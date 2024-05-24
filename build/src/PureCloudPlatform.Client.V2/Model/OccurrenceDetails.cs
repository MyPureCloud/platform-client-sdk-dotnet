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
    /// OccurrenceDetails
    /// </summary>
    [DataContract]
    public partial class OccurrenceDetails :  IEquatable<OccurrenceDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OccurrenceDetails" /> class.
        /// </summary>
        /// <param name="DateOfNextOccurrence">The date of the next start or end occurrence for the recurrence as an ISO-8601 string.</param>
        /// <param name="NumberOfOccurrences">The number of start or end occurrences that have been processed for the recurrence..</param>
        public OccurrenceDetails(DateTime? DateOfNextOccurrence = null, int? NumberOfOccurrences = null)
        {
            this.DateOfNextOccurrence = DateOfNextOccurrence;
            this.NumberOfOccurrences = NumberOfOccurrences;
            
        }
        


        /// <summary>
        /// The date of the next start or end occurrence for the recurrence as an ISO-8601 string
        /// </summary>
        /// <value>The date of the next start or end occurrence for the recurrence as an ISO-8601 string</value>
        [DataMember(Name="dateOfNextOccurrence", EmitDefaultValue=false)]
        public DateTime? DateOfNextOccurrence { get; set; }



        /// <summary>
        /// The number of start or end occurrences that have been processed for the recurrence.
        /// </summary>
        /// <value>The number of start or end occurrences that have been processed for the recurrence.</value>
        [DataMember(Name="numberOfOccurrences", EmitDefaultValue=false)]
        public int? NumberOfOccurrences { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OccurrenceDetails {\n");

            sb.Append("  DateOfNextOccurrence: ").Append(DateOfNextOccurrence).Append("\n");
            sb.Append("  NumberOfOccurrences: ").Append(NumberOfOccurrences).Append("\n");
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
            return this.Equals(obj as OccurrenceDetails);
        }

        /// <summary>
        /// Returns true if OccurrenceDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of OccurrenceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OccurrenceDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateOfNextOccurrence == other.DateOfNextOccurrence ||
                    this.DateOfNextOccurrence != null &&
                    this.DateOfNextOccurrence.Equals(other.DateOfNextOccurrence)
                ) &&
                (
                    this.NumberOfOccurrences == other.NumberOfOccurrences ||
                    this.NumberOfOccurrences != null &&
                    this.NumberOfOccurrences.Equals(other.NumberOfOccurrences)
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
                if (this.DateOfNextOccurrence != null)
                    hash = hash * 59 + this.DateOfNextOccurrence.GetHashCode();

                if (this.NumberOfOccurrences != null)
                    hash = hash * 59 + this.NumberOfOccurrences.GetHashCode();

                return hash;
            }
        }
    }

}
