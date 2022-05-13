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
    /// UserImage
    /// </summary>
    [DataContract]
    public partial class UserImage :  IEquatable<UserImage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserImage" /> class.
        /// </summary>
        /// <param name="Resolution">Height and/or width of image. ex: 640x480 or x128.</param>
        /// <param name="ImageUri">ImageUri.</param>
        public UserImage(string Resolution = null, string ImageUri = null)
        {
            this.Resolution = Resolution;
            this.ImageUri = ImageUri;
            
        }
        


        /// <summary>
        /// Height and/or width of image. ex: 640x480 or x128
        /// </summary>
        /// <value>Height and/or width of image. ex: 640x480 or x128</value>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public string Resolution { get; set; }



        /// <summary>
        /// Gets or Sets ImageUri
        /// </summary>
        [DataMember(Name="imageUri", EmitDefaultValue=false)]
        public string ImageUri { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserImage {\n");

            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  ImageUri: ").Append(ImageUri).Append("\n");
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
            return this.Equals(obj as UserImage);
        }

        /// <summary>
        /// Returns true if UserImage instances are equal
        /// </summary>
        /// <param name="other">Instance of UserImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserImage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Resolution == other.Resolution ||
                    this.Resolution != null &&
                    this.Resolution.Equals(other.Resolution)
                ) &&
                (
                    this.ImageUri == other.ImageUri ||
                    this.ImageUri != null &&
                    this.ImageUri.Equals(other.ImageUri)
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
                if (this.Resolution != null)
                    hash = hash * 59 + this.Resolution.GetHashCode();

                if (this.ImageUri != null)
                    hash = hash * 59 + this.ImageUri.GetHashCode();

                return hash;
            }
        }
    }

}
