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
    /// Defines a SCIM enterprise user.
    /// </summary>
    [DataContract]
    public partial class ScimV2EnterpriseUser :  IEquatable<ScimV2EnterpriseUser>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimV2EnterpriseUser" /> class.
        /// </summary>
        /// <param name="Division">The division that the user belongs to..</param>
        /// <param name="Department">The department that the user belongs to..</param>
        /// <param name="Manager">The user&#39;s manager..</param>
        /// <param name="EmployeeNumber">The user&#39;s employee number..</param>
        public ScimV2EnterpriseUser(string Division = null, string Department = null, Manager Manager = null, string EmployeeNumber = null)
        {
            this.Division = Division;
            this.Department = Department;
            this.Manager = Manager;
            this.EmployeeNumber = EmployeeNumber;
            
        }
        
        
        
        /// <summary>
        /// The division that the user belongs to.
        /// </summary>
        /// <value>The division that the user belongs to.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public string Division { get; set; }
        
        
        
        /// <summary>
        /// The department that the user belongs to.
        /// </summary>
        /// <value>The department that the user belongs to.</value>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
        
        
        
        /// <summary>
        /// The user&#39;s manager.
        /// </summary>
        /// <value>The user&#39;s manager.</value>
        [DataMember(Name="manager", EmitDefaultValue=false)]
        public Manager Manager { get; set; }
        
        
        
        /// <summary>
        /// The user&#39;s employee number.
        /// </summary>
        /// <value>The user&#39;s employee number.</value>
        [DataMember(Name="employeeNumber", EmitDefaultValue=false)]
        public string EmployeeNumber { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimV2EnterpriseUser {\n");
            
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  EmployeeNumber: ").Append(EmployeeNumber).Append("\n");
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
            return this.Equals(obj as ScimV2EnterpriseUser);
        }

        /// <summary>
        /// Returns true if ScimV2EnterpriseUser instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimV2EnterpriseUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimV2EnterpriseUser other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) &&
                (
                    this.Manager == other.Manager ||
                    this.Manager != null &&
                    this.Manager.Equals(other.Manager)
                ) &&
                (
                    this.EmployeeNumber == other.EmployeeNumber ||
                    this.EmployeeNumber != null &&
                    this.EmployeeNumber.Equals(other.EmployeeNumber)
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
                
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                
                if (this.Manager != null)
                    hash = hash * 59 + this.Manager.GetHashCode();
                
                if (this.EmployeeNumber != null)
                    hash = hash * 59 + this.EmployeeNumber.GetHashCode();
                
                return hash;
            }
        }
    }

}
