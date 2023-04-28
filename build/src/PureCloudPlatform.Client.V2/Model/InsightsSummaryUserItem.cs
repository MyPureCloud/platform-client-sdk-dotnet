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
    /// InsightsSummaryUserItem
    /// </summary>
    [DataContract]
    public partial class InsightsSummaryUserItem :  IEquatable<InsightsSummaryUserItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsSummaryUserItem" /> class.
        /// </summary>
        /// <param name="User">Queried user.</param>
        /// <param name="MetricData">The list of insights data for each metric of the user.</param>
        /// <param name="OverallData">Overall insights data of the user.</param>
        public InsightsSummaryUserItem(UserReference User = null, List<InsightsSummaryMetricItem> MetricData = null, InsightsSummaryOverallItem OverallData = null)
        {
            this.User = User;
            this.MetricData = MetricData;
            this.OverallData = OverallData;
            
        }
        


        /// <summary>
        /// Queried user
        /// </summary>
        /// <value>Queried user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// The list of insights data for each metric of the user
        /// </summary>
        /// <value>The list of insights data for each metric of the user</value>
        [DataMember(Name="metricData", EmitDefaultValue=false)]
        public List<InsightsSummaryMetricItem> MetricData { get; set; }



        /// <summary>
        /// Overall insights data of the user
        /// </summary>
        /// <value>Overall insights data of the user</value>
        [DataMember(Name="overallData", EmitDefaultValue=false)]
        public InsightsSummaryOverallItem OverallData { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsightsSummaryUserItem {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  MetricData: ").Append(MetricData).Append("\n");
            sb.Append("  OverallData: ").Append(OverallData).Append("\n");
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
            return this.Equals(obj as InsightsSummaryUserItem);
        }

        /// <summary>
        /// Returns true if InsightsSummaryUserItem instances are equal
        /// </summary>
        /// <param name="other">Instance of InsightsSummaryUserItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsSummaryUserItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.MetricData == other.MetricData ||
                    this.MetricData != null &&
                    this.MetricData.SequenceEqual(other.MetricData)
                ) &&
                (
                    this.OverallData == other.OverallData ||
                    this.OverallData != null &&
                    this.OverallData.Equals(other.OverallData)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.MetricData != null)
                    hash = hash * 59 + this.MetricData.GetHashCode();

                if (this.OverallData != null)
                    hash = hash * 59 + this.OverallData.GetHashCode();

                return hash;
            }
        }
    }

}
