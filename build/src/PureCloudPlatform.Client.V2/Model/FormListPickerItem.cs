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
    /// An item in a list picker section
    /// </summary>
    [DataContract]
    public partial class FormListPickerItem :  IEquatable<FormListPickerItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FormListPickerItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FormListPickerItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormListPickerItem" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the item.</param>
        /// <param name="Title">Title of the item (required).</param>
        /// <param name="ImageUrl">URL of the image to display.</param>
        public FormListPickerItem(string Id = null, string Title = null, string ImageUrl = null)
        {
            this.Id = Id;
            this.Title = Title;
            this.ImageUrl = ImageUrl;
            
        }
        


        /// <summary>
        /// Unique identifier for the item
        /// </summary>
        /// <value>Unique identifier for the item</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Title of the item
        /// </summary>
        /// <value>Title of the item</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// URL of the image to display
        /// </summary>
        /// <value>URL of the image to display</value>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormListPickerItem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
            return this.Equals(obj as FormListPickerItem);
        }

        /// <summary>
        /// Returns true if FormListPickerItem instances are equal
        /// </summary>
        /// <param name="other">Instance of FormListPickerItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormListPickerItem other)
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
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
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

                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();

                return hash;
            }
        }
    }

}
