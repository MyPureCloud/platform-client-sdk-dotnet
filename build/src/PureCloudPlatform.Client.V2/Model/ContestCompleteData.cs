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
    /// ContestCompleteData
    /// </summary>
    [DataContract]
    public partial class ContestCompleteData :  IEquatable<ContestCompleteData>
    {
        /// <summary>
        /// Anonymization of the contest
        /// </summary>
        /// <value>Anonymization of the contest</value>
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
            /// Enum Noanonymization for "NoAnonymization"
            /// </summary>
            [EnumMember(Value = "NoAnonymization")]
            Noanonymization,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All,
            
            /// <summary>
            /// Enum Allexcepttop for "AllExceptTop"
            /// </summary>
            [EnumMember(Value = "AllExceptTop")]
            Allexcepttop
        }
        /// <summary>
        /// Anonymization of the contest
        /// </summary>
        /// <value>Anonymization of the contest</value>
        [DataMember(Name="anonymization", EmitDefaultValue=false)]
        public AnonymizationEnum? Anonymization { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestCompleteData" /> class.
        /// </summary>
        /// <param name="DateEnd">End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="Anonymization">Anonymization of the contest.</param>
        /// <param name="Metrics">Metrics of the contest.</param>
        /// <param name="Prizes">Prizes of the contest.</param>
        /// <param name="Winners">Winners of the contest.</param>
        public ContestCompleteData(String DateEnd = null, AnonymizationEnum? Anonymization = null, List<ContestDataMetrics> Metrics = null, List<ContestDataPrizes> Prizes = null, List<ContestDataWinners> Winners = null)
        {
            this.DateEnd = DateEnd;
            this.Anonymization = Anonymization;
            this.Metrics = Metrics;
            this.Prizes = Prizes;
            this.Winners = Winners;
            
        }
        


        /// <summary>
        /// End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public String DateEnd { get; set; }





        /// <summary>
        /// Metrics of the contest
        /// </summary>
        /// <value>Metrics of the contest</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<ContestDataMetrics> Metrics { get; set; }



        /// <summary>
        /// Prizes of the contest
        /// </summary>
        /// <value>Prizes of the contest</value>
        [DataMember(Name="prizes", EmitDefaultValue=false)]
        public List<ContestDataPrizes> Prizes { get; set; }



        /// <summary>
        /// Winners of the contest
        /// </summary>
        /// <value>Winners of the contest</value>
        [DataMember(Name="winners", EmitDefaultValue=false)]
        public List<ContestDataWinners> Winners { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContestCompleteData {\n");

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
            return this.Equals(obj as ContestCompleteData);
        }

        /// <summary>
        /// Returns true if ContestCompleteData instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestCompleteData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestCompleteData other)
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
