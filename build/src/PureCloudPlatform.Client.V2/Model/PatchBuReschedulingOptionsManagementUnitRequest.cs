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
    /// PatchBuReschedulingOptionsManagementUnitRequest
    /// </summary>
    [DataContract]
    public partial class PatchBuReschedulingOptionsManagementUnitRequest :  IEquatable<PatchBuReschedulingOptionsManagementUnitRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchBuReschedulingOptionsManagementUnitRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PatchBuReschedulingOptionsManagementUnitRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchBuReschedulingOptionsManagementUnitRequest" /> class.
        /// </summary>
        /// <param name="ManagementUnitId">The management unit portion of the rescheduling run to update (required).</param>
        /// <param name="Applied">Whether to mark the run as applied.  Only applies to reschedule runs.  Once applied, a run cannot be un-marked as applied.</param>
        public PatchBuReschedulingOptionsManagementUnitRequest(string ManagementUnitId = null, bool? Applied = null)
        {
            this.ManagementUnitId = ManagementUnitId;
            this.Applied = Applied;
            
        }
        


        /// <summary>
        /// The management unit portion of the rescheduling run to update
        /// </summary>
        /// <value>The management unit portion of the rescheduling run to update</value>
        [DataMember(Name="managementUnitId", EmitDefaultValue=false)]
        public string ManagementUnitId { get; set; }



        /// <summary>
        /// Whether to mark the run as applied.  Only applies to reschedule runs.  Once applied, a run cannot be un-marked as applied
        /// </summary>
        /// <value>Whether to mark the run as applied.  Only applies to reschedule runs.  Once applied, a run cannot be un-marked as applied</value>
        [DataMember(Name="applied", EmitDefaultValue=false)]
        public bool? Applied { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchBuReschedulingOptionsManagementUnitRequest {\n");

            sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
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
            return this.Equals(obj as PatchBuReschedulingOptionsManagementUnitRequest);
        }

        /// <summary>
        /// Returns true if PatchBuReschedulingOptionsManagementUnitRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchBuReschedulingOptionsManagementUnitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchBuReschedulingOptionsManagementUnitRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManagementUnitId == other.ManagementUnitId ||
                    this.ManagementUnitId != null &&
                    this.ManagementUnitId.Equals(other.ManagementUnitId)
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
                if (this.ManagementUnitId != null)
                    hash = hash * 59 + this.ManagementUnitId.GetHashCode();

                if (this.Applied != null)
                    hash = hash * 59 + this.Applied.GetHashCode();

                return hash;
            }
        }
    }

}
