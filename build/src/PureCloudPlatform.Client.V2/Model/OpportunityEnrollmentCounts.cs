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
    /// OpportunityEnrollmentCounts
    /// </summary>
    [DataContract]
    public partial class OpportunityEnrollmentCounts :  IEquatable<OpportunityEnrollmentCounts>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunityEnrollmentCounts" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpportunityEnrollmentCounts() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunityEnrollmentCounts" /> class.
        /// </summary>
        /// <param name="Pending">The number of pending enrollments for this opportunity (required).</param>
        /// <param name="Approved">The number of approved enrollments for this opportunity (required).</param>
        /// <param name="Denied">The number of denied enrollments for this opportunity (required).</param>
        /// <param name="Withdrawn">The number of withdrawn enrollments for this opportunity (required).</param>
        public OpportunityEnrollmentCounts(int? Pending = null, int? Approved = null, int? Denied = null, int? Withdrawn = null)
        {
            this.Pending = Pending;
            this.Approved = Approved;
            this.Denied = Denied;
            this.Withdrawn = Withdrawn;
            
        }
        


        /// <summary>
        /// The number of pending enrollments for this opportunity
        /// </summary>
        /// <value>The number of pending enrollments for this opportunity</value>
        [DataMember(Name="pending", EmitDefaultValue=false)]
        public int? Pending { get; set; }



        /// <summary>
        /// The number of approved enrollments for this opportunity
        /// </summary>
        /// <value>The number of approved enrollments for this opportunity</value>
        [DataMember(Name="approved", EmitDefaultValue=false)]
        public int? Approved { get; set; }



        /// <summary>
        /// The number of denied enrollments for this opportunity
        /// </summary>
        /// <value>The number of denied enrollments for this opportunity</value>
        [DataMember(Name="denied", EmitDefaultValue=false)]
        public int? Denied { get; set; }



        /// <summary>
        /// The number of withdrawn enrollments for this opportunity
        /// </summary>
        /// <value>The number of withdrawn enrollments for this opportunity</value>
        [DataMember(Name="withdrawn", EmitDefaultValue=false)]
        public int? Withdrawn { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpportunityEnrollmentCounts {\n");

            sb.Append("  Pending: ").Append(Pending).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  Denied: ").Append(Denied).Append("\n");
            sb.Append("  Withdrawn: ").Append(Withdrawn).Append("\n");
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
            return this.Equals(obj as OpportunityEnrollmentCounts);
        }

        /// <summary>
        /// Returns true if OpportunityEnrollmentCounts instances are equal
        /// </summary>
        /// <param name="other">Instance of OpportunityEnrollmentCounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpportunityEnrollmentCounts other)
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
                ) &&
                (
                    this.Denied == other.Denied ||
                    this.Denied != null &&
                    this.Denied.Equals(other.Denied)
                ) &&
                (
                    this.Withdrawn == other.Withdrawn ||
                    this.Withdrawn != null &&
                    this.Withdrawn.Equals(other.Withdrawn)
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

                if (this.Denied != null)
                    hash = hash * 59 + this.Denied.GetHashCode();

                if (this.Withdrawn != null)
                    hash = hash * 59 + this.Withdrawn.GetHashCode();

                return hash;
            }
        }
    }

}
