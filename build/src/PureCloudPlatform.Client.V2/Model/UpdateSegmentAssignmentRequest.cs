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
    /// UpdateSegmentAssignmentRequest
    /// </summary>
    [DataContract]
    public partial class UpdateSegmentAssignmentRequest :  IEquatable<UpdateSegmentAssignmentRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSegmentAssignmentRequest" /> class.
        /// </summary>
        /// <param name="Assign">The segment assignments to apply..</param>
        /// <param name="Unassign">The segment unassignments to apply..</param>
        public UpdateSegmentAssignmentRequest(SegmentAssignments Assign = null, SegmentUnassignments Unassign = null)
        {
            this.Assign = Assign;
            this.Unassign = Unassign;
            
        }
        


        /// <summary>
        /// The segment assignments to apply.
        /// </summary>
        /// <value>The segment assignments to apply.</value>
        [DataMember(Name="assign", EmitDefaultValue=false)]
        public SegmentAssignments Assign { get; set; }



        /// <summary>
        /// The segment unassignments to apply.
        /// </summary>
        /// <value>The segment unassignments to apply.</value>
        [DataMember(Name="unassign", EmitDefaultValue=false)]
        public SegmentUnassignments Unassign { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSegmentAssignmentRequest {\n");

            sb.Append("  Assign: ").Append(Assign).Append("\n");
            sb.Append("  Unassign: ").Append(Unassign).Append("\n");
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
            return this.Equals(obj as UpdateSegmentAssignmentRequest);
        }

        /// <summary>
        /// Returns true if UpdateSegmentAssignmentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateSegmentAssignmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSegmentAssignmentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Assign == other.Assign ||
                    this.Assign != null &&
                    this.Assign.Equals(other.Assign)
                ) &&
                (
                    this.Unassign == other.Unassign ||
                    this.Unassign != null &&
                    this.Unassign.Equals(other.Unassign)
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
                if (this.Assign != null)
                    hash = hash * 59 + this.Assign.GetHashCode();

                if (this.Unassign != null)
                    hash = hash * 59 + this.Unassign.GetHashCode();

                return hash;
            }
        }
    }

}
