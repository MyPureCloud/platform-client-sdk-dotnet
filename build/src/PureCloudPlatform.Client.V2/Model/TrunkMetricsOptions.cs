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
    /// TrunkMetricsOptions
    /// </summary>
    [DataContract]
    public partial class TrunkMetricsOptions :  IEquatable<TrunkMetricsOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrunkMetricsOptions" /> class.
        /// </summary>
        /// <param name="ProxyAddress">Server proxy address that this options array element represents..</param>
        /// <param name="OptionState">OptionState.</param>
        /// <param name="OptionStateTime">ISO 8601 format UTC absolute date & time of the last change of the option state..</param>
        /// <param name="ErrorInfo">ErrorInfo.</param>
        public TrunkMetricsOptions(string ProxyAddress = null, bool? OptionState = null, DateTime? OptionStateTime = null, TrunkErrorInfo ErrorInfo = null)
        {
            this.ProxyAddress = ProxyAddress;
            this.OptionState = OptionState;
            this.OptionStateTime = OptionStateTime;
            this.ErrorInfo = ErrorInfo;
            
        }
        


        /// <summary>
        /// Server proxy address that this options array element represents.
        /// </summary>
        /// <value>Server proxy address that this options array element represents.</value>
        [DataMember(Name="proxyAddress", EmitDefaultValue=false)]
        public string ProxyAddress { get; set; }



        /// <summary>
        /// Gets or Sets OptionState
        /// </summary>
        [DataMember(Name="optionState", EmitDefaultValue=false)]
        public bool? OptionState { get; set; }



        /// <summary>
        /// ISO 8601 format UTC absolute date & time of the last change of the option state.
        /// </summary>
        /// <value>ISO 8601 format UTC absolute date & time of the last change of the option state.</value>
        [DataMember(Name="optionStateTime", EmitDefaultValue=false)]
        public DateTime? OptionStateTime { get; set; }



        /// <summary>
        /// Gets or Sets ErrorInfo
        /// </summary>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public TrunkErrorInfo ErrorInfo { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrunkMetricsOptions {\n");

            sb.Append("  ProxyAddress: ").Append(ProxyAddress).Append("\n");
            sb.Append("  OptionState: ").Append(OptionState).Append("\n");
            sb.Append("  OptionStateTime: ").Append(OptionStateTime).Append("\n");
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
            return this.Equals(obj as TrunkMetricsOptions);
        }

        /// <summary>
        /// Returns true if TrunkMetricsOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of TrunkMetricsOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrunkMetricsOptions other)
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
                    this.OptionState == other.OptionState ||
                    this.OptionState != null &&
                    this.OptionState.Equals(other.OptionState)
                ) &&
                (
                    this.OptionStateTime == other.OptionStateTime ||
                    this.OptionStateTime != null &&
                    this.OptionStateTime.Equals(other.OptionStateTime)
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

                if (this.OptionState != null)
                    hash = hash * 59 + this.OptionState.GetHashCode();

                if (this.OptionStateTime != null)
                    hash = hash * 59 + this.OptionStateTime.GetHashCode();

                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();

                return hash;
            }
        }
    }

}
