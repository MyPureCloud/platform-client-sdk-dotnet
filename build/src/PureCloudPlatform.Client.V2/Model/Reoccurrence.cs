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
    /// Reoccurrence
    /// </summary>
    [DataContract]
    public partial class Reoccurrence :  IEquatable<Reoccurrence>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Reoccurrence" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Reoccurrence() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Reoccurrence" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Start">The start date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss (required).</param>
        /// <param name="End">The end date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss (required).</param>
        /// <param name="TimeZone">The time zone of the schedule e.g.:  America/New_York (required).</param>
        /// <param name="Pattern">The schedule pattern e.g.: Daily/Weekly (required).</param>
        /// <param name="Range">The schedule range e.g.: EndDate/NoEnd/Numbered (required).</param>
        /// <param name="Alterations">Modifications to the original recurrence schedule (Exclusions/Inclusions).</param>
        public Reoccurrence(string Id = null, string Start = null, string End = null, string TimeZone = null, Pattern Pattern = null, Range Range = null, List<Alteration> Alterations = null)
        {
            this.Id = Id;
            this.Start = Start;
            this.End = End;
            this.TimeZone = TimeZone;
            this.Pattern = Pattern;
            this.Range = Range;
            this.Alterations = Alterations;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The start date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>The start date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public string Start { get; set; }



        /// <summary>
        /// The end date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>The end date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public string End { get; set; }



        /// <summary>
        /// The time zone of the schedule e.g.:  America/New_York
        /// </summary>
        /// <value>The time zone of the schedule e.g.:  America/New_York</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }



        /// <summary>
        /// The schedule pattern e.g.: Daily/Weekly
        /// </summary>
        /// <value>The schedule pattern e.g.: Daily/Weekly</value>
        [DataMember(Name="pattern", EmitDefaultValue=false)]
        public Pattern Pattern { get; set; }



        /// <summary>
        /// The schedule range e.g.: EndDate/NoEnd/Numbered
        /// </summary>
        /// <value>The schedule range e.g.: EndDate/NoEnd/Numbered</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public Range Range { get; set; }



        /// <summary>
        /// Modifications to the original recurrence schedule (Exclusions/Inclusions)
        /// </summary>
        /// <value>Modifications to the original recurrence schedule (Exclusions/Inclusions)</value>
        [DataMember(Name="alterations", EmitDefaultValue=false)]
        public List<Alteration> Alterations { get; set; }



        /// <summary>
        /// The next occurrence details for the next start and end occurrences for the recurrence
        /// </summary>
        /// <value>The next occurrence details for the next start and end occurrences for the recurrence</value>
        [DataMember(Name="nextOccurrenceDetails", EmitDefaultValue=false)]
        public NextOccurrenceDetails NextOccurrenceDetails { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reoccurrence {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  Alterations: ").Append(Alterations).Append("\n");
            sb.Append("  NextOccurrenceDetails: ").Append(NextOccurrenceDetails).Append("\n");
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
            return this.Equals(obj as Reoccurrence);
        }

        /// <summary>
        /// Returns true if Reoccurrence instances are equal
        /// </summary>
        /// <param name="other">Instance of Reoccurrence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reoccurrence other)
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
                    this.Pattern == other.Pattern ||
                    this.Pattern != null &&
                    this.Pattern.Equals(other.Pattern)
                ) &&
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
                ) &&
                (
                    this.Alterations == other.Alterations ||
                    this.Alterations != null &&
                    this.Alterations.SequenceEqual(other.Alterations)
                ) &&
                (
                    this.NextOccurrenceDetails == other.NextOccurrenceDetails ||
                    this.NextOccurrenceDetails != null &&
                    this.NextOccurrenceDetails.Equals(other.NextOccurrenceDetails)
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

                if (this.Pattern != null)
                    hash = hash * 59 + this.Pattern.GetHashCode();

                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();

                if (this.Alterations != null)
                    hash = hash * 59 + this.Alterations.GetHashCode();

                if (this.NextOccurrenceDetails != null)
                    hash = hash * 59 + this.NextOccurrenceDetails.GetHashCode();

                return hash;
            }
        }
    }

}
