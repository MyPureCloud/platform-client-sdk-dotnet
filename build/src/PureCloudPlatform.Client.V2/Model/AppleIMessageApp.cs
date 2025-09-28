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
    /// AppleIMessageApp
    /// </summary>
    [DataContract]
    public partial class AppleIMessageApp :  IEquatable<AppleIMessageApp>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AppleIMessageApp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppleIMessageApp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleIMessageApp" /> class.
        /// </summary>
        /// <param name="ApplicationName">Application Name. (required).</param>
        /// <param name="ApplicationId">Application ID. (required).</param>
        /// <param name="BundleId">Bundle ID. (required).</param>
        public AppleIMessageApp(string ApplicationName = null, string ApplicationId = null, string BundleId = null)
        {
            this.ApplicationName = ApplicationName;
            this.ApplicationId = ApplicationId;
            this.BundleId = BundleId;
            
        }
        


        /// <summary>
        /// Application Name.
        /// </summary>
        /// <value>Application Name.</value>
        [DataMember(Name="applicationName", EmitDefaultValue=false)]
        public string ApplicationName { get; set; }



        /// <summary>
        /// Application ID.
        /// </summary>
        /// <value>Application ID.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }



        /// <summary>
        /// Bundle ID.
        /// </summary>
        /// <value>Bundle ID.</value>
        [DataMember(Name="bundleId", EmitDefaultValue=false)]
        public string BundleId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppleIMessageApp {\n");

            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
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
            return this.Equals(obj as AppleIMessageApp);
        }

        /// <summary>
        /// Returns true if AppleIMessageApp instances are equal
        /// </summary>
        /// <param name="other">Instance of AppleIMessageApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleIMessageApp other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ApplicationName == other.ApplicationName ||
                    this.ApplicationName != null &&
                    this.ApplicationName.Equals(other.ApplicationName)
                ) &&
                (
                    this.ApplicationId == other.ApplicationId ||
                    this.ApplicationId != null &&
                    this.ApplicationId.Equals(other.ApplicationId)
                ) &&
                (
                    this.BundleId == other.BundleId ||
                    this.BundleId != null &&
                    this.BundleId.Equals(other.BundleId)
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
                if (this.ApplicationName != null)
                    hash = hash * 59 + this.ApplicationName.GetHashCode();

                if (this.ApplicationId != null)
                    hash = hash * 59 + this.ApplicationId.GetHashCode();

                if (this.BundleId != null)
                    hash = hash * 59 + this.BundleId.GetHashCode();

                return hash;
            }
        }
    }

}
