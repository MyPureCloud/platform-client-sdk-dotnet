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
    /// Request for a guide session turn
    /// </summary>
    [DataContract]
    public partial class GuideSessionTurnRequest :  IEquatable<GuideSessionTurnRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionTurnRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GuideSessionTurnRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionTurnRequest" /> class.
        /// </summary>
        /// <param name="InputEvent">The input event for this turn. (required).</param>
        /// <param name="LanguageCode">The language code for this turn. (required).</param>
        /// <param name="Version">The version for this turn. (required).</param>
        /// <param name="InputVariables">The input variables for this turn..</param>
        /// <param name="KnowledgeSettings">The knowledge settings for this turn..</param>
        public GuideSessionTurnRequest(GuideSessionInputEvent InputEvent = null, string LanguageCode = null, string Version = null, List<GuideSessionVariable> InputVariables = null, KnowledgeSettings KnowledgeSettings = null)
        {
            this.InputEvent = InputEvent;
            this.LanguageCode = LanguageCode;
            this.Version = Version;
            this.InputVariables = InputVariables;
            this.KnowledgeSettings = KnowledgeSettings;
            
        }
        


        /// <summary>
        /// The input event for this turn.
        /// </summary>
        /// <value>The input event for this turn.</value>
        [DataMember(Name="inputEvent", EmitDefaultValue=false)]
        public GuideSessionInputEvent InputEvent { get; set; }



        /// <summary>
        /// The language code for this turn.
        /// </summary>
        /// <value>The language code for this turn.</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }



        /// <summary>
        /// The version for this turn.
        /// </summary>
        /// <value>The version for this turn.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }



        /// <summary>
        /// The input variables for this turn.
        /// </summary>
        /// <value>The input variables for this turn.</value>
        [DataMember(Name="inputVariables", EmitDefaultValue=false)]
        public List<GuideSessionVariable> InputVariables { get; set; }



        /// <summary>
        /// The knowledge settings for this turn.
        /// </summary>
        /// <value>The knowledge settings for this turn.</value>
        [DataMember(Name="knowledgeSettings", EmitDefaultValue=false)]
        public KnowledgeSettings KnowledgeSettings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuideSessionTurnRequest {\n");

            sb.Append("  InputEvent: ").Append(InputEvent).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  InputVariables: ").Append(InputVariables).Append("\n");
            sb.Append("  KnowledgeSettings: ").Append(KnowledgeSettings).Append("\n");
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
            return this.Equals(obj as GuideSessionTurnRequest);
        }

        /// <summary>
        /// Returns true if GuideSessionTurnRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GuideSessionTurnRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuideSessionTurnRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.InputEvent == other.InputEvent ||
                    this.InputEvent != null &&
                    this.InputEvent.Equals(other.InputEvent)
                ) &&
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.InputVariables == other.InputVariables ||
                    this.InputVariables != null &&
                    this.InputVariables.SequenceEqual(other.InputVariables)
                ) &&
                (
                    this.KnowledgeSettings == other.KnowledgeSettings ||
                    this.KnowledgeSettings != null &&
                    this.KnowledgeSettings.Equals(other.KnowledgeSettings)
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
                if (this.InputEvent != null)
                    hash = hash * 59 + this.InputEvent.GetHashCode();

                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.InputVariables != null)
                    hash = hash * 59 + this.InputVariables.GetHashCode();

                if (this.KnowledgeSettings != null)
                    hash = hash * 59 + this.KnowledgeSettings.GetHashCode();

                return hash;
            }
        }
    }

}
