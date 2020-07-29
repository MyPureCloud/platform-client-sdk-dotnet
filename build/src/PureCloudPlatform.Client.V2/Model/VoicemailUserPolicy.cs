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
    /// VoicemailUserPolicy
    /// </summary>
    [DataContract]
    public partial class VoicemailUserPolicy :  IEquatable<VoicemailUserPolicy>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailUserPolicy" /> class.
        /// </summary>
        /// <param name="AlertTimeoutSeconds">The number of seconds to ring the user&#39;s phone before a call is transfered to voicemail.</param>
        /// <param name="Pin">The user&#39;s PIN to access their voicemail. This property is only used for updates and never provided otherwise to ensure security.</param>
        /// <param name="SendEmailNotifications">Whether email notifications are sent to the user when a new voicemail is received.</param>
        public VoicemailUserPolicy(int? AlertTimeoutSeconds = null, string Pin = null, bool? SendEmailNotifications = null)
        {
            this.AlertTimeoutSeconds = AlertTimeoutSeconds;
            this.Pin = Pin;
            this.SendEmailNotifications = SendEmailNotifications;
            
        }
        
        
        
        /// <summary>
        /// Whether the user has voicemail enabled
        /// </summary>
        /// <value>Whether the user has voicemail enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; private set; }
        
        
        
        /// <summary>
        /// The number of seconds to ring the user&#39;s phone before a call is transfered to voicemail
        /// </summary>
        /// <value>The number of seconds to ring the user&#39;s phone before a call is transfered to voicemail</value>
        [DataMember(Name="alertTimeoutSeconds", EmitDefaultValue=false)]
        public int? AlertTimeoutSeconds { get; set; }
        
        
        
        /// <summary>
        /// The user&#39;s PIN to access their voicemail. This property is only used for updates and never provided otherwise to ensure security
        /// </summary>
        /// <value>The user&#39;s PIN to access their voicemail. This property is only used for updates and never provided otherwise to ensure security</value>
        [DataMember(Name="pin", EmitDefaultValue=false)]
        public string Pin { get; set; }
        
        
        
        /// <summary>
        /// The date the policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date the policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; private set; }
        
        
        
        /// <summary>
        /// Whether email notifications are sent to the user when a new voicemail is received
        /// </summary>
        /// <value>Whether email notifications are sent to the user when a new voicemail is received</value>
        [DataMember(Name="sendEmailNotifications", EmitDefaultValue=false)]
        public bool? SendEmailNotifications { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicemailUserPolicy {\n");
            
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  AlertTimeoutSeconds: ").Append(AlertTimeoutSeconds).Append("\n");
            sb.Append("  Pin: ").Append(Pin).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  SendEmailNotifications: ").Append(SendEmailNotifications).Append("\n");
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
            return this.Equals(obj as VoicemailUserPolicy);
        }

        /// <summary>
        /// Returns true if VoicemailUserPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailUserPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailUserPolicy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.AlertTimeoutSeconds == other.AlertTimeoutSeconds ||
                    this.AlertTimeoutSeconds != null &&
                    this.AlertTimeoutSeconds.Equals(other.AlertTimeoutSeconds)
                ) &&
                (
                    this.Pin == other.Pin ||
                    this.Pin != null &&
                    this.Pin.Equals(other.Pin)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.SendEmailNotifications == other.SendEmailNotifications ||
                    this.SendEmailNotifications != null &&
                    this.SendEmailNotifications.Equals(other.SendEmailNotifications)
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
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.AlertTimeoutSeconds != null)
                    hash = hash * 59 + this.AlertTimeoutSeconds.GetHashCode();
                
                if (this.Pin != null)
                    hash = hash * 59 + this.Pin.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                if (this.SendEmailNotifications != null)
                    hash = hash * 59 + this.SendEmailNotifications.GetHashCode();
                
                return hash;
            }
        }
    }

}
