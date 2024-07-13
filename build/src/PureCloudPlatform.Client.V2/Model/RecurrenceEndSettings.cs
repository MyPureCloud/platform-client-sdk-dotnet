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
    /// RecurrenceEndSettings
    /// </summary>
    [DataContract]
    public partial class RecurrenceEndSettings :  IEquatable<RecurrenceEndSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceEndSettings" /> class.
        /// </summary>
        /// <param name="LastDate">The end date of the recurrence for the activity plan, in ISO-8601 format. Only one of lastDate or noEndDate may be set.</param>
        /// <param name="NoEndDate">Whether this activity plan should continue indefinitely. If set to true, lastDate must not be set.</param>
        public RecurrenceEndSettings(DateTime? LastDate = null, bool? NoEndDate = null)
        {
            this.LastDate = LastDate;
            this.NoEndDate = NoEndDate;
            
        }
        


        /// <summary>
        /// The end date of the recurrence for the activity plan, in ISO-8601 format. Only one of lastDate or noEndDate may be set
        /// </summary>
        /// <value>The end date of the recurrence for the activity plan, in ISO-8601 format. Only one of lastDate or noEndDate may be set</value>
        [DataMember(Name="lastDate", EmitDefaultValue=false)]
        public DateTime? LastDate { get; set; }



        /// <summary>
        /// Whether this activity plan should continue indefinitely. If set to true, lastDate must not be set
        /// </summary>
        /// <value>Whether this activity plan should continue indefinitely. If set to true, lastDate must not be set</value>
        [DataMember(Name="noEndDate", EmitDefaultValue=false)]
        public bool? NoEndDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecurrenceEndSettings {\n");

            sb.Append("  LastDate: ").Append(LastDate).Append("\n");
            sb.Append("  NoEndDate: ").Append(NoEndDate).Append("\n");
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
            return this.Equals(obj as RecurrenceEndSettings);
        }

        /// <summary>
        /// Returns true if RecurrenceEndSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of RecurrenceEndSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurrenceEndSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LastDate == other.LastDate ||
                    this.LastDate != null &&
                    this.LastDate.Equals(other.LastDate)
                ) &&
                (
                    this.NoEndDate == other.NoEndDate ||
                    this.NoEndDate != null &&
                    this.NoEndDate.Equals(other.NoEndDate)
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
                if (this.LastDate != null)
                    hash = hash * 59 + this.LastDate.GetHashCode();

                if (this.NoEndDate != null)
                    hash = hash * 59 + this.NoEndDate.GetHashCode();

                return hash;
            }
        }
    }

}
