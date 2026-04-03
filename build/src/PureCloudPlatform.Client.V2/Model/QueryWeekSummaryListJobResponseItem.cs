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
    /// QueryWeekSummaryListJobResponseItem
    /// </summary>
    [DataContract]
    public partial class QueryWeekSummaryListJobResponseItem :  IEquatable<QueryWeekSummaryListJobResponseItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryWeekSummaryListJobResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryWeekSummaryListJobResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryWeekSummaryListJobResponseItem" /> class.
        /// </summary>
        /// <param name="Weeks">Weekly summary counts of the trades for the requested weeks (required).</param>
        public QueryWeekSummaryListJobResponseItem(List<ShiftTradeWeekSummaryResponseItem> Weeks = null)
        {
            this.Weeks = Weeks;
            
        }
        


        /// <summary>
        /// Weekly summary counts of the trades for the requested weeks
        /// </summary>
        /// <value>Weekly summary counts of the trades for the requested weeks</value>
        [DataMember(Name="weeks", EmitDefaultValue=false)]
        public List<ShiftTradeWeekSummaryResponseItem> Weeks { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryWeekSummaryListJobResponseItem {\n");

            sb.Append("  Weeks: ").Append(Weeks).Append("\n");
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
            return this.Equals(obj as QueryWeekSummaryListJobResponseItem);
        }

        /// <summary>
        /// Returns true if QueryWeekSummaryListJobResponseItem instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryWeekSummaryListJobResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryWeekSummaryListJobResponseItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Weeks == other.Weeks ||
                    this.Weeks != null &&
                    this.Weeks.SequenceEqual(other.Weeks)
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
                if (this.Weeks != null)
                    hash = hash * 59 + this.Weeks.GetHashCode();

                return hash;
            }
        }
    }

}
