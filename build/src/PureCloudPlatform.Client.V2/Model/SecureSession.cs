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
    /// SecureSession
    /// </summary>
    [DataContract]
    public partial class SecureSession :  IEquatable<SecureSession>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The current state of a secure session
        /// </summary>
        /// <value>The current state of a secure session</value>
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
            /// Enum Pending for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            Pending,
            
            /// <summary>
            /// Enum Completed for "COMPLETED"
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            Completed,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The current state of a secure session
        /// </summary>
        /// <value>The current state of a secure session</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SecureSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecureSession() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SecureSession" /> class.
        /// </summary>
        /// <param name="Flow">The flow to execute securely (required).</param>
        /// <param name="UserData">Customer-provided data.</param>
        /// <param name="State">The current state of a secure session (required).</param>
        /// <param name="SourceParticipantId">Unique identifier for the participant initiating the secure session..</param>
        /// <param name="Disconnect">If true, disconnect the agent after creating the session.</param>
        public SecureSession(DomainEntityRef Flow = null, string UserData = null, StateEnum? State = null, string SourceParticipantId = null, bool? Disconnect = null)
        {
            this.Flow = Flow;
            this.UserData = UserData;
            this.State = State;
            this.SourceParticipantId = SourceParticipantId;
            this.Disconnect = Disconnect;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The flow to execute securely
        /// </summary>
        /// <value>The flow to execute securely</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public DomainEntityRef Flow { get; set; }
        
        
        
        /// <summary>
        /// Customer-provided data
        /// </summary>
        /// <value>Customer-provided data</value>
        [DataMember(Name="userData", EmitDefaultValue=false)]
        public string UserData { get; set; }
        
        
        
        
        
        /// <summary>
        /// Unique identifier for the participant initiating the secure session.
        /// </summary>
        /// <value>Unique identifier for the participant initiating the secure session.</value>
        [DataMember(Name="sourceParticipantId", EmitDefaultValue=false)]
        public string SourceParticipantId { get; set; }
        
        
        
        /// <summary>
        /// If true, disconnect the agent after creating the session
        /// </summary>
        /// <value>If true, disconnect the agent after creating the session</value>
        [DataMember(Name="disconnect", EmitDefaultValue=false)]
        public bool? Disconnect { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecureSession {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SourceParticipantId: ").Append(SourceParticipantId).Append("\n");
            sb.Append("  Disconnect: ").Append(Disconnect).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SecureSession);
        }

        /// <summary>
        /// Returns true if SecureSession instances are equal
        /// </summary>
        /// <param name="other">Instance of SecureSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecureSession other)
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
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
                ) &&
                (
                    this.UserData == other.UserData ||
                    this.UserData != null &&
                    this.UserData.Equals(other.UserData)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.SourceParticipantId == other.SourceParticipantId ||
                    this.SourceParticipantId != null &&
                    this.SourceParticipantId.Equals(other.SourceParticipantId)
                ) &&
                (
                    this.Disconnect == other.Disconnect ||
                    this.Disconnect != null &&
                    this.Disconnect.Equals(other.Disconnect)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();
                
                if (this.UserData != null)
                    hash = hash * 59 + this.UserData.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.SourceParticipantId != null)
                    hash = hash * 59 + this.SourceParticipantId.GetHashCode();
                
                if (this.Disconnect != null)
                    hash = hash * 59 + this.Disconnect.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
