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
    /// ListPickerItem
    /// </summary>
    [DataContract]
    public partial class ListPickerItem :  IEquatable<ListPickerItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPickerItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListPickerItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPickerItem" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the list picker item (required).</param>
        /// <param name="Subtitle">Additional text providing more details about the item..</param>
        /// <param name="Title">The main text displayed for the item. (required).</param>
        /// <param name="Selected">Whether the item is selected. (required).</param>
        public ListPickerItem(string Id = null, string Subtitle = null, string Title = null, bool? Selected = null)
        {
            this.Id = Id;
            this.Subtitle = Subtitle;
            this.Title = Title;
            this.Selected = Selected;
            
        }
        


        /// <summary>
        /// Unique identifier for the list picker item
        /// </summary>
        /// <value>Unique identifier for the list picker item</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Additional text providing more details about the item.
        /// </summary>
        /// <value>Additional text providing more details about the item.</value>
        [DataMember(Name="subtitle", EmitDefaultValue=false)]
        public string Subtitle { get; set; }



        /// <summary>
        /// The main text displayed for the item.
        /// </summary>
        /// <value>The main text displayed for the item.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Whether the item is selected.
        /// </summary>
        /// <value>Whether the item is selected.</value>
        [DataMember(Name="selected", EmitDefaultValue=false)]
        public bool? Selected { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPickerItem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
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
            return this.Equals(obj as ListPickerItem);
        }

        /// <summary>
        /// Returns true if ListPickerItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ListPickerItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListPickerItem other)
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
                    this.Subtitle == other.Subtitle ||
                    this.Subtitle != null &&
                    this.Subtitle.Equals(other.Subtitle)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Selected == other.Selected ||
                    this.Selected != null &&
                    this.Selected.Equals(other.Selected)
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

                if (this.Subtitle != null)
                    hash = hash * 59 + this.Subtitle.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Selected != null)
                    hash = hash * 59 + this.Selected.GetHashCode();

                return hash;
            }
        }
    }

}
