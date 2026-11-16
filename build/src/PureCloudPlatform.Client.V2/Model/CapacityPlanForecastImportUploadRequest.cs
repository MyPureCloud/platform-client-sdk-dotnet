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
    /// CapacityPlanForecastImportUploadRequest
    /// </summary>
    [DataContract]
    public partial class CapacityPlanForecastImportUploadRequest :  IEquatable<CapacityPlanForecastImportUploadRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastImportUploadRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanForecastImportUploadRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastImportUploadRequest" /> class.
        /// </summary>
        /// <param name="HourlyForecast">Content length request details for the hourly forecast to be imported for the capacity plan (required).</param>
        /// <param name="DailyForecast">Content length request details for the daily forecast to be imported for the capacity plan (required).</param>
        public CapacityPlanForecastImportUploadRequest(UploadUrlRequestBody HourlyForecast = null, UploadUrlRequestBody DailyForecast = null)
        {
            this.HourlyForecast = HourlyForecast;
            this.DailyForecast = DailyForecast;
            
        }
        


        /// <summary>
        /// Content length request details for the hourly forecast to be imported for the capacity plan
        /// </summary>
        /// <value>Content length request details for the hourly forecast to be imported for the capacity plan</value>
        [DataMember(Name="hourlyForecast", EmitDefaultValue=false)]
        public UploadUrlRequestBody HourlyForecast { get; set; }



        /// <summary>
        /// Content length request details for the daily forecast to be imported for the capacity plan
        /// </summary>
        /// <value>Content length request details for the daily forecast to be imported for the capacity plan</value>
        [DataMember(Name="dailyForecast", EmitDefaultValue=false)]
        public UploadUrlRequestBody DailyForecast { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanForecastImportUploadRequest {\n");

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
            return this.Equals(obj as CapacityPlanForecastImportUploadRequest);
        }

        /// <summary>
        /// Returns true if CapacityPlanForecastImportUploadRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanForecastImportUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanForecastImportUploadRequest other)
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
