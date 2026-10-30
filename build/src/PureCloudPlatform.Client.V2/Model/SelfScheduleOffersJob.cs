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
    /// SelfScheduleOffersJob
    /// </summary>
    [DataContract]
    public partial class SelfScheduleOffersJob :  IEquatable<SelfScheduleOffersJob>
    {
        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
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
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleOffersJob" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SelfScheduleOffersJob() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleOffersJob" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="Status">The status of the job (required).</param>
        /// <param name="DownloadUrl">URL from which to fetch results for requests. Populated if status &#x3D;&#x3D; ‘Complete&#39;. The downloaded data will conform to the schema defined in downloadResultTemplate.</param>
        /// <param name="DownloadResultTemplate">Schema template for deserializing lookup offers results returned from the downloadUrl.</param>
        /// <param name="Error">Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39;.</param>
        public SelfScheduleOffersJob(string Id = null, StatusEnum? Status = null, string DownloadUrl = null, SelfScheduleOffersResultTemplate DownloadResultTemplate = null, ErrorBody Error = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.DownloadUrl = DownloadUrl;
            this.DownloadResultTemplate = DownloadResultTemplate;
            this.Error = Error;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// URL from which to fetch results for requests. Populated if status &#x3D;&#x3D; ‘Complete&#39;. The downloaded data will conform to the schema defined in downloadResultTemplate
        /// </summary>
        /// <value>URL from which to fetch results for requests. Populated if status &#x3D;&#x3D; ‘Complete&#39;. The downloaded data will conform to the schema defined in downloadResultTemplate</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Schema template for deserializing lookup offers results returned from the downloadUrl
        /// </summary>
        /// <value>Schema template for deserializing lookup offers results returned from the downloadUrl</value>
        [DataMember(Name="downloadResultTemplate", EmitDefaultValue=false)]
        public SelfScheduleOffersResultTemplate DownloadResultTemplate { get; set; }



        /// <summary>
        /// Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39;
        /// </summary>
        /// <value>Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39;</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorBody Error { get; set; }



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
            sb.Append("class SelfScheduleOffersJob {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  DownloadResultTemplate: ").Append(DownloadResultTemplate).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(obj as SelfScheduleOffersJob);
        }

        /// <summary>
        /// Returns true if SelfScheduleOffersJob instances are equal
        /// </summary>
        /// <param name="other">Instance of SelfScheduleOffersJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelfScheduleOffersJob other)
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
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.DownloadResultTemplate == other.DownloadResultTemplate ||
                    this.DownloadResultTemplate != null &&
                    this.DownloadResultTemplate.Equals(other.DownloadResultTemplate)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
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

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.DownloadResultTemplate != null)
                    hash = hash * 59 + this.DownloadResultTemplate.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
