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
    /// JourneyViewChartMetricResultValue
    /// </summary>
    [DataContract]
    public partial class JourneyViewChartMetricResultValue :  IEquatable<JourneyViewChartMetricResultValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewChartMetricResultValue" /> class.
        /// </summary>
        public JourneyViewChartMetricResultValue()
        {
            
        }
        


        /// <summary>
        /// Value for this metric
        /// </summary>
        /// <value>Value for this metric</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; private set; }



        /// <summary>
        /// Group by attributes for this metric
        /// </summary>
        /// <value>Group by attributes for this metric</value>
        [DataMember(Name="groupByAttributes", EmitDefaultValue=false)]
        public List<GroupByAttribute> GroupByAttributes { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewChartMetricResultValue {\n");

            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  GroupByAttributes: ").Append(GroupByAttributes).Append("\n");
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
            return this.Equals(obj as JourneyViewChartMetricResultValue);
        }

        /// <summary>
        /// Returns true if JourneyViewChartMetricResultValue instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewChartMetricResultValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewChartMetricResultValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.GroupByAttributes == other.GroupByAttributes ||
                    this.GroupByAttributes != null &&
                    this.GroupByAttributes.SequenceEqual(other.GroupByAttributes)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.GroupByAttributes != null)
                    hash = hash * 59 + this.GroupByAttributes.GetHashCode();

                return hash;
            }
        }
    }

}
