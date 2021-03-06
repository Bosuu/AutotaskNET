﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceBundle : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ServiceBundle() : base() { } //end ServiceBundle()
        public ServiceBundle(net.autotask.webservices.ServiceBundle entity) : base(entity)
        {
            this.AllocationCodeID = int.Parse(entity.AllocationCodeID.ToString());
            this.CreateDate = entity.CreateDate == null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString());
            this.CreatorResourceID = entity.CreatorResourceID == null ? default(int?) : int.Parse(entity.CreatorResourceID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.InvoiceDescription = entity.InvoiceDescription == null ? default(string) : entity.InvoiceDescription.ToString();
            this.IsActive = entity.IsActive == null ? default(bool?) : bool.Parse(entity.IsActive.ToString());
            this.LastModifiedDate = entity.LastModifiedDate == null ? default(DateTime?) : DateTime.Parse(entity.LastModifiedDate.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.PercentageDiscount = double.Parse(entity.PercentageDiscount.ToString());
            this.PeriodType = entity.PeriodType == null ? default(string) : entity.PeriodType.ToString();
            this.ServiceLevelAgreementID = long.Parse(entity.ServiceLevelAgreementID.ToString());
            this.UnitCost = double.Parse(entity.UnitCost.ToString());
            this.UnitDiscount = double.Parse(entity.UnitDiscount.ToString());
            this.UnitPrice = double.Parse(entity.UnitPrice.ToString());
            this.UpdateResourceID = entity.UpdateResourceID == null ? default(int?) : int.Parse(entity.UpdateResourceID.ToString());
        } //end ServiceBundle(net.autotask.webservices.ServiceBundle entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        public string Name; //Required Length:100
        public string Description; //Length:200
        public double UnitPrice;
        public double UnitDiscount;
        public double PercentageDiscount;
        public string PeriodType; //ReadOnly Required PickList Length:1
        public int AllocationCodeID; //Required [AllocationCode]
        public bool? IsActive;
        public int? CreatorResourceID; //ReadOnly [Resource]
        public int? UpdateResourceID; //ReadOnly [Resource]
        public DateTime? CreateDate; //ReadOnly
        public string InvoiceDescription; //Length:1000
        public DateTime? LastModifiedDate; //ReadOnly
        public long ServiceLevelAgreementID; //PickList
        public double UnitCost; //ReadOnly

        #endregion //Fields

    } //end ServiceBundle

}
