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
    /// CreateDecisionTableSnapshotRequest
    /// </summary>
    [DataContract]
    public partial class CreateDecisionTableSnapshotRequest :  IEquatable<CreateDecisionTableSnapshotRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionTableSnapshotRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDecisionTableSnapshotRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionTableSnapshotRequest" /> class.
        /// </summary>
        /// <param name="SnapshotName">Display name for the snapshot (required).</param>
        /// <param name="Notes">Optional notes for the snapshot.</param>
        public CreateDecisionTableSnapshotRequest(string SnapshotName = null, string Notes = null)
        {
            this.SnapshotName = SnapshotName;
            this.Notes = Notes;
            
        }
        


        /// <summary>
        /// Display name for the snapshot
        /// </summary>
        /// <value>Display name for the snapshot</value>
        [DataMember(Name="snapshotName", EmitDefaultValue=false)]
        public string SnapshotName { get; set; }



        /// <summary>
        /// Optional notes for the snapshot
        /// </summary>
        /// <value>Optional notes for the snapshot</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDecisionTableSnapshotRequest {\n");

            sb.Append("  SnapshotName: ").Append(SnapshotName).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(obj as CreateDecisionTableSnapshotRequest);
        }

        /// <summary>
        /// Returns true if CreateDecisionTableSnapshotRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateDecisionTableSnapshotRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDecisionTableSnapshotRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SnapshotName == other.SnapshotName ||
                    this.SnapshotName != null &&
                    this.SnapshotName.Equals(other.SnapshotName)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
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
                if (this.SnapshotName != null)
                    hash = hash * 59 + this.SnapshotName.GetHashCode();

                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();

                return hash;
            }
        }
    }

}
