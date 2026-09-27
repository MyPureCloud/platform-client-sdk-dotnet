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
    /// BuAdherenceAdjustmentsQueryJob
    /// </summary>
    [DataContract]
    public partial class BuAdherenceAdjustmentsQueryJob :  IEquatable<BuAdherenceAdjustmentsQueryJob>
    {
        /// <summary>
        /// The status of the adherence adjustments query job
        /// </summary>
        /// <value>The status of the adherence adjustments query job</value>
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
        /// The status of the adherence adjustments query job
        /// </summary>
        /// <value>The status of the adherence adjustments query job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuAdherenceAdjustmentsQueryJob" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuAdherenceAdjustmentsQueryJob() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuAdherenceAdjustmentsQueryJob" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="Status">The status of the adherence adjustments query job.</param>
        /// <param name="DownloadUrl">A URL to fetch results of the job. Only set if status &#x3D;&#x3D; &#39;Complete&#39;.</param>
        /// <param name="Error">Error details if status &#x3D;&#x3D; &#39;Error&#39;.</param>
        /// <param name="Result">Schema template for deserializing data returned from the downloadUrl. Will always be null on the response.</param>
        public BuAdherenceAdjustmentsQueryJob(string Id = null, StatusEnum? Status = null, string DownloadUrl = null, ErrorBody Error = null, AdherenceAdjustmentsListing Result = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.DownloadUrl = DownloadUrl;
            this.Error = Error;
            this.Result = Result;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// A URL to fetch results of the job. Only set if status &#x3D;&#x3D; &#39;Complete&#39;
        /// </summary>
        /// <value>A URL to fetch results of the job. Only set if status &#x3D;&#x3D; &#39;Complete&#39;</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Error details if status &#x3D;&#x3D; &#39;Error&#39;
        /// </summary>
        /// <value>Error details if status &#x3D;&#x3D; &#39;Error&#39;</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorBody Error { get; set; }



        /// <summary>
        /// Schema template for deserializing data returned from the downloadUrl. Will always be null on the response
        /// </summary>
        /// <value>Schema template for deserializing data returned from the downloadUrl. Will always be null on the response</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public AdherenceAdjustmentsListing Result { get; set; }



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
            sb.Append("class BuAdherenceAdjustmentsQueryJob {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(obj as BuAdherenceAdjustmentsQueryJob);
        }

        /// <summary>
        /// Returns true if BuAdherenceAdjustmentsQueryJob instances are equal
        /// </summary>
        /// <param name="other">Instance of BuAdherenceAdjustmentsQueryJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuAdherenceAdjustmentsQueryJob other)
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
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
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

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
