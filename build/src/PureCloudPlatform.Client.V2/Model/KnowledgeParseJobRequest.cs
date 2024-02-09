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
    /// KnowledgeParseJobRequest
    /// </summary>
    [DataContract]
    public partial class KnowledgeParseJobRequest :  IEquatable<KnowledgeParseJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeParseJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeParseJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeParseJobRequest" /> class.
        /// </summary>
        /// <param name="UploadKey">Upload key (required).</param>
        /// <param name="Hints">Hinted titles for the parser..</param>
        public KnowledgeParseJobRequest(string UploadKey = null, List<string> Hints = null)
        {
            this.UploadKey = UploadKey;
            this.Hints = Hints;
            
        }
        


        /// <summary>
        /// Upload key
        /// </summary>
        /// <value>Upload key</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }



        /// <summary>
        /// Hinted titles for the parser.
        /// </summary>
        /// <value>Hinted titles for the parser.</value>
        [DataMember(Name="hints", EmitDefaultValue=false)]
        public List<string> Hints { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeParseJobRequest {\n");

            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
            sb.Append("  Hints: ").Append(Hints).Append("\n");
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
            return this.Equals(obj as KnowledgeParseJobRequest);
        }

        /// <summary>
        /// Returns true if KnowledgeParseJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeParseJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeParseJobRequest other)
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
                    this.Hints == other.Hints ||
                    this.Hints != null &&
                    this.Hints.SequenceEqual(other.Hints)
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

                if (this.Hints != null)
                    hash = hash * 59 + this.Hints.GetHashCode();

                return hash;
            }
        }
    }

}
