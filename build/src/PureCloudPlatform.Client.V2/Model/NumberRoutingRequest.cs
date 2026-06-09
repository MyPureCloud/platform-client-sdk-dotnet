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
    /// NumberRoutingRequest
    /// </summary>
    [DataContract]
    public partial class NumberRoutingRequest :  IEquatable<NumberRoutingRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberRoutingRequest" /> class.
        /// </summary>
        /// <param name="OrganizationId">Target organization Id where number will be routed to.</param>
        /// <param name="NumberId">Number Id to be routed..</param>
        /// <param name="TargetRegion">Region where target organization is hosted..</param>
        public NumberRoutingRequest(string OrganizationId = null, string NumberId = null, string TargetRegion = null)
        {
            this.OrganizationId = OrganizationId;
            this.NumberId = NumberId;
            this.TargetRegion = TargetRegion;
            
        }
        


        /// <summary>
        /// Target organization Id where number will be routed to
        /// </summary>
        /// <value>Target organization Id where number will be routed to</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }



        /// <summary>
        /// Number Id to be routed.
        /// </summary>
        /// <value>Number Id to be routed.</value>
        [DataMember(Name="numberId", EmitDefaultValue=false)]
        public string NumberId { get; set; }



        /// <summary>
        /// Region where target organization is hosted.
        /// </summary>
        /// <value>Region where target organization is hosted.</value>
        [DataMember(Name="targetRegion", EmitDefaultValue=false)]
        public string TargetRegion { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumberRoutingRequest {\n");

            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  NumberId: ").Append(NumberId).Append("\n");
            sb.Append("  TargetRegion: ").Append(TargetRegion).Append("\n");
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
            return this.Equals(obj as NumberRoutingRequest);
        }

        /// <summary>
        /// Returns true if NumberRoutingRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of NumberRoutingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumberRoutingRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) &&
                (
                    this.NumberId == other.NumberId ||
                    this.NumberId != null &&
                    this.NumberId.Equals(other.NumberId)
                ) &&
                (
                    this.TargetRegion == other.TargetRegion ||
                    this.TargetRegion != null &&
                    this.TargetRegion.Equals(other.TargetRegion)
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
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();

                if (this.NumberId != null)
                    hash = hash * 59 + this.NumberId.GetHashCode();

                if (this.TargetRegion != null)
                    hash = hash * 59 + this.TargetRegion.GetHashCode();

                return hash;
            }
        }
    }

}
