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
    /// CursorExternalSourceListing
    /// </summary>
    [DataContract]
    public partial class CursorExternalSourceListing :  IEquatable<CursorExternalSourceListing>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CursorExternalSourceListing" /> class.
        /// </summary>
        /// <param name="Entities">Entities.</param>
        /// <param name="NextUri">NextUri.</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="PreviousUri">PreviousUri.</param>
        /// <param name="Cursors">The cursor that points to the next set of entities being returned..</param>
        public CursorExternalSourceListing(List<ExternalSource> Entities = null, string NextUri = null, string SelfUri = null, string PreviousUri = null, Cursors Cursors = null)
        {
            this.Entities = Entities;
            this.NextUri = NextUri;
            this.SelfUri = SelfUri;
            this.PreviousUri = PreviousUri;
            this.Cursors = Cursors;
            
        }
        


        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<ExternalSource> Entities { get; set; }



        /// <summary>
        /// Gets or Sets NextUri
        /// </summary>
        [DataMember(Name="nextUri", EmitDefaultValue=false)]
        public string NextUri { get; set; }



        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }



        /// <summary>
        /// Gets or Sets PreviousUri
        /// </summary>
        [DataMember(Name="previousUri", EmitDefaultValue=false)]
        public string PreviousUri { get; set; }



        /// <summary>
        /// The cursor that points to the next set of entities being returned.
        /// </summary>
        /// <value>The cursor that points to the next set of entities being returned.</value>
        [DataMember(Name="cursors", EmitDefaultValue=false)]
        public Cursors Cursors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CursorExternalSourceListing {\n");

            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
            sb.Append("  Cursors: ").Append(Cursors).Append("\n");
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
            return this.Equals(obj as CursorExternalSourceListing);
        }

        /// <summary>
        /// Returns true if CursorExternalSourceListing instances are equal
        /// </summary>
        /// <param name="other">Instance of CursorExternalSourceListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CursorExternalSourceListing other)
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
                    this.NextUri == other.NextUri ||
                    this.NextUri != null &&
                    this.NextUri.Equals(other.NextUri)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.PreviousUri == other.PreviousUri ||
                    this.PreviousUri != null &&
                    this.PreviousUri.Equals(other.PreviousUri)
                ) &&
                (
                    this.Cursors == other.Cursors ||
                    this.Cursors != null &&
                    this.Cursors.Equals(other.Cursors)
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

                if (this.NextUri != null)
                    hash = hash * 59 + this.NextUri.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.PreviousUri != null)
                    hash = hash * 59 + this.PreviousUri.GetHashCode();

                if (this.Cursors != null)
                    hash = hash * 59 + this.Cursors.GetHashCode();

                return hash;
            }
        }
    }

}
