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
    /// OutlierResultBody
    /// </summary>
    [DataContract]
    public partial class OutlierResultBody :  IEquatable<OutlierResultBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutlierResultBody" /> class.
        /// </summary>
        /// <param name="PlanningGroupId">The ID of the planning group for which outliers are present.</param>
        /// <param name="Outliers">Outliers detected in the forecast data.</param>
        public OutlierResultBody(string PlanningGroupId = null, List<Outlier> Outliers = null)
        {
            this.PlanningGroupId = PlanningGroupId;
            this.Outliers = Outliers;
            
        }
        


        /// <summary>
        /// The ID of the planning group for which outliers are present
        /// </summary>
        /// <value>The ID of the planning group for which outliers are present</value>
        [DataMember(Name="planningGroupId", EmitDefaultValue=false)]
        public string PlanningGroupId { get; set; }



        /// <summary>
        /// Outliers detected in the forecast data
        /// </summary>
        /// <value>Outliers detected in the forecast data</value>
        [DataMember(Name="outliers", EmitDefaultValue=false)]
        public List<Outlier> Outliers { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutlierResultBody {\n");

            sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
            sb.Append("  Outliers: ").Append(Outliers).Append("\n");
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
            return this.Equals(obj as OutlierResultBody);
        }

        /// <summary>
        /// Returns true if OutlierResultBody instances are equal
        /// </summary>
        /// <param name="other">Instance of OutlierResultBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutlierResultBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PlanningGroupId == other.PlanningGroupId ||
                    this.PlanningGroupId != null &&
                    this.PlanningGroupId.Equals(other.PlanningGroupId)
                ) &&
                (
                    this.Outliers == other.Outliers ||
                    this.Outliers != null &&
                    this.Outliers.SequenceEqual(other.Outliers)
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
                if (this.PlanningGroupId != null)
                    hash = hash * 59 + this.PlanningGroupId.GetHashCode();

                if (this.Outliers != null)
                    hash = hash * 59 + this.Outliers.GetHashCode();

                return hash;
            }
        }
    }

}
