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
    /// QueryAvailabilityManagementUnitsSettingsRequest
    /// </summary>
    [DataContract]
    public partial class QueryAvailabilityManagementUnitsSettingsRequest :  IEquatable<QueryAvailabilityManagementUnitsSettingsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAvailabilityManagementUnitsSettingsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryAvailabilityManagementUnitsSettingsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAvailabilityManagementUnitsSettingsRequest" /> class.
        /// </summary>
        /// <param name="ManagementUnitIds">The IDs of the management units for which to fetch their configurations. The management units must be in the business unit specified in the request path (required).</param>
        public QueryAvailabilityManagementUnitsSettingsRequest(List<string> ManagementUnitIds = null)
        {
            this.ManagementUnitIds = ManagementUnitIds;
            
        }
        


        /// <summary>
        /// The IDs of the management units for which to fetch their configurations. The management units must be in the business unit specified in the request path
        /// </summary>
        /// <value>The IDs of the management units for which to fetch their configurations. The management units must be in the business unit specified in the request path</value>
        [DataMember(Name="managementUnitIds", EmitDefaultValue=false)]
        public List<string> ManagementUnitIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryAvailabilityManagementUnitsSettingsRequest {\n");

            sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
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
            return this.Equals(obj as QueryAvailabilityManagementUnitsSettingsRequest);
        }

        /// <summary>
        /// Returns true if QueryAvailabilityManagementUnitsSettingsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryAvailabilityManagementUnitsSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryAvailabilityManagementUnitsSettingsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManagementUnitIds == other.ManagementUnitIds ||
                    this.ManagementUnitIds != null &&
                    this.ManagementUnitIds.SequenceEqual(other.ManagementUnitIds)
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
                if (this.ManagementUnitIds != null)
                    hash = hash * 59 + this.ManagementUnitIds.GetHashCode();

                return hash;
            }
        }
    }

}
