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
    /// BuForecastGenerationResult
    /// </summary>
    [DataContract]
    public partial class BuForecastGenerationResult :  IEquatable<BuForecastGenerationResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuForecastGenerationResult" /> class.
        /// </summary>
        /// <param name="PlanningGroupResults">Generation results, broken down by planning group.</param>
        public BuForecastGenerationResult(List<BuForecastGenerationPlanningGroupResult> PlanningGroupResults = null)
        {
            this.PlanningGroupResults = PlanningGroupResults;
            
        }
        


        /// <summary>
        /// Generation results, broken down by planning group
        /// </summary>
        /// <value>Generation results, broken down by planning group</value>
        [DataMember(Name="planningGroupResults", EmitDefaultValue=false)]
        public List<BuForecastGenerationPlanningGroupResult> PlanningGroupResults { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuForecastGenerationResult {\n");

            sb.Append("  PlanningGroupResults: ").Append(PlanningGroupResults).Append("\n");
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
            return this.Equals(obj as BuForecastGenerationResult);
        }

        /// <summary>
        /// Returns true if BuForecastGenerationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BuForecastGenerationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuForecastGenerationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PlanningGroupResults == other.PlanningGroupResults ||
                    this.PlanningGroupResults != null &&
                    this.PlanningGroupResults.SequenceEqual(other.PlanningGroupResults)
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
                if (this.PlanningGroupResults != null)
                    hash = hash * 59 + this.PlanningGroupResults.GetHashCode();

                return hash;
            }
        }
    }

}
