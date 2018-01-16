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
    /// OutOfOfficeNotification
    /// </summary>
    [DataContract]
    public partial class OutOfOfficeNotification :  IEquatable<OutOfOfficeNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OutOfOfficeNotification" /> class.
        /// </summary>
        
        
        /// <param name="User">User.</param>
        
        
        
        /// <param name="Active">Active.</param>
        
        
        
        /// <param name="Indefinite">Indefinite.</param>
        
        
        
        /// <param name="StartDate">StartDate.</param>
        
        
        
        /// <param name="EndDate">EndDate.</param>
        
        
        public OutOfOfficeNotification(DocumentDataV2NotificationWorkspace User = null, bool? Active = null, bool? Indefinite = null, DateTime? StartDate = null, DateTime? EndDate = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.User = User;
            
            
            
            
            
            
            
            
this.Active = Active;
            
            
            
            
            
            
            
            
this.Indefinite = Indefinite;
            
            
            
            
            
            
            
            
this.StartDate = StartDate;
            
            
            
            
            
            
            
            
this.EndDate = EndDate;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public DocumentDataV2NotificationWorkspace User { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Indefinite
        /// </summary>
        [DataMember(Name="indefinite", EmitDefaultValue=false)]
        public bool? Indefinite { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutOfOfficeNotification {\n");
            
            sb.Append("  User: ").Append(User).Append("\n");
            
            sb.Append("  Active: ").Append(Active).Append("\n");
            
            sb.Append("  Indefinite: ").Append(Indefinite).Append("\n");
            
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            
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
            return this.Equals(obj as OutOfOfficeNotification);
        }

        /// <summary>
        /// Returns true if OutOfOfficeNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of OutOfOfficeNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutOfOfficeNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) &&
                (
                    this.Indefinite == other.Indefinite ||
                    this.Indefinite != null &&
                    this.Indefinite.Equals(other.Indefinite)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
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
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                
                if (this.Indefinite != null)
                    hash = hash * 59 + this.Indefinite.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
