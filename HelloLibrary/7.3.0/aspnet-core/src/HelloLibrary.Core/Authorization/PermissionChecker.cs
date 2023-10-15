using Abp.Authorization;
using HelloLibrary.Authorization.Roles;
using HelloLibrary.Authorization.Users;

namespace HelloLibrary.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
