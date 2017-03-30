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
    /// VoicemailOrganizationPolicy
    /// </summary>
    [DataContract]
    public partial class VoicemailOrganizationPolicy :  IEquatable<VoicemailOrganizationPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailOrganizationPolicy" /> class.
        /// </summary>
        /// <param name="AlertTimeoutSeconds">The organization&#39;s default number of seconds to ring a user&#39;s phone before a call is transfered to voicemail.</param>
        /// <param name="PinConfiguration">The configuration for user PINs to access their voicemail from a phone.</param>
        /// <param name="VoicemailExtension">The extension for voicemail retrieval.  The default value is *86..</param>
        /// <param name="PinRequired">If this is true, a PIN is required when accessing a user&#39;s voicemail from a phone..</param>
        /// <param name="SendEmailNotifications">Whether email notifications are sent for new voicemails in the organization. If false, new voicemail email notifications are not be sent for the organization overriding any user or group setting..</param>
        public VoicemailOrganizationPolicy(int? AlertTimeoutSeconds = null, PINConfiguration PinConfiguration = null, string VoicemailExtension = null, bool? PinRequired = null, bool? SendEmailNotifications = null)
        {
            this.AlertTimeoutSeconds = AlertTimeoutSeconds;
            this.PinConfiguration = PinConfiguration;
            this.VoicemailExtension = VoicemailExtension;
            this.PinRequired = PinRequired;
            this.SendEmailNotifications = SendEmailNotifications;
        }
        
        /// <summary>
        /// Whether voicemail is enable for this organization
        /// </summary>
        /// <value>Whether voicemail is enable for this organization</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; private set; }
        /// <summary>
        /// The organization&#39;s default number of seconds to ring a user&#39;s phone before a call is transfered to voicemail
        /// </summary>
        /// <value>The organization&#39;s default number of seconds to ring a user&#39;s phone before a call is transfered to voicemail</value>
        [DataMember(Name="alertTimeoutSeconds", EmitDefaultValue=false)]
        public int? AlertTimeoutSeconds { get; set; }
        /// <summary>
        /// The configuration for user PINs to access their voicemail from a phone
        /// </summary>
        /// <value>The configuration for user PINs to access their voicemail from a phone</value>
        [DataMember(Name="pinConfiguration", EmitDefaultValue=false)]
        public PINConfiguration PinConfiguration { get; set; }
        /// <summary>
        /// The extension for voicemail retrieval.  The default value is *86.
        /// </summary>
        /// <value>The extension for voicemail retrieval.  The default value is *86.</value>
        [DataMember(Name="voicemailExtension", EmitDefaultValue=false)]
        public string VoicemailExtension { get; set; }
        /// <summary>
        /// If this is true, a PIN is required when accessing a user&#39;s voicemail from a phone.
        /// </summary>
        /// <value>If this is true, a PIN is required when accessing a user&#39;s voicemail from a phone.</value>
        [DataMember(Name="pinRequired", EmitDefaultValue=false)]
        public bool? PinRequired { get; set; }
        /// <summary>
        /// Whether email notifications are sent for new voicemails in the organization. If false, new voicemail email notifications are not be sent for the organization overriding any user or group setting.
        /// </summary>
        /// <value>Whether email notifications are sent for new voicemails in the organization. If false, new voicemail email notifications are not be sent for the organization overriding any user or group setting.</value>
        [DataMember(Name="sendEmailNotifications", EmitDefaultValue=false)]
        public bool? SendEmailNotifications { get; set; }
        /// <summary>
        /// The date the policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date the policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicemailOrganizationPolicy {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  AlertTimeoutSeconds: ").Append(AlertTimeoutSeconds).Append("\n");
            sb.Append("  PinConfiguration: ").Append(PinConfiguration).Append("\n");
            sb.Append("  VoicemailExtension: ").Append(VoicemailExtension).Append("\n");
            sb.Append("  PinRequired: ").Append(PinRequired).Append("\n");
            sb.Append("  SendEmailNotifications: ").Append(SendEmailNotifications).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(obj as VoicemailOrganizationPolicy);
        }

        /// <summary>
        /// Returns true if VoicemailOrganizationPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailOrganizationPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailOrganizationPolicy other)
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
                    this.PinConfiguration == other.PinConfiguration ||
                    this.PinConfiguration != null &&
                    this.PinConfiguration.Equals(other.PinConfiguration)
                ) &&
                (
                    this.VoicemailExtension == other.VoicemailExtension ||
                    this.VoicemailExtension != null &&
                    this.VoicemailExtension.Equals(other.VoicemailExtension)
                ) &&
                (
                    this.PinRequired == other.PinRequired ||
                    this.PinRequired != null &&
                    this.PinRequired.Equals(other.PinRequired)
                ) &&
                (
                    this.SendEmailNotifications == other.SendEmailNotifications ||
                    this.SendEmailNotifications != null &&
                    this.SendEmailNotifications.Equals(other.SendEmailNotifications)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
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
                if (this.PinConfiguration != null)
                    hash = hash * 59 + this.PinConfiguration.GetHashCode();
                if (this.VoicemailExtension != null)
                    hash = hash * 59 + this.VoicemailExtension.GetHashCode();
                if (this.PinRequired != null)
                    hash = hash * 59 + this.PinRequired.GetHashCode();
                if (this.SendEmailNotifications != null)
                    hash = hash * 59 + this.SendEmailNotifications.GetHashCode();
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                return hash;
            }
        }
    }

}
