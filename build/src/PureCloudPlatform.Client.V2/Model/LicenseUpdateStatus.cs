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
    /// LicenseUpdateStatus
    /// </summary>
    [DataContract]
    public partial class LicenseUpdateStatus :  IEquatable<LicenseUpdateStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseUpdateStatus" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="LicenseId">LicenseId.</param>
        /// <param name="Result">Result.</param>
        public LicenseUpdateStatus(string UserId = null, string LicenseId = null, string Result = null)
        {
            this.UserId = UserId;
            this.LicenseId = LicenseId;
            this.Result = Result;
            
        }
        


        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Gets or Sets LicenseId
        /// </summary>
        [DataMember(Name="licenseId", EmitDefaultValue=false)]
        public string LicenseId { get; set; }



        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicenseUpdateStatus {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(obj as LicenseUpdateStatus);
        }

        /// <summary>
        /// Returns true if LicenseUpdateStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of LicenseUpdateStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseUpdateStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.LicenseId == other.LicenseId ||
                    this.LicenseId != null &&
                    this.LicenseId.Equals(other.LicenseId)
                ) &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.LicenseId != null)
                    hash = hash * 59 + this.LicenseId.GetHashCode();

                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();

                return hash;
            }
        }
    }

}
