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
    /// Service Goal Group
    /// </summary>
    [DataContract]
    public partial class CreateServiceGoalGroupRequest :  IEquatable<CreateServiceGoalGroupRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceGoalGroupRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateServiceGoalGroupRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceGoalGroupRequest" /> class.
        /// </summary>
        /// <param name="Name">name (required).</param>
        /// <param name="Goals">Goals defined for this service goal group.</param>
        /// <param name="QueueMediaAssociations">List of queues and media types from that queue to associate with this service goal group.</param>
        public CreateServiceGoalGroupRequest(string Name = null, ServiceGoalGroupGoals Goals = null, List<CreateQueueMediaAssociationRequest> QueueMediaAssociations = null)
        {
            this.Name = Name;
            this.Goals = Goals;
            this.QueueMediaAssociations = QueueMediaAssociations;
            
        }
        
        
        
        /// <summary>
        /// name
        /// </summary>
        /// <value>name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Goals defined for this service goal group
        /// </summary>
        /// <value>Goals defined for this service goal group</value>
        [DataMember(Name="goals", EmitDefaultValue=false)]
        public ServiceGoalGroupGoals Goals { get; set; }
        
        
        
        /// <summary>
        /// List of queues and media types from that queue to associate with this service goal group
        /// </summary>
        /// <value>List of queues and media types from that queue to associate with this service goal group</value>
        [DataMember(Name="queueMediaAssociations", EmitDefaultValue=false)]
        public List<CreateQueueMediaAssociationRequest> QueueMediaAssociations { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateServiceGoalGroupRequest {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Goals: ").Append(Goals).Append("\n");
            sb.Append("  QueueMediaAssociations: ").Append(QueueMediaAssociations).Append("\n");
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
            return this.Equals(obj as CreateServiceGoalGroupRequest);
        }

        /// <summary>
        /// Returns true if CreateServiceGoalGroupRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateServiceGoalGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateServiceGoalGroupRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Goals == other.Goals ||
                    this.Goals != null &&
                    this.Goals.Equals(other.Goals)
                ) &&
                (
                    this.QueueMediaAssociations == other.QueueMediaAssociations ||
                    this.QueueMediaAssociations != null &&
                    this.QueueMediaAssociations.SequenceEqual(other.QueueMediaAssociations)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Goals != null)
                    hash = hash * 59 + this.Goals.GetHashCode();
                
                if (this.QueueMediaAssociations != null)
                    hash = hash * 59 + this.QueueMediaAssociations.GetHashCode();
                
                return hash;
            }
        }
    }

}
