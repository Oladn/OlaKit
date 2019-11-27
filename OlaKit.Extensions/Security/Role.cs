using Ola.Extensions;
using Ola.Extensions.Identity;

namespace OlaKit.Extensions.Security
{
    /// <summary>
    /// 角色表。
    /// </summary>

    public class Role : RoleBase
    {
        /// <summary>
        /// 颜色。
        /// </summary>
        [Size(20)]
        public string Color { get; set; }

        /// <summary>
        /// 图标。
        /// </summary>
        [Size(200)]
        public string Icon { get; set; }
    }
}