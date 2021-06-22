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
    /// CreateBenefitAssessmentRequest
    /// </summary>
    [DataContract]
    public partial class CreateBenefitAssessmentRequest :  IEquatable<CreateBenefitAssessmentRequest>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBenefitAssessmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateBenefitAssessmentRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBenefitAssessmentRequest" /> class.
        /// </summary>
        /// <param name="QueueIds">The list of queue ids that are to be assessed for Predictive Routing benefit. (required).</param>
        public CreateBenefitAssessmentRequest(List<string> QueueIds = null)
        {
            this.QueueIds = QueueIds;
            
        }
        
        
        
        /// <summary>
        /// The list of queue ids that are to be assessed for Predictive Routing benefit.
        /// </summary>
        /// <value>The list of queue ids that are to be assessed for Predictive Routing benefit.</value>
        [DataMember(Name="queueIds", EmitDefaultValue=false)]
        public List<string> QueueIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBenefitAssessmentRequest {\n");
            
            sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
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
            return this.Equals(obj as CreateBenefitAssessmentRequest);
        }

        /// <summary>
        /// Returns true if CreateBenefitAssessmentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateBenefitAssessmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateBenefitAssessmentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueueIds == other.QueueIds ||
                    this.QueueIds != null &&
                    this.QueueIds.SequenceEqual(other.QueueIds)
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
                
                if (this.QueueIds != null)
                    hash = hash * 59 + this.QueueIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
