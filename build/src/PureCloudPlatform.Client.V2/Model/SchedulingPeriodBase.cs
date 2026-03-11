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
    /// SchedulingPeriodBase
    /// </summary>
    [DataContract]
    public partial class SchedulingPeriodBase :  IEquatable<SchedulingPeriodBase>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingPeriodBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SchedulingPeriodBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingPeriodBase" /> class.
        /// </summary>
        /// <param name="LatestEndDate">The latest date the associated activity plan can end, in YYYY-MM-DD format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        public SchedulingPeriodBase(String LatestEndDate = null)
        {
            this.LatestEndDate = LatestEndDate;
            
        }
        


        /// <summary>
        /// The latest date the associated activity plan can end, in YYYY-MM-DD format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The latest date the associated activity plan can end, in YYYY-MM-DD format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="latestEndDate", EmitDefaultValue=false)]
        public String LatestEndDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulingPeriodBase {\n");

            sb.Append("  LatestEndDate: ").Append(LatestEndDate).Append("\n");
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
            return this.Equals(obj as SchedulingPeriodBase);
        }

        /// <summary>
        /// Returns true if SchedulingPeriodBase instances are equal
        /// </summary>
        /// <param name="other">Instance of SchedulingPeriodBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingPeriodBase other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LatestEndDate == other.LatestEndDate ||
                    this.LatestEndDate != null &&
                    this.LatestEndDate.Equals(other.LatestEndDate)
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
                if (this.LatestEndDate != null)
                    hash = hash * 59 + this.LatestEndDate.GetHashCode();

                return hash;
            }
        }
    }

}
