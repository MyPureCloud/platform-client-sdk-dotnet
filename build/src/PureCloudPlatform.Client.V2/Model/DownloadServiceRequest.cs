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
    /// DownloadServiceRequest
    /// </summary>
    [DataContract]
    public partial class DownloadServiceRequest :  IEquatable<DownloadServiceRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadServiceRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DownloadServiceRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadServiceRequest" /> class.
        /// </summary>
        /// <param name="Files">List of file names to download (required).</param>
        public DownloadServiceRequest(List<string> Files = null)
        {
            this.Files = Files;
            
        }
        


        /// <summary>
        /// List of file names to download
        /// </summary>
        /// <value>List of file names to download</value>
        [DataMember(Name="files", EmitDefaultValue=false)]
        public List<string> Files { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadServiceRequest {\n");

            sb.Append("  Files: ").Append(Files).Append("\n");
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
            return this.Equals(obj as DownloadServiceRequest);
        }

        /// <summary>
        /// Returns true if DownloadServiceRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DownloadServiceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadServiceRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Files == other.Files ||
                    this.Files != null &&
                    this.Files.SequenceEqual(other.Files)
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
                if (this.Files != null)
                    hash = hash * 59 + this.Files.GetHashCode();

                return hash;
            }
        }
    }

}
