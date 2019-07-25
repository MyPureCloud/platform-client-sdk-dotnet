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
    /// MoveManagementUnitRequest
    /// </summary>
    [DataContract]
    public partial class MoveManagementUnitRequest :  IEquatable<MoveManagementUnitRequest>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveManagementUnitRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MoveManagementUnitRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveManagementUnitRequest" /> class.
        /// </summary>
        /// <param name="BusinessUnitId">The ID of the business unit to which to move the management unit (required).</param>
        public MoveManagementUnitRequest(string BusinessUnitId = null)
        {
            this.BusinessUnitId = BusinessUnitId;
            
        }
        
        
        
        /// <summary>
        /// The ID of the business unit to which to move the management unit
        /// </summary>
        /// <value>The ID of the business unit to which to move the management unit</value>
        [DataMember(Name="businessUnitId", EmitDefaultValue=false)]
        public string BusinessUnitId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoveManagementUnitRequest {\n");
            
            sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
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
            return this.Equals(obj as MoveManagementUnitRequest);
        }

        /// <summary>
        /// Returns true if MoveManagementUnitRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MoveManagementUnitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoveManagementUnitRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.BusinessUnitId == other.BusinessUnitId ||
                    this.BusinessUnitId != null &&
                    this.BusinessUnitId.Equals(other.BusinessUnitId)
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
                
                if (this.BusinessUnitId != null)
                    hash = hash * 59 + this.BusinessUnitId.GetHashCode();
                
                return hash;
            }
        }
    }

}
