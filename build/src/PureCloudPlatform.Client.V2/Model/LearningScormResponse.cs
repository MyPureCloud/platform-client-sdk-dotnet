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
    /// Learning SCORM package
    /// </summary>
    [DataContract]
    public partial class LearningScormResponse :  IEquatable<LearningScormResponse>
    {
        /// <summary>
        /// The status of the SCORM package
        /// </summary>
        /// <value>The status of the SCORM package</value>
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
            /// Enum Uploadpending for "UploadPending"
            /// </summary>
            [EnumMember(Value = "UploadPending")]
            Uploadpending,
            
            /// <summary>
            /// Enum Unpacking for "Unpacking"
            /// </summary>
            [EnumMember(Value = "Unpacking")]
            Unpacking,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Ready for "Ready"
            /// </summary>
            [EnumMember(Value = "Ready")]
            Ready
        }
        /// <summary>
        /// The status of the SCORM package
        /// </summary>
        /// <value>The status of the SCORM package</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningScormResponse" /> class.
        /// </summary>
        /// <param name="Status">The status of the SCORM package.</param>
        /// <param name="ErrorCode">The error code of the SCORM package (on failure).</param>
        /// <param name="ErrorMessage">The error message associated with the error code.</param>
        /// <param name="PercentageUnpacked">The percentage of the SCORM package that has been unpacked.</param>
        public LearningScormResponse(StatusEnum? Status = null, string ErrorCode = null, string ErrorMessage = null, float? PercentageUnpacked = null)
        {
            this.Status = Status;
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            this.PercentageUnpacked = PercentageUnpacked;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }





        /// <summary>
        /// The error code of the SCORM package (on failure)
        /// </summary>
        /// <value>The error code of the SCORM package (on failure)</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// The error message associated with the error code
        /// </summary>
        /// <value>The error message associated with the error code</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// The percentage of the SCORM package that has been unpacked
        /// </summary>
        /// <value>The percentage of the SCORM package that has been unpacked</value>
        [DataMember(Name="percentageUnpacked", EmitDefaultValue=false)]
        public float? PercentageUnpacked { get; set; }



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
            sb.Append("class LearningScormResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  PercentageUnpacked: ").Append(PercentageUnpacked).Append("\n");
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
            return this.Equals(obj as LearningScormResponse);
        }

        /// <summary>
        /// Returns true if LearningScormResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningScormResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningScormResponse other)
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
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) &&
                (
                    this.PercentageUnpacked == other.PercentageUnpacked ||
                    this.PercentageUnpacked != null &&
                    this.PercentageUnpacked.Equals(other.PercentageUnpacked)
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

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();

                if (this.PercentageUnpacked != null)
                    hash = hash * 59 + this.PercentageUnpacked.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
