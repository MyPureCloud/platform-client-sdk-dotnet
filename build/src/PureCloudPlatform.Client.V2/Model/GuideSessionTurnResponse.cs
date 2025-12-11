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
    /// Response for a guide session turn
    /// </summary>
    [DataContract]
    public partial class GuideSessionTurnResponse :  IEquatable<GuideSessionTurnResponse>
    {
        /// <summary>
        /// The status of the turn.
        /// </summary>
        /// <value>The status of the turn.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum InProgress for "IN_PROGRESS"
            /// </summary>
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            
            /// <summary>
            /// Enum Completed for "COMPLETED"
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            Completed,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error
        }
        /// <summary>
        /// The result of the turn.
        /// </summary>
        /// <value>The result of the turn.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ResultEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum SuccessfulCollection for "SUCCESSFUL_COLLECTION"
            /// </summary>
            [EnumMember(Value = "SUCCESSFUL_COLLECTION")]
            SuccessfulCollection,
            
            /// <summary>
            /// Enum ConfirmationRequired for "CONFIRMATION_REQUIRED"
            /// </summary>
            [EnumMember(Value = "CONFIRMATION_REQUIRED")]
            ConfirmationRequired,
            
            /// <summary>
            /// Enum EscalationTriggered for "ESCALATION_TRIGGERED"
            /// </summary>
            [EnumMember(Value = "ESCALATION_TRIGGERED")]
            EscalationTriggered,
            
            /// <summary>
            /// Enum ClientActionRequired for "CLIENT_ACTION_REQUIRED"
            /// </summary>
            [EnumMember(Value = "CLIENT_ACTION_REQUIRED")]
            ClientActionRequired,
            
            /// <summary>
            /// Enum NoMatch for "NO_MATCH"
            /// </summary>
            [EnumMember(Value = "NO_MATCH")]
            NoMatch
        }
        /// <summary>
        /// The status of the turn.
        /// </summary>
        /// <value>The status of the turn.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The result of the turn.
        /// </summary>
        /// <value>The result of the turn.</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public ResultEnum? Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionTurnResponse" /> class.
        /// </summary>
        /// <param name="Response">The response content for this turn..</param>
        /// <param name="Status">The status of the turn..</param>
        /// <param name="Result">The result of the turn..</param>
        /// <param name="OutputVariables">The output variables for this turn..</param>
        /// <param name="InvocationId">Invocation ID for this turn..</param>
        /// <param name="Invocations">The invocations for this turn..</param>
        public GuideSessionTurnResponse(GuideSessionTurnResponseData Response = null, StatusEnum? Status = null, ResultEnum? Result = null, List<GuideSessionVariable> OutputVariables = null, string InvocationId = null, List<GuideSessionTurnInvocationResponse> Invocations = null)
        {
            this.Response = Response;
            this.Status = Status;
            this.Result = Result;
            this.OutputVariables = OutputVariables;
            this.InvocationId = InvocationId;
            this.Invocations = Invocations;
            
        }
        


        /// <summary>
        /// The response content for this turn.
        /// </summary>
        /// <value>The response content for this turn.</value>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public GuideSessionTurnResponseData Response { get; set; }







        /// <summary>
        /// The output variables for this turn.
        /// </summary>
        /// <value>The output variables for this turn.</value>
        [DataMember(Name="outputVariables", EmitDefaultValue=false)]
        public List<GuideSessionVariable> OutputVariables { get; set; }



        /// <summary>
        /// Invocation ID for this turn.
        /// </summary>
        /// <value>Invocation ID for this turn.</value>
        [DataMember(Name="invocationId", EmitDefaultValue=false)]
        public string InvocationId { get; set; }



        /// <summary>
        /// The invocations for this turn.
        /// </summary>
        /// <value>The invocations for this turn.</value>
        [DataMember(Name="invocations", EmitDefaultValue=false)]
        public List<GuideSessionTurnInvocationResponse> Invocations { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuideSessionTurnResponse {\n");

            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  OutputVariables: ").Append(OutputVariables).Append("\n");
            sb.Append("  InvocationId: ").Append(InvocationId).Append("\n");
            sb.Append("  Invocations: ").Append(Invocations).Append("\n");
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
            return this.Equals(obj as GuideSessionTurnResponse);
        }

        /// <summary>
        /// Returns true if GuideSessionTurnResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GuideSessionTurnResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuideSessionTurnResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Response == other.Response ||
                    this.Response != null &&
                    this.Response.Equals(other.Response)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) &&
                (
                    this.OutputVariables == other.OutputVariables ||
                    this.OutputVariables != null &&
                    this.OutputVariables.SequenceEqual(other.OutputVariables)
                ) &&
                (
                    this.InvocationId == other.InvocationId ||
                    this.InvocationId != null &&
                    this.InvocationId.Equals(other.InvocationId)
                ) &&
                (
                    this.Invocations == other.Invocations ||
                    this.Invocations != null &&
                    this.Invocations.SequenceEqual(other.Invocations)
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
                if (this.Response != null)
                    hash = hash * 59 + this.Response.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();

                if (this.OutputVariables != null)
                    hash = hash * 59 + this.OutputVariables.GetHashCode();

                if (this.InvocationId != null)
                    hash = hash * 59 + this.InvocationId.GetHashCode();

                if (this.Invocations != null)
                    hash = hash * 59 + this.Invocations.GetHashCode();

                return hash;
            }
        }
    }

}
