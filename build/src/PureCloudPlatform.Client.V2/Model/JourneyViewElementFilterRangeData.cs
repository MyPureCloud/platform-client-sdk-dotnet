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
    /// JourneyViewElementFilterRangeData
    /// </summary>
    [DataContract]
    public partial class JourneyViewElementFilterRangeData :  IEquatable<JourneyViewElementFilterRangeData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewElementFilterRangeData" /> class.
        /// </summary>
        /// <param name="Duration">An ISO 8601 time duration. Only one of number or duration must be specified..</param>
        /// <param name="Number">A numeric value. Only one of number or duration must be specified..</param>
        public JourneyViewElementFilterRangeData(string Duration = null, double? Number = null)
        {
            this.Duration = Duration;
            this.Number = Number;
            
        }
        


        /// <summary>
        /// An ISO 8601 time duration. Only one of number or duration must be specified.
        /// </summary>
        /// <value>An ISO 8601 time duration. Only one of number or duration must be specified.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public string Duration { get; set; }



        /// <summary>
        /// A numeric value. Only one of number or duration must be specified.
        /// </summary>
        /// <value>A numeric value. Only one of number or duration must be specified.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public double? Number { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewElementFilterRangeData {\n");

            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(obj as JourneyViewElementFilterRangeData);
        }

        /// <summary>
        /// Returns true if JourneyViewElementFilterRangeData instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewElementFilterRangeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewElementFilterRangeData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) &&
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
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
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();

                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();

                return hash;
            }
        }
    }

}
