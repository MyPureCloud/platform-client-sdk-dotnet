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
    /// Annotation
    /// </summary>
    [DataContract]
    public partial class Annotation :  IEquatable<Annotation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Annotation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Location">Offset of annotation in milliseconds..</param>
        /// <param name="DurationMs">Duration of annotation in milliseconds..</param>
        /// <param name="User">User that created this annotation (if any)..</param>
        /// <param name="Description">Text of annotation..</param>
        /// <param name="KeywordName">The word or phrase which is being looked for with speech recognition..</param>
        /// <param name="Confidence">Actual confidence that this is an accurate match..</param>
        /// <param name="KeywordSetId">A unique identifier for the keyword set to which this spotted keyword belongs..</param>
        /// <param name="KeywordSetName">The keyword set to which this spotted keyword belongs..</param>
        /// <param name="Utterance">The phonetic spellings for the phrase and alternate spellings..</param>
        /// <param name="TimeBegin">Beginning time offset of the keyword spot match..</param>
        /// <param name="TimeEnd">Ending time offset of the keyword spot match..</param>
        /// <param name="KeywordConfidenceThreshold">Configured sensitivity threshold that can be increased to lower false positives or decreased to reduce false negatives..</param>
        /// <param name="AgentScoreModifier">A modifier to the evaluation score when the phrase is spotted in the agent channel. (required).</param>
        /// <param name="CustomerScoreModifier">A modifier to the evaluation score when the phrase is spotted in the customer channel. (required).</param>
        public Annotation(string Name = null, string Type = null, long? Location = null, long? DurationMs = null, User User = null, string Description = null, string KeywordName = null, float? Confidence = null, string KeywordSetId = null, string KeywordSetName = null, string Utterance = null, string TimeBegin = null, string TimeEnd = null, string KeywordConfidenceThreshold = null, string AgentScoreModifier = null, string CustomerScoreModifier = null)
        {
            // to ensure "AgentScoreModifier" is required (not null)
            if (AgentScoreModifier == null)
            {
                throw new InvalidDataException("AgentScoreModifier is a required property for Annotation and cannot be null");
            }
            else
            {
                this.AgentScoreModifier = AgentScoreModifier;
            }
            // to ensure "CustomerScoreModifier" is required (not null)
            if (CustomerScoreModifier == null)
            {
                throw new InvalidDataException("CustomerScoreModifier is a required property for Annotation and cannot be null");
            }
            else
            {
                this.CustomerScoreModifier = CustomerScoreModifier;
            }
            this.Name = Name;
            this.Type = Type;
            this.Location = Location;
            this.DurationMs = DurationMs;
            this.User = User;
            this.Description = Description;
            this.KeywordName = KeywordName;
            this.Confidence = Confidence;
            this.KeywordSetId = KeywordSetId;
            this.KeywordSetName = KeywordSetName;
            this.Utterance = Utterance;
            this.TimeBegin = TimeBegin;
            this.TimeEnd = TimeEnd;
            this.KeywordConfidenceThreshold = KeywordConfidenceThreshold;
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
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Offset of annotation in milliseconds.
        /// </summary>
        /// <value>Offset of annotation in milliseconds.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public long? Location { get; set; }
        /// <summary>
        /// Duration of annotation in milliseconds.
        /// </summary>
        /// <value>Duration of annotation in milliseconds.</value>
        [DataMember(Name="durationMs", EmitDefaultValue=false)]
        public long? DurationMs { get; set; }
        /// <summary>
        /// User that created this annotation (if any).
        /// </summary>
        /// <value>User that created this annotation (if any).</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        /// <summary>
        /// Text of annotation.
        /// </summary>
        /// <value>Text of annotation.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The word or phrase which is being looked for with speech recognition.
        /// </summary>
        /// <value>The word or phrase which is being looked for with speech recognition.</value>
        [DataMember(Name="keywordName", EmitDefaultValue=false)]
        public string KeywordName { get; set; }
        /// <summary>
        /// Actual confidence that this is an accurate match.
        /// </summary>
        /// <value>Actual confidence that this is an accurate match.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public float? Confidence { get; set; }
        /// <summary>
        /// A unique identifier for the keyword set to which this spotted keyword belongs.
        /// </summary>
        /// <value>A unique identifier for the keyword set to which this spotted keyword belongs.</value>
        [DataMember(Name="keywordSetId", EmitDefaultValue=false)]
        public string KeywordSetId { get; set; }
        /// <summary>
        /// The keyword set to which this spotted keyword belongs.
        /// </summary>
        /// <value>The keyword set to which this spotted keyword belongs.</value>
        [DataMember(Name="keywordSetName", EmitDefaultValue=false)]
        public string KeywordSetName { get; set; }
        /// <summary>
        /// The phonetic spellings for the phrase and alternate spellings.
        /// </summary>
        /// <value>The phonetic spellings for the phrase and alternate spellings.</value>
        [DataMember(Name="utterance", EmitDefaultValue=false)]
        public string Utterance { get; set; }
        /// <summary>
        /// Beginning time offset of the keyword spot match.
        /// </summary>
        /// <value>Beginning time offset of the keyword spot match.</value>
        [DataMember(Name="timeBegin", EmitDefaultValue=false)]
        public string TimeBegin { get; set; }
        /// <summary>
        /// Ending time offset of the keyword spot match.
        /// </summary>
        /// <value>Ending time offset of the keyword spot match.</value>
        [DataMember(Name="timeEnd", EmitDefaultValue=false)]
        public string TimeEnd { get; set; }
        /// <summary>
        /// Configured sensitivity threshold that can be increased to lower false positives or decreased to reduce false negatives.
        /// </summary>
        /// <value>Configured sensitivity threshold that can be increased to lower false positives or decreased to reduce false negatives.</value>
        [DataMember(Name="keywordConfidenceThreshold", EmitDefaultValue=false)]
        public string KeywordConfidenceThreshold { get; set; }
        /// <summary>
        /// A modifier to the evaluation score when the phrase is spotted in the agent channel.
        /// </summary>
        /// <value>A modifier to the evaluation score when the phrase is spotted in the agent channel.</value>
        [DataMember(Name="agentScoreModifier", EmitDefaultValue=false)]
        public string AgentScoreModifier { get; set; }
        /// <summary>
        /// A modifier to the evaluation score when the phrase is spotted in the customer channel.
        /// </summary>
        /// <value>A modifier to the evaluation score when the phrase is spotted in the customer channel.</value>
        [DataMember(Name="customerScoreModifier", EmitDefaultValue=false)]
        public string CustomerScoreModifier { get; set; }
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
            sb.Append("class Annotation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  KeywordName: ").Append(KeywordName).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  KeywordSetId: ").Append(KeywordSetId).Append("\n");
            sb.Append("  KeywordSetName: ").Append(KeywordSetName).Append("\n");
            sb.Append("  Utterance: ").Append(Utterance).Append("\n");
            sb.Append("  TimeBegin: ").Append(TimeBegin).Append("\n");
            sb.Append("  TimeEnd: ").Append(TimeEnd).Append("\n");
            sb.Append("  KeywordConfidenceThreshold: ").Append(KeywordConfidenceThreshold).Append("\n");
            sb.Append("  AgentScoreModifier: ").Append(AgentScoreModifier).Append("\n");
            sb.Append("  CustomerScoreModifier: ").Append(CustomerScoreModifier).Append("\n");
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
            return this.Equals(obj as Annotation);
        }

        /// <summary>
        /// Returns true if Annotation instances are equal
        /// </summary>
        /// <param name="other">Instance of Annotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Annotation other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) &&
                (
                    this.DurationMs == other.DurationMs ||
                    this.DurationMs != null &&
                    this.DurationMs.Equals(other.DurationMs)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.KeywordName == other.KeywordName ||
                    this.KeywordName != null &&
                    this.KeywordName.Equals(other.KeywordName)
                ) &&
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
                ) &&
                (
                    this.KeywordSetId == other.KeywordSetId ||
                    this.KeywordSetId != null &&
                    this.KeywordSetId.Equals(other.KeywordSetId)
                ) &&
                (
                    this.KeywordSetName == other.KeywordSetName ||
                    this.KeywordSetName != null &&
                    this.KeywordSetName.Equals(other.KeywordSetName)
                ) &&
                (
                    this.Utterance == other.Utterance ||
                    this.Utterance != null &&
                    this.Utterance.Equals(other.Utterance)
                ) &&
                (
                    this.TimeBegin == other.TimeBegin ||
                    this.TimeBegin != null &&
                    this.TimeBegin.Equals(other.TimeBegin)
                ) &&
                (
                    this.TimeEnd == other.TimeEnd ||
                    this.TimeEnd != null &&
                    this.TimeEnd.Equals(other.TimeEnd)
                ) &&
                (
                    this.KeywordConfidenceThreshold == other.KeywordConfidenceThreshold ||
                    this.KeywordConfidenceThreshold != null &&
                    this.KeywordConfidenceThreshold.Equals(other.KeywordConfidenceThreshold)
                ) &&
                (
                    this.AgentScoreModifier == other.AgentScoreModifier ||
                    this.AgentScoreModifier != null &&
                    this.AgentScoreModifier.Equals(other.AgentScoreModifier)
                ) &&
                (
                    this.CustomerScoreModifier == other.CustomerScoreModifier ||
                    this.CustomerScoreModifier != null &&
                    this.CustomerScoreModifier.Equals(other.CustomerScoreModifier)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.DurationMs != null)
                    hash = hash * 59 + this.DurationMs.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.KeywordName != null)
                    hash = hash * 59 + this.KeywordName.GetHashCode();
                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();
                if (this.KeywordSetId != null)
                    hash = hash * 59 + this.KeywordSetId.GetHashCode();
                if (this.KeywordSetName != null)
                    hash = hash * 59 + this.KeywordSetName.GetHashCode();
                if (this.Utterance != null)
                    hash = hash * 59 + this.Utterance.GetHashCode();
                if (this.TimeBegin != null)
                    hash = hash * 59 + this.TimeBegin.GetHashCode();
                if (this.TimeEnd != null)
                    hash = hash * 59 + this.TimeEnd.GetHashCode();
                if (this.KeywordConfidenceThreshold != null)
                    hash = hash * 59 + this.KeywordConfidenceThreshold.GetHashCode();
                if (this.AgentScoreModifier != null)
                    hash = hash * 59 + this.AgentScoreModifier.GetHashCode();
                if (this.CustomerScoreModifier != null)
                    hash = hash * 59 + this.CustomerScoreModifier.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
