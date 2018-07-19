
//-----------------------------------------------------------------------
// <copyright file=" Himall_StatisticOrderComments.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_StatisticOrderComments.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_StatisticOrderComments Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_StatisticOrderCommentsInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public bigint ShopId { get; set; }
    
        /// <summary>
        /// 评价的枚举（宝贝与描述相符 商家得分）
        /// </summary>
        public int CommentKey { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public decimal CommentValue { get; set; }

    }
}