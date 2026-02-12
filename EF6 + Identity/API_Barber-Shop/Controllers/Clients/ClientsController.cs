using API_Barber_Shop.Models.Entities;
using API_Barber_Shop.Repositories;
using System;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace API_Barber_Shop.Controllers.Clients
{
    [Authorize(Roles = "Client")]
    [RoutePrefix("api/clients")]
    public class ClientsController : ApiController
    {
        private readonly ClientsRepository clientRepo;
        public ClientsController() 
        {
            clientRepo = new ClientsRepository();
        }

        [HttpPut]
        [Route("client/{id:int}")]
        public async Task<IHttpActionResult> UpdateName(int id, [FromBody]Client client)
        {
            if (client == null)
                return BadRequest();

            if (id != client.Id)
                return BadRequest("O id do endpoint é diferente do id do objeto enviado");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                bool result = await clientRepo.UpdateAsync(client);

                if (!result)
                    return Content(HttpStatusCode.NotFound, new {message = "Conta não encontrada"});

                return Content(HttpStatusCode.OK, new {message = "Nome atualizado com sucesso"});
            }
            catch (DbUpdateConcurrencyException)
            {
                return InternalServerError();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                clientRepo.Dispose();

            base.Dispose();
        }

    }
}
