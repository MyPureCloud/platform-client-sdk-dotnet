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
    /// BuConvertTimeOffLimitGranularityJobResponse
    /// </summary>
    [DataContract]
    public partial class BuConvertTimeOffLimitGranularityJobResponse :  IEquatable<BuConvertTimeOffLimitGranularityJobResponse>
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
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing
        }
        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuConvertTimeOffLimitGranularityJobResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuConvertTimeOffLimitGranularityJobResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuConvertTimeOffLimitGranularityJobResponse" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="TimeOffLimit">The time-off limit associated with this job (required).</param>
        /// <param name="Status">The status of the job (required).</param>
        /// <param name="Progress">Progress of time-off limit granularity conversion.</param>
        /// <param name="Error">Error information. Set only when status is Error.</param>
        public BuConvertTimeOffLimitGranularityJobResponse(string Id = null, BuTimeOffLimitReference TimeOffLimit = null, StatusEnum? Status = null, BuConvertTimeOffLimitGranularityJobProgress Progress = null, ErrorBody Error = null)
        {
            this.Id = Id;
            this.TimeOffLimit = TimeOffLimit;
            this.Status = Status;
            this.Progress = Progress;
            this.Error = Error;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The time-off limit associated with this job
        /// </summary>
        /// <value>The time-off limit associated with this job</value>
        [DataMember(Name="timeOffLimit", EmitDefaultValue=false)]
        public BuTimeOffLimitReference TimeOffLimit { get; set; }





        /// <summary>
        /// Progress of time-off limit granularity conversion
        /// </summary>
        /// <value>Progress of time-off limit granularity conversion</value>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public BuConvertTimeOffLimitGranularityJobProgress Progress { get; set; }



        /// <summary>
        /// Error information. Set only when status is Error
        /// </summary>
        /// <value>Error information. Set only when status is Error</value>
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
            sb.Append("class BuConvertTimeOffLimitGranularityJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TimeOffLimit: ").Append(TimeOffLimit).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
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
            return this.Equals(obj as BuConvertTimeOffLimitGranularityJobResponse);
        }

        /// <summary>
        /// Returns true if BuConvertTimeOffLimitGranularityJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BuConvertTimeOffLimitGranularityJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuConvertTimeOffLimitGranularityJobResponse other)
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
                    this.TimeOffLimit == other.TimeOffLimit ||
                    this.TimeOffLimit != null &&
                    this.TimeOffLimit.Equals(other.TimeOffLimit)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Progress == other.Progress ||
                    this.Progress != null &&
                    this.Progress.Equals(other.Progress)
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

                if (this.TimeOffLimit != null)
                    hash = hash * 59 + this.TimeOffLimit.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Progress != null)
                    hash = hash * 59 + this.Progress.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
