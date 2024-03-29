﻿using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Ola;
using Ola.Extensions.Identity;

namespace OlaKit.Extensions.Security
{
    /// <summary>
    /// 服务配置。
    /// </summary>
    public class ServiceConfigurer : ServiceConfigurer<User, Role, UserStore, RoleStore, UserManager, RoleManager>
    {
        /// <summary>
        /// 配置服务。
        /// </summary>
        /// <param name="builder">容器构建实例。</param>
        protected override void ConfigureSecurityServices(IOlaBuilder builder)
        {
            builder.AddServices(services =>
            {
                services.Configure<IdentityOptions>(options =>
                {
                    //锁定配置
                    options.Lockout = new LockoutOptions
                    {
                        AllowedForNewUsers = true,
                        DefaultLockoutTimeSpan = TimeSpan.FromHours(1),
                        MaxFailedAccessAttempts = 5
                    };
                    //用户配置
                    options.User = new UserOptions
                    {
                        AllowedUserNameCharacters = null,
                        RequireUniqueEmail = false
                    };
                    //需要激活电子邮件
                    options.SignIn.RequireConfirmedEmail = false;
                })
                .AddScoped(service => service.GetRequiredService<IUserManager>().GetUser() ?? _anonymous);
            });
        }

        private static readonly User _anonymous = new User { UserName = "Anonymous" };
    }
}