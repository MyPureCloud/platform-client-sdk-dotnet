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
    /// TopicRequest
    /// </summary>
    [DataContract]
    public partial class TopicRequest :  IEquatable<TopicRequest>
    {
        /// <summary>
        /// The topic strictness, default value is 72
        /// </summary>
        /// <value>The topic strictness, default value is 72</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StrictnessEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum _1 for "1"
            /// </summary>
            [EnumMember(Value = "1")]
            _1,
            
            /// <summary>
            /// Enum _55 for "55"
            /// </summary>
            [EnumMember(Value = "55")]
            _55,
            
            /// <summary>
            /// Enum _65 for "65"
            /// </summary>
            [EnumMember(Value = "65")]
            _65,
            
            /// <summary>
            /// Enum _72 for "72"
            /// </summary>
            [EnumMember(Value = "72")]
            _72,
            
            /// <summary>
            /// Enum _85 for "85"
            /// </summary>
            [EnumMember(Value = "85")]
            _85,
            
            /// <summary>
            /// Enum _90 for "90"
            /// </summary>
            [EnumMember(Value = "90")]
            _90
        }
        /// <summary>
        /// The topic participants, default value is All
        /// </summary>
        /// <value>The topic participants, default value is All</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ParticipantsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum External for "External"
            /// </summary>
            [EnumMember(Value = "External")]
            External,
            
            /// <summary>
            /// Enum Internal for "Internal"
            /// </summary>
            [EnumMember(Value = "Internal")]
            Internal,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All
        }
        /// <summary>
        /// The topic strictness, default value is 72
        /// </summary>
        /// <value>The topic strictness, default value is 72</value>
        [DataMember(Name="strictness", EmitDefaultValue=false)]
        public StrictnessEnum? Strictness { get; set; }
        /// <summary>
        /// The topic participants, default value is All
        /// </summary>
        /// <value>The topic participants, default value is All</value>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public ParticipantsEnum? Participants { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TopicRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TopicRequest" /> class.
        /// </summary>
        /// <param name="Name">The topic name (required).</param>
        /// <param name="Description">The topic description.</param>
        /// <param name="Strictness">The topic strictness, default value is 72.</param>
        /// <param name="ProgramIds">The ids of programs associated to the topic.</param>
        /// <param name="Tags">The topic tags.</param>
        /// <param name="Dialect">The topic dialect (required).</param>
        /// <param name="Participants">The topic participants, default value is All.</param>
        /// <param name="Phrases">The topic phrases.</param>
        public TopicRequest(string Name = null, string Description = null, StrictnessEnum? Strictness = null, List<string> ProgramIds = null, List<string> Tags = null, string Dialect = null, ParticipantsEnum? Participants = null, List<Phrase> Phrases = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Strictness = Strictness;
            this.ProgramIds = ProgramIds;
            this.Tags = Tags;
            this.Dialect = Dialect;
            this.Participants = Participants;
            this.Phrases = Phrases;
            
        }
        


        /// <summary>
        /// The topic name
        /// </summary>
        /// <value>The topic name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The topic description
        /// </summary>
        /// <value>The topic description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }





        /// <summary>
        /// The ids of programs associated to the topic
        /// </summary>
        /// <value>The ids of programs associated to the topic</value>
        [DataMember(Name="programIds", EmitDefaultValue=false)]
        public List<string> ProgramIds { get; set; }



        /// <summary>
        /// The topic tags
        /// </summary>
        /// <value>The topic tags</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// The topic dialect
        /// </summary>
        /// <value>The topic dialect</value>
        [DataMember(Name="dialect", EmitDefaultValue=false)]
        public string Dialect { get; set; }





        /// <summary>
        /// The topic phrases
        /// </summary>
        /// <value>The topic phrases</value>
        [DataMember(Name="phrases", EmitDefaultValue=false)]
        public List<Phrase> Phrases { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Strictness: ").Append(Strictness).Append("\n");
            sb.Append("  ProgramIds: ").Append(ProgramIds).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Dialect: ").Append(Dialect).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  Phrases: ").Append(Phrases).Append("\n");
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
            return this.Equals(obj as TopicRequest);
        }

        /// <summary>
        /// Returns true if TopicRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TopicRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopicRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Strictness == other.Strictness ||
                    this.Strictness != null &&
                    this.Strictness.Equals(other.Strictness)
                ) &&
                (
                    this.ProgramIds == other.ProgramIds ||
                    this.ProgramIds != null &&
                    this.ProgramIds.SequenceEqual(other.ProgramIds)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.Dialect == other.Dialect ||
                    this.Dialect != null &&
                    this.Dialect.Equals(other.Dialect)
                ) &&
                (
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.Equals(other.Participants)
                ) &&
                (
                    this.Phrases == other.Phrases ||
                    this.Phrases != null &&
                    this.Phrases.SequenceEqual(other.Phrases)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Strictness != null)
                    hash = hash * 59 + this.Strictness.GetHashCode();

                if (this.ProgramIds != null)
                    hash = hash * 59 + this.ProgramIds.GetHashCode();

                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();

                if (this.Dialect != null)
                    hash = hash * 59 + this.Dialect.GetHashCode();

                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();

                if (this.Phrases != null)
                    hash = hash * 59 + this.Phrases.GetHashCode();

                return hash;
            }
        }
    }

}
