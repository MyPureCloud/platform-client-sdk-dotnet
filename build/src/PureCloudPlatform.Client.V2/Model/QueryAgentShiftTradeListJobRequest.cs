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
    /// QueryAgentShiftTradeListJobRequest
    /// </summary>
    [DataContract]
    public partial class QueryAgentShiftTradeListJobRequest :  IEquatable<QueryAgentShiftTradeListJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAgentShiftTradeListJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryAgentShiftTradeListJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAgentShiftTradeListJobRequest" /> class.
        /// </summary>
        /// <param name="WeekDates">The start week dates in which to query shift trades in the business unit time zone (yyyy-MM-dd format) (required).</param>
        public QueryAgentShiftTradeListJobRequest(List<String> WeekDates = null)
        {
            this.WeekDates = WeekDates;
            
        }
        


        /// <summary>
        /// The start week dates in which to query shift trades in the business unit time zone (yyyy-MM-dd format)
        /// </summary>
        /// <value>The start week dates in which to query shift trades in the business unit time zone (yyyy-MM-dd format)</value>
        [DataMember(Name="weekDates", EmitDefaultValue=false)]
        public List<String> WeekDates { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryAgentShiftTradeListJobRequest {\n");

            sb.Append("  WeekDates: ").Append(WeekDates).Append("\n");
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
            return this.Equals(obj as QueryAgentShiftTradeListJobRequest);
        }

        /// <summary>
        /// Returns true if QueryAgentShiftTradeListJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryAgentShiftTradeListJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryAgentShiftTradeListJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WeekDates == other.WeekDates ||
                    this.WeekDates != null &&
                    this.WeekDates.SequenceEqual(other.WeekDates)
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
                if (this.WeekDates != null)
                    hash = hash * 59 + this.WeekDates.GetHashCode();

                return hash;
            }
        }
    }

}
