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
    /// QueryShiftTradeListJobRequest
    /// </summary>
    [DataContract]
    public partial class QueryShiftTradeListJobRequest :  IEquatable<QueryShiftTradeListJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryShiftTradeListJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryShiftTradeListJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryShiftTradeListJobRequest" /> class.
        /// </summary>
        /// <param name="ManagementUnitIds">The IDs of management units from which to query shift trades (required).</param>
        /// <param name="WeekDates">The start week dates in which to query shift trades in the business unit time zone (yyyy-MM-dd format) (required).</param>
        /// <param name="UserIds">The IDs of the users for whom to query trades (required).</param>
        public QueryShiftTradeListJobRequest(List<string> ManagementUnitIds = null, List<String> WeekDates = null, List<string> UserIds = null)
        {
            this.ManagementUnitIds = ManagementUnitIds;
            this.WeekDates = WeekDates;
            this.UserIds = UserIds;
            
        }
        


        /// <summary>
        /// The IDs of management units from which to query shift trades
        /// </summary>
        /// <value>The IDs of management units from which to query shift trades</value>
        [DataMember(Name="managementUnitIds", EmitDefaultValue=false)]
        public List<string> ManagementUnitIds { get; set; }



        /// <summary>
        /// The start week dates in which to query shift trades in the business unit time zone (yyyy-MM-dd format)
        /// </summary>
        /// <value>The start week dates in which to query shift trades in the business unit time zone (yyyy-MM-dd format)</value>
        [DataMember(Name="weekDates", EmitDefaultValue=false)]
        public List<String> WeekDates { get; set; }



        /// <summary>
        /// The IDs of the users for whom to query trades
        /// </summary>
        /// <value>The IDs of the users for whom to query trades</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<string> UserIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryShiftTradeListJobRequest {\n");

            sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
            sb.Append("  WeekDates: ").Append(WeekDates).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
            return this.Equals(obj as QueryShiftTradeListJobRequest);
        }

        /// <summary>
        /// Returns true if QueryShiftTradeListJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryShiftTradeListJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryShiftTradeListJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManagementUnitIds == other.ManagementUnitIds ||
                    this.ManagementUnitIds != null &&
                    this.ManagementUnitIds.SequenceEqual(other.ManagementUnitIds)
                ) &&
                (
                    this.WeekDates == other.WeekDates ||
                    this.WeekDates != null &&
                    this.WeekDates.SequenceEqual(other.WeekDates)
                ) &&
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
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
                if (this.ManagementUnitIds != null)
                    hash = hash * 59 + this.ManagementUnitIds.GetHashCode();

                if (this.WeekDates != null)
                    hash = hash * 59 + this.WeekDates.GetHashCode();

                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();

                return hash;
            }
        }
    }

}
