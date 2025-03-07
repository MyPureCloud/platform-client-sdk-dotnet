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
    /// InitialConfiguration
    /// </summary>
    [DataContract]
    public partial class InitialConfiguration :  IEquatable<InitialConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitialConfiguration" /> class.
        /// </summary>
        /// <param name="AudioState">Indicates the initial audio state for the communication..</param>
        /// <param name="Alerting">Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state..</param>
        /// <param name="Inbound">Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND..</param>
        /// <param name="InvitedBy">The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred..</param>
        /// <param name="RecordingActive">Indicates whether recording is active for this communication at creation..</param>
        /// <param name="AdditionalInfo">Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields..</param>
        public InitialConfiguration(AudioState AudioState = null, bool? Alerting = null, bool? Inbound = null, string InvitedBy = null, bool? RecordingActive = null, Dictionary<string, string> AdditionalInfo = null)
        {
            this.AudioState = AudioState;
            this.Alerting = Alerting;
            this.Inbound = Inbound;
            this.InvitedBy = InvitedBy;
            this.RecordingActive = RecordingActive;
            this.AdditionalInfo = AdditionalInfo;
            
        }
        


        /// <summary>
        /// Indicates the initial audio state for the communication.
        /// </summary>
        /// <value>Indicates the initial audio state for the communication.</value>
        [DataMember(Name="audioState", EmitDefaultValue=false)]
        public AudioState AudioState { get; set; }



        /// <summary>
        /// Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state.
        /// </summary>
        /// <value>Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state.</value>
        [DataMember(Name="alerting", EmitDefaultValue=false)]
        public bool? Alerting { get; set; }



        /// <summary>
        /// Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND.
        /// </summary>
        /// <value>Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND.</value>
        [DataMember(Name="inbound", EmitDefaultValue=false)]
        public bool? Inbound { get; set; }



        /// <summary>
        /// The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred.
        /// </summary>
        /// <value>The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred.</value>
        [DataMember(Name="invitedBy", EmitDefaultValue=false)]
        public string InvitedBy { get; set; }



        /// <summary>
        /// Indicates whether recording is active for this communication at creation.
        /// </summary>
        /// <value>Indicates whether recording is active for this communication at creation.</value>
        [DataMember(Name="recordingActive", EmitDefaultValue=false)]
        public bool? RecordingActive { get; set; }



        /// <summary>
        /// Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields.
        /// </summary>
        /// <value>Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields.</value>
        [DataMember(Name="additionalInfo", EmitDefaultValue=false)]
        public Dictionary<string, string> AdditionalInfo { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitialConfiguration {\n");

            sb.Append("  AudioState: ").Append(AudioState).Append("\n");
            sb.Append("  Alerting: ").Append(Alerting).Append("\n");
            sb.Append("  Inbound: ").Append(Inbound).Append("\n");
            sb.Append("  InvitedBy: ").Append(InvitedBy).Append("\n");
            sb.Append("  RecordingActive: ").Append(RecordingActive).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
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
            return this.Equals(obj as InitialConfiguration);
        }

        /// <summary>
        /// Returns true if InitialConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of InitialConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitialConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AudioState == other.AudioState ||
                    this.AudioState != null &&
                    this.AudioState.Equals(other.AudioState)
                ) &&
                (
                    this.Alerting == other.Alerting ||
                    this.Alerting != null &&
                    this.Alerting.Equals(other.Alerting)
                ) &&
                (
                    this.Inbound == other.Inbound ||
                    this.Inbound != null &&
                    this.Inbound.Equals(other.Inbound)
                ) &&
                (
                    this.InvitedBy == other.InvitedBy ||
                    this.InvitedBy != null &&
                    this.InvitedBy.Equals(other.InvitedBy)
                ) &&
                (
                    this.RecordingActive == other.RecordingActive ||
                    this.RecordingActive != null &&
                    this.RecordingActive.Equals(other.RecordingActive)
                ) &&
                (
                    this.AdditionalInfo == other.AdditionalInfo ||
                    this.AdditionalInfo != null &&
                    this.AdditionalInfo.SequenceEqual(other.AdditionalInfo)
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
                if (this.AudioState != null)
                    hash = hash * 59 + this.AudioState.GetHashCode();

                if (this.Alerting != null)
                    hash = hash * 59 + this.Alerting.GetHashCode();

                if (this.Inbound != null)
                    hash = hash * 59 + this.Inbound.GetHashCode();

                if (this.InvitedBy != null)
                    hash = hash * 59 + this.InvitedBy.GetHashCode();

                if (this.RecordingActive != null)
                    hash = hash * 59 + this.RecordingActive.GetHashCode();

                if (this.AdditionalInfo != null)
                    hash = hash * 59 + this.AdditionalInfo.GetHashCode();

                return hash;
            }
        }
    }

}
