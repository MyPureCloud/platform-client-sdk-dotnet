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
    /// SourcePlanningGroupRequest
    /// </summary>
    [DataContract]
    public partial class SourcePlanningGroupRequest :  IEquatable<SourcePlanningGroupRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SourcePlanningGroupRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SourcePlanningGroupRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourcePlanningGroupRequest" /> class.
        /// </summary>
        /// <param name="Id">The ID of the planning group (required).</param>
        /// <param name="Metadata">Version metadata for the planning group (required).</param>
        public SourcePlanningGroupRequest(string Id = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Id = Id;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The ID of the planning group
        /// </summary>
        /// <value>The ID of the planning group</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Version metadata for the planning group
        /// </summary>
        /// <value>Version metadata for the planning group</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourcePlanningGroupRequest {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as SourcePlanningGroupRequest);
        }

        /// <summary>
        /// Returns true if SourcePlanningGroupRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SourcePlanningGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourcePlanningGroupRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
