﻿using System;
using Microsoft.AspNetCore.Html;
using Ola;

namespace OlaKit.Extensions
{
    /// <summary>
    /// 网站配置。
    /// </summary>
    public class SiteSettings
    {
        /// <summary>
        /// 网站名称。
        /// </summary>
        public string SiteName { get; set; } = "OlaKit";

        /// <summary>
        /// 简称。
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Logo地址。
        /// </summary>
        public string LogoUrl { get; set; } = "/images/logo.png";

        /// <summary>
        /// 描述。
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 版权信息。
        /// </summary>
        public string Copyright { get; set; } = "Copyright &copy;$year OlaKit ver $version";

        /// <summary>
        /// 版权信息。
        /// </summary>
        public IHtmlContent CopyrightHTML => new HtmlString(Copyright.Replace("$version", Cores.Version.ToString(3)).Replace("$year", DateTime.Now.Year.ToString()));
    }
}