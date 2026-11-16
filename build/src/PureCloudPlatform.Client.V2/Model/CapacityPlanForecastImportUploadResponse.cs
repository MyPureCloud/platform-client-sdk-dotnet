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
    /// CapacityPlanForecastImportUploadResponse
    /// </summary>
    [DataContract]
    public partial class CapacityPlanForecastImportUploadResponse :  IEquatable<CapacityPlanForecastImportUploadResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastImportUploadResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanForecastImportUploadResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastImportUploadResponse" /> class.
        /// </summary>
        /// <param name="HourlyForecast">The upload URL, upload key, and required headers for the hourly forecast to be imported for the capacity plan (required).</param>
        /// <param name="DailyForecast">The upload URL, upload key, and required headers for the daily forecast to be imported for the capacity plan (required).</param>
        public CapacityPlanForecastImportUploadResponse(CapacityPlanForecastImportUpload HourlyForecast = null, CapacityPlanForecastImportUpload DailyForecast = null)
        {
            this.HourlyForecast = HourlyForecast;
            this.DailyForecast = DailyForecast;
            
        }
        


        /// <summary>
        /// The upload URL, upload key, and required headers for the hourly forecast to be imported for the capacity plan
        /// </summary>
        /// <value>The upload URL, upload key, and required headers for the hourly forecast to be imported for the capacity plan</value>
        [DataMember(Name="hourlyForecast", EmitDefaultValue=false)]
        public CapacityPlanForecastImportUpload HourlyForecast { get; set; }



        /// <summary>
        /// The upload URL, upload key, and required headers for the daily forecast to be imported for the capacity plan
        /// </summary>
        /// <value>The upload URL, upload key, and required headers for the daily forecast to be imported for the capacity plan</value>
        [DataMember(Name="dailyForecast", EmitDefaultValue=false)]
        public CapacityPlanForecastImportUpload DailyForecast { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanForecastImportUploadResponse {\n");

            sb.Append("  HourlyForecast: ").Append(HourlyForecast).Append("\n");
            sb.Append("  DailyForecast: ").Append(DailyForecast).Append("\n");
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
            return this.Equals(obj as CapacityPlanForecastImportUploadResponse);
        }

        /// <summary>
        /// Returns true if CapacityPlanForecastImportUploadResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanForecastImportUploadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanForecastImportUploadResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.HourlyForecast == other.HourlyForecast ||
                    this.HourlyForecast != null &&
                    this.HourlyForecast.Equals(other.HourlyForecast)
                ) &&
                (
                    this.DailyForecast == other.DailyForecast ||
                    this.DailyForecast != null &&
                    this.DailyForecast.Equals(other.DailyForecast)
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
                if (this.HourlyForecast != null)
                    hash = hash * 59 + this.HourlyForecast.GetHashCode();

                if (this.DailyForecast != null)
                    hash = hash * 59 + this.DailyForecast.GetHashCode();

                return hash;
            }
        }
    }

}
