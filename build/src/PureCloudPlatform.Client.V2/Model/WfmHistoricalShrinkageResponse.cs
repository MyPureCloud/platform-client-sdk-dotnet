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
    /// WfmHistoricalShrinkageResponse
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalShrinkageResponse :  IEquatable<WfmHistoricalShrinkageResponse>
    {
        /// <summary>
        /// The state of the shrinkage query
        /// </summary>
        /// <value>The state of the shrinkage query</value>
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
        /// The state of the shrinkage query
        /// </summary>
        /// <value>The state of the shrinkage query</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalShrinkageResponse" /> class.
        /// </summary>
        /// <param name="OperationId">The operationId for which to listen.</param>
        /// <param name="DownloadUrls">The url list to GET the results of the Historical Shrinkage query. This field is populated only if query state is Complete.</param>
        /// <param name="DownloadResult">Result will always come via downloadUrls; however the schema is included for documentation.</param>
        /// <param name="State">The state of the shrinkage query.</param>
        public WfmHistoricalShrinkageResponse(string OperationId = null, List<string> DownloadUrls = null, HistoricalShrinkageResultListing DownloadResult = null, StateEnum? State = null)
        {
            this.OperationId = OperationId;
            this.DownloadUrls = DownloadUrls;
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
        /// The url list to GET the results of the Historical Shrinkage query. This field is populated only if query state is Complete
        /// </summary>
        /// <value>The url list to GET the results of the Historical Shrinkage query. This field is populated only if query state is Complete</value>
        [DataMember(Name="downloadUrls", EmitDefaultValue=false)]
        public List<string> DownloadUrls { get; set; }



        /// <summary>
        /// Result will always come via downloadUrls; however the schema is included for documentation
        /// </summary>
        /// <value>Result will always come via downloadUrls; however the schema is included for documentation</value>
        [DataMember(Name="downloadResult", EmitDefaultValue=false)]
        public HistoricalShrinkageResultListing DownloadResult { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalShrinkageResponse {\n");

            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  DownloadUrls: ").Append(DownloadUrls).Append("\n");
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
            return this.Equals(obj as WfmHistoricalShrinkageResponse);
        }

        /// <summary>
        /// Returns true if WfmHistoricalShrinkageResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalShrinkageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalShrinkageResponse other)
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
                    this.DownloadUrls == other.DownloadUrls ||
                    this.DownloadUrls != null &&
                    this.DownloadUrls.SequenceEqual(other.DownloadUrls)
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

                if (this.DownloadUrls != null)
                    hash = hash * 59 + this.DownloadUrls.GetHashCode();

                if (this.DownloadResult != null)
                    hash = hash * 59 + this.DownloadResult.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                return hash;
            }
        }
    }

}
