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
    /// Request body for generating the content of a guide
    /// </summary>
    [DataContract]
    public partial class GenerateGuideContentRequest :  IEquatable<GenerateGuideContentRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateGuideContentRequest" /> class.
        /// </summary>
        /// <param name="Description">The description that you wish to use to generate the guide content from..</param>
        /// <param name="Url">The URL of the file you wish to use to generate the guide content from..</param>
        public GenerateGuideContentRequest(string Description = null, string Url = null)
        {
            this.Description = Description;
            this.Url = Url;
            
        }
        


        /// <summary>
        /// The description that you wish to use to generate the guide content from.
        /// </summary>
        /// <value>The description that you wish to use to generate the guide content from.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The URL of the file you wish to use to generate the guide content from.
        /// </summary>
        /// <value>The URL of the file you wish to use to generate the guide content from.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateGuideContentRequest {\n");

            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as GenerateGuideContentRequest);
        }

        /// <summary>
        /// Returns true if GenerateGuideContentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GenerateGuideContentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateGuideContentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                return hash;
            }
        }
    }

}
