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
    /// CustomAttributes
    /// </summary>
    [DataContract]
    public partial class CustomAttributes :  IEquatable<CustomAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAttributes" /> class.
        /// </summary>
        /// <param name="Id">The id of the Custom Attributes record..</param>
        /// <param name="Name">Name.</param>
        /// <param name="ConversationId">The id of the conversation..</param>
        /// <param name="Divisions">The list of division ids that the record is visible in. If [], the record is visible to all divisions (Unassigned Division)..</param>
        /// <param name="Schema">The schema that dictates which attributes can be included..</param>
        /// <param name="_CustomAttributes">The map of attribute values..</param>
        /// <param name="Version">The latest version of the Custom Attributes record..</param>
        /// <param name="DateCreated">The date the record was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The date the record was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public CustomAttributes(string Id = null, string Name = null, string ConversationId = null, List<string> Divisions = null, ConversationDataSchema Schema = null, Dictionary<string, Object> _CustomAttributes = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateModified = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.ConversationId = ConversationId;
            this.Divisions = Divisions;
            this.Schema = Schema;
            this._CustomAttributes = _CustomAttributes;
            this.Version = Version;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            
        }
        


        /// <summary>
        /// The id of the Custom Attributes record.
        /// </summary>
        /// <value>The id of the Custom Attributes record.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The id of the conversation.
        /// </summary>
        /// <value>The id of the conversation.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// The list of division ids that the record is visible in. If [], the record is visible to all divisions (Unassigned Division).
        /// </summary>
        /// <value>The list of division ids that the record is visible in. If [], the record is visible to all divisions (Unassigned Division).</value>
        [DataMember(Name="divisions", EmitDefaultValue=false)]
        public List<string> Divisions { get; set; }



        /// <summary>
        /// The schema that dictates which attributes can be included.
        /// </summary>
        /// <value>The schema that dictates which attributes can be included.</value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public ConversationDataSchema Schema { get; set; }



        /// <summary>
        /// The map of attribute values.
        /// </summary>
        /// <value>The map of attribute values.</value>
        [DataMember(Name="customAttributes", EmitDefaultValue=false)]
        public Dictionary<string, Object> _CustomAttributes { get; set; }



        /// <summary>
        /// The map of timestamps for when each attribute was last updated.
        /// </summary>
        /// <value>The map of timestamps for when each attribute was last updated.</value>
        [DataMember(Name="customAttributesTimestamps", EmitDefaultValue=false)]
        public Dictionary<string, string> CustomAttributesTimestamps { get; private set; }



        /// <summary>
        /// The latest version of the Custom Attributes record.
        /// </summary>
        /// <value>The latest version of the Custom Attributes record.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// The date the record was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the record was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The date the record was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the record was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



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
            sb.Append("class CustomAttributes {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  Divisions: ").Append(Divisions).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  _CustomAttributes: ").Append(_CustomAttributes).Append("\n");
            sb.Append("  CustomAttributesTimestamps: ").Append(CustomAttributesTimestamps).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as CustomAttributes);
        }

        /// <summary>
        /// Returns true if CustomAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomAttributes other)
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
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.Divisions == other.Divisions ||
                    this.Divisions != null &&
                    this.Divisions.SequenceEqual(other.Divisions)
                ) &&
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
                ) &&
                (
                    this._CustomAttributes == other._CustomAttributes ||
                    this._CustomAttributes != null &&
                    this._CustomAttributes.SequenceEqual(other._CustomAttributes)
                ) &&
                (
                    this.CustomAttributesTimestamps == other.CustomAttributesTimestamps ||
                    this.CustomAttributesTimestamps != null &&
                    this.CustomAttributesTimestamps.SequenceEqual(other.CustomAttributesTimestamps)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.Divisions != null)
                    hash = hash * 59 + this.Divisions.GetHashCode();

                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();

                if (this._CustomAttributes != null)
                    hash = hash * 59 + this._CustomAttributes.GetHashCode();

                if (this.CustomAttributesTimestamps != null)
                    hash = hash * 59 + this.CustomAttributesTimestamps.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
