﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity associates User-defined Fields with an InstalledProductType.<br />
    /// An InstalledProductType is assigned to a Configuration Item in Autotask.<br />
    /// The user defined fields describe key data that the user wants to capture for configuration items of the specified type, for example, make and model, or replacement part numbers.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class InstalledProductTypeUdfAssociation : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public InstalledProductTypeUdfAssociation() : base() { } //end InstalledProductTypeUdfAssociation()
        public InstalledProductTypeUdfAssociation(net.autotask.webservices.InstalledProductTypeUdfAssociation entity) : base(entity)
        {
            this.InstalledProductTypeId = long.Parse(entity.InstalledProductTypeId.ToString());
            this.Required = bool.Parse(entity.Required.ToString());
            this.SortOrder = int.Parse(entity.SortOrder.ToString());
            this.UserDefinedFieldDefinitionId = long.Parse(entity.UserDefinedFieldDefinitionId.ToString());
        } //end InstalledProductTypeUdfAssociation(net.autotask.webservices.InstalledProductTypeUdfAssociation entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public long InstalledProductTypeId; //ReadOnly Required [InstalledProductType]
        public long UserDefinedFieldDefinitionId; //ReadOnly Required

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public bool Required; //Required
        public int SortOrder; //Required

        #endregion //Required Fields

        #endregion //Fields

    } //end InstalledProductTypeUdfAssociation

}
