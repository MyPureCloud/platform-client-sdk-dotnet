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
    /// JourneyViewLinkTimeConstraint
    /// </summary>
    [DataContract]
    public partial class JourneyViewLinkTimeConstraint :  IEquatable<JourneyViewLinkTimeConstraint>
    {
        /// <summary>
        /// The unit for the link's time constraint
        /// </summary>
        /// <value>The unit for the link's time constraint</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Seconds for "Seconds"
            /// </summary>
            [EnumMember(Value = "Seconds")]
            Seconds,
            
            /// <summary>
            /// Enum Minutes for "Minutes"
            /// </summary>
            [EnumMember(Value = "Minutes")]
            Minutes,
            
            /// <summary>
            /// Enum Hours for "Hours"
            /// </summary>
            [EnumMember(Value = "Hours")]
            Hours,
            
            /// <summary>
            /// Enum Days for "Days"
            /// </summary>
            [EnumMember(Value = "Days")]
            Days,
            
            /// <summary>
            /// Enum Weeks for "Weeks"
            /// </summary>
            [EnumMember(Value = "Weeks")]
            Weeks,
            
            /// <summary>
            /// Enum Months for "Months"
            /// </summary>
            [EnumMember(Value = "Months")]
            Months
        }
        /// <summary>
        /// The unit for the link's time constraint
        /// </summary>
        /// <value>The unit for the link's time constraint</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public UnitEnum? Unit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewLinkTimeConstraint" /> class.
        /// </summary>
        /// <param name="Unit">The unit for the link's time constraint.</param>
        /// <param name="Value">The value for the link's time constraint.</param>
        public JourneyViewLinkTimeConstraint(UnitEnum? Unit = null, int? Value = null)
        {
            this.Unit = Unit;
            this.Value = Value;
            
        }
        




        /// <summary>
        /// The value for the link's time constraint
        /// </summary>
        /// <value>The value for the link's time constraint</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewLinkTimeConstraint {\n");

            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(obj as JourneyViewLinkTimeConstraint);
        }

        /// <summary>
        /// Returns true if JourneyViewLinkTimeConstraint instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewLinkTimeConstraint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewLinkTimeConstraint other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Unit == other.Unit ||
                    this.Unit != null &&
                    this.Unit.Equals(other.Unit)
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
                if (this.Unit != null)
                    hash = hash * 59 + this.Unit.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
