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
    /// Information related to a success bot flow turn request.
    /// </summary>
    [DataContract]
    public partial class TextBotFlowTurnResponse :  IEquatable<TextBotFlowTurnResponse>
    {
        /// <summary>
        /// Indicates the suggested next action. If appropriate, the matching output event object includes additional information.
        /// </summary>
        /// <value>Indicates the suggested next action. If appropriate, the matching output event object includes additional information.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NextActionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Noop for "NoOp"
            /// </summary>
            [EnumMember(Value = "NoOp")]
            Noop,
            
            /// <summary>
            /// Enum Disconnect for "Disconnect"
            /// </summary>
            [EnumMember(Value = "Disconnect")]
            Disconnect,
            
            /// <summary>
            /// Enum Waitforinput for "WaitForInput"
            /// </summary>
            [EnumMember(Value = "WaitForInput")]
            Waitforinput,
            
            /// <summary>
            /// Enum Exit for "Exit"
            /// </summary>
            [EnumMember(Value = "Exit")]
            Exit
        }
        /// <summary>
        /// Indicates the suggested next action. If appropriate, the matching output event object includes additional information.
        /// </summary>
        /// <value>Indicates the suggested next action. If appropriate, the matching output event object includes additional information.</value>
        [DataMember(Name="nextActionType", EmitDefaultValue=false)]
        public NextActionTypeEnum? NextActionType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotFlowTurnResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextBotFlowTurnResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotFlowTurnResponse" /> class.
        /// </summary>
        /// <param name="Id">The ID of the bot flow turn. If additional turns are needed, supply this ID as the previous turn in your next turn request. (required).</param>
        /// <param name="PreviousTurn">The reference to a previous turn, if applicable..</param>
        /// <param name="Prompts">The output prompts for this turn..</param>
        /// <param name="NextActionType">Indicates the suggested next action. If appropriate, the matching output event object includes additional information. (required).</param>
        /// <param name="NextActionDisconnect">The next action directive for this turn if it is a Disconnect type..</param>
        /// <param name="NextActionWaitForInput">The next action directive for this turn if it is a WaitForInput type..</param>
        /// <param name="NextActionExit">The next action directive for this turn if it is an Exit type..</param>
        public TextBotFlowTurnResponse(string Id = null, TextBotTurnReference PreviousTurn = null, TextBotOutputPrompts Prompts = null, NextActionTypeEnum? NextActionType = null, TextBotDisconnectAction NextActionDisconnect = null, TextBotWaitForInputAction NextActionWaitForInput = null, TextBotExitAction NextActionExit = null)
        {
            this.Id = Id;
            this.PreviousTurn = PreviousTurn;
            this.Prompts = Prompts;
            this.NextActionType = NextActionType;
            this.NextActionDisconnect = NextActionDisconnect;
            this.NextActionWaitForInput = NextActionWaitForInput;
            this.NextActionExit = NextActionExit;
            
        }
        


        /// <summary>
        /// The ID of the bot flow turn. If additional turns are needed, supply this ID as the previous turn in your next turn request.
        /// </summary>
        /// <value>The ID of the bot flow turn. If additional turns are needed, supply this ID as the previous turn in your next turn request.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The reference to a previous turn, if applicable.
        /// </summary>
        /// <value>The reference to a previous turn, if applicable.</value>
        [DataMember(Name="previousTurn", EmitDefaultValue=false)]
        public TextBotTurnReference PreviousTurn { get; set; }



        /// <summary>
        /// The output prompts for this turn.
        /// </summary>
        /// <value>The output prompts for this turn.</value>
        [DataMember(Name="prompts", EmitDefaultValue=false)]
        public TextBotOutputPrompts Prompts { get; set; }





        /// <summary>
        /// The next action directive for this turn if it is a Disconnect type.
        /// </summary>
        /// <value>The next action directive for this turn if it is a Disconnect type.</value>
        [DataMember(Name="nextActionDisconnect", EmitDefaultValue=false)]
        public TextBotDisconnectAction NextActionDisconnect { get; set; }



        /// <summary>
        /// The next action directive for this turn if it is a WaitForInput type.
        /// </summary>
        /// <value>The next action directive for this turn if it is a WaitForInput type.</value>
        [DataMember(Name="nextActionWaitForInput", EmitDefaultValue=false)]
        public TextBotWaitForInputAction NextActionWaitForInput { get; set; }



        /// <summary>
        /// The next action directive for this turn if it is an Exit type.
        /// </summary>
        /// <value>The next action directive for this turn if it is an Exit type.</value>
        [DataMember(Name="nextActionExit", EmitDefaultValue=false)]
        public TextBotExitAction NextActionExit { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextBotFlowTurnResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PreviousTurn: ").Append(PreviousTurn).Append("\n");
            sb.Append("  Prompts: ").Append(Prompts).Append("\n");
            sb.Append("  NextActionType: ").Append(NextActionType).Append("\n");
            sb.Append("  NextActionDisconnect: ").Append(NextActionDisconnect).Append("\n");
            sb.Append("  NextActionWaitForInput: ").Append(NextActionWaitForInput).Append("\n");
            sb.Append("  NextActionExit: ").Append(NextActionExit).Append("\n");
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
            return this.Equals(obj as TextBotFlowTurnResponse);
        }

        /// <summary>
        /// Returns true if TextBotFlowTurnResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TextBotFlowTurnResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextBotFlowTurnResponse other)
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
                    this.PreviousTurn == other.PreviousTurn ||
                    this.PreviousTurn != null &&
                    this.PreviousTurn.Equals(other.PreviousTurn)
                ) &&
                (
                    this.Prompts == other.Prompts ||
                    this.Prompts != null &&
                    this.Prompts.Equals(other.Prompts)
                ) &&
                (
                    this.NextActionType == other.NextActionType ||
                    this.NextActionType != null &&
                    this.NextActionType.Equals(other.NextActionType)
                ) &&
                (
                    this.NextActionDisconnect == other.NextActionDisconnect ||
                    this.NextActionDisconnect != null &&
                    this.NextActionDisconnect.Equals(other.NextActionDisconnect)
                ) &&
                (
                    this.NextActionWaitForInput == other.NextActionWaitForInput ||
                    this.NextActionWaitForInput != null &&
                    this.NextActionWaitForInput.Equals(other.NextActionWaitForInput)
                ) &&
                (
                    this.NextActionExit == other.NextActionExit ||
                    this.NextActionExit != null &&
                    this.NextActionExit.Equals(other.NextActionExit)
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

                if (this.PreviousTurn != null)
                    hash = hash * 59 + this.PreviousTurn.GetHashCode();

                if (this.Prompts != null)
                    hash = hash * 59 + this.Prompts.GetHashCode();

                if (this.NextActionType != null)
                    hash = hash * 59 + this.NextActionType.GetHashCode();

                if (this.NextActionDisconnect != null)
                    hash = hash * 59 + this.NextActionDisconnect.GetHashCode();

                if (this.NextActionWaitForInput != null)
                    hash = hash * 59 + this.NextActionWaitForInput.GetHashCode();

                if (this.NextActionExit != null)
                    hash = hash * 59 + this.NextActionExit.GetHashCode();

                return hash;
            }
        }
    }

}
