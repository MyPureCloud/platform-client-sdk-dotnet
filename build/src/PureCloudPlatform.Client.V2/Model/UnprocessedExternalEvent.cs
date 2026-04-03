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
    /// UnprocessedExternalEvent
    /// </summary>
    [DataContract]
    public partial class UnprocessedExternalEvent :  IEquatable<UnprocessedExternalEvent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UnprocessedExternalEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnprocessedExternalEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnprocessedExternalEvent" /> class.
        /// </summary>
        /// <param name="Event">The event that failed processing. (required).</param>
        /// <param name="OriginalRequestIndex">The index of the event in the original request. (required).</param>
        /// <param name="IsRetryable">Whether the error is retryable. (required).</param>
        /// <param name="ErrorMessage">The error message. (required).</param>
        /// <param name="StatusCode">The HTTP status code associated with the error..</param>
        public UnprocessedExternalEvent(ExternalEvent Event = null, int? OriginalRequestIndex = null, bool? IsRetryable = null, string ErrorMessage = null, int? StatusCode = null)
        {
            this.Event = Event;
            this.OriginalRequestIndex = OriginalRequestIndex;
            this.IsRetryable = IsRetryable;
            this.ErrorMessage = ErrorMessage;
            this.StatusCode = StatusCode;
            
        }
        


        /// <summary>
        /// The event that failed processing.
        /// </summary>
        /// <value>The event that failed processing.</value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public ExternalEvent Event { get; set; }



        /// <summary>
        /// The index of the event in the original request.
        /// </summary>
        /// <value>The index of the event in the original request.</value>
        [DataMember(Name="originalRequestIndex", EmitDefaultValue=false)]
        public int? OriginalRequestIndex { get; set; }



        /// <summary>
        /// Whether the error is retryable.
        /// </summary>
        /// <value>Whether the error is retryable.</value>
        [DataMember(Name="isRetryable", EmitDefaultValue=false)]
        public bool? IsRetryable { get; set; }



        /// <summary>
        /// The error message.
        /// </summary>
        /// <value>The error message.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// The HTTP status code associated with the error.
        /// </summary>
        /// <value>The HTTP status code associated with the error.</value>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnprocessedExternalEvent {\n");

            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  OriginalRequestIndex: ").Append(OriginalRequestIndex).Append("\n");
            sb.Append("  IsRetryable: ").Append(IsRetryable).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
            return this.Equals(obj as UnprocessedExternalEvent);
        }

        /// <summary>
        /// Returns true if UnprocessedExternalEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of UnprocessedExternalEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnprocessedExternalEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Event == other.Event ||
                    this.Event != null &&
                    this.Event.Equals(other.Event)
                ) &&
                (
                    this.OriginalRequestIndex == other.OriginalRequestIndex ||
                    this.OriginalRequestIndex != null &&
                    this.OriginalRequestIndex.Equals(other.OriginalRequestIndex)
                ) &&
                (
                    this.IsRetryable == other.IsRetryable ||
                    this.IsRetryable != null &&
                    this.IsRetryable.Equals(other.IsRetryable)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) &&
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
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
                if (this.Event != null)
                    hash = hash * 59 + this.Event.GetHashCode();

                if (this.OriginalRequestIndex != null)
                    hash = hash * 59 + this.OriginalRequestIndex.GetHashCode();

                if (this.IsRetryable != null)
                    hash = hash * 59 + this.IsRetryable.GetHashCode();

                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();

                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();

                return hash;
            }
        }
    }

}
