using Ola.Data.Migrations.Builders;
using Ola.Extensions.Identity;

namespace OlaKit.Extensions.Security
{
    /// <summary>
    /// 数据库迁移类。
    /// </summary>
    public class SecurityDataMigration : IdentityDataMigration<User, Role, UserClaim, RoleClaim, UserLogin, UserRole, UserToken>
    {
        /// <summary>
        /// 添加用户定义列。
        /// </summary>
        /// <param name="builder">用户表格定义实例。</param>
        protected override void Create(CreateTableBuilder<User> builder)
        {
            builder.Column(x => x.Amount)
                .Column(x => x.LockedAmount)
                .Column(x => x.Score)
                .Column(x => x.LockedScore)
                .Column(x => x.ParentId);
        }
    }
}