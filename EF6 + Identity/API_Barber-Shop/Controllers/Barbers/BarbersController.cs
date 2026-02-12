using API_Barber_Shop.DTOs.Update;
using API_Barber_Shop.Models.Entities;
using API_Barber_Shop.Models.Enums;
using API_Barber_Shop.Repositories;
using System;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Routing;
using API_Barber_Shop.Filters;

namespace API_Barber_Shop.Controllers.Barbers
{
    [AuthorizeAdmin(Roles = "Admin")]
    [RoutePrefix("api/barbers")]
    public class BarbersController : ApiController
    {
        private readonly BarbersRepository barberRepo;

        public BarbersController()
        {
            barberRepo = new BarbersRepository();
        }

        [HttpGet]
        [Authorize]
        [Route("allbarbers")]
        public async Task<IHttpActionResult> GetAll()
        {
            try
            {
                return Ok(await barberRepo.GetAllAsync());
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
                Barber barber = await barberRepo.GetAsync(id);

                if (barber == null)
                {
                    return Content(HttpStatusCode.NotFound, new {message = "Barbeiro não encontrado"});
                }

                return Ok(barber);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [HttpPost]
        [Route("create")]
        public async Task<IHttpActionResult> Create([FromBody] Barber barber)
        {
            if (barber == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await barberRepo.CreateAsync(barber);
                return Content(HttpStatusCode.Created, new {message = "Barbeiro adicionado com sucesso"});
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [HttpPut]
        [Route("updateall/{id:int}")]
        public async Task<IHttpActionResult> Update(int id, [FromBody]Barber barber)
        {
            if (barber == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != barber.Id)
                return BadRequest("O id do endpoint é diferente do id enviado no objeto da requisição");

            try
            {
                var result = await barberRepo.UpdateAsync(barber);

                if (!result)
                    return Content(HttpStatusCode.NotFound, new {message = "Barbeiro não encontrado"});

                return Ok(new {message = "Barbeiro atualizado com sucesso"});
            }
            catch (DbUpdateConcurrencyException)
            {
                return InternalServerError();
            }
        }

        [HttpPatch]
        [Route("update/{id:int}")]
        public async Task<IHttpActionResult> Patch(int id, [FromBody]UpdateBarberDTO barber)
        {
            if (barber == null)
                return BadRequest();

            if (barber.Status.HasValue && !Enum.IsDefined(typeof(StatusServices), barber.Status))
                return BadRequest("O valor do campo status é inválido");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != barber.Id)
                return BadRequest("O id do endpoint é diferente do enviado no objeto da requisição");

            try
            {
                var result = await barberRepo.PatchAsync(barber);

                if (result == null)
                    return Content(HttpStatusCode.NotFound, new {message = "Barbeiro não encontrado"});

                return Ok(new {message = "Barbeiro atualizado com sucesso"});
            }
            catch (DbUpdateConcurrencyException)
            {
                return InternalServerError();
            }
        }


        [Route("delete/{id:int}")]
        public async Task<IHttpActionResult> Delete(int id)
        {
            Barber barber = await barberRepo.DeleteAsync(id);

            if (barber == null)
            {
                return Content(HttpStatusCode.NotFound, new {message = "Barbeiro não encontrado"});
            }

            return Ok(new {message = "Barbeiro excluído com sucesso"});
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                barberRepo.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}