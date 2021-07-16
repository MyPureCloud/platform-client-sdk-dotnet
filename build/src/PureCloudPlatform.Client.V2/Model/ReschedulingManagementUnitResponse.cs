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
    /// ReschedulingManagementUnitResponse
    /// </summary>
    [DataContract]
    public partial class ReschedulingManagementUnitResponse :  IEquatable<ReschedulingManagementUnitResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReschedulingManagementUnitResponse" /> class.
        /// </summary>
        /// <param name="ManagementUnit">The management unit.</param>
        /// <param name="Applied">Whether the rescheduling run is applied for the given management unit.</param>
        public ReschedulingManagementUnitResponse(ManagementUnitReference ManagementUnit = null, bool? Applied = null)
        {
            this.ManagementUnit = ManagementUnit;
            this.Applied = Applied;
            
        }
        
        
        
        /// <summary>
        /// The management unit
        /// </summary>
        /// <value>The management unit</value>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public ManagementUnitReference ManagementUnit { get; set; }
        
        
        
        /// <summary>
        /// Whether the rescheduling run is applied for the given management unit
        /// </summary>
        /// <value>Whether the rescheduling run is applied for the given management unit</value>
        [DataMember(Name="applied", EmitDefaultValue=false)]
        public bool? Applied { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReschedulingManagementUnitResponse {\n");
            
            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  Applied: ").Append(Applied).Append("\n");
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
            return this.Equals(obj as ReschedulingManagementUnitResponse);
        }

        /// <summary>
        /// Returns true if ReschedulingManagementUnitResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ReschedulingManagementUnitResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReschedulingManagementUnitResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManagementUnit == other.ManagementUnit ||
                    this.ManagementUnit != null &&
                    this.ManagementUnit.Equals(other.ManagementUnit)
                ) &&
                (
                    this.Applied == other.Applied ||
                    this.Applied != null &&
                    this.Applied.Equals(other.Applied)
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
                
                if (this.ManagementUnit != null)
                    hash = hash * 59 + this.ManagementUnit.GetHashCode();
                
                if (this.Applied != null)
                    hash = hash * 59 + this.Applied.GetHashCode();
                
                return hash;
            }
        }
    }

}
