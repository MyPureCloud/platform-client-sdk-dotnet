using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// UserActivity
    /// </summary>
    [DataContract]
    public partial class UserActivity :  IEquatable<UserActivity>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UserActivity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserActivity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserActivity" /> class.
        /// </summary>
        /// <param name="Id">The ID of the user (required).</param>
        /// <param name="RoutingStatus">The current routing status of the user.</param>
        /// <param name="Presence">The current system presence of the user.</param>
        /// <param name="OutOfOffice">The current out of office state of the user.</param>
        /// <param name="ActiveQueueIds">The IDs of the queues for which the user is active (required).</param>
        /// <param name="DateActiveQueuesChanged">The date the activeQueueIds list was last modified. For reference only - subject to eventual consistency. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public UserActivity(string Id = null, UserActivityRoutingStatus RoutingStatus = null, UserActivityAdherencePresence Presence = null, UserActivityOutOfOffice OutOfOffice = null, List<string> ActiveQueueIds = null, DateTime? DateActiveQueuesChanged = null)
        {
            this.Id = Id;
            this.RoutingStatus = RoutingStatus;
            this.Presence = Presence;
            this.OutOfOffice = OutOfOffice;
            this.ActiveQueueIds = ActiveQueueIds;
            this.DateActiveQueuesChanged = DateActiveQueuesChanged;
            
        }
        


        /// <summary>
        /// The ID of the user
        /// </summary>
        /// <value>The ID of the user</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The current routing status of the user
        /// </summary>
        /// <value>The current routing status of the user</value>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public UserActivityRoutingStatus RoutingStatus { get; set; }



        /// <summary>
        /// The current system presence of the user
        /// </summary>
        /// <value>The current system presence of the user</value>
        [DataMember(Name="presence", EmitDefaultValue=false)]
        public UserActivityAdherencePresence Presence { get; set; }



        /// <summary>
        /// The current out of office state of the user
        /// </summary>
        /// <value>The current out of office state of the user</value>
        [DataMember(Name="outOfOffice", EmitDefaultValue=false)]
        public UserActivityOutOfOffice OutOfOffice { get; set; }



        /// <summary>
        /// The IDs of the queues for which the user is active
        /// </summary>
        /// <value>The IDs of the queues for which the user is active</value>
        [DataMember(Name="activeQueueIds", EmitDefaultValue=false)]
        public List<string> ActiveQueueIds { get; set; }



        /// <summary>
        /// The date the activeQueueIds list was last modified. For reference only - subject to eventual consistency. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the activeQueueIds list was last modified. For reference only - subject to eventual consistency. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateActiveQueuesChanged", EmitDefaultValue=false)]
        public DateTime? DateActiveQueuesChanged { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserActivity {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
            sb.Append("  OutOfOffice: ").Append(OutOfOffice).Append("\n");
            sb.Append("  ActiveQueueIds: ").Append(ActiveQueueIds).Append("\n");
            sb.Append("  DateActiveQueuesChanged: ").Append(DateActiveQueuesChanged).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UserActivity);
        }

        /// <summary>
        /// Returns true if UserActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of UserActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserActivity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.RoutingStatus == other.RoutingStatus ||
                    this.RoutingStatus != null &&
                    this.RoutingStatus.Equals(other.RoutingStatus)
                ) &&
                (
                    this.Presence == other.Presence ||
                    this.Presence != null &&
                    this.Presence.Equals(other.Presence)
                ) &&
                (
                    this.OutOfOffice == other.OutOfOffice ||
                    this.OutOfOffice != null &&
                    this.OutOfOffice.Equals(other.OutOfOffice)
                ) &&
                (
                    this.ActiveQueueIds == other.ActiveQueueIds ||
                    this.ActiveQueueIds != null &&
                    this.ActiveQueueIds.SequenceEqual(other.ActiveQueueIds)
                ) &&
                (
                    this.DateActiveQueuesChanged == other.DateActiveQueuesChanged ||
                    this.DateActiveQueuesChanged != null &&
                    this.DateActiveQueuesChanged.Equals(other.DateActiveQueuesChanged)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.RoutingStatus != null)
                    hash = hash * 59 + this.RoutingStatus.GetHashCode();

                if (this.Presence != null)
                    hash = hash * 59 + this.Presence.GetHashCode();

                if (this.OutOfOffice != null)
                    hash = hash * 59 + this.OutOfOffice.GetHashCode();

                if (this.ActiveQueueIds != null)
                    hash = hash * 59 + this.ActiveQueueIds.GetHashCode();

                if (this.DateActiveQueuesChanged != null)
                    hash = hash * 59 + this.DateActiveQueuesChanged.GetHashCode();

                return hash;
            }
        }
    }

}
