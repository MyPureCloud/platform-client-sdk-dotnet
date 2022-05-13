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
    /// WorkPlanPatternResponse
    /// </summary>
    [DataContract]
    public partial class WorkPlanPatternResponse :  IEquatable<WorkPlanPatternResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanPatternResponse" /> class.
        /// </summary>
        /// <param name="WorkPlans">List of work plans in order of rotation on a weekly basis.</param>
        public WorkPlanPatternResponse(List<WorkPlanReference> WorkPlans = null)
        {
            this.WorkPlans = WorkPlans;
            
        }
        


        /// <summary>
        /// List of work plans in order of rotation on a weekly basis
        /// </summary>
        /// <value>List of work plans in order of rotation on a weekly basis</value>
        [DataMember(Name="workPlans", EmitDefaultValue=false)]
        public List<WorkPlanReference> WorkPlans { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlanPatternResponse {\n");

            sb.Append("  WorkPlans: ").Append(WorkPlans).Append("\n");
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
            return this.Equals(obj as WorkPlanPatternResponse);
        }

        /// <summary>
        /// Returns true if WorkPlanPatternResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanPatternResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanPatternResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WorkPlans == other.WorkPlans ||
                    this.WorkPlans != null &&
                    this.WorkPlans.SequenceEqual(other.WorkPlans)
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
                if (this.WorkPlans != null)
                    hash = hash * 59 + this.WorkPlans.GetHashCode();

                return hash;
            }
        }
    }

}
