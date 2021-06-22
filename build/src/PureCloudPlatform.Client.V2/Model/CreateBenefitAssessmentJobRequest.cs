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
    /// CreateBenefitAssessmentJobRequest
    /// </summary>
    [DataContract]
    public partial class CreateBenefitAssessmentJobRequest :  IEquatable<CreateBenefitAssessmentJobRequest>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBenefitAssessmentJobRequest" /> class.
        /// </summary>
        /// <param name="DivisionIds">The list of division ids for routing queues that are to be assessed for Predictive Routing benefit..</param>
        public CreateBenefitAssessmentJobRequest(List<string> DivisionIds = null)
        {
            this.DivisionIds = DivisionIds;
            
        }
        
        
        
        /// <summary>
        /// The list of division ids for routing queues that are to be assessed for Predictive Routing benefit.
        /// </summary>
        /// <value>The list of division ids for routing queues that are to be assessed for Predictive Routing benefit.</value>
        [DataMember(Name="divisionIds", EmitDefaultValue=false)]
        public List<string> DivisionIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBenefitAssessmentJobRequest {\n");
            
            sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CreateBenefitAssessmentJobRequest);
        }

        /// <summary>
        /// Returns true if CreateBenefitAssessmentJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateBenefitAssessmentJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateBenefitAssessmentJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DivisionIds == other.DivisionIds ||
                    this.DivisionIds != null &&
                    this.DivisionIds.SequenceEqual(other.DivisionIds)
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
                
                if (this.DivisionIds != null)
                    hash = hash * 59 + this.DivisionIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
