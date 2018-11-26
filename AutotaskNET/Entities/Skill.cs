﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a skill that can be associated with a Resource through the ResourceSkill entity.<br />
    /// When assigning tickets via the API, the ResourceSkill entity provides information to assist in matching a Problem/Incident to resources with the proper skill level.<br />
    /// <br />
    /// To access or update ResourceSkill data, the user logged into the API must have security level must include Resources/Users (HR) permission.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Skill : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Skill() : base() { } //end Skill()
        public Skill(net.autotask.webservices.Skill entity) : base(entity)
        {
            this.Active = bool.Parse(entity.Active.ToString());
            this.CategoryID = long.Parse(entity.CategoryID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
        } //end Skill(net.autotask.webservices.Skill entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string Description; //ReadOnly Length:2000

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public string Name; //ReadOnly Required Length:100
        public long CategoryID; //ReadOnly Required PickList
        public bool Active; //ReadOnly Required

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end Skill

}
