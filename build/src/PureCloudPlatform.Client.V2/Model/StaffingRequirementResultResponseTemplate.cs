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
    /// StaffingRequirementResultResponseTemplate
    /// </summary>
    [DataContract]
    public partial class StaffingRequirementResultResponseTemplate :  IEquatable<StaffingRequirementResultResponseTemplate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="StaffingRequirementResultResponseTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StaffingRequirementResultResponseTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffingRequirementResultResponseTemplate" /> class.
        /// </summary>
        /// <param name="RequirementResults">List of staffing requirement results (required).</param>
        public StaffingRequirementResultResponseTemplate(List<PlanningGroupRequirementOutput> RequirementResults = null)
        {
            this.RequirementResults = RequirementResults;
            
        }
        


        /// <summary>
        /// List of staffing requirement results
        /// </summary>
        /// <value>List of staffing requirement results</value>
        [DataMember(Name="requirementResults", EmitDefaultValue=false)]
        public List<PlanningGroupRequirementOutput> RequirementResults { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffingRequirementResultResponseTemplate {\n");

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
            return this.Equals(obj as StaffingRequirementResultResponseTemplate);
        }

        /// <summary>
        /// Returns true if StaffingRequirementResultResponseTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of StaffingRequirementResultResponseTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffingRequirementResultResponseTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                if (this.RequirementResults != null)
                    hash = hash * 59 + this.RequirementResults.GetHashCode();

                return hash;
            }
        }
    }

}
