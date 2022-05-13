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
    /// InboundDomainPatchRequest
    /// </summary>
    [DataContract]
    public partial class InboundDomainPatchRequest :  IEquatable<InboundDomainPatchRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundDomainPatchRequest" /> class.
        /// </summary>
        /// <param name="MailFromSettings">The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false..</param>
        /// <param name="CustomSMTPServer">The custom SMTP server integration to use when sending outbound emails from this domain..</param>
        public InboundDomainPatchRequest(MailFromResult MailFromSettings = null, DomainEntityRef CustomSMTPServer = null)
        {
            this.MailFromSettings = MailFromSettings;
            this.CustomSMTPServer = CustomSMTPServer;
            
        }
        


        /// <summary>
        /// The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false.
        /// </summary>
        /// <value>The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false.</value>
        [DataMember(Name="mailFromSettings", EmitDefaultValue=false)]
        public MailFromResult MailFromSettings { get; set; }



        /// <summary>
        /// The custom SMTP server integration to use when sending outbound emails from this domain.
        /// </summary>
        /// <value>The custom SMTP server integration to use when sending outbound emails from this domain.</value>
        [DataMember(Name="customSMTPServer", EmitDefaultValue=false)]
        public DomainEntityRef CustomSMTPServer { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundDomainPatchRequest {\n");

            sb.Append("  MailFromSettings: ").Append(MailFromSettings).Append("\n");
            sb.Append("  CustomSMTPServer: ").Append(CustomSMTPServer).Append("\n");
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
            return this.Equals(obj as InboundDomainPatchRequest);
        }

        /// <summary>
        /// Returns true if InboundDomainPatchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of InboundDomainPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundDomainPatchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MailFromSettings == other.MailFromSettings ||
                    this.MailFromSettings != null &&
                    this.MailFromSettings.Equals(other.MailFromSettings)
                ) &&
                (
                    this.CustomSMTPServer == other.CustomSMTPServer ||
                    this.CustomSMTPServer != null &&
                    this.CustomSMTPServer.Equals(other.CustomSMTPServer)
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
                if (this.MailFromSettings != null)
                    hash = hash * 59 + this.MailFromSettings.GetHashCode();

                if (this.CustomSMTPServer != null)
                    hash = hash * 59 + this.CustomSMTPServer.GetHashCode();

                return hash;
            }
        }
    }

}
