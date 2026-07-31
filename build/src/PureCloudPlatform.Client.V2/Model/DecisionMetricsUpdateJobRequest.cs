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
    /// DecisionMetricsUpdateJobRequest
    /// </summary>
    [DataContract]
    public partial class DecisionMetricsUpdateJobRequest :  IEquatable<DecisionMetricsUpdateJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionMetricsUpdateJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecisionMetricsUpdateJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionMetricsUpdateJobRequest" /> class.
        /// </summary>
        /// <param name="UploadKey">The S3 key for the uploaded decision metrics file (required).</param>
        public DecisionMetricsUpdateJobRequest(string UploadKey = null)
        {
            this.UploadKey = UploadKey;
            
        }
        


        /// <summary>
        /// The S3 key for the uploaded decision metrics file
        /// </summary>
        /// <value>The S3 key for the uploaded decision metrics file</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionMetricsUpdateJobRequest {\n");

            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
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
            return this.Equals(obj as DecisionMetricsUpdateJobRequest);
        }

        /// <summary>
        /// Returns true if DecisionMetricsUpdateJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionMetricsUpdateJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionMetricsUpdateJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UploadKey == other.UploadKey ||
                    this.UploadKey != null &&
                    this.UploadKey.Equals(other.UploadKey)
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

                return hash;
            }
        }
    }

}
