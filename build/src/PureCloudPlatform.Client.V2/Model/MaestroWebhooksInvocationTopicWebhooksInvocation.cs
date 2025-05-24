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
    /// MaestroWebhooksInvocationTopicWebhooksInvocation
    /// </summary>
    [DataContract]
    public partial class MaestroWebhooksInvocationTopicWebhooksInvocation :  IEquatable<MaestroWebhooksInvocationTopicWebhooksInvocation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaestroWebhooksInvocationTopicWebhooksInvocation" /> class.
        /// </summary>
        /// <param name="Body">Body.</param>
        /// <param name="Headers">Headers.</param>
        /// <param name="Query">Query.</param>
        public MaestroWebhooksInvocationTopicWebhooksInvocation(Object Body = null, Dictionary<string, List<string>> Headers = null, Dictionary<string, List<string>> Query = null)
        {
            this.Body = Body;
            this.Headers = Headers;
            this.Query = Query;
            
        }
        


        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public Object Body { get; set; }



        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> Headers { get; set; }



        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> Query { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaestroWebhooksInvocationTopicWebhooksInvocation {\n");

            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(obj as MaestroWebhooksInvocationTopicWebhooksInvocation);
        }

        /// <summary>
        /// Returns true if MaestroWebhooksInvocationTopicWebhooksInvocation instances are equal
        /// </summary>
        /// <param name="other">Instance of MaestroWebhooksInvocationTopicWebhooksInvocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaestroWebhooksInvocationTopicWebhooksInvocation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) &&
                (
                    this.Headers == other.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(other.Headers)
                ) &&
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.SequenceEqual(other.Query)
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
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();

                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();

                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();

                return hash;
            }
        }
    }

}
