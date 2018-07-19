
//-----------------------------------------------------------------------
// <copyright file=" Himall_RegionHelper.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_RegionHelper.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_RegionHelper Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_RegionHelperInfo
    {
        /// <summary>
        /// 街道ID
        /// </summary>

        public int StreetRegionId { get; set; }
    
        /// <summary>
        /// 区域Id
        /// </summary>
        public int AreaRegionId { get; set; }
    
        /// <summary>
        /// 市Id
        /// </summary>
        public int CityRegionId { get; set; }
    
        /// <summary>
        /// 省Id
        /// </summary>
        public int ProviceRegionId { get; set; }

    }
}