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
    /// CustomAttributesPatchRequest
    /// </summary>
    [DataContract]
    public partial class CustomAttributesPatchRequest :  IEquatable<CustomAttributesPatchRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAttributesPatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomAttributesPatchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAttributesPatchRequest" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the Custom Attributes record. IDs are created by users. (required).</param>
        /// <param name="Divisions">The list of division ids. Use [] if divisions aren&#39;t used (Unassigned Division). Omitting or setting to [] clears existing values on update..</param>
        /// <param name="Version">The latest version of the Custom Attributes record. Optional for concurrency check..</param>
        /// <param name="CustomAttributes">The map of attribute values. (required).</param>
        public CustomAttributesPatchRequest(string Id = null, List<string> Divisions = null, int? Version = null, Dictionary<string, Object> CustomAttributes = null)
        {
            this.Id = Id;
            this.Divisions = Divisions;
            this.Version = Version;
            this.CustomAttributes = CustomAttributes;
            
        }
        


        /// <summary>
        /// Unique identifier for the Custom Attributes record. IDs are created by users.
        /// </summary>
        /// <value>Unique identifier for the Custom Attributes record. IDs are created by users.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The list of division ids. Use [] if divisions aren&#39;t used (Unassigned Division). Omitting or setting to [] clears existing values on update.
        /// </summary>
        /// <value>The list of division ids. Use [] if divisions aren&#39;t used (Unassigned Division). Omitting or setting to [] clears existing values on update.</value>
        [DataMember(Name="divisions", EmitDefaultValue=false)]
        public List<string> Divisions { get; set; }



        /// <summary>
        /// The latest version of the Custom Attributes record. Optional for concurrency check.
        /// </summary>
        /// <value>The latest version of the Custom Attributes record. Optional for concurrency check.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// The map of attribute values.
        /// </summary>
        /// <value>The map of attribute values.</value>
        [DataMember(Name="customAttributes", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomAttributes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomAttributesPatchRequest {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Divisions: ").Append(Divisions).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
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
            return this.Equals(obj as CustomAttributesPatchRequest);
        }

        /// <summary>
        /// Returns true if CustomAttributesPatchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomAttributesPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomAttributesPatchRequest other)
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
                    this.Divisions == other.Divisions ||
                    this.Divisions != null &&
                    this.Divisions.SequenceEqual(other.Divisions)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.CustomAttributes == other.CustomAttributes ||
                    this.CustomAttributes != null &&
                    this.CustomAttributes.SequenceEqual(other.CustomAttributes)
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

                if (this.Divisions != null)
                    hash = hash * 59 + this.Divisions.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.CustomAttributes != null)
                    hash = hash * 59 + this.CustomAttributes.GetHashCode();

                return hash;
            }
        }
    }

}
