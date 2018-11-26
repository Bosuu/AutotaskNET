﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The AllocationCode entity describes an Autotask Allocation Code. An allocation code represents a billing item category.<br />
    /// There are six types of allocation codes: Work Types, Material, Internal Time, Expense Categories, Recurring Contract Service, and Milestone.<br />
    /// Administrators add and manage allocation codes through the Admin module(Admin >Site Setup > Billing Codes).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AllocationCode : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public AllocationCode() : base() { } //end AllocationCode()
        public AllocationCode(net.autotask.webservices.AllocationCode entity) : base(entity)
        {
            this.Active = bool.Parse(entity.Active.ToString());
            this.AllocationCodeType = entity.AllocationCodeType == null ? default(int?) : int.Parse(entity.AllocationCodeType.ToString());
            this.Department = entity.Department == null ? default(int?) : int.Parse(entity.Department.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.ExternalNumber = entity.ExternalNumber == null ? default(string) : entity.ExternalNumber.ToString();
            this.GeneralLedgerCode = entity.GeneralLedgerCode == null ? default(int?) : int.Parse(entity.GeneralLedgerCode.ToString());
            this.IsExcludedFromNewContracts = entity.IsExcludedFromNewContracts == null ? default(bool?) : bool.Parse(entity.IsExcludedFromNewContracts.ToString());
            this.MarkupRate = double.Parse(entity.MarkupRate.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.Taxable = entity.Taxable == null ? default(bool?) : bool.Parse(entity.Taxable.ToString());
            this.TaxCategoryID = entity.TaxCategoryID == null ? default(int?) : int.Parse(entity.TaxCategoryID.ToString());
            this.Type = entity.Type == null ? default(int?) : int.Parse(entity.Type.ToString());
            this.UnitCost = double.Parse(entity.UnitCost.ToString());
            this.UnitPrice = double.Parse(entity.UnitPrice.ToString());
            this.UseType = entity.UseType == null ? default(int?) : int.Parse(entity.UseType.ToString());
        } //end AllocationCode(net.autotask.webservices.AllocationCode entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public double MarkupRate; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public bool Active; //Required
        public double UnitCost; //Required
        public double UnitPrice; //Required

        #endregion //Required Fields

        #region Optional Fields

        public int? GeneralLedgerCode; //PickList
        public int? Department;
        public string Name; //Length:200
        public string ExternalNumber; //Length:100
        public int? Type; //PickList
        public int? UseType; //PickList
        public string Description; //Length:500
        public int? AllocationCodeType; //PickList
        public bool? Taxable;
        public int? TaxCategoryID; //[TaxCategory]
        public bool? IsExcludedFromNewContracts;

        #endregion //Optional Fields

        #endregion //Fields

    } //end AllocationCode

}
