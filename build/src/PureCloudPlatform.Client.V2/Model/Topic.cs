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
    /// Topic
    /// </summary>
    [DataContract]
    public partial class Topic :  IEquatable<Topic>
    {
        /// <summary>
        /// Gets or Sets Strictness
        /// </summary>
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
        /// Gets or Sets MatchingType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MatchingTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Lexical for "Lexical"
            /// </summary>
            [EnumMember(Value = "Lexical")]
            Lexical,
            
            /// <summary>
            /// Enum Semantic for "Semantic"
            /// </summary>
            [EnumMember(Value = "Semantic")]
            Semantic
        }
        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
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
        /// Gets or Sets Strictness
        /// </summary>
        [DataMember(Name="strictness", EmitDefaultValue=false)]
        public StrictnessEnum? Strictness { get; set; }
        /// <summary>
        /// Gets or Sets MatchingType
        /// </summary>
        [DataMember(Name="matchingType", EmitDefaultValue=false)]
        public MatchingTypeEnum? MatchingType { get; set; }
        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public ParticipantsEnum? Participants { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Topic" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Published">Published.</param>
        /// <param name="Strictness">Strictness.</param>
        /// <param name="MatchingType">MatchingType.</param>
        /// <param name="Programs">Programs.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Dialect">Dialect.</param>
        /// <param name="Participants">Participants.</param>
        /// <param name="Phrases">Phrases.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="PublishedBy">PublishedBy.</param>
        /// <param name="DatePublished">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public Topic(string Name = null, string Description = null, bool? Published = null, StrictnessEnum? Strictness = null, MatchingTypeEnum? MatchingType = null, List<BaseProgramEntity> Programs = null, List<string> Tags = null, string Dialect = null, ParticipantsEnum? Participants = null, List<Phrase> Phrases = null, AddressableEntityRef ModifiedBy = null, DateTime? DateModified = null, AddressableEntityRef PublishedBy = null, DateTime? DatePublished = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Published = Published;
            this.Strictness = Strictness;
            this.MatchingType = MatchingType;
            this.Programs = Programs;
            this.Tags = Tags;
            this.Dialect = Dialect;
            this.Participants = Participants;
            this.Phrases = Phrases;
            this.ModifiedBy = ModifiedBy;
            this.DateModified = DateModified;
            this.PublishedBy = PublishedBy;
            this.DatePublished = DatePublished;
            
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
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }







        /// <summary>
        /// Gets or Sets Programs
        /// </summary>
        [DataMember(Name="programs", EmitDefaultValue=false)]
        public List<BaseProgramEntity> Programs { get; set; }



        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// Gets or Sets Dialect
        /// </summary>
        [DataMember(Name="dialect", EmitDefaultValue=false)]
        public string Dialect { get; set; }





        /// <summary>
        /// Gets or Sets Phrases
        /// </summary>
        [DataMember(Name="phrases", EmitDefaultValue=false)]
        public List<Phrase> Phrases { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public AddressableEntityRef ModifiedBy { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// Gets or Sets PublishedBy
        /// </summary>
        [DataMember(Name="publishedBy", EmitDefaultValue=false)]
        public AddressableEntityRef PublishedBy { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="datePublished", EmitDefaultValue=false)]
        public DateTime? DatePublished { get; set; }



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
            sb.Append("class Topic {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Strictness: ").Append(Strictness).Append("\n");
            sb.Append("  MatchingType: ").Append(MatchingType).Append("\n");
            sb.Append("  Programs: ").Append(Programs).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Dialect: ").Append(Dialect).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  Phrases: ").Append(Phrases).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  PublishedBy: ").Append(PublishedBy).Append("\n");
            sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
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
            return this.Equals(obj as Topic);
        }

        /// <summary>
        /// Returns true if Topic instances are equal
        /// </summary>
        /// <param name="other">Instance of Topic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Topic other)
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
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.Strictness == other.Strictness ||
                    this.Strictness != null &&
                    this.Strictness.Equals(other.Strictness)
                ) &&
                (
                    this.MatchingType == other.MatchingType ||
                    this.MatchingType != null &&
                    this.MatchingType.Equals(other.MatchingType)
                ) &&
                (
                    this.Programs == other.Programs ||
                    this.Programs != null &&
                    this.Programs.SequenceEqual(other.Programs)
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
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.PublishedBy == other.PublishedBy ||
                    this.PublishedBy != null &&
                    this.PublishedBy.Equals(other.PublishedBy)
                ) &&
                (
                    this.DatePublished == other.DatePublished ||
                    this.DatePublished != null &&
                    this.DatePublished.Equals(other.DatePublished)
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

                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();

                if (this.Strictness != null)
                    hash = hash * 59 + this.Strictness.GetHashCode();

                if (this.MatchingType != null)
                    hash = hash * 59 + this.MatchingType.GetHashCode();

                if (this.Programs != null)
                    hash = hash * 59 + this.Programs.GetHashCode();

                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();

                if (this.Dialect != null)
                    hash = hash * 59 + this.Dialect.GetHashCode();

                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();

                if (this.Phrases != null)
                    hash = hash * 59 + this.Phrases.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.PublishedBy != null)
                    hash = hash * 59 + this.PublishedBy.GetHashCode();

                if (this.DatePublished != null)
                    hash = hash * 59 + this.DatePublished.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
