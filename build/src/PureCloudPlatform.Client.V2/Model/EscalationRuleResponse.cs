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
    /// EscalationRuleResponse
    /// </summary>
    [DataContract]
    public partial class EscalationRuleResponse :  IEquatable<EscalationRuleResponse>
    {
        /// <summary>
        /// The status of the escalation rule.
        /// </summary>
        /// <value>The status of the escalation rule.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Paused for "Paused"
            /// </summary>
            [EnumMember(Value = "Paused")]
            Paused
        }
        /// <summary>
        /// The status of the escalation rule.
        /// </summary>
        /// <value>The status of the escalation rule.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EscalationRuleResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EscalationRuleResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EscalationRuleResponse" /> class.
        /// </summary>
        /// <param name="Id">ID of the escalation rule..</param>
        /// <param name="Name">The name of the escalation rule..</param>
        /// <param name="MatchCriteria">The criteria that defines when a social media message should be escalated. (required).</param>
        /// <param name="Priority">The priority of the escalation rule..</param>
        /// <param name="DivisionId">The ID of the division the social escalation rule belongs to. (required).</param>
        /// <param name="Description">A description of the social escalation rule..</param>
        /// <param name="DateCreated">Timestamp indicating when the escalation rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">Timestamp indicating when the escalation rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Status">The status of the escalation rule..</param>
        /// <param name="OpenEscalation">The target integration configuration used for an open message escalation..</param>
        /// <param name="FacebookEscalation">The target integration configuration used for a Facebook message escalation..</param>
        /// <param name="InstagramEscalation">The target integration configuration used for an Instagram message escalation..</param>
        /// <param name="TwitterEscalation">The target integration configuration used for a X (formerly Twitter) message escalation..</param>
        /// <param name="GoogleBusinessProfileEscalation">The target integration configuration used for a Google Business Profile message escalation..</param>
        public EscalationRuleResponse(string Id = null, string Name = null, string MatchCriteria = null, int? Priority = null, string DivisionId = null, string Description = null, DateTime? DateCreated = null, DateTime? DateModified = null, StatusEnum? Status = null, EscalationTarget OpenEscalation = null, EscalationTarget FacebookEscalation = null, EscalationTarget InstagramEscalation = null, EscalationTarget TwitterEscalation = null, EscalationTarget GoogleBusinessProfileEscalation = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.MatchCriteria = MatchCriteria;
            this.Priority = Priority;
            this.DivisionId = DivisionId;
            this.Description = Description;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Status = Status;
            this.OpenEscalation = OpenEscalation;
            this.FacebookEscalation = FacebookEscalation;
            this.InstagramEscalation = InstagramEscalation;
            this.TwitterEscalation = TwitterEscalation;
            this.GoogleBusinessProfileEscalation = GoogleBusinessProfileEscalation;
            
        }
        


        /// <summary>
        /// ID of the escalation rule.
        /// </summary>
        /// <value>ID of the escalation rule.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The name of the escalation rule.
        /// </summary>
        /// <value>The name of the escalation rule.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The criteria that defines when a social media message should be escalated.
        /// </summary>
        /// <value>The criteria that defines when a social media message should be escalated.</value>
        [DataMember(Name="matchCriteria", EmitDefaultValue=false)]
        public string MatchCriteria { get; set; }



        /// <summary>
        /// The priority of the escalation rule.
        /// </summary>
        /// <value>The priority of the escalation rule.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }



        /// <summary>
        /// The ID of the division the social escalation rule belongs to.
        /// </summary>
        /// <value>The ID of the division the social escalation rule belongs to.</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }



        /// <summary>
        /// A description of the social escalation rule.
        /// </summary>
        /// <value>A description of the social escalation rule.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Timestamp indicating when the escalation rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the escalation rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Timestamp indicating when the escalation rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the escalation rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }





        /// <summary>
        /// The target integration configuration used for an open message escalation.
        /// </summary>
        /// <value>The target integration configuration used for an open message escalation.</value>
        [DataMember(Name="openEscalation", EmitDefaultValue=false)]
        public EscalationTarget OpenEscalation { get; set; }



        /// <summary>
        /// The target integration configuration used for a Facebook message escalation.
        /// </summary>
        /// <value>The target integration configuration used for a Facebook message escalation.</value>
        [DataMember(Name="facebookEscalation", EmitDefaultValue=false)]
        public EscalationTarget FacebookEscalation { get; set; }



        /// <summary>
        /// The target integration configuration used for an Instagram message escalation.
        /// </summary>
        /// <value>The target integration configuration used for an Instagram message escalation.</value>
        [DataMember(Name="instagramEscalation", EmitDefaultValue=false)]
        public EscalationTarget InstagramEscalation { get; set; }



        /// <summary>
        /// The target integration configuration used for a X (formerly Twitter) message escalation.
        /// </summary>
        /// <value>The target integration configuration used for a X (formerly Twitter) message escalation.</value>
        [DataMember(Name="twitterEscalation", EmitDefaultValue=false)]
        public EscalationTarget TwitterEscalation { get; set; }



        /// <summary>
        /// The target integration configuration used for a Google Business Profile message escalation.
        /// </summary>
        /// <value>The target integration configuration used for a Google Business Profile message escalation.</value>
        [DataMember(Name="googleBusinessProfileEscalation", EmitDefaultValue=false)]
        public EscalationTarget GoogleBusinessProfileEscalation { get; set; }



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
            sb.Append("class EscalationRuleResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MatchCriteria: ").Append(MatchCriteria).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  OpenEscalation: ").Append(OpenEscalation).Append("\n");
            sb.Append("  FacebookEscalation: ").Append(FacebookEscalation).Append("\n");
            sb.Append("  InstagramEscalation: ").Append(InstagramEscalation).Append("\n");
            sb.Append("  TwitterEscalation: ").Append(TwitterEscalation).Append("\n");
            sb.Append("  GoogleBusinessProfileEscalation: ").Append(GoogleBusinessProfileEscalation).Append("\n");
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
            return this.Equals(obj as EscalationRuleResponse);
        }

        /// <summary>
        /// Returns true if EscalationRuleResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EscalationRuleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EscalationRuleResponse other)
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
                    this.MatchCriteria == other.MatchCriteria ||
                    this.MatchCriteria != null &&
                    this.MatchCriteria.Equals(other.MatchCriteria)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.OpenEscalation == other.OpenEscalation ||
                    this.OpenEscalation != null &&
                    this.OpenEscalation.Equals(other.OpenEscalation)
                ) &&
                (
                    this.FacebookEscalation == other.FacebookEscalation ||
                    this.FacebookEscalation != null &&
                    this.FacebookEscalation.Equals(other.FacebookEscalation)
                ) &&
                (
                    this.InstagramEscalation == other.InstagramEscalation ||
                    this.InstagramEscalation != null &&
                    this.InstagramEscalation.Equals(other.InstagramEscalation)
                ) &&
                (
                    this.TwitterEscalation == other.TwitterEscalation ||
                    this.TwitterEscalation != null &&
                    this.TwitterEscalation.Equals(other.TwitterEscalation)
                ) &&
                (
                    this.GoogleBusinessProfileEscalation == other.GoogleBusinessProfileEscalation ||
                    this.GoogleBusinessProfileEscalation != null &&
                    this.GoogleBusinessProfileEscalation.Equals(other.GoogleBusinessProfileEscalation)
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

                if (this.MatchCriteria != null)
                    hash = hash * 59 + this.MatchCriteria.GetHashCode();

                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.OpenEscalation != null)
                    hash = hash * 59 + this.OpenEscalation.GetHashCode();

                if (this.FacebookEscalation != null)
                    hash = hash * 59 + this.FacebookEscalation.GetHashCode();

                if (this.InstagramEscalation != null)
                    hash = hash * 59 + this.InstagramEscalation.GetHashCode();

                if (this.TwitterEscalation != null)
                    hash = hash * 59 + this.TwitterEscalation.GetHashCode();

                if (this.GoogleBusinessProfileEscalation != null)
                    hash = hash * 59 + this.GoogleBusinessProfileEscalation.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
