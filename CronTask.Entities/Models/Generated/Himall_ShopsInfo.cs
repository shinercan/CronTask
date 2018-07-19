
//-----------------------------------------------------------------------
// <copyright file=" Himall_Shops.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_Shops.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_Shops Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_ShopsInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 店铺等级
        /// </summary>
        public bigint GradeId { get; set; }
    
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName { get; set; }
    
        /// <summary>
        /// 店铺LOGO路径
        /// </summary>
        public string Logo { get; set; }
    
        /// <summary>
        /// 预留子域名，未使用
        /// </summary>
        public string SubDomains { get; set; }
    
        /// <summary>
        /// 预留主题，未使用
        /// </summary>
        public string Theme { get; set; }
    
        /// <summary>
        /// 是否是官方自营店
        /// </summary>
        public int IsSelf { get; set; }
    
        /// <summary>
        /// 店铺状态
        /// </summary>
        public int ShopStatus { get; set; }
    
        /// <summary>
        /// 审核拒绝原因
        /// </summary>
        public string RefuseReason { get; set; }
    
        /// <summary>
        /// 店铺创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }
    
        /// <summary>
        /// 店铺过期日期
        /// </summary>
        public DateTime EndDate { get; set; }
    
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }
    
        /// <summary>
        /// 公司省市区
        /// </summary>
        public int CompanyRegionId { get; set; }
    
        /// <summary>
        /// 公司地址
        /// </summary>
        public string CompanyAddress { get; set; }
    
        /// <summary>
        /// 公司电话
        /// </summary>
        public string CompanyPhone { get; set; }
    
        /// <summary>
        /// 公司员工数量
        /// </summary>
        public int CompanyEmployeeCount { get; set; }
    
        /// <summary>
        /// 公司注册资金
        /// </summary>
        public decimal CompanyRegisteredCapital { get; set; }
    
        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string ContactsName { get; set; }
    
        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContactsPhone { get; set; }
    
        /// <summary>
        /// 联系Email
        /// </summary>
        public string ContactsEmail { get; set; }
    
        /// <summary>
        /// 营业执照号
        /// </summary>
        public string BusinessLicenceNumber { get; set; }
    
        /// <summary>
        /// 营业执照
        /// </summary>
        public string BusinessLicenceNumberPhoto { get; set; }
    
        /// <summary>
        /// 营业执照所在地
        /// </summary>
        public int BusinessLicenceRegionId { get; set; }
    
        /// <summary>
        /// 营业执照有效期开始
        /// </summary>
        public DateTime BusinessLicenceStart { get; set; }
    
        /// <summary>
        /// 营业执照有效期
        /// </summary>
        public DateTime BusinessLicenceEnd { get; set; }
    
        /// <summary>
        /// 法定经营范围
        /// </summary>
        public string BusinessSphere { get; set; }
    
        /// <summary>
        /// 组织机构代码
        /// </summary>
        public string OrganizationCode { get; set; }
    
        /// <summary>
        /// 组织机构执照
        /// </summary>
        public string OrganizationCodePhoto { get; set; }
    
        /// <summary>
        /// 一般纳税人证明
        /// </summary>
        public string GeneralTaxpayerPhot { get; set; }
    
        /// <summary>
        /// 银行开户名
        /// </summary>
        public string BankAccountName { get; set; }
    
        /// <summary>
        /// 公司银行账号
        /// </summary>
        public string BankAccountNumber { get; set; }
    
        /// <summary>
        /// 开户银行支行名称
        /// </summary>
        public string BankName { get; set; }
    
        /// <summary>
        /// 支行联行号
        /// </summary>
        public string BankCode { get; set; }
    
        /// <summary>
        /// 开户银行所在地
        /// </summary>
        public int BankRegionId { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string BankPhoto { get; set; }
    
        /// <summary>
        /// 税务登记证
        /// </summary>
        public string TaxRegistrationCertificate { get; set; }
    
        /// <summary>
        /// 税务登记证号
        /// </summary>
        public string TaxpayerId { get; set; }
    
        /// <summary>
        /// 纳税人识别号
        /// </summary>
        public string TaxRegistrationCertificatePhoto { get; set; }
    
        /// <summary>
        /// 支付凭证
        /// </summary>
        public string PayPhoto { get; set; }
    
        /// <summary>
        /// 支付注释
        /// </summary>
        public string PayRemark { get; set; }
    
        /// <summary>
        /// 商家发货人名称
        /// </summary>
        public string SenderName { get; set; }
    
        /// <summary>
        /// 商家发货人地址
        /// </summary>
        public string SenderAddress { get; set; }
    
        /// <summary>
        /// 商家发货人电话
        /// </summary>
        public string SenderPhone { get; set; }
    
        /// <summary>
        /// 运费
        /// </summary>
        public decimal Freight { get; set; }
    
        /// <summary>
        /// 多少钱开始免运费
        /// </summary>
        public decimal FreeFreight { get; set; }
    
        /// <summary>
        /// 注册步骤
        /// </summary>
        public int Stage { get; set; }
    
        /// <summary>
        /// 商家发货人省市区
        /// </summary>
        public int SenderRegionId { get; set; }
    
        /// <summary>
        /// 营业执照证书
        /// </summary>
        public string BusinessLicenseCert { get; set; }
    
        /// <summary>
        /// 商品证书
        /// </summary>
        public string ProductCert { get; set; }
    
        /// <summary>
        /// 其他证书
        /// </summary>
        public string OtherCert { get; set; }
    
        /// <summary>
        /// 法人代表
        /// </summary>
        public string legalPerson { get; set; }
    
        /// <summary>
        /// 公司成立日期
        /// </summary>
        public DateTime CompanyFoundingDate { get; set; }
    
        /// <summary>
        /// 0、企业；1、个人
        /// </summary>
        public int BusinessType { get; set; }
    
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IDCard { get; set; }
    
        /// <summary>
        /// 身份证URL
        /// </summary>
        public string IDCardUrl { get; set; }
    
        /// <summary>
        /// 身份证照片URL2
        /// </summary>
        public string IDCardUrl2 { get; set; }
    
        /// <summary>
        /// 微信昵称
        /// </summary>
        public string WeiXinNickName { get; set; }
    
        /// <summary>
        /// 微信性别;0、男；1、女
        /// </summary>
        public int WeiXinSex { get; set; }
    
        /// <summary>
        /// 微信地区
        /// </summary>
        public string WeiXinAddress { get; set; }
    
        /// <summary>
        /// 微信真实姓名
        /// </summary>
        public string WeiXinTrueName { get; set; }
    
        /// <summary>
        /// 微信标识符
        /// </summary>
        public string WeiXinOpenId { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string WeiXinImg { get; set; }
    
        /// <summary>
        /// 商家是否开启自动分配订单
        /// </summary>
        public int AutoAllotOrder { get; set; }
    
        /// <summary>
        /// 是否提供发票
        /// </summary>
        public int ProvideInvoice { get; set; }
    
        /// <summary>
        /// 商家是否开启自动打印
        /// </summary>
        public bool IsAutoPrint { get; set; }
    
        /// <summary>
        /// 打印张数
        /// </summary>
        public int PrintCount { get; set; }
    
        /// <summary>
        /// 商家角色：1-联盟商(Alliance)，2-加盟商(Franchisee)，3-代理商(Agent)
        /// </summary>
        public int ShopRole { get; set; }
    
        /// <summary>
        /// 代理区域ID
        /// </summary>
        public int AgentRegionId { get; set; }
    
        /// <summary>
        /// 代理抽佣比例
        /// </summary>
        public decimal AgentRate { get; set; }
    
        /// <summary>
        /// 上级联盟商ID
        /// </summary>
        public bigint AllianceId { get; set; }
    
        /// <summary>
        /// 代理级别(1-CityAgent市代，2AreaAgent-区代)
        /// </summary>
        public int AgentLevel { get; set; }
    
        /// <summary>
        /// 允许添加连锁店数量
        /// </summary>
        public int ShopBranchCount { get; set; }
    
        /// <summary>
        /// 店铺装修状态(1 Designing 装修中、2 WaitAudit 待审核、3 Audit 已审核、4 Hidden 已隐藏)
        /// </summary>
        public int DesignStatus { get; set; }
    
        /// <summary>
        /// 线下扫码让利比，只有联盟商角色才会设置这个值
        /// </summary>
        public decimal OfflinePayRate { get; set; }

    }
}