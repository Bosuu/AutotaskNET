﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Account Contact that has been assigned access to the Client Access Portal.<br />
    /// In the Autotask Interface, Account Contacts are enabled as Client Portal Users in Admin > Client Access Portal > Manage Accounts > select Account > "Manage users for this account" or from the Client Portal tab of the Edit Contact window.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ClientPortalUser : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ClientPortalUser() : base() { } //end ClientPortalUser()
        public ClientPortalUser(net.autotask.webservices.ClientPortalUser entity) : base(entity)
        {
            this.ClientPortalActive = bool.Parse(entity.ClientPortalActive.ToString());
            this.ContactID = int.Parse(entity.ContactID.ToString());
            this.DateFormat = int.Parse(entity.DateFormat.ToString());
            this.NumberFormat = int.Parse(entity.NumberFormat.ToString());
            this.Password = entity.Password == null ? default(string) : entity.Password.ToString();
            this.SecurityLevel = int.Parse(entity.SecurityLevel.ToString());
            this.TimeFormat = int.Parse(entity.TimeFormat.ToString());
            this.UserName = entity.UserName == null ? default(string) : entity.UserName.ToString();
        } //end ClientPortalUser(net.autotask.webservices.ClientPortalUser entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int ContactID; //ReadOnly Required [Contact]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int SecurityLevel; //Required PickList
        public int DateFormat; //Required PickList
        public int TimeFormat; //Required PickList
        public int NumberFormat; //Required PickList
        public string UserName; //Required Length:200
        public bool ClientPortalActive; //Required

        #endregion //Required Fields

        #region Optional Fields

        public string Password; //Length:50

        #endregion //Optional Fields

        #endregion //Fields

    } //end ClientPortalUser
}
