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
    /// KnowledgeSyncJobRequest
    /// </summary>
    [DataContract]
    public partial class KnowledgeSyncJobRequest :  IEquatable<KnowledgeSyncJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSyncJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeSyncJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSyncJobRequest" /> class.
        /// </summary>
        /// <param name="UploadKey">Upload key (required).</param>
        /// <param name="SourceId">Knowledge integration source id..</param>
        public KnowledgeSyncJobRequest(string UploadKey = null, string SourceId = null)
        {
            this.UploadKey = UploadKey;
            this.SourceId = SourceId;
            
        }
        


        /// <summary>
        /// Upload key
        /// </summary>
        /// <value>Upload key</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }



        /// <summary>
        /// Knowledge integration source id.
        /// </summary>
        /// <value>Knowledge integration source id.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeSyncJobRequest {\n");

            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
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
            return this.Equals(obj as KnowledgeSyncJobRequest);
        }

        /// <summary>
        /// Returns true if KnowledgeSyncJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSyncJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSyncJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UploadKey == other.UploadKey ||
                    this.UploadKey != null &&
                    this.UploadKey.Equals(other.UploadKey)
                ) &&
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
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
                if (this.UploadKey != null)
                    hash = hash * 59 + this.UploadKey.GetHashCode();

                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();

                return hash;
            }
        }
    }

}
