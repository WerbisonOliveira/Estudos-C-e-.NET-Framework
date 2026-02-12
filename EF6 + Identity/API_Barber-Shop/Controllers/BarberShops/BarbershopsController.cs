using API_Barber_Shop.DTOs.Disableaccount;
using API_Barber_Shop.Models.Entities;
using API_Barber_Shop.Repositories;
using API_Barber_Shop.Filters;
using System;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;


namespace API_Barber_Shop.Controllers.BarberShops
{
    [AuthorizeAdmin(Roles = "Admin")]
    [RoutePrefix("api/barbershops")]
    public class BarbershopsController : ApiController
    {
        private readonly BarbershopRepository barbershopRepo;
        private readonly ClientsRepository clientRepo;
        private readonly AccountsClientsRepository clientAccountRepo;
        public BarbershopsController()
        {
            barbershopRepo = new BarbershopRepository();
            clientRepo = new ClientsRepository();
            clientAccountRepo = new AccountsClientsRepository();
        }

        [HttpGet]
        [Route("allclients")]
        public async Task<IHttpActionResult> GetAllClients()
        {
            try
            {
                return Ok(await clientRepo.GetAllAsync());
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [HttpGet]
        [Route("client/{id:int}")]
        public async Task<IHttpActionResult> GetClient(int id)
        {
            try
            {
                var client = await clientRepo.GetByIdAsync(id);

                if (client == null)
                    return Content(HttpStatusCode.NotFound, new {message = "Conta não encontrada"});

                return Ok(client);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [HttpGet]
        [Route("allbarbershops")]
        public async Task<IHttpActionResult> GetAllBarbershops()
        {
            try
            {
                return Ok(await barbershopRepo.GetAllAsync());
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [HttpGet]
        [Route("barbershop/{id:int}")]
        public async Task<IHttpActionResult> GetBarbershop(int id)
        {
            try
            {
                var client = await barbershopRepo.GetByIdAsync(id);

                if (client == null)
                    return Content(HttpStatusCode.NotFound, new {message = "Conta não encontrada"});

                return Ok(client);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [HttpPut]
        [Route("barbershop/{id:int}")]
        public async Task<IHttpActionResult> UpdateName(int id, [FromBody]Barbershop barbershop)
        {
            if (barbershop == null)
                return BadRequest();

            if (id != barbershop.Id)
                return BadRequest("O id do endpoint é diferente do id do objeto enviado");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                bool result = await barbershopRepo.UpdateAsync(barbershop);

                if (!result)
                    return Content(HttpStatusCode.NotFound, new {message = "Conta não encontrada"});

                return Content(HttpStatusCode.OK, new {message = "Nome da barbearia atualizado com sucesso"});
            }
            catch (DbUpdateConcurrencyException)
            {
                return InternalServerError();
            }
        }

        [HttpPut]
        [Route("update/disableaccount")]
        public async Task<IHttpActionResult> UpdateActive([FromBody]DisableAccountClient client)
        {
            if (client == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await clientAccountRepo.UpdateUserAsync(client.Id, client.Active);

                if (result == null)
                    return Content(HttpStatusCode.NotFound, new {message = "Conta não encontrada"});

                return Content(HttpStatusCode.OK, client.Active ? new {message = "Conta ativada com sucesso"} : new {message = "Conta desativada com sucesso"});
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
                barbershopRepo.Dispose();
                clientRepo.Dispose();
                clientAccountRepo.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
