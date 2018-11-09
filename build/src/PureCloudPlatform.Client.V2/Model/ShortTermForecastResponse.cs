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
    /// ShortTermForecastResponse
    /// </summary>
    [DataContract]
    public partial class ShortTermForecastResponse :  IEquatable<ShortTermForecastResponse>
    {
        
        
        /// <summary>
        /// The status of the request
        /// </summary>
        /// <value>The status of the request</value>
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
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The status of the request
        /// </summary>
        /// <value>The status of the request</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShortTermForecastResponse" /> class.
        /// </summary>
        /// <param name="Status">The status of the request.</param>
        /// <param name="Result">The resulting forecast.  May be sent asynchronously via notification depending on the complexity of the forecast.</param>
        /// <param name="OperationId">The operation id to watch for on the notification topic.</param>
        public ShortTermForecastResponse(StatusEnum? Status = null, ShortTermForecast Result = null, string OperationId = null)
        {
            this.Status = Status;
            this.Result = Result;
            this.OperationId = OperationId;
            
        }
        
        
        
        
        
        /// <summary>
        /// The resulting forecast.  May be sent asynchronously via notification depending on the complexity of the forecast
        /// </summary>
        /// <value>The resulting forecast.  May be sent asynchronously via notification depending on the complexity of the forecast</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public ShortTermForecast Result { get; set; }
        
        
        
        /// <summary>
        /// The operation id to watch for on the notification topic
        /// </summary>
        /// <value>The operation id to watch for on the notification topic</value>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public string OperationId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShortTermForecastResponse {\n");
            
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
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
            return this.Equals(obj as ShortTermForecastResponse);
        }

        /// <summary>
        /// Returns true if ShortTermForecastResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ShortTermForecastResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShortTermForecastResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) &&
                (
                    this.OperationId == other.OperationId ||
                    this.OperationId != null &&
                    this.OperationId.Equals(other.OperationId)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
                
                if (this.OperationId != null)
                    hash = hash * 59 + this.OperationId.GetHashCode();
                
                return hash;
            }
        }
    }

}
