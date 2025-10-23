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
    /// MessagingIdentityResolutionConfig
    /// </summary>
    [DataContract]
    public partial class MessagingIdentityResolutionConfig :  IEquatable<MessagingIdentityResolutionConfig>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingIdentityResolutionConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagingIdentityResolutionConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingIdentityResolutionConfig" /> class.
        /// </summary>
        /// <param name="Division">The division to use when performing identity resolution..</param>
        /// <param name="ResolveIdentities">Whether the channel should resolve identities (required).</param>
        public MessagingIdentityResolutionConfig(WritableStarrableDivision Division = null, bool? ResolveIdentities = null)
        {
            this.Division = Division;
            this.ResolveIdentities = ResolveIdentities;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The division to use when performing identity resolution.
        /// </summary>
        /// <value>The division to use when performing identity resolution.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public WritableStarrableDivision Division { get; set; }



        /// <summary>
        /// Whether the channel should resolve identities
        /// </summary>
        /// <value>Whether the channel should resolve identities</value>
        [DataMember(Name="resolveIdentities", EmitDefaultValue=false)]
        public bool? ResolveIdentities { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingIdentityResolutionConfig {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  ResolveIdentities: ").Append(ResolveIdentities).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as MessagingIdentityResolutionConfig);
        }

        /// <summary>
        /// Returns true if MessagingIdentityResolutionConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingIdentityResolutionConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingIdentityResolutionConfig other)
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
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.ResolveIdentities == other.ResolveIdentities ||
                    this.ResolveIdentities != null &&
                    this.ResolveIdentities.Equals(other.ResolveIdentities)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.ResolveIdentities != null)
                    hash = hash * 59 + this.ResolveIdentities.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
