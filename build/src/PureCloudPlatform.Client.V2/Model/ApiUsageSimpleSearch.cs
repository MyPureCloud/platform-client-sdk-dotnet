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
    /// ApiUsageSimpleSearch
    /// </summary>
    [DataContract]
    public partial class ApiUsageSimpleSearch :  IEquatable<ApiUsageSimpleSearch>
    {
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
            /// Enum Date for "Date"
            /// </summary>
            [EnumMember(Value = "Date")]
            Date,
            
            /// <summary>
            /// Enum Clientname for "ClientName"
            /// </summary>
            [EnumMember(Value = "ClientName")]
            Clientname,
            
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
            /// Enum Status500 for "Status500"
            /// </summary>
            [EnumMember(Value = "Status500")]
            Status500,
            
            /// <summary>
            /// Enum Status429 for "Status429"
            /// </summary>
            [EnumMember(Value = "Status429")]
            Status429
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
            /// Enum Delete for "DELETE"
            /// </summary>
            [EnumMember(Value = "DELETE")]
            Delete,
            
            /// <summary>
            /// Enum Patch for "PATCH"
            /// </summary>
            [EnumMember(Value = "PATCH")]
            Patch,
            
            /// <summary>
            /// Enum Put for "PUT"
            /// </summary>
            [EnumMember(Value = "PUT")]
            Put,
            
            /// <summary>
            /// Enum Head for "HEAD"
            /// </summary>
            [EnumMember(Value = "HEAD")]
            Head,
            
            /// <summary>
            /// Enum Connect for "CONNECT"
            /// </summary>
            [EnumMember(Value = "CONNECT")]
            Connect,
            
            /// <summary>
            /// Enum Options for "OPTIONS"
            /// </summary>
            [EnumMember(Value = "OPTIONS")]
            Options,
            
            /// <summary>
            /// Enum Trace for "TRACE"
            /// </summary>
            [EnumMember(Value = "TRACE")]
            Trace
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUsageSimpleSearch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiUsageSimpleSearch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUsageSimpleSearch" /> class.
        /// </summary>
        /// <param name="Interval">Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
        /// <param name="Metrics">Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *)..</param>
        /// <param name="OauthClientNames">Behaves like a SQL WHERE with multiple IN operators. Specifies a list of OAuth client names to be queried..</param>
        /// <param name="HttpMethods">Behaves like a SQL WHERE with multiple IN operators. Specifies a list of HTTP methods to be queried..</param>
        /// <param name="TemplateUris">Behaves like a SQL WHERE with multiple IN operators. Specifies a list of Template Uris to be queried..</param>
        public ApiUsageSimpleSearch(string Interval = null, List<MetricsEnum> Metrics = null, List<string> OauthClientNames = null, List<HttpMethodsEnum> HttpMethods = null, List<string> TemplateUris = null)
        {
            this.Interval = Interval;
            this.Metrics = Metrics;
            this.OauthClientNames = OauthClientNames;
            this.HttpMethods = HttpMethods;
            this.TemplateUris = TemplateUris;
            
        }
        


        /// <summary>
        /// Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }



        /// <summary>
        /// Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *).
        /// </summary>
        /// <value>Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *).</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<MetricsEnum> Metrics { get; set; }



        /// <summary>
        /// Behaves like a SQL WHERE with multiple IN operators. Specifies a list of OAuth client names to be queried.
        /// </summary>
        /// <value>Behaves like a SQL WHERE with multiple IN operators. Specifies a list of OAuth client names to be queried.</value>
        [DataMember(Name="oauthClientNames", EmitDefaultValue=false)]
        public List<string> OauthClientNames { get; set; }



        /// <summary>
        /// Behaves like a SQL WHERE with multiple IN operators. Specifies a list of HTTP methods to be queried.
        /// </summary>
        /// <value>Behaves like a SQL WHERE with multiple IN operators. Specifies a list of HTTP methods to be queried.</value>
        [DataMember(Name="httpMethods", EmitDefaultValue=false)]
        public List<HttpMethodsEnum> HttpMethods { get; set; }



        /// <summary>
        /// Behaves like a SQL WHERE with multiple IN operators. Specifies a list of Template Uris to be queried.
        /// </summary>
        /// <value>Behaves like a SQL WHERE with multiple IN operators. Specifies a list of Template Uris to be queried.</value>
        [DataMember(Name="templateUris", EmitDefaultValue=false)]
        public List<string> TemplateUris { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiUsageSimpleSearch {\n");

            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  OauthClientNames: ").Append(OauthClientNames).Append("\n");
            sb.Append("  HttpMethods: ").Append(HttpMethods).Append("\n");
            sb.Append("  TemplateUris: ").Append(TemplateUris).Append("\n");
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
            return this.Equals(obj as ApiUsageSimpleSearch);
        }

        /// <summary>
        /// Returns true if ApiUsageSimpleSearch instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiUsageSimpleSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiUsageSimpleSearch other)
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
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.OauthClientNames == other.OauthClientNames ||
                    this.OauthClientNames != null &&
                    this.OauthClientNames.SequenceEqual(other.OauthClientNames)
                ) &&
                (
                    this.HttpMethods == other.HttpMethods ||
                    this.HttpMethods != null &&
                    this.HttpMethods.SequenceEqual(other.HttpMethods)
                ) &&
                (
                    this.TemplateUris == other.TemplateUris ||
                    this.TemplateUris != null &&
                    this.TemplateUris.SequenceEqual(other.TemplateUris)
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

                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();

                if (this.OauthClientNames != null)
                    hash = hash * 59 + this.OauthClientNames.GetHashCode();

                if (this.HttpMethods != null)
                    hash = hash * 59 + this.HttpMethods.GetHashCode();

                if (this.TemplateUris != null)
                    hash = hash * 59 + this.TemplateUris.GetHashCode();

                return hash;
            }
        }
    }

}
