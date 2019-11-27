using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Ola;
using Ola.Extensions.Identity;
using Ola.Extensions.Storages;

namespace OlaKit.Extensions.Security
{
    /// <summary>
    /// 用户管理接口。
    /// </summary>
    public interface IUserManager : IUserManager<User, Role>, IScopedService
    {
        /// <summary>
        /// 上传头像。
        /// </summary>
        /// <param name="file">上传的文件实例对象。</param>
        /// <param name="id">用户Id。</param>
        /// <returns>返回上传结果。</returns>
        Task<MediaResult> UploadAvatarAsync(IFormFile file, int id);
    }
}