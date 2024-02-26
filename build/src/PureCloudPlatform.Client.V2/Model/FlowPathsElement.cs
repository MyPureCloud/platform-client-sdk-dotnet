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
    /// FlowPathsElement
    /// </summary>
    [DataContract]
    public partial class FlowPathsElement :  IEquatable<FlowPathsElement>
    {
        /// <summary>
        /// Type of the element.
        /// </summary>
        /// <value>Type of the element.</value>
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
            /// Enum Abandoned for "Abandoned"
            /// </summary>
            [EnumMember(Value = "Abandoned")]
            Abandoned,
            
            /// <summary>
            /// Enum Agentescalation for "AgentEscalation"
            /// </summary>
            [EnumMember(Value = "AgentEscalation")]
            Agentescalation,
            
            /// <summary>
            /// Enum Disconnect for "Disconnect"
            /// </summary>
            [EnumMember(Value = "Disconnect")]
            Disconnect,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Exit for "Exit"
            /// </summary>
            [EnumMember(Value = "Exit")]
            Exit,
            
            /// <summary>
            /// Enum Milestone for "Milestone"
            /// </summary>
            [EnumMember(Value = "Milestone")]
            Milestone,
            
            /// <summary>
            /// Enum Outcome for "Outcome"
            /// </summary>
            [EnumMember(Value = "Outcome")]
            Outcome,
            
            /// <summary>
            /// Enum Recognitionfailure for "RecognitionFailure"
            /// </summary>
            [EnumMember(Value = "RecognitionFailure")]
            Recognitionfailure,
            
            /// <summary>
            /// Enum Root for "Root"
            /// </summary>
            [EnumMember(Value = "Root")]
            Root,
            
            /// <summary>
            /// Enum Transfertoacd for "TransferToAcd"
            /// </summary>
            [EnumMember(Value = "TransferToAcd")]
            Transfertoacd
        }
        /// <summary>
        /// The value of the flow outcome, if the element type is Outcome.
        /// </summary>
        /// <value>The value of the flow outcome, if the element type is Outcome.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlowOutcomeValueEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Failure for "FAILURE"
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            Failure,
            
            /// <summary>
            /// Enum Success for "SUCCESS"
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            Success,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        }
        /// <summary>
        /// Type of the element.
        /// </summary>
        /// <value>Type of the element.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The value of the flow outcome, if the element type is Outcome.
        /// </summary>
        /// <value>The value of the flow outcome, if the element type is Outcome.</value>
        [DataMember(Name="flowOutcomeValue", EmitDefaultValue=false)]
        public FlowOutcomeValueEnum? FlowOutcomeValue { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowPathsElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlowPathsElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowPathsElement" /> class.
        /// </summary>
        /// <param name="ParentId">Unique identifier of the parent element. Will be null for the root element..</param>
        /// <param name="Type">Type of the element. (required).</param>
        /// <param name="Count">Count of all journeys that include this element. (required).</param>
        /// <param name="Flows">Details of flows involved in journeys that include this element. (required).</param>
        /// <param name="FlowOutcomeValue">The value of the flow outcome, if the element type is Outcome..</param>
        public FlowPathsElement(string ParentId = null, TypeEnum? Type = null, int? Count = null, List<FlowPathsFlowDetails> Flows = null, FlowOutcomeValueEnum? FlowOutcomeValue = null)
        {
            this.ParentId = ParentId;
            this.Type = Type;
            this.Count = Count;
            this.Flows = Flows;
            this.FlowOutcomeValue = FlowOutcomeValue;
            
        }
        


        /// <summary>
        /// Unique identifier of the parent element. Will be null for the root element.
        /// </summary>
        /// <value>Unique identifier of the parent element. Will be null for the root element.</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public string ParentId { get; set; }





        /// <summary>
        /// Count of all journeys that include this element.
        /// </summary>
        /// <value>Count of all journeys that include this element.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }



        /// <summary>
        /// Details of flows involved in journeys that include this element.
        /// </summary>
        /// <value>Details of flows involved in journeys that include this element.</value>
        [DataMember(Name="flows", EmitDefaultValue=false)]
        public List<FlowPathsFlowDetails> Flows { get; set; }





        /// <summary>
        /// The flow milestone, set if the element type is Milestone.
        /// </summary>
        /// <value>The flow milestone, set if the element type is Milestone.</value>
        [DataMember(Name="flowMilestone", EmitDefaultValue=false)]
        public AddressableEntityRef FlowMilestone { get; private set; }



        /// <summary>
        /// The flow outcome, set if the element type is Outcome or Milestone.
        /// </summary>
        /// <value>The flow outcome, set if the element type is Outcome or Milestone.</value>
        [DataMember(Name="flowOutcome", EmitDefaultValue=false)]
        public AddressableEntityRef FlowOutcome { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowPathsElement {\n");

            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Flows: ").Append(Flows).Append("\n");
            sb.Append("  FlowOutcomeValue: ").Append(FlowOutcomeValue).Append("\n");
            sb.Append("  FlowMilestone: ").Append(FlowMilestone).Append("\n");
            sb.Append("  FlowOutcome: ").Append(FlowOutcome).Append("\n");
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
            return this.Equals(obj as FlowPathsElement);
        }

        /// <summary>
        /// Returns true if FlowPathsElement instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowPathsElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowPathsElement other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) &&
                (
                    this.Flows == other.Flows ||
                    this.Flows != null &&
                    this.Flows.SequenceEqual(other.Flows)
                ) &&
                (
                    this.FlowOutcomeValue == other.FlowOutcomeValue ||
                    this.FlowOutcomeValue != null &&
                    this.FlowOutcomeValue.Equals(other.FlowOutcomeValue)
                ) &&
                (
                    this.FlowMilestone == other.FlowMilestone ||
                    this.FlowMilestone != null &&
                    this.FlowMilestone.Equals(other.FlowMilestone)
                ) &&
                (
                    this.FlowOutcome == other.FlowOutcome ||
                    this.FlowOutcome != null &&
                    this.FlowOutcome.Equals(other.FlowOutcome)
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
                if (this.ParentId != null)
                    hash = hash * 59 + this.ParentId.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                if (this.Flows != null)
                    hash = hash * 59 + this.Flows.GetHashCode();

                if (this.FlowOutcomeValue != null)
                    hash = hash * 59 + this.FlowOutcomeValue.GetHashCode();

                if (this.FlowMilestone != null)
                    hash = hash * 59 + this.FlowMilestone.GetHashCode();

                if (this.FlowOutcome != null)
                    hash = hash * 59 + this.FlowOutcome.GetHashCode();

                return hash;
            }
        }
    }

}
