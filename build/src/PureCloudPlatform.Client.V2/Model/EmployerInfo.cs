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
    /// EmployerInfo
    /// </summary>
    [DataContract]
    public partial class EmployerInfo :  IEquatable<EmployerInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployerInfo" /> class.
        /// </summary>
        /// <param name="OfficialName">OfficialName.</param>
        /// <param name="EmployeeId">EmployeeId.</param>
        /// <param name="EmployeeType">EmployeeType.</param>
        /// <param name="DateHire">DateHire.</param>
        public EmployerInfo(string OfficialName = null, string EmployeeId = null, string EmployeeType = null, string DateHire = null)
        {
            this.OfficialName = OfficialName;
            this.EmployeeId = EmployeeId;
            this.EmployeeType = EmployeeType;
            this.DateHire = DateHire;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets OfficialName
        /// </summary>
        [DataMember(Name="officialName", EmitDefaultValue=false)]
        public string OfficialName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EmployeeId
        /// </summary>
        [DataMember(Name="employeeId", EmitDefaultValue=false)]
        public string EmployeeId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EmployeeType
        /// </summary>
        [DataMember(Name="employeeType", EmitDefaultValue=false)]
        public string EmployeeType { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateHire
        /// </summary>
        [DataMember(Name="dateHire", EmitDefaultValue=false)]
        public string DateHire { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployerInfo {\n");
            
            sb.Append("  OfficialName: ").Append(OfficialName).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EmployeeType: ").Append(EmployeeType).Append("\n");
            sb.Append("  DateHire: ").Append(DateHire).Append("\n");
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
            return this.Equals(obj as EmployerInfo);
        }

        /// <summary>
        /// Returns true if EmployerInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of EmployerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployerInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OfficialName == other.OfficialName ||
                    this.OfficialName != null &&
                    this.OfficialName.Equals(other.OfficialName)
                ) &&
                (
                    this.EmployeeId == other.EmployeeId ||
                    this.EmployeeId != null &&
                    this.EmployeeId.Equals(other.EmployeeId)
                ) &&
                (
                    this.EmployeeType == other.EmployeeType ||
                    this.EmployeeType != null &&
                    this.EmployeeType.Equals(other.EmployeeType)
                ) &&
                (
                    this.DateHire == other.DateHire ||
                    this.DateHire != null &&
                    this.DateHire.Equals(other.DateHire)
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
                
                if (this.OfficialName != null)
                    hash = hash * 59 + this.OfficialName.GetHashCode();
                
                if (this.EmployeeId != null)
                    hash = hash * 59 + this.EmployeeId.GetHashCode();
                
                if (this.EmployeeType != null)
                    hash = hash * 59 + this.EmployeeType.GetHashCode();
                
                if (this.DateHire != null)
                    hash = hash * 59 + this.DateHire.GetHashCode();
                
                return hash;
            }
        }
    }

}
