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
    /// RecipientWarning
    /// </summary>
    [DataContract]
    public partial class RecipientWarning :  IEquatable<RecipientWarning>
    {
        /// <summary>
        /// The reason the recipient failed validation.
        /// </summary>
        /// <value>The reason the recipient failed validation.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Invalidemail for "InvalidEmail"
            /// </summary>
            [EnumMember(Value = "InvalidEmail")]
            Invalidemail,
            
            /// <summary>
            /// Enum Domainnotpermitted for "DomainNotPermitted"
            /// </summary>
            [EnumMember(Value = "DomainNotPermitted")]
            Domainnotpermitted
        }
        /// <summary>
        /// The reason the recipient failed validation.
        /// </summary>
        /// <value>The reason the recipient failed validation.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientWarning" /> class.
        /// </summary>
        public RecipientWarning()
        {
            
        }
        


        /// <summary>
        /// The recipient email address that failed validation.
        /// </summary>
        /// <value>The recipient email address that failed validation.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; private set; }





        /// <summary>
        /// The array-index path of the recipient within the draft, for example \&quot;to[0]\&quot;, \&quot;cc[1]\&quot; or \&quot;bcc[0]\&quot;.
        /// </summary>
        /// <value>The array-index path of the recipient within the draft, for example \&quot;to[0]\&quot;, \&quot;cc[1]\&quot; or \&quot;bcc[0]\&quot;.</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientWarning {\n");

            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
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
            return this.Equals(obj as RecipientWarning);
        }

        /// <summary>
        /// Returns true if RecipientWarning instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientWarning to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientWarning other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) &&
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) &&
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();

                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();

                if (this.FieldName != null)
                    hash = hash * 59 + this.FieldName.GetHashCode();

                return hash;
            }
        }
    }

}
