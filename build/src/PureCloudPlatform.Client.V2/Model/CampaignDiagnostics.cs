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
    /// CampaignDiagnostics
    /// </summary>
    [DataContract]
    public partial class CampaignDiagnostics :  IEquatable<CampaignDiagnostics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignDiagnostics" /> class.
        /// </summary>
        public CampaignDiagnostics()
        {
            
        }
        


        /// <summary>
        /// Campaign properties that can impact which contacts are callable
        /// </summary>
        /// <value>Campaign properties that can impact which contacts are callable</value>
        [DataMember(Name="callableContacts", EmitDefaultValue=false)]
        public CallableContactsDiagnostic CallableContacts { get; private set; }



        /// <summary>
        /// Information regarding the campaign's queue
        /// </summary>
        /// <value>Information regarding the campaign's queue</value>
        [DataMember(Name="queueUtilizationDiagnostic", EmitDefaultValue=false)]
        public QueueUtilizationDiagnostic QueueUtilizationDiagnostic { get; private set; }



        /// <summary>
        /// Information regarding the campaign's rule sets
        /// </summary>
        /// <value>Information regarding the campaign's rule sets</value>
        [DataMember(Name="ruleSetDiagnostics", EmitDefaultValue=false)]
        public List<RuleSetDiagnostic> RuleSetDiagnostics { get; private set; }



        /// <summary>
        /// Current number of outstanding interactions on the campaign
        /// </summary>
        /// <value>Current number of outstanding interactions on the campaign</value>
        [DataMember(Name="outstandingInteractionsCount", EmitDefaultValue=false)]
        public int? OutstandingInteractionsCount { get; private set; }



        /// <summary>
        /// Current number of scheduled interactions on the campaign
        /// </summary>
        /// <value>Current number of scheduled interactions on the campaign</value>
        [DataMember(Name="scheduledInteractionsCount", EmitDefaultValue=false)]
        public int? ScheduledInteractionsCount { get; private set; }



        /// <summary>
        /// Current number of time zone rescheduled calls on the campaign
        /// </summary>
        /// <value>Current number of time zone rescheduled calls on the campaign</value>
        [DataMember(Name="timeZoneRescheduledCallsCount", EmitDefaultValue=false)]
        public int? TimeZoneRescheduledCallsCount { get; private set; }



        /// <summary>
        /// Number of contacts that don't match filter. This is currently supported only for Campaigns with dynamic filter on.
        /// </summary>
        /// <value>Number of contacts that don't match filter. This is currently supported only for Campaigns with dynamic filter on.</value>
        [DataMember(Name="filteredOutContactsCount", EmitDefaultValue=false)]
        public int? FilteredOutContactsCount { get; private set; }



        /// <summary>
        /// Information regarding the campaign's skills
        /// </summary>
        /// <value>Information regarding the campaign's skills</value>
        [DataMember(Name="campaignSkillStatistics", EmitDefaultValue=false)]
        public CampaignSkillStatistics CampaignSkillStatistics { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignDiagnostics {\n");

            sb.Append("  CallableContacts: ").Append(CallableContacts).Append("\n");
            sb.Append("  QueueUtilizationDiagnostic: ").Append(QueueUtilizationDiagnostic).Append("\n");
            sb.Append("  RuleSetDiagnostics: ").Append(RuleSetDiagnostics).Append("\n");
            sb.Append("  OutstandingInteractionsCount: ").Append(OutstandingInteractionsCount).Append("\n");
            sb.Append("  ScheduledInteractionsCount: ").Append(ScheduledInteractionsCount).Append("\n");
            sb.Append("  TimeZoneRescheduledCallsCount: ").Append(TimeZoneRescheduledCallsCount).Append("\n");
            sb.Append("  FilteredOutContactsCount: ").Append(FilteredOutContactsCount).Append("\n");
            sb.Append("  CampaignSkillStatistics: ").Append(CampaignSkillStatistics).Append("\n");
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
            return this.Equals(obj as CampaignDiagnostics);
        }

        /// <summary>
        /// Returns true if CampaignDiagnostics instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignDiagnostics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignDiagnostics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CallableContacts == other.CallableContacts ||
                    this.CallableContacts != null &&
                    this.CallableContacts.Equals(other.CallableContacts)
                ) &&
                (
                    this.QueueUtilizationDiagnostic == other.QueueUtilizationDiagnostic ||
                    this.QueueUtilizationDiagnostic != null &&
                    this.QueueUtilizationDiagnostic.Equals(other.QueueUtilizationDiagnostic)
                ) &&
                (
                    this.RuleSetDiagnostics == other.RuleSetDiagnostics ||
                    this.RuleSetDiagnostics != null &&
                    this.RuleSetDiagnostics.SequenceEqual(other.RuleSetDiagnostics)
                ) &&
                (
                    this.OutstandingInteractionsCount == other.OutstandingInteractionsCount ||
                    this.OutstandingInteractionsCount != null &&
                    this.OutstandingInteractionsCount.Equals(other.OutstandingInteractionsCount)
                ) &&
                (
                    this.ScheduledInteractionsCount == other.ScheduledInteractionsCount ||
                    this.ScheduledInteractionsCount != null &&
                    this.ScheduledInteractionsCount.Equals(other.ScheduledInteractionsCount)
                ) &&
                (
                    this.TimeZoneRescheduledCallsCount == other.TimeZoneRescheduledCallsCount ||
                    this.TimeZoneRescheduledCallsCount != null &&
                    this.TimeZoneRescheduledCallsCount.Equals(other.TimeZoneRescheduledCallsCount)
                ) &&
                (
                    this.FilteredOutContactsCount == other.FilteredOutContactsCount ||
                    this.FilteredOutContactsCount != null &&
                    this.FilteredOutContactsCount.Equals(other.FilteredOutContactsCount)
                ) &&
                (
                    this.CampaignSkillStatistics == other.CampaignSkillStatistics ||
                    this.CampaignSkillStatistics != null &&
                    this.CampaignSkillStatistics.Equals(other.CampaignSkillStatistics)
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
                if (this.CallableContacts != null)
                    hash = hash * 59 + this.CallableContacts.GetHashCode();

                if (this.QueueUtilizationDiagnostic != null)
                    hash = hash * 59 + this.QueueUtilizationDiagnostic.GetHashCode();

                if (this.RuleSetDiagnostics != null)
                    hash = hash * 59 + this.RuleSetDiagnostics.GetHashCode();

                if (this.OutstandingInteractionsCount != null)
                    hash = hash * 59 + this.OutstandingInteractionsCount.GetHashCode();

                if (this.ScheduledInteractionsCount != null)
                    hash = hash * 59 + this.ScheduledInteractionsCount.GetHashCode();

                if (this.TimeZoneRescheduledCallsCount != null)
                    hash = hash * 59 + this.TimeZoneRescheduledCallsCount.GetHashCode();

                if (this.FilteredOutContactsCount != null)
                    hash = hash * 59 + this.FilteredOutContactsCount.GetHashCode();

                if (this.CampaignSkillStatistics != null)
                    hash = hash * 59 + this.CampaignSkillStatistics.GetHashCode();

                return hash;
            }
        }
    }

}
