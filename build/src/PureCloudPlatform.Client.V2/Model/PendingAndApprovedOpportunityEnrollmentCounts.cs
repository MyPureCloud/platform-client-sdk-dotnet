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
    /// PendingAndApprovedOpportunityEnrollmentCounts
    /// </summary>
    [DataContract]
    public partial class PendingAndApprovedOpportunityEnrollmentCounts :  IEquatable<PendingAndApprovedOpportunityEnrollmentCounts>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingAndApprovedOpportunityEnrollmentCounts" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PendingAndApprovedOpportunityEnrollmentCounts() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PendingAndApprovedOpportunityEnrollmentCounts" /> class.
        /// </summary>
        /// <param name="Pending">The number of pending enrollments (required).</param>
        /// <param name="Approved">The number of approved enrollments (required).</param>
        public PendingAndApprovedOpportunityEnrollmentCounts(int? Pending = null, int? Approved = null)
        {
            this.Pending = Pending;
            this.Approved = Approved;
            
        }
        


        /// <summary>
        /// The number of pending enrollments
        /// </summary>
        /// <value>The number of pending enrollments</value>
        [DataMember(Name="pending", EmitDefaultValue=false)]
        public int? Pending { get; set; }



        /// <summary>
        /// The number of approved enrollments
        /// </summary>
        /// <value>The number of approved enrollments</value>
        [DataMember(Name="approved", EmitDefaultValue=false)]
        public int? Approved { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PendingAndApprovedOpportunityEnrollmentCounts {\n");

            sb.Append("  Pending: ").Append(Pending).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
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
            return this.Equals(obj as PendingAndApprovedOpportunityEnrollmentCounts);
        }

        /// <summary>
        /// Returns true if PendingAndApprovedOpportunityEnrollmentCounts instances are equal
        /// </summary>
        /// <param name="other">Instance of PendingAndApprovedOpportunityEnrollmentCounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PendingAndApprovedOpportunityEnrollmentCounts other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Pending == other.Pending ||
                    this.Pending != null &&
                    this.Pending.Equals(other.Pending)
                ) &&
                (
                    this.Approved == other.Approved ||
                    this.Approved != null &&
                    this.Approved.Equals(other.Approved)
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
                if (this.Pending != null)
                    hash = hash * 59 + this.Pending.GetHashCode();

                if (this.Approved != null)
                    hash = hash * 59 + this.Approved.GetHashCode();

                return hash;
            }
        }
    }

}
