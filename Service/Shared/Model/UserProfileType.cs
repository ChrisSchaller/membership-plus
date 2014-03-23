//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool from CryptoGateway Software Inc.
//     Tool name: CGW X-Script RDB visual Layer Generator
//
//     Archymeta Information Technologies Co., Ltd.
//
//     Changes to this file, could be overwritten if the code is re-generated.
//     Add (if not yet) a code-manager node to the generator to specify 
//     how existing files are processed.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Configuration;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace CryptoGateway.RDB.Data.MembershipPlus
{
    /// <summary>
    /// A entity in "UserProfileTypes" data set.
    /// </summary>
    /// <remarks>
    ///  <para>
    ///    Properties of the entity are categorized in the following:
    ///  </para>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>Primary keys</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>ID</term>
    ///      <description>See <see cref="UserProfileType.ID" />. Auto-gen primary key; fixed; not null.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>Intrinsic Identifiers</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>ClrType</term>
    ///      <description>See <see cref="UserProfileType.ClrType" />. Intrinsic id; fixed; nullable; max-length = 128 characters.</description>
    ///    </item>
    ///    <item>
    ///      <term>SerializationProvider</term>
    ///      <description>See <see cref="UserProfileType.SerializationProvider" />. Intrinsic id; fixed; nullable; max-length = 100 characters.</description>
    ///    </item>
    ///    <item>
    ///      <term>SerializeType</term>
    ///      <description>See <see cref="UserProfileType.SerializeType" />. Intrinsic id; fixed; nullable; max-length = 50 characters.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>The following entity sets depend on this entity</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>UserProfiles</term>
    ///      <description>See <see cref="UserProfileType.UserProfiles" />, which is a sub-set of the data set "UserProfiles" for <see cref="UserProfile" />.</description>
    ///    </item>
    ///  </list>
    /// </remarks>
    [DataContract]
    public class UserProfileType : IDbEntity 
    {
        /// <summary>
        /// For internal use only.
        /// </summary>
        public bool IsOperationHandled = false;

        /// <summary>
        /// Used on the server side to return an unique key for caching purposes.
        /// </summary>
        public string CacheKey
        {
            get
            {
                return this.ID.ToString();
            }
        }

        /// <summary>
        /// Whether or not the entity was already persisted into to the data source. 
        /// </summary>
        [DataMember]
        public bool IsPersisted
        {
            get { return _isPersisted; }
            set { _isPersisted = value; }
        }
        private bool _isPersisted = false;

        /// <summary>
        /// Used internally.
        /// </summary>
        public bool IsInitializing
        {
            get { return _isInitializing; }
            set { _isInitializing = value; }
        }
        private bool _isInitializing = false;

        /// <summary>
        /// Used to matching entities in input adding or updating entity list and the returned ones, see <see cref="IUserProfileTypeService.AddOrUpdateEntities" />.
        /// </summary>
        [DataMember]
        public int UpdateIndex
        {
            get { return _updateIndex; }
            set { _updateIndex = value; }
        }
        private int _updateIndex = -1;

        /// <summary>
        /// Configured at system generation step, its value provides a short, but characteristic summary of the entity.
        /// </summary>
        [DataMember]
        public string DistinctString
        {
            get 
            {
                if (_distinctString == null)
                    _distinctString = GetDistinctString(true);
                return _distinctString;
            }
            set
            {
                _distinctString = value;
            }
        }
        private string _distinctString = null;

        private string GetDistinctString(bool ShowPathInfo)
        {
            return String.Format(@"{0}", (ClrType != null ? ClrType.Trim() : ""));
        }

        /// <summary>
        /// Whether or not the entity was edited.
        /// </summary>
        [DataMember]
        public bool IsEntityChanged
        {
            get { return _isEntityChanged; }
            set { _isEntityChanged = value; }
        }
        private bool _isEntityChanged = true;

        /// <summary>
        /// Whether or not the entity was to be deleted.
        /// </summary>
        [DataMember]
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }
        private bool _isDeleted = false;

#region Properties of the current entity

        /// <summary>
        /// Meta-info: auto-gen primary key; fixed; not null.
        /// </summary>
        [Key]
        [Editable(false)]
        [DataMember(IsRequired = false)]
        public int ID
        { 
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                }
            }
        }
        private int _ID = default(int);

        /// <summary>
        /// Meta-info: intrinsic id; fixed; nullable; max-length = 128 characters.
        /// </summary>
        [Key]
        [Editable(false)]
        [StringLength(128)]
        [DataMember(IsRequired = false)]
        public string ClrType
        { 
            get
            {
                return _ClrType;
            }
            set
            {
                if (_ClrType != value)
                {
                    _ClrType = value;
                }
            }
        }
        private string _ClrType = default(string);

        /// <summary>
        /// Meta-info: intrinsic id; fixed; nullable; max-length = 100 characters.
        /// </summary>
        [Key]
        [Editable(false)]
        [StringLength(100)]
        [DataMember(IsRequired = false)]
        public string SerializationProvider
        { 
            get
            {
                return _SerializationProvider;
            }
            set
            {
                if (_SerializationProvider != value)
                {
                    _SerializationProvider = value;
                }
            }
        }
        private string _SerializationProvider = default(string);

        /// <summary>
        /// Meta-info: intrinsic id; fixed; nullable; max-length = 50 characters.
        /// </summary>
        [Key]
        [Editable(false)]
        [StringLength(50)]
        [DataMember(IsRequired = false)]
        public string SerializeType
        { 
            get
            {
                return _SerializeType;
            }
            set
            {
                if (_SerializeType != value)
                {
                    _SerializeType = value;
                }
            }
        }
        private string _SerializeType = default(string);

#endregion

#region Entities that the current one depends upon.

#endregion

#region Entities that depend on the current one.

        /// <summary>
        /// Entitity set <see cref="UserProfileSet" /> for data set "UserProfiles" of <see cref="UserProfile" /> that depend on the current entity.
        /// The corresponding foreign key in <see cref="UserProfileSet" /> set is { <see cref="UserProfile.TypeID" /> }.
        /// </summary>
        [DataMember]
		public UserProfileSet UserProfiles
		{
			get
			{
                if (_UserProfiles == null)
                    _UserProfiles = new UserProfileSet();
				return _UserProfiles;
			}
            set
            {
                _UserProfiles = value;
            }
		}
		private UserProfileSet _UserProfiles = null;

        /// <summary>
        /// Entitites enumeration expression for data set "UserProfiles" of <see cref="UserProfile" /> that depend on the current entity.
        /// The corresponding foreign key in <see cref="UserProfileSet" /> set is { <see cref="UserProfile.TypeID" /> }.
        /// </summary>
		public IEnumerable<UserProfile> UserProfileEnum
		{
			get;
            set;
		}

        /// <summary>
        /// A list of <see cref="UserProfile" /> that is to be added or updated to the data source, together with the current entity.
        /// The corresponding foreign key in <see cref="UserProfileSet" /> set is { <see cref="UserProfile.TypeID" /> }.
        /// </summary>
        [DataMember]
		public UserProfile[] ChangedUserProfiles
		{
			get;
            set;
		}

#endregion

        /// <summary>
        /// Whether or not the present entity is identitical to <paramref name="other" />, in the sense that they have the same (set of) primary key(s).
        /// </summary>
        /// <param name="other">The entity to be compared to.</param>
        /// <returns>
        ///   The result of comparison.
        /// </returns>
        public bool IsEntityIdentical(UserProfileType other)
        {
            if (other == null)
                return false;
            if (ID != other.ID)
                return false;
            return true;
        }              

        /// <summary>
        /// Whether or not the present entity is identitical to <paramref name="other" />, in the sense that they have the same (set of) intrinsic identifiers.
        /// </summary>
        /// <param name="other">The entity to be compared to.</param>
        /// <returns>
        ///   The result of comparison.
        /// </returns>
        public bool IsEntityTheSame(UserProfileType other)
        {
            if (other == null)
                return false;
            else
                return ClrType == other.ClrType &&  SerializationProvider == other.SerializationProvider &&  SerializeType == other.SerializeType;
        }              

        /// <summary>
        /// Merge changes inside entity <paramref name="from" /> to the entity <paramref name="to" />. Any changes in <paramref name="from" /> that is not changed in <paramref name="to" /> is updated inside <paramref name="to" />.
        /// </summary>
        /// <param name="from">The "old" entity acting as merging source.</param>
        /// <param name="to">The "new" entity which inherits changes made in <paramref name="from" />.</param>
        /// <returns>
        /// </returns>
        public static void MergeChanges(UserProfileType from, UserProfileType to)
        {
            if (to.IsPersisted)
            {
            }
            else
            {
                to.IsPersisted = from.IsPersisted;
                to.ID = from.ID;
                to.ClrType = from.ClrType;
                to.SerializationProvider = from.SerializationProvider;
                to.SerializeType = from.SerializeType;
            }
        }

        /// <summary>
        /// Update changes to the current entity compared to an input <paramref name="newdata" /> and set the entity to a proper state for updating.
        /// </summary>
        /// <param name="newdata">The "new" entity acting as the source of the changes, if any.</param>
        /// <returns>
        /// </returns>
        public void UpdateChanges(UserProfileType newdata)
        {
            int cnt = 0;
            IsEntityChanged = cnt > 0;
        }

        /// <summary>
        /// Internal use
        /// </summary>
        public void NormalizeValues()
        {
            IsInitializing = true;
            IsInitializing = false;
        }

        /// <summary>
        /// Internal use
        /// </summary>
        public UserProfileType ShallowCopy(bool allData = false)
        {
            UserProfileType e = new UserProfileType();
            e.IsInitializing = true;
            e.ID = ID;
            e.ClrType = ClrType;
            e.SerializationProvider = SerializationProvider;
            e.SerializeType = SerializeType;
            e.DistinctString = GetDistinctString(true);
            e.IsPersisted = true;
            e.IsEntityChanged = false;
            e.IsInitializing = false;
            return e;
        }

        /// <summary>
        /// A textual representation of the entity.
        /// </summary>
        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"
----===== [[UserProfileType]] =====----
  ID = " + ID + @"
  ClrType = '" + (ClrType != null ? ClrType : "null") + @"'");
            sb.Append(@" (natural id)");
            sb.Append(@"
  SerializationProvider = '" + (SerializationProvider != null ? SerializationProvider : "null") + @"'");
            sb.Append(@" (natural id)");
            sb.Append(@"
  SerializeType = '" + (SerializeType != null ? SerializeType : "null") + @"'");
            sb.Append(@" (natural id)");
            sb.Append(@"
");
            return sb.ToString();
        }

    }

    ///<summary>
    ///The result of an add or update of type <see cref="UserProfileType" />.
    ///</summary>
    [DataContract]
    public class UserProfileTypeUpdateResult : IUpdateResult
    {
        /// <summary>
        /// Status of add, update or delete operation
        /// </summary>
        [DataMember]
        public int OpStatus
        {
            get { return _opStatus; }
            set { _opStatus = value; }
        }
        private int _opStatus = (int)EntityOpStatus.Unknown;

        /// <summary>
        /// Parents or child operation status
        /// </summary>
        [DataMember]
        public int RelatedOpStatus
        {
            get { return _relatedOpStatus; }
            set { _relatedOpStatus = value; }
        }
        private int _relatedOpStatus = (int)EntityOpStatus.Unknown;

        /// <summary>
        /// The updated entity.
        /// </summary>
        [DataMember]
        public UserProfileType UpdatedItem
        {
            get;
            set;
        }

        /// <summary>
        /// If the relational data source has a way of detecting concurrent update conflicts, this is the item inside the
        /// data source that had been updated by other agents in between the load and update time interval of the present
        /// agent. The client software should resolve the conflict.
        /// </summary>
        [DataMember]
        public UserProfileType ConflictItem
        {
            get;
            set;
        }

        /// <summary>
        /// String representation of the entity.
        /// </summary>
        public string EntityInfo 
        { 
            get { return UpdatedItem == null ? "NULL" : UpdatedItem.ToString(); }
        }
    }

}
