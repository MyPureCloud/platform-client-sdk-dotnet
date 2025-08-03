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
    /// NluDomain
    /// </summary>
    [DataContract]
    public partial class NluDomain :  IEquatable<NluDomain>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NluDomain" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NluDomain() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NluDomain" /> class.
        /// </summary>
        /// <param name="Name">The name of the NLU domain. (required).</param>
        /// <param name="Language">The language culture of the NLU domain, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;..</param>
        /// <param name="EngineVersion">The version of the NLU engine to use..</param>
        public NluDomain(string Name = null, string Language = null, string EngineVersion = null)
        {
            this.Name = Name;
            this.Language = Language;
            this.EngineVersion = EngineVersion;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the NLU domain.
        /// </summary>
        /// <value>The name of the NLU domain.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The language culture of the NLU domain, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;.
        /// </summary>
        /// <value>The language culture of the NLU domain, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// The draft version of that NLU domain.
        /// </summary>
        /// <value>The draft version of that NLU domain.</value>
        [DataMember(Name="draftVersion", EmitDefaultValue=false)]
        public NluDomainVersionReference DraftVersion { get; private set; }



        /// <summary>
        /// The last published version of that NLU domain.
        /// </summary>
        /// <value>The last published version of that NLU domain.</value>
        [DataMember(Name="lastPublishedVersion", EmitDefaultValue=false)]
        public NluDomainVersionReference LastPublishedVersion { get; private set; }



        /// <summary>
        /// The date when the NLU domain was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date when the NLU domain was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The date when the NLU domain was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date when the NLU domain was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The version of the NLU engine to use.
        /// </summary>
        /// <value>The version of the NLU engine to use.</value>
        [DataMember(Name="engineVersion", EmitDefaultValue=false)]
        public string EngineVersion { get; set; }



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
            sb.Append("class NluDomain {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  DraftVersion: ").Append(DraftVersion).Append("\n");
            sb.Append("  LastPublishedVersion: ").Append(LastPublishedVersion).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  EngineVersion: ").Append(EngineVersion).Append("\n");
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
            return this.Equals(obj as NluDomain);
        }

        /// <summary>
        /// Returns true if NluDomain instances are equal
        /// </summary>
        /// <param name="other">Instance of NluDomain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NluDomain other)
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
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.DraftVersion == other.DraftVersion ||
                    this.DraftVersion != null &&
                    this.DraftVersion.Equals(other.DraftVersion)
                ) &&
                (
                    this.LastPublishedVersion == other.LastPublishedVersion ||
                    this.LastPublishedVersion != null &&
                    this.LastPublishedVersion.Equals(other.LastPublishedVersion)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.EngineVersion == other.EngineVersion ||
                    this.EngineVersion != null &&
                    this.EngineVersion.Equals(other.EngineVersion)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.DraftVersion != null)
                    hash = hash * 59 + this.DraftVersion.GetHashCode();

                if (this.LastPublishedVersion != null)
                    hash = hash * 59 + this.LastPublishedVersion.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.EngineVersion != null)
                    hash = hash * 59 + this.EngineVersion.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
