using System.Linq;
using System.Net.Http;
using System.Collections.Generic;
using Chris.SPA.SPA_Template.Services.ViewModels;
using DotNetNuke.Web.Api;
using DotNetNuke.Security;
using DotNetNuke.Entities.Users;

namespace Chris.SPA.SPA_Template.Services
{
    [SupportedModules("SPA_Template")]
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Edit)]
    public class UserController : DnnApiController
    {
        public UserController() { }

        public HttpResponseMessage GetList()
        {

            var userlist = DotNetNuke.Entities.Users.UserController.GetUsers(this.PortalSettings.PortalId);
            var users = userlist.Cast<UserInfo>().ToList()
                   .Select(user => new UserViewModel(user))
                   .ToList();

            return Request.CreateResponse(users);
        }
    }
}
