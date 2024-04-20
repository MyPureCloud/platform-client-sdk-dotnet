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
    /// FaxConfig
    /// </summary>
    [DataContract]
    public partial class FaxConfig :  IEquatable<FaxConfig>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FaxConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FaxConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FaxConfig" /> class.
        /// </summary>
        /// <param name="SendEmailNotifications">Whether to enable email notifications for this organization (required).</param>
        /// <param name="DisableEmailPii">Whether to disable PII for email notifications (required).</param>
        public FaxConfig(bool? SendEmailNotifications = null, bool? DisableEmailPii = null)
        {
            this.SendEmailNotifications = SendEmailNotifications;
            this.DisableEmailPii = DisableEmailPii;
            
        }
        


        /// <summary>
        /// Whether to enable email notifications for this organization
        /// </summary>
        /// <value>Whether to enable email notifications for this organization</value>
        [DataMember(Name="sendEmailNotifications", EmitDefaultValue=false)]
        public bool? SendEmailNotifications { get; set; }



        /// <summary>
        /// Whether to disable PII for email notifications
        /// </summary>
        /// <value>Whether to disable PII for email notifications</value>
        [DataMember(Name="disableEmailPii", EmitDefaultValue=false)]
        public bool? DisableEmailPii { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaxConfig {\n");

            sb.Append("  SendEmailNotifications: ").Append(SendEmailNotifications).Append("\n");
            sb.Append("  DisableEmailPii: ").Append(DisableEmailPii).Append("\n");
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
            return this.Equals(obj as FaxConfig);
        }

        /// <summary>
        /// Returns true if FaxConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of FaxConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaxConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SendEmailNotifications == other.SendEmailNotifications ||
                    this.SendEmailNotifications != null &&
                    this.SendEmailNotifications.Equals(other.SendEmailNotifications)
                ) &&
                (
                    this.DisableEmailPii == other.DisableEmailPii ||
                    this.DisableEmailPii != null &&
                    this.DisableEmailPii.Equals(other.DisableEmailPii)
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
                if (this.SendEmailNotifications != null)
                    hash = hash * 59 + this.SendEmailNotifications.GetHashCode();

                if (this.DisableEmailPii != null)
                    hash = hash * 59 + this.DisableEmailPii.GetHashCode();

                return hash;
            }
        }
    }

}
