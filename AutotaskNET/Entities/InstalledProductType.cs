﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a Type, for example, printer, server, or workstation, assigned to a Configuration Item in Autotask.<br />
    /// The InstalledProductType associates one or more User-defined Fields with configuration items of the same type.<br />
    /// The Userdefined Fields allow the user to capture key information for configuration items of the specified type, for example, make and model, or replacement part numbers.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class InstalledProductType : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public string Name { get; set; } //Required Length:100
        public bool Active { get; set; } //Required

        #endregion //Required Fields
        
    } //end InstalledProductType

}
