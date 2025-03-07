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
    /// ContactAddressConditionSettings
    /// </summary>
    [DataContract]
    public partial class ContactAddressConditionSettings :  IEquatable<ContactAddressConditionSettings>
    {
        /// <summary>
        /// The operator to use when comparing address values.
        /// </summary>
        /// <value>The operator to use when comparing address values.</value>
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
            /// Enum Equals for "Equals"
            /// </summary>
            [EnumMember(Value = "Equals")]
            Equals,
            
            /// <summary>
            /// Enum Contains for "Contains"
            /// </summary>
            [EnumMember(Value = "Contains")]
            Contains,
            
            /// <summary>
            /// Enum Beginswith for "BeginsWith"
            /// </summary>
            [EnumMember(Value = "BeginsWith")]
            Beginswith,
            
            /// <summary>
            /// Enum Endswith for "EndsWith"
            /// </summary>
            [EnumMember(Value = "EndsWith")]
            Endswith
        }
        /// <summary>
        /// The operator to use when comparing address values.
        /// </summary>
        /// <value>The operator to use when comparing address values.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactAddressConditionSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactAddressConditionSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactAddressConditionSettings" /> class.
        /// </summary>
        /// <param name="Operator">The operator to use when comparing address values. (required).</param>
        /// <param name="Value">The value to compare against the contact&#39;s address. (required).</param>
        public ContactAddressConditionSettings(OperatorEnum? Operator = null, string Value = null)
        {
            this.Operator = Operator;
            this.Value = Value;
            
        }
        




        /// <summary>
        /// The value to compare against the contact&#39;s address.
        /// </summary>
        /// <value>The value to compare against the contact&#39;s address.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactAddressConditionSettings {\n");

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
            return this.Equals(obj as ContactAddressConditionSettings);
        }

        /// <summary>
        /// Returns true if ContactAddressConditionSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactAddressConditionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactAddressConditionSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
