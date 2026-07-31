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
    /// AgenticVirtualAgentVersionPublishJobRequest
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentVersionPublishJobRequest :  IEquatable<AgenticVirtualAgentVersionPublishJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentVersionPublishJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgenticVirtualAgentVersionPublishJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentVersionPublishJobRequest" /> class.
        /// </summary>
        /// <param name="VirtualAgentVersion">The attributes of the virtual agent version to update as part of this publish job. (required).</param>
        public AgenticVirtualAgentVersionPublishJobRequest(AgenticVirtualAgentVersionPublish VirtualAgentVersion = null)
        {
            this.VirtualAgentVersion = VirtualAgentVersion;
            
        }
        


        /// <summary>
        /// The attributes of the virtual agent version to update as part of this publish job.
        /// </summary>
        /// <value>The attributes of the virtual agent version to update as part of this publish job.</value>
        [DataMember(Name="virtualAgentVersion", EmitDefaultValue=false)]
        public AgenticVirtualAgentVersionPublish VirtualAgentVersion { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentVersionPublishJobRequest {\n");

            sb.Append("  VirtualAgentVersion: ").Append(VirtualAgentVersion).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentVersionPublishJobRequest);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentVersionPublishJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentVersionPublishJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentVersionPublishJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.VirtualAgentVersion == other.VirtualAgentVersion ||
                    this.VirtualAgentVersion != null &&
                    this.VirtualAgentVersion.Equals(other.VirtualAgentVersion)
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
                if (this.VirtualAgentVersion != null)
                    hash = hash * 59 + this.VirtualAgentVersion.GetHashCode();

                return hash;
            }
        }
    }

}
