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
    /// KnowledgeSettingsResponse
    /// </summary>
    [DataContract]
    public partial class KnowledgeSettingsResponse :  IEquatable<KnowledgeSettingsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSettingsResponse" /> class.
        /// </summary>
        /// <param name="Id">Knowledge Setting Id..</param>
        /// <param name="Name">Knowledge Setting Name..</param>
        /// <param name="Description">Knowledge setting description..</param>
        /// <param name="Sources">Knowledge source information searched upon..</param>
        /// <param name="GenerationSetting">Settings for answer generation..</param>
        /// <param name="Stateful">Indicates if stateful search and generation is enabled for the knowledge setting..</param>
        /// <param name="DateCreated">Knowledge setting created date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">Knowledge setting last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ModifiedBy">The user who modified the knowledge setting..</param>
        public KnowledgeSettingsResponse(string Id = null, string Name = null, string Description = null, List<V3SourceRef> Sources = null, KnowledgeGenerationSetting GenerationSetting = null, bool? Stateful = null, DateTime? DateCreated = null, DateTime? DateModified = null, UserReference ModifiedBy = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Sources = Sources;
            this.GenerationSetting = GenerationSetting;
            this.Stateful = Stateful;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            
        }
        


        /// <summary>
        /// Knowledge Setting Id.
        /// </summary>
        /// <value>Knowledge Setting Id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Knowledge Setting Name.
        /// </summary>
        /// <value>Knowledge Setting Name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Knowledge setting description.
        /// </summary>
        /// <value>Knowledge setting description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Knowledge source information searched upon.
        /// </summary>
        /// <value>Knowledge source information searched upon.</value>
        [DataMember(Name="sources", EmitDefaultValue=false)]
        public List<V3SourceRef> Sources { get; set; }



        /// <summary>
        /// Settings for answer generation.
        /// </summary>
        /// <value>Settings for answer generation.</value>
        [DataMember(Name="generationSetting", EmitDefaultValue=false)]
        public KnowledgeGenerationSetting GenerationSetting { get; set; }



        /// <summary>
        /// Indicates if stateful search and generation is enabled for the knowledge setting.
        /// </summary>
        /// <value>Indicates if stateful search and generation is enabled for the knowledge setting.</value>
        [DataMember(Name="stateful", EmitDefaultValue=false)]
        public bool? Stateful { get; set; }



        /// <summary>
        /// Knowledge setting created date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Knowledge setting created date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Knowledge setting last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Knowledge setting last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// The user who modified the knowledge setting.
        /// </summary>
        /// <value>The user who modified the knowledge setting.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public UserReference ModifiedBy { get; set; }



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
            sb.Append("class KnowledgeSettingsResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  GenerationSetting: ").Append(GenerationSetting).Append("\n");
            sb.Append("  Stateful: ").Append(Stateful).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
            return this.Equals(obj as KnowledgeSettingsResponse);
        }

        /// <summary>
        /// Returns true if KnowledgeSettingsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSettingsResponse other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Sources == other.Sources ||
                    this.Sources != null &&
                    this.Sources.SequenceEqual(other.Sources)
                ) &&
                (
                    this.GenerationSetting == other.GenerationSetting ||
                    this.GenerationSetting != null &&
                    this.GenerationSetting.Equals(other.GenerationSetting)
                ) &&
                (
                    this.Stateful == other.Stateful ||
                    this.Stateful != null &&
                    this.Stateful.Equals(other.Stateful)
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
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Sources != null)
                    hash = hash * 59 + this.Sources.GetHashCode();

                if (this.GenerationSetting != null)
                    hash = hash * 59 + this.GenerationSetting.GetHashCode();

                if (this.Stateful != null)
                    hash = hash * 59 + this.Stateful.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
