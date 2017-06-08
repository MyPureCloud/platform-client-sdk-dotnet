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
    /// RecordingEmailMessage
    /// </summary>
    [DataContract]
    public partial class RecordingEmailMessage :  IEquatable<RecordingEmailMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingEmailMessage" /> class.
        /// </summary>
        
        
        /// <param name="HtmlBody">HtmlBody.</param>
        
        
        
        /// <param name="TextBody">TextBody.</param>
        
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="To">To.</param>
        
        
        
        /// <param name="Cc">Cc.</param>
        
        
        
        /// <param name="Bcc">Bcc.</param>
        
        
        
        /// <param name="From">From.</param>
        
        
        
        /// <param name="Subject">Subject.</param>
        
        
        
        /// <param name="Attachments">Attachments.</param>
        
        
        
        /// <param name="Time">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        public RecordingEmailMessage(string HtmlBody = null, string TextBody = null, string Id = null, List<EmailAddress> To = null, List<EmailAddress> Cc = null, List<EmailAddress> Bcc = null, EmailAddress From = null, string Subject = null, List<EmailAttachment> Attachments = null, DateTime? Time = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.HtmlBody = HtmlBody;
            
            
            
            
            
            
            
            
this.TextBody = TextBody;
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.To = To;
            
            
            
            
            
            
            
            
this.Cc = Cc;
            
            
            
            
            
            
            
            
this.Bcc = Bcc;
            
            
            
            
            
            
            
            
this.From = From;
            
            
            
            
            
            
            
            
this.Subject = Subject;
            
            
            
            
            
            
            
            
this.Attachments = Attachments;
            
            
            
            
            
            
            
            
this.Time = Time;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets HtmlBody
        /// </summary>
        [DataMember(Name="htmlBody", EmitDefaultValue=false)]
        public string HtmlBody { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets TextBody
        /// </summary>
        [DataMember(Name="textBody", EmitDefaultValue=false)]
        public string TextBody { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<EmailAddress> To { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name="cc", EmitDefaultValue=false)]
        public List<EmailAddress> Cc { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name="bcc", EmitDefaultValue=false)]
        public List<EmailAddress> Bcc { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public EmailAddress From { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<EmailAttachment> Attachments { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingEmailMessage {\n");
            
            sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
            
            sb.Append("  TextBody: ").Append(TextBody).Append("\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  To: ").Append(To).Append("\n");
            
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            
            sb.Append("  From: ").Append(From).Append("\n");
            
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            
            sb.Append("  Time: ").Append(Time).Append("\n");
            
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
            return this.Equals(obj as RecordingEmailMessage);
        }

        /// <summary>
        /// Returns true if RecordingEmailMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingEmailMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingEmailMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.HtmlBody == other.HtmlBody ||
                    this.HtmlBody != null &&
                    this.HtmlBody.Equals(other.HtmlBody)
                ) &&
                (
                    this.TextBody == other.TextBody ||
                    this.TextBody != null &&
                    this.TextBody.Equals(other.TextBody)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
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
                
                if (this.HtmlBody != null)
                    hash = hash * 59 + this.HtmlBody.GetHashCode();
                
                if (this.TextBody != null)
                    hash = hash * 59 + this.TextBody.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
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
                
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                
                return hash;
            }
        }
    }

}
