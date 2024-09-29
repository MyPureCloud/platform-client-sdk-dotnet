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
    /// CopilotTranscriptionConfig
    /// </summary>
    [DataContract]
    public partial class CopilotTranscriptionConfig :  IEquatable<CopilotTranscriptionConfig>
    {
        /// <summary>
        /// The Transcription engine for Agent Copilot.
        /// </summary>
        /// <value>The Transcription engine for Agent Copilot.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EngineEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Genesys for "Genesys"
            /// </summary>
            [EnumMember(Value = "Genesys")]
            Genesys,
            
            /// <summary>
            /// Enum Genesysextended for "GenesysExtended"
            /// </summary>
            [EnumMember(Value = "GenesysExtended")]
            Genesysextended
        }
        /// <summary>
        /// The Transcription engine for Agent Copilot.
        /// </summary>
        /// <value>The Transcription engine for Agent Copilot.</value>
        [DataMember(Name="engine", EmitDefaultValue=false)]
        public EngineEnum? Engine { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotTranscriptionConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CopilotTranscriptionConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotTranscriptionConfig" /> class.
        /// </summary>
        /// <param name="Engine">The Transcription engine for Agent Copilot. (required).</param>
        public CopilotTranscriptionConfig(EngineEnum? Engine = null)
        {
            this.Engine = Engine;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopilotTranscriptionConfig {\n");

            sb.Append("  Engine: ").Append(Engine).Append("\n");
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
            return this.Equals(obj as CopilotTranscriptionConfig);
        }

        /// <summary>
        /// Returns true if CopilotTranscriptionConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of CopilotTranscriptionConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopilotTranscriptionConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Engine == other.Engine ||
                    this.Engine != null &&
                    this.Engine.Equals(other.Engine)
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
                if (this.Engine != null)
                    hash = hash * 59 + this.Engine.GetHashCode();

                return hash;
            }
        }
    }

}
