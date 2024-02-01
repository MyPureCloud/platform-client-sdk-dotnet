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
    /// SupportCenterHeroStyle
    /// </summary>
    [DataContract]
    public partial class SupportCenterHeroStyle :  IEquatable<SupportCenterHeroStyle>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterHeroStyle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportCenterHeroStyle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterHeroStyle" /> class.
        /// </summary>
        /// <param name="BackgroundColor">Background color for hero section, in hexadecimal format, eg #ffffff (required).</param>
        /// <param name="TextColor">Text color for hero section, in hexadecimal format, eg #ffffff (required).</param>
        /// <param name="Image">Background image for hero section.</param>
        public SupportCenterHeroStyle(string BackgroundColor = null, string TextColor = null, SupportCenterImage Image = null)
        {
            this.BackgroundColor = BackgroundColor;
            this.TextColor = TextColor;
            this.Image = Image;
            
        }
        


        /// <summary>
        /// Background color for hero section, in hexadecimal format, eg #ffffff
        /// </summary>
        /// <value>Background color for hero section, in hexadecimal format, eg #ffffff</value>
        [DataMember(Name="backgroundColor", EmitDefaultValue=false)]
        public string BackgroundColor { get; set; }



        /// <summary>
        /// Text color for hero section, in hexadecimal format, eg #ffffff
        /// </summary>
        /// <value>Text color for hero section, in hexadecimal format, eg #ffffff</value>
        [DataMember(Name="textColor", EmitDefaultValue=false)]
        public string TextColor { get; set; }



        /// <summary>
        /// Background image for hero section
        /// </summary>
        /// <value>Background image for hero section</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public SupportCenterImage Image { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportCenterHeroStyle {\n");

            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  TextColor: ").Append(TextColor).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return this.Equals(obj as SupportCenterHeroStyle);
        }

        /// <summary>
        /// Returns true if SupportCenterHeroStyle instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportCenterHeroStyle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportCenterHeroStyle other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.BackgroundColor == other.BackgroundColor ||
                    this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(other.BackgroundColor)
                ) &&
                (
                    this.TextColor == other.TextColor ||
                    this.TextColor != null &&
                    this.TextColor.Equals(other.TextColor)
                ) &&
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
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
                if (this.BackgroundColor != null)
                    hash = hash * 59 + this.BackgroundColor.GetHashCode();

                if (this.TextColor != null)
                    hash = hash * 59 + this.TextColor.GetHashCode();

                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();

                return hash;
            }
        }
    }

}
