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
    /// UnavailableTimesManagementUnitSettings
    /// </summary>
    [DataContract]
    public partial class UnavailableTimesManagementUnitSettings :  IEquatable<UnavailableTimesManagementUnitSettings>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableTimesManagementUnitSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnavailableTimesManagementUnitSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableTimesManagementUnitSettings" /> class.
        /// </summary>
        /// <param name="ManagementUnit">The management unit to which these settings apply (required).</param>
        /// <param name="Enabled">Indicates whether agent availability is enabled for the management unit (required).</param>
        public UnavailableTimesManagementUnitSettings(ManagementUnitReference ManagementUnit = null, bool? Enabled = null)
        {
            this.ManagementUnit = ManagementUnit;
            this.Enabled = Enabled;
            
        }
        


        /// <summary>
        /// The management unit to which these settings apply
        /// </summary>
        /// <value>The management unit to which these settings apply</value>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public ManagementUnitReference ManagementUnit { get; set; }



        /// <summary>
        /// Indicates whether agent availability is enabled for the management unit
        /// </summary>
        /// <value>Indicates whether agent availability is enabled for the management unit</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnavailableTimesManagementUnitSettings {\n");

            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(obj as UnavailableTimesManagementUnitSettings);
        }

        /// <summary>
        /// Returns true if UnavailableTimesManagementUnitSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of UnavailableTimesManagementUnitSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnavailableTimesManagementUnitSettings other)
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
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
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

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                return hash;
            }
        }
    }

}
