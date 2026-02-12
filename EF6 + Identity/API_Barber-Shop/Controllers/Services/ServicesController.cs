using API_Barber_Shop.DTOs.Update;
using API_Barber_Shop.Models.Entities;
using API_Barber_Shop.Models.Enums;
using API_Barber_Shop.Repositories;
using System;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using API_Barber_Shop.Filters;

namespace API_Barber_Shop.Controllers.Services
{
    [AuthorizeAdmin(Roles = "Admin")]
    [RoutePrefix("api/services")]
    public class ServicesController : ApiController
    {
        private readonly ServicesRepository serviceRepo;

        public ServicesController()
        {
            serviceRepo = new ServicesRepository();
        }

        [Authorize]
        [HttpGet]
        [Route("allservices")]
        public async Task<IHttpActionResult> GetAll()
        {
            try
            {
                return Ok(await serviceRepo.GetAllAsync());
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [Route("{id:int}")]
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                Service service = await serviceRepo.GetAsync(id);

                if (service == null)
                {
                    return Content(HttpStatusCode.NotFound, new {message = "Serviço não encontrado"});
                }

                return Ok(service);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [HttpPost]
        [Route("create")]
        public async Task<IHttpActionResult> Create([FromBody]Service service)
        {
            if (service == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await serviceRepo.CreateAsync(service);

                return Content(HttpStatusCode.Created, new {message = "Serviço criado com sucesso"});
            }
            catch (Exception)
            {
                return InternalServerError();
            }
          
        }

        [HttpPut]
        [Route("updateall/{id:int}")]
        public async Task<IHttpActionResult> Update(int id, [FromBody]Service service)
        {
            if (service == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != service.Id)
                return BadRequest("O id do endpoint é diferente do id enviado no objeto da requisição");

            try
            {
                bool result = await serviceRepo.UpdateAsync(service);

                if (!result)
                    return Content(HttpStatusCode.NotFound, new {message = "Serviço não encontrado"});

                return Ok(new {message = "Serviço atualizado com sucesso"});
            }
            catch (DbUpdateConcurrencyException)
            {
                return InternalServerError();
            }

        }


        [HttpPatch]
        [Route("update/{id:int}")]
        public async Task<IHttpActionResult> Patch(int id, [FromBody]UpdateServiceDTO service)
        {
            if (service == null)
                return BadRequest();

            if (service.Status.HasValue && !Enum.IsDefined(typeof(StatusServices), service.Status))
                return BadRequest("O valor do campo status é inválido");

            if (service.Id != id)
                return BadRequest("O id do endpoint é diferente do id enviado no objeto da requisição");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                Service result = await serviceRepo.PatchAsync(service);

                if (result == null)
                    return Content(HttpStatusCode.NotFound, new {message = "Serviço não encontrado"});

                return Ok(new {message = "Serviço atualizado com sucesso"});
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [Route("delete/{id:int}")]
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                Service service = await serviceRepo.DeleteAsync(id);

                if (service == null)
                {
                    return Content(HttpStatusCode.NotFound, new {message = "Serviço não encontrado"});
                }

                return Ok(new {message = "Serviço excluído com sucesso"});
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                serviceRepo.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}