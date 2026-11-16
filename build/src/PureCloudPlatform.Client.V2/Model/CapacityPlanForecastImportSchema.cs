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
    /// CapacityPlanForecastImportSchema
    /// </summary>
    [DataContract]
    public partial class CapacityPlanForecastImportSchema :  IEquatable<CapacityPlanForecastImportSchema>
    {
        /// <summary>
        /// The granularity at which forecast values are provided for each planning group
        /// </summary>
        /// <value>The granularity at which forecast values are provided for each planning group</value>
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
            /// Enum Hourly for "Hourly"
            /// </summary>
            [EnumMember(Value = "Hourly")]
            Hourly,
            
            /// <summary>
            /// Enum Daily for "Daily"
            /// </summary>
            [EnumMember(Value = "Daily")]
            Daily
        }
        /// <summary>
        /// The granularity at which forecast values are provided for each planning group
        /// </summary>
        /// <value>The granularity at which forecast values are provided for each planning group</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public GranularityEnum? Granularity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastImportSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanForecastImportSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastImportSchema" /> class.
        /// </summary>
        /// <param name="Granularity">The granularity at which forecast values are provided for each planning group (required).</param>
        /// <param name="BusinessUnitStartDate">The first day of the forecast relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="PlanningGroups">The forecast data for the planning groups included in this forecast (required).</param>
        public CapacityPlanForecastImportSchema(GranularityEnum? Granularity = null, String BusinessUnitStartDate = null, List<CapacityPlanForecastPlanningGroup> PlanningGroups = null)
        {
            this.Granularity = Granularity;
            this.BusinessUnitStartDate = BusinessUnitStartDate;
            this.PlanningGroups = PlanningGroups;
            
        }
        




        /// <summary>
        /// The first day of the forecast relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The first day of the forecast relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="businessUnitStartDate", EmitDefaultValue=false)]
        public String BusinessUnitStartDate { get; set; }



        /// <summary>
        /// The forecast data for the planning groups included in this forecast
        /// </summary>
        /// <value>The forecast data for the planning groups included in this forecast</value>
        [DataMember(Name="planningGroups", EmitDefaultValue=false)]
        public List<CapacityPlanForecastPlanningGroup> PlanningGroups { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanForecastImportSchema {\n");

            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  BusinessUnitStartDate: ").Append(BusinessUnitStartDate).Append("\n");
            sb.Append("  PlanningGroups: ").Append(PlanningGroups).Append("\n");
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
            return this.Equals(obj as CapacityPlanForecastImportSchema);
        }

        /// <summary>
        /// Returns true if CapacityPlanForecastImportSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanForecastImportSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanForecastImportSchema other)
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
                    this.BusinessUnitStartDate == other.BusinessUnitStartDate ||
                    this.BusinessUnitStartDate != null &&
                    this.BusinessUnitStartDate.Equals(other.BusinessUnitStartDate)
                ) &&
                (
                    this.PlanningGroups == other.PlanningGroups ||
                    this.PlanningGroups != null &&
                    this.PlanningGroups.SequenceEqual(other.PlanningGroups)
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

                if (this.BusinessUnitStartDate != null)
                    hash = hash * 59 + this.BusinessUnitStartDate.GetHashCode();

                if (this.PlanningGroups != null)
                    hash = hash * 59 + this.PlanningGroups.GetHashCode();

                return hash;
            }
        }
    }

}
