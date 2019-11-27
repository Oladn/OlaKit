using Ola;
using Ola.Extensions.Identity;

namespace OlaKit.Extensions.Security
{
    /// <summary>
    /// 角色管理。
    /// </summary>
    public interface IRoleManager : IRoleManager<Role, UserRole, RoleClaim>, IScopedService
    {

    }
}