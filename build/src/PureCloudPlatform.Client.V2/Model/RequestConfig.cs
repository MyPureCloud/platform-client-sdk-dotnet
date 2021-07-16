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
    /// Defines response components of the Action Request.
    /// </summary>
    [DataContract]
    public partial class RequestConfig :  IEquatable<RequestConfig>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestConfig" /> class.
        /// </summary>
        /// <param name="RequestUrlTemplate">URL that may include placeholders for requests to 3rd party service.</param>
        /// <param name="RequestTemplate">Velocity template to define request body sent to 3rd party service..</param>
        /// <param name="RequestTemplateUri">URI to retrieve requestTemplate.</param>
        /// <param name="RequestType">HTTP method to use for request.</param>
        /// <param name="Headers">Headers to include in request in (Header Name, Value) pairs..</param>
        public RequestConfig(string RequestUrlTemplate = null, string RequestTemplate = null, string RequestTemplateUri = null, string RequestType = null, Dictionary<string, string> Headers = null)
        {
            this.RequestUrlTemplate = RequestUrlTemplate;
            this.RequestTemplate = RequestTemplate;
            this.RequestTemplateUri = RequestTemplateUri;
            this.RequestType = RequestType;
            this.Headers = Headers;
            
        }
        
        
        
        /// <summary>
        /// URL that may include placeholders for requests to 3rd party service
        /// </summary>
        /// <value>URL that may include placeholders for requests to 3rd party service</value>
        [DataMember(Name="requestUrlTemplate", EmitDefaultValue=false)]
        public string RequestUrlTemplate { get; set; }
        
        
        
        /// <summary>
        /// Velocity template to define request body sent to 3rd party service.
        /// </summary>
        /// <value>Velocity template to define request body sent to 3rd party service.</value>
        [DataMember(Name="requestTemplate", EmitDefaultValue=false)]
        public string RequestTemplate { get; set; }
        
        
        
        /// <summary>
        /// URI to retrieve requestTemplate
        /// </summary>
        /// <value>URI to retrieve requestTemplate</value>
        [DataMember(Name="requestTemplateUri", EmitDefaultValue=false)]
        public string RequestTemplateUri { get; set; }
        
        
        
        /// <summary>
        /// HTTP method to use for request
        /// </summary>
        /// <value>HTTP method to use for request</value>
        [DataMember(Name="requestType", EmitDefaultValue=false)]
        public string RequestType { get; set; }
        
        
        
        /// <summary>
        /// Headers to include in request in (Header Name, Value) pairs.
        /// </summary>
        /// <value>Headers to include in request in (Header Name, Value) pairs.</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, string> Headers { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestConfig {\n");
            
            sb.Append("  RequestUrlTemplate: ").Append(RequestUrlTemplate).Append("\n");
            sb.Append("  RequestTemplate: ").Append(RequestTemplate).Append("\n");
            sb.Append("  RequestTemplateUri: ").Append(RequestTemplateUri).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
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
            return this.Equals(obj as RequestConfig);
        }

        /// <summary>
        /// Returns true if RequestConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RequestUrlTemplate == other.RequestUrlTemplate ||
                    this.RequestUrlTemplate != null &&
                    this.RequestUrlTemplate.Equals(other.RequestUrlTemplate)
                ) &&
                (
                    this.RequestTemplate == other.RequestTemplate ||
                    this.RequestTemplate != null &&
                    this.RequestTemplate.Equals(other.RequestTemplate)
                ) &&
                (
                    this.RequestTemplateUri == other.RequestTemplateUri ||
                    this.RequestTemplateUri != null &&
                    this.RequestTemplateUri.Equals(other.RequestTemplateUri)
                ) &&
                (
                    this.RequestType == other.RequestType ||
                    this.RequestType != null &&
                    this.RequestType.Equals(other.RequestType)
                ) &&
                (
                    this.Headers == other.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(other.Headers)
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
                
                if (this.RequestUrlTemplate != null)
                    hash = hash * 59 + this.RequestUrlTemplate.GetHashCode();
                
                if (this.RequestTemplate != null)
                    hash = hash * 59 + this.RequestTemplate.GetHashCode();
                
                if (this.RequestTemplateUri != null)
                    hash = hash * 59 + this.RequestTemplateUri.GetHashCode();
                
                if (this.RequestType != null)
                    hash = hash * 59 + this.RequestType.GetHashCode();
                
                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();
                
                return hash;
            }
        }
    }

}
