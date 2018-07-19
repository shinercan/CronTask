
//-----------------------------------------------------------------------
// <copyright file=" Himall_IntegralProductSkus.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_IntegralProductSkus.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_IntegralProductSkus Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_IntegralProductSkusInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string SkuId { get; set; }
    
        /// <summary>
        /// 所需积分
        /// </summary>
        public int Integrals { get; set; }
    
        /// <summary>
        /// 库存
        /// </summary>
        public int Stock { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public bigint IntegralProductId { get; set; }

    }
}
