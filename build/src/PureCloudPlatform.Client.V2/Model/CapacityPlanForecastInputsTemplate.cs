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
    /// CapacityPlanForecastInputsTemplate
    /// </summary>
    [DataContract]
    public partial class CapacityPlanForecastInputsTemplate :  IEquatable<CapacityPlanForecastInputsTemplate>
    {
        /// <summary>
        /// Granularity of the intervals
        /// </summary>
        /// <value>Granularity of the intervals</value>
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
            /// Enum Weekly for "Weekly"
            /// </summary>
            [EnumMember(Value = "Weekly")]
            Weekly,
            
            /// <summary>
            /// Enum Monthly for "Monthly"
            /// </summary>
            [EnumMember(Value = "Monthly")]
            Monthly
        }
        /// <summary>
        /// Granularity of the intervals
        /// </summary>
        /// <value>Granularity of the intervals</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public GranularityEnum? Granularity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastInputsTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanForecastInputsTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastInputsTemplate" /> class.
        /// </summary>
        /// <param name="ReferenceBusinessUnitDate">The reference date for interval-based data relative to the business unit time zone for the forecast inputs. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="Granularity">Granularity of the intervals (required).</param>
        /// <param name="Months">The list of months covered by this capacity plan, formatted as yyyy-MM, populated for monthly granularity.</param>
        /// <param name="PlanningGroupsForecastData">The forecast data for the planning groups (required).</param>
        /// <param name="CapacityPlanForecastSummary">The summary of forecast inputs for this capacity plan, for the selected granularity (required).</param>
        public CapacityPlanForecastInputsTemplate(String ReferenceBusinessUnitDate = null, GranularityEnum? Granularity = null, List<YearMonth> Months = null, List<ForecastInputPlanningGroupData> PlanningGroupsForecastData = null, CapacityPlanForecastMetrics CapacityPlanForecastSummary = null)
        {
            this.ReferenceBusinessUnitDate = ReferenceBusinessUnitDate;
            this.Granularity = Granularity;
            this.Months = Months;
            this.PlanningGroupsForecastData = PlanningGroupsForecastData;
            this.CapacityPlanForecastSummary = CapacityPlanForecastSummary;
            
        }
        


        /// <summary>
        /// The reference date for interval-based data relative to the business unit time zone for the forecast inputs. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The reference date for interval-based data relative to the business unit time zone for the forecast inputs. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="referenceBusinessUnitDate", EmitDefaultValue=false)]
        public String ReferenceBusinessUnitDate { get; set; }





        /// <summary>
        /// The list of months covered by this capacity plan, formatted as yyyy-MM, populated for monthly granularity
        /// </summary>
        /// <value>The list of months covered by this capacity plan, formatted as yyyy-MM, populated for monthly granularity</value>
        [DataMember(Name="months", EmitDefaultValue=false)]
        public List<YearMonth> Months { get; set; }



        /// <summary>
        /// The forecast data for the planning groups
        /// </summary>
        /// <value>The forecast data for the planning groups</value>
        [DataMember(Name="planningGroupsForecastData", EmitDefaultValue=false)]
        public List<ForecastInputPlanningGroupData> PlanningGroupsForecastData { get; set; }



        /// <summary>
        /// The summary of forecast inputs for this capacity plan, for the selected granularity
        /// </summary>
        /// <value>The summary of forecast inputs for this capacity plan, for the selected granularity</value>
        [DataMember(Name="capacityPlanForecastSummary", EmitDefaultValue=false)]
        public CapacityPlanForecastMetrics CapacityPlanForecastSummary { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanForecastInputsTemplate {\n");

            sb.Append("  ReferenceBusinessUnitDate: ").Append(ReferenceBusinessUnitDate).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  Months: ").Append(Months).Append("\n");
            sb.Append("  PlanningGroupsForecastData: ").Append(PlanningGroupsForecastData).Append("\n");
            sb.Append("  CapacityPlanForecastSummary: ").Append(CapacityPlanForecastSummary).Append("\n");
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
            return this.Equals(obj as CapacityPlanForecastInputsTemplate);
        }

        /// <summary>
        /// Returns true if CapacityPlanForecastInputsTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanForecastInputsTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanForecastInputsTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ReferenceBusinessUnitDate == other.ReferenceBusinessUnitDate ||
                    this.ReferenceBusinessUnitDate != null &&
                    this.ReferenceBusinessUnitDate.Equals(other.ReferenceBusinessUnitDate)
                ) &&
                (
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.Months == other.Months ||
                    this.Months != null &&
                    this.Months.SequenceEqual(other.Months)
                ) &&
                (
                    this.PlanningGroupsForecastData == other.PlanningGroupsForecastData ||
                    this.PlanningGroupsForecastData != null &&
                    this.PlanningGroupsForecastData.SequenceEqual(other.PlanningGroupsForecastData)
                ) &&
                (
                    this.CapacityPlanForecastSummary == other.CapacityPlanForecastSummary ||
                    this.CapacityPlanForecastSummary != null &&
                    this.CapacityPlanForecastSummary.Equals(other.CapacityPlanForecastSummary)
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
                if (this.ReferenceBusinessUnitDate != null)
                    hash = hash * 59 + this.ReferenceBusinessUnitDate.GetHashCode();

                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.Months != null)
                    hash = hash * 59 + this.Months.GetHashCode();

                if (this.PlanningGroupsForecastData != null)
                    hash = hash * 59 + this.PlanningGroupsForecastData.GetHashCode();

                if (this.CapacityPlanForecastSummary != null)
                    hash = hash * 59 + this.CapacityPlanForecastSummary.GetHashCode();

                return hash;
            }
        }
    }

}
