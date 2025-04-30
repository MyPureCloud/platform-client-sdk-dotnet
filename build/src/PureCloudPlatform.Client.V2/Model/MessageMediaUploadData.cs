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
    /// MessageMediaUploadData
    /// </summary>
    [DataContract]
    public partial class MessageMediaUploadData :  IEquatable<MessageMediaUploadData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageMediaUploadData" /> class.
        /// </summary>
        /// <param name="Id">A unique media ID.</param>
        /// <param name="Name">The name of the file.</param>
        /// <param name="UploadUrl">URL to upload the file.</param>
        /// <param name="UploadHeaders">Required headers when uploading a file with the upload URL.</param>
        public MessageMediaUploadData(string Id = null, string Name = null, string UploadUrl = null, Dictionary<string, string> UploadHeaders = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.UploadUrl = UploadUrl;
            this.UploadHeaders = UploadHeaders;
            
        }
        


        /// <summary>
        /// A unique media ID
        /// </summary>
        /// <value>A unique media ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The name of the file
        /// </summary>
        /// <value>The name of the file</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// URL to upload the file
        /// </summary>
        /// <value>URL to upload the file</value>
        [DataMember(Name="uploadUrl", EmitDefaultValue=false)]
        public string UploadUrl { get; set; }



        /// <summary>
        /// Required headers when uploading a file with the upload URL
        /// </summary>
        /// <value>Required headers when uploading a file with the upload URL</value>
        [DataMember(Name="uploadHeaders", EmitDefaultValue=false)]
        public Dictionary<string, string> UploadHeaders { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageMediaUploadData {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
            sb.Append("  UploadHeaders: ").Append(UploadHeaders).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as MessageMediaUploadData);
        }

        /// <summary>
        /// Returns true if MessageMediaUploadData instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageMediaUploadData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageMediaUploadData other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.UploadUrl == other.UploadUrl ||
                    this.UploadUrl != null &&
                    this.UploadUrl.Equals(other.UploadUrl)
                ) &&
                (
                    this.UploadHeaders == other.UploadHeaders ||
                    this.UploadHeaders != null &&
                    this.UploadHeaders.SequenceEqual(other.UploadHeaders)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.UploadUrl != null)
                    hash = hash * 59 + this.UploadUrl.GetHashCode();

                if (this.UploadHeaders != null)
                    hash = hash * 59 + this.UploadHeaders.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
