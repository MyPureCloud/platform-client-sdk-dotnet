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
    /// HistoryHeadersTranslation
    /// </summary>
    [DataContract]
    public partial class HistoryHeadersTranslation :  IEquatable<HistoryHeadersTranslation>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryHeadersTranslation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HistoryHeadersTranslation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryHeadersTranslation" /> class.
        /// </summary>
        /// <param name="From">A translation for the word \&quot;from\&quot;, for the expected language (required).</param>
        /// <param name="To">A translation for the word \&quot;to\&quot;, for the expected language (required).</param>
        /// <param name="Cc">A translation for the word \&quot;cc\&quot;, for the expected language (required).</param>
        /// <param name="Subject">A translation for the word \&quot;subject\&quot;, for the expected language (required).</param>
        /// <param name="ReplyPrefix">A translation for the subject prefix \&quot;Reply\&quot;, for the expected language (required).</param>
        /// <param name="ForwardPrefix">A translation for the subject prefix \&quot;Forward\&quot;, for the expected language (required).</param>
        /// <param name="Sent">A translation for the word \&quot;sent\&quot;, for the expected language (required).</param>
        /// <param name="Language">The code of the expected language (required).</param>
        /// <param name="TimeZone">Timezone used by the agent, used to format the sent email date and time. If not defined, will default to UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London.</param>
        public HistoryHeadersTranslation(string From = null, string To = null, string Cc = null, string Subject = null, string ReplyPrefix = null, string ForwardPrefix = null, string Sent = null, string Language = null, string TimeZone = null)
        {
            this.From = From;
            this.To = To;
            this.Cc = Cc;
            this.Subject = Subject;
            this.ReplyPrefix = ReplyPrefix;
            this.ForwardPrefix = ForwardPrefix;
            this.Sent = Sent;
            this.Language = Language;
            this.TimeZone = TimeZone;
            
        }
        


        /// <summary>
        /// A translation for the word \&quot;from\&quot;, for the expected language
        /// </summary>
        /// <value>A translation for the word \&quot;from\&quot;, for the expected language</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }



        /// <summary>
        /// A translation for the word \&quot;to\&quot;, for the expected language
        /// </summary>
        /// <value>A translation for the word \&quot;to\&quot;, for the expected language</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }



        /// <summary>
        /// A translation for the word \&quot;cc\&quot;, for the expected language
        /// </summary>
        /// <value>A translation for the word \&quot;cc\&quot;, for the expected language</value>
        [DataMember(Name="cc", EmitDefaultValue=false)]
        public string Cc { get; set; }



        /// <summary>
        /// A translation for the word \&quot;subject\&quot;, for the expected language
        /// </summary>
        /// <value>A translation for the word \&quot;subject\&quot;, for the expected language</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }



        /// <summary>
        /// A translation for the subject prefix \&quot;Reply\&quot;, for the expected language
        /// </summary>
        /// <value>A translation for the subject prefix \&quot;Reply\&quot;, for the expected language</value>
        [DataMember(Name="replyPrefix", EmitDefaultValue=false)]
        public string ReplyPrefix { get; set; }



        /// <summary>
        /// A translation for the subject prefix \&quot;Forward\&quot;, for the expected language
        /// </summary>
        /// <value>A translation for the subject prefix \&quot;Forward\&quot;, for the expected language</value>
        [DataMember(Name="forwardPrefix", EmitDefaultValue=false)]
        public string ForwardPrefix { get; set; }



        /// <summary>
        /// A translation for the word \&quot;sent\&quot;, for the expected language
        /// </summary>
        /// <value>A translation for the word \&quot;sent\&quot;, for the expected language</value>
        [DataMember(Name="sent", EmitDefaultValue=false)]
        public string Sent { get; set; }



        /// <summary>
        /// The code of the expected language
        /// </summary>
        /// <value>The code of the expected language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// Timezone used by the agent, used to format the sent email date and time. If not defined, will default to UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
        /// </summary>
        /// <value>Timezone used by the agent, used to format the sent email date and time. If not defined, will default to UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryHeadersTranslation {\n");

            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  ReplyPrefix: ").Append(ReplyPrefix).Append("\n");
            sb.Append("  ForwardPrefix: ").Append(ForwardPrefix).Append("\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
            return this.Equals(obj as HistoryHeadersTranslation);
        }

        /// <summary>
        /// Returns true if HistoryHeadersTranslation instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoryHeadersTranslation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryHeadersTranslation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.Cc == other.Cc ||
                    this.Cc != null &&
                    this.Cc.Equals(other.Cc)
                ) &&
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) &&
                (
                    this.ReplyPrefix == other.ReplyPrefix ||
                    this.ReplyPrefix != null &&
                    this.ReplyPrefix.Equals(other.ReplyPrefix)
                ) &&
                (
                    this.ForwardPrefix == other.ForwardPrefix ||
                    this.ForwardPrefix != null &&
                    this.ForwardPrefix.Equals(other.ForwardPrefix)
                ) &&
                (
                    this.Sent == other.Sent ||
                    this.Sent != null &&
                    this.Sent.Equals(other.Sent)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
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
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();

                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();

                if (this.Cc != null)
                    hash = hash * 59 + this.Cc.GetHashCode();

                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();

                if (this.ReplyPrefix != null)
                    hash = hash * 59 + this.ReplyPrefix.GetHashCode();

                if (this.ForwardPrefix != null)
                    hash = hash * 59 + this.ForwardPrefix.GetHashCode();

                if (this.Sent != null)
                    hash = hash * 59 + this.Sent.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();

                return hash;
            }
        }
    }

}
