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
    /// AutoAnswerSettings
    /// </summary>
    [DataContract]
    public partial class AutoAnswerSettings :  IEquatable<AutoAnswerSettings>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoAnswerSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoAnswerSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoAnswerSettings" /> class.
        /// </summary>
        /// <param name="Settings">Map of conversation media type enabled status. (required).</param>
        public AutoAnswerSettings(Dictionary<string, AutoAnswerSetting> Settings = null)
        {
            this.Settings = Settings;
            
        }
        


        /// <summary>
        /// Map of conversation media type enabled status.
        /// </summary>
        /// <value>Map of conversation media type enabled status.</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public Dictionary<string, AutoAnswerSetting> Settings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoAnswerSettings {\n");

            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(obj as AutoAnswerSettings);
        }

        /// <summary>
        /// Returns true if AutoAnswerSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of AutoAnswerSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoAnswerSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.SequenceEqual(other.Settings)
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
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();

                return hash;
            }
        }
    }

}
