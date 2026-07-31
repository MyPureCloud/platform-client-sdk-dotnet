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
    /// RelyingPartyEntity
    /// </summary>
    [DataContract]
    public partial class RelyingPartyEntity :  IEquatable<RelyingPartyEntity>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RelyingPartyEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RelyingPartyEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelyingPartyEntity" /> class.
        /// </summary>
        /// <param name="Id">The relying party identifier (typically the registrable domain). (required).</param>
        /// <param name="Name">The human-readable name of the relying party. (required).</param>
        public RelyingPartyEntity(string Id = null, string Name = null)
        {
            this.Id = Id;
            this.Name = Name;
            
        }
        


        /// <summary>
        /// The relying party identifier (typically the registrable domain).
        /// </summary>
        /// <value>The relying party identifier (typically the registrable domain).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The human-readable name of the relying party.
        /// </summary>
        /// <value>The human-readable name of the relying party.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelyingPartyEntity {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as RelyingPartyEntity);
        }

        /// <summary>
        /// Returns true if RelyingPartyEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of RelyingPartyEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelyingPartyEntity other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                return hash;
            }
        }
    }

}
