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
    /// ContinuousForecastTimeSeries
    /// </summary>
    [DataContract]
    public partial class ContinuousForecastTimeSeries :  IEquatable<ContinuousForecastTimeSeries>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousForecastTimeSeries" /> class.
        /// </summary>
        /// <param name="PlanningGroup">The planning group ID.</param>
        /// <param name="Weeks">List of data for each week.</param>
        public ContinuousForecastTimeSeries(string PlanningGroup = null, List<ContinuousForecastWeeks> Weeks = null)
        {
            this.PlanningGroup = PlanningGroup;
            this.Weeks = Weeks;
            
        }
        


        /// <summary>
        /// The planning group ID
        /// </summary>
        /// <value>The planning group ID</value>
        [DataMember(Name="planningGroup", EmitDefaultValue=false)]
        public string PlanningGroup { get; set; }



        /// <summary>
        /// List of data for each week
        /// </summary>
        /// <value>List of data for each week</value>
        [DataMember(Name="weeks", EmitDefaultValue=false)]
        public List<ContinuousForecastWeeks> Weeks { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContinuousForecastTimeSeries {\n");

            sb.Append("  PlanningGroup: ").Append(PlanningGroup).Append("\n");
            sb.Append("  Weeks: ").Append(Weeks).Append("\n");
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
            return this.Equals(obj as ContinuousForecastTimeSeries);
        }

        /// <summary>
        /// Returns true if ContinuousForecastTimeSeries instances are equal
        /// </summary>
        /// <param name="other">Instance of ContinuousForecastTimeSeries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContinuousForecastTimeSeries other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PlanningGroup == other.PlanningGroup ||
                    this.PlanningGroup != null &&
                    this.PlanningGroup.Equals(other.PlanningGroup)
                ) &&
                (
                    this.Weeks == other.Weeks ||
                    this.Weeks != null &&
                    this.Weeks.SequenceEqual(other.Weeks)
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
                if (this.PlanningGroup != null)
                    hash = hash * 59 + this.PlanningGroup.GetHashCode();

                if (this.Weeks != null)
                    hash = hash * 59 + this.Weeks.GetHashCode();

                return hash;
            }
        }
    }

}
