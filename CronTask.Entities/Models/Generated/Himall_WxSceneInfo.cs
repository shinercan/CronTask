
//-----------------------------------------------------------------------
// <copyright file=" Himall_WxScene.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_WxScene.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_WxScene Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_WxSceneInfo
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
        /// 
        /// </summary>
        public bigint ShopBranchId { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public int QRSCENEType { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public int SceneId { get; set; }

    }
}