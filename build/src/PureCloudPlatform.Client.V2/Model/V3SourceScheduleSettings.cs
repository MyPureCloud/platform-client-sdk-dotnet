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
    /// V3SourceScheduleSettings
    /// </summary>
    [DataContract]
    public partial class V3SourceScheduleSettings :  IEquatable<V3SourceScheduleSettings>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceScheduleSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V3SourceScheduleSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceScheduleSettings" /> class.
        /// </summary>
        /// <param name="DateStart">The date-time value of the first sync run. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="Period">The time between syncs, in hours, until a new sync is run. (required).</param>
        public V3SourceScheduleSettings(DateTime? DateStart = null, int? Period = null)
        {
            this.DateStart = DateStart;
            this.Period = Period;
            
        }
        


        /// <summary>
        /// The date-time value of the first sync run. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date-time value of the first sync run. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }



        /// <summary>
        /// The time between syncs, in hours, until a new sync is run.
        /// </summary>
        /// <value>The time between syncs, in hours, until a new sync is run.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SourceScheduleSettings {\n");

            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
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
            return this.Equals(obj as V3SourceScheduleSettings);
        }

        /// <summary>
        /// Returns true if V3SourceScheduleSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SourceScheduleSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SourceScheduleSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
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
                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();

                return hash;
            }
        }
    }

}
