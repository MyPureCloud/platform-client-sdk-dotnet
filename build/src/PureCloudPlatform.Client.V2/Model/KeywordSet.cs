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
    /// KeywordSet
    /// </summary>
    [DataContract]
    public partial class KeywordSet :  IEquatable<KeywordSet>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ParticipantPurposes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ParticipantPurposesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Agent for "AGENT"
            /// </summary>
            [EnumMember(Value = "AGENT")]
            Agent,
            
            /// <summary>
            /// Enum Customer for "CUSTOMER"
            /// </summary>
            [EnumMember(Value = "CUSTOMER")]
            Customer
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KeywordSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KeywordSet() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KeywordSet" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Queues">Queues.</param>
        /// <param name="Language">Language code, such as &#39;en-US&#39; (required).</param>
        /// <param name="Agents">Agents.</param>
        /// <param name="Keywords">The list of keywords to be used for keyword spotting. (required).</param>
        /// <param name="ParticipantPurposes">The types of participants to use keyword spotting on. (required).</param>
        public KeywordSet(string Name = null, string Description = null, List<Queue> Queues = null, string Language = null, List<User> Agents = null, List<Keyword> Keywords = null, List<ParticipantPurposesEnum> ParticipantPurposes = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Queues = Queues;
            this.Agents = Agents;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Queues
        /// </summary>
        [DataMember(Name="queues", EmitDefaultValue=false)]
        public List<Queue> Queues { get; set; }
        
        
        
        /// <summary>
        /// Language code, such as &#39;en-US&#39;
        /// </summary>
        /// <value>Language code, such as &#39;en-US&#39;</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Agents
        /// </summary>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public List<User> Agents { get; set; }
        
        
        
        /// <summary>
        /// The list of keywords to be used for keyword spotting.
        /// </summary>
        /// <value>The list of keywords to be used for keyword spotting.</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<Keyword> Keywords { get; set; }
        
        
        
        /// <summary>
        /// The types of participants to use keyword spotting on.
        /// </summary>
        /// <value>The types of participants to use keyword spotting on.</value>
        [DataMember(Name="participantPurposes", EmitDefaultValue=false)]
        public List<ParticipantPurposesEnum> ParticipantPurposes { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeywordSet {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Queues: ").Append(Queues).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Agents: ").Append(Agents).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  ParticipantPurposes: ").Append(ParticipantPurposes).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as KeywordSet);
        }

        /// <summary>
        /// Returns true if KeywordSet instances are equal
        /// </summary>
        /// <param name="other">Instance of KeywordSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeywordSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Queues == other.Queues ||
                    this.Queues != null &&
                    this.Queues.SequenceEqual(other.Queues)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Agents == other.Agents ||
                    this.Agents != null &&
                    this.Agents.SequenceEqual(other.Agents)
                ) &&
                (
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.SequenceEqual(other.Keywords)
                ) &&
                (
                    this.ParticipantPurposes == other.ParticipantPurposes ||
                    this.ParticipantPurposes != null &&
                    this.ParticipantPurposes.SequenceEqual(other.ParticipantPurposes)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Queues != null)
                    hash = hash * 59 + this.Queues.GetHashCode();
                
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                
                if (this.Agents != null)
                    hash = hash * 59 + this.Agents.GetHashCode();
                
                if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();
                
                if (this.ParticipantPurposes != null)
                    hash = hash * 59 + this.ParticipantPurposes.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
