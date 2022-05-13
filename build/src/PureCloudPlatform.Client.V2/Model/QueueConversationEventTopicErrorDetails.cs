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
    /// Detailed information about an error response.
    /// </summary>
    [DataContract]
    public partial class QueueConversationEventTopicErrorDetails :  IEquatable<QueueConversationEventTopicErrorDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationEventTopicErrorDetails" /> class.
        /// </summary>
        /// <param name="Status">The HTTP status code for this message (400, 401, 403, 404, 500, etc..</param>
        /// <param name="Code">A code unique to this error..</param>
        /// <param name="Message">Friendly description of this error..</param>
        /// <param name="MessageWithParams">This is the same as message except it uses template fields for variable replacement. For instance: 'User {username} was not found'.</param>
        /// <param name="MessageParams">Used in conjunction with messageWithParams. These are the template parameters. For instance: UserParam.key = 'username', UserParam.value = 'john.doe'.</param>
        /// <param name="ContextId">The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header 'ININ-Correlation-Id' instead..</param>
        /// <param name="Uri">Uri.</param>
        public QueueConversationEventTopicErrorDetails(int? Status = null, string Code = null, string Message = null, string MessageWithParams = null, Dictionary<string, string> MessageParams = null, string ContextId = null, string Uri = null)
        {
            this.Status = Status;
            this.Code = Code;
            this.Message = Message;
            this.MessageWithParams = MessageWithParams;
            this.MessageParams = MessageParams;
            this.ContextId = ContextId;
            this.Uri = Uri;
            
        }
        


        /// <summary>
        /// The HTTP status code for this message (400, 401, 403, 404, 500, etc.
        /// </summary>
        /// <value>The HTTP status code for this message (400, 401, 403, 404, 500, etc.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }



        /// <summary>
        /// A code unique to this error.
        /// </summary>
        /// <value>A code unique to this error.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// Friendly description of this error.
        /// </summary>
        /// <value>Friendly description of this error.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// This is the same as message except it uses template fields for variable replacement. For instance: 'User {username} was not found'
        /// </summary>
        /// <value>This is the same as message except it uses template fields for variable replacement. For instance: 'User {username} was not found'</value>
        [DataMember(Name="messageWithParams", EmitDefaultValue=false)]
        public string MessageWithParams { get; set; }



        /// <summary>
        /// Used in conjunction with messageWithParams. These are the template parameters. For instance: UserParam.key = 'username', UserParam.value = 'john.doe'
        /// </summary>
        /// <value>Used in conjunction with messageWithParams. These are the template parameters. For instance: UserParam.key = 'username', UserParam.value = 'john.doe'</value>
        [DataMember(Name="messageParams", EmitDefaultValue=false)]
        public Dictionary<string, string> MessageParams { get; set; }



        /// <summary>
        /// The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header 'ININ-Correlation-Id' instead.
        /// </summary>
        /// <value>The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header 'ININ-Correlation-Id' instead.</value>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; set; }



        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationEventTopicErrorDetails {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageWithParams: ").Append(MessageWithParams).Append("\n");
            sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(obj as QueueConversationEventTopicErrorDetails);
        }

        /// <summary>
        /// Returns true if QueueConversationEventTopicErrorDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationEventTopicErrorDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationEventTopicErrorDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.MessageWithParams == other.MessageWithParams ||
                    this.MessageWithParams != null &&
                    this.MessageWithParams.Equals(other.MessageWithParams)
                ) &&
                (
                    this.MessageParams == other.MessageParams ||
                    this.MessageParams != null &&
                    this.MessageParams.SequenceEqual(other.MessageParams)
                ) &&
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) &&
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.MessageWithParams != null)
                    hash = hash * 59 + this.MessageWithParams.GetHashCode();

                if (this.MessageParams != null)
                    hash = hash * 59 + this.MessageParams.GetHashCode();

                if (this.ContextId != null)
                    hash = hash * 59 + this.ContextId.GetHashCode();

                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();

                return hash;
            }
        }
    }

}
