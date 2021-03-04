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
    /// ProgramJobRequest
    /// </summary>
    [DataContract]
    public partial class ProgramJobRequest :  IEquatable<ProgramJobRequest>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProgramJobRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramJobRequest" /> class.
        /// </summary>
        /// <param name="ProgramIds">The ids of the programs used for this job (required).</param>
        public ProgramJobRequest(List<string> ProgramIds = null)
        {
            this.ProgramIds = ProgramIds;
            
        }
        
        
        
        /// <summary>
        /// The ids of the programs used for this job
        /// </summary>
        /// <value>The ids of the programs used for this job</value>
        [DataMember(Name="programIds", EmitDefaultValue=false)]
        public List<string> ProgramIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramJobRequest {\n");
            
            sb.Append("  ProgramIds: ").Append(ProgramIds).Append("\n");
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
            return this.Equals(obj as ProgramJobRequest);
        }

        /// <summary>
        /// Returns true if ProgramJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgramJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ProgramIds == other.ProgramIds ||
                    this.ProgramIds != null &&
                    this.ProgramIds.SequenceEqual(other.ProgramIds)
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
                
                if (this.ProgramIds != null)
                    hash = hash * 59 + this.ProgramIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
