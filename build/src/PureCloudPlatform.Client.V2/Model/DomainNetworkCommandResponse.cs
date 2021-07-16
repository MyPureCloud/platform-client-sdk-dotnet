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
    /// DomainNetworkCommandResponse
    /// </summary>
    [DataContract]
    public partial class DomainNetworkCommandResponse :  IEquatable<DomainNetworkCommandResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainNetworkCommandResponse" /> class.
        /// </summary>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="CommandName">CommandName.</param>
        /// <param name="Acknowledged">Acknowledged.</param>
        /// <param name="ErrorInfo">ErrorInfo.</param>
        public DomainNetworkCommandResponse(string CorrelationId = null, string CommandName = null, bool? Acknowledged = null, ErrorDetails ErrorInfo = null)
        {
            this.CorrelationId = CorrelationId;
            this.CommandName = CommandName;
            this.Acknowledged = Acknowledged;
            this.ErrorInfo = ErrorInfo;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CommandName
        /// </summary>
        [DataMember(Name="commandName", EmitDefaultValue=false)]
        public string CommandName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Acknowledged
        /// </summary>
        [DataMember(Name="acknowledged", EmitDefaultValue=false)]
        public bool? Acknowledged { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ErrorInfo
        /// </summary>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public ErrorDetails ErrorInfo { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainNetworkCommandResponse {\n");
            
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  CommandName: ").Append(CommandName).Append("\n");
            sb.Append("  Acknowledged: ").Append(Acknowledged).Append("\n");
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
            return this.Equals(obj as DomainNetworkCommandResponse);
        }

        /// <summary>
        /// Returns true if DomainNetworkCommandResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DomainNetworkCommandResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainNetworkCommandResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) &&
                (
                    this.CommandName == other.CommandName ||
                    this.CommandName != null &&
                    this.CommandName.Equals(other.CommandName)
                ) &&
                (
                    this.Acknowledged == other.Acknowledged ||
                    this.Acknowledged != null &&
                    this.Acknowledged.Equals(other.Acknowledged)
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
                
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                
                if (this.CommandName != null)
                    hash = hash * 59 + this.CommandName.GetHashCode();
                
                if (this.Acknowledged != null)
                    hash = hash * 59 + this.Acknowledged.GetHashCode();
                
                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();
                
                return hash;
            }
        }
    }

}
