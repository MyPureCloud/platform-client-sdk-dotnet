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
    /// CapacityPlanImportedForecastRequest
    /// </summary>
    [DataContract]
    public partial class CapacityPlanImportedForecastRequest :  IEquatable<CapacityPlanImportedForecastRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanImportedForecastRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanImportedForecastRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanImportedForecastRequest" /> class.
        /// </summary>
        /// <param name="HourlyForecastUploadKey">The uploadKey returned in the hourlyForecast field of the capacity plan forecast upload URL response (required).</param>
        /// <param name="DailyForecastUploadKey">The uploadKey returned in the dailyForecast field of the capacity plan forecast upload URL response (required).</param>
        public CapacityPlanImportedForecastRequest(string HourlyForecastUploadKey = null, string DailyForecastUploadKey = null)
        {
            this.HourlyForecastUploadKey = HourlyForecastUploadKey;
            this.DailyForecastUploadKey = DailyForecastUploadKey;
            
        }
        


        /// <summary>
        /// The uploadKey returned in the hourlyForecast field of the capacity plan forecast upload URL response
        /// </summary>
        /// <value>The uploadKey returned in the hourlyForecast field of the capacity plan forecast upload URL response</value>
        [DataMember(Name="hourlyForecastUploadKey", EmitDefaultValue=false)]
        public string HourlyForecastUploadKey { get; set; }



        /// <summary>
        /// The uploadKey returned in the dailyForecast field of the capacity plan forecast upload URL response
        /// </summary>
        /// <value>The uploadKey returned in the dailyForecast field of the capacity plan forecast upload URL response</value>
        [DataMember(Name="dailyForecastUploadKey", EmitDefaultValue=false)]
        public string DailyForecastUploadKey { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanImportedForecastRequest {\n");

            sb.Append("  HourlyForecastUploadKey: ").Append(HourlyForecastUploadKey).Append("\n");
            sb.Append("  DailyForecastUploadKey: ").Append(DailyForecastUploadKey).Append("\n");
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
            return this.Equals(obj as CapacityPlanImportedForecastRequest);
        }

        /// <summary>
        /// Returns true if CapacityPlanImportedForecastRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanImportedForecastRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanImportedForecastRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.HourlyForecastUploadKey == other.HourlyForecastUploadKey ||
                    this.HourlyForecastUploadKey != null &&
                    this.HourlyForecastUploadKey.Equals(other.HourlyForecastUploadKey)
                ) &&
                (
                    this.DailyForecastUploadKey == other.DailyForecastUploadKey ||
                    this.DailyForecastUploadKey != null &&
                    this.DailyForecastUploadKey.Equals(other.DailyForecastUploadKey)
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
                if (this.HourlyForecastUploadKey != null)
                    hash = hash * 59 + this.HourlyForecastUploadKey.GetHashCode();

                if (this.DailyForecastUploadKey != null)
                    hash = hash * 59 + this.DailyForecastUploadKey.GetHashCode();

                return hash;
            }
        }
    }

}
