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
    /// TrunkInstanceTopicTrunkMetricsRegisters
    /// </summary>
    [DataContract]
    public partial class TrunkInstanceTopicTrunkMetricsRegisters :  IEquatable<TrunkInstanceTopicTrunkMetricsRegisters>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrunkInstanceTopicTrunkMetricsRegisters" /> class.
        /// </summary>
        /// <param name="ProxyAddress">ProxyAddress.</param>
        /// <param name="RegisterState">RegisterState.</param>
        /// <param name="RegisterStateTime">RegisterStateTime.</param>
        /// <param name="ErrorInfo">ErrorInfo.</param>
        public TrunkInstanceTopicTrunkMetricsRegisters(string ProxyAddress = null, bool? RegisterState = null, DateTime? RegisterStateTime = null, TrunkInstanceTopicTrunkErrorInfo ErrorInfo = null)
        {
            this.ProxyAddress = ProxyAddress;
            this.RegisterState = RegisterState;
            this.RegisterStateTime = RegisterStateTime;
            this.ErrorInfo = ErrorInfo;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets ProxyAddress
        /// </summary>
        [DataMember(Name="proxyAddress", EmitDefaultValue=false)]
        public string ProxyAddress { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RegisterState
        /// </summary>
        [DataMember(Name="registerState", EmitDefaultValue=false)]
        public bool? RegisterState { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RegisterStateTime
        /// </summary>
        [DataMember(Name="registerStateTime", EmitDefaultValue=false)]
        public DateTime? RegisterStateTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ErrorInfo
        /// </summary>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public TrunkInstanceTopicTrunkErrorInfo ErrorInfo { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrunkInstanceTopicTrunkMetricsRegisters {\n");
            
            sb.Append("  ProxyAddress: ").Append(ProxyAddress).Append("\n");
            sb.Append("  RegisterState: ").Append(RegisterState).Append("\n");
            sb.Append("  RegisterStateTime: ").Append(RegisterStateTime).Append("\n");
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
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
            return this.Equals(obj as TrunkInstanceTopicTrunkMetricsRegisters);
        }

        /// <summary>
        /// Returns true if TrunkInstanceTopicTrunkMetricsRegisters instances are equal
        /// </summary>
        /// <param name="other">Instance of TrunkInstanceTopicTrunkMetricsRegisters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrunkInstanceTopicTrunkMetricsRegisters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ProxyAddress == other.ProxyAddress ||
                    this.ProxyAddress != null &&
                    this.ProxyAddress.Equals(other.ProxyAddress)
                ) &&
                (
                    this.RegisterState == other.RegisterState ||
                    this.RegisterState != null &&
                    this.RegisterState.Equals(other.RegisterState)
                ) &&
                (
                    this.RegisterStateTime == other.RegisterStateTime ||
                    this.RegisterStateTime != null &&
                    this.RegisterStateTime.Equals(other.RegisterStateTime)
                ) &&
                (
                    this.ErrorInfo == other.ErrorInfo ||
                    this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(other.ErrorInfo)
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
                
                if (this.ProxyAddress != null)
                    hash = hash * 59 + this.ProxyAddress.GetHashCode();
                
                if (this.RegisterState != null)
                    hash = hash * 59 + this.RegisterState.GetHashCode();
                
                if (this.RegisterStateTime != null)
                    hash = hash * 59 + this.RegisterStateTime.GetHashCode();
                
                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();
                
                return hash;
            }
        }
    }

}
