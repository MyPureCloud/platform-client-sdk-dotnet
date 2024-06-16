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
    /// Learning SCORM upload request
    /// </summary>
    [DataContract]
    public partial class LearningScormUploadRequest :  IEquatable<LearningScormUploadRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningScormUploadRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningScormUploadRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningScormUploadRequest" /> class.
        /// </summary>
        /// <param name="ContentMd5">The MD5 content of the SCORM package (required).</param>
        public LearningScormUploadRequest(string ContentMd5 = null)
        {
            this.ContentMd5 = ContentMd5;
            
        }
        


        /// <summary>
        /// The MD5 content of the SCORM package
        /// </summary>
        /// <value>The MD5 content of the SCORM package</value>
        [DataMember(Name="contentMd5", EmitDefaultValue=false)]
        public string ContentMd5 { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningScormUploadRequest {\n");

            sb.Append("  ContentMd5: ").Append(ContentMd5).Append("\n");
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
            return this.Equals(obj as LearningScormUploadRequest);
        }

        /// <summary>
        /// Returns true if LearningScormUploadRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningScormUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningScormUploadRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContentMd5 == other.ContentMd5 ||
                    this.ContentMd5 != null &&
                    this.ContentMd5.Equals(other.ContentMd5)
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
                if (this.ContentMd5 != null)
                    hash = hash * 59 + this.ContentMd5.GetHashCode();

                return hash;
            }
        }
    }

}
