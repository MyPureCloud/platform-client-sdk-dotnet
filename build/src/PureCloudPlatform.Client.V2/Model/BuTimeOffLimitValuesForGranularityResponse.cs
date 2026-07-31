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
    /// BuTimeOffLimitValuesForGranularityResponse
    /// </summary>
    [DataContract]
    public partial class BuTimeOffLimitValuesForGranularityResponse :  IEquatable<BuTimeOffLimitValuesForGranularityResponse>
    {
        /// <summary>
        /// Granularity choice for time-off limit
        /// </summary>
        /// <value>Granularity choice for time-off limit</value>
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
            Daily,
            
            /// <summary>
            /// Enum Fifteenminutes for "FifteenMinutes"
            /// </summary>
            [EnumMember(Value = "FifteenMinutes")]
            Fifteenminutes
        }
        /// <summary>
        /// Granularity choice for time-off limit
        /// </summary>
        /// <value>Granularity choice for time-off limit</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public GranularityEnum? Granularity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuTimeOffLimitValuesForGranularityResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuTimeOffLimitValuesForGranularityResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuTimeOffLimitValuesForGranularityResponse" /> class.
        /// </summary>
        /// <param name="TimeOffLimit">The ID of the time-off limit (required).</param>
        /// <param name="Granularity">Granularity choice for time-off limit (required).</param>
        /// <param name="LimitValues">Values for time-off limit.</param>
        /// <param name="Metadata">Version metadata for the time-off limit (required).</param>
        public BuTimeOffLimitValuesForGranularityResponse(BuTimeOffLimitReference TimeOffLimit = null, GranularityEnum? Granularity = null, List<BuTimeOffLimitValues> LimitValues = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.TimeOffLimit = TimeOffLimit;
            this.Granularity = Granularity;
            this.LimitValues = LimitValues;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The ID of the time-off limit
        /// </summary>
        /// <value>The ID of the time-off limit</value>
        [DataMember(Name="timeOffLimit", EmitDefaultValue=false)]
        public BuTimeOffLimitReference TimeOffLimit { get; set; }





        /// <summary>
        /// Values for time-off limit
        /// </summary>
        /// <value>Values for time-off limit</value>
        [DataMember(Name="limitValues", EmitDefaultValue=false)]
        public List<BuTimeOffLimitValues> LimitValues { get; set; }



        /// <summary>
        /// Version metadata for the time-off limit
        /// </summary>
        /// <value>Version metadata for the time-off limit</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuTimeOffLimitValuesForGranularityResponse {\n");

            sb.Append("  TimeOffLimit: ").Append(TimeOffLimit).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  LimitValues: ").Append(LimitValues).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as BuTimeOffLimitValuesForGranularityResponse);
        }

        /// <summary>
        /// Returns true if BuTimeOffLimitValuesForGranularityResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BuTimeOffLimitValuesForGranularityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuTimeOffLimitValuesForGranularityResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeOffLimit == other.TimeOffLimit ||
                    this.TimeOffLimit != null &&
                    this.TimeOffLimit.Equals(other.TimeOffLimit)
                ) &&
                (
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.LimitValues == other.LimitValues ||
                    this.LimitValues != null &&
                    this.LimitValues.SequenceEqual(other.LimitValues)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.TimeOffLimit != null)
                    hash = hash * 59 + this.TimeOffLimit.GetHashCode();

                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.LimitValues != null)
                    hash = hash * 59 + this.LimitValues.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
