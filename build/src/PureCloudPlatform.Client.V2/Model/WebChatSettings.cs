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
    /// WebChatSettings
    /// </summary>
    [DataContract]
    public partial class WebChatSettings :  IEquatable<WebChatSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatSettings" /> class.
        /// </summary>
        /// <param name="RequireDeployment">RequireDeployment.</param>
        public WebChatSettings(bool? RequireDeployment = null)
        {
            this.RequireDeployment = RequireDeployment;
            
        }
        


        /// <summary>
        /// Gets or Sets RequireDeployment
        /// </summary>
        [DataMember(Name="requireDeployment", EmitDefaultValue=false)]
        public bool? RequireDeployment { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebChatSettings {\n");

            sb.Append("  RequireDeployment: ").Append(RequireDeployment).Append("\n");
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
            return this.Equals(obj as WebChatSettings);
        }

        /// <summary>
        /// Returns true if WebChatSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of WebChatSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebChatSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RequireDeployment == other.RequireDeployment ||
                    this.RequireDeployment != null &&
                    this.RequireDeployment.Equals(other.RequireDeployment)
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
                if (this.RequireDeployment != null)
                    hash = hash * 59 + this.RequireDeployment.GetHashCode();

                return hash;
            }
        }
    }

}
