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
    /// ActivityPlanAbandonRateImpactOverride
    /// </summary>
    [DataContract]
    public partial class ActivityPlanAbandonRateImpactOverride :  IEquatable<ActivityPlanAbandonRateImpactOverride>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanAbandonRateImpactOverride" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanAbandonRateImpactOverride() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanAbandonRateImpactOverride" /> class.
        /// </summary>
        /// <param name="IncreaseByPercent">Allowed abandon rate increase percent, from 0.0 to 100.0 (required).</param>
        public ActivityPlanAbandonRateImpactOverride(double? IncreaseByPercent = null)
        {
            this.IncreaseByPercent = IncreaseByPercent;
            
        }
        


        /// <summary>
        /// Allowed abandon rate increase percent, from 0.0 to 100.0
        /// </summary>
        /// <value>Allowed abandon rate increase percent, from 0.0 to 100.0</value>
        [DataMember(Name="increaseByPercent", EmitDefaultValue=false)]
        public double? IncreaseByPercent { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityPlanAbandonRateImpactOverride {\n");

            sb.Append("  IncreaseByPercent: ").Append(IncreaseByPercent).Append("\n");
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
            return this.Equals(obj as ActivityPlanAbandonRateImpactOverride);
        }

        /// <summary>
        /// Returns true if ActivityPlanAbandonRateImpactOverride instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanAbandonRateImpactOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanAbandonRateImpactOverride other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IncreaseByPercent == other.IncreaseByPercent ||
                    this.IncreaseByPercent != null &&
                    this.IncreaseByPercent.Equals(other.IncreaseByPercent)
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
                if (this.IncreaseByPercent != null)
                    hash = hash * 59 + this.IncreaseByPercent.GetHashCode();

                return hash;
            }
        }
    }

}
