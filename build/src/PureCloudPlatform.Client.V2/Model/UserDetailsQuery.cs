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
    /// UserDetailsQuery
    /// </summary>
    [DataContract]
    public partial class UserDetailsQuery :  IEquatable<UserDetailsQuery>
    {
        /// <summary>
        /// Sort the result set in ascending/descending order. Default is ascending
        /// </summary>
        /// <value>Sort the result set in ascending/descending order. Default is ascending</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OrderEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Asc for "asc"
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc,
            
            /// <summary>
            /// Enum Desc for "desc"
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc
        }
        /// <summary>
        /// Sort the result set in ascending/descending order. Default is ascending
        /// </summary>
        /// <value>Sort the result set in ascending/descending order. Default is ascending</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public OrderEnum? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDetailsQuery" /> class.
        /// </summary>
        /// <param name="Interval">Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
        /// <param name="UserFilters">Filters that target the users to retrieve data for.</param>
        /// <param name="PresenceFilters">Filters that target system and organization presence-level data.</param>
        /// <param name="RoutingStatusFilters">Filters that target agent routing status-level data.</param>
        /// <param name="PresenceAggregations">Include faceted search and aggregate roll-ups of presence data in your search results. This does not function as a filter, but rather, summary data about the presence results matching your filters.</param>
        /// <param name="RoutingStatusAggregations">Include faceted search and aggregate roll-ups of agent routing status data in your search results. This does not function as a filter, but rather, summary data about the agent routing status results matching your filters.</param>
        /// <param name="Paging">Page size and number to control iterating through large result sets. Default page size is 25.</param>
        /// <param name="Order">Sort the result set in ascending/descending order. Default is ascending.</param>
        public UserDetailsQuery(string Interval = null, List<AnalyticsQueryFilter> UserFilters = null, List<AnalyticsQueryFilter> PresenceFilters = null, List<AnalyticsQueryFilter> RoutingStatusFilters = null, List<AnalyticsQueryAggregation> PresenceAggregations = null, List<AnalyticsQueryAggregation> RoutingStatusAggregations = null, PagingSpec Paging = null, OrderEnum? Order = null)
        {
            this.Interval = Interval;
            this.UserFilters = UserFilters;
            this.PresenceFilters = PresenceFilters;
            this.RoutingStatusFilters = RoutingStatusFilters;
            this.PresenceAggregations = PresenceAggregations;
            this.RoutingStatusAggregations = RoutingStatusAggregations;
            this.Paging = Paging;
            this.Order = Order;
        }
        
        /// <summary>
        /// Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }
        /// <summary>
        /// Filters that target the users to retrieve data for
        /// </summary>
        /// <value>Filters that target the users to retrieve data for</value>
        [DataMember(Name="userFilters", EmitDefaultValue=false)]
        public List<AnalyticsQueryFilter> UserFilters { get; set; }
        /// <summary>
        /// Filters that target system and organization presence-level data
        /// </summary>
        /// <value>Filters that target system and organization presence-level data</value>
        [DataMember(Name="presenceFilters", EmitDefaultValue=false)]
        public List<AnalyticsQueryFilter> PresenceFilters { get; set; }
        /// <summary>
        /// Filters that target agent routing status-level data
        /// </summary>
        /// <value>Filters that target agent routing status-level data</value>
        [DataMember(Name="routingStatusFilters", EmitDefaultValue=false)]
        public List<AnalyticsQueryFilter> RoutingStatusFilters { get; set; }
        /// <summary>
        /// Include faceted search and aggregate roll-ups of presence data in your search results. This does not function as a filter, but rather, summary data about the presence results matching your filters
        /// </summary>
        /// <value>Include faceted search and aggregate roll-ups of presence data in your search results. This does not function as a filter, but rather, summary data about the presence results matching your filters</value>
        [DataMember(Name="presenceAggregations", EmitDefaultValue=false)]
        public List<AnalyticsQueryAggregation> PresenceAggregations { get; set; }
        /// <summary>
        /// Include faceted search and aggregate roll-ups of agent routing status data in your search results. This does not function as a filter, but rather, summary data about the agent routing status results matching your filters
        /// </summary>
        /// <value>Include faceted search and aggregate roll-ups of agent routing status data in your search results. This does not function as a filter, but rather, summary data about the agent routing status results matching your filters</value>
        [DataMember(Name="routingStatusAggregations", EmitDefaultValue=false)]
        public List<AnalyticsQueryAggregation> RoutingStatusAggregations { get; set; }
        /// <summary>
        /// Page size and number to control iterating through large result sets. Default page size is 25
        /// </summary>
        /// <value>Page size and number to control iterating through large result sets. Default page size is 25</value>
        [DataMember(Name="paging", EmitDefaultValue=false)]
        public PagingSpec Paging { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserDetailsQuery {\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  UserFilters: ").Append(UserFilters).Append("\n");
            sb.Append("  PresenceFilters: ").Append(PresenceFilters).Append("\n");
            sb.Append("  RoutingStatusFilters: ").Append(RoutingStatusFilters).Append("\n");
            sb.Append("  PresenceAggregations: ").Append(PresenceAggregations).Append("\n");
            sb.Append("  RoutingStatusAggregations: ").Append(RoutingStatusAggregations).Append("\n");
            sb.Append("  Paging: ").Append(Paging).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UserDetailsQuery);
        }

        /// <summary>
        /// Returns true if UserDetailsQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of UserDetailsQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDetailsQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.UserFilters == other.UserFilters ||
                    this.UserFilters != null &&
                    this.UserFilters.SequenceEqual(other.UserFilters)
                ) &&
                (
                    this.PresenceFilters == other.PresenceFilters ||
                    this.PresenceFilters != null &&
                    this.PresenceFilters.SequenceEqual(other.PresenceFilters)
                ) &&
                (
                    this.RoutingStatusFilters == other.RoutingStatusFilters ||
                    this.RoutingStatusFilters != null &&
                    this.RoutingStatusFilters.SequenceEqual(other.RoutingStatusFilters)
                ) &&
                (
                    this.PresenceAggregations == other.PresenceAggregations ||
                    this.PresenceAggregations != null &&
                    this.PresenceAggregations.SequenceEqual(other.PresenceAggregations)
                ) &&
                (
                    this.RoutingStatusAggregations == other.RoutingStatusAggregations ||
                    this.RoutingStatusAggregations != null &&
                    this.RoutingStatusAggregations.SequenceEqual(other.RoutingStatusAggregations)
                ) &&
                (
                    this.Paging == other.Paging ||
                    this.Paging != null &&
                    this.Paging.Equals(other.Paging)
                ) &&
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();
                if (this.UserFilters != null)
                    hash = hash * 59 + this.UserFilters.GetHashCode();
                if (this.PresenceFilters != null)
                    hash = hash * 59 + this.PresenceFilters.GetHashCode();
                if (this.RoutingStatusFilters != null)
                    hash = hash * 59 + this.RoutingStatusFilters.GetHashCode();
                if (this.PresenceAggregations != null)
                    hash = hash * 59 + this.PresenceAggregations.GetHashCode();
                if (this.RoutingStatusAggregations != null)
                    hash = hash * 59 + this.RoutingStatusAggregations.GetHashCode();
                if (this.Paging != null)
                    hash = hash * 59 + this.Paging.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                return hash;
            }
        }
    }

}
