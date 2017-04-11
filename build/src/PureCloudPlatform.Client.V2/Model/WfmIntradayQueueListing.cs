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
    /// A list of IntradayQueue objects
    /// </summary>
    [DataContract]
    public partial class WfmIntradayQueueListing :  IEquatable<WfmIntradayQueueListing>
    {
        /// <summary>
        /// Gets or Sets NoDataReason
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NoDataReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Noweekdata for "NoWeekData"
            /// </summary>
            [EnumMember(Value = "NoWeekData")]
            Noweekdata,
            
            /// <summary>
            /// Enum Nopublishedschedule for "NoPublishedSchedule"
            /// </summary>
            [EnumMember(Value = "NoPublishedSchedule")]
            Nopublishedschedule,
            
            /// <summary>
            /// Enum Nosourceforecast for "NoSourceForecast"
            /// </summary>
            [EnumMember(Value = "NoSourceForecast")]
            Nosourceforecast
        }
        /// <summary>
        /// Gets or Sets NoDataReason
        /// </summary>
        [DataMember(Name="noDataReason", EmitDefaultValue=false)]
        public NoDataReasonEnum? NoDataReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmIntradayQueueListing" /> class.
        /// </summary>
        /// <param name="Entities">Entities.</param>
        /// <param name="NoDataReason">NoDataReason.</param>
        public WfmIntradayQueueListing(List<IntradayQueue> Entities = null, NoDataReasonEnum? NoDataReason = null)
        {
            this.Entities = Entities;
            this.NoDataReason = NoDataReason;
        }
        
        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<IntradayQueue> Entities { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmIntradayQueueListing {\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  NoDataReason: ").Append(NoDataReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WfmIntradayQueueListing);
        }

        /// <summary>
        /// Returns true if WfmIntradayQueueListing instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmIntradayQueueListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmIntradayQueueListing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.NoDataReason == other.NoDataReason ||
                    this.NoDataReason != null &&
                    this.NoDataReason.Equals(other.NoDataReason)
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
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();
                if (this.NoDataReason != null)
                    hash = hash * 59 + this.NoDataReason.GetHashCode();
                return hash;
            }
        }
    }

}
