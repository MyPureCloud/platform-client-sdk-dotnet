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
    /// UnavailableTimesTimeSpan
    /// </summary>
    [DataContract]
    public partial class UnavailableTimesTimeSpan :  IEquatable<UnavailableTimesTimeSpan>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableTimesTimeSpan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnavailableTimesTimeSpan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableTimesTimeSpan" /> class.
        /// </summary>
        /// <param name="StartDate">Start date of the time span. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="LengthMinutes">The length of the time span from the start date in minutes (required).</param>
        public UnavailableTimesTimeSpan(DateTime? StartDate = null, int? LengthMinutes = null)
        {
            this.StartDate = StartDate;
            this.LengthMinutes = LengthMinutes;
            
        }
        


        /// <summary>
        /// Start date of the time span. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Start date of the time span. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// The length of the time span from the start date in minutes
        /// </summary>
        /// <value>The length of the time span from the start date in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnavailableTimesTimeSpan {\n");

            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
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
            return this.Equals(obj as UnavailableTimesTimeSpan);
        }

        /// <summary>
        /// Returns true if UnavailableTimesTimeSpan instances are equal
        /// </summary>
        /// <param name="other">Instance of UnavailableTimesTimeSpan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnavailableTimesTimeSpan other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
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
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                return hash;
            }
        }
    }

}
