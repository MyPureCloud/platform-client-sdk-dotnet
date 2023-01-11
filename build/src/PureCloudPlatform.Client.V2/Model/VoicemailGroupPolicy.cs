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
    /// VoicemailGroupPolicy
    /// </summary>
    [DataContract]
    public partial class VoicemailGroupPolicy :  IEquatable<VoicemailGroupPolicy>
    {
        /// <summary>
        /// Specifies if the members in this group should be contacted randomly, in a specific order, or by round-robin.
        /// </summary>
        /// <value>Specifies if the members in this group should be contacted randomly, in a specific order, or by round-robin.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GroupAlertTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Random for "RANDOM"
            /// </summary>
            [EnumMember(Value = "RANDOM")]
            Random,
            
            /// <summary>
            /// Enum RoundRobin for "ROUND_ROBIN"
            /// </summary>
            [EnumMember(Value = "ROUND_ROBIN")]
            RoundRobin,
            
            /// <summary>
            /// Enum Sequential for "SEQUENTIAL"
            /// </summary>
            [EnumMember(Value = "SEQUENTIAL")]
            Sequential
        }
        /// <summary>
        /// Specifies if the members in this group should be contacted randomly, in a specific order, or by round-robin.
        /// </summary>
        /// <value>Specifies if the members in this group should be contacted randomly, in a specific order, or by round-robin.</value>
        [DataMember(Name="groupAlertType", EmitDefaultValue=false)]
        public GroupAlertTypeEnum? GroupAlertType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailGroupPolicy" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Enabled">Whether voicemail is enabled for the group.</param>
        /// <param name="SendEmailNotifications">Whether email notifications are sent to group members when a new voicemail is received.</param>
        /// <param name="DisableEmailPii">Removes any PII from group emails. This is overridden by the analogous organization configuration value. This is always true if HIPAA is enabled or unknown for an organization..</param>
        /// <param name="IncludeEmailTranscriptions">Whether to include the voicemail transcription in a group notification email.</param>
        /// <param name="LanguagePreference">The language preference for the group.  Used for group voicemail transcription.</param>
        /// <param name="RotateCallsSecs">How many seconds to ring before rotating to the next member in the group.</param>
        /// <param name="StopRingingAfterRotations">How many rotations to go through.</param>
        /// <param name="OverflowGroupId">A fallback group to contact when all of the members in this group did not answer the call..</param>
        /// <param name="GroupAlertType">Specifies if the members in this group should be contacted randomly, in a specific order, or by round-robin..</param>
        /// <param name="InteractiveResponsePromptId">The prompt to use when connecting a user to a Group Ring call.</param>
        /// <param name="InteractiveResponseRequired">Whether user should be prompted with a confirmation prompt when connecting to a Group Ring call.</param>
        public VoicemailGroupPolicy(string Name = null, bool? Enabled = null, bool? SendEmailNotifications = null, bool? DisableEmailPii = null, bool? IncludeEmailTranscriptions = null, string LanguagePreference = null, int? RotateCallsSecs = null, int? StopRingingAfterRotations = null, string OverflowGroupId = null, GroupAlertTypeEnum? GroupAlertType = null, string InteractiveResponsePromptId = null, bool? InteractiveResponseRequired = null)
        {
            this.Name = Name;
            this.Enabled = Enabled;
            this.SendEmailNotifications = SendEmailNotifications;
            this.DisableEmailPii = DisableEmailPii;
            this.IncludeEmailTranscriptions = IncludeEmailTranscriptions;
            this.LanguagePreference = LanguagePreference;
            this.RotateCallsSecs = RotateCallsSecs;
            this.StopRingingAfterRotations = StopRingingAfterRotations;
            this.OverflowGroupId = OverflowGroupId;
            this.GroupAlertType = GroupAlertType;
            this.InteractiveResponsePromptId = InteractiveResponsePromptId;
            this.InteractiveResponseRequired = InteractiveResponseRequired;
            
        }
        


        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The group associated with the policy
        /// </summary>
        /// <value>The group associated with the policy</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public Group Group { get; private set; }



        /// <summary>
        /// Whether voicemail is enabled for the group
        /// </summary>
        /// <value>Whether voicemail is enabled for the group</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Whether email notifications are sent to group members when a new voicemail is received
        /// </summary>
        /// <value>Whether email notifications are sent to group members when a new voicemail is received</value>
        [DataMember(Name="sendEmailNotifications", EmitDefaultValue=false)]
        public bool? SendEmailNotifications { get; set; }



        /// <summary>
        /// Removes any PII from group emails. This is overridden by the analogous organization configuration value. This is always true if HIPAA is enabled or unknown for an organization.
        /// </summary>
        /// <value>Removes any PII from group emails. This is overridden by the analogous organization configuration value. This is always true if HIPAA is enabled or unknown for an organization.</value>
        [DataMember(Name="disableEmailPii", EmitDefaultValue=false)]
        public bool? DisableEmailPii { get; set; }



        /// <summary>
        /// Whether to include the voicemail transcription in a group notification email
        /// </summary>
        /// <value>Whether to include the voicemail transcription in a group notification email</value>
        [DataMember(Name="includeEmailTranscriptions", EmitDefaultValue=false)]
        public bool? IncludeEmailTranscriptions { get; set; }



        /// <summary>
        /// The language preference for the group.  Used for group voicemail transcription
        /// </summary>
        /// <value>The language preference for the group.  Used for group voicemail transcription</value>
        [DataMember(Name="languagePreference", EmitDefaultValue=false)]
        public string LanguagePreference { get; set; }



        /// <summary>
        /// How many seconds to ring before rotating to the next member in the group
        /// </summary>
        /// <value>How many seconds to ring before rotating to the next member in the group</value>
        [DataMember(Name="rotateCallsSecs", EmitDefaultValue=false)]
        public int? RotateCallsSecs { get; set; }



        /// <summary>
        /// How many rotations to go through
        /// </summary>
        /// <value>How many rotations to go through</value>
        [DataMember(Name="stopRingingAfterRotations", EmitDefaultValue=false)]
        public int? StopRingingAfterRotations { get; set; }



        /// <summary>
        /// A fallback group to contact when all of the members in this group did not answer the call.
        /// </summary>
        /// <value>A fallback group to contact when all of the members in this group did not answer the call.</value>
        [DataMember(Name="overflowGroupId", EmitDefaultValue=false)]
        public string OverflowGroupId { get; set; }





        /// <summary>
        /// The prompt to use when connecting a user to a Group Ring call
        /// </summary>
        /// <value>The prompt to use when connecting a user to a Group Ring call</value>
        [DataMember(Name="interactiveResponsePromptId", EmitDefaultValue=false)]
        public string InteractiveResponsePromptId { get; set; }



        /// <summary>
        /// Whether user should be prompted with a confirmation prompt when connecting to a Group Ring call
        /// </summary>
        /// <value>Whether user should be prompted with a confirmation prompt when connecting to a Group Ring call</value>
        [DataMember(Name="interactiveResponseRequired", EmitDefaultValue=false)]
        public bool? InteractiveResponseRequired { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicemailGroupPolicy {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SendEmailNotifications: ").Append(SendEmailNotifications).Append("\n");
            sb.Append("  DisableEmailPii: ").Append(DisableEmailPii).Append("\n");
            sb.Append("  IncludeEmailTranscriptions: ").Append(IncludeEmailTranscriptions).Append("\n");
            sb.Append("  LanguagePreference: ").Append(LanguagePreference).Append("\n");
            sb.Append("  RotateCallsSecs: ").Append(RotateCallsSecs).Append("\n");
            sb.Append("  StopRingingAfterRotations: ").Append(StopRingingAfterRotations).Append("\n");
            sb.Append("  OverflowGroupId: ").Append(OverflowGroupId).Append("\n");
            sb.Append("  GroupAlertType: ").Append(GroupAlertType).Append("\n");
            sb.Append("  InteractiveResponsePromptId: ").Append(InteractiveResponsePromptId).Append("\n");
            sb.Append("  InteractiveResponseRequired: ").Append(InteractiveResponseRequired).Append("\n");
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
            return this.Equals(obj as VoicemailGroupPolicy);
        }

        /// <summary>
        /// Returns true if VoicemailGroupPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailGroupPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailGroupPolicy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.SendEmailNotifications == other.SendEmailNotifications ||
                    this.SendEmailNotifications != null &&
                    this.SendEmailNotifications.Equals(other.SendEmailNotifications)
                ) &&
                (
                    this.DisableEmailPii == other.DisableEmailPii ||
                    this.DisableEmailPii != null &&
                    this.DisableEmailPii.Equals(other.DisableEmailPii)
                ) &&
                (
                    this.IncludeEmailTranscriptions == other.IncludeEmailTranscriptions ||
                    this.IncludeEmailTranscriptions != null &&
                    this.IncludeEmailTranscriptions.Equals(other.IncludeEmailTranscriptions)
                ) &&
                (
                    this.LanguagePreference == other.LanguagePreference ||
                    this.LanguagePreference != null &&
                    this.LanguagePreference.Equals(other.LanguagePreference)
                ) &&
                (
                    this.RotateCallsSecs == other.RotateCallsSecs ||
                    this.RotateCallsSecs != null &&
                    this.RotateCallsSecs.Equals(other.RotateCallsSecs)
                ) &&
                (
                    this.StopRingingAfterRotations == other.StopRingingAfterRotations ||
                    this.StopRingingAfterRotations != null &&
                    this.StopRingingAfterRotations.Equals(other.StopRingingAfterRotations)
                ) &&
                (
                    this.OverflowGroupId == other.OverflowGroupId ||
                    this.OverflowGroupId != null &&
                    this.OverflowGroupId.Equals(other.OverflowGroupId)
                ) &&
                (
                    this.GroupAlertType == other.GroupAlertType ||
                    this.GroupAlertType != null &&
                    this.GroupAlertType.Equals(other.GroupAlertType)
                ) &&
                (
                    this.InteractiveResponsePromptId == other.InteractiveResponsePromptId ||
                    this.InteractiveResponsePromptId != null &&
                    this.InteractiveResponsePromptId.Equals(other.InteractiveResponsePromptId)
                ) &&
                (
                    this.InteractiveResponseRequired == other.InteractiveResponseRequired ||
                    this.InteractiveResponseRequired != null &&
                    this.InteractiveResponseRequired.Equals(other.InteractiveResponseRequired)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.SendEmailNotifications != null)
                    hash = hash * 59 + this.SendEmailNotifications.GetHashCode();

                if (this.DisableEmailPii != null)
                    hash = hash * 59 + this.DisableEmailPii.GetHashCode();

                if (this.IncludeEmailTranscriptions != null)
                    hash = hash * 59 + this.IncludeEmailTranscriptions.GetHashCode();

                if (this.LanguagePreference != null)
                    hash = hash * 59 + this.LanguagePreference.GetHashCode();

                if (this.RotateCallsSecs != null)
                    hash = hash * 59 + this.RotateCallsSecs.GetHashCode();

                if (this.StopRingingAfterRotations != null)
                    hash = hash * 59 + this.StopRingingAfterRotations.GetHashCode();

                if (this.OverflowGroupId != null)
                    hash = hash * 59 + this.OverflowGroupId.GetHashCode();

                if (this.GroupAlertType != null)
                    hash = hash * 59 + this.GroupAlertType.GetHashCode();

                if (this.InteractiveResponsePromptId != null)
                    hash = hash * 59 + this.InteractiveResponsePromptId.GetHashCode();

                if (this.InteractiveResponseRequired != null)
                    hash = hash * 59 + this.InteractiveResponseRequired.GetHashCode();

                return hash;
            }
        }
    }

}
