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
    /// TtsSettings
    /// </summary>
    [DataContract]
    public partial class TtsSettings :  IEquatable<TtsSettings>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TtsSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSettings" /> class.
        /// </summary>
        /// <param name="DefaultEngine">ID of the global default TTS engine (required).</param>
        /// <param name="LanguageOverrides">The list of default overrides for specific languages (required).</param>
        public TtsSettings(string DefaultEngine = null, List<LanguageOverride> LanguageOverrides = null)
        {
            this.DefaultEngine = DefaultEngine;
            this.LanguageOverrides = LanguageOverrides;
            
        }
        


        /// <summary>
        /// ID of the global default TTS engine
        /// </summary>
        /// <value>ID of the global default TTS engine</value>
        [DataMember(Name="defaultEngine", EmitDefaultValue=false)]
        public string DefaultEngine { get; set; }



        /// <summary>
        /// The list of default overrides for specific languages
        /// </summary>
        /// <value>The list of default overrides for specific languages</value>
        [DataMember(Name="languageOverrides", EmitDefaultValue=false)]
        public List<LanguageOverride> LanguageOverrides { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TtsSettings {\n");

            sb.Append("  DefaultEngine: ").Append(DefaultEngine).Append("\n");
            sb.Append("  LanguageOverrides: ").Append(LanguageOverrides).Append("\n");
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
            return this.Equals(obj as TtsSettings);
        }

        /// <summary>
        /// Returns true if TtsSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of TtsSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TtsSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DefaultEngine == other.DefaultEngine ||
                    this.DefaultEngine != null &&
                    this.DefaultEngine.Equals(other.DefaultEngine)
                ) &&
                (
                    this.LanguageOverrides == other.LanguageOverrides ||
                    this.LanguageOverrides != null &&
                    this.LanguageOverrides.SequenceEqual(other.LanguageOverrides)
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
                if (this.DefaultEngine != null)
                    hash = hash * 59 + this.DefaultEngine.GetHashCode();

                if (this.LanguageOverrides != null)
                    hash = hash * 59 + this.LanguageOverrides.GetHashCode();

                return hash;
            }
        }
    }

}
