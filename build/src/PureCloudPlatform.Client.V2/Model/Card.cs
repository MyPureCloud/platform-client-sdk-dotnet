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
    /// Card
    /// </summary>
    [DataContract]
    public partial class Card :  IEquatable<Card>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// </summary>
        /// <param name="Title">Text to show in the title..</param>
        /// <param name="Description">Text to show in the description..</param>
        /// <param name="Url">URL of an image..</param>
        /// <param name="DefaultAction">The default action to be taken..</param>
        /// <param name="Actions">List of possible action objects..</param>
        public Card(string Title = null, string Description = null, string Url = null, CardAction DefaultAction = null, List<CardAction> Actions = null)
        {
            this.Title = Title;
            this.Description = Description;
            this.Url = Url;
            this.DefaultAction = DefaultAction;
            this.Actions = Actions;
            
        }
        


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
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// URL of an image.
        /// </summary>
        /// <value>URL of an image.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// The default action to be taken.
        /// </summary>
        /// <value>The default action to be taken.</value>
        [DataMember(Name="defaultAction", EmitDefaultValue=false)]
        public CardAction DefaultAction { get; set; }



        /// <summary>
        /// List of possible action objects.
        /// </summary>
        /// <value>List of possible action objects.</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<CardAction> Actions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Card {\n");

            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  DefaultAction: ").Append(DefaultAction).Append("\n");
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
            return this.Equals(obj as Card);
        }

        /// <summary>
        /// Returns true if Card instances are equal
        /// </summary>
        /// <param name="other">Instance of Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Card other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.DefaultAction == other.DefaultAction ||
                    this.DefaultAction != null &&
                    this.DefaultAction.Equals(other.DefaultAction)
                ) &&
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.DefaultAction != null)
                    hash = hash * 59 + this.DefaultAction.GetHashCode();

                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();

                return hash;
            }
        }
    }

}
