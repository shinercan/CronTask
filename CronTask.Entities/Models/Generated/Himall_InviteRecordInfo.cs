
//-----------------------------------------------------------------------
// <copyright file=" Himall_InviteRecord.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_InviteRecord.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_InviteRecord Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_InviteRecordInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
    
        /// <summary>
        /// 邀请的用户
        /// </summary>
        public string RegName { get; set; }
    
        /// <summary>
        /// 邀请获得的积分
        /// </summary>
        public int InviteIntegral { get; set; }
    
        /// <summary>
        /// 被邀请获得的积分
        /// </summary>
        public int RegIntegral { get; set; }
    
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegTime { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        public bigint UserId { get; set; }
    
        /// <summary>
        /// 被邀请的用户ID
        /// </summary>
        public bigint RegUserId { get; set; }
    
        /// <summary>
        /// 获得积分时间
        /// </summary>
        public DateTime RecordTime { get; set; }

    }
}
