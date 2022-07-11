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
    /// AgentManagementUnitReference
    /// </summary>
    [DataContract]
    public partial class AgentManagementUnitReference :  IEquatable<AgentManagementUnitReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentManagementUnitReference" /> class.
        /// </summary>
        /// <param name="User">The user (agent) for whom the management unit was requested.</param>
        /// <param name="ManagementUnit">The management to which the user (agent) belongs.</param>
        /// <param name="BusinessUnit">The business unit to which the user (agent) belongs. Populate with expand=businessUnit.</param>
        public AgentManagementUnitReference(UserReference User = null, ManagementUnitReference ManagementUnit = null, BusinessUnitReference BusinessUnit = null)
        {
            this.User = User;
            this.ManagementUnit = ManagementUnit;
            this.BusinessUnit = BusinessUnit;
            
        }
        


        /// <summary>
        /// The user (agent) for whom the management unit was requested
        /// </summary>
        /// <value>The user (agent) for whom the management unit was requested</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// The management to which the user (agent) belongs
        /// </summary>
        /// <value>The management to which the user (agent) belongs</value>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public ManagementUnitReference ManagementUnit { get; set; }



        /// <summary>
        /// The business unit to which the user (agent) belongs. Populate with expand=businessUnit
        /// </summary>
        /// <value>The business unit to which the user (agent) belongs. Populate with expand=businessUnit</value>
        [DataMember(Name="businessUnit", EmitDefaultValue=false)]
        public BusinessUnitReference BusinessUnit { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentManagementUnitReference {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
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
            return this.Equals(obj as AgentManagementUnitReference);
        }

        /// <summary>
        /// Returns true if AgentManagementUnitReference instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentManagementUnitReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentManagementUnitReference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.ManagementUnit == other.ManagementUnit ||
                    this.ManagementUnit != null &&
                    this.ManagementUnit.Equals(other.ManagementUnit)
                ) &&
                (
                    this.BusinessUnit == other.BusinessUnit ||
                    this.BusinessUnit != null &&
                    this.BusinessUnit.Equals(other.BusinessUnit)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.ManagementUnit != null)
                    hash = hash * 59 + this.ManagementUnit.GetHashCode();

                if (this.BusinessUnit != null)
                    hash = hash * 59 + this.BusinessUnit.GetHashCode();

                return hash;
            }
        }
    }

}
