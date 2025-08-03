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
    /// LongTermRequirements
    /// </summary>
    [DataContract]
    public partial class LongTermRequirements :  IEquatable<LongTermRequirements>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LongTermRequirements" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LongTermRequirements() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LongTermRequirements" /> class.
        /// </summary>
        /// <param name="ForecastMetadata">Forecast metadata (required).</param>
        /// <param name="DateGenerationStarted">Date the generation of the requirements started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="RequirementResults">List of planning group outputs (required).</param>
        public LongTermRequirements(ForecastMetadata ForecastMetadata = null, DateTime? DateGenerationStarted = null, List<PlanningGroupRequirementOutput> RequirementResults = null)
        {
            this.ForecastMetadata = ForecastMetadata;
            this.DateGenerationStarted = DateGenerationStarted;
            this.RequirementResults = RequirementResults;
            
        }
        


        /// <summary>
        /// Forecast metadata
        /// </summary>
        /// <value>Forecast metadata</value>
        [DataMember(Name="forecastMetadata", EmitDefaultValue=false)]
        public ForecastMetadata ForecastMetadata { get; set; }



        /// <summary>
        /// Date the generation of the requirements started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date the generation of the requirements started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateGenerationStarted", EmitDefaultValue=false)]
        public DateTime? DateGenerationStarted { get; set; }



        /// <summary>
        /// List of planning group outputs
        /// </summary>
        /// <value>List of planning group outputs</value>
        [DataMember(Name="requirementResults", EmitDefaultValue=false)]
        public List<PlanningGroupRequirementOutput> RequirementResults { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LongTermRequirements {\n");

            sb.Append("  ForecastMetadata: ").Append(ForecastMetadata).Append("\n");
            sb.Append("  DateGenerationStarted: ").Append(DateGenerationStarted).Append("\n");
            sb.Append("  RequirementResults: ").Append(RequirementResults).Append("\n");
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
            return this.Equals(obj as LongTermRequirements);
        }

        /// <summary>
        /// Returns true if LongTermRequirements instances are equal
        /// </summary>
        /// <param name="other">Instance of LongTermRequirements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LongTermRequirements other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ForecastMetadata == other.ForecastMetadata ||
                    this.ForecastMetadata != null &&
                    this.ForecastMetadata.Equals(other.ForecastMetadata)
                ) &&
                (
                    this.DateGenerationStarted == other.DateGenerationStarted ||
                    this.DateGenerationStarted != null &&
                    this.DateGenerationStarted.Equals(other.DateGenerationStarted)
                ) &&
                (
                    this.RequirementResults == other.RequirementResults ||
                    this.RequirementResults != null &&
                    this.RequirementResults.SequenceEqual(other.RequirementResults)
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
                if (this.ForecastMetadata != null)
                    hash = hash * 59 + this.ForecastMetadata.GetHashCode();

                if (this.DateGenerationStarted != null)
                    hash = hash * 59 + this.DateGenerationStarted.GetHashCode();

                if (this.RequirementResults != null)
                    hash = hash * 59 + this.RequirementResults.GetHashCode();

                return hash;
            }
        }
    }

}
