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
    /// ConfusionUtterance
    /// </summary>
    [DataContract]
    public partial class ConfusionUtterance :  IEquatable<ConfusionUtterance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfusionUtterance" /> class.
        /// </summary>
        /// <param name="Text">Utterance Text..</param>
        /// <param name="Similarity">Utterance's similarity score, 0 being dissimilar and 1 being very similar..</param>
        public ConfusionUtterance(string Text = null, float? Similarity = null)
        {
            this.Text = Text;
            this.Similarity = Similarity;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Utterance Text.
        /// </summary>
        /// <value>Utterance Text.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Utterance's similarity score, 0 being dissimilar and 1 being very similar.
        /// </summary>
        /// <value>Utterance's similarity score, 0 being dissimilar and 1 being very similar.</value>
        [DataMember(Name="similarity", EmitDefaultValue=false)]
        public float? Similarity { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfusionUtterance {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Similarity: ").Append(Similarity).Append("\n");
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
            return this.Equals(obj as ConfusionUtterance);
        }

        /// <summary>
        /// Returns true if ConfusionUtterance instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfusionUtterance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfusionUtterance other)
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
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Similarity == other.Similarity ||
                    this.Similarity != null &&
                    this.Similarity.Equals(other.Similarity)
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

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Similarity != null)
                    hash = hash * 59 + this.Similarity.GetHashCode();

                return hash;
            }
        }
    }

}
