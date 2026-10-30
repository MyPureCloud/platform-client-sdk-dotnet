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
    /// V3SourceFileCountsResponse
    /// </summary>
    [DataContract]
    public partial class V3SourceFileCountsResponse :  IEquatable<V3SourceFileCountsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceFileCountsResponse" /> class.
        /// </summary>
        /// <param name="Entities">Per-source file counts..</param>
        public V3SourceFileCountsResponse(List<V3SourceFileCountEntry> Entities = null)
        {
            this.Entities = Entities;
            
        }
        


        /// <summary>
        /// Per-source file counts.
        /// </summary>
        /// <value>Per-source file counts.</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<V3SourceFileCountEntry> Entities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SourceFileCountsResponse {\n");

            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(obj as V3SourceFileCountsResponse);
        }

        /// <summary>
        /// Returns true if V3SourceFileCountsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SourceFileCountsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SourceFileCountsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
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

                return hash;
            }
        }
    }

}
