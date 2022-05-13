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
    /// ShrinkageOverride
    /// </summary>
    [DataContract]
    public partial class ShrinkageOverride :  IEquatable<ShrinkageOverride>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ShrinkageOverride" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShrinkageOverride() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShrinkageOverride" /> class.
        /// </summary>
        /// <param name="IntervalIndex">Index of shrinkage override interval. Starting index is 0 and indexes are based on 15 minute intervals for a 7 day week (required).</param>
        /// <param name="ShrinkagePercent">Shrinkage override percent. Setting a null value will reset the interval to the default.</param>
        public ShrinkageOverride(int? IntervalIndex = null, double? ShrinkagePercent = null)
        {
            this.IntervalIndex = IntervalIndex;
            this.ShrinkagePercent = ShrinkagePercent;
            
        }
        


        /// <summary>
        /// Index of shrinkage override interval. Starting index is 0 and indexes are based on 15 minute intervals for a 7 day week
        /// </summary>
        /// <value>Index of shrinkage override interval. Starting index is 0 and indexes are based on 15 minute intervals for a 7 day week</value>
        [DataMember(Name="intervalIndex", EmitDefaultValue=false)]
        public int? IntervalIndex { get; set; }



        /// <summary>
        /// Shrinkage override percent. Setting a null value will reset the interval to the default
        /// </summary>
        /// <value>Shrinkage override percent. Setting a null value will reset the interval to the default</value>
        [DataMember(Name="shrinkagePercent", EmitDefaultValue=false)]
        public double? ShrinkagePercent { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShrinkageOverride {\n");

            sb.Append("  IntervalIndex: ").Append(IntervalIndex).Append("\n");
            sb.Append("  ShrinkagePercent: ").Append(ShrinkagePercent).Append("\n");
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
            return this.Equals(obj as ShrinkageOverride);
        }

        /// <summary>
        /// Returns true if ShrinkageOverride instances are equal
        /// </summary>
        /// <param name="other">Instance of ShrinkageOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShrinkageOverride other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IntervalIndex == other.IntervalIndex ||
                    this.IntervalIndex != null &&
                    this.IntervalIndex.Equals(other.IntervalIndex)
                ) &&
                (
                    this.ShrinkagePercent == other.ShrinkagePercent ||
                    this.ShrinkagePercent != null &&
                    this.ShrinkagePercent.Equals(other.ShrinkagePercent)
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
                if (this.IntervalIndex != null)
                    hash = hash * 59 + this.IntervalIndex.GetHashCode();

                if (this.ShrinkagePercent != null)
                    hash = hash * 59 + this.ShrinkagePercent.GetHashCode();

                return hash;
            }
        }
    }

}
