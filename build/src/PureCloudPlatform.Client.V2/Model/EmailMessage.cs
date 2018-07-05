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
    /// EmailMessage
    /// </summary>
    [DataContract]
    public partial class EmailMessage :  IEquatable<EmailMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailMessage() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailMessage" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="To">The recipients of the email message. (required).</param>
        /// <param name="Cc">The recipients that were copied on the email message..</param>
        /// <param name="Bcc">The recipients that were blind copied on the email message..</param>
        /// <param name="From">The sender of the email message. (required).</param>
        /// <param name="Subject">The subject of the email message..</param>
        /// <param name="Attachments">The attachments of the email message..</param>
        /// <param name="TextBody">The text body of the email message. (required).</param>
        /// <param name="HtmlBody">The html body of the email message..</param>
        /// <param name="Time">The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public EmailMessage(string Name = null, List<EmailAddress> To = null, List<EmailAddress> Cc = null, List<EmailAddress> Bcc = null, EmailAddress From = null, string Subject = null, List<Attachment> Attachments = null, string TextBody = null, string HtmlBody = null, DateTime? Time = null)
        {
            this.Name = Name;
            this.Cc = Cc;
            this.Bcc = Bcc;
            this.Subject = Subject;
            this.Attachments = Attachments;
            this.HtmlBody = HtmlBody;
            this.Time = Time;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The recipients of the email message.
        /// </summary>
        /// <value>The recipients of the email message.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<EmailAddress> To { get; set; }
        
        
        
        /// <summary>
        /// The recipients that were copied on the email message.
        /// </summary>
        /// <value>The recipients that were copied on the email message.</value>
        [DataMember(Name="cc", EmitDefaultValue=false)]
        public List<EmailAddress> Cc { get; set; }
        
        
        
        /// <summary>
        /// The recipients that were blind copied on the email message.
        /// </summary>
        /// <value>The recipients that were blind copied on the email message.</value>
        [DataMember(Name="bcc", EmitDefaultValue=false)]
        public List<EmailAddress> Bcc { get; set; }
        
        
        
        /// <summary>
        /// The sender of the email message.
        /// </summary>
        /// <value>The sender of the email message.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public EmailAddress From { get; set; }
        
        
        
        /// <summary>
        /// The subject of the email message.
        /// </summary>
        /// <value>The subject of the email message.</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
        
        
        
        /// <summary>
        /// The attachments of the email message.
        /// </summary>
        /// <value>The attachments of the email message.</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<Attachment> Attachments { get; set; }
        
        
        
        /// <summary>
        /// The text body of the email message.
        /// </summary>
        /// <value>The text body of the email message.</value>
        [DataMember(Name="textBody", EmitDefaultValue=false)]
        public string TextBody { get; set; }
        
        
        
        /// <summary>
        /// The html body of the email message.
        /// </summary>
        /// <value>The html body of the email message.</value>
        [DataMember(Name="htmlBody", EmitDefaultValue=false)]
        public string HtmlBody { get; set; }
        
        
        
        /// <summary>
        /// The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }
        
        
        
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
            sb.Append("class EmailMessage {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  TextBody: ").Append(TextBody).Append("\n");
            sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(obj as EmailMessage);
        }

        /// <summary>
        /// Returns true if EmailMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailMessage other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.SequenceEqual(other.To)
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
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) &&
                (
                    this.Attachments == other.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(other.Attachments)
                ) &&
                (
                    this.TextBody == other.TextBody ||
                    this.TextBody != null &&
                    this.TextBody.Equals(other.TextBody)
                ) &&
                (
                    this.HtmlBody == other.HtmlBody ||
                    this.HtmlBody != null &&
                    this.HtmlBody.Equals(other.HtmlBody)
                ) &&
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                
                if (this.Cc != null)
                    hash = hash * 59 + this.Cc.GetHashCode();
                
                if (this.Bcc != null)
                    hash = hash * 59 + this.Bcc.GetHashCode();
                
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                
                if (this.Attachments != null)
                    hash = hash * 59 + this.Attachments.GetHashCode();
                
                if (this.TextBody != null)
                    hash = hash * 59 + this.TextBody.GetHashCode();
                
                if (this.HtmlBody != null)
                    hash = hash * 59 + this.HtmlBody.GetHashCode();
                
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
