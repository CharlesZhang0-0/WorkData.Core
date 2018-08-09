﻿// ------------------------------------------------------------------------------
// Copyright  吴来伟个人 版权所有。
// 项目名：WorkData.Web
// 文件名：WorkDataBaseApiController.cs
// 创建标识：吴来伟 2018-05-28 11:33
// 创建描述：
//
// 修改标识：吴来伟2018-06-11 15:32
// 修改描述：
//  ------------------------------------------------------------------------------

#region

using Microsoft.AspNetCore.Mvc;
using WorkData.Dependency;
using WorkData.Domain.EntityFramework.EntityFramework.Sessions;

#endregion

namespace WorkData.Web.Extensions.Infrastructure
{
    public class WorkDataBaseController : Controller
    {
        /// <summary>
        /// WorkDataSession
        /// </summary>s
        public IWorkDataSessionExtension WorkDataSession { get; set; } =
            IocManager.Instance.Resolve<IWorkDataSessionExtension>();
    }
}