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
    /// EmailMediaPolicyConditions
    /// </summary>
    [DataContract]
    public partial class EmailMediaPolicyConditions :  IEquatable<EmailMediaPolicyConditions>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailMediaPolicyConditions" /> class.
        /// </summary>
        /// <param name="ForUsers">ForUsers.</param>
        /// <param name="DateRanges">DateRanges.</param>
        /// <param name="ForQueues">ForQueues.</param>
        /// <param name="WrapupCodes">WrapupCodes.</param>
        /// <param name="Languages">Languages.</param>
        /// <param name="TimeAllowed">TimeAllowed.</param>
        public EmailMediaPolicyConditions(List<User> ForUsers = null, List<string> DateRanges = null, List<Queue> ForQueues = null, List<WrapupCode> WrapupCodes = null, List<Language> Languages = null, TimeAllowed TimeAllowed = null)
        {
            this.ForUsers = ForUsers;
            this.DateRanges = DateRanges;
            this.ForQueues = ForQueues;
            this.WrapupCodes = WrapupCodes;
            this.Languages = Languages;
            this.TimeAllowed = TimeAllowed;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets ForUsers
        /// </summary>
        [DataMember(Name="forUsers", EmitDefaultValue=false)]
        public List<User> ForUsers { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateRanges
        /// </summary>
        [DataMember(Name="dateRanges", EmitDefaultValue=false)]
        public List<string> DateRanges { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ForQueues
        /// </summary>
        [DataMember(Name="forQueues", EmitDefaultValue=false)]
        public List<Queue> ForQueues { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets WrapupCodes
        /// </summary>
        [DataMember(Name="wrapupCodes", EmitDefaultValue=false)]
        public List<WrapupCode> WrapupCodes { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<Language> Languages { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets TimeAllowed
        /// </summary>
        [DataMember(Name="timeAllowed", EmitDefaultValue=false)]
        public TimeAllowed TimeAllowed { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailMediaPolicyConditions {\n");
            
            sb.Append("  ForUsers: ").Append(ForUsers).Append("\n");
            sb.Append("  DateRanges: ").Append(DateRanges).Append("\n");
            sb.Append("  ForQueues: ").Append(ForQueues).Append("\n");
            sb.Append("  WrapupCodes: ").Append(WrapupCodes).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  TimeAllowed: ").Append(TimeAllowed).Append("\n");
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
            return this.Equals(obj as EmailMediaPolicyConditions);
        }

        /// <summary>
        /// Returns true if EmailMediaPolicyConditions instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailMediaPolicyConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailMediaPolicyConditions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ForUsers == other.ForUsers ||
                    this.ForUsers != null &&
                    this.ForUsers.SequenceEqual(other.ForUsers)
                ) &&
                (
                    this.DateRanges == other.DateRanges ||
                    this.DateRanges != null &&
                    this.DateRanges.SequenceEqual(other.DateRanges)
                ) &&
                (
                    this.ForQueues == other.ForQueues ||
                    this.ForQueues != null &&
                    this.ForQueues.SequenceEqual(other.ForQueues)
                ) &&
                (
                    this.WrapupCodes == other.WrapupCodes ||
                    this.WrapupCodes != null &&
                    this.WrapupCodes.SequenceEqual(other.WrapupCodes)
                ) &&
                (
                    this.Languages == other.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(other.Languages)
                ) &&
                (
                    this.TimeAllowed == other.TimeAllowed ||
                    this.TimeAllowed != null &&
                    this.TimeAllowed.Equals(other.TimeAllowed)
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
                
                if (this.ForUsers != null)
                    hash = hash * 59 + this.ForUsers.GetHashCode();
                
                if (this.DateRanges != null)
                    hash = hash * 59 + this.DateRanges.GetHashCode();
                
                if (this.ForQueues != null)
                    hash = hash * 59 + this.ForQueues.GetHashCode();
                
                if (this.WrapupCodes != null)
                    hash = hash * 59 + this.WrapupCodes.GetHashCode();
                
                if (this.Languages != null)
                    hash = hash * 59 + this.Languages.GetHashCode();
                
                if (this.TimeAllowed != null)
                    hash = hash * 59 + this.TimeAllowed.GetHashCode();
                
                return hash;
            }
        }
    }

}
