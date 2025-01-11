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
    /// A metric to measure within the chart
    /// </summary>
    [DataContract]
    public partial class JourneyViewChartMetric :  IEquatable<JourneyViewChartMetric>
    {
        /// <summary>
        /// How to aggregate the given element, defaults to CustomerCount
        /// </summary>
        /// <value>How to aggregate the given element, defaults to CustomerCount</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AggregateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Eventcount for "EventCount"
            /// </summary>
            [EnumMember(Value = "EventCount")]
            Eventcount,
            
            /// <summary>
            /// Enum Customercount for "CustomerCount"
            /// </summary>
            [EnumMember(Value = "CustomerCount")]
            Customercount
        }
        /// <summary>
        /// How to aggregate the given element, defaults to CustomerCount
        /// </summary>
        /// <value>How to aggregate the given element, defaults to CustomerCount</value>
        [DataMember(Name="aggregate", EmitDefaultValue=false)]
        public AggregateEnum? Aggregate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewChartMetric" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneyViewChartMetric() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewChartMetric" /> class.
        /// </summary>
        /// <param name="Id">The unique identifier of the metric within the chart (required).</param>
        /// <param name="ElementId">The element in the list of elements which the metric is measuring (required).</param>
        /// <param name="Aggregate">How to aggregate the given element, defaults to CustomerCount.</param>
        /// <param name="DisplayLabel">A display label for the metric.</param>
        public JourneyViewChartMetric(string Id = null, string ElementId = null, AggregateEnum? Aggregate = null, string DisplayLabel = null)
        {
            this.Id = Id;
            this.ElementId = ElementId;
            this.Aggregate = Aggregate;
            this.DisplayLabel = DisplayLabel;
            
        }
        


        /// <summary>
        /// The unique identifier of the metric within the chart
        /// </summary>
        /// <value>The unique identifier of the metric within the chart</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The element in the list of elements which the metric is measuring
        /// </summary>
        /// <value>The element in the list of elements which the metric is measuring</value>
        [DataMember(Name="elementId", EmitDefaultValue=false)]
        public string ElementId { get; set; }





        /// <summary>
        /// A display label for the metric
        /// </summary>
        /// <value>A display label for the metric</value>
        [DataMember(Name="displayLabel", EmitDefaultValue=false)]
        public string DisplayLabel { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewChartMetric {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ElementId: ").Append(ElementId).Append("\n");
            sb.Append("  Aggregate: ").Append(Aggregate).Append("\n");
            sb.Append("  DisplayLabel: ").Append(DisplayLabel).Append("\n");
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
            return this.Equals(obj as JourneyViewChartMetric);
        }

        /// <summary>
        /// Returns true if JourneyViewChartMetric instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewChartMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewChartMetric other)
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
                    this.ElementId == other.ElementId ||
                    this.ElementId != null &&
                    this.ElementId.Equals(other.ElementId)
                ) &&
                (
                    this.Aggregate == other.Aggregate ||
                    this.Aggregate != null &&
                    this.Aggregate.Equals(other.Aggregate)
                ) &&
                (
                    this.DisplayLabel == other.DisplayLabel ||
                    this.DisplayLabel != null &&
                    this.DisplayLabel.Equals(other.DisplayLabel)
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

                if (this.ElementId != null)
                    hash = hash * 59 + this.ElementId.GetHashCode();

                if (this.Aggregate != null)
                    hash = hash * 59 + this.Aggregate.GetHashCode();

                if (this.DisplayLabel != null)
                    hash = hash * 59 + this.DisplayLabel.GetHashCode();

                return hash;
            }
        }
    }

}
