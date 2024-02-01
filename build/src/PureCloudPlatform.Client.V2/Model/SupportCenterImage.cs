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
    /// SupportCenterImage
    /// </summary>
    [DataContract]
    public partial class SupportCenterImage :  IEquatable<SupportCenterImage>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterImage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportCenterImage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterImage" /> class.
        /// </summary>
        /// <param name="Source">Source URLs for image (required).</param>
        public SupportCenterImage(SupportCenterImageSource Source = null)
        {
            this.Source = Source;
            
        }
        


        /// <summary>
        /// Source URLs for image
        /// </summary>
        /// <value>Source URLs for image</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SupportCenterImageSource Source { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportCenterImage {\n");

            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(obj as SupportCenterImage);
        }

        /// <summary>
        /// Returns true if SupportCenterImage instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportCenterImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportCenterImage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
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
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                return hash;
            }
        }
    }

}
