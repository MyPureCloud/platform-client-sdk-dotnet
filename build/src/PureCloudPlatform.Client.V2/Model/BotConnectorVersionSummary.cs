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
    /// A version summary for a botConnector bot.
    /// </summary>
    [DataContract]
    public partial class BotConnectorVersionSummary :  IEquatable<BotConnectorVersionSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BotConnectorVersionSummary" /> class.
        /// </summary>
        /// <param name="Version">The name of the version..</param>
        public BotConnectorVersionSummary(string Version = null)
        {
            this.Version = Version;
            
        }
        


        /// <summary>
        /// The name of the version.
        /// </summary>
        /// <value>The name of the version.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BotConnectorVersionSummary {\n");

            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as BotConnectorVersionSummary);
        }

        /// <summary>
        /// Returns true if BotConnectorVersionSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of BotConnectorVersionSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotConnectorVersionSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                return hash;
            }
        }
    }

}
