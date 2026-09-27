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
    /// ListItem
    /// </summary>
    [DataContract]
    public partial class ListItem :  IEquatable<ListItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListItem" /> class.
        /// </summary>
        /// <param name="Value">The value returned when this item is selected. (required).</param>
        /// <param name="Synonyms">Alternative phrases that should match this value. Used only with Exact match type..</param>
        /// <param name="Active">Whether this list item is active and available for selection..</param>
        /// <param name="Description">Description of this value for semantic matching. Used only with Semantic match type..</param>
        public ListItem(string Value = null, List<string> Synonyms = null, bool? Active = null, string Description = null)
        {
            this.Value = Value;
            this.Synonyms = Synonyms;
            this.Active = Active;
            this.Description = Description;
            
        }
        


        /// <summary>
        /// The value returned when this item is selected.
        /// </summary>
        /// <value>The value returned when this item is selected.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }



        /// <summary>
        /// Alternative phrases that should match this value. Used only with Exact match type.
        /// </summary>
        /// <value>Alternative phrases that should match this value. Used only with Exact match type.</value>
        [DataMember(Name="synonyms", EmitDefaultValue=false)]
        public List<string> Synonyms { get; set; }



        /// <summary>
        /// Whether this list item is active and available for selection.
        /// </summary>
        /// <value>Whether this list item is active and available for selection.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }



        /// <summary>
        /// Description of this value for semantic matching. Used only with Semantic match type.
        /// </summary>
        /// <value>Description of this value for semantic matching. Used only with Semantic match type.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListItem {\n");

            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Synonyms: ").Append(Synonyms).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as ListItem);
        }

        /// <summary>
        /// Returns true if ListItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Synonyms == other.Synonyms ||
                    this.Synonyms != null &&
                    this.Synonyms.SequenceEqual(other.Synonyms)
                ) &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Synonyms != null)
                    hash = hash * 59 + this.Synonyms.GetHashCode();

                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                return hash;
            }
        }
    }

}
