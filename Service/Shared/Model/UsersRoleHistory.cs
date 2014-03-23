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
    /// A entity in "UsersRoleHistories" data set.
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
    ///      <description>See <see cref="UsersRoleHistory.ID" />. Auto-gen primary key; fixed; not null.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>Intrinsic Identifiers</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>RoleID</term>
    ///      <description>See <see cref="UsersRoleHistory.RoleID" />. Intrinsic id; fixed; not null; foreign key.</description>
    ///    </item>
    ///    <item>
    ///      <term>UserID</term>
    ///      <description>See <see cref="UsersRoleHistory.UserID" />. Intrinsic id; fixed; not null; foreign key.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>None editable properties</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>ChangeDate</term>
    ///      <description>See <see cref="UsersRoleHistory.ChangeDate" />. Fixed; not null.</description>
    ///    </item>
    ///    <item>
    ///      <term>Operation</term>
    ///      <description>See <see cref="UsersRoleHistory.Operation" />. Fixed; not null; max-length = 20 characters.</description>
    ///    </item>
    ///    <item>
    ///      <term>SubPriority</term>
    ///      <description>See <see cref="UsersRoleHistory.SubPriority" />. Fixed; not null.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>Foreign keys</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>OperatorID</term>
    ///      <description>See <see cref="UsersRoleHistory.OperatorID" />. Fixed; not null; foreign key.</description>
    ///    </item>
    ///    <item>
    ///      <term>RoleID</term>
    ///      <description>See <see cref="UsersRoleHistory.RoleID" />. Intrinsic id; fixed; not null; foreign key.</description>
    ///    </item>
    ///    <item>
    ///      <term>UserID</term>
    ///      <description>See <see cref="UsersRoleHistory.UserID" />. Intrinsic id; fixed; not null; foreign key.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>This entity depends on</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>RoleRef</term>
    ///      <description>See <see cref="UsersRoleHistory.RoleRef" />, which is a member of the data set "Roles" for <see cref="Role" />.</description>
    ///    </item>
    ///    <item>
    ///      <term>User_UserID</term>
    ///      <description>See <see cref="UsersRoleHistory.User_UserID" />, which is a member of the data set "Users" for <see cref="User" />.</description>
    ///    </item>
    ///    <item>
    ///      <term>User_OperatorID</term>
    ///      <description>See <see cref="UsersRoleHistory.User_OperatorID" />, which is a member of the data set "Users" for <see cref="User" />.</description>
    ///    </item>
    ///  </list>
    /// </remarks>
    [DataContract]
    public class UsersRoleHistory : IDbEntity 
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
        /// Used to matching entities in input adding or updating entity list and the returned ones, see <see cref="IUsersRoleHistoryService.AddOrUpdateEntities" />.
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
            LoadUser_UserID();
            LoadRoleRef();
            LoadUser_OperatorID();
            return String.Format(@"{0} as {1} {2} at {3} by {4}", (User_UserID != null ? User_UserID.DistinctString : ""), (RoleRef != null ? RoleRef.DistinctString : ""), Operation.Trim(), ChangeDate, (User_OperatorID != null ? User_OperatorID.DistinctString : ""));
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
        /// Meta-info: fixed; not null.
        /// </summary>
        [Required]
        [Editable(false)]
        [DataMember(IsRequired = true)]
        public DateTime ChangeDate
        { 
            get
            {
                return _ChangeDate;
            }
            set
            {
                if (_ChangeDate != value)
                {
                    _ChangeDate = value;
                }
            }
        }
        private DateTime _ChangeDate = default(DateTime);

        /// <summary>
        /// Meta-info: fixed; not null; max-length = 20 characters.
        /// </summary>
        [Required]
        [Editable(false)]
        [StringLength(20)]
        [DataMember(IsRequired = true)]
        public string Operation
        { 
            get
            {
                return _Operation;
            }
            set
            {
                if (_Operation != value)
                {
                    _Operation = value;
                }
            }
        }
        private string _Operation = default(string);

        /// <summary>
        /// Meta-info: fixed; not null.
        /// </summary>
        [Required]
        [Editable(false)]
        [DataMember(IsRequired = true)]
        public int SubPriority
        { 
            get
            {
                return _SubPriority;
            }
            set
            {
                if (_SubPriority != value)
                {
                    _SubPriority = value;
                }
            }
        }
        private int _SubPriority = default(int);

        /// <summary>
        /// Meta-info: fixed; not null; foreign key.
        /// </summary>
        [Required]
        [Editable(false)]
        [DataMember(IsRequired = true)]
        public string OperatorID
        { 
            get
            {
                return _OperatorID;
            }
            set
            {
                if (_OperatorID != value)
                {
                    _OperatorID = value;
                }
            }
        }
        private string _OperatorID = default(string);

        /// <summary>
        /// Meta-info: intrinsic id; fixed; not null; foreign key.
        /// </summary>
        [Key]
        [Required]
        [Editable(false)]
        [DataMember(IsRequired = true)]
        public int RoleID
        { 
            get
            {
                return _RoleID;
            }
            set
            {
                if (_RoleID != value)
                {
                    _RoleID = value;
                }
            }
        }
        private int _RoleID = default(int);

        /// <summary>
        /// Meta-info: intrinsic id; fixed; not null; foreign key.
        /// </summary>
        [Key]
        [Required]
        [Editable(false)]
        [DataMember(IsRequired = true)]
        public string UserID
        { 
            get
            {
                return _UserID;
            }
            set
            {
                if (_UserID != value)
                {
                    _UserID = value;
                }
            }
        }
        private string _UserID = default(string);

#endregion

#region Entities that the current one depends upon.

        /// <summary>
        /// Entity in data set "Roles" for <see cref="Role" /> that this entity depend upon through .
        /// The corresponding foreign key set is { <see cref="UsersRoleHistory.RoleID" /> }.
        /// </summary>
        [DataMember]
        public Role RoleRef
        {
            get 
            {
                if (_RoleRef == null && AutoLoadRoleRef != null)
                    _RoleRef = AutoLoadRoleRef();
                return _RoleRef; 
            }
            set 
            { 
                _RoleRef = value; 
            }
        }
        private Role _RoleRef = null;

        /// <summary>
        /// <see cref="UsersRoleHistory.RoleRef" /> is not initialized when the entity is created. Clients could call this method to load it provided a proper delegate <see cref="UsersRoleHistory.DelLoadRoleRef" /> was setup
        /// before calling it.
        /// </summary>
        public void LoadRoleRef()
        {
            if (_RoleRef != null)
                return;
            if (DelLoadRoleRef != null)
                _RoleRef = DelLoadRoleRef();
        }

        /// <summary>
        /// A delegate to load <see cref="UsersRoleHistory.RoleRef" />.
        /// </summary>
        public Func<Role> DelLoadRoleRef = null;

        /// <summary>
        /// A delegate to load <see cref="UsersRoleHistory.RoleRef" /> automatically when it is referred to at the first time.
        /// </summary>
        public Func<Role> AutoLoadRoleRef = null;

        /// <summary>
        /// Entity in data set "Users" for <see cref="User" /> that this entity depend upon through .
        /// The corresponding foreign key set is { <see cref="UsersRoleHistory.UserID" /> }.
        /// </summary>
        [DataMember]
        public User User_UserID
        {
            get 
            {
                if (_User_UserID == null && AutoLoadUser_UserID != null)
                    _User_UserID = AutoLoadUser_UserID();
                return _User_UserID; 
            }
            set 
            { 
                _User_UserID = value; 
            }
        }
        private User _User_UserID = null;

        /// <summary>
        /// <see cref="UsersRoleHistory.User_UserID" /> is not initialized when the entity is created. Clients could call this method to load it provided a proper delegate <see cref="UsersRoleHistory.DelLoadUser_UserID" /> was setup
        /// before calling it.
        /// </summary>
        public void LoadUser_UserID()
        {
            if (_User_UserID != null)
                return;
            if (DelLoadUser_UserID != null)
                _User_UserID = DelLoadUser_UserID();
        }

        /// <summary>
        /// A delegate to load <see cref="UsersRoleHistory.User_UserID" />.
        /// </summary>
        public Func<User> DelLoadUser_UserID = null;

        /// <summary>
        /// A delegate to load <see cref="UsersRoleHistory.User_UserID" /> automatically when it is referred to at the first time.
        /// </summary>
        public Func<User> AutoLoadUser_UserID = null;

        /// <summary>
        /// Entity in data set "Users" for <see cref="User" /> that this entity depend upon through .
        /// The corresponding foreign key set is { <see cref="UsersRoleHistory.OperatorID" /> }.
        /// </summary>
        [DataMember]
        public User User_OperatorID
        {
            get 
            {
                if (_User_OperatorID == null && AutoLoadUser_OperatorID != null)
                    _User_OperatorID = AutoLoadUser_OperatorID();
                return _User_OperatorID; 
            }
            set 
            { 
                _User_OperatorID = value; 
            }
        }
        private User _User_OperatorID = null;

        /// <summary>
        /// <see cref="UsersRoleHistory.User_OperatorID" /> is not initialized when the entity is created. Clients could call this method to load it provided a proper delegate <see cref="UsersRoleHistory.DelLoadUser_OperatorID" /> was setup
        /// before calling it.
        /// </summary>
        public void LoadUser_OperatorID()
        {
            if (_User_OperatorID != null)
                return;
            if (DelLoadUser_OperatorID != null)
                _User_OperatorID = DelLoadUser_OperatorID();
        }

        /// <summary>
        /// A delegate to load <see cref="UsersRoleHistory.User_OperatorID" />.
        /// </summary>
        public Func<User> DelLoadUser_OperatorID = null;

        /// <summary>
        /// A delegate to load <see cref="UsersRoleHistory.User_OperatorID" /> automatically when it is referred to at the first time.
        /// </summary>
        public Func<User> AutoLoadUser_OperatorID = null;

#endregion

#region Entities that depend on the current one.

#endregion

        /// <summary>
        /// Whether or not the present entity is identitical to <paramref name="other" />, in the sense that they have the same (set of) primary key(s).
        /// </summary>
        /// <param name="other">The entity to be compared to.</param>
        /// <returns>
        ///   The result of comparison.
        /// </returns>
        public bool IsEntityIdentical(UsersRoleHistory other)
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
        public bool IsEntityTheSame(UsersRoleHistory other)
        {
            if (other == null)
                return false;
            else
                return RoleID == other.RoleID &&  UserID == other.UserID;
        }              

        /// <summary>
        /// Merge changes inside entity <paramref name="from" /> to the entity <paramref name="to" />. Any changes in <paramref name="from" /> that is not changed in <paramref name="to" /> is updated inside <paramref name="to" />.
        /// </summary>
        /// <param name="from">The "old" entity acting as merging source.</param>
        /// <param name="to">The "new" entity which inherits changes made in <paramref name="from" />.</param>
        /// <returns>
        /// </returns>
        public static void MergeChanges(UsersRoleHistory from, UsersRoleHistory to)
        {
            if (to.IsPersisted)
            {
            }
            else
            {
                to.IsPersisted = from.IsPersisted;
                to.ID = from.ID;
                to.ChangeDate = from.ChangeDate;
                to.Operation = from.Operation;
                to.SubPriority = from.SubPriority;
                to.OperatorID = from.OperatorID;
                to.RoleID = from.RoleID;
                to.UserID = from.UserID;
            }
        }

        /// <summary>
        /// Update changes to the current entity compared to an input <paramref name="newdata" /> and set the entity to a proper state for updating.
        /// </summary>
        /// <param name="newdata">The "new" entity acting as the source of the changes, if any.</param>
        /// <returns>
        /// </returns>
        public void UpdateChanges(UsersRoleHistory newdata)
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
            if (Operation == null)
                Operation = "";
            if (OperatorID == null)
                OperatorID = "";
            if (UserID == null)
                UserID = "";
            IsInitializing = false;
        }

        /// <summary>
        /// Internal use
        /// </summary>
        public UsersRoleHistory ShallowCopy(bool allData = false)
        {
            UsersRoleHistory e = new UsersRoleHistory();
            e.IsInitializing = true;
            e.ID = ID;
            e.ChangeDate = ChangeDate;
            e.Operation = Operation;
            e.SubPriority = SubPriority;
            e.OperatorID = OperatorID;
            e.RoleID = RoleID;
            e.UserID = UserID;
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
----===== [[UsersRoleHistory]] =====----
  ID = " + ID + @"
  ChangeDate = " + ChangeDate + @"
  Operation = '" + Operation + @"'
  SubPriority = " + SubPriority + @"
  OperatorID = '" + OperatorID + @"'
  RoleID = " + RoleID + @"");
            sb.Append(@" (natural id)");
            sb.Append(@"
  UserID = '" + UserID + @"'");
            sb.Append(@" (natural id)");
            sb.Append(@"
");
            return sb.ToString();
        }

    }

    ///<summary>
    ///The result of an add or update of type <see cref="UsersRoleHistory" />.
    ///</summary>
    [DataContract]
    public class UsersRoleHistoryUpdateResult : IUpdateResult
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
        public UsersRoleHistory UpdatedItem
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
        public UsersRoleHistory ConflictItem
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
