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
    /// AdminBulkUpdateAlternativeShiftTradeStateRequest
    /// </summary>
    [DataContract]
    public partial class AdminBulkUpdateAlternativeShiftTradeStateRequest :  IEquatable<AdminBulkUpdateAlternativeShiftTradeStateRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBulkUpdateAlternativeShiftTradeStateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdminBulkUpdateAlternativeShiftTradeStateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBulkUpdateAlternativeShiftTradeStateRequest" /> class.
        /// </summary>
        /// <param name="Entities">Entities.</param>
        /// <param name="ManagementUnitId">The ID of the management unit for this alternative shift bulk trade update (required).</param>
        public AdminBulkUpdateAlternativeShiftTradeStateRequest(List<AdminBulkUpdateAlternativeShiftTradeState> Entities = null, string ManagementUnitId = null)
        {
            this.Entities = Entities;
            this.ManagementUnitId = ManagementUnitId;
            
        }
        


        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<AdminBulkUpdateAlternativeShiftTradeState> Entities { get; set; }



        /// <summary>
        /// The ID of the management unit for this alternative shift bulk trade update
        /// </summary>
        /// <value>The ID of the management unit for this alternative shift bulk trade update</value>
        [DataMember(Name="managementUnitId", EmitDefaultValue=false)]
        public string ManagementUnitId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminBulkUpdateAlternativeShiftTradeStateRequest {\n");

            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
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
            return this.Equals(obj as AdminBulkUpdateAlternativeShiftTradeStateRequest);
        }

        /// <summary>
        /// Returns true if AdminBulkUpdateAlternativeShiftTradeStateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AdminBulkUpdateAlternativeShiftTradeStateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminBulkUpdateAlternativeShiftTradeStateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.ManagementUnitId == other.ManagementUnitId ||
                    this.ManagementUnitId != null &&
                    this.ManagementUnitId.Equals(other.ManagementUnitId)
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
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                if (this.ManagementUnitId != null)
                    hash = hash * 59 + this.ManagementUnitId.GetHashCode();

                return hash;
            }
        }
    }

}
