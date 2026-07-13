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
    /// CreateDecisionTableVersionRequest
    /// </summary>
    [DataContract]
    public partial class CreateDecisionTableVersionRequest :  IEquatable<CreateDecisionTableVersionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionTableVersionRequest" /> class.
        /// </summary>
        /// <param name="SourceVersion">The published, superseded, or snapshot version to create the new draft from. When not provided or null, the published version is used. Must be at least 1 when provided..</param>
        public CreateDecisionTableVersionRequest(int? SourceVersion = null)
        {
            this.SourceVersion = SourceVersion;
            
        }
        


        /// <summary>
        /// The published, superseded, or snapshot version to create the new draft from. When not provided or null, the published version is used. Must be at least 1 when provided.
        /// </summary>
        /// <value>The published, superseded, or snapshot version to create the new draft from. When not provided or null, the published version is used. Must be at least 1 when provided.</value>
        [DataMember(Name="sourceVersion", EmitDefaultValue=false)]
        public int? SourceVersion { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDecisionTableVersionRequest {\n");

            sb.Append("  SourceVersion: ").Append(SourceVersion).Append("\n");
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
            return this.Equals(obj as CreateDecisionTableVersionRequest);
        }

        /// <summary>
        /// Returns true if CreateDecisionTableVersionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateDecisionTableVersionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDecisionTableVersionRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceVersion == other.SourceVersion ||
                    this.SourceVersion != null &&
                    this.SourceVersion.Equals(other.SourceVersion)
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
                if (this.SourceVersion != null)
                    hash = hash * 59 + this.SourceVersion.GetHashCode();

                return hash;
            }
        }
    }

}
