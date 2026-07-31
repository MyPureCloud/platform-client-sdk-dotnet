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
    /// BuConvertTimeOffLimitGranularityJobRequest
    /// </summary>
    [DataContract]
    public partial class BuConvertTimeOffLimitGranularityJobRequest :  IEquatable<BuConvertTimeOffLimitGranularityJobRequest>
    {
        /// <summary>
        /// Granularity to convert the time-off limit to
        /// </summary>
        /// <value>Granularity to convert the time-off limit to</value>
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
        /// Granularity to convert the time-off limit to
        /// </summary>
        /// <value>Granularity to convert the time-off limit to</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public GranularityEnum? Granularity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuConvertTimeOffLimitGranularityJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuConvertTimeOffLimitGranularityJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuConvertTimeOffLimitGranularityJobRequest" /> class.
        /// </summary>
        /// <param name="Granularity">Granularity to convert the time-off limit to (required).</param>
        /// <param name="FullDayTimeOffStartTime">The start time of full day time-off requests associated with this limit interval in HH:mm format.The value can be set only once when converting the time-off limit from daily granularity to fifteen minutes.Setting this value is allowed only for time-off limit with fifteen minutes granularity.When converting time-off limit from fifteen minutes to daily granularity, the existing value is reset..</param>
        public BuConvertTimeOffLimitGranularityJobRequest(GranularityEnum? Granularity = null, string FullDayTimeOffStartTime = null)
        {
            this.Granularity = Granularity;
            this.FullDayTimeOffStartTime = FullDayTimeOffStartTime;
            
        }
        




        /// <summary>
        /// The start time of full day time-off requests associated with this limit interval in HH:mm format.The value can be set only once when converting the time-off limit from daily granularity to fifteen minutes.Setting this value is allowed only for time-off limit with fifteen minutes granularity.When converting time-off limit from fifteen minutes to daily granularity, the existing value is reset.
        /// </summary>
        /// <value>The start time of full day time-off requests associated with this limit interval in HH:mm format.The value can be set only once when converting the time-off limit from daily granularity to fifteen minutes.Setting this value is allowed only for time-off limit with fifteen minutes granularity.When converting time-off limit from fifteen minutes to daily granularity, the existing value is reset.</value>
        [DataMember(Name="fullDayTimeOffStartTime", EmitDefaultValue=false)]
        public string FullDayTimeOffStartTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuConvertTimeOffLimitGranularityJobRequest {\n");

            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  FullDayTimeOffStartTime: ").Append(FullDayTimeOffStartTime).Append("\n");
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
            return this.Equals(obj as BuConvertTimeOffLimitGranularityJobRequest);
        }

        /// <summary>
        /// Returns true if BuConvertTimeOffLimitGranularityJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BuConvertTimeOffLimitGranularityJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuConvertTimeOffLimitGranularityJobRequest other)
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
                    this.FullDayTimeOffStartTime == other.FullDayTimeOffStartTime ||
                    this.FullDayTimeOffStartTime != null &&
                    this.FullDayTimeOffStartTime.Equals(other.FullDayTimeOffStartTime)
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

                if (this.FullDayTimeOffStartTime != null)
                    hash = hash * 59 + this.FullDayTimeOffStartTime.GetHashCode();

                return hash;
            }
        }
    }

}
