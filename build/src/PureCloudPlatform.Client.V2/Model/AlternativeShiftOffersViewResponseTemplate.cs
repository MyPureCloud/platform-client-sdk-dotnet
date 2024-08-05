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
    /// AlternativeShiftOffersViewResponseTemplate
    /// </summary>
    [DataContract]
    public partial class AlternativeShiftOffersViewResponseTemplate :  IEquatable<AlternativeShiftOffersViewResponseTemplate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeShiftOffersViewResponseTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlternativeShiftOffersViewResponseTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeShiftOffersViewResponseTemplate" /> class.
        /// </summary>
        /// <param name="JobId">The unique identifier of the async list job that created this file (required).</param>
        /// <param name="BusinessUnitId">The unique identifier of the business unit to which the user (agent) belongs at the time the offer is created (required).</param>
        /// <param name="AgentId">The unique identifier of the agent for whom the offer was made (required).</param>
        /// <param name="ManagementUnitId">The unique identifier of the management unit to which the user (agent) belongs at the time the offer is created (required).</param>
        /// <param name="Schedule">The existing schedule information associated with the offer (required).</param>
        /// <param name="OfferWeekDate">The first date of the week for the schedule we are querying in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="Shifts">The shifts the agent is scheduled for at the time the offer is created (required).</param>
        /// <param name="AlternativeDays">The offered alternative shift days in this week at the time the offer is created (required).</param>
        public AlternativeShiftOffersViewResponseTemplate(string JobId = null, string BusinessUnitId = null, string AgentId = null, string ManagementUnitId = null, AlternativeShiftScheduleLookup Schedule = null, String OfferWeekDate = null, List<AlternativeShiftAgentScheduledShift> Shifts = null, List<AlternativeShiftAgentScheduledShift> AlternativeDays = null)
        {
            this.JobId = JobId;
            this.BusinessUnitId = BusinessUnitId;
            this.AgentId = AgentId;
            this.ManagementUnitId = ManagementUnitId;
            this.Schedule = Schedule;
            this.OfferWeekDate = OfferWeekDate;
            this.Shifts = Shifts;
            this.AlternativeDays = AlternativeDays;
            
        }
        


        /// <summary>
        /// The unique identifier of the async list job that created this file
        /// </summary>
        /// <value>The unique identifier of the async list job that created this file</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; set; }



        /// <summary>
        /// The unique identifier of the business unit to which the user (agent) belongs at the time the offer is created
        /// </summary>
        /// <value>The unique identifier of the business unit to which the user (agent) belongs at the time the offer is created</value>
        [DataMember(Name="businessUnitId", EmitDefaultValue=false)]
        public string BusinessUnitId { get; set; }



        /// <summary>
        /// The unique identifier of the agent for whom the offer was made
        /// </summary>
        /// <value>The unique identifier of the agent for whom the offer was made</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// The unique identifier of the management unit to which the user (agent) belongs at the time the offer is created
        /// </summary>
        /// <value>The unique identifier of the management unit to which the user (agent) belongs at the time the offer is created</value>
        [DataMember(Name="managementUnitId", EmitDefaultValue=false)]
        public string ManagementUnitId { get; set; }



        /// <summary>
        /// The existing schedule information associated with the offer
        /// </summary>
        /// <value>The existing schedule information associated with the offer</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public AlternativeShiftScheduleLookup Schedule { get; set; }



        /// <summary>
        /// The first date of the week for the schedule we are querying in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The first date of the week for the schedule we are querying in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="offerWeekDate", EmitDefaultValue=false)]
        public String OfferWeekDate { get; set; }



        /// <summary>
        /// The shifts the agent is scheduled for at the time the offer is created
        /// </summary>
        /// <value>The shifts the agent is scheduled for at the time the offer is created</value>
        [DataMember(Name="shifts", EmitDefaultValue=false)]
        public List<AlternativeShiftAgentScheduledShift> Shifts { get; set; }



        /// <summary>
        /// The offered alternative shift days in this week at the time the offer is created
        /// </summary>
        /// <value>The offered alternative shift days in this week at the time the offer is created</value>
        [DataMember(Name="alternativeDays", EmitDefaultValue=false)]
        public List<AlternativeShiftAgentScheduledShift> AlternativeDays { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlternativeShiftOffersViewResponseTemplate {\n");

            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  OfferWeekDate: ").Append(OfferWeekDate).Append("\n");
            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
            sb.Append("  AlternativeDays: ").Append(AlternativeDays).Append("\n");
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
            return this.Equals(obj as AlternativeShiftOffersViewResponseTemplate);
        }

        /// <summary>
        /// Returns true if AlternativeShiftOffersViewResponseTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of AlternativeShiftOffersViewResponseTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlternativeShiftOffersViewResponseTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.JobId == other.JobId ||
                    this.JobId != null &&
                    this.JobId.Equals(other.JobId)
                ) &&
                (
                    this.BusinessUnitId == other.BusinessUnitId ||
                    this.BusinessUnitId != null &&
                    this.BusinessUnitId.Equals(other.BusinessUnitId)
                ) &&
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) &&
                (
                    this.ManagementUnitId == other.ManagementUnitId ||
                    this.ManagementUnitId != null &&
                    this.ManagementUnitId.Equals(other.ManagementUnitId)
                ) &&
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this.OfferWeekDate == other.OfferWeekDate ||
                    this.OfferWeekDate != null &&
                    this.OfferWeekDate.Equals(other.OfferWeekDate)
                ) &&
                (
                    this.Shifts == other.Shifts ||
                    this.Shifts != null &&
                    this.Shifts.SequenceEqual(other.Shifts)
                ) &&
                (
                    this.AlternativeDays == other.AlternativeDays ||
                    this.AlternativeDays != null &&
                    this.AlternativeDays.SequenceEqual(other.AlternativeDays)
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
                if (this.JobId != null)
                    hash = hash * 59 + this.JobId.GetHashCode();

                if (this.BusinessUnitId != null)
                    hash = hash * 59 + this.BusinessUnitId.GetHashCode();

                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();

                if (this.ManagementUnitId != null)
                    hash = hash * 59 + this.ManagementUnitId.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                if (this.OfferWeekDate != null)
                    hash = hash * 59 + this.OfferWeekDate.GetHashCode();

                if (this.Shifts != null)
                    hash = hash * 59 + this.Shifts.GetHashCode();

                if (this.AlternativeDays != null)
                    hash = hash * 59 + this.AlternativeDays.GetHashCode();

                return hash;
            }
        }
    }

}
