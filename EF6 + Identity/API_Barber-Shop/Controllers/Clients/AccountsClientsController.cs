using API_Barber_Shop.DTOs.Register;
using API_Barber_Shop.Repositories;
using Microsoft.AspNet.Identity;
using API_Barber_Shop.Models.Entities;
using API_Barber_Shop.DTOs.Delete;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net;
using API_Barber_Shop.DTOs.Update;

namespace API_Barber_Shop.Controllers.Clients
{
    [RoutePrefix("api/accountclients")]
    [Authorize(Roles = "Client")]
    public class AccountsClientsController : ApiController
    {
        private readonly AccountsClientsRepository clientAccountRepo;
        private readonly ClientsRepository clientRepo;
        public AccountsClientsController() 
        {
            clientAccountRepo = new AccountsClientsRepository();
            clientRepo = new ClientsRepository();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        public async Task<IHttpActionResult> Register(ClientDTO clientDTO)
        {
            if (clientDTO == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                IdentityResult result = await clientAccountRepo.RegisterAsync(clientDTO);

                IHttpActionResult error = GetErrorResult(result);

                if (error != null)
                    return error;

                var user = await clientAccountRepo.FindUserAsync(clientDTO.Email, clientDTO.Senha);

                Client client = new Client()
                {
                    Nome = clientDTO.Nome,
                    IdentityUserId = user.Id
                };

                await clientRepo.CreateAsync(client);

                return Content(HttpStatusCode.Created, new {message = "Conta criada com sucesso"});
            }
            catch (Exception)
            {
                return InternalServerError();
            }
            
        }

        [HttpPut]
        [Route("update/email")]
        public async Task<IHttpActionResult> UpdateEmail([FromBody]UpdateClientDTO client)
        {
            if (client == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (client.Email == null || client.Email == "")
                return BadRequest("O campo Email é obrigatório");

            try
            {
                var result = await clientAccountRepo.UpdateUserAsync(client.Id, client.Email);

                if (result == null)
                    return Content(HttpStatusCode.NotFound, new {message = "Conta não encontrada"});

                return Ok(new {message = "Email atualizado com sucesso"});
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [HttpPut]
        [Route("update/senha")]
        public async Task<IHttpActionResult> UpdatePassWord([FromBody] UpdateClientDTO client)
        {
            if (client == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (client.Senha == null || client.Senha == "")
                return BadRequest("O campo Senha Atual é obrigatório");

            if (client.SenhaNova == null || client.SenhaNova == "")
                return BadRequest("O campo Senha Nova é obrigatório");

            try
            {
                var result = await clientAccountRepo.UpdatePassWordAsync(client.Id.ToString(), client.Senha, client.SenhaNova);

                if (result == null)
                    return Content(HttpStatusCode.NotFound, new {message = "Conta não encontrada"});

                return Ok(new {message = "Senha atualizada com sucesso"});
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [HttpDelete]
        [Route("deleteaccount")]
        public async Task<IHttpActionResult> DeleteAccount([FromBody] 
        DeleteClientDTO client)
        {
            if (client == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {      
                var result = await clientAccountRepo.DeleteUserAsync(client.Email);

                if (result == null)
                    return Content(HttpStatusCode.NotFound, new {message = "Conta não encontrada"});

                return Ok(new {message = "Conta excluída com sucesso"});
            }
            catch (Exception)
            { 
                return InternalServerError();
            }
        }

        private IHttpActionResult GetErrorResult(IdentityResult resultado)
        {
            if (resultado == null)
                return InternalServerError();

            if (!resultado.Succeeded)
            {
                if (resultado.Errors != null)
                {
                    foreach (string error in resultado.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                    return BadRequest();

                return BadRequest(ModelState);
            }

            return null;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                clientAccountRepo.Dispose();
                clientRepo.Dispose();
            }
                
            base.Dispose(disposing);
        }

    }
}
