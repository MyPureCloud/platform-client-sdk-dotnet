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
    /// QueueUtilizationDiagnostic
    /// </summary>
    [DataContract]
    public partial class QueueUtilizationDiagnostic :  IEquatable<QueueUtilizationDiagnostic>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueUtilizationDiagnostic" /> class.
        /// </summary>
        /// <param name="Queue">Identifier of the queue.</param>
        public QueueUtilizationDiagnostic(DomainEntityRef Queue = null)
        {
            this.Queue = Queue;
            
        }
        
        
        
        /// <summary>
        /// Identifier of the queue
        /// </summary>
        /// <value>Identifier of the queue</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public DomainEntityRef Queue { get; set; }
        
        
        
        /// <summary>
        /// The number of users joined to the queue
        /// </summary>
        /// <value>The number of users joined to the queue</value>
        [DataMember(Name="usersInQueue", EmitDefaultValue=false)]
        public int? UsersInQueue { get; private set; }
        
        
        
        /// <summary>
        /// The number of users active on the queue
        /// </summary>
        /// <value>The number of users active on the queue</value>
        [DataMember(Name="activeUsersInQueue", EmitDefaultValue=false)]
        public int? ActiveUsersInQueue { get; private set; }
        
        
        
        /// <summary>
        /// The number of users with a status of on-queue
        /// </summary>
        /// <value>The number of users with a status of on-queue</value>
        [DataMember(Name="usersOnQueue", EmitDefaultValue=false)]
        public int? UsersOnQueue { get; private set; }
        
        
        
        /// <summary>
        /// The number of users in the queue currently not engaged
        /// </summary>
        /// <value>The number of users in the queue currently not engaged</value>
        [DataMember(Name="usersNotUtilized", EmitDefaultValue=false)]
        public int? UsersNotUtilized { get; private set; }
        
        
        
        /// <summary>
        /// The number of users in the queue with a station
        /// </summary>
        /// <value>The number of users in the queue with a station</value>
        [DataMember(Name="usersOnQueueWithStation", EmitDefaultValue=false)]
        public int? UsersOnQueueWithStation { get; private set; }
        
        
        
        /// <summary>
        /// The number of users currently engaged in a campaign call
        /// </summary>
        /// <value>The number of users currently engaged in a campaign call</value>
        [DataMember(Name="usersOnACampaignCall", EmitDefaultValue=false)]
        public int? UsersOnACampaignCall { get; private set; }
        
        
        
        /// <summary>
        /// The number of users whose station is homed to an edge different from the campaign
        /// </summary>
        /// <value>The number of users whose station is homed to an edge different from the campaign</value>
        [DataMember(Name="usersOnDifferentEdgeGroup", EmitDefaultValue=false)]
        public int? UsersOnDifferentEdgeGroup { get; private set; }
        
        
        
        /// <summary>
        /// The number of users currently engaged in a communication that is not part of the campaign
        /// </summary>
        /// <value>The number of users currently engaged in a communication that is not part of the campaign</value>
        [DataMember(Name="usersOnANonCampaignCall", EmitDefaultValue=false)]
        public int? UsersOnANonCampaignCall { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueUtilizationDiagnostic {\n");
            
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  UsersInQueue: ").Append(UsersInQueue).Append("\n");
            sb.Append("  ActiveUsersInQueue: ").Append(ActiveUsersInQueue).Append("\n");
            sb.Append("  UsersOnQueue: ").Append(UsersOnQueue).Append("\n");
            sb.Append("  UsersNotUtilized: ").Append(UsersNotUtilized).Append("\n");
            sb.Append("  UsersOnQueueWithStation: ").Append(UsersOnQueueWithStation).Append("\n");
            sb.Append("  UsersOnACampaignCall: ").Append(UsersOnACampaignCall).Append("\n");
            sb.Append("  UsersOnDifferentEdgeGroup: ").Append(UsersOnDifferentEdgeGroup).Append("\n");
            sb.Append("  UsersOnANonCampaignCall: ").Append(UsersOnANonCampaignCall).Append("\n");
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
            return this.Equals(obj as QueueUtilizationDiagnostic);
        }

        /// <summary>
        /// Returns true if QueueUtilizationDiagnostic instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueUtilizationDiagnostic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueUtilizationDiagnostic other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.UsersInQueue == other.UsersInQueue ||
                    this.UsersInQueue != null &&
                    this.UsersInQueue.Equals(other.UsersInQueue)
                ) &&
                (
                    this.ActiveUsersInQueue == other.ActiveUsersInQueue ||
                    this.ActiveUsersInQueue != null &&
                    this.ActiveUsersInQueue.Equals(other.ActiveUsersInQueue)
                ) &&
                (
                    this.UsersOnQueue == other.UsersOnQueue ||
                    this.UsersOnQueue != null &&
                    this.UsersOnQueue.Equals(other.UsersOnQueue)
                ) &&
                (
                    this.UsersNotUtilized == other.UsersNotUtilized ||
                    this.UsersNotUtilized != null &&
                    this.UsersNotUtilized.Equals(other.UsersNotUtilized)
                ) &&
                (
                    this.UsersOnQueueWithStation == other.UsersOnQueueWithStation ||
                    this.UsersOnQueueWithStation != null &&
                    this.UsersOnQueueWithStation.Equals(other.UsersOnQueueWithStation)
                ) &&
                (
                    this.UsersOnACampaignCall == other.UsersOnACampaignCall ||
                    this.UsersOnACampaignCall != null &&
                    this.UsersOnACampaignCall.Equals(other.UsersOnACampaignCall)
                ) &&
                (
                    this.UsersOnDifferentEdgeGroup == other.UsersOnDifferentEdgeGroup ||
                    this.UsersOnDifferentEdgeGroup != null &&
                    this.UsersOnDifferentEdgeGroup.Equals(other.UsersOnDifferentEdgeGroup)
                ) &&
                (
                    this.UsersOnANonCampaignCall == other.UsersOnANonCampaignCall ||
                    this.UsersOnANonCampaignCall != null &&
                    this.UsersOnANonCampaignCall.Equals(other.UsersOnANonCampaignCall)
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
                
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                
                if (this.UsersInQueue != null)
                    hash = hash * 59 + this.UsersInQueue.GetHashCode();
                
                if (this.ActiveUsersInQueue != null)
                    hash = hash * 59 + this.ActiveUsersInQueue.GetHashCode();
                
                if (this.UsersOnQueue != null)
                    hash = hash * 59 + this.UsersOnQueue.GetHashCode();
                
                if (this.UsersNotUtilized != null)
                    hash = hash * 59 + this.UsersNotUtilized.GetHashCode();
                
                if (this.UsersOnQueueWithStation != null)
                    hash = hash * 59 + this.UsersOnQueueWithStation.GetHashCode();
                
                if (this.UsersOnACampaignCall != null)
                    hash = hash * 59 + this.UsersOnACampaignCall.GetHashCode();
                
                if (this.UsersOnDifferentEdgeGroup != null)
                    hash = hash * 59 + this.UsersOnDifferentEdgeGroup.GetHashCode();
                
                if (this.UsersOnANonCampaignCall != null)
                    hash = hash * 59 + this.UsersOnANonCampaignCall.GetHashCode();
                
                return hash;
            }
        }
    }

}
