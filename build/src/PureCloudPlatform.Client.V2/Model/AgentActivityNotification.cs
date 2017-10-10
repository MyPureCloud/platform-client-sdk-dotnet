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
    /// AgentActivityNotification
    /// </summary>
    [DataContract]
    public partial class AgentActivityNotification :  IEquatable<AgentActivityNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentActivityNotification" /> class.
        /// </summary>
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="RoutingStatus">RoutingStatus.</param>
        
        
        
        /// <param name="Presence">Presence.</param>
        
        
        
        /// <param name="OutOfOffice">OutOfOffice.</param>
        
        
        
        /// <param name="ActiveQueueIds">ActiveQueueIds.</param>
        
        
        
        /// <param name="DateActiveQueuesChanged">DateActiveQueuesChanged.</param>
        
        
        public AgentActivityNotification(string Id = null, AgentActivityNotificationRoutingStatus RoutingStatus = null, AgentActivityNotificationPresence Presence = null, AgentActivityNotificationOutOfOffice OutOfOffice = null, List<string> ActiveQueueIds = null, DateTime? DateActiveQueuesChanged = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.RoutingStatus = RoutingStatus;
            
            
            
            
            
            
            
            
this.Presence = Presence;
            
            
            
            
            
            
            
            
this.OutOfOffice = OutOfOffice;
            
            
            
            
            
            
            
            
this.ActiveQueueIds = ActiveQueueIds;
            
            
            
            
            
            
            
            
this.DateActiveQueuesChanged = DateActiveQueuesChanged;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RoutingStatus
        /// </summary>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public AgentActivityNotificationRoutingStatus RoutingStatus { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Presence
        /// </summary>
        [DataMember(Name="presence", EmitDefaultValue=false)]
        public AgentActivityNotificationPresence Presence { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OutOfOffice
        /// </summary>
        [DataMember(Name="outOfOffice", EmitDefaultValue=false)]
        public AgentActivityNotificationOutOfOffice OutOfOffice { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ActiveQueueIds
        /// </summary>
        [DataMember(Name="activeQueueIds", EmitDefaultValue=false)]
        public List<string> ActiveQueueIds { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateActiveQueuesChanged
        /// </summary>
        [DataMember(Name="dateActiveQueuesChanged", EmitDefaultValue=false)]
        public DateTime? DateActiveQueuesChanged { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentActivityNotification {\n");
            
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AgentActivityNotification);
        }

        /// <summary>
        /// Returns true if AgentActivityNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentActivityNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentActivityNotification other)
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
