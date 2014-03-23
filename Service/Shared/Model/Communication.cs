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
    /// A entity in "Communications" data set.
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
    ///      <description>See <see cref="Communication.ID" />. Primary key; intrinsic id; fixed; not null.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>Intrinsic Identifiers</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>ID</term>
    ///      <description>See <see cref="Communication.ID" />. Primary key; intrinsic id; fixed; not null.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>Editable properties</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>AddressInfo</term>
    ///      <description>See <see cref="Communication.AddressInfo" />. Editable; not null; max-length = 250 characters.</description>
    ///    </item>
    ///    <item>
    ///      <term>Comment</term>
    ///      <description>See <see cref="Communication.Comment" />. Editable; nullable; load delayed; max-length = 1500 characters.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>Foreign keys</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>ApplicationID</term>
    ///      <description>See <see cref="Communication.ApplicationID" />. Fixed; not null; foreign key.</description>
    ///    </item>
    ///    <item>
    ///      <term>TypeID</term>
    ///      <description>See <see cref="Communication.TypeID" />. Fixed; not null; foreign key.</description>
    ///    </item>
    ///    <item>
    ///      <term>UserID</term>
    ///      <description>See <see cref="Communication.UserID" />. Fixed; not null; foreign key.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>This entity depends on</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>Application_Ref</term>
    ///      <description>See <see cref="Communication.Application_Ref" />, which is a member of the data set "Applications" for <see cref="Application_" />.</description>
    ///    </item>
    ///    <item>
    ///      <term>CommunicationTypeRef</term>
    ///      <description>See <see cref="Communication.CommunicationTypeRef" />, which is a member of the data set "CommunicationTypes" for <see cref="CommunicationType" />.</description>
    ///    </item>
    ///    <item>
    ///      <term>UserRef</term>
    ///      <description>See <see cref="Communication.UserRef" />, which is a member of the data set "Users" for <see cref="User" />.</description>
    ///    </item>
    ///  </list>
    /// </remarks>
    [DataContract]
    public class Communication : IDbEntity 
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
                return this.ID;
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
        /// Used to matching entities in input adding or updating entity list and the returned ones, see <see cref="ICommunicationService.AddOrUpdateEntities" />.
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
            LoadCommunicationTypeRef();
            LoadUserRef();
            return String.Format(@"{0}: {1} for {2}", (CommunicationTypeRef != null ? CommunicationTypeRef.DistinctString : ""), AddressInfo.Trim(), (UserRef != null ? UserRef.DistinctString : ""));
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
        /// Meta-info: primary key; intrinsic id; fixed; not null.
        /// </summary>
        [Key]
        [Editable(false)]
        [DataMember(IsRequired = true)]
        public string ID
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
        private string _ID = default(string);

        /// <summary>
        /// Meta-info: editable; not null; max-length = 250 characters.
        /// </summary>
        [Required]
        [Editable(true)]
        [StringLength(250)]
        [DataMember(IsRequired = true)]
        public string AddressInfo
        { 
            get
            {
                return _AddressInfo;
            }
            set
            {
                if (_AddressInfo != value)
                {
                    _AddressInfo = value;
                    if (!IsInitializing)
                        IsAddressInfoModified = true;
                }
            }
        }
        private string _AddressInfo = default(string);

        /// <summary>
        /// Wether or not the value of <see cref="AddressInfo" /> was changed compared to what it was loaded last time. 
        /// Note: the backend data source updates the changed <see cref="AddressInfo" /> only if this is set to true no matter what
        /// the actual value of <see cref="AddressInfo" /> is.
        /// </summary>
        [DataMember]
        public bool IsAddressInfoModified
        { 
            get
            {
                return _isAddressInfoModified;
            }
            set
            {
                _isAddressInfoModified = value;
            }
        }
        private bool _isAddressInfoModified = false;

        /// <summary>
        /// Meta-info: editable; nullable; load delayed; max-length = 1500 characters.
        /// </summary>
        [Editable(true)]
        [StringLength(1500)]
        [DataMember(IsRequired = false)]
        public string Comment
        { 
            get
            {
                return _Comment;
            }
            set
            {
                if (_Comment != value)
                {
                    _Comment = value;
                    if (!IsInitializing)
                        IsCommentModified = true;
                }
            }
        }
        private string _Comment = default(string);

        /// <summary>
        /// Wether or not the value of <see cref="Comment" /> was changed compared to what it was loaded last time. 
        /// Note: the backend data source updates the changed <see cref="Comment" /> only if this is set to true no matter what
        /// the actual value of <see cref="Comment" /> is.
        /// </summary>
        [DataMember]
        public bool IsCommentModified
        { 
            get
            {
                return _isCommentModified;
            }
            set
            {
                _isCommentModified = value;
            }
        }
        private bool _isCommentModified = false;

        /// <summary>
        /// Wether or not the value of the delay loaded "Comment" is Loaded. Clients are responsible for keeping 
        /// track of loading status of delay loading properties.
        /// </summary>
        [DataMember]
        public bool IsCommentLoaded
        { 
            get
            {
                return _isCommentLoaded;
            }
            set
            {
                _isCommentLoaded = value;
            }
        }
        private bool _isCommentLoaded = false;

        /// <summary>
        /// Meta-info: fixed; not null; foreign key.
        /// </summary>
        [Required]
        [Editable(false)]
        [DataMember(IsRequired = true)]
        public string ApplicationID
        { 
            get
            {
                return _ApplicationID;
            }
            set
            {
                if (_ApplicationID != value)
                {
                    _ApplicationID = value;
                }
            }
        }
        private string _ApplicationID = default(string);

        /// <summary>
        /// Meta-info: fixed; not null; foreign key.
        /// </summary>
        [Required]
        [Editable(false)]
        [DataMember(IsRequired = true)]
        public int TypeID
        { 
            get
            {
                return _TypeID;
            }
            set
            {
                if (_TypeID != value)
                {
                    _TypeID = value;
                }
            }
        }
        private int _TypeID = default(int);

        /// <summary>
        /// Meta-info: fixed; not null; foreign key.
        /// </summary>
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
        /// Entity in data set "Applications" for <see cref="Application_" /> that this entity depend upon through .
        /// The corresponding foreign key set is { <see cref="Communication.ApplicationID" /> }.
        /// </summary>
        [DataMember]
        public Application_ Application_Ref
        {
            get 
            {
                if (_Application_Ref == null && AutoLoadApplication_Ref != null)
                    _Application_Ref = AutoLoadApplication_Ref();
                return _Application_Ref; 
            }
            set 
            { 
                _Application_Ref = value; 
            }
        }
        private Application_ _Application_Ref = null;

        /// <summary>
        /// <see cref="Communication.Application_Ref" /> is not initialized when the entity is created. Clients could call this method to load it provided a proper delegate <see cref="Communication.DelLoadApplication_Ref" /> was setup
        /// before calling it.
        /// </summary>
        public void LoadApplication_Ref()
        {
            if (_Application_Ref != null)
                return;
            if (DelLoadApplication_Ref != null)
                _Application_Ref = DelLoadApplication_Ref();
        }

        /// <summary>
        /// A delegate to load <see cref="Communication.Application_Ref" />.
        /// </summary>
        public Func<Application_> DelLoadApplication_Ref = null;

        /// <summary>
        /// A delegate to load <see cref="Communication.Application_Ref" /> automatically when it is referred to at the first time.
        /// </summary>
        public Func<Application_> AutoLoadApplication_Ref = null;

        /// <summary>
        /// Entity in data set "CommunicationTypes" for <see cref="CommunicationType" /> that this entity depend upon through .
        /// The corresponding foreign key set is { <see cref="Communication.TypeID" /> }.
        /// </summary>
        [DataMember]
        public CommunicationType CommunicationTypeRef
        {
            get 
            {
                if (_CommunicationTypeRef == null && AutoLoadCommunicationTypeRef != null)
                    _CommunicationTypeRef = AutoLoadCommunicationTypeRef();
                return _CommunicationTypeRef; 
            }
            set 
            { 
                _CommunicationTypeRef = value; 
            }
        }
        private CommunicationType _CommunicationTypeRef = null;

        /// <summary>
        /// <see cref="Communication.CommunicationTypeRef" /> is not initialized when the entity is created. Clients could call this method to load it provided a proper delegate <see cref="Communication.DelLoadCommunicationTypeRef" /> was setup
        /// before calling it.
        /// </summary>
        public void LoadCommunicationTypeRef()
        {
            if (_CommunicationTypeRef != null)
                return;
            if (DelLoadCommunicationTypeRef != null)
                _CommunicationTypeRef = DelLoadCommunicationTypeRef();
        }

        /// <summary>
        /// A delegate to load <see cref="Communication.CommunicationTypeRef" />.
        /// </summary>
        public Func<CommunicationType> DelLoadCommunicationTypeRef = null;

        /// <summary>
        /// A delegate to load <see cref="Communication.CommunicationTypeRef" /> automatically when it is referred to at the first time.
        /// </summary>
        public Func<CommunicationType> AutoLoadCommunicationTypeRef = null;

        /// <summary>
        /// Entity in data set "Users" for <see cref="User" /> that this entity depend upon through .
        /// The corresponding foreign key set is { <see cref="Communication.UserID" /> }.
        /// </summary>
        [DataMember]
        public User UserRef
        {
            get 
            {
                if (_UserRef == null && AutoLoadUserRef != null)
                    _UserRef = AutoLoadUserRef();
                return _UserRef; 
            }
            set 
            { 
                _UserRef = value; 
            }
        }
        private User _UserRef = null;

        /// <summary>
        /// <see cref="Communication.UserRef" /> is not initialized when the entity is created. Clients could call this method to load it provided a proper delegate <see cref="Communication.DelLoadUserRef" /> was setup
        /// before calling it.
        /// </summary>
        public void LoadUserRef()
        {
            if (_UserRef != null)
                return;
            if (DelLoadUserRef != null)
                _UserRef = DelLoadUserRef();
        }

        /// <summary>
        /// A delegate to load <see cref="Communication.UserRef" />.
        /// </summary>
        public Func<User> DelLoadUserRef = null;

        /// <summary>
        /// A delegate to load <see cref="Communication.UserRef" /> automatically when it is referred to at the first time.
        /// </summary>
        public Func<User> AutoLoadUserRef = null;

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
        public bool IsEntityIdentical(Communication other)
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
        public bool IsEntityTheSame(Communication other)
        {
            if (other == null)
                return false;
            else
                return ID == other.ID;
        }              

        /// <summary>
        /// Merge changes inside entity <paramref name="from" /> to the entity <paramref name="to" />. Any changes in <paramref name="from" /> that is not changed in <paramref name="to" /> is updated inside <paramref name="to" />.
        /// </summary>
        /// <param name="from">The "old" entity acting as merging source.</param>
        /// <param name="to">The "new" entity which inherits changes made in <paramref name="from" />.</param>
        /// <returns>
        /// </returns>
        public static void MergeChanges(Communication from, Communication to)
        {
            if (to.IsPersisted)
            {
                if (from.IsAddressInfoModified && !to.IsAddressInfoModified)
                {
                    to.AddressInfo = from.AddressInfo;
                    to.IsAddressInfoModified = true;
                }
                if (from.IsCommentModified && !to.IsCommentModified)
                {
                    to.Comment = from.Comment;
                    to.IsCommentModified = true;
                }
            }
            else
            {
                to.IsPersisted = from.IsPersisted;
                to.ID = from.ID;
                to.AddressInfo = from.AddressInfo;
                to.IsAddressInfoModified = from.IsAddressInfoModified;
                to.Comment = from.Comment;
                to.IsCommentModified = from.IsCommentModified;
                to.ApplicationID = from.ApplicationID;
                to.TypeID = from.TypeID;
                to.UserID = from.UserID;
            }
        }

        /// <summary>
        /// Update changes to the current entity compared to an input <paramref name="newdata" /> and set the entity to a proper state for updating.
        /// </summary>
        /// <param name="newdata">The "new" entity acting as the source of the changes, if any.</param>
        /// <returns>
        /// </returns>
        public void UpdateChanges(Communication newdata)
        {
            int cnt = 0;
            if (AddressInfo != newdata.AddressInfo)
            {
                AddressInfo = newdata.AddressInfo;
                IsAddressInfoModified = true;
                cnt++;
            }
            if (Comment != newdata.Comment)
            {
                Comment = newdata.Comment;
                IsCommentModified = true;
                cnt++;
            }
            IsEntityChanged = cnt > 0;
        }

        /// <summary>
        /// Internal use
        /// </summary>
        public void NormalizeValues()
        {
            IsInitializing = true;
            if (AddressInfo == null)
                AddressInfo = "";
            if (ApplicationID == null)
                ApplicationID = "";
            if (UserID == null)
                UserID = "";
            if (!IsEntityChanged)
                IsEntityChanged = IsAddressInfoModified || IsCommentModified;
            if (IsCommentModified && !IsCommentLoaded)
                IsCommentLoaded = true;
            IsInitializing = false;
        }

        /// <summary>
        /// Internal use
        /// </summary>
        public Communication ShallowCopy(bool allData = false)
        {
            Communication e = new Communication();
            e.IsInitializing = true;
            e.ID = ID;
            e.AddressInfo = AddressInfo;
            e.ApplicationID = ApplicationID;
            e.TypeID = TypeID;
            e.UserID = UserID;
            if (allData)
            {
                e.Comment = Comment;
            }
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
----===== [[Communication]] =====----
  ID = '" + ID + @"'");
            sb.Append(@" (natural id)");
            sb.Append(@"
  AddressInfo = '" + AddressInfo + @"'");
            if (IsAddressInfoModified)
                sb.Append(@" (modified)");
            else
                sb.Append(@" (unchanged)");
            sb.Append(@"
  ApplicationID = '" + ApplicationID + @"'
  TypeID = " + TypeID + @"
  UserID = '" + UserID + @"'
");
            return sb.ToString();
        }

    }

    ///<summary>
    ///The result of an add or update of type <see cref="Communication" />.
    ///</summary>
    [DataContract]
    public class CommunicationUpdateResult : IUpdateResult
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
        public Communication UpdatedItem
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
        public Communication ConflictItem
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
