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
    /// A chart within the context of the elements of the the journey view
    /// </summary>
    [DataContract]
    public partial class JourneyViewChart :  IEquatable<JourneyViewChart>
    {
        /// <summary>
        /// A time unit to group the metrics by. There is a limit on the number of groupBy properties which can be specified.
        /// </summary>
        /// <value>A time unit to group the metrics by. There is a limit on the number of groupBy properties which can be specified.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GroupByTimeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Day for "Day"
            /// </summary>
            [EnumMember(Value = "Day")]
            Day,
            
            /// <summary>
            /// Enum Week for "Week"
            /// </summary>
            [EnumMember(Value = "Week")]
            Week,
            
            /// <summary>
            /// Enum Month for "Month"
            /// </summary>
            [EnumMember(Value = "Month")]
            Month,
            
            /// <summary>
            /// Enum Year for "Year"
            /// </summary>
            [EnumMember(Value = "Year")]
            Year
        }
        /// <summary>
        /// A time unit to group the metrics by. There is a limit on the number of groupBy properties which can be specified.
        /// </summary>
        /// <value>A time unit to group the metrics by. There is a limit on the number of groupBy properties which can be specified.</value>
        [DataMember(Name="groupByTime", EmitDefaultValue=false)]
        public GroupByTimeEnum? GroupByTime { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewChart" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneyViewChart() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewChart" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="GroupByTime">A time unit to group the metrics by. There is a limit on the number of groupBy properties which can be specified..</param>
        /// <param name="GroupByAttributes">A list of attributes to group the metrics by. There is a limit on the number of groupBy properties which can be specified..</param>
        /// <param name="Metrics">A list of metrics to calculate within the chart by (aka the y axis) (required).</param>
        /// <param name="DisplayAttributes">Optional display attributes for rendering the chart.</param>
        /// <param name="GroupByMax">A maximum on the number of values being grouped by.</param>
        public JourneyViewChart(string Name = null, GroupByTimeEnum? GroupByTime = null, List<JourneyViewChartGroupByAttribute> GroupByAttributes = null, List<JourneyViewChartMetric> Metrics = null, JourneyViewChartDisplayAttributes DisplayAttributes = null, long? GroupByMax = null)
        {
            this.Name = Name;
            this.GroupByTime = GroupByTime;
            this.GroupByAttributes = GroupByAttributes;
            this.Metrics = Metrics;
            this.DisplayAttributes = DisplayAttributes;
            this.GroupByMax = GroupByMax;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The version of the journey view chart
        /// </summary>
        /// <value>The version of the journey view chart</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }





        /// <summary>
        /// A list of attributes to group the metrics by. There is a limit on the number of groupBy properties which can be specified.
        /// </summary>
        /// <value>A list of attributes to group the metrics by. There is a limit on the number of groupBy properties which can be specified.</value>
        [DataMember(Name="groupByAttributes", EmitDefaultValue=false)]
        public List<JourneyViewChartGroupByAttribute> GroupByAttributes { get; set; }



        /// <summary>
        /// A list of metrics to calculate within the chart by (aka the y axis)
        /// </summary>
        /// <value>A list of metrics to calculate within the chart by (aka the y axis)</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<JourneyViewChartMetric> Metrics { get; set; }



        /// <summary>
        /// Optional display attributes for rendering the chart
        /// </summary>
        /// <value>Optional display attributes for rendering the chart</value>
        [DataMember(Name="displayAttributes", EmitDefaultValue=false)]
        public JourneyViewChartDisplayAttributes DisplayAttributes { get; set; }



        /// <summary>
        /// A maximum on the number of values being grouped by
        /// </summary>
        /// <value>A maximum on the number of values being grouped by</value>
        [DataMember(Name="groupByMax", EmitDefaultValue=false)]
        public long? GroupByMax { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewChart {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  GroupByTime: ").Append(GroupByTime).Append("\n");
            sb.Append("  GroupByAttributes: ").Append(GroupByAttributes).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  DisplayAttributes: ").Append(DisplayAttributes).Append("\n");
            sb.Append("  GroupByMax: ").Append(GroupByMax).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as JourneyViewChart);
        }

        /// <summary>
        /// Returns true if JourneyViewChart instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewChart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewChart other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.GroupByTime == other.GroupByTime ||
                    this.GroupByTime != null &&
                    this.GroupByTime.Equals(other.GroupByTime)
                ) &&
                (
                    this.GroupByAttributes == other.GroupByAttributes ||
                    this.GroupByAttributes != null &&
                    this.GroupByAttributes.SequenceEqual(other.GroupByAttributes)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.DisplayAttributes == other.DisplayAttributes ||
                    this.DisplayAttributes != null &&
                    this.DisplayAttributes.Equals(other.DisplayAttributes)
                ) &&
                (
                    this.GroupByMax == other.GroupByMax ||
                    this.GroupByMax != null &&
                    this.GroupByMax.Equals(other.GroupByMax)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.GroupByTime != null)
                    hash = hash * 59 + this.GroupByTime.GetHashCode();

                if (this.GroupByAttributes != null)
                    hash = hash * 59 + this.GroupByAttributes.GetHashCode();

                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();

                if (this.DisplayAttributes != null)
                    hash = hash * 59 + this.DisplayAttributes.GetHashCode();

                if (this.GroupByMax != null)
                    hash = hash * 59 + this.GroupByMax.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
