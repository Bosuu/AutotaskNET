﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask project Phase.<br />
    /// Phases allow users to break projects into sub-groups of project tasks.<br />
    /// They can be a sub-phase to a Parent phase.Users manage phases through the Project's Schedule view in the Projects module.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Phase : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Phase() : base() { } //end Phase()
        public Phase(net.autotask.webservices.Phase entity) : base(entity)
        {
            this.ProjectID = int.Parse(entity.ProjectID.ToString());
            this.Title = entity.Title == null ? default(string) : entity.Title.ToString();
            this.CreateDate = entity.CreateDate == null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString());
            this.CreatorResourceID = entity.CreatorResourceID == null ? default(int?) : int.Parse(entity.CreatorResourceID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.DueDate = entity.DueDate == null ? default(DateTime?) : DateTime.Parse(entity.DueDate.ToString());
            this.EstimatedHours = float.Parse(entity.EstimatedHours.ToString());
            this.ExternalID = entity.ExternalID == null ? default(string) : entity.ExternalID.ToString();
            this.LastActivityDateTime = entity.LastActivityDateTime == null ? default(DateTime?) : DateTime.Parse(entity.LastActivityDateTime.ToString());
            this.ParentPhaseID = entity.ParentPhaseID == null ? default(int?) : int.Parse(entity.ParentPhaseID.ToString());
            this.PhaseNumber = entity.PhaseNumber == null ? default(string) : entity.PhaseNumber.ToString();
            this.Scheduled = entity.Scheduled == null ? default(bool?) : bool.Parse(entity.Scheduled.ToString());
            this.StartDate = entity.StartDate == null ? default(DateTime?) : DateTime.Parse(entity.StartDate.ToString());
        } //end Phase(net.autotask.webservices.Phase entity)

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

        #endregion //Fields

        public DateTime? CreateDate; //ReadOnly
        public int? CreatorResourceID; //ReadOnly [Resource]
        public string Description; //Length:8000
        public DateTime? DueDate;
        public float EstimatedHours; //ReadOnly
        public string ExternalID; //Length:50
        public DateTime? LastActivityDateTime; //ReadOnly
        public int? ParentPhaseID; //[Phase]
        public string PhaseNumber; //ReadOnly Length:50
        public int ProjectID; //ReadOnly Required [Project]
        public bool? Scheduled; //ReadOnly
        public DateTime? StartDate;
        public string Title; //Required Length:255

    } //end Phase

}
