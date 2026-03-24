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
    /// DialerCampaignScheduleConfigChangeScheduleRecurrence
    /// </summary>
    [DataContract]
    public partial class DialerCampaignScheduleConfigChangeScheduleRecurrence :  IEquatable<DialerCampaignScheduleConfigChangeScheduleRecurrence>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCampaignScheduleConfigChangeScheduleRecurrence" /> class.
        /// </summary>
        /// <param name="Id">the recurrence id.</param>
        /// <param name="Start">scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="End">scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="TimeZone">the timezone the recurrence will use.</param>
        /// <param name="Range">Range.</param>
        /// <param name="Pattern">Pattern.</param>
        /// <param name="Alterations">modifications to the original recurrence schedule.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public DialerCampaignScheduleConfigChangeScheduleRecurrence(string Id = null, string Start = null, string End = null, string TimeZone = null, DialerCampaignScheduleConfigChangeRecurrenceRange Range = null, DialerCampaignScheduleConfigChangeRecurrencePattern Pattern = null, List<DialerCampaignScheduleConfigChangeAlteration> Alterations = null, Dictionary<string, Object> AdditionalProperties = null)
        {
            this.Id = Id;
            this.Start = Start;
            this.End = End;
            this.TimeZone = TimeZone;
            this.Range = Range;
            this.Pattern = Pattern;
            this.Alterations = Alterations;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        


        /// <summary>
        /// the recurrence id
        /// </summary>
        /// <value>the recurrence id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public string Start { get; set; }



        /// <summary>
        /// scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public string End { get; set; }



        /// <summary>
        /// the timezone the recurrence will use
        /// </summary>
        /// <value>the timezone the recurrence will use</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }



        /// <summary>
        /// Gets or Sets Range
        /// </summary>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public DialerCampaignScheduleConfigChangeRecurrenceRange Range { get; set; }



        /// <summary>
        /// Gets or Sets Pattern
        /// </summary>
        [DataMember(Name="pattern", EmitDefaultValue=false)]
        public DialerCampaignScheduleConfigChangeRecurrencePattern Pattern { get; set; }



        /// <summary>
        /// modifications to the original recurrence schedule
        /// </summary>
        /// <value>modifications to the original recurrence schedule</value>
        [DataMember(Name="alterations", EmitDefaultValue=false)]
        public List<DialerCampaignScheduleConfigChangeAlteration> Alterations { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCampaignScheduleConfigChangeScheduleRecurrence {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  Alterations: ").Append(Alterations).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as DialerCampaignScheduleConfigChangeScheduleRecurrence);
        }

        /// <summary>
        /// Returns true if DialerCampaignScheduleConfigChangeScheduleRecurrence instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCampaignScheduleConfigChangeScheduleRecurrence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCampaignScheduleConfigChangeScheduleRecurrence other)
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
                    this.Start == other.Start ||
                    this.Start != null &&
                    this.Start.Equals(other.Start)
                ) &&
                (
                    this.End == other.End ||
                    this.End != null &&
                    this.End.Equals(other.End)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) &&
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
                ) &&
                (
                    this.Pattern == other.Pattern ||
                    this.Pattern != null &&
                    this.Pattern.Equals(other.Pattern)
                ) &&
                (
                    this.Alterations == other.Alterations ||
                    this.Alterations != null &&
                    this.Alterations.SequenceEqual(other.Alterations)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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

                if (this.Start != null)
                    hash = hash * 59 + this.Start.GetHashCode();

                if (this.End != null)
                    hash = hash * 59 + this.End.GetHashCode();

                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();

                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();

                if (this.Pattern != null)
                    hash = hash * 59 + this.Pattern.GetHashCode();

                if (this.Alterations != null)
                    hash = hash * 59 + this.Alterations.GetHashCode();

                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

                return hash;
            }
        }
    }

}
