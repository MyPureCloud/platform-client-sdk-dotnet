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
    /// An entry in a List template.
    /// </summary>
    [DataContract]
    public partial class ListItemComponent :  IEquatable<ListItemComponent>
    {
        /// <summary>
        /// The type of list item to render.
        /// </summary>
        /// <value>The type of list item to render.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Listitem for "ListItem"
            /// </summary>
            [EnumMember(Value = "ListItem")]
            Listitem,
            
            /// <summary>
            /// Enum Listitembig for "ListItemBig"
            /// </summary>
            [EnumMember(Value = "ListItemBig")]
            Listitembig
        }
        /// <summary>
        /// The type of list item to render.
        /// </summary>
        /// <value>The type of list item to render.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemComponent" /> class.
        /// </summary>
        /// <param name="Id">An ID assigned to this list item..</param>
        /// <param name="Rmid">An ID of the rich message instance..</param>
        /// <param name="Type">The type of list item to render..</param>
        /// <param name="Image">URL of an image..</param>
        /// <param name="Title">The main headline of the list item..</param>
        /// <param name="Description">Text to show in the list item description..</param>
        /// <param name="Actions">The list item actions (Deprecated)..</param>
        public ListItemComponent(string Id = null, string Rmid = null, TypeEnum? Type = null, string Image = null, string Title = null, string Description = null, ContentActions Actions = null)
        {
            this.Id = Id;
            this.Rmid = Rmid;
            this.Type = Type;
            this.Image = Image;
            this.Title = Title;
            this.Description = Description;
            this.Actions = Actions;
            
        }
        


        /// <summary>
        /// An ID assigned to this list item.
        /// </summary>
        /// <value>An ID assigned to this list item.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// An ID of the rich message instance.
        /// </summary>
        /// <value>An ID of the rich message instance.</value>
        [DataMember(Name="rmid", EmitDefaultValue=false)]
        public string Rmid { get; set; }





        /// <summary>
        /// URL of an image.
        /// </summary>
        /// <value>URL of an image.</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }



        /// <summary>
        /// The main headline of the list item.
        /// </summary>
        /// <value>The main headline of the list item.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Text to show in the list item description.
        /// </summary>
        /// <value>Text to show in the list item description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The list item actions (Deprecated).
        /// </summary>
        /// <value>The list item actions (Deprecated).</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public ContentActions Actions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListItemComponent {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rmid: ").Append(Rmid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(obj as ListItemComponent);
        }

        /// <summary>
        /// Returns true if ListItemComponent instances are equal
        /// </summary>
        /// <param name="other">Instance of ListItemComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListItemComponent other)
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
                    this.Rmid == other.Rmid ||
                    this.Rmid != null &&
                    this.Rmid.Equals(other.Rmid)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.Equals(other.Actions)
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

                if (this.Rmid != null)
                    hash = hash * 59 + this.Rmid.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();

                return hash;
            }
        }
    }

}
