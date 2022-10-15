using Abp.Authorization;
using coresolution.Authorization.Roles;
using coresolution.Authorization.Users;

namespace coresolution.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
