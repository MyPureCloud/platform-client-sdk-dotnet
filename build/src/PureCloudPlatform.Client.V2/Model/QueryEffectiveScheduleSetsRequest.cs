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
    /// QueryEffectiveScheduleSetsRequest
    /// </summary>
    [DataContract]
    public partial class QueryEffectiveScheduleSetsRequest :  IEquatable<QueryEffectiveScheduleSetsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEffectiveScheduleSetsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryEffectiveScheduleSetsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEffectiveScheduleSetsRequest" /> class.
        /// </summary>
        /// <param name="StartDate">The start date for querying effective bids relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="WeekCount">The number of weeks to query for effective bids (required).</param>
        public QueryEffectiveScheduleSetsRequest(String StartDate = null, int? WeekCount = null)
        {
            this.StartDate = StartDate;
            this.WeekCount = WeekCount;
            
        }
        


        /// <summary>
        /// The start date for querying effective bids relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start date for querying effective bids relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public String StartDate { get; set; }



        /// <summary>
        /// The number of weeks to query for effective bids
        /// </summary>
        /// <value>The number of weeks to query for effective bids</value>
        [DataMember(Name="weekCount", EmitDefaultValue=false)]
        public int? WeekCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryEffectiveScheduleSetsRequest {\n");

            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
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
            return this.Equals(obj as QueryEffectiveScheduleSetsRequest);
        }

        /// <summary>
        /// Returns true if QueryEffectiveScheduleSetsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryEffectiveScheduleSetsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryEffectiveScheduleSetsRequest other)
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
                    this.WeekCount == other.WeekCount ||
                    this.WeekCount != null &&
                    this.WeekCount.Equals(other.WeekCount)
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

                if (this.WeekCount != null)
                    hash = hash * 59 + this.WeekCount.GetHashCode();

                return hash;
            }
        }
    }

}
