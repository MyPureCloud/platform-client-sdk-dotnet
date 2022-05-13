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
    /// CreateSecureSession
    /// </summary>
    [DataContract]
    public partial class CreateSecureSession :  IEquatable<CreateSecureSession>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecureSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSecureSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecureSession" /> class.
        /// </summary>
        /// <param name="SourceParticipantId">requesting participant.</param>
        /// <param name="FlowId">the flow id to execute in the secure session (required).</param>
        /// <param name="UserData">user data for the secure session (required).</param>
        /// <param name="Disconnect">if true, disconnect the agent after creating the session.</param>
        public CreateSecureSession(string SourceParticipantId = null, string FlowId = null, string UserData = null, bool? Disconnect = null)
        {
            this.SourceParticipantId = SourceParticipantId;
            this.FlowId = FlowId;
            this.UserData = UserData;
            this.Disconnect = Disconnect;
            
        }
        


        /// <summary>
        /// requesting participant
        /// </summary>
        /// <value>requesting participant</value>
        [DataMember(Name="sourceParticipantId", EmitDefaultValue=false)]
        public string SourceParticipantId { get; set; }



        /// <summary>
        /// the flow id to execute in the secure session
        /// </summary>
        /// <value>the flow id to execute in the secure session</value>
        [DataMember(Name="flowId", EmitDefaultValue=false)]
        public string FlowId { get; set; }



        /// <summary>
        /// user data for the secure session
        /// </summary>
        /// <value>user data for the secure session</value>
        [DataMember(Name="userData", EmitDefaultValue=false)]
        public string UserData { get; set; }



        /// <summary>
        /// if true, disconnect the agent after creating the session
        /// </summary>
        /// <value>if true, disconnect the agent after creating the session</value>
        [DataMember(Name="disconnect", EmitDefaultValue=false)]
        public bool? Disconnect { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSecureSession {\n");

            sb.Append("  SourceParticipantId: ").Append(SourceParticipantId).Append("\n");
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Disconnect: ").Append(Disconnect).Append("\n");
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
            return this.Equals(obj as CreateSecureSession);
        }

        /// <summary>
        /// Returns true if CreateSecureSession instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateSecureSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSecureSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceParticipantId == other.SourceParticipantId ||
                    this.SourceParticipantId != null &&
                    this.SourceParticipantId.Equals(other.SourceParticipantId)
                ) &&
                (
                    this.FlowId == other.FlowId ||
                    this.FlowId != null &&
                    this.FlowId.Equals(other.FlowId)
                ) &&
                (
                    this.UserData == other.UserData ||
                    this.UserData != null &&
                    this.UserData.Equals(other.UserData)
                ) &&
                (
                    this.Disconnect == other.Disconnect ||
                    this.Disconnect != null &&
                    this.Disconnect.Equals(other.Disconnect)
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
                if (this.SourceParticipantId != null)
                    hash = hash * 59 + this.SourceParticipantId.GetHashCode();

                if (this.FlowId != null)
                    hash = hash * 59 + this.FlowId.GetHashCode();

                if (this.UserData != null)
                    hash = hash * 59 + this.UserData.GetHashCode();

                if (this.Disconnect != null)
                    hash = hash * 59 + this.Disconnect.GetHashCode();

                return hash;
            }
        }
    }

}
