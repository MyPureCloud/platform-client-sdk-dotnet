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
    /// TestMessage
    /// </summary>
    [DataContract]
    public partial class TestMessage :  IEquatable<TestMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TestMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestMessage() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TestMessage" /> class.
        /// </summary>
        /// <param name="To">The recipients of the email message. (required).</param>
        /// <param name="From">The sender of the email message. (required).</param>
        /// <param name="Subject">The subject of the email message..</param>
        /// <param name="TextBody">The text body of the email message. (required).</param>
        /// <param name="HtmlBody">The html body of the email message.</param>
        /// <param name="Time">The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public TestMessage(List<EmailAddress> To = null, EmailAddress From = null, string Subject = null, string TextBody = null, string HtmlBody = null, DateTime? Time = null)
        {
            this.To = To;
            this.From = From;
            this.Subject = Subject;
            this.TextBody = TextBody;
            this.HtmlBody = HtmlBody;
            this.Time = Time;
            
        }
        
        
        
        /// <summary>
        /// After the message has been sent, this is the value of the Message-ID email header.
        /// </summary>
        /// <value>After the message has been sent, this is the value of the Message-ID email header.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The recipients of the email message.
        /// </summary>
        /// <value>The recipients of the email message.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<EmailAddress> To { get; set; }
        
        
        
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
        /// The text body of the email message.
        /// </summary>
        /// <value>The text body of the email message.</value>
        [DataMember(Name="textBody", EmitDefaultValue=false)]
        public string TextBody { get; set; }
        
        
        
        /// <summary>
        /// The html body of the email message
        /// </summary>
        /// <value>The html body of the email message</value>
        [DataMember(Name="htmlBody", EmitDefaultValue=false)]
        public string HtmlBody { get; set; }
        
        
        
        /// <summary>
        /// The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestMessage {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TextBody: ").Append(TextBody).Append("\n");
            sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
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
            return this.Equals(obj as TestMessage);
        }

        /// <summary>
        /// Returns true if TestMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of TestMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestMessage other)
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
                    this.To == other.To ||
                    this.To != null &&
                    this.To.SequenceEqual(other.To)
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
                
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                
                if (this.TextBody != null)
                    hash = hash * 59 + this.TextBody.GetHashCode();
                
                if (this.HtmlBody != null)
                    hash = hash * 59 + this.HtmlBody.GetHashCode();
                
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                
                return hash;
            }
        }
    }

}
