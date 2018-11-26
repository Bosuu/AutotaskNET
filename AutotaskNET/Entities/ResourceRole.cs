﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ResourceRole : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ResourceRole() : base() { } //end ResourceRole()
        public ResourceRole(net.autotask.webservices.ResourceRole entity) : base(entity)
        {
            this.Active = entity.Active == null ? default(bool?) : bool.Parse(entity.Active.ToString();
            this.DepartmentID = long.Parse(entity.DepartmentID.ToString());
            this.QueueID = long.Parse(entity.QueueID.ToString());
            this.ResourceID = long.Parse(entity.ResourceID.ToString());
            this.RoleID = long.Parse(entity.RoleID.ToString());
        } //end ResourceRole(net.autotask.webservices.ResourceRole entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public long DepartmentID; //ReadOnly [Department]
        public long QueueID; //ReadOnly PickList
        public bool? Active; //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public long ResourceID; //ReadOnly Required [Resource]
        public long RoleID; //ReadOnly Required [Role]

        #endregion //ReadOnly Required Fields
        
        #endregion //Fields

    } //end ResourceRole

}
