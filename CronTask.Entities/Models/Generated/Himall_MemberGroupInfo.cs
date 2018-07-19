
//-----------------------------------------------------------------------
// <copyright file=" Himall_MemberGroup.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_MemberGroup.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_MemberGroup Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_MemberGroupInfo
    {
        /// <summary>
        /// Id
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 门店编号
        /// </summary>
        public bigint ShopId { get; set; }
    
        /// <summary>
        /// 统计类型
        /// </summary>
        public int StatisticsType { get; set; }
    
        /// <summary>
        /// 统计数量
        /// </summary>
        public int Total { get; set; }

    }
}
