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
    /// PauseCriteria
    /// </summary>
    [DataContract]
    public partial class PauseCriteria :  IEquatable<PauseCriteria>
    {
        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ConditionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Includes for "Includes"
            /// </summary>
            [EnumMember(Value = "Includes")]
            Includes,
            
            /// <summary>
            /// Enum Doesnotinclude for "DoesNotInclude"
            /// </summary>
            [EnumMember(Value = "DoesNotInclude")]
            Doesnotinclude,
            
            /// <summary>
            /// Enum Startswith for "StartsWith"
            /// </summary>
            [EnumMember(Value = "StartsWith")]
            Startswith,
            
            /// <summary>
            /// Enum Endswith for "EndsWith"
            /// </summary>
            [EnumMember(Value = "EndsWith")]
            Endswith,
            
            /// <summary>
            /// Enum Equals for "Equals"
            /// </summary>
            [EnumMember(Value = "Equals")]
            Equals
        }
        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public ConditionEnum? Condition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PauseCriteria" /> class.
        /// </summary>
        /// <param name="UrlFragment">UrlFragment.</param>
        /// <param name="Condition">Condition.</param>
        public PauseCriteria(string UrlFragment = null, ConditionEnum? Condition = null)
        {
            this.UrlFragment = UrlFragment;
            this.Condition = Condition;
            
        }
        


        /// <summary>
        /// Gets or Sets UrlFragment
        /// </summary>
        [DataMember(Name="urlFragment", EmitDefaultValue=false)]
        public string UrlFragment { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PauseCriteria {\n");

            sb.Append("  UrlFragment: ").Append(UrlFragment).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
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
            return this.Equals(obj as PauseCriteria);
        }

        /// <summary>
        /// Returns true if PauseCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of PauseCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PauseCriteria other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UrlFragment == other.UrlFragment ||
                    this.UrlFragment != null &&
                    this.UrlFragment.Equals(other.UrlFragment)
                ) &&
                (
                    this.Condition == other.Condition ||
                    this.Condition != null &&
                    this.Condition.Equals(other.Condition)
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
                if (this.UrlFragment != null)
                    hash = hash * 59 + this.UrlFragment.GetHashCode();

                if (this.Condition != null)
                    hash = hash * 59 + this.Condition.GetHashCode();

                return hash;
            }
        }
    }

}
