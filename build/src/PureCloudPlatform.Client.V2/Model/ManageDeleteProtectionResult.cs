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
    /// ManageDeleteProtectionResult
    /// </summary>
    [DataContract]
    public partial class ManageDeleteProtectionResult :  IEquatable<ManageDeleteProtectionResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManageDeleteProtectionResult" /> class.
        /// </summary>
        /// <param name="FailedUpdates">List of failed delete protection status updates.</param>
        public ManageDeleteProtectionResult(List<FailedDeleteProtectionUpdate> FailedUpdates = null)
        {
            this.FailedUpdates = FailedUpdates;
            
        }
        


        /// <summary>
        /// List of failed delete protection status updates
        /// </summary>
        /// <value>List of failed delete protection status updates</value>
        [DataMember(Name="failedUpdates", EmitDefaultValue=false)]
        public List<FailedDeleteProtectionUpdate> FailedUpdates { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManageDeleteProtectionResult {\n");

            sb.Append("  FailedUpdates: ").Append(FailedUpdates).Append("\n");
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
            return this.Equals(obj as ManageDeleteProtectionResult);
        }

        /// <summary>
        /// Returns true if ManageDeleteProtectionResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ManageDeleteProtectionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManageDeleteProtectionResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FailedUpdates == other.FailedUpdates ||
                    this.FailedUpdates != null &&
                    this.FailedUpdates.SequenceEqual(other.FailedUpdates)
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
                if (this.FailedUpdates != null)
                    hash = hash * 59 + this.FailedUpdates.GetHashCode();

                return hash;
            }
        }
    }

}
