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
    /// SurveyAssignment
    /// </summary>
    [DataContract]
    public partial class SurveyAssignment :  IEquatable<SurveyAssignment>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyAssignment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SurveyAssignment() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyAssignment" /> class.
        /// </summary>
        /// <param name="SurveyForm">The survey form used for this survey..</param>
        /// <param name="Flow">The URI reference to the flow associated with this survey..</param>
        /// <param name="InviteTimeInterval">An ISO 8601 repeated interval consisting of the number of repetitions, the start datetime, and the interval (e.g. R2/2018-03-01T13:00:00Z/P1M10DT2H30M). Total duration must not exceed 90 days..</param>
        /// <param name="SendingUser">User together with sendingDomain used to send email, null to use no-reply.</param>
        /// <param name="SendingDomain">Validated email domain, required (required).</param>
        public SurveyAssignment(PublishedSurveyFormReference SurveyForm = null, DomainEntityRef Flow = null, string InviteTimeInterval = null, string SendingUser = null, string SendingDomain = null)
        {
            this.SurveyForm = SurveyForm;
            this.Flow = Flow;
            this.InviteTimeInterval = InviteTimeInterval;
            this.SendingUser = SendingUser;
            this.SendingDomain = SendingDomain;
            
        }
        
        
        
        /// <summary>
        /// The survey form used for this survey.
        /// </summary>
        /// <value>The survey form used for this survey.</value>
        [DataMember(Name="surveyForm", EmitDefaultValue=false)]
        public PublishedSurveyFormReference SurveyForm { get; set; }
        
        
        
        /// <summary>
        /// The URI reference to the flow associated with this survey.
        /// </summary>
        /// <value>The URI reference to the flow associated with this survey.</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public DomainEntityRef Flow { get; set; }
        
        
        
        /// <summary>
        /// An ISO 8601 repeated interval consisting of the number of repetitions, the start datetime, and the interval (e.g. R2/2018-03-01T13:00:00Z/P1M10DT2H30M). Total duration must not exceed 90 days.
        /// </summary>
        /// <value>An ISO 8601 repeated interval consisting of the number of repetitions, the start datetime, and the interval (e.g. R2/2018-03-01T13:00:00Z/P1M10DT2H30M). Total duration must not exceed 90 days.</value>
        [DataMember(Name="inviteTimeInterval", EmitDefaultValue=false)]
        public string InviteTimeInterval { get; set; }
        
        
        
        /// <summary>
        /// User together with sendingDomain used to send email, null to use no-reply
        /// </summary>
        /// <value>User together with sendingDomain used to send email, null to use no-reply</value>
        [DataMember(Name="sendingUser", EmitDefaultValue=false)]
        public string SendingUser { get; set; }
        
        
        
        /// <summary>
        /// Validated email domain, required
        /// </summary>
        /// <value>Validated email domain, required</value>
        [DataMember(Name="sendingDomain", EmitDefaultValue=false)]
        public string SendingDomain { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SurveyAssignment {\n");
            
            sb.Append("  SurveyForm: ").Append(SurveyForm).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  InviteTimeInterval: ").Append(InviteTimeInterval).Append("\n");
            sb.Append("  SendingUser: ").Append(SendingUser).Append("\n");
            sb.Append("  SendingDomain: ").Append(SendingDomain).Append("\n");
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
            return this.Equals(obj as SurveyAssignment);
        }

        /// <summary>
        /// Returns true if SurveyAssignment instances are equal
        /// </summary>
        /// <param name="other">Instance of SurveyAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SurveyAssignment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SurveyForm == other.SurveyForm ||
                    this.SurveyForm != null &&
                    this.SurveyForm.Equals(other.SurveyForm)
                ) &&
                (
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
                ) &&
                (
                    this.InviteTimeInterval == other.InviteTimeInterval ||
                    this.InviteTimeInterval != null &&
                    this.InviteTimeInterval.Equals(other.InviteTimeInterval)
                ) &&
                (
                    this.SendingUser == other.SendingUser ||
                    this.SendingUser != null &&
                    this.SendingUser.Equals(other.SendingUser)
                ) &&
                (
                    this.SendingDomain == other.SendingDomain ||
                    this.SendingDomain != null &&
                    this.SendingDomain.Equals(other.SendingDomain)
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
                
                if (this.SurveyForm != null)
                    hash = hash * 59 + this.SurveyForm.GetHashCode();
                
                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();
                
                if (this.InviteTimeInterval != null)
                    hash = hash * 59 + this.InviteTimeInterval.GetHashCode();
                
                if (this.SendingUser != null)
                    hash = hash * 59 + this.SendingUser.GetHashCode();
                
                if (this.SendingDomain != null)
                    hash = hash * 59 + this.SendingDomain.GetHashCode();
                
                return hash;
            }
        }
    }

}
