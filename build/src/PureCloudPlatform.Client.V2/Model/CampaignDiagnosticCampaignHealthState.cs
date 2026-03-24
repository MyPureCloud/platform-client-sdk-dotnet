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
    /// CampaignDiagnosticCampaignHealthState
    /// </summary>
    [DataContract]
    public partial class CampaignDiagnosticCampaignHealthState :  IEquatable<CampaignDiagnosticCampaignHealthState>
    {
        /// <summary>
        /// Campaign health state name
        /// </summary>
        /// <value>Campaign health state name</value>
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
            /// Enum Healthy for "healthy"
            /// </summary>
            [EnumMember(Value = "healthy")]
            Healthy,
            
            /// <summary>
            /// Enum Waitingforagents for "WaitingForAgents"
            /// </summary>
            [EnumMember(Value = "WaitingForAgents")]
            Waitingforagents,
            
            /// <summary>
            /// Enum Waitingforcontacts for "WaitingForContacts"
            /// </summary>
            [EnumMember(Value = "WaitingForContacts")]
            Waitingforcontacts,
            
            /// <summary>
            /// Enum Waitingforlines for "WaitingForLines"
            /// </summary>
            [EnumMember(Value = "WaitingForLines")]
            Waitingforlines,
            
            /// <summary>
            /// Enum Warnthresholdcps for "WarnThresholdCPS"
            /// </summary>
            [EnumMember(Value = "WarnThresholdCPS")]
            Warnthresholdcps,
            
            /// <summary>
            /// Enum Warnmaxcpaalarm for "WarnMaxCPAalarm"
            /// </summary>
            [EnumMember(Value = "WarnMaxCPAalarm")]
            Warnmaxcpaalarm
        }
        /// <summary>
        /// Campaign health state name
        /// </summary>
        /// <value>Campaign health state name</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignDiagnosticCampaignHealthState" /> class.
        /// </summary>
        /// <param name="State">Campaign health state name.</param>
        /// <param name="DateStart">Start datetime of the health state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateEnd">End datetime of the health state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public CampaignDiagnosticCampaignHealthState(StateEnum? State = null, DateTime? DateStart = null, DateTime? DateEnd = null)
        {
            this.State = State;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            
        }
        




        /// <summary>
        /// Start datetime of the health state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Start datetime of the health state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }



        /// <summary>
        /// End datetime of the health state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>End datetime of the health state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public DateTime? DateEnd { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignDiagnosticCampaignHealthState {\n");

            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
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
            return this.Equals(obj as CampaignDiagnosticCampaignHealthState);
        }

        /// <summary>
        /// Returns true if CampaignDiagnosticCampaignHealthState instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignDiagnosticCampaignHealthState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignDiagnosticCampaignHealthState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
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
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();

                return hash;
            }
        }
    }

}
