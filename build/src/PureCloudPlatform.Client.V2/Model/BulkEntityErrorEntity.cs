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
    /// BulkEntityErrorEntity
    /// </summary>
    [DataContract]
    public partial class BulkEntityErrorEntity :  IEquatable<BulkEntityErrorEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkEntityErrorEntity" /> class.
        /// </summary>
        /// <param name="Code">An error code for the specific error condition..</param>
        /// <param name="Message">A short error message..</param>
        /// <param name="Status">The HTTP Status Code for the error..</param>
        /// <param name="Retryable">Whether this particular error should be retried..</param>
        /// <param name="Details">Additional error details for specific fields..</param>
        /// <param name="Entity">The entity body specified in the Bulk request operation that caused this error..</param>
        public BulkEntityErrorEntity(string Code = null, string Message = null, int? Status = null, bool? Retryable = null, List<BulkErrorDetail> Details = null, Entity Entity = null)
        {
            this.Code = Code;
            this.Message = Message;
            this.Status = Status;
            this.Retryable = Retryable;
            this.Details = Details;
            this.Entity = Entity;
            
        }
        


        /// <summary>
        /// An error code for the specific error condition.
        /// </summary>
        /// <value>An error code for the specific error condition.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// A short error message.
        /// </summary>
        /// <value>A short error message.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// The HTTP Status Code for the error.
        /// </summary>
        /// <value>The HTTP Status Code for the error.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }



        /// <summary>
        /// Whether this particular error should be retried.
        /// </summary>
        /// <value>Whether this particular error should be retried.</value>
        [DataMember(Name="retryable", EmitDefaultValue=false)]
        public bool? Retryable { get; set; }



        /// <summary>
        /// Additional error details for specific fields.
        /// </summary>
        /// <value>Additional error details for specific fields.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<BulkErrorDetail> Details { get; set; }



        /// <summary>
        /// The entity body specified in the Bulk request operation that caused this error.
        /// </summary>
        /// <value>The entity body specified in the Bulk request operation that caused this error.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public Entity Entity { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkEntityErrorEntity {\n");

            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Retryable: ").Append(Retryable).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
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
            return this.Equals(obj as BulkEntityErrorEntity);
        }

        /// <summary>
        /// Returns true if BulkEntityErrorEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkEntityErrorEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkEntityErrorEntity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Retryable == other.Retryable ||
                    this.Retryable != null &&
                    this.Retryable.Equals(other.Retryable)
                ) &&
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Retryable != null)
                    hash = hash * 59 + this.Retryable.GetHashCode();

                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();

                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();

                return hash;
            }
        }
    }

}
