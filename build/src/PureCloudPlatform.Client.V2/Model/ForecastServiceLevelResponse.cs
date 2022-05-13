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
    /// ForecastServiceLevelResponse
    /// </summary>
    [DataContract]
    public partial class ForecastServiceLevelResponse :  IEquatable<ForecastServiceLevelResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastServiceLevelResponse" /> class.
        /// </summary>
        /// <param name="Percent">The percent of calls to answer in the number of seconds defined.</param>
        /// <param name="Seconds">The number of seconds to define for the percent of calls to be answered.</param>
        public ForecastServiceLevelResponse(int? Percent = null, int? Seconds = null)
        {
            this.Percent = Percent;
            this.Seconds = Seconds;
            
        }
        


        /// <summary>
        /// The percent of calls to answer in the number of seconds defined
        /// </summary>
        /// <value>The percent of calls to answer in the number of seconds defined</value>
        [DataMember(Name="percent", EmitDefaultValue=false)]
        public int? Percent { get; set; }



        /// <summary>
        /// The number of seconds to define for the percent of calls to be answered
        /// </summary>
        /// <value>The number of seconds to define for the percent of calls to be answered</value>
        [DataMember(Name="seconds", EmitDefaultValue=false)]
        public int? Seconds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastServiceLevelResponse {\n");

            sb.Append("  Percent: ").Append(Percent).Append("\n");
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
            return this.Equals(obj as ForecastServiceLevelResponse);
        }

        /// <summary>
        /// Returns true if ForecastServiceLevelResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastServiceLevelResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastServiceLevelResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Percent == other.Percent ||
                    this.Percent != null &&
                    this.Percent.Equals(other.Percent)
                ) &&
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
                if (this.Percent != null)
                    hash = hash * 59 + this.Percent.GetHashCode();

                if (this.Seconds != null)
                    hash = hash * 59 + this.Seconds.GetHashCode();

                return hash;
            }
        }
    }

}
