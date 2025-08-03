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
    /// OrganizationPublicApiUsage
    /// </summary>
    [DataContract]
    public partial class OrganizationPublicApiUsage :  IEquatable<OrganizationPublicApiUsage>
    {
        /// <summary>
        /// The http method of the request(s)
        /// </summary>
        /// <value>The http method of the request(s)</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum HttpMethodEnum
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
        /// The http method of the request(s)
        /// </summary>
        /// <value>The http method of the request(s)</value>
        [DataMember(Name="httpMethod", EmitDefaultValue=false)]
        public HttpMethodEnum? HttpMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPublicApiUsage" /> class.
        /// </summary>
        /// <param name="Date">The date of the usage. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="Platform">The platform the request(s) is/were made on..</param>
        /// <param name="HttpMethod">The http method of the request(s).</param>
        /// <param name="TemplateUri">The templateUri of the request(s)..</param>
        /// <param name="RequestCount">The total number of requests..</param>
        /// <param name="Status200">The number of requests resulting in a 2xx HTTP status code..</param>
        /// <param name="Status300">The number of requests resulting in a 3xx HTTP status code..</param>
        /// <param name="Status400">The number of requests resulting in a 4xx HTTP status code..</param>
        /// <param name="Status429">The number of requests resulting in a 429 HTTP status code..</param>
        /// <param name="Status500">The number of requests resulting in a 5xx HTTP status code..</param>
        /// <param name="OauthClient">The id of the oauthClient that made the request(s)..</param>
        /// <param name="User">The id of the user who made the request(s)..</param>
        public OrganizationPublicApiUsage(String Date = null, string Platform = null, HttpMethodEnum? HttpMethod = null, string TemplateUri = null, long? RequestCount = null, long? Status200 = null, long? Status300 = null, long? Status400 = null, long? Status429 = null, long? Status500 = null, DomainEntityRef OauthClient = null, UserReference User = null)
        {
            this.Date = Date;
            this.Platform = Platform;
            this.HttpMethod = HttpMethod;
            this.TemplateUri = TemplateUri;
            this.RequestCount = RequestCount;
            this.Status200 = Status200;
            this.Status300 = Status300;
            this.Status400 = Status400;
            this.Status429 = Status429;
            this.Status500 = Status500;
            this.OauthClient = OauthClient;
            this.User = User;
            
        }
        


        /// <summary>
        /// The date of the usage. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The date of the usage. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public String Date { get; set; }



        /// <summary>
        /// The platform the request(s) is/were made on.
        /// </summary>
        /// <value>The platform the request(s) is/were made on.</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }





        /// <summary>
        /// The templateUri of the request(s).
        /// </summary>
        /// <value>The templateUri of the request(s).</value>
        [DataMember(Name="templateUri", EmitDefaultValue=false)]
        public string TemplateUri { get; set; }



        /// <summary>
        /// The total number of requests.
        /// </summary>
        /// <value>The total number of requests.</value>
        [DataMember(Name="requestCount", EmitDefaultValue=false)]
        public long? RequestCount { get; set; }



        /// <summary>
        /// The number of requests resulting in a 2xx HTTP status code.
        /// </summary>
        /// <value>The number of requests resulting in a 2xx HTTP status code.</value>
        [DataMember(Name="status200", EmitDefaultValue=false)]
        public long? Status200 { get; set; }



        /// <summary>
        /// The number of requests resulting in a 3xx HTTP status code.
        /// </summary>
        /// <value>The number of requests resulting in a 3xx HTTP status code.</value>
        [DataMember(Name="status300", EmitDefaultValue=false)]
        public long? Status300 { get; set; }



        /// <summary>
        /// The number of requests resulting in a 4xx HTTP status code.
        /// </summary>
        /// <value>The number of requests resulting in a 4xx HTTP status code.</value>
        [DataMember(Name="status400", EmitDefaultValue=false)]
        public long? Status400 { get; set; }



        /// <summary>
        /// The number of requests resulting in a 429 HTTP status code.
        /// </summary>
        /// <value>The number of requests resulting in a 429 HTTP status code.</value>
        [DataMember(Name="status429", EmitDefaultValue=false)]
        public long? Status429 { get; set; }



        /// <summary>
        /// The number of requests resulting in a 5xx HTTP status code.
        /// </summary>
        /// <value>The number of requests resulting in a 5xx HTTP status code.</value>
        [DataMember(Name="status500", EmitDefaultValue=false)]
        public long? Status500 { get; set; }



        /// <summary>
        /// The id of the oauthClient that made the request(s).
        /// </summary>
        /// <value>The id of the oauthClient that made the request(s).</value>
        [DataMember(Name="oauthClient", EmitDefaultValue=false)]
        public DomainEntityRef OauthClient { get; set; }



        /// <summary>
        /// The id of the user who made the request(s).
        /// </summary>
        /// <value>The id of the user who made the request(s).</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationPublicApiUsage {\n");

            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  HttpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  TemplateUri: ").Append(TemplateUri).Append("\n");
            sb.Append("  RequestCount: ").Append(RequestCount).Append("\n");
            sb.Append("  Status200: ").Append(Status200).Append("\n");
            sb.Append("  Status300: ").Append(Status300).Append("\n");
            sb.Append("  Status400: ").Append(Status400).Append("\n");
            sb.Append("  Status429: ").Append(Status429).Append("\n");
            sb.Append("  Status500: ").Append(Status500).Append("\n");
            sb.Append("  OauthClient: ").Append(OauthClient).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as OrganizationPublicApiUsage);
        }

        /// <summary>
        /// Returns true if OrganizationPublicApiUsage instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationPublicApiUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationPublicApiUsage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) &&
                (
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
                ) &&
                (
                    this.HttpMethod == other.HttpMethod ||
                    this.HttpMethod != null &&
                    this.HttpMethod.Equals(other.HttpMethod)
                ) &&
                (
                    this.TemplateUri == other.TemplateUri ||
                    this.TemplateUri != null &&
                    this.TemplateUri.Equals(other.TemplateUri)
                ) &&
                (
                    this.RequestCount == other.RequestCount ||
                    this.RequestCount != null &&
                    this.RequestCount.Equals(other.RequestCount)
                ) &&
                (
                    this.Status200 == other.Status200 ||
                    this.Status200 != null &&
                    this.Status200.Equals(other.Status200)
                ) &&
                (
                    this.Status300 == other.Status300 ||
                    this.Status300 != null &&
                    this.Status300.Equals(other.Status300)
                ) &&
                (
                    this.Status400 == other.Status400 ||
                    this.Status400 != null &&
                    this.Status400.Equals(other.Status400)
                ) &&
                (
                    this.Status429 == other.Status429 ||
                    this.Status429 != null &&
                    this.Status429.Equals(other.Status429)
                ) &&
                (
                    this.Status500 == other.Status500 ||
                    this.Status500 != null &&
                    this.Status500.Equals(other.Status500)
                ) &&
                (
                    this.OauthClient == other.OauthClient ||
                    this.OauthClient != null &&
                    this.OauthClient.Equals(other.OauthClient)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();

                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();

                if (this.HttpMethod != null)
                    hash = hash * 59 + this.HttpMethod.GetHashCode();

                if (this.TemplateUri != null)
                    hash = hash * 59 + this.TemplateUri.GetHashCode();

                if (this.RequestCount != null)
                    hash = hash * 59 + this.RequestCount.GetHashCode();

                if (this.Status200 != null)
                    hash = hash * 59 + this.Status200.GetHashCode();

                if (this.Status300 != null)
                    hash = hash * 59 + this.Status300.GetHashCode();

                if (this.Status400 != null)
                    hash = hash * 59 + this.Status400.GetHashCode();

                if (this.Status429 != null)
                    hash = hash * 59 + this.Status429.GetHashCode();

                if (this.Status500 != null)
                    hash = hash * 59 + this.Status500.GetHashCode();

                if (this.OauthClient != null)
                    hash = hash * 59 + this.OauthClient.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                return hash;
            }
        }
    }

}
