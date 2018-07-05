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
    /// ProvisionInfo
    /// </summary>
    [DataContract]
    public partial class ProvisionInfo :  IEquatable<ProvisionInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionInfo" /> class.
        /// </summary>
        /// <param name="Time">The time at which this phone was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Source">The source of the provisioning.</param>
        /// <param name="ErrorInfo">The error information from the provision process, if any.</param>
        public ProvisionInfo(DateTime? Time = null, string Source = null, string ErrorInfo = null)
        {
            this.Time = Time;
            this.Source = Source;
            this.ErrorInfo = ErrorInfo;
            
        }
        
        
        
        /// <summary>
        /// The time at which this phone was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time at which this phone was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }
        
        
        
        /// <summary>
        /// The source of the provisioning
        /// </summary>
        /// <value>The source of the provisioning</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }
        
        
        
        /// <summary>
        /// The error information from the provision process, if any
        /// </summary>
        /// <value>The error information from the provision process, if any</value>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public string ErrorInfo { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProvisionInfo {\n");
            
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(obj as ProvisionInfo);
        }

        /// <summary>
        /// Returns true if ProvisionInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ProvisionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProvisionInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
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
                
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                
                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();
                
                return hash;
            }
        }
    }

}
