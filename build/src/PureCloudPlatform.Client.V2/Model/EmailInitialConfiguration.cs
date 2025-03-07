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
    /// EmailInitialConfiguration
    /// </summary>
    [DataContract]
    public partial class EmailInitialConfiguration :  IEquatable<EmailInitialConfiguration>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailInitialConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailInitialConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailInitialConfiguration" /> class.
        /// </summary>
        /// <param name="To">An email address that this email is to. (required).</param>
        /// <param name="From">An email address that this email is from. (required).</param>
        /// <param name="Cc">An email addresses that this email is carbon copied to..</param>
        /// <param name="Bcc">An email addresses that this email is blind carbon copied to..</param>
        /// <param name="Subject">The subject for this email..</param>
        /// <param name="PreviousEmailId">UUID identifying the most recent previous email communication ID from the same participant on this email conversation. Will be null if this is a new participant..</param>
        /// <param name="Held">Indicates that this communication&#39;s initial state is held..</param>
        /// <param name="Alerting">Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state..</param>
        /// <param name="Inbound">Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND..</param>
        /// <param name="InvitedBy">The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred..</param>
        /// <param name="AdditionalInfo">Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields..</param>
        public EmailInitialConfiguration(string To = null, string From = null, List<string> Cc = null, List<string> Bcc = null, string Subject = null, string PreviousEmailId = null, bool? Held = null, bool? Alerting = null, bool? Inbound = null, string InvitedBy = null, Dictionary<string, string> AdditionalInfo = null)
        {
            this.To = To;
            this.From = From;
            this.Cc = Cc;
            this.Bcc = Bcc;
            this.Subject = Subject;
            this.PreviousEmailId = PreviousEmailId;
            this.Held = Held;
            this.Alerting = Alerting;
            this.Inbound = Inbound;
            this.InvitedBy = InvitedBy;
            this.AdditionalInfo = AdditionalInfo;
            
        }
        


        /// <summary>
        /// An email address that this email is to.
        /// </summary>
        /// <value>An email address that this email is to.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }



        /// <summary>
        /// An email address that this email is from.
        /// </summary>
        /// <value>An email address that this email is from.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }



        /// <summary>
        /// An email addresses that this email is carbon copied to.
        /// </summary>
        /// <value>An email addresses that this email is carbon copied to.</value>
        [DataMember(Name="cc", EmitDefaultValue=false)]
        public List<string> Cc { get; set; }



        /// <summary>
        /// An email addresses that this email is blind carbon copied to.
        /// </summary>
        /// <value>An email addresses that this email is blind carbon copied to.</value>
        [DataMember(Name="bcc", EmitDefaultValue=false)]
        public List<string> Bcc { get; set; }



        /// <summary>
        /// The subject for this email.
        /// </summary>
        /// <value>The subject for this email.</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }



        /// <summary>
        /// UUID identifying the most recent previous email communication ID from the same participant on this email conversation. Will be null if this is a new participant.
        /// </summary>
        /// <value>UUID identifying the most recent previous email communication ID from the same participant on this email conversation. Will be null if this is a new participant.</value>
        [DataMember(Name="previousEmailId", EmitDefaultValue=false)]
        public string PreviousEmailId { get; set; }



        /// <summary>
        /// Indicates that this communication&#39;s initial state is held.
        /// </summary>
        /// <value>Indicates that this communication&#39;s initial state is held.</value>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }



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
            sb.Append("class EmailInitialConfiguration {\n");

            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  PreviousEmailId: ").Append(PreviousEmailId).Append("\n");
            sb.Append("  Held: ").Append(Held).Append("\n");
            sb.Append("  Alerting: ").Append(Alerting).Append("\n");
            sb.Append("  Inbound: ").Append(Inbound).Append("\n");
            sb.Append("  InvitedBy: ").Append(InvitedBy).Append("\n");
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
            return this.Equals(obj as EmailInitialConfiguration);
        }

        /// <summary>
        /// Returns true if EmailInitialConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailInitialConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailInitialConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.Cc == other.Cc ||
                    this.Cc != null &&
                    this.Cc.SequenceEqual(other.Cc)
                ) &&
                (
                    this.Bcc == other.Bcc ||
                    this.Bcc != null &&
                    this.Bcc.SequenceEqual(other.Bcc)
                ) &&
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) &&
                (
                    this.PreviousEmailId == other.PreviousEmailId ||
                    this.PreviousEmailId != null &&
                    this.PreviousEmailId.Equals(other.PreviousEmailId)
                ) &&
                (
                    this.Held == other.Held ||
                    this.Held != null &&
                    this.Held.Equals(other.Held)
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
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();

                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();

                if (this.Cc != null)
                    hash = hash * 59 + this.Cc.GetHashCode();

                if (this.Bcc != null)
                    hash = hash * 59 + this.Bcc.GetHashCode();

                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();

                if (this.PreviousEmailId != null)
                    hash = hash * 59 + this.PreviousEmailId.GetHashCode();

                if (this.Held != null)
                    hash = hash * 59 + this.Held.GetHashCode();

                if (this.Alerting != null)
                    hash = hash * 59 + this.Alerting.GetHashCode();

                if (this.Inbound != null)
                    hash = hash * 59 + this.Inbound.GetHashCode();

                if (this.InvitedBy != null)
                    hash = hash * 59 + this.InvitedBy.GetHashCode();

                if (this.AdditionalInfo != null)
                    hash = hash * 59 + this.AdditionalInfo.GetHashCode();

                return hash;
            }
        }
    }

}
