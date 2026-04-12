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
    /// JourneySessionEventsNotificationCaseAssociation
    /// </summary>
    [DataContract]
    public partial class JourneySessionEventsNotificationCaseAssociation :  IEquatable<JourneySessionEventsNotificationCaseAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneySessionEventsNotificationCaseAssociation" /> class.
        /// </summary>
        /// <param name="CaseId">CaseId.</param>
        /// <param name="CaseReference">CaseReference.</param>
        /// <param name="DateAssociated">DateAssociated.</param>
        public JourneySessionEventsNotificationCaseAssociation(Guid? CaseId = null, string CaseReference = null, DateTime? DateAssociated = null)
        {
            this.CaseId = CaseId;
            this.CaseReference = CaseReference;
            this.DateAssociated = DateAssociated;
            
        }
        


        /// <summary>
        /// Gets or Sets CaseId
        /// </summary>
        [DataMember(Name="caseId", EmitDefaultValue=false)]
        public Guid? CaseId { get; set; }



        /// <summary>
        /// Gets or Sets CaseReference
        /// </summary>
        [DataMember(Name="caseReference", EmitDefaultValue=false)]
        public string CaseReference { get; set; }



        /// <summary>
        /// Gets or Sets DateAssociated
        /// </summary>
        [DataMember(Name="dateAssociated", EmitDefaultValue=false)]
        public DateTime? DateAssociated { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneySessionEventsNotificationCaseAssociation {\n");

            sb.Append("  CaseId: ").Append(CaseId).Append("\n");
            sb.Append("  CaseReference: ").Append(CaseReference).Append("\n");
            sb.Append("  DateAssociated: ").Append(DateAssociated).Append("\n");
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
            return this.Equals(obj as JourneySessionEventsNotificationCaseAssociation);
        }

        /// <summary>
        /// Returns true if JourneySessionEventsNotificationCaseAssociation instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneySessionEventsNotificationCaseAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneySessionEventsNotificationCaseAssociation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CaseId == other.CaseId ||
                    this.CaseId != null &&
                    this.CaseId.Equals(other.CaseId)
                ) &&
                (
                    this.CaseReference == other.CaseReference ||
                    this.CaseReference != null &&
                    this.CaseReference.Equals(other.CaseReference)
                ) &&
                (
                    this.DateAssociated == other.DateAssociated ||
                    this.DateAssociated != null &&
                    this.DateAssociated.Equals(other.DateAssociated)
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
                if (this.CaseId != null)
                    hash = hash * 59 + this.CaseId.GetHashCode();

                if (this.CaseReference != null)
                    hash = hash * 59 + this.CaseReference.GetHashCode();

                if (this.DateAssociated != null)
                    hash = hash * 59 + this.DateAssociated.GetHashCode();

                return hash;
            }
        }
    }

}
