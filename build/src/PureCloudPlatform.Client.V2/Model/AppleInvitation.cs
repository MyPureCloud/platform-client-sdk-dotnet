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
    /// Apple Messages for Business invitation template configuration
    /// </summary>
    [DataContract]
    public partial class AppleInvitation :  IEquatable<AppleInvitation>
    {
        /// <summary>
        /// The template type for the invitation
        /// </summary>
        /// <value>The template type for the invitation</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TemplateTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Withimage for "WithImage"
            /// </summary>
            [EnumMember(Value = "WithImage")]
            Withimage,
            
            /// <summary>
            /// Enum Withoutimage for "WithoutImage"
            /// </summary>
            [EnumMember(Value = "WithoutImage")]
            Withoutimage
        }
        /// <summary>
        /// The template type for the invitation
        /// </summary>
        /// <value>The template type for the invitation</value>
        [DataMember(Name="templateType", EmitDefaultValue=false)]
        public TemplateTypeEnum? TemplateType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppleInvitation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppleInvitation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleInvitation" /> class.
        /// </summary>
        /// <param name="BusinessName">The business name displayed in the invitation (required).</param>
        /// <param name="TranscriptMessage">The transcript message displayed in the invitation (required).</param>
        /// <param name="TemplateType">The template type for the invitation (required).</param>
        /// <param name="Locale">The locale for the invitation (required).</param>
        public AppleInvitation(string BusinessName = null, string TranscriptMessage = null, TemplateTypeEnum? TemplateType = null, string Locale = null)
        {
            this.BusinessName = BusinessName;
            this.TranscriptMessage = TranscriptMessage;
            this.TemplateType = TemplateType;
            this.Locale = Locale;
            
        }
        


        /// <summary>
        /// The business name displayed in the invitation
        /// </summary>
        /// <value>The business name displayed in the invitation</value>
        [DataMember(Name="businessName", EmitDefaultValue=false)]
        public string BusinessName { get; set; }



        /// <summary>
        /// The transcript message displayed in the invitation
        /// </summary>
        /// <value>The transcript message displayed in the invitation</value>
        [DataMember(Name="transcriptMessage", EmitDefaultValue=false)]
        public string TranscriptMessage { get; set; }





        /// <summary>
        /// The locale for the invitation
        /// </summary>
        /// <value>The locale for the invitation</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppleInvitation {\n");

            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  TranscriptMessage: ").Append(TranscriptMessage).Append("\n");
            sb.Append("  TemplateType: ").Append(TemplateType).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(obj as AppleInvitation);
        }

        /// <summary>
        /// Returns true if AppleInvitation instances are equal
        /// </summary>
        /// <param name="other">Instance of AppleInvitation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleInvitation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.BusinessName == other.BusinessName ||
                    this.BusinessName != null &&
                    this.BusinessName.Equals(other.BusinessName)
                ) &&
                (
                    this.TranscriptMessage == other.TranscriptMessage ||
                    this.TranscriptMessage != null &&
                    this.TranscriptMessage.Equals(other.TranscriptMessage)
                ) &&
                (
                    this.TemplateType == other.TemplateType ||
                    this.TemplateType != null &&
                    this.TemplateType.Equals(other.TemplateType)
                ) &&
                (
                    this.Locale == other.Locale ||
                    this.Locale != null &&
                    this.Locale.Equals(other.Locale)
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
                if (this.BusinessName != null)
                    hash = hash * 59 + this.BusinessName.GetHashCode();

                if (this.TranscriptMessage != null)
                    hash = hash * 59 + this.TranscriptMessage.GetHashCode();

                if (this.TemplateType != null)
                    hash = hash * 59 + this.TemplateType.GetHashCode();

                if (this.Locale != null)
                    hash = hash * 59 + this.Locale.GetHashCode();

                return hash;
            }
        }
    }

}
