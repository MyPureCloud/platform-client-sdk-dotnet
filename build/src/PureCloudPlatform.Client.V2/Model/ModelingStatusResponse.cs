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
    /// ModelingStatusResponse
    /// </summary>
    [DataContract]
    public partial class ModelingStatusResponse :  IEquatable<ModelingStatusResponse>
    {
        
        
        
        
        
        /// <summary>
        /// The status of the modeling job.
        /// </summary>
        /// <value>The status of the modeling job.</value>
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
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Ongoing for "Ongoing"
            /// </summary>
            [EnumMember(Value = "Ongoing")]
            Ongoing,
            
            /// <summary>
            /// Enum Partialfailure for "PartialFailure"
            /// </summary>
            [EnumMember(Value = "PartialFailure")]
            Partialfailure
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The status of the modeling job.
        /// </summary>
        /// <value>The status of the modeling job.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelingStatusResponse" /> class.
        /// </summary>
        /// <param name="ErrorDetails">If the request could not be properly processed, error details will be given here..</param>
        public ModelingStatusResponse(List<ModelingProcessingError> ErrorDetails = null)
        {
            this.ErrorDetails = ErrorDetails;
            
        }
        
        
        
        /// <summary>
        /// The ID generated for the modeling job.  Use to GET result when job is completed.
        /// </summary>
        /// <value>The ID generated for the modeling job.  Use to GET result when job is completed.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        
        
        /// <summary>
        /// If the request could not be properly processed, error details will be given here.
        /// </summary>
        /// <value>If the request could not be properly processed, error details will be given here.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public List<ModelingProcessingError> ErrorDetails { get; set; }
        
        
        
        /// <summary>
        /// The uri of the modeling result. It has a value if the status is either &#39;Success&#39;, &#39;PartialFailure&#39;, or &#39;Failed&#39;.
        /// </summary>
        /// <value>The uri of the modeling result. It has a value if the status is either &#39;Success&#39;, &#39;PartialFailure&#39;, or &#39;Failed&#39;.</value>
        [DataMember(Name="modelingResultUri", EmitDefaultValue=false)]
        public string ModelingResultUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelingStatusResponse {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  ModelingResultUri: ").Append(ModelingResultUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ModelingStatusResponse);
        }

        /// <summary>
        /// Returns true if ModelingStatusResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelingStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelingStatusResponse other)
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
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.SequenceEqual(other.ErrorDetails)
                ) &&
                (
                    this.ModelingResultUri == other.ModelingResultUri ||
                    this.ModelingResultUri != null &&
                    this.ModelingResultUri.Equals(other.ModelingResultUri)
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
                
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                
                if (this.ModelingResultUri != null)
                    hash = hash * 59 + this.ModelingResultUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
