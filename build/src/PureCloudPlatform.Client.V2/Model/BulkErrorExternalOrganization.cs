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
    /// BulkErrorExternalOrganization
    /// </summary>
    [DataContract]
    public partial class BulkErrorExternalOrganization :  IEquatable<BulkErrorExternalOrganization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkErrorExternalOrganization" /> class.
        /// </summary>
        /// <param name="Code">Code.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Retryable">Retryable.</param>
        /// <param name="Entity">Entity.</param>
        /// <param name="Details">Details.</param>
        public BulkErrorExternalOrganization(string Code = null, string Message = null, int? Status = null, bool? Retryable = null, ExternalOrganization Entity = null, List<BulkErrorDetail> Details = null)
        {
            this.Code = Code;
            this.Message = Message;
            this.Status = Status;
            this.Retryable = Retryable;
            this.Entity = Entity;
            this.Details = Details;
            
        }
        


        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }



        /// <summary>
        /// Gets or Sets Retryable
        /// </summary>
        [DataMember(Name="retryable", EmitDefaultValue=false)]
        public bool? Retryable { get; set; }



        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public ExternalOrganization Entity { get; set; }



        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<BulkErrorDetail> Details { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkErrorExternalOrganization {\n");

            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Retryable: ").Append(Retryable).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as BulkErrorExternalOrganization);
        }

        /// <summary>
        /// Returns true if BulkErrorExternalOrganization instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkErrorExternalOrganization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkErrorExternalOrganization other)
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
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) &&
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
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

                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();

                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();

                return hash;
            }
        }
    }

}
