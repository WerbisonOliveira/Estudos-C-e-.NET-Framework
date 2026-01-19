using System;
using System.Configuration;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using web_api.Models;

namespace web_api.Controllers
{
    [RoutePrefix("api/usuarios")]
    public class UsuariosController : ApiController
    {
        private Tools.Logger logger;
        private Repositories.Usuario user;

        public UsuariosController()
        {
            logger = new Tools.Logger(ConfigurationManager.AppSettings["PathLog"]);
            user = new Repositories.Usuario(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        }

        //POST: api/usuarios/register
        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        public async Task<IHttpActionResult> Register([FromBody]Usuario usuario)
        {
            if (usuario == null)
                return BadRequest("Preencha todos os campos!");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await user.RegisterAsync(usuario);
                return Content(HttpStatusCode.Created, true);
            }
            catch (Exception ex)
            {
                logger.log(ex);
                return InternalServerError();
            }
        }

        //POST: api/usuarios/login
        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public async Task<IHttpActionResult> Login([FromBody]Usuario usuario)
        {
            if (usuario == null)
                return BadRequest();

            try
            {
                var auth = await user.FindUserAsync(usuario.Email, usuario.Senha);

                if (auth == null)
                    return NotFound();

                return Ok(auth);
            }
            catch (Exception ex)
            {
                logger.log(ex);
                return InternalServerError();
            }
        }

    }
}
