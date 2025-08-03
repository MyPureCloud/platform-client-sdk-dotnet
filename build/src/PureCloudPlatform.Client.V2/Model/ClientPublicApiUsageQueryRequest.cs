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
    /// ClientPublicApiUsageQueryRequest
    /// </summary>
    [DataContract]
    public partial class ClientPublicApiUsageQueryRequest :  IEquatable<ClientPublicApiUsageQueryRequest>
    {
        /// <summary>
        /// Specify the granularity to aggregate the data to.
        /// </summary>
        /// <value>Specify the granularity to aggregate the data to.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GranularityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Day for "Day"
            /// </summary>
            [EnumMember(Value = "Day")]
            Day,
            
            /// <summary>
            /// Enum Week for "Week"
            /// </summary>
            [EnumMember(Value = "Week")]
            Week,
            
            /// <summary>
            /// Enum Month for "Month"
            /// </summary>
            [EnumMember(Value = "Month")]
            Month
        }
        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Requests for "Requests"
            /// </summary>
            [EnumMember(Value = "Requests")]
            Requests,
            
            /// <summary>
            /// Enum Status200 for "Status200"
            /// </summary>
            [EnumMember(Value = "Status200")]
            Status200,
            
            /// <summary>
            /// Enum Status300 for "Status300"
            /// </summary>
            [EnumMember(Value = "Status300")]
            Status300,
            
            /// <summary>
            /// Enum Status400 for "Status400"
            /// </summary>
            [EnumMember(Value = "Status400")]
            Status400,
            
            /// <summary>
            /// Enum Status429 for "Status429"
            /// </summary>
            [EnumMember(Value = "Status429")]
            Status429,
            
            /// <summary>
            /// Enum Status500 for "Status500"
            /// </summary>
            [EnumMember(Value = "Status500")]
            Status500
        }
        /// <summary>
        /// Gets or Sets HttpMethods
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum HttpMethodsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Get for "GET"
            /// </summary>
            [EnumMember(Value = "GET")]
            Get,
            
            /// <summary>
            /// Enum Post for "POST"
            /// </summary>
            [EnumMember(Value = "POST")]
            Post,
            
            /// <summary>
            /// Enum Put for "PUT"
            /// </summary>
            [EnumMember(Value = "PUT")]
            Put,
            
            /// <summary>
            /// Enum Patch for "PATCH"
            /// </summary>
            [EnumMember(Value = "PATCH")]
            Patch,
            
            /// <summary>
            /// Enum Delete for "DELETE"
            /// </summary>
            [EnumMember(Value = "DELETE")]
            Delete,
            
            /// <summary>
            /// Enum Head for "HEAD"
            /// </summary>
            [EnumMember(Value = "HEAD")]
            Head
        }
        /// <summary>
        /// Gets or Sets GroupBy
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GroupByEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Organizationid for "OrganizationId"
            /// </summary>
            [EnumMember(Value = "OrganizationId")]
            Organizationid,
            
            /// <summary>
            /// Enum Httpmethod for "HttpMethod"
            /// </summary>
            [EnumMember(Value = "HttpMethod")]
            Httpmethod,
            
            /// <summary>
            /// Enum Templateuri for "TemplateUri"
            /// </summary>
            [EnumMember(Value = "TemplateUri")]
            Templateuri,
            
            /// <summary>
            /// Enum Platform for "Platform"
            /// </summary>
            [EnumMember(Value = "Platform")]
            Platform
        }
        /// <summary>
        /// Specify the granularity to aggregate the data to.
        /// </summary>
        /// <value>Specify the granularity to aggregate the data to.</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public GranularityEnum? Granularity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPublicApiUsageQueryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientPublicApiUsageQueryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPublicApiUsageQueryRequest" /> class.
        /// </summary>
        /// <param name="Interval">Specify the interval to query on. Start and end are inclusive. Start date cannot be more than a year ago. End date cannot be more than 90 days after the start. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
        /// <param name="Granularity">Specify the granularity to aggregate the data to..</param>
        /// <param name="SortBy">Specify how to sort the returned data..</param>
        /// <param name="Metrics">Specify which metrics you want returned (all will be returned by default)..</param>
        /// <param name="TemplateUris">Specify if you only want a subset of templateUris represented in the query..</param>
        /// <param name="HttpMethods">Specify if you only want a subset of httpMethods represented in the query..</param>
        /// <param name="Platforms">Specify if you only want a subset of platforms represented in the query..</param>
        /// <param name="GroupBy">Specify how to aggregate the data (by default the data is not aggregated)..</param>
        /// <param name="OrganizationIds">Specify if you only want a subset of organizationIds represented in the query..</param>
        public ClientPublicApiUsageQueryRequest(string Interval = null, GranularityEnum? Granularity = null, List<UsageQuerySortBy> SortBy = null, List<MetricsEnum> Metrics = null, List<string> TemplateUris = null, List<HttpMethodsEnum> HttpMethods = null, List<string> Platforms = null, List<GroupByEnum> GroupBy = null, List<string> OrganizationIds = null)
        {
            this.Interval = Interval;
            this.Granularity = Granularity;
            this.SortBy = SortBy;
            this.Metrics = Metrics;
            this.TemplateUris = TemplateUris;
            this.HttpMethods = HttpMethods;
            this.Platforms = Platforms;
            this.GroupBy = GroupBy;
            this.OrganizationIds = OrganizationIds;
            
        }
        


        /// <summary>
        /// Specify the interval to query on. Start and end are inclusive. Start date cannot be more than a year ago. End date cannot be more than 90 days after the start. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Specify the interval to query on. Start and end are inclusive. Start date cannot be more than a year ago. End date cannot be more than 90 days after the start. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }





        /// <summary>
        /// Specify how to sort the returned data.
        /// </summary>
        /// <value>Specify how to sort the returned data.</value>
        [DataMember(Name="sortBy", EmitDefaultValue=false)]
        public List<UsageQuerySortBy> SortBy { get; set; }



        /// <summary>
        /// Specify which metrics you want returned (all will be returned by default).
        /// </summary>
        /// <value>Specify which metrics you want returned (all will be returned by default).</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<MetricsEnum> Metrics { get; set; }



        /// <summary>
        /// Specify if you only want a subset of templateUris represented in the query.
        /// </summary>
        /// <value>Specify if you only want a subset of templateUris represented in the query.</value>
        [DataMember(Name="templateUris", EmitDefaultValue=false)]
        public List<string> TemplateUris { get; set; }



        /// <summary>
        /// Specify if you only want a subset of httpMethods represented in the query.
        /// </summary>
        /// <value>Specify if you only want a subset of httpMethods represented in the query.</value>
        [DataMember(Name="httpMethods", EmitDefaultValue=false)]
        public List<HttpMethodsEnum> HttpMethods { get; set; }



        /// <summary>
        /// Specify if you only want a subset of platforms represented in the query.
        /// </summary>
        /// <value>Specify if you only want a subset of platforms represented in the query.</value>
        [DataMember(Name="platforms", EmitDefaultValue=false)]
        public List<string> Platforms { get; set; }



        /// <summary>
        /// Specify how to aggregate the data (by default the data is not aggregated).
        /// </summary>
        /// <value>Specify how to aggregate the data (by default the data is not aggregated).</value>
        [DataMember(Name="groupBy", EmitDefaultValue=false)]
        public List<GroupByEnum> GroupBy { get; set; }



        /// <summary>
        /// Specify if you only want a subset of organizationIds represented in the query.
        /// </summary>
        /// <value>Specify if you only want a subset of organizationIds represented in the query.</value>
        [DataMember(Name="organizationIds", EmitDefaultValue=false)]
        public List<string> OrganizationIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientPublicApiUsageQueryRequest {\n");

            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  TemplateUris: ").Append(TemplateUris).Append("\n");
            sb.Append("  HttpMethods: ").Append(HttpMethods).Append("\n");
            sb.Append("  Platforms: ").Append(Platforms).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  OrganizationIds: ").Append(OrganizationIds).Append("\n");
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
            return this.Equals(obj as ClientPublicApiUsageQueryRequest);
        }

        /// <summary>
        /// Returns true if ClientPublicApiUsageQueryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ClientPublicApiUsageQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientPublicApiUsageQueryRequest other)
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
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.SortBy == other.SortBy ||
                    this.SortBy != null &&
                    this.SortBy.SequenceEqual(other.SortBy)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.TemplateUris == other.TemplateUris ||
                    this.TemplateUris != null &&
                    this.TemplateUris.SequenceEqual(other.TemplateUris)
                ) &&
                (
                    this.HttpMethods == other.HttpMethods ||
                    this.HttpMethods != null &&
                    this.HttpMethods.SequenceEqual(other.HttpMethods)
                ) &&
                (
                    this.Platforms == other.Platforms ||
                    this.Platforms != null &&
                    this.Platforms.SequenceEqual(other.Platforms)
                ) &&
                (
                    this.GroupBy == other.GroupBy ||
                    this.GroupBy != null &&
                    this.GroupBy.SequenceEqual(other.GroupBy)
                ) &&
                (
                    this.OrganizationIds == other.OrganizationIds ||
                    this.OrganizationIds != null &&
                    this.OrganizationIds.SequenceEqual(other.OrganizationIds)
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

                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.SortBy != null)
                    hash = hash * 59 + this.SortBy.GetHashCode();

                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();

                if (this.TemplateUris != null)
                    hash = hash * 59 + this.TemplateUris.GetHashCode();

                if (this.HttpMethods != null)
                    hash = hash * 59 + this.HttpMethods.GetHashCode();

                if (this.Platforms != null)
                    hash = hash * 59 + this.Platforms.GetHashCode();

                if (this.GroupBy != null)
                    hash = hash * 59 + this.GroupBy.GetHashCode();

                if (this.OrganizationIds != null)
                    hash = hash * 59 + this.OrganizationIds.GetHashCode();

                return hash;
            }
        }
    }

}
