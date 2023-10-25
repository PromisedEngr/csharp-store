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
	/// <summary>Class which represents a row in the typed view 'MatchToPlayRaw'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the property <see cref="TournamentManager.DAL.FactoryClasses.QueryFactory.MatchToPlayRaw"/>. </remarks>
	[Serializable]
	public partial class MatchToPlayRawRow 
	{
		partial void OnCreated();
		
		/// <summary>Initializes a new instance of the <see cref="MatchToPlayRawRow"/> class.</summary>
		public MatchToPlayRawRow()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the GuestTeamId field.</summary>
		public System.Int64 GuestTeamId { get; set; }
		/// <summary>Gets or sets the HomeTeamId field.</summary>
		public System.Int64 HomeTeamId { get; set; }
		/// <summary>Gets or sets the Id field.</summary>
		public System.Int64 Id { get; set; }
		/// <summary>Gets or sets the MatchDate field.</summary>
		public Nullable<System.DateTime> MatchDate { get; set; }
		/// <summary>Gets or sets the ModifiedOn field.</summary>
		public System.DateTime ModifiedOn { get; set; }
		/// <summary>Gets or sets the RoundId field.</summary>
		public System.Int64 RoundId { get; set; }
		/// <summary>Gets or sets the TournamentId field.</summary>
		public Nullable<System.Int64> TournamentId { get; set; }
		/// <summary>Gets or sets the VenueId field.</summary>
		public Nullable<System.Int64> VenueId { get; set; }
	}
}

