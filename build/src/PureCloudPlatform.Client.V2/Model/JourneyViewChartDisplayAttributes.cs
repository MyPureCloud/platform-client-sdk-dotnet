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
    /// Display attributes for the chart, such as type, labels and legends
    /// </summary>
    [DataContract]
    public partial class JourneyViewChartDisplayAttributes :  IEquatable<JourneyViewChartDisplayAttributes>
    {
        /// <summary>
        /// The type of chart to display
        /// </summary>
        /// <value>The type of chart to display</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Column for "Column"
            /// </summary>
            [EnumMember(Value = "Column")]
            Column,
            
            /// <summary>
            /// Enum Bar for "Bar"
            /// </summary>
            [EnumMember(Value = "Bar")]
            Bar,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>
            [EnumMember(Value = "Line")]
            Line
        }
        /// <summary>
        /// The type of chart to display
        /// </summary>
        /// <value>The type of chart to display</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewChartDisplayAttributes" /> class.
        /// </summary>
        /// <param name="Type">The type of chart to display.</param>
        /// <param name="GroupByTitle">A title for the grouped by attributes (aka the x axis).</param>
        /// <param name="MetricsTitle">A title for the metrics (aka the y axis).</param>
        /// <param name="ShowLegend">Whether to show a legend.</param>
        public JourneyViewChartDisplayAttributes(TypeEnum? Type = null, string GroupByTitle = null, string MetricsTitle = null, bool? ShowLegend = null)
        {
            this.Type = Type;
            this.GroupByTitle = GroupByTitle;
            this.MetricsTitle = MetricsTitle;
            this.ShowLegend = ShowLegend;
            
        }
        




        /// <summary>
        /// A title for the grouped by attributes (aka the x axis)
        /// </summary>
        /// <value>A title for the grouped by attributes (aka the x axis)</value>
        [DataMember(Name="groupByTitle", EmitDefaultValue=false)]
        public string GroupByTitle { get; set; }



        /// <summary>
        /// A title for the metrics (aka the y axis)
        /// </summary>
        /// <value>A title for the metrics (aka the y axis)</value>
        [DataMember(Name="metricsTitle", EmitDefaultValue=false)]
        public string MetricsTitle { get; set; }



        /// <summary>
        /// Whether to show a legend
        /// </summary>
        /// <value>Whether to show a legend</value>
        [DataMember(Name="showLegend", EmitDefaultValue=false)]
        public bool? ShowLegend { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewChartDisplayAttributes {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  GroupByTitle: ").Append(GroupByTitle).Append("\n");
            sb.Append("  MetricsTitle: ").Append(MetricsTitle).Append("\n");
            sb.Append("  ShowLegend: ").Append(ShowLegend).Append("\n");
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
            return this.Equals(obj as JourneyViewChartDisplayAttributes);
        }

        /// <summary>
        /// Returns true if JourneyViewChartDisplayAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewChartDisplayAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewChartDisplayAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.GroupByTitle == other.GroupByTitle ||
                    this.GroupByTitle != null &&
                    this.GroupByTitle.Equals(other.GroupByTitle)
                ) &&
                (
                    this.MetricsTitle == other.MetricsTitle ||
                    this.MetricsTitle != null &&
                    this.MetricsTitle.Equals(other.MetricsTitle)
                ) &&
                (
                    this.ShowLegend == other.ShowLegend ||
                    this.ShowLegend != null &&
                    this.ShowLegend.Equals(other.ShowLegend)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.GroupByTitle != null)
                    hash = hash * 59 + this.GroupByTitle.GetHashCode();

                if (this.MetricsTitle != null)
                    hash = hash * 59 + this.MetricsTitle.GetHashCode();

                if (this.ShowLegend != null)
                    hash = hash * 59 + this.ShowLegend.GetHashCode();

                return hash;
            }
        }
    }

}
