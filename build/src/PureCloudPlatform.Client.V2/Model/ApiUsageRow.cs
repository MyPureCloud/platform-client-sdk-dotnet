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
    /// ApiUsageRow
    /// </summary>
    [DataContract]
    public partial class ApiUsageRow :  IEquatable<ApiUsageRow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUsageRow" /> class.
        /// </summary>
        /// <param name="ClientId">Client Id associated with this query result.</param>
        /// <param name="ClientName">Client Name associated with this query result.</param>
        /// <param name="OrganizationId">Organization Id associated with this query result.</param>
        /// <param name="UserId">User Id associated with this query result.</param>
        /// <param name="TemplateUri">Template Uri associated with this query result.</param>
        /// <param name="HttpMethod">HTTP Method associated with this query result.</param>
        /// <param name="Status200">Number of requests resulting in a 2xx HTTP status code.</param>
        /// <param name="Status300">Number of requests resulting in a 3xx HTTP status code.</param>
        /// <param name="Status400">Number of requests resulting in a 4xx HTTP status code.</param>
        /// <param name="Status500">Number of requests resulting in a 5xx HTTP status code.</param>
        /// <param name="Status429">Number of requests resulting in a 429 HTTP status code, this is a subset of the count returned with status400.</param>
        /// <param name="Requests">Total number of requests.</param>
        /// <param name="Date">Date of requests, based on granularity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public ApiUsageRow(string ClientId = null, string ClientName = null, string OrganizationId = null, string UserId = null, string TemplateUri = null, string HttpMethod = null, long? Status200 = null, long? Status300 = null, long? Status400 = null, long? Status500 = null, long? Status429 = null, long? Requests = null, DateTime? Date = null)
        {
            this.ClientId = ClientId;
            this.ClientName = ClientName;
            this.OrganizationId = OrganizationId;
            this.UserId = UserId;
            this.TemplateUri = TemplateUri;
            this.HttpMethod = HttpMethod;
            this.Status200 = Status200;
            this.Status300 = Status300;
            this.Status400 = Status400;
            this.Status500 = Status500;
            this.Status429 = Status429;
            this.Requests = Requests;
            this.Date = Date;
            
        }
        


        /// <summary>
        /// Client Id associated with this query result
        /// </summary>
        /// <value>Client Id associated with this query result</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }



        /// <summary>
        /// Client Name associated with this query result
        /// </summary>
        /// <value>Client Name associated with this query result</value>
        [DataMember(Name="clientName", EmitDefaultValue=false)]
        public string ClientName { get; set; }



        /// <summary>
        /// Organization Id associated with this query result
        /// </summary>
        /// <value>Organization Id associated with this query result</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }



        /// <summary>
        /// User Id associated with this query result
        /// </summary>
        /// <value>User Id associated with this query result</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Template Uri associated with this query result
        /// </summary>
        /// <value>Template Uri associated with this query result</value>
        [DataMember(Name="templateUri", EmitDefaultValue=false)]
        public string TemplateUri { get; set; }



        /// <summary>
        /// HTTP Method associated with this query result
        /// </summary>
        /// <value>HTTP Method associated with this query result</value>
        [DataMember(Name="httpMethod", EmitDefaultValue=false)]
        public string HttpMethod { get; set; }



        /// <summary>
        /// Number of requests resulting in a 2xx HTTP status code
        /// </summary>
        /// <value>Number of requests resulting in a 2xx HTTP status code</value>
        [DataMember(Name="status200", EmitDefaultValue=false)]
        public long? Status200 { get; set; }



        /// <summary>
        /// Number of requests resulting in a 3xx HTTP status code
        /// </summary>
        /// <value>Number of requests resulting in a 3xx HTTP status code</value>
        [DataMember(Name="status300", EmitDefaultValue=false)]
        public long? Status300 { get; set; }



        /// <summary>
        /// Number of requests resulting in a 4xx HTTP status code
        /// </summary>
        /// <value>Number of requests resulting in a 4xx HTTP status code</value>
        [DataMember(Name="status400", EmitDefaultValue=false)]
        public long? Status400 { get; set; }



        /// <summary>
        /// Number of requests resulting in a 5xx HTTP status code
        /// </summary>
        /// <value>Number of requests resulting in a 5xx HTTP status code</value>
        [DataMember(Name="status500", EmitDefaultValue=false)]
        public long? Status500 { get; set; }



        /// <summary>
        /// Number of requests resulting in a 429 HTTP status code, this is a subset of the count returned with status400
        /// </summary>
        /// <value>Number of requests resulting in a 429 HTTP status code, this is a subset of the count returned with status400</value>
        [DataMember(Name="status429", EmitDefaultValue=false)]
        public long? Status429 { get; set; }



        /// <summary>
        /// Total number of requests
        /// </summary>
        /// <value>Total number of requests</value>
        [DataMember(Name="requests", EmitDefaultValue=false)]
        public long? Requests { get; set; }



        /// <summary>
        /// Date of requests, based on granularity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date of requests, based on granularity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiUsageRow {\n");

            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TemplateUri: ").Append(TemplateUri).Append("\n");
            sb.Append("  HttpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  Status200: ").Append(Status200).Append("\n");
            sb.Append("  Status300: ").Append(Status300).Append("\n");
            sb.Append("  Status400: ").Append(Status400).Append("\n");
            sb.Append("  Status500: ").Append(Status500).Append("\n");
            sb.Append("  Status429: ").Append(Status429).Append("\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(obj as ApiUsageRow);
        }

        /// <summary>
        /// Returns true if ApiUsageRow instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiUsageRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiUsageRow other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) &&
                (
                    this.ClientName == other.ClientName ||
                    this.ClientName != null &&
                    this.ClientName.Equals(other.ClientName)
                ) &&
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.TemplateUri == other.TemplateUri ||
                    this.TemplateUri != null &&
                    this.TemplateUri.Equals(other.TemplateUri)
                ) &&
                (
                    this.HttpMethod == other.HttpMethod ||
                    this.HttpMethod != null &&
                    this.HttpMethod.Equals(other.HttpMethod)
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
                    this.Status500 == other.Status500 ||
                    this.Status500 != null &&
                    this.Status500.Equals(other.Status500)
                ) &&
                (
                    this.Status429 == other.Status429 ||
                    this.Status429 != null &&
                    this.Status429.Equals(other.Status429)
                ) &&
                (
                    this.Requests == other.Requests ||
                    this.Requests != null &&
                    this.Requests.Equals(other.Requests)
                ) &&
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
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
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();

                if (this.ClientName != null)
                    hash = hash * 59 + this.ClientName.GetHashCode();

                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.TemplateUri != null)
                    hash = hash * 59 + this.TemplateUri.GetHashCode();

                if (this.HttpMethod != null)
                    hash = hash * 59 + this.HttpMethod.GetHashCode();

                if (this.Status200 != null)
                    hash = hash * 59 + this.Status200.GetHashCode();

                if (this.Status300 != null)
                    hash = hash * 59 + this.Status300.GetHashCode();

                if (this.Status400 != null)
                    hash = hash * 59 + this.Status400.GetHashCode();

                if (this.Status500 != null)
                    hash = hash * 59 + this.Status500.GetHashCode();

                if (this.Status429 != null)
                    hash = hash * 59 + this.Status429.GetHashCode();

                if (this.Requests != null)
                    hash = hash * 59 + this.Requests.GetHashCode();

                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();

                return hash;
            }
        }
    }

}
