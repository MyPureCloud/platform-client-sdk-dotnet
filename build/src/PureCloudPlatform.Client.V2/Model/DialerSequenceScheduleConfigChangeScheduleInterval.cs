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
    /// DialerSequenceScheduleConfigChangeScheduleInterval
    /// </summary>
    [DataContract]
    public partial class DialerSequenceScheduleConfigChangeScheduleInterval :  IEquatable<DialerSequenceScheduleConfigChangeScheduleInterval>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerSequenceScheduleConfigChangeScheduleInterval" /> class.
        /// </summary>
        /// <param name="Start">scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="End">scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public DialerSequenceScheduleConfigChangeScheduleInterval(string Start = null, string End = null)
        {
            this.Start = Start;
            this.End = End;
            
        }
        


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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerSequenceScheduleConfigChangeScheduleInterval {\n");

            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
            return this.Equals(obj as DialerSequenceScheduleConfigChangeScheduleInterval);
        }

        /// <summary>
        /// Returns true if DialerSequenceScheduleConfigChangeScheduleInterval instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerSequenceScheduleConfigChangeScheduleInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerSequenceScheduleConfigChangeScheduleInterval other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Start == other.Start ||
                    this.Start != null &&
                    this.Start.Equals(other.Start)
                ) &&
                (
                    this.End == other.End ||
                    this.End != null &&
                    this.End.Equals(other.End)
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
                if (this.Start != null)
                    hash = hash * 59 + this.Start.GetHashCode();

                if (this.End != null)
                    hash = hash * 59 + this.End.GetHashCode();

                return hash;
            }
        }
    }

}
