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
    /// AggregatedExportJobRequest
    /// </summary>
    [DataContract]
    public partial class AggregatedExportJobRequest :  IEquatable<AggregatedExportJobRequest>
    {
        /// <summary>
        /// Granularity of the exported data, defaults to day
        /// </summary>
        /// <value>Granularity of the exported data, defaults to day</value>
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
            /// Enum Fifteenminutes for "FifteenMinutes"
            /// </summary>
            [EnumMember(Value = "FifteenMinutes")]
            Fifteenminutes,
            
            /// <summary>
            /// Enum Thirtyminutes for "ThirtyMinutes"
            /// </summary>
            [EnumMember(Value = "ThirtyMinutes")]
            Thirtyminutes,
            
            /// <summary>
            /// Enum Sixtyminutes for "SixtyMinutes"
            /// </summary>
            [EnumMember(Value = "SixtyMinutes")]
            Sixtyminutes,
            
            /// <summary>
            /// Enum Day for "Day"
            /// </summary>
            [EnumMember(Value = "Day")]
            Day,
            
            /// <summary>
            /// Enum Week for "Week"
            /// </summary>
            [EnumMember(Value = "Week")]
            Week
        }
        /// <summary>
        /// Granularity of the exported data, defaults to day
        /// </summary>
        /// <value>Granularity of the exported data, defaults to day</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public GranularityEnum? Granularity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedExportJobRequest" /> class.
        /// </summary>
        /// <param name="Granularity">Granularity of the exported data, defaults to day.</param>
        /// <param name="TimeZone">The requested time zone of the exported data, in Olson format. Defaults to business unit time zone.</param>
        /// <param name="Delimiter">The delimiter to use between fields in the export, defaults to comma.</param>
        /// <param name="PlanningGroupIds">The IDs of the planning groups to include in the export, defaults to all planning groups in the business unit.</param>
        /// <param name="DateStart">Start date-time of the export range in ISO-8601 format.</param>
        /// <param name="DateEnd">End date-time of the export range in ISO-8601 format.</param>
        public AggregatedExportJobRequest(GranularityEnum? Granularity = null, string TimeZone = null, string Delimiter = null, List<string> PlanningGroupIds = null, DateTime? DateStart = null, DateTime? DateEnd = null)
        {
            this.Granularity = Granularity;
            this.TimeZone = TimeZone;
            this.Delimiter = Delimiter;
            this.PlanningGroupIds = PlanningGroupIds;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            
        }
        




        /// <summary>
        /// The requested time zone of the exported data, in Olson format. Defaults to business unit time zone
        /// </summary>
        /// <value>The requested time zone of the exported data, in Olson format. Defaults to business unit time zone</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }



        /// <summary>
        /// The delimiter to use between fields in the export, defaults to comma
        /// </summary>
        /// <value>The delimiter to use between fields in the export, defaults to comma</value>
        [DataMember(Name="delimiter", EmitDefaultValue=false)]
        public string Delimiter { get; set; }



        /// <summary>
        /// The IDs of the planning groups to include in the export, defaults to all planning groups in the business unit
        /// </summary>
        /// <value>The IDs of the planning groups to include in the export, defaults to all planning groups in the business unit</value>
        [DataMember(Name="planningGroupIds", EmitDefaultValue=false)]
        public List<string> PlanningGroupIds { get; set; }



        /// <summary>
        /// Start date-time of the export range in ISO-8601 format
        /// </summary>
        /// <value>Start date-time of the export range in ISO-8601 format</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }



        /// <summary>
        /// End date-time of the export range in ISO-8601 format
        /// </summary>
        /// <value>End date-time of the export range in ISO-8601 format</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public DateTime? DateEnd { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregatedExportJobRequest {\n");

            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  PlanningGroupIds: ").Append(PlanningGroupIds).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
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
            return this.Equals(obj as AggregatedExportJobRequest);
        }

        /// <summary>
        /// Returns true if AggregatedExportJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AggregatedExportJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregatedExportJobRequest other)
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
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) &&
                (
                    this.Delimiter == other.Delimiter ||
                    this.Delimiter != null &&
                    this.Delimiter.Equals(other.Delimiter)
                ) &&
                (
                    this.PlanningGroupIds == other.PlanningGroupIds ||
                    this.PlanningGroupIds != null &&
                    this.PlanningGroupIds.SequenceEqual(other.PlanningGroupIds)
                ) &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
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

                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();

                if (this.Delimiter != null)
                    hash = hash * 59 + this.Delimiter.GetHashCode();

                if (this.PlanningGroupIds != null)
                    hash = hash * 59 + this.PlanningGroupIds.GetHashCode();

                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();

                return hash;
            }
        }
    }

}
