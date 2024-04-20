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
    /// The settings to enable video chat
    /// </summary>
    [DataContract]
    public partial class VideoSettings :  IEquatable<VideoSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSettings" /> class.
        /// </summary>
        /// <param name="Enabled">whether or not video is enabled.</param>
        /// <param name="Agent">Video Settings for agent.</param>
        /// <param name="User">Video Settings for user.</param>
        public VideoSettings(bool? Enabled = null, AgentVideoSettings Agent = null, UserVideoSettings User = null)
        {
            this.Enabled = Enabled;
            this.Agent = Agent;
            this.User = User;
            
        }
        


        /// <summary>
        /// whether or not video is enabled
        /// </summary>
        /// <value>whether or not video is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Video Settings for agent
        /// </summary>
        /// <value>Video Settings for agent</value>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public AgentVideoSettings Agent { get; set; }



        /// <summary>
        /// Video Settings for user
        /// </summary>
        /// <value>Video Settings for user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserVideoSettings User { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoSettings {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as VideoSettings);
        }

        /// <summary>
        /// Returns true if VideoSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of VideoSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                return hash;
            }
        }
    }

}
