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
    /// DialerResponsesetConfigChangeResponseSet
    /// </summary>
    [DataContract]
    public partial class DialerResponsesetConfigChangeResponseSet :  IEquatable<DialerResponsesetConfigChangeResponseSet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerResponsesetConfigChangeResponseSet" /> class.
        /// </summary>
        /// <param name="Responses">Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}}.</param>
        /// <param name="BeepDetectionEnabled">When beep detection is enabled, answering machine detection will wait for the beep before transferring the call.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Name">The UI-visible name of the object.</param>
        /// <param name="DateCreated">Creation time of the entity.</param>
        /// <param name="DateModified">Last modified time of the entity.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        /// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
        public DialerResponsesetConfigChangeResponseSet(Dictionary<string, DialerResponsesetConfigChangeReaction> Responses = null, bool? BeepDetectionEnabled = null, Dictionary<string, Object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null, Dictionary<string, Object> GetAdditionalProperties = null)
        {
            this.Responses = Responses;
            this.BeepDetectionEnabled = BeepDetectionEnabled;
            this.AdditionalProperties = AdditionalProperties;
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            this.GetAdditionalProperties = GetAdditionalProperties;
            
        }
        


        /// <summary>
        /// Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}}
        /// </summary>
        /// <value>Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}}</value>
        [DataMember(Name="responses", EmitDefaultValue=false)]
        public Dictionary<string, DialerResponsesetConfigChangeReaction> Responses { get; set; }



        /// <summary>
        /// When beep detection is enabled, answering machine detection will wait for the beep before transferring the call
        /// </summary>
        /// <value>When beep detection is enabled, answering machine detection will wait for the beep before transferring the call</value>
        [DataMember(Name="beepDetectionEnabled", EmitDefaultValue=false)]
        public bool? BeepDetectionEnabled { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }



        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The UI-visible name of the object
        /// </summary>
        /// <value>The UI-visible name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Creation time of the entity
        /// </summary>
        /// <value>Creation time of the entity</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Last modified time of the entity
        /// </summary>
        /// <value>Last modified time of the entity</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }



        /// <summary>
        /// Gets or Sets GetAdditionalProperties
        /// </summary>
        [DataMember(Name="getAdditionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> GetAdditionalProperties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerResponsesetConfigChangeResponseSet {\n");

            sb.Append("  Responses: ").Append(Responses).Append("\n");
            sb.Append("  BeepDetectionEnabled: ").Append(BeepDetectionEnabled).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  GetAdditionalProperties: ").Append(GetAdditionalProperties).Append("\n");
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
            return this.Equals(obj as DialerResponsesetConfigChangeResponseSet);
        }

        /// <summary>
        /// Returns true if DialerResponsesetConfigChangeResponseSet instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerResponsesetConfigChangeResponseSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerResponsesetConfigChangeResponseSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Responses == other.Responses ||
                    this.Responses != null &&
                    this.Responses.SequenceEqual(other.Responses)
                ) &&
                (
                    this.BeepDetectionEnabled == other.BeepDetectionEnabled ||
                    this.BeepDetectionEnabled != null &&
                    this.BeepDetectionEnabled.Equals(other.BeepDetectionEnabled)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.GetAdditionalProperties == other.GetAdditionalProperties ||
                    this.GetAdditionalProperties != null &&
                    this.GetAdditionalProperties.SequenceEqual(other.GetAdditionalProperties)
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
                if (this.Responses != null)
                    hash = hash * 59 + this.Responses.GetHashCode();

                if (this.BeepDetectionEnabled != null)
                    hash = hash * 59 + this.BeepDetectionEnabled.GetHashCode();

                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.GetAdditionalProperties != null)
                    hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

                return hash;
            }
        }
    }

}
