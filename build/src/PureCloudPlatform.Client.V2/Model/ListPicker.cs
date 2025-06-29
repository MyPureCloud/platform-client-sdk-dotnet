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
    /// ListPicker
    /// </summary>
    [DataContract]
    public partial class ListPicker :  IEquatable<ListPicker>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPicker" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListPicker() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPicker" /> class.
        /// </summary>
        /// <param name="Id">Optional unique identifier to help map component replies to form messages where multiple List Pickers can be present..</param>
        /// <param name="Title">Text to show in the title..</param>
        /// <param name="Subtitle">Text to show in the description..</param>
        /// <param name="Sections">An array of sections in the List Picker. (required).</param>
        public ListPicker(string Id = null, string Title = null, string Subtitle = null, List<ListPickerSection> Sections = null)
        {
            this.Id = Id;
            this.Title = Title;
            this.Subtitle = Subtitle;
            this.Sections = Sections;
            
        }
        


        /// <summary>
        /// Optional unique identifier to help map component replies to form messages where multiple List Pickers can be present.
        /// </summary>
        /// <value>Optional unique identifier to help map component replies to form messages where multiple List Pickers can be present.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Text to show in the title.
        /// </summary>
        /// <value>Text to show in the title.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Text to show in the description.
        /// </summary>
        /// <value>Text to show in the description.</value>
        [DataMember(Name="subtitle", EmitDefaultValue=false)]
        public string Subtitle { get; set; }



        /// <summary>
        /// An array of sections in the List Picker.
        /// </summary>
        /// <value>An array of sections in the List Picker.</value>
        [DataMember(Name="sections", EmitDefaultValue=false)]
        public List<ListPickerSection> Sections { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPicker {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  Sections: ").Append(Sections).Append("\n");
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
            return this.Equals(obj as ListPicker);
        }

        /// <summary>
        /// Returns true if ListPicker instances are equal
        /// </summary>
        /// <param name="other">Instance of ListPicker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListPicker other)
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
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Subtitle == other.Subtitle ||
                    this.Subtitle != null &&
                    this.Subtitle.Equals(other.Subtitle)
                ) &&
                (
                    this.Sections == other.Sections ||
                    this.Sections != null &&
                    this.Sections.SequenceEqual(other.Sections)
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

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Subtitle != null)
                    hash = hash * 59 + this.Subtitle.GetHashCode();

                if (this.Sections != null)
                    hash = hash * 59 + this.Sections.GetHashCode();

                return hash;
            }
        }
    }

}
