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
    /// ContentOfferStyleProperties
    /// </summary>
    [DataContract]
    public partial class ContentOfferStyleProperties :  IEquatable<ContentOfferStyleProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentOfferStyleProperties" /> class.
        /// </summary>
        /// <param name="Padding">Padding of the offer. (eg. 10px).</param>
        /// <param name="Color">Text color of the offer. (eg. #FF0000).</param>
        /// <param name="BackgroundColor">Background color of the offer. (eg. #000000).</param>
        public ContentOfferStyleProperties(string Padding = null, string Color = null, string BackgroundColor = null)
        {
            this.Padding = Padding;
            this.Color = Color;
            this.BackgroundColor = BackgroundColor;
            
        }
        


        /// <summary>
        /// Padding of the offer. (eg. 10px)
        /// </summary>
        /// <value>Padding of the offer. (eg. 10px)</value>
        [DataMember(Name="padding", EmitDefaultValue=false)]
        public string Padding { get; set; }



        /// <summary>
        /// Text color of the offer. (eg. #FF0000)
        /// </summary>
        /// <value>Text color of the offer. (eg. #FF0000)</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }



        /// <summary>
        /// Background color of the offer. (eg. #000000)
        /// </summary>
        /// <value>Background color of the offer. (eg. #000000)</value>
        [DataMember(Name="backgroundColor", EmitDefaultValue=false)]
        public string BackgroundColor { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentOfferStyleProperties {\n");

            sb.Append("  Padding: ").Append(Padding).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
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
            return this.Equals(obj as ContentOfferStyleProperties);
        }

        /// <summary>
        /// Returns true if ContentOfferStyleProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentOfferStyleProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentOfferStyleProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Padding == other.Padding ||
                    this.Padding != null &&
                    this.Padding.Equals(other.Padding)
                ) &&
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) &&
                (
                    this.BackgroundColor == other.BackgroundColor ||
                    this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(other.BackgroundColor)
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
                if (this.Padding != null)
                    hash = hash * 59 + this.Padding.GetHashCode();

                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();

                if (this.BackgroundColor != null)
                    hash = hash * 59 + this.BackgroundColor.GetHashCode();

                return hash;
            }
        }
    }

}
