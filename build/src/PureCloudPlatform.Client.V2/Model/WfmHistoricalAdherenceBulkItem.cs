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
    /// WfmHistoricalAdherenceBulkItem
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceBulkItem :  IEquatable<WfmHistoricalAdherenceBulkItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WfmHistoricalAdherenceBulkItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkItem" /> class.
        /// </summary>
        /// <param name="ManagementUnitId">The ID of the management unit to query (required).</param>
        /// <param name="StartDate">Beginning of the date range to query in ISO-8601 format (required).</param>
        /// <param name="EndDate">End of the date range to query in ISO-8601 format (required).</param>
        /// <param name="UserIds">The IDs of the users to query. If not included, will query every user in the management unit.</param>
        /// <param name="IncludeExceptions">Whether user exceptions should be returned as part of the results. If not included, will default to false.</param>
        public WfmHistoricalAdherenceBulkItem(string ManagementUnitId = null, DateTime? StartDate = null, DateTime? EndDate = null, List<string> UserIds = null, bool? IncludeExceptions = null)
        {
            this.ManagementUnitId = ManagementUnitId;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.UserIds = UserIds;
            this.IncludeExceptions = IncludeExceptions;
            
        }
        


        /// <summary>
        /// The ID of the management unit to query
        /// </summary>
        /// <value>The ID of the management unit to query</value>
        [DataMember(Name="managementUnitId", EmitDefaultValue=false)]
        public string ManagementUnitId { get; set; }



        /// <summary>
        /// Beginning of the date range to query in ISO-8601 format
        /// </summary>
        /// <value>Beginning of the date range to query in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// End of the date range to query in ISO-8601 format
        /// </summary>
        /// <value>End of the date range to query in ISO-8601 format</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }



        /// <summary>
        /// The IDs of the users to query. If not included, will query every user in the management unit
        /// </summary>
        /// <value>The IDs of the users to query. If not included, will query every user in the management unit</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<string> UserIds { get; set; }



        /// <summary>
        /// Whether user exceptions should be returned as part of the results. If not included, will default to false
        /// </summary>
        /// <value>Whether user exceptions should be returned as part of the results. If not included, will default to false</value>
        [DataMember(Name="includeExceptions", EmitDefaultValue=false)]
        public bool? IncludeExceptions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceBulkItem {\n");

            sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("  IncludeExceptions: ").Append(IncludeExceptions).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceBulkItem);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceBulkItem instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceBulkItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceBulkItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManagementUnitId == other.ManagementUnitId ||
                    this.ManagementUnitId != null &&
                    this.ManagementUnitId.Equals(other.ManagementUnitId)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
                ) &&
                (
                    this.IncludeExceptions == other.IncludeExceptions ||
                    this.IncludeExceptions != null &&
                    this.IncludeExceptions.Equals(other.IncludeExceptions)
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
                if (this.ManagementUnitId != null)
                    hash = hash * 59 + this.ManagementUnitId.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();

                if (this.IncludeExceptions != null)
                    hash = hash * 59 + this.IncludeExceptions.GetHashCode();

                return hash;
            }
        }
    }

}
