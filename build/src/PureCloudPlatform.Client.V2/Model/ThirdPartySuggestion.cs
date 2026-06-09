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
    /// ThirdPartySuggestion
    /// </summary>
    [DataContract]
    public partial class ThirdPartySuggestion :  IEquatable<ThirdPartySuggestion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartySuggestion" /> class.
        /// </summary>
        /// <param name="Text">The third party suggestion text..</param>
        /// <param name="Title">The title of the suggestion..</param>
        /// <param name="Sources">A list of source references attributing the suggestion to its origin sources..</param>
        public ThirdPartySuggestion(string Text = null, string Title = null, List<ThirdPartySuggestionSource> Sources = null)
        {
            this.Text = Text;
            this.Title = Title;
            this.Sources = Sources;
            
        }
        


        /// <summary>
        /// The third party suggestion text.
        /// </summary>
        /// <value>The third party suggestion text.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// The title of the suggestion.
        /// </summary>
        /// <value>The title of the suggestion.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// A list of source references attributing the suggestion to its origin sources.
        /// </summary>
        /// <value>A list of source references attributing the suggestion to its origin sources.</value>
        [DataMember(Name="sources", EmitDefaultValue=false)]
        public List<ThirdPartySuggestionSource> Sources { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThirdPartySuggestion {\n");

            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
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
            return this.Equals(obj as ThirdPartySuggestion);
        }

        /// <summary>
        /// Returns true if ThirdPartySuggestion instances are equal
        /// </summary>
        /// <param name="other">Instance of ThirdPartySuggestion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThirdPartySuggestion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Sources == other.Sources ||
                    this.Sources != null &&
                    this.Sources.SequenceEqual(other.Sources)
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
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Sources != null)
                    hash = hash * 59 + this.Sources.GetHashCode();

                return hash;
            }
        }
    }

}
