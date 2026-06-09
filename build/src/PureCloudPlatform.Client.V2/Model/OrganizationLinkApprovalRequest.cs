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
    /// OrganizationLinkApprovalRequest
    /// </summary>
    [DataContract]
    public partial class OrganizationLinkApprovalRequest :  IEquatable<OrganizationLinkApprovalRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationLinkApprovalRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizationLinkApprovalRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationLinkApprovalRequest" /> class.
        /// </summary>
        /// <param name="Approval">Value for approving or rejecting an organization link, true is approved, false is rejected (required).</param>
        public OrganizationLinkApprovalRequest(bool? Approval = null)
        {
            this.Approval = Approval;
            
        }
        


        /// <summary>
        /// Value for approving or rejecting an organization link, true is approved, false is rejected
        /// </summary>
        /// <value>Value for approving or rejecting an organization link, true is approved, false is rejected</value>
        [DataMember(Name="approval", EmitDefaultValue=false)]
        public bool? Approval { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationLinkApprovalRequest {\n");

            sb.Append("  Approval: ").Append(Approval).Append("\n");
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
            return this.Equals(obj as OrganizationLinkApprovalRequest);
        }

        /// <summary>
        /// Returns true if OrganizationLinkApprovalRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationLinkApprovalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationLinkApprovalRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Approval == other.Approval ||
                    this.Approval != null &&
                    this.Approval.Equals(other.Approval)
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
                if (this.Approval != null)
                    hash = hash * 59 + this.Approval.GetHashCode();

                return hash;
            }
        }
    }

}
