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
    /// LastAttemptOverallConditionSettings
    /// </summary>
    [DataContract]
    public partial class LastAttemptOverallConditionSettings :  IEquatable<LastAttemptOverallConditionSettings>
    {
        /// <summary>
        /// Gets or Sets MediaTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Sms for "Sms"
            /// </summary>
            [EnumMember(Value = "Sms")]
            Sms,
            
            /// <summary>
            /// Enum Whatsapp for "WhatsApp"
            /// </summary>
            [EnumMember(Value = "WhatsApp")]
            Whatsapp
        }
        /// <summary>
        /// The operator to use when comparing values.
        /// </summary>
        /// <value>The operator to use when comparing values.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Before for "Before"
            /// </summary>
            [EnumMember(Value = "Before")]
            Before,
            
            /// <summary>
            /// Enum After for "After"
            /// </summary>
            [EnumMember(Value = "After")]
            After
        }
        /// <summary>
        /// The operator to use when comparing values.
        /// </summary>
        /// <value>The operator to use when comparing values.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LastAttemptOverallConditionSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LastAttemptOverallConditionSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LastAttemptOverallConditionSettings" /> class.
        /// </summary>
        /// <param name="MediaTypes">A list of media types to evaluate. (required).</param>
        /// <param name="Operator">The operator to use when comparing values. (required).</param>
        /// <param name="Value">The period value to compare against the contact&#39;s data. (required).</param>
        public LastAttemptOverallConditionSettings(List<MediaTypesEnum> MediaTypes = null, OperatorEnum? Operator = null, string Value = null)
        {
            this.MediaTypes = MediaTypes;
            this.Operator = Operator;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// A list of media types to evaluate.
        /// </summary>
        /// <value>A list of media types to evaluate.</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<MediaTypesEnum> MediaTypes { get; set; }





        /// <summary>
        /// The period value to compare against the contact&#39;s data.
        /// </summary>
        /// <value>The period value to compare against the contact&#39;s data.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LastAttemptOverallConditionSettings {\n");

            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as LastAttemptOverallConditionSettings);
        }

        /// <summary>
        /// Returns true if LastAttemptOverallConditionSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of LastAttemptOverallConditionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LastAttemptOverallConditionSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
