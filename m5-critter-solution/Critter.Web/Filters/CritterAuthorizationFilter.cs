using Critter.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Critter.Web.Filters
{
    public class CritterAuthorizationFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            // Check to see if we have a username in the url
            if (filterContext.ActionParameters.ContainsKey("username") || filterContext.ActionParameters.ContainsKey("forUser"))
            {

                //gets the username from the url
                var impliedUsername = GetImpliedUsername(filterContext);
                var controller = (CritterController)filterContext.Controller;
                var actualUsername = controller.CurrentUser;

                // If the user is not logged in, then take them to the login page
                if (!controller.IsAuthenticated)
                {
                    // then redirect to login page
                    controller.Session["landingPage"] = filterContext.HttpContext.Request.Url;
                    var routeValue = new RouteValueDictionary(new
                    {
                        controller = "Users",
                        action = "Login",
                        landingPage = filterContext.HttpContext.Request.Url
                    });
                    filterContext.Result = new RedirectToRouteResult(routeValue);
                }
                else
                {
                    if (impliedUsername.ToLower() != actualUsername.ToLower()) //They're liars
                    {
                        filterContext.Result = new HttpStatusCodeResult(403);
                    }
                }

            }




            base.OnActionExecuting(filterContext);
        }

        private static string GetImpliedUsername(ActionExecutingContext filterContext)
        {
            if (filterContext.ActionParameters.ContainsKey("username"))
            {
                return (string)filterContext.ActionParameters["username"];
            }
            else
            {
                return (string)filterContext.ActionParameters["forUser"];
            }
            
        }
    }

}