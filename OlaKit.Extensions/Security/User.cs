using Ola.Extensions.Identity;

namespace OlaKit.Extensions.Security
{
    /// <summary>
    /// 用户实体表。
    /// </summary>
    public class User : UserBase
    {
        /// <summary>
        /// 金额。
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 锁定金额。
        /// </summary>
        public decimal LockedAmount { get; set; }

        /// <summary>
        /// 积分。
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// 锁定积分。
        /// </summary>
        public int LockedScore { get; set; }

        /// <summary>
        /// 推荐人Id。
        /// </summary>
        public int ParentId { get; set; }
    }
}