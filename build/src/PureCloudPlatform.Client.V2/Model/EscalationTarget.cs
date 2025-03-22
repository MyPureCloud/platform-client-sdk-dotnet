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
    /// EscalationTarget
    /// </summary>
    [DataContract]
    public partial class EscalationTarget :  IEquatable<EscalationTarget>
    {
        /// <summary>
        /// Defines the target that the message will be escalated to.
        /// </summary>
        /// <value>Defines the target that the message will be escalated to.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TargetTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Conversation for "Conversation"
            /// </summary>
            [EnumMember(Value = "Conversation")]
            Conversation
        }
        /// <summary>
        /// Defines the destination of the escalation.SourceIntegration means use the SocialMedia Source Integration as the destination.OverrideIntegration means the set integration will be used regardless of the source.
        /// </summary>
        /// <value>Defines the destination of the escalation.SourceIntegration means use the SocialMedia Source Integration as the destination.OverrideIntegration means the set integration will be used regardless of the source.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DestinationEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sourceintegration for "SourceIntegration"
            /// </summary>
            [EnumMember(Value = "SourceIntegration")]
            Sourceintegration,
            
            /// <summary>
            /// Enum Overrideintegration for "OverrideIntegration"
            /// </summary>
            [EnumMember(Value = "OverrideIntegration")]
            Overrideintegration
        }
        /// <summary>
        /// Defines the target that the message will be escalated to.
        /// </summary>
        /// <value>Defines the target that the message will be escalated to.</value>
        [DataMember(Name="targetType", EmitDefaultValue=false)]
        public TargetTypeEnum? TargetType { get; set; }
        /// <summary>
        /// Defines the destination of the escalation.SourceIntegration means use the SocialMedia Source Integration as the destination.OverrideIntegration means the set integration will be used regardless of the source.
        /// </summary>
        /// <value>Defines the destination of the escalation.SourceIntegration means use the SocialMedia Source Integration as the destination.OverrideIntegration means the set integration will be used regardless of the source.</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public DestinationEnum? Destination { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EscalationTarget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EscalationTarget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EscalationTarget" /> class.
        /// </summary>
        /// <param name="TargetType">Defines the target that the message will be escalated to. (required).</param>
        /// <param name="Destination">Defines the destination of the escalation.SourceIntegration means use the SocialMedia Source Integration as the destination.OverrideIntegration means the set integration will be used regardless of the source. (required).</param>
        /// <param name="Override">Set the integration ID.Only valid when type is OverrideIntegration..</param>
        public EscalationTarget(TargetTypeEnum? TargetType = null, DestinationEnum? Destination = null, OverrideEscalationTarget Override = null)
        {
            this.TargetType = TargetType;
            this.Destination = Destination;
            this.Override = Override;
            
        }
        






        /// <summary>
        /// Set the integration ID.Only valid when type is OverrideIntegration.
        /// </summary>
        /// <value>Set the integration ID.Only valid when type is OverrideIntegration.</value>
        [DataMember(Name="override", EmitDefaultValue=false)]
        public OverrideEscalationTarget Override { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EscalationTarget {\n");

            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Override: ").Append(Override).Append("\n");
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
            return this.Equals(obj as EscalationTarget);
        }

        /// <summary>
        /// Returns true if EscalationTarget instances are equal
        /// </summary>
        /// <param name="other">Instance of EscalationTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EscalationTarget other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TargetType == other.TargetType ||
                    this.TargetType != null &&
                    this.TargetType.Equals(other.TargetType)
                ) &&
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
                ) &&
                (
                    this.Override == other.Override ||
                    this.Override != null &&
                    this.Override.Equals(other.Override)
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
                if (this.TargetType != null)
                    hash = hash * 59 + this.TargetType.GetHashCode();

                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();

                if (this.Override != null)
                    hash = hash * 59 + this.Override.GetHashCode();

                return hash;
            }
        }
    }

}
