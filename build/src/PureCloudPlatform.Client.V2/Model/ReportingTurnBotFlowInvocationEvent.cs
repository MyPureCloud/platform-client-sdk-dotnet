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
    /// ReportingTurnBotFlowInvocationEvent
    /// </summary>
    [DataContract]
    public partial class ReportingTurnBotFlowInvocationEvent :  IEquatable<ReportingTurnBotFlowInvocationEvent>
    {
        /// <summary>
        /// Represents the type of invocation event which occurred.
        /// </summary>
        /// <value>Represents the type of invocation event which occurred.</value>
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
            /// Enum Call for "Call"
            /// </summary>
            [EnumMember(Value = "Call")]
            Call,
            
            /// <summary>
            /// Enum Returnto for "ReturnTo"
            /// </summary>
            [EnumMember(Value = "ReturnTo")]
            Returnto,
            
            /// <summary>
            /// Enum Returnfrom for "ReturnFrom"
            /// </summary>
            [EnumMember(Value = "ReturnFrom")]
            Returnfrom,
            
            /// <summary>
            /// Enum Initialinvoke for "InitialInvoke"
            /// </summary>
            [EnumMember(Value = "InitialInvoke")]
            Initialinvoke
        }
        /// <summary>
        /// Represents the type of invocation event which occurred.
        /// </summary>
        /// <value>Represents the type of invocation event which occurred.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingTurnBotFlowInvocationEvent" /> class.
        /// </summary>
        /// <param name="Type">Represents the type of invocation event which occurred..</param>
        /// <param name="Action">The action in which the event occurred..</param>
        /// <param name="Flow">The details relating to the invoking or invoked flow..</param>
        public ReportingTurnBotFlowInvocationEvent(TypeEnum? Type = null, ReportingTurnAction Action = null, ReportingTurnFlow Flow = null)
        {
            this.Type = Type;
            this.Action = Action;
            this.Flow = Flow;
            
        }
        




        /// <summary>
        /// The action in which the event occurred.
        /// </summary>
        /// <value>The action in which the event occurred.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ReportingTurnAction Action { get; set; }



        /// <summary>
        /// The details relating to the invoking or invoked flow.
        /// </summary>
        /// <value>The details relating to the invoking or invoked flow.</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public ReportingTurnFlow Flow { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingTurnBotFlowInvocationEvent {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
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
            return this.Equals(obj as ReportingTurnBotFlowInvocationEvent);
        }

        /// <summary>
        /// Returns true if ReportingTurnBotFlowInvocationEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingTurnBotFlowInvocationEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingTurnBotFlowInvocationEvent other)
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
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
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

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();

                return hash;
            }
        }
    }

}
