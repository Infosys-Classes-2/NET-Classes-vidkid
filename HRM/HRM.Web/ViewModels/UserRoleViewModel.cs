using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Core.Types;

namespace HRM.Web.ViewModels
{
    public class UserRoleViewModel
    {
        public string UserId { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }
        public List<RoleItem> Roles { get; set; }
    }
    public class RoleItem
    { 
        public string Value { get; set; }
        public bool IsSelected { get; set; }
    }

}
