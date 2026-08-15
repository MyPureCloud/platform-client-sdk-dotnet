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
    /// A rule that detects repeated user or agent messages and adds a corrective instruction.
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentRepetitionCheck :  IEquatable<AgenticVirtualAgentRepetitionCheck>
    {
        /// <summary>
        /// Whether this check looks for repetition in user messages or agent responses.
        /// </summary>
        /// <value>Whether this check looks for repetition in user messages or agent responses.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum Agent for "Agent"
            /// </summary>
            [EnumMember(Value = "Agent")]
            Agent
        }
        /// <summary>
        /// The similarity category compared to the Levenshtein result that triggers this check's instruction.
        /// </summary>
        /// <value>The similarity category compared to the Levenshtein result that triggers this check's instruction.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SimilarityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Loose for "Loose"
            /// </summary>
            [EnumMember(Value = "Loose")]
            Loose,
            
            /// <summary>
            /// Enum Moderate for "Moderate"
            /// </summary>
            [EnumMember(Value = "Moderate")]
            Moderate,
            
            /// <summary>
            /// Enum Strict for "Strict"
            /// </summary>
            [EnumMember(Value = "Strict")]
            Strict,
            
            /// <summary>
            /// Enum Verystrict for "VeryStrict"
            /// </summary>
            [EnumMember(Value = "VeryStrict")]
            Verystrict
        }
        /// <summary>
        /// Whether this check looks for repetition in user messages or agent responses.
        /// </summary>
        /// <value>Whether this check looks for repetition in user messages or agent responses.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The similarity category compared to the Levenshtein result that triggers this check's instruction.
        /// </summary>
        /// <value>The similarity category compared to the Levenshtein result that triggers this check's instruction.</value>
        [DataMember(Name="similarity", EmitDefaultValue=false)]
        public SimilarityEnum? Similarity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentRepetitionCheck" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgenticVirtualAgentRepetitionCheck() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentRepetitionCheck" /> class.
        /// </summary>
        /// <param name="Type">Whether this check looks for repetition in user messages or agent responses. (required).</param>
        /// <param name="Messages">The number of prior messages of the specified type to compare for repetition. (required).</param>
        /// <param name="Similarity">The similarity category compared to the Levenshtein result that triggers this check&#39;s instruction. (required).</param>
        /// <param name="Instruction">The instruction added to the virtual agent&#39;s turn when message similarity matches the configured category. (required).</param>
        public AgenticVirtualAgentRepetitionCheck(TypeEnum? Type = null, int? Messages = null, SimilarityEnum? Similarity = null, string Instruction = null)
        {
            this.Type = Type;
            this.Messages = Messages;
            this.Similarity = Similarity;
            this.Instruction = Instruction;
            
        }
        




        /// <summary>
        /// The number of prior messages of the specified type to compare for repetition.
        /// </summary>
        /// <value>The number of prior messages of the specified type to compare for repetition.</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public int? Messages { get; set; }





        /// <summary>
        /// The instruction added to the virtual agent&#39;s turn when message similarity matches the configured category.
        /// </summary>
        /// <value>The instruction added to the virtual agent&#39;s turn when message similarity matches the configured category.</value>
        [DataMember(Name="instruction", EmitDefaultValue=false)]
        public string Instruction { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentRepetitionCheck {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Similarity: ").Append(Similarity).Append("\n");
            sb.Append("  Instruction: ").Append(Instruction).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentRepetitionCheck);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentRepetitionCheck instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentRepetitionCheck to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentRepetitionCheck other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.Equals(other.Messages)
                ) &&
                (
                    this.Similarity == other.Similarity ||
                    this.Similarity != null &&
                    this.Similarity.Equals(other.Similarity)
                ) &&
                (
                    this.Instruction == other.Instruction ||
                    this.Instruction != null &&
                    this.Instruction.Equals(other.Instruction)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();

                if (this.Similarity != null)
                    hash = hash * 59 + this.Similarity.GetHashCode();

                if (this.Instruction != null)
                    hash = hash * 59 + this.Instruction.GetHashCode();

                return hash;
            }
        }
    }

}
