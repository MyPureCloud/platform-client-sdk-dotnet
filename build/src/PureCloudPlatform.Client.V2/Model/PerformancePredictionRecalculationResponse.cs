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
    /// PerformancePredictionRecalculationResponse
    /// </summary>
    [DataContract]
    public partial class PerformancePredictionRecalculationResponse :  IEquatable<PerformancePredictionRecalculationResponse>
    {
        /// <summary>
        /// The state of the performance prediction
        /// </summary>
        /// <value>The state of the performance prediction</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
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
        /// The state of the performance prediction
        /// </summary>
        /// <value>The state of the performance prediction</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformancePredictionRecalculationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PerformancePredictionRecalculationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformancePredictionRecalculationResponse" /> class.
        /// </summary>
        /// <param name="OperationId">The operationId for which to listen (required).</param>
        /// <param name="DownloadUrl">The url to GET the results of the performance prediction. This field is populated only if query state is &#39;Complete&#39;.</param>
        /// <param name="DownloadResult">Result will always come via downloadUrls; however the schema is included for documentation.</param>
        /// <param name="State">The state of the performance prediction (required).</param>
        public PerformancePredictionRecalculationResponse(string OperationId = null, string DownloadUrl = null, PerformancePredictionOutputs DownloadResult = null, StateEnum? State = null)
        {
            this.OperationId = OperationId;
            this.DownloadUrl = DownloadUrl;
            this.DownloadResult = DownloadResult;
            this.State = State;
            
        }
        


        /// <summary>
        /// The operationId for which to listen
        /// </summary>
        /// <value>The operationId for which to listen</value>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public string OperationId { get; set; }



        /// <summary>
        /// The url to GET the results of the performance prediction. This field is populated only if query state is &#39;Complete&#39;
        /// </summary>
        /// <value>The url to GET the results of the performance prediction. This field is populated only if query state is &#39;Complete&#39;</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Result will always come via downloadUrls; however the schema is included for documentation
        /// </summary>
        /// <value>Result will always come via downloadUrls; however the schema is included for documentation</value>
        [DataMember(Name="downloadResult", EmitDefaultValue=false)]
        public PerformancePredictionOutputs DownloadResult { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerformancePredictionRecalculationResponse {\n");

            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  DownloadResult: ").Append(DownloadResult).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as PerformancePredictionRecalculationResponse);
        }

        /// <summary>
        /// Returns true if PerformancePredictionRecalculationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PerformancePredictionRecalculationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformancePredictionRecalculationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OperationId == other.OperationId ||
                    this.OperationId != null &&
                    this.OperationId.Equals(other.OperationId)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.DownloadResult == other.DownloadResult ||
                    this.DownloadResult != null &&
                    this.DownloadResult.Equals(other.DownloadResult)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.OperationId != null)
                    hash = hash * 59 + this.OperationId.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.DownloadResult != null)
                    hash = hash * 59 + this.DownloadResult.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                return hash;
            }
        }
    }

}
