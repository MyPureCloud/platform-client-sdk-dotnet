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
    /// NluInfo
    /// </summary>
    [DataContract]
    public partial class NluInfo :  IEquatable<NluInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NluInfo" /> class.
        /// </summary>
        /// <param name="Intents">Intents.</param>
        /// <param name="EngineVersion">EngineVersion.</param>
        /// <param name="NluData">NluData.</param>
        public NluInfo(List<Intent> Intents = null, string EngineVersion = null, NluDomainVersion NluData = null)
        {
            this.Intents = Intents;
            this.EngineVersion = EngineVersion;
            this.NluData = NluData;
            
        }
        


        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public AddressableEntityRef Domain { get; private set; }



        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public NluDomainVersion Version { get; private set; }



        /// <summary>
        /// Gets or Sets Intents
        /// </summary>
        [DataMember(Name="intents", EmitDefaultValue=false)]
        public List<Intent> Intents { get; set; }



        /// <summary>
        /// Gets or Sets EngineVersion
        /// </summary>
        [DataMember(Name="engineVersion", EmitDefaultValue=false)]
        public string EngineVersion { get; set; }



        /// <summary>
        /// Gets or Sets NluData
        /// </summary>
        [DataMember(Name="nluData", EmitDefaultValue=false)]
        public NluDomainVersion NluData { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NluInfo {\n");

            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Intents: ").Append(Intents).Append("\n");
            sb.Append("  EngineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  NluData: ").Append(NluData).Append("\n");
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
            return this.Equals(obj as NluInfo);
        }

        /// <summary>
        /// Returns true if NluInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of NluInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NluInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Intents == other.Intents ||
                    this.Intents != null &&
                    this.Intents.SequenceEqual(other.Intents)
                ) &&
                (
                    this.EngineVersion == other.EngineVersion ||
                    this.EngineVersion != null &&
                    this.EngineVersion.Equals(other.EngineVersion)
                ) &&
                (
                    this.NluData == other.NluData ||
                    this.NluData != null &&
                    this.NluData.Equals(other.NluData)
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
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Intents != null)
                    hash = hash * 59 + this.Intents.GetHashCode();

                if (this.EngineVersion != null)
                    hash = hash * 59 + this.EngineVersion.GetHashCode();

                if (this.NluData != null)
                    hash = hash * 59 + this.NluData.GetHashCode();

                return hash;
            }
        }
    }

}
