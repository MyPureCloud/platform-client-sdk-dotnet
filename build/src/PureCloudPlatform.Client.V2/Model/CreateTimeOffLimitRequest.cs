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
    /// Contains property values of time off limit to be created
    /// </summary>
    [DataContract]
    public partial class CreateTimeOffLimitRequest :  IEquatable<CreateTimeOffLimitRequest>
    {
        /// <summary>
        /// Granularity choice for time off limit. If not specified, 'Daily' is assumed
        /// </summary>
        /// <value>Granularity choice for time off limit. If not specified, 'Daily' is assumed</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GranularityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Daily for "Daily"
            /// </summary>
            [EnumMember(Value = "Daily")]
            Daily
        }
        /// <summary>
        /// Granularity choice for time off limit. If not specified, 'Daily' is assumed
        /// </summary>
        /// <value>Granularity choice for time off limit. If not specified, 'Daily' is assumed</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public GranularityEnum? Granularity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTimeOffLimitRequest" /> class.
        /// </summary>
        /// <param name="Granularity">Granularity choice for time off limit. If not specified, 'Daily' is assumed.</param>
        /// <param name="DefaultLimitMinutes">The default limit value in minutes per granularity.If not specified, then 0 is assumed, which means there are no time off minutes available.</param>
        public CreateTimeOffLimitRequest(GranularityEnum? Granularity = null, int? DefaultLimitMinutes = null)
        {
            this.Granularity = Granularity;
            this.DefaultLimitMinutes = DefaultLimitMinutes;
            
        }
        




        /// <summary>
        /// The default limit value in minutes per granularity.If not specified, then 0 is assumed, which means there are no time off minutes available
        /// </summary>
        /// <value>The default limit value in minutes per granularity.If not specified, then 0 is assumed, which means there are no time off minutes available</value>
        [DataMember(Name="defaultLimitMinutes", EmitDefaultValue=false)]
        public int? DefaultLimitMinutes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTimeOffLimitRequest {\n");

            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  DefaultLimitMinutes: ").Append(DefaultLimitMinutes).Append("\n");
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
            return this.Equals(obj as CreateTimeOffLimitRequest);
        }

        /// <summary>
        /// Returns true if CreateTimeOffLimitRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateTimeOffLimitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTimeOffLimitRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.DefaultLimitMinutes == other.DefaultLimitMinutes ||
                    this.DefaultLimitMinutes != null &&
                    this.DefaultLimitMinutes.Equals(other.DefaultLimitMinutes)
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
                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.DefaultLimitMinutes != null)
                    hash = hash * 59 + this.DefaultLimitMinutes.GetHashCode();

                return hash;
            }
        }
    }

}
