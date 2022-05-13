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
    /// ForecastAverageSpeedOfAnswerResponse
    /// </summary>
    [DataContract]
    public partial class ForecastAverageSpeedOfAnswerResponse :  IEquatable<ForecastAverageSpeedOfAnswerResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastAverageSpeedOfAnswerResponse" /> class.
        /// </summary>
        /// <param name="Seconds">the average speed of answer goal in seconds.</param>
        public ForecastAverageSpeedOfAnswerResponse(int? Seconds = null)
        {
            this.Seconds = Seconds;
            
        }
        


        /// <summary>
        /// the average speed of answer goal in seconds
        /// </summary>
        /// <value>the average speed of answer goal in seconds</value>
        [DataMember(Name="seconds", EmitDefaultValue=false)]
        public int? Seconds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastAverageSpeedOfAnswerResponse {\n");

            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
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
            return this.Equals(obj as ForecastAverageSpeedOfAnswerResponse);
        }

        /// <summary>
        /// Returns true if ForecastAverageSpeedOfAnswerResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastAverageSpeedOfAnswerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastAverageSpeedOfAnswerResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Seconds == other.Seconds ||
                    this.Seconds != null &&
                    this.Seconds.Equals(other.Seconds)
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
                if (this.Seconds != null)
                    hash = hash * 59 + this.Seconds.GetHashCode();

                return hash;
            }
        }
    }

}
