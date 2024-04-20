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
    /// JourneyViewChartMetricResult
    /// </summary>
    [DataContract]
    public partial class JourneyViewChartMetricResult :  IEquatable<JourneyViewChartMetricResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewChartMetricResult" /> class.
        /// </summary>
        public JourneyViewChartMetricResult()
        {
            
        }
        


        /// <summary>
        /// Id of the metric
        /// </summary>
        /// <value>Id of the metric</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Metric result values
        /// </summary>
        /// <value>Metric result values</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<JourneyViewChartMetricResultValue> Values { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewChartMetricResult {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as JourneyViewChartMetricResult);
        }

        /// <summary>
        /// Returns true if JourneyViewChartMetricResult instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewChartMetricResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewChartMetricResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                return hash;
            }
        }
    }

}
