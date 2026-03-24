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
    /// CaseCreate
    /// </summary>
    [DataContract]
    public partial class CaseCreate :  IEquatable<CaseCreate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseCreate" /> class.
        /// </summary>
        /// <param name="CaseplanId">The ID of the caseplan to create the case from. (required).</param>
        /// <param name="OwnerId">The ID of the owner of the case..</param>
        /// <param name="Summary">Overview information for the Case. Valid length between 3 and 512 characters..</param>
        /// <param name="ExternalContactId">The ID of the External Contact associated with the Case. (required).</param>
        /// <param name="ConversationId">The ID of conversation associated with the Case..</param>
        /// <param name="WorkitemId">The ID of the workitem associated with the Case..</param>
        /// <param name="TtlSeconds">The epoch timestamp in seconds specifying the time-to-live for the lifetime of the Case. Can not be greater than 365 days from the current time..</param>
        /// <param name="Intake">The intake data for the Case. Maximum of 10 intake objects allowed..</param>
        public CaseCreate(string CaseplanId = null, string OwnerId = null, string Summary = null, string ExternalContactId = null, string ConversationId = null, string WorkitemId = null, int? TtlSeconds = null, List<Intake> Intake = null)
        {
            this.CaseplanId = CaseplanId;
            this.OwnerId = OwnerId;
            this.Summary = Summary;
            this.ExternalContactId = ExternalContactId;
            this.ConversationId = ConversationId;
            this.WorkitemId = WorkitemId;
            this.TtlSeconds = TtlSeconds;
            this.Intake = Intake;
            
        }
        


        /// <summary>
        /// The ID of the caseplan to create the case from.
        /// </summary>
        /// <value>The ID of the caseplan to create the case from.</value>
        [DataMember(Name="caseplanId", EmitDefaultValue=false)]
        public string CaseplanId { get; set; }



        /// <summary>
        /// The ID of the owner of the case.
        /// </summary>
        /// <value>The ID of the owner of the case.</value>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public string OwnerId { get; set; }



        /// <summary>
        /// Overview information for the Case. Valid length between 3 and 512 characters.
        /// </summary>
        /// <value>Overview information for the Case. Valid length between 3 and 512 characters.</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }



        /// <summary>
        /// The ID of the External Contact associated with the Case.
        /// </summary>
        /// <value>The ID of the External Contact associated with the Case.</value>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }



        /// <summary>
        /// The ID of conversation associated with the Case.
        /// </summary>
        /// <value>The ID of conversation associated with the Case.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// The ID of the workitem associated with the Case.
        /// </summary>
        /// <value>The ID of the workitem associated with the Case.</value>
        [DataMember(Name="workitemId", EmitDefaultValue=false)]
        public string WorkitemId { get; set; }



        /// <summary>
        /// The epoch timestamp in seconds specifying the time-to-live for the lifetime of the Case. Can not be greater than 365 days from the current time.
        /// </summary>
        /// <value>The epoch timestamp in seconds specifying the time-to-live for the lifetime of the Case. Can not be greater than 365 days from the current time.</value>
        [DataMember(Name="ttlSeconds", EmitDefaultValue=false)]
        public int? TtlSeconds { get; set; }



        /// <summary>
        /// The intake data for the Case. Maximum of 10 intake objects allowed.
        /// </summary>
        /// <value>The intake data for the Case. Maximum of 10 intake objects allowed.</value>
        [DataMember(Name="intake", EmitDefaultValue=false)]
        public List<Intake> Intake { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseCreate {\n");

            sb.Append("  CaseplanId: ").Append(CaseplanId).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  WorkitemId: ").Append(WorkitemId).Append("\n");
            sb.Append("  TtlSeconds: ").Append(TtlSeconds).Append("\n");
            sb.Append("  Intake: ").Append(Intake).Append("\n");
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
            return this.Equals(obj as CaseCreate);
        }

        /// <summary>
        /// Returns true if CaseCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CaseplanId == other.CaseplanId ||
                    this.CaseplanId != null &&
                    this.CaseplanId.Equals(other.CaseplanId)
                ) &&
                (
                    this.OwnerId == other.OwnerId ||
                    this.OwnerId != null &&
                    this.OwnerId.Equals(other.OwnerId)
                ) &&
                (
                    this.Summary == other.Summary ||
                    this.Summary != null &&
                    this.Summary.Equals(other.Summary)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.WorkitemId == other.WorkitemId ||
                    this.WorkitemId != null &&
                    this.WorkitemId.Equals(other.WorkitemId)
                ) &&
                (
                    this.TtlSeconds == other.TtlSeconds ||
                    this.TtlSeconds != null &&
                    this.TtlSeconds.Equals(other.TtlSeconds)
                ) &&
                (
                    this.Intake == other.Intake ||
                    this.Intake != null &&
                    this.Intake.SequenceEqual(other.Intake)
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
                if (this.CaseplanId != null)
                    hash = hash * 59 + this.CaseplanId.GetHashCode();

                if (this.OwnerId != null)
                    hash = hash * 59 + this.OwnerId.GetHashCode();

                if (this.Summary != null)
                    hash = hash * 59 + this.Summary.GetHashCode();

                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.WorkitemId != null)
                    hash = hash * 59 + this.WorkitemId.GetHashCode();

                if (this.TtlSeconds != null)
                    hash = hash * 59 + this.TtlSeconds.GetHashCode();

                if (this.Intake != null)
                    hash = hash * 59 + this.Intake.GetHashCode();

                return hash;
            }
        }
    }

}
