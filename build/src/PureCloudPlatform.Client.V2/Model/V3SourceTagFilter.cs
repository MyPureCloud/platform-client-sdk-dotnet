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
    /// V3SourceTagFilter
    /// </summary>
    [DataContract]
    public partial class V3SourceTagFilter :  IEquatable<V3SourceTagFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceTagFilter" /> class.
        /// </summary>
        /// <param name="AllOf">Tags that must all be present (AND)..</param>
        /// <param name="AnyOfGroups">OR groups ANDed together; within each group at least one tag must match..</param>
        /// <param name="NoneOf">Tags that must not be present on matching chunks..</param>
        public V3SourceTagFilter(List<string> AllOf = null, List<List<string>> AnyOfGroups = null, List<string> NoneOf = null)
        {
            this.AllOf = AllOf;
            this.AnyOfGroups = AnyOfGroups;
            this.NoneOf = NoneOf;
            
        }
        


        /// <summary>
        /// Tags that must all be present (AND).
        /// </summary>
        /// <value>Tags that must all be present (AND).</value>
        [DataMember(Name="allOf", EmitDefaultValue=false)]
        public List<string> AllOf { get; set; }



        /// <summary>
        /// OR groups ANDed together; within each group at least one tag must match.
        /// </summary>
        /// <value>OR groups ANDed together; within each group at least one tag must match.</value>
        [DataMember(Name="anyOfGroups", EmitDefaultValue=false)]
        public List<List<string>> AnyOfGroups { get; set; }



        /// <summary>
        /// Tags that must not be present on matching chunks.
        /// </summary>
        /// <value>Tags that must not be present on matching chunks.</value>
        [DataMember(Name="noneOf", EmitDefaultValue=false)]
        public List<string> NoneOf { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SourceTagFilter {\n");

            sb.Append("  AllOf: ").Append(AllOf).Append("\n");
            sb.Append("  AnyOfGroups: ").Append(AnyOfGroups).Append("\n");
            sb.Append("  NoneOf: ").Append(NoneOf).Append("\n");
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
            return this.Equals(obj as V3SourceTagFilter);
        }

        /// <summary>
        /// Returns true if V3SourceTagFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SourceTagFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SourceTagFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AllOf == other.AllOf ||
                    this.AllOf != null &&
                    this.AllOf.SequenceEqual(other.AllOf)
                ) &&
                (
                    this.AnyOfGroups == other.AnyOfGroups ||
                    this.AnyOfGroups != null &&
                    this.AnyOfGroups.SequenceEqual(other.AnyOfGroups)
                ) &&
                (
                    this.NoneOf == other.NoneOf ||
                    this.NoneOf != null &&
                    this.NoneOf.SequenceEqual(other.NoneOf)
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
                if (this.AllOf != null)
                    hash = hash * 59 + this.AllOf.GetHashCode();

                if (this.AnyOfGroups != null)
                    hash = hash * 59 + this.AnyOfGroups.GetHashCode();

                if (this.NoneOf != null)
                    hash = hash * 59 + this.NoneOf.GetHashCode();

                return hash;
            }
        }
    }

}
