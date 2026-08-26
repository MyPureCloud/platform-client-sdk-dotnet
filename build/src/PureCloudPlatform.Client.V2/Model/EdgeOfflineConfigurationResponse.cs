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
    /// EdgeOfflineConfigurationResponse
    /// </summary>
    [DataContract]
    public partial class EdgeOfflineConfigurationResponse :  IEquatable<EdgeOfflineConfigurationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeOfflineConfigurationResponse" /> class.
        /// </summary>
        /// <param name="DownloadUrl">The URL to download the Edge configuration file. Save the file to a USB key and plug it into the Edge..</param>
        public EdgeOfflineConfigurationResponse(string DownloadUrl = null)
        {
            this.DownloadUrl = DownloadUrl;
            
        }
        


        /// <summary>
        /// The URL to download the Edge configuration file. Save the file to a USB key and plug it into the Edge.
        /// </summary>
        /// <value>The URL to download the Edge configuration file. Save the file to a USB key and plug it into the Edge.</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeOfflineConfigurationResponse {\n");

            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
            return this.Equals(obj as EdgeOfflineConfigurationResponse);
        }

        /// <summary>
        /// Returns true if EdgeOfflineConfigurationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeOfflineConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeOfflineConfigurationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
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
                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                return hash;
            }
        }
    }

}
