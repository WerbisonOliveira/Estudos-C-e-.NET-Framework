using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Net;

namespace API_Barber_Shop.Filters
{
    public class AuthorizeAdmin : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            if (actionContext.RequestContext.Principal.Identity.IsAuthenticated)
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Forbidden, new {message = "Usuário sem permissão"});
            else
                base.HandleUnauthorizedRequest(actionContext);
        }
    }
}