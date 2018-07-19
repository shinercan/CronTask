
//-----------------------------------------------------------------------
// <copyright file=" Himall_OpenIds.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_OpenIds.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_OpenIds Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_OpenIdsInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string OpenId { get; set; }
    
        /// <summary>
        /// 关注时间
        /// </summary>
        public DateTime SubscribeTime { get; set; }
    
        /// <summary>
        /// 是否关注
        /// </summary>
        public int IsSubscribe { get; set; }

    }
}
