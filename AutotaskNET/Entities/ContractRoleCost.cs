﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a per hour cost for labor that is set at the contract level.<br />
    /// This cost overrides a resource's Admin level internal cost rate for time entries posted against the contract.<br />
    /// Time entry dates must fall within the active dates of the contract.<br />
    /// The cost rate is associated with a resource and a role.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractRoleCost : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractRoleCost() : base() { } //end ContractRoleCost()
        public ContractRoleCost(net.autotask.webservices.ContractRoleCost entity) : base(entity)
        {
            this.ContractID = int.Parse(entity.ContractID.ToString());
            this.Rate = double.Parse(entity.Rate.ToString());
            this.ResourceID = int.Parse(entity.ResourceID.ToString());
            this.RoleID = int.Parse(entity.RoleID.ToString());
        } //end ContractRoleCost(net.autotask.webservices.ContractRoleCost entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int ContractID; //ReadOnly Required [Contract]
        public int ResourceID; //ReadOnly Required [Resource]
        public int RoleID; //ReadOnly Required [Role]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public double Rate; //Required

        #endregion //Required Fields

        #endregion //Fields

    } //end ContractRoleCost

}
