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
    /// V2WfmContinuousForecastSessionEventContinuousForecastSessionNotification
    /// </summary>
    [DataContract]
    public partial class V2WfmContinuousForecastSessionEventContinuousForecastSessionNotification :  IEquatable<V2WfmContinuousForecastSessionEventContinuousForecastSessionNotification>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Cancelled for "Cancelled"
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled
        }
        /// <summary>
        /// Gets or Sets ForecastDataState
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ForecastDataStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Current for "Current"
            /// </summary>
            [EnumMember(Value = "Current")]
            Current,
            
            /// <summary>
            /// Enum Stale for "Stale"
            /// </summary>
            [EnumMember(Value = "Stale")]
            Stale,
            
            /// <summary>
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing
        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Gets or Sets ForecastDataState
        /// </summary>
        [DataMember(Name="forecastDataState", EmitDefaultValue=false)]
        public ForecastDataStateEnum? ForecastDataState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2WfmContinuousForecastSessionEventContinuousForecastSessionNotification" /> class.
        /// </summary>
        /// <param name="SessionId">SessionId.</param>
        /// <param name="LastSuccessfulSessionId">LastSuccessfulSessionId.</param>
        /// <param name="State">State.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="ForecastDataState">ForecastDataState.</param>
        public V2WfmContinuousForecastSessionEventContinuousForecastSessionNotification(string SessionId = null, string LastSuccessfulSessionId = null, StateEnum? State = null, string ErrorCode = null, ForecastDataStateEnum? ForecastDataState = null)
        {
            this.SessionId = SessionId;
            this.LastSuccessfulSessionId = LastSuccessfulSessionId;
            this.State = State;
            this.ErrorCode = ErrorCode;
            this.ForecastDataState = ForecastDataState;
            
        }
        


        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }



        /// <summary>
        /// Gets or Sets LastSuccessfulSessionId
        /// </summary>
        [DataMember(Name="lastSuccessfulSessionId", EmitDefaultValue=false)]
        public string LastSuccessfulSessionId { get; set; }





        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2WfmContinuousForecastSessionEventContinuousForecastSessionNotification {\n");

            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  LastSuccessfulSessionId: ").Append(LastSuccessfulSessionId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ForecastDataState: ").Append(ForecastDataState).Append("\n");
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
            return this.Equals(obj as V2WfmContinuousForecastSessionEventContinuousForecastSessionNotification);
        }

        /// <summary>
        /// Returns true if V2WfmContinuousForecastSessionEventContinuousForecastSessionNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of V2WfmContinuousForecastSessionEventContinuousForecastSessionNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2WfmContinuousForecastSessionEventContinuousForecastSessionNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.LastSuccessfulSessionId == other.LastSuccessfulSessionId ||
                    this.LastSuccessfulSessionId != null &&
                    this.LastSuccessfulSessionId.Equals(other.LastSuccessfulSessionId)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.ForecastDataState == other.ForecastDataState ||
                    this.ForecastDataState != null &&
                    this.ForecastDataState.Equals(other.ForecastDataState)
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
                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.LastSuccessfulSessionId != null)
                    hash = hash * 59 + this.LastSuccessfulSessionId.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.ForecastDataState != null)
                    hash = hash * 59 + this.ForecastDataState.GetHashCode();

                return hash;
            }
        }
    }

}
