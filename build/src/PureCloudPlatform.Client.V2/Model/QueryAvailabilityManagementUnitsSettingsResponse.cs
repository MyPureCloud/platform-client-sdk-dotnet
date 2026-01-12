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
    /// QueryAvailabilityManagementUnitsSettingsResponse
    /// </summary>
    [DataContract]
    public partial class QueryAvailabilityManagementUnitsSettingsResponse :  IEquatable<QueryAvailabilityManagementUnitsSettingsResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAvailabilityManagementUnitsSettingsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryAvailabilityManagementUnitsSettingsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAvailabilityManagementUnitsSettingsResponse" /> class.
        /// </summary>
        /// <param name="ManagementUnits">List of unavailable times settings, per management unit (required).</param>
        public QueryAvailabilityManagementUnitsSettingsResponse(List<UnavailableTimesManagementUnitSettings> ManagementUnits = null)
        {
            this.ManagementUnits = ManagementUnits;
            
        }
        


        /// <summary>
        /// List of unavailable times settings, per management unit
        /// </summary>
        /// <value>List of unavailable times settings, per management unit</value>
        [DataMember(Name="managementUnits", EmitDefaultValue=false)]
        public List<UnavailableTimesManagementUnitSettings> ManagementUnits { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryAvailabilityManagementUnitsSettingsResponse {\n");

            sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
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
            return this.Equals(obj as QueryAvailabilityManagementUnitsSettingsResponse);
        }

        /// <summary>
        /// Returns true if QueryAvailabilityManagementUnitsSettingsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryAvailabilityManagementUnitsSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryAvailabilityManagementUnitsSettingsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManagementUnits == other.ManagementUnits ||
                    this.ManagementUnits != null &&
                    this.ManagementUnits.SequenceEqual(other.ManagementUnits)
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
                if (this.ManagementUnits != null)
                    hash = hash * 59 + this.ManagementUnits.GetHashCode();

                return hash;
            }
        }
    }

}
