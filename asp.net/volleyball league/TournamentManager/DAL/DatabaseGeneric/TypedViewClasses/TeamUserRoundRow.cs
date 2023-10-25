﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.7.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;

namespace TournamentManager.DAL.TypedViewClasses
{
	/// <summary>Class which represents a row in the typed view 'TeamUserRound'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the property <see cref="TournamentManager.DAL.FactoryClasses.QueryFactory.TeamUserRound"/>. </remarks>
	[Serializable]
	public partial class TeamUserRoundRow 
	{
		partial void OnCreated();
		
		/// <summary>Initializes a new instance of the <see cref="TeamUserRoundRow"/> class.</summary>
		public TeamUserRoundRow()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the ClubName field.</summary>
		public System.String ClubName { get; set; }
		/// <summary>Gets or sets the Email field.</summary>
		public System.String Email { get; set; }
		/// <summary>Gets or sets the Email2 field.</summary>
		public System.String Email2 { get; set; }
		/// <summary>Gets or sets the FirstName field.</summary>
		public System.String FirstName { get; set; }
		/// <summary>Gets or sets the Gender field.</summary>
		public System.String Gender { get; set; }
		/// <summary>Gets or sets the IsManager field.</summary>
		public System.Boolean IsManager { get; set; }
		/// <summary>Gets or sets the IsPlayer field.</summary>
		public System.Boolean IsPlayer { get; set; }
		/// <summary>Gets or sets the LastName field.</summary>
		public System.String LastName { get; set; }
		/// <summary>Gets or sets the MatchDayOfWeek field.</summary>
		public Nullable<System.Int32> MatchDayOfWeek { get; set; }
		/// <summary>Gets or sets the MatchTime field.</summary>
		public Nullable<System.TimeSpan> MatchTime { get; set; }
		/// <summary>Gets or sets the MatchWeekday field.</summary>
		public System.String MatchWeekday { get; set; }
		/// <summary>Gets or sets the MiddleName field.</summary>
		public System.String MiddleName { get; set; }
		/// <summary>Gets or sets the Nickname field.</summary>
		public System.String Nickname { get; set; }
		/// <summary>Gets or sets the PhoneNumber field.</summary>
		public System.String PhoneNumber { get; set; }
		/// <summary>Gets or sets the PhoneNumber2 field.</summary>
		public System.String PhoneNumber2 { get; set; }
		/// <summary>Gets or sets the RoundDescription field.</summary>
		public System.String RoundDescription { get; set; }
		/// <summary>Gets or sets the RoundId field.</summary>
		public System.Int64 RoundId { get; set; }
		/// <summary>Gets or sets the RoundName field.</summary>
		public System.String RoundName { get; set; }
		/// <summary>Gets or sets the TeamId field.</summary>
		public System.Int64 TeamId { get; set; }
		/// <summary>Gets or sets the TeamModifiedOn field.</summary>
		public System.DateTime TeamModifiedOn { get; set; }
		/// <summary>Gets or sets the TeamName field.</summary>
		public System.String TeamName { get; set; }
		/// <summary>Gets or sets the TeamNameForRound field.</summary>
		public System.String TeamNameForRound { get; set; }
		/// <summary>Gets or sets the Title field.</summary>
		public System.String Title { get; set; }
		/// <summary>Gets or sets the TournamentId field.</summary>
		public Nullable<System.Int64> TournamentId { get; set; }
		/// <summary>Gets or sets the UserId field.</summary>
		public System.Int64 UserId { get; set; }
		/// <summary>Gets or sets the UserModifiedOn field.</summary>
		public System.DateTime UserModifiedOn { get; set; }
	}
}

