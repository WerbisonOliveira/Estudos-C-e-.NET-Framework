using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using API_Barber_Shop.DTOs.Update;
using API_Barber_Shop.Models.Entities;
using API_Barber_Shop.Repositories;
using API_Barber_Shop.Filters;

namespace API_Barber_Shop.Controllers.Schedulings
{
    [RoutePrefix("api/scheduling")]
    public class SchedulingsController : ApiController
    {
        private readonly SchedulingRepository schedulingRepo;
        private readonly SchedulingServiceRepository schedulingServiceRepo;

        public SchedulingsController()
        {
            schedulingRepo = new SchedulingRepository();
            schedulingServiceRepo = new SchedulingServiceRepository();
        }


        [HttpGet]
        [AuthorizeAdmin(Roles = "Admin")]
        [Route("allschedulings")]
        public async Task<IHttpActionResult> GetAll()
        {
            try
            {
                return Ok(await schedulingRepo.GetAllAsync());
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [HttpGet]
        [Authorize(Roles = "Client")]
        [Route("client/{clientId:int}")]
        public async Task<IHttpActionResult> GetSchedulingsClient(string clientId)
        {
            try
            {
                return Ok(await schedulingRepo.GetSchedulingClient(clientId));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [AuthorizeAdmin(Roles = "Admin")]
        [Route("{id:int}")]
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                var scheduling = await schedulingRepo.GetAsync(id);

                if (scheduling == null)
                    return Content(HttpStatusCode.NotFound, new {message = "Agendamento não encontrado"});

                return Ok(scheduling);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [HttpPost]
        [Authorize(Roles = "Client")]
        [Route("create")]
        public async Task<IHttpActionResult> Create([FromBody]Scheduling scheduling)
        {
            if (scheduling == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                Scheduling result = await schedulingRepo.CreateAsync(scheduling);

                foreach (var schedulingservice in scheduling.ServicesId)
                {
                    SchedulingService schedulingService = new SchedulingService() 
                    {
                        SchedulingId = result.Id,
                        ServiceId = schedulingservice
                    };
                    await schedulingServiceRepo.Create(schedulingService);
                }

                return Content(HttpStatusCode.Created, new {message = "Agendamento realizado com sucesso"});
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [HttpPatch]
        [Authorize(Roles = "Client")]
        [Route("update/{id:int}")]
        public async Task<IHttpActionResult> Patch(int id, [FromBody] UpdateSchedulingDTO scheduling)
        {
            if (scheduling == null)
                return BadRequest();

            if (scheduling.Id != id)
                return BadRequest("O id do endpoint é diferente do id enviado no objeto da requisição");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (scheduling.ServicesId.Count == 0)
                return BadRequest();

            if (!scheduling.DataeHora.HasValue || !scheduling.ValorTotal.HasValue)
                return BadRequest();

            try
            {
                var result = await schedulingRepo.PatchAsync(scheduling);

                if (result == null)
                    return Content(HttpStatusCode.NotFound, new {message = "Agendamento não encontrado"});

                return Ok(new {message = "Agendamento atualizado com sucesso"});
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [AuthorizeAdmin(Roles = "Admin")]
        [Route("delete/{id:int}")]
        public async Task<IHttpActionResult> Delete(int id)
        {
            Scheduling scheduling = await schedulingRepo.DeleteAsync(id);

            if (scheduling == null)
                return Content(HttpStatusCode.NotFound, new {message = "Agendamento não encontrado"});
           
            return Ok(new {message = "Agendamento excluído com sucesso"});
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                schedulingRepo.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}