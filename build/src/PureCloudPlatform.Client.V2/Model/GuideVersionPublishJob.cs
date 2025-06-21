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
    /// GuideVersionPublishJob
    /// </summary>
    [DataContract]
    public partial class GuideVersionPublishJob :  IEquatable<GuideVersionPublishJob>
    {
        /// <summary>
        /// The status of the job.
        /// </summary>
        /// <value>The status of the job.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Succeeded for "Succeeded"
            /// </summary>
            [EnumMember(Value = "Succeeded")]
            Succeeded,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        /// <summary>
        /// The status of the job.
        /// </summary>
        /// <value>The status of the job.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuideVersionPublishJob" /> class.
        /// </summary>
        /// <param name="Guide">Guide.</param>
        /// <param name="GuideVersion">GuideVersion.</param>
        public GuideVersionPublishJob(AddressableEntityRef Guide = null, GuideVersion GuideVersion = null)
        {
            this.Guide = Guide;
            this.GuideVersion = GuideVersion;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }





        /// <summary>
        /// The list of errors in case of job failure.
        /// </summary>
        /// <value>The list of errors in case of job failure.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<ErrorBody> Errors { get; private set; }



        /// <summary>
        /// Gets or Sets Guide
        /// </summary>
        [DataMember(Name="guide", EmitDefaultValue=false)]
        public AddressableEntityRef Guide { get; set; }



        /// <summary>
        /// Gets or Sets GuideVersion
        /// </summary>
        [DataMember(Name="guideVersion", EmitDefaultValue=false)]
        public GuideVersion GuideVersion { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuideVersionPublishJob {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Guide: ").Append(Guide).Append("\n");
            sb.Append("  GuideVersion: ").Append(GuideVersion).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as GuideVersionPublishJob);
        }

        /// <summary>
        /// Returns true if GuideVersionPublishJob instances are equal
        /// </summary>
        /// <param name="other">Instance of GuideVersionPublishJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuideVersionPublishJob other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) &&
                (
                    this.Guide == other.Guide ||
                    this.Guide != null &&
                    this.Guide.Equals(other.Guide)
                ) &&
                (
                    this.GuideVersion == other.GuideVersion ||
                    this.GuideVersion != null &&
                    this.GuideVersion.Equals(other.GuideVersion)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();

                if (this.Guide != null)
                    hash = hash * 59 + this.Guide.GetHashCode();

                if (this.GuideVersion != null)
                    hash = hash * 59 + this.GuideVersion.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
