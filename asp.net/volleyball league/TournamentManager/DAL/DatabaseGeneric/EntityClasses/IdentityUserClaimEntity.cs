﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.7.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using TournamentManager.DAL.HelperClasses;
using TournamentManager.DAL.FactoryClasses;
using TournamentManager.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace TournamentManager.DAL.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'IdentityUserClaim'.<br/><br/></summary>
	[Serializable]
	public partial class IdentityUserClaimEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private UserEntity _user;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static IdentityUserClaimEntityStaticMetaData _staticMetaData = new IdentityUserClaimEntityStaticMetaData();
		private static IdentityUserClaimRelations _relationsFactory = new IdentityUserClaimRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class IdentityUserClaimEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public IdentityUserClaimEntityStaticMetaData()
			{
				SetEntityCoreInfo("IdentityUserClaimEntity", InheritanceHierarchyType.None, false, (int)TournamentManager.DAL.EntityType.IdentityUserClaimEntity, typeof(IdentityUserClaimEntity), typeof(IdentityUserClaimEntityFactory), false);
				AddNavigatorMetaData<IdentityUserClaimEntity, UserEntity>("User", "IdentityUserClaims", (a, b) => a._user = b, a => a._user, (a, b) => a.User = b, TournamentManager.DAL.RelationClasses.StaticIdentityUserClaimRelations.UserEntityUsingUserIdStatic, ()=>new IdentityUserClaimRelations().UserEntityUsingUserId, null, new int[] { (int)IdentityUserClaimFieldIndex.UserId }, null, true, (int)TournamentManager.DAL.EntityType.UserEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static IdentityUserClaimEntity()
		{
		}

		/// <summary> CTor</summary>
		public IdentityUserClaimEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public IdentityUserClaimEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this IdentityUserClaimEntity</param>
		public IdentityUserClaimEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for IdentityUserClaim which data should be fetched into this IdentityUserClaim object</param>
		public IdentityUserClaimEntity(System.Int64 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for IdentityUserClaim which data should be fetched into this IdentityUserClaim object</param>
		/// <param name="validator">The custom validator object for this IdentityUserClaimEntity</param>
		public IdentityUserClaimEntity(System.Int64 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected IdentityUserClaimEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'User' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser() { return CreateRelationInfoForNavigator("User"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this IdentityUserClaimEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static IdentityUserClaimRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUser { get { return _staticMetaData.GetPrefetchPathElement("User", CommonEntityBase.CreateEntityCollection<UserEntity>()); } }

		/// <summary>The ClaimType property of the Entity IdentityUserClaim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityUserClaim"."ClaimType".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ClaimType
		{
			get { return (System.String)GetValue((int)IdentityUserClaimFieldIndex.ClaimType, true); }
			set	{ SetValue((int)IdentityUserClaimFieldIndex.ClaimType, value); }
		}

		/// <summary>The ClaimValue property of the Entity IdentityUserClaim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityUserClaim"."ClaimValue".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ClaimValue
		{
			get { return (System.String)GetValue((int)IdentityUserClaimFieldIndex.ClaimValue, true); }
			set	{ SetValue((int)IdentityUserClaimFieldIndex.ClaimValue, value); }
		}

		/// <summary>The Id property of the Entity IdentityUserClaim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityUserClaim"."Id".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)IdentityUserClaimFieldIndex.Id, true); }
			set { SetValue((int)IdentityUserClaimFieldIndex.Id, value); }		}

		/// <summary>The Issuer property of the Entity IdentityUserClaim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityUserClaim"."Issuer".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Issuer
		{
			get { return (System.String)GetValue((int)IdentityUserClaimFieldIndex.Issuer, true); }
			set	{ SetValue((int)IdentityUserClaimFieldIndex.Issuer, value); }
		}

		/// <summary>The UserId property of the Entity IdentityUserClaim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityUserClaim"."UserId".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int64 UserId
		{
			get { return (System.Int64)GetValue((int)IdentityUserClaimFieldIndex.UserId, true); }
			set	{ SetValue((int)IdentityUserClaimFieldIndex.UserId, value); }
		}

		/// <summary>The ValueType property of the Entity IdentityUserClaim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityUserClaim"."ValueType".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ValueType
		{
			get { return (System.String)GetValue((int)IdentityUserClaimFieldIndex.ValueType, true); }
			set	{ SetValue((int)IdentityUserClaimFieldIndex.ValueType, value); }
		}

		/// <summary>Gets / sets related entity of type 'UserEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UserEntity User
		{
			get { return _user; }
			set { SetSingleRelatedEntityNavigator(value, "User"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace TournamentManager.DAL
{
	public enum IdentityUserClaimFieldIndex
	{
		///<summary>ClaimType. </summary>
		ClaimType,
		///<summary>ClaimValue. </summary>
		ClaimValue,
		///<summary>Id. </summary>
		Id,
		///<summary>Issuer. </summary>
		Issuer,
		///<summary>UserId. </summary>
		UserId,
		///<summary>ValueType. </summary>
		ValueType,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace TournamentManager.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: IdentityUserClaim. </summary>
	public partial class IdentityUserClaimRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between IdentityUserClaimEntity and UserEntity over the m:1 relation they have, using the relation between the fields: IdentityUserClaim.UserId - User.Id</summary>
		public virtual IEntityRelation UserEntityUsingUserId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "User", false, new[] { UserFields.Id, IdentityUserClaimFields.UserId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticIdentityUserClaimRelations
	{
		internal static readonly IEntityRelation UserEntityUsingUserIdStatic = new IdentityUserClaimRelations().UserEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticIdentityUserClaimRelations() { }
	}
}
