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
    /// Settings for a next-action of disconnecting, including the reason code for the disconnect.
    /// </summary>
    [DataContract]
    public partial class TextBotDisconnectAction :  IEquatable<TextBotDisconnectAction>
    {
        
        
        /// <summary>
        /// The reason for the disconnect.
        /// </summary>
        /// <value>The reason for the disconnect.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Triggeredbyuser for "TriggeredByUser"
            /// </summary>
            [EnumMember(Value = "TriggeredByUser")]
            Triggeredbyuser,
            
            /// <summary>
            /// Enum Triggeredbyflow for "TriggeredByFlow"
            /// </summary>
            [EnumMember(Value = "TriggeredByFlow")]
            Triggeredbyflow,
            
            /// <summary>
            /// Enum Sessionexpired for "SessionExpired"
            /// </summary>
            [EnumMember(Value = "SessionExpired")]
            Sessionexpired,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Recognitionfailure for "RecognitionFailure"
            /// </summary>
            [EnumMember(Value = "RecognitionFailure")]
            Recognitionfailure
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The reason for the disconnect.
        /// </summary>
        /// <value>The reason for the disconnect.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotDisconnectAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextBotDisconnectAction() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotDisconnectAction" /> class.
        /// </summary>
        /// <param name="Reason">The reason for the disconnect. (required).</param>
        /// <param name="ReasonExtendedInfo">Extended information related to the reason, if available..</param>
        /// <param name="FlowLocation">Describes where in the Bot Flow the user was when the disconnect occurred..</param>
        /// <param name="FlowOutcomes">The list of Flow Outcomes for the bot flow and their details..</param>
        public TextBotDisconnectAction(ReasonEnum? Reason = null, string ReasonExtendedInfo = null, TextBotFlowLocation FlowLocation = null, List<TextBotFlowOutcome> FlowOutcomes = null)
        {
            this.Reason = Reason;
            this.ReasonExtendedInfo = ReasonExtendedInfo;
            this.FlowLocation = FlowLocation;
            this.FlowOutcomes = FlowOutcomes;
            
        }
        
        
        
        
        
        /// <summary>
        /// Extended information related to the reason, if available.
        /// </summary>
        /// <value>Extended information related to the reason, if available.</value>
        [DataMember(Name="reasonExtendedInfo", EmitDefaultValue=false)]
        public string ReasonExtendedInfo { get; set; }
        
        
        
        /// <summary>
        /// Describes where in the Bot Flow the user was when the disconnect occurred.
        /// </summary>
        /// <value>Describes where in the Bot Flow the user was when the disconnect occurred.</value>
        [DataMember(Name="flowLocation", EmitDefaultValue=false)]
        public TextBotFlowLocation FlowLocation { get; set; }
        
        
        
        /// <summary>
        /// The list of Flow Outcomes for the bot flow and their details.
        /// </summary>
        /// <value>The list of Flow Outcomes for the bot flow and their details.</value>
        [DataMember(Name="flowOutcomes", EmitDefaultValue=false)]
        public List<TextBotFlowOutcome> FlowOutcomes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextBotDisconnectAction {\n");
            
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ReasonExtendedInfo: ").Append(ReasonExtendedInfo).Append("\n");
            sb.Append("  FlowLocation: ").Append(FlowLocation).Append("\n");
            sb.Append("  FlowOutcomes: ").Append(FlowOutcomes).Append("\n");
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
            return this.Equals(obj as TextBotDisconnectAction);
        }

        /// <summary>
        /// Returns true if TextBotDisconnectAction instances are equal
        /// </summary>
        /// <param name="other">Instance of TextBotDisconnectAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextBotDisconnectAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) &&
                (
                    this.ReasonExtendedInfo == other.ReasonExtendedInfo ||
                    this.ReasonExtendedInfo != null &&
                    this.ReasonExtendedInfo.Equals(other.ReasonExtendedInfo)
                ) &&
                (
                    this.FlowLocation == other.FlowLocation ||
                    this.FlowLocation != null &&
                    this.FlowLocation.Equals(other.FlowLocation)
                ) &&
                (
                    this.FlowOutcomes == other.FlowOutcomes ||
                    this.FlowOutcomes != null &&
                    this.FlowOutcomes.SequenceEqual(other.FlowOutcomes)
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
                
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                
                if (this.ReasonExtendedInfo != null)
                    hash = hash * 59 + this.ReasonExtendedInfo.GetHashCode();
                
                if (this.FlowLocation != null)
                    hash = hash * 59 + this.FlowLocation.GetHashCode();
                
                if (this.FlowOutcomes != null)
                    hash = hash * 59 + this.FlowOutcomes.GetHashCode();
                
                return hash;
            }
        }
    }

}
