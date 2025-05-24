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
    /// MaestroWebhooksInvocationTopicPublicWebhooksEvent
    /// </summary>
    [DataContract]
    public partial class MaestroWebhooksInvocationTopicPublicWebhooksEvent :  IEquatable<MaestroWebhooksInvocationTopicPublicWebhooksEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaestroWebhooksInvocationTopicPublicWebhooksEvent" /> class.
        /// </summary>
        /// <param name="WebhookId">WebhookId.</param>
        /// <param name="InvocationTime">InvocationTime.</param>
        /// <param name="WebhooksInvocation">WebhooksInvocation.</param>
        public MaestroWebhooksInvocationTopicPublicWebhooksEvent(string WebhookId = null, string InvocationTime = null, MaestroWebhooksInvocationTopicWebhooksInvocation WebhooksInvocation = null)
        {
            this.WebhookId = WebhookId;
            this.InvocationTime = InvocationTime;
            this.WebhooksInvocation = WebhooksInvocation;
            
        }
        


        /// <summary>
        /// Gets or Sets WebhookId
        /// </summary>
        [DataMember(Name="webhookId", EmitDefaultValue=false)]
        public string WebhookId { get; set; }



        /// <summary>
        /// Gets or Sets InvocationTime
        /// </summary>
        [DataMember(Name="invocationTime", EmitDefaultValue=false)]
        public string InvocationTime { get; set; }



        /// <summary>
        /// Gets or Sets WebhooksInvocation
        /// </summary>
        [DataMember(Name="webhooksInvocation", EmitDefaultValue=false)]
        public MaestroWebhooksInvocationTopicWebhooksInvocation WebhooksInvocation { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaestroWebhooksInvocationTopicPublicWebhooksEvent {\n");

            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  InvocationTime: ").Append(InvocationTime).Append("\n");
            sb.Append("  WebhooksInvocation: ").Append(WebhooksInvocation).Append("\n");
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
            return this.Equals(obj as MaestroWebhooksInvocationTopicPublicWebhooksEvent);
        }

        /// <summary>
        /// Returns true if MaestroWebhooksInvocationTopicPublicWebhooksEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of MaestroWebhooksInvocationTopicPublicWebhooksEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaestroWebhooksInvocationTopicPublicWebhooksEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WebhookId == other.WebhookId ||
                    this.WebhookId != null &&
                    this.WebhookId.Equals(other.WebhookId)
                ) &&
                (
                    this.InvocationTime == other.InvocationTime ||
                    this.InvocationTime != null &&
                    this.InvocationTime.Equals(other.InvocationTime)
                ) &&
                (
                    this.WebhooksInvocation == other.WebhooksInvocation ||
                    this.WebhooksInvocation != null &&
                    this.WebhooksInvocation.Equals(other.WebhooksInvocation)
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
                if (this.WebhookId != null)
                    hash = hash * 59 + this.WebhookId.GetHashCode();

                if (this.InvocationTime != null)
                    hash = hash * 59 + this.InvocationTime.GetHashCode();

                if (this.WebhooksInvocation != null)
                    hash = hash * 59 + this.WebhooksInvocation.GetHashCode();

                return hash;
            }
        }
    }

}
