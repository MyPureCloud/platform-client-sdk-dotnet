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
    /// V2WemEngagementCelebrationUpdatesTopicContestCompleteData
    /// </summary>
    [DataContract]
    public partial class V2WemEngagementCelebrationUpdatesTopicContestCompleteData :  IEquatable<V2WemEngagementCelebrationUpdatesTopicContestCompleteData>
    {
        /// <summary>
        /// Gets or Sets Anonymization
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AnonymizationEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum NoAnonymization for "NO_ANONYMIZATION"
            /// </summary>
            [EnumMember(Value = "NO_ANONYMIZATION")]
            NoAnonymization,
            
            /// <summary>
            /// Enum All for "ALL"
            /// </summary>
            [EnumMember(Value = "ALL")]
            All,
            
            /// <summary>
            /// Enum AllExceptTop for "ALL_EXCEPT_TOP"
            /// </summary>
            [EnumMember(Value = "ALL_EXCEPT_TOP")]
            AllExceptTop
        }
        /// <summary>
        /// Gets or Sets Anonymization
        /// </summary>
        [DataMember(Name="anonymization", EmitDefaultValue=false)]
        public AnonymizationEnum? Anonymization { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2WemEngagementCelebrationUpdatesTopicContestCompleteData" /> class.
        /// </summary>
        /// <param name="DateEnd">DateEnd.</param>
        /// <param name="Anonymization">Anonymization.</param>
        /// <param name="Metrics">Metrics.</param>
        /// <param name="Prizes">Prizes.</param>
        /// <param name="Winners">Winners.</param>
        public V2WemEngagementCelebrationUpdatesTopicContestCompleteData(string DateEnd = null, AnonymizationEnum? Anonymization = null, List<V2WemEngagementCelebrationUpdatesTopicContestMetrics> Metrics = null, List<V2WemEngagementCelebrationUpdatesTopicContestPrizes> Prizes = null, List<V2WemEngagementCelebrationUpdatesTopicContestWinners> Winners = null)
        {
            this.DateEnd = DateEnd;
            this.Anonymization = Anonymization;
            this.Metrics = Metrics;
            this.Prizes = Prizes;
            this.Winners = Winners;
            
        }
        


        /// <summary>
        /// Gets or Sets DateEnd
        /// </summary>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public string DateEnd { get; set; }





        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<V2WemEngagementCelebrationUpdatesTopicContestMetrics> Metrics { get; set; }



        /// <summary>
        /// Gets or Sets Prizes
        /// </summary>
        [DataMember(Name="prizes", EmitDefaultValue=false)]
        public List<V2WemEngagementCelebrationUpdatesTopicContestPrizes> Prizes { get; set; }



        /// <summary>
        /// Gets or Sets Winners
        /// </summary>
        [DataMember(Name="winners", EmitDefaultValue=false)]
        public List<V2WemEngagementCelebrationUpdatesTopicContestWinners> Winners { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2WemEngagementCelebrationUpdatesTopicContestCompleteData {\n");

            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  Anonymization: ").Append(Anonymization).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  Prizes: ").Append(Prizes).Append("\n");
            sb.Append("  Winners: ").Append(Winners).Append("\n");
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
            return this.Equals(obj as V2WemEngagementCelebrationUpdatesTopicContestCompleteData);
        }

        /// <summary>
        /// Returns true if V2WemEngagementCelebrationUpdatesTopicContestCompleteData instances are equal
        /// </summary>
        /// <param name="other">Instance of V2WemEngagementCelebrationUpdatesTopicContestCompleteData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2WemEngagementCelebrationUpdatesTopicContestCompleteData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
                ) &&
                (
                    this.Anonymization == other.Anonymization ||
                    this.Anonymization != null &&
                    this.Anonymization.Equals(other.Anonymization)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.Prizes == other.Prizes ||
                    this.Prizes != null &&
                    this.Prizes.SequenceEqual(other.Prizes)
                ) &&
                (
                    this.Winners == other.Winners ||
                    this.Winners != null &&
                    this.Winners.SequenceEqual(other.Winners)
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
                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();

                if (this.Anonymization != null)
                    hash = hash * 59 + this.Anonymization.GetHashCode();

                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();

                if (this.Prizes != null)
                    hash = hash * 59 + this.Prizes.GetHashCode();

                if (this.Winners != null)
                    hash = hash * 59 + this.Winners.GetHashCode();

                return hash;
            }
        }
    }

}
