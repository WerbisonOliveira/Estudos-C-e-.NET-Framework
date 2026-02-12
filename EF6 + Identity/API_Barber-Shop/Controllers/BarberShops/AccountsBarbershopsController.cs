using API_Barber_Shop.DTOs.Delete;
using API_Barber_Shop.DTOs.Register;
using API_Barber_Shop.DTOs.Update;
using API_Barber_Shop.Models.Entities;
using API_Barber_Shop.Repositories;
using API_Barber_Shop.Filters;
using Microsoft.AspNet.Identity;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;


namespace API_Barber_Shop.Controllers.BarberShops
{
    [RoutePrefix("api/accountbarbershop")]
    [AuthorizeAdmin(Roles = "Admin")]
    public class AccountsBarbershopsController : ApiController
    {
        private readonly AccountsBarbershopsRepository barbershopAccountRepo;
        private readonly BarbershopRepository barbershopRepo;
        public AccountsBarbershopsController()
        {
            barbershopAccountRepo = new AccountsBarbershopsRepository();
            barbershopRepo = new BarbershopRepository();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        public async Task<IHttpActionResult> Register(BarbershopDTO barbershopDTO)
        {
            if (barbershopDTO == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                IdentityResult result = await barbershopAccountRepo.RegisterAsync(barbershopDTO);

                IHttpActionResult error = GetErrorResult(result);

                if (error != null)
                    return error;

                var Barbershop = await barbershopAccountRepo.FindBarbershopAsync(barbershopDTO.CNPJ, barbershopDTO.Senha);

                Barbershop barbershop = new Barbershop()
                {
                    Nome = barbershopDTO.Nome,
                    IdentityUserId = Barbershop.Id
                };

                await barbershopRepo.CreateAsync(barbershop);

                return Content(HttpStatusCode.Created, new {message = "Conta criada com sucesso"});
            }
            catch (Exception)
            {
                return InternalServerError();
            }

        }

        [HttpPut]
        [Route("update/cnpj")]
        public async Task<IHttpActionResult> UpdateCNPJ([FromBody] UpdateBarbershopDTO barbershop)
        {
            if (barbershop == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (barbershop.CNPJ == null || barbershop.CNPJ == "")
                return BadRequest("O campo CNPJ é obrigatório");

            try
            {
                var result = await barbershopAccountRepo.UpdateBarbershopAsync(barbershop.Id, barbershop.CNPJ);

                if (result == null)
                    return Content(HttpStatusCode.NotFound, new {message = "Conta não encontrada"});

                return Ok(new {message = "CNPJ atualizado com sucesso"});
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [HttpPut]
        [Route("update/senha")]
        public async Task<IHttpActionResult> UpdatePassWord([FromBody] UpdateBarbershopDTO barbershop)
        {
            if (barbershop == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (barbershop.Senha == null || barbershop.Senha == "")
                return BadRequest("O campo Senha Atual é obrigatório");

            if (barbershop.SenhaNova == null || barbershop.SenhaNova == "")
                return BadRequest("O campo Senha Nova é obrigatório");

            try
            {
                var result = await barbershopAccountRepo.UpdatePassWordAsync(barbershop.Id, barbershop.Senha, barbershop.SenhaNova);

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
    DeleteBarbershopDTO barbershop)
        {
            if (barbershop == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await barbershopAccountRepo.DeleteBarbershopAsync(barbershop.CNPJ);

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
                barbershopAccountRepo.Dispose();
                barbershopRepo.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
