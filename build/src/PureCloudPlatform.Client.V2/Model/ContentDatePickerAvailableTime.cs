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
    /// A datepicker available time that a user can take.
    /// </summary>
    [DataContract]
    public partial class ContentDatePickerAvailableTime :  IEquatable<ContentDatePickerAvailableTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentDatePickerAvailableTime" /> class.
        /// </summary>
        /// <param name="Duration">The duration of the scheduling event in seconds..</param>
        /// <param name="DateTime">The date and times of the event being scheduled. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public ContentDatePickerAvailableTime(long? Duration = null, DateTime? DateTime = null)
        {
            this.Duration = Duration;
            this.DateTime = DateTime;
            
        }
        


        /// <summary>
        /// The duration of the scheduling event in seconds.
        /// </summary>
        /// <value>The duration of the scheduling event in seconds.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public long? Duration { get; set; }



        /// <summary>
        /// The date and times of the event being scheduled. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and times of the event being scheduled. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateTime", EmitDefaultValue=false)]
        public DateTime? DateTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentDatePickerAvailableTime {\n");

            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
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
            return this.Equals(obj as ContentDatePickerAvailableTime);
        }

        /// <summary>
        /// Returns true if ContentDatePickerAvailableTime instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentDatePickerAvailableTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentDatePickerAvailableTime other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) &&
                (
                    this.DateTime == other.DateTime ||
                    this.DateTime != null &&
                    this.DateTime.Equals(other.DateTime)
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
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();

                if (this.DateTime != null)
                    hash = hash * 59 + this.DateTime.GetHashCode();

                return hash;
            }
        }
    }

}
