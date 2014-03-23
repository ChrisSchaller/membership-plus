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
    /// A entity in "EventTypes" data set.
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
    ///      <description>See <see cref="EventType.ID" />. Primary key; intrinsic id; fixed; not null.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>Intrinsic Identifiers</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>ID</term>
    ///      <description>See <see cref="EventType.ID" />. Primary key; intrinsic id; fixed; not null.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>Editable properties</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>EventTypeName</term>
    ///      <description>See <see cref="EventType.EventTypeName" />. Editable; not null; max-length = 80 characters.</description>
    ///    </item>
    ///  </list>
    ///  <list type="table">
    ///    <listheader>
    ///       <term>The following entity sets depend on this entity</term><description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>EventCalendars</term>
    ///      <description>See <see cref="EventType.EventCalendars" />, which is a sub-set of the data set "EventCalendar" for <see cref="EventCalendar" />.</description>
    ///    </item>
    ///  </list>
    /// </remarks>
    [DataContract]
    public class EventType : IDbEntity 
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
        /// Used to matching entities in input adding or updating entity list and the returned ones, see <see cref="IEventTypeService.AddOrUpdateEntities" />.
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
            return String.Format(@"{0}", EventTypeName.Trim());
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
        [Required]
        [Editable(false)]
        [DataMember(IsRequired = true)]
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
        /// Meta-info: editable; not null; max-length = 80 characters.
        /// </summary>
        [Required]
        [Editable(true)]
        [StringLength(80)]
        [DataMember(IsRequired = true)]
        public string EventTypeName
        { 
            get
            {
                return _EventTypeName;
            }
            set
            {
                if (_EventTypeName != value)
                {
                    _EventTypeName = value;
                    if (!IsInitializing)
                        IsEventTypeNameModified = true;
                }
            }
        }
        private string _EventTypeName = default(string);

        /// <summary>
        /// Wether or not the value of <see cref="EventTypeName" /> was changed compared to what it was loaded last time. 
        /// Note: the backend data source updates the changed <see cref="EventTypeName" /> only if this is set to true no matter what
        /// the actual value of <see cref="EventTypeName" /> is.
        /// </summary>
        [DataMember]
        public bool IsEventTypeNameModified
        { 
            get
            {
                return _isEventTypeNameModified;
            }
            set
            {
                _isEventTypeNameModified = value;
            }
        }
        private bool _isEventTypeNameModified = false;

#endregion

#region Entities that the current one depends upon.

#endregion

#region Entities that depend on the current one.

        /// <summary>
        /// Entitity set <see cref="EventCalendarSet" /> for data set "EventCalendar" of <see cref="EventCalendar" /> that depend on the current entity.
        /// The corresponding foreign key in <see cref="EventCalendarSet" /> set is { <see cref="EventCalendar.EventTypeID" /> }.
        /// </summary>
        [DataMember]
		public EventCalendarSet EventCalendars
		{
			get
			{
                if (_EventCalendars == null)
                    _EventCalendars = new EventCalendarSet();
				return _EventCalendars;
			}
            set
            {
                _EventCalendars = value;
            }
		}
		private EventCalendarSet _EventCalendars = null;

        /// <summary>
        /// Entitites enumeration expression for data set "EventCalendar" of <see cref="EventCalendar" /> that depend on the current entity.
        /// The corresponding foreign key in <see cref="EventCalendarSet" /> set is { <see cref="EventCalendar.EventTypeID" /> }.
        /// </summary>
		public IEnumerable<EventCalendar> EventCalendarEnum
		{
			get;
            set;
		}

        /// <summary>
        /// A list of <see cref="EventCalendar" /> that is to be added or updated to the data source, together with the current entity.
        /// The corresponding foreign key in <see cref="EventCalendarSet" /> set is { <see cref="EventCalendar.EventTypeID" /> }.
        /// </summary>
        [DataMember]
		public EventCalendar[] ChangedEventCalendars
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
        public bool IsEntityIdentical(EventType other)
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
        public bool IsEntityTheSame(EventType other)
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
        public static void MergeChanges(EventType from, EventType to)
        {
            if (to.IsPersisted)
            {
                if (from.IsEventTypeNameModified && !to.IsEventTypeNameModified)
                {
                    to.EventTypeName = from.EventTypeName;
                    to.IsEventTypeNameModified = true;
                }
            }
            else
            {
                to.IsPersisted = from.IsPersisted;
                to.ID = from.ID;
                to.EventTypeName = from.EventTypeName;
                to.IsEventTypeNameModified = from.IsEventTypeNameModified;
            }
        }

        /// <summary>
        /// Update changes to the current entity compared to an input <paramref name="newdata" /> and set the entity to a proper state for updating.
        /// </summary>
        /// <param name="newdata">The "new" entity acting as the source of the changes, if any.</param>
        /// <returns>
        /// </returns>
        public void UpdateChanges(EventType newdata)
        {
            int cnt = 0;
            if (EventTypeName != newdata.EventTypeName)
            {
                EventTypeName = newdata.EventTypeName;
                IsEventTypeNameModified = true;
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
            if (EventTypeName == null)
                EventTypeName = "";
            if (!IsEntityChanged)
                IsEntityChanged = IsEventTypeNameModified;
            IsInitializing = false;
        }

        /// <summary>
        /// Internal use
        /// </summary>
        public EventType ShallowCopy(bool allData = false)
        {
            EventType e = new EventType();
            e.IsInitializing = true;
            e.ID = ID;
            e.EventTypeName = EventTypeName;
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
----===== [[EventType]] =====----
  ID = " + ID + @"");
            sb.Append(@" (natural id)");
            sb.Append(@"
  EventTypeName = '" + EventTypeName + @"'");
            if (IsEventTypeNameModified)
                sb.Append(@" (modified)");
            else
                sb.Append(@" (unchanged)");
            sb.Append(@"
");
            return sb.ToString();
        }

    }

    ///<summary>
    ///The result of an add or update of type <see cref="EventType" />.
    ///</summary>
    [DataContract]
    public class EventTypeUpdateResult : IUpdateResult
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
        public EventType UpdatedItem
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
        public EventType ConflictItem
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
