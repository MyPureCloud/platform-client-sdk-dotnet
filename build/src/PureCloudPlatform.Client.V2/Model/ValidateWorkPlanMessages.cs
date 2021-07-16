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
    /// ValidateWorkPlanMessages
    /// </summary>
    [DataContract]
    public partial class ValidateWorkPlanMessages :  IEquatable<ValidateWorkPlanMessages>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateWorkPlanMessages" /> class.
        /// </summary>
        /// <param name="ViolationMessages">Messages for work plan violating some rules such as no shifts in a work plan.</param>
        /// <param name="ConstraintConflictMessage">This field is not null when there is a set of work plan constraints that conflict thus agent schedules cannot be generated.</param>
        public ValidateWorkPlanMessages(List<WorkPlanConfigurationViolationMessage> ViolationMessages = null, ConstraintConflictMessage ConstraintConflictMessage = null)
        {
            this.ViolationMessages = ViolationMessages;
            this.ConstraintConflictMessage = ConstraintConflictMessage;
            
        }
        
        
        
        /// <summary>
        /// Messages for work plan violating some rules such as no shifts in a work plan
        /// </summary>
        /// <value>Messages for work plan violating some rules such as no shifts in a work plan</value>
        [DataMember(Name="violationMessages", EmitDefaultValue=false)]
        public List<WorkPlanConfigurationViolationMessage> ViolationMessages { get; set; }
        
        
        
        /// <summary>
        /// This field is not null when there is a set of work plan constraints that conflict thus agent schedules cannot be generated
        /// </summary>
        /// <value>This field is not null when there is a set of work plan constraints that conflict thus agent schedules cannot be generated</value>
        [DataMember(Name="constraintConflictMessage", EmitDefaultValue=false)]
        public ConstraintConflictMessage ConstraintConflictMessage { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateWorkPlanMessages {\n");
            
            sb.Append("  ViolationMessages: ").Append(ViolationMessages).Append("\n");
            sb.Append("  ConstraintConflictMessage: ").Append(ConstraintConflictMessage).Append("\n");
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
            return this.Equals(obj as ValidateWorkPlanMessages);
        }

        /// <summary>
        /// Returns true if ValidateWorkPlanMessages instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidateWorkPlanMessages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateWorkPlanMessages other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ViolationMessages == other.ViolationMessages ||
                    this.ViolationMessages != null &&
                    this.ViolationMessages.SequenceEqual(other.ViolationMessages)
                ) &&
                (
                    this.ConstraintConflictMessage == other.ConstraintConflictMessage ||
                    this.ConstraintConflictMessage != null &&
                    this.ConstraintConflictMessage.Equals(other.ConstraintConflictMessage)
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
                
                if (this.ViolationMessages != null)
                    hash = hash * 59 + this.ViolationMessages.GetHashCode();
                
                if (this.ConstraintConflictMessage != null)
                    hash = hash * 59 + this.ConstraintConflictMessage.GetHashCode();
                
                return hash;
            }
        }
    }

}
