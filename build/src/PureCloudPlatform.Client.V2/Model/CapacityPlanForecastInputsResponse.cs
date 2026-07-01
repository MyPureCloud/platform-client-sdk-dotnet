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
    /// CapacityPlanForecastInputsResponse
    /// </summary>
    [DataContract]
    public partial class CapacityPlanForecastInputsResponse :  IEquatable<CapacityPlanForecastInputsResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastInputsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanForecastInputsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastInputsResponse" /> class.
        /// </summary>
        /// <param name="BusinessUnit">The business unit to which the capacity plan forecast inputs belongs (required).</param>
        /// <param name="CapacityPlan">The capacity plan associated with these forecast inputs (required).</param>
        /// <param name="DownloadUrl">The URL to get the forecast inputs for the capacity plan (required).</param>
        /// <param name="DownloadTemplate">Forecast inputs always come through downloadUrl, the schema included here is just for documentation.</param>
        public CapacityPlanForecastInputsResponse(BusinessUnitReference BusinessUnit = null, CapacityPlanReference CapacityPlan = null, string DownloadUrl = null, CapacityPlanForecastInputsTemplate DownloadTemplate = null)
        {
            this.BusinessUnit = BusinessUnit;
            this.CapacityPlan = CapacityPlan;
            this.DownloadUrl = DownloadUrl;
            this.DownloadTemplate = DownloadTemplate;
            
        }
        


        /// <summary>
        /// The business unit to which the capacity plan forecast inputs belongs
        /// </summary>
        /// <value>The business unit to which the capacity plan forecast inputs belongs</value>
        [DataMember(Name="businessUnit", EmitDefaultValue=false)]
        public BusinessUnitReference BusinessUnit { get; set; }



        /// <summary>
        /// The capacity plan associated with these forecast inputs
        /// </summary>
        /// <value>The capacity plan associated with these forecast inputs</value>
        [DataMember(Name="capacityPlan", EmitDefaultValue=false)]
        public CapacityPlanReference CapacityPlan { get; set; }



        /// <summary>
        /// The URL to get the forecast inputs for the capacity plan
        /// </summary>
        /// <value>The URL to get the forecast inputs for the capacity plan</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Forecast inputs always come through downloadUrl, the schema included here is just for documentation
        /// </summary>
        /// <value>Forecast inputs always come through downloadUrl, the schema included here is just for documentation</value>
        [DataMember(Name="downloadTemplate", EmitDefaultValue=false)]
        public CapacityPlanForecastInputsTemplate DownloadTemplate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanForecastInputsResponse {\n");

            sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
            sb.Append("  CapacityPlan: ").Append(CapacityPlan).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  DownloadTemplate: ").Append(DownloadTemplate).Append("\n");
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
            return this.Equals(obj as CapacityPlanForecastInputsResponse);
        }

        /// <summary>
        /// Returns true if CapacityPlanForecastInputsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanForecastInputsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanForecastInputsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.BusinessUnit == other.BusinessUnit ||
                    this.BusinessUnit != null &&
                    this.BusinessUnit.Equals(other.BusinessUnit)
                ) &&
                (
                    this.CapacityPlan == other.CapacityPlan ||
                    this.CapacityPlan != null &&
                    this.CapacityPlan.Equals(other.CapacityPlan)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.DownloadTemplate == other.DownloadTemplate ||
                    this.DownloadTemplate != null &&
                    this.DownloadTemplate.Equals(other.DownloadTemplate)
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
                if (this.BusinessUnit != null)
                    hash = hash * 59 + this.BusinessUnit.GetHashCode();

                if (this.CapacityPlan != null)
                    hash = hash * 59 + this.CapacityPlan.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.DownloadTemplate != null)
                    hash = hash * 59 + this.DownloadTemplate.GetHashCode();

                return hash;
            }
        }
    }

}
