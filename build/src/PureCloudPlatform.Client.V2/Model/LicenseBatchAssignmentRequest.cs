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
    /// LicenseBatchAssignmentRequest
    /// </summary>
    [DataContract]
    public partial class LicenseBatchAssignmentRequest :  IEquatable<LicenseBatchAssignmentRequest>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseBatchAssignmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LicenseBatchAssignmentRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseBatchAssignmentRequest" /> class.
        /// </summary>
        /// <param name="Assignments">The list of license assignment updates to make. (required).</param>
        public LicenseBatchAssignmentRequest(List<LicenseAssignmentRequest> Assignments = null)
        {
            this.Assignments = Assignments;
            
        }
        
        
        
        /// <summary>
        /// The list of license assignment updates to make.
        /// </summary>
        /// <value>The list of license assignment updates to make.</value>
        [DataMember(Name="assignments", EmitDefaultValue=false)]
        public List<LicenseAssignmentRequest> Assignments { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicenseBatchAssignmentRequest {\n");
            
            sb.Append("  Assignments: ").Append(Assignments).Append("\n");
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
            return this.Equals(obj as LicenseBatchAssignmentRequest);
        }

        /// <summary>
        /// Returns true if LicenseBatchAssignmentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LicenseBatchAssignmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseBatchAssignmentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Assignments == other.Assignments ||
                    this.Assignments != null &&
                    this.Assignments.SequenceEqual(other.Assignments)
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
                
                if (this.Assignments != null)
                    hash = hash * 59 + this.Assignments.GetHashCode();
                
                return hash;
            }
        }
    }

}
