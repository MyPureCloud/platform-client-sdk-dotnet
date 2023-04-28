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
    /// InsightsTrends
    /// </summary>
    [DataContract]
    public partial class InsightsTrends :  IEquatable<InsightsTrends>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsTrends" /> class.
        /// </summary>
        /// <param name="ComparativePeriod">List of trend data in the comparative period.</param>
        /// <param name="PrimaryPeriod">List of trend data in the primary period.</param>
        public InsightsTrends(List<TrendData> ComparativePeriod = null, List<TrendData> PrimaryPeriod = null)
        {
            this.ComparativePeriod = ComparativePeriod;
            this.PrimaryPeriod = PrimaryPeriod;
            
        }
        


        /// <summary>
        /// List of trend data in the comparative period
        /// </summary>
        /// <value>List of trend data in the comparative period</value>
        [DataMember(Name="comparativePeriod", EmitDefaultValue=false)]
        public List<TrendData> ComparativePeriod { get; set; }



        /// <summary>
        /// List of trend data in the primary period
        /// </summary>
        /// <value>List of trend data in the primary period</value>
        [DataMember(Name="primaryPeriod", EmitDefaultValue=false)]
        public List<TrendData> PrimaryPeriod { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsightsTrends {\n");

            sb.Append("  ComparativePeriod: ").Append(ComparativePeriod).Append("\n");
            sb.Append("  PrimaryPeriod: ").Append(PrimaryPeriod).Append("\n");
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
            return this.Equals(obj as InsightsTrends);
        }

        /// <summary>
        /// Returns true if InsightsTrends instances are equal
        /// </summary>
        /// <param name="other">Instance of InsightsTrends to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsTrends other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ComparativePeriod == other.ComparativePeriod ||
                    this.ComparativePeriod != null &&
                    this.ComparativePeriod.SequenceEqual(other.ComparativePeriod)
                ) &&
                (
                    this.PrimaryPeriod == other.PrimaryPeriod ||
                    this.PrimaryPeriod != null &&
                    this.PrimaryPeriod.SequenceEqual(other.PrimaryPeriod)
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
                if (this.ComparativePeriod != null)
                    hash = hash * 59 + this.ComparativePeriod.GetHashCode();

                if (this.PrimaryPeriod != null)
                    hash = hash * 59 + this.PrimaryPeriod.GetHashCode();

                return hash;
            }
        }
    }

}
