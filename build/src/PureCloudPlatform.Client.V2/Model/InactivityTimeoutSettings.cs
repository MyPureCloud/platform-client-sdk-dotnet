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
    /// InactivityTimeoutSettings
    /// </summary>
    [DataContract]
    public partial class InactivityTimeoutSettings :  IEquatable<InactivityTimeoutSettings>
    {
        /// <summary>
        /// Action to take when timeout occurs
        /// </summary>
        /// <value>Action to take when timeout occurs</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Disconnect for "DISCONNECT"
            /// </summary>
            [EnumMember(Value = "DISCONNECT")]
            Disconnect,
            
            /// <summary>
            /// Enum SendToArchitectFlow for "SEND_TO_ARCHITECT_FLOW"
            /// </summary>
            [EnumMember(Value = "SEND_TO_ARCHITECT_FLOW")]
            SendToArchitectFlow
        }
        /// <summary>
        /// Action to take when timeout occurs
        /// </summary>
        /// <value>Action to take when timeout occurs</value>
        [DataMember(Name="actionType", EmitDefaultValue=false)]
        public ActionTypeEnum? ActionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InactivityTimeoutSettings" /> class.
        /// </summary>
        /// <param name="TimeoutSeconds">Timeout in seconds for inactivity on the interaction.</param>
        /// <param name="ActionType">Action to take when timeout occurs.</param>
        /// <param name="FlowId">Flow ID for architect flow action.</param>
        public InactivityTimeoutSettings(int? TimeoutSeconds = null, ActionTypeEnum? ActionType = null, DomainEntityRef FlowId = null)
        {
            this.TimeoutSeconds = TimeoutSeconds;
            this.ActionType = ActionType;
            this.FlowId = FlowId;
            
        }
        


        /// <summary>
        /// Timeout in seconds for inactivity on the interaction
        /// </summary>
        /// <value>Timeout in seconds for inactivity on the interaction</value>
        [DataMember(Name="timeoutSeconds", EmitDefaultValue=false)]
        public int? TimeoutSeconds { get; set; }





        /// <summary>
        /// Flow ID for architect flow action
        /// </summary>
        /// <value>Flow ID for architect flow action</value>
        [DataMember(Name="flowId", EmitDefaultValue=false)]
        public DomainEntityRef FlowId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InactivityTimeoutSettings {\n");

            sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
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
            return this.Equals(obj as InactivityTimeoutSettings);
        }

        /// <summary>
        /// Returns true if InactivityTimeoutSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of InactivityTimeoutSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InactivityTimeoutSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeoutSeconds == other.TimeoutSeconds ||
                    this.TimeoutSeconds != null &&
                    this.TimeoutSeconds.Equals(other.TimeoutSeconds)
                ) &&
                (
                    this.ActionType == other.ActionType ||
                    this.ActionType != null &&
                    this.ActionType.Equals(other.ActionType)
                ) &&
                (
                    this.FlowId == other.FlowId ||
                    this.FlowId != null &&
                    this.FlowId.Equals(other.FlowId)
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
                if (this.TimeoutSeconds != null)
                    hash = hash * 59 + this.TimeoutSeconds.GetHashCode();

                if (this.ActionType != null)
                    hash = hash * 59 + this.ActionType.GetHashCode();

                if (this.FlowId != null)
                    hash = hash * 59 + this.FlowId.GetHashCode();

                return hash;
            }
        }
    }

}
