using Microsoft.Extensions.DependencyInjection;
using Ola;
using Ola.Extensions;

namespace OlaKit.Extensions
{
    /// <summary>
    /// 服务注册。
    /// </summary>
    public class ServiceConfigurer : IServiceConfigurer
    {
        /// <summary>
        /// 配置服务方法。
        /// </summary>
        /// <param name="builder">容器构建实例。</param>
        public void ConfigureServices(IOlaBuilder builder)
        {
            builder.AddServices(services =>
                services.AddScoped(s => s.GetRequiredService<ISettingsManager>().GetSettings<SiteSettings>()));
        }
    }
}