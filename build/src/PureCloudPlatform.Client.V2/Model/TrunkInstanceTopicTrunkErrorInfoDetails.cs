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
    /// TrunkInstanceTopicTrunkErrorInfoDetails
    /// </summary>
    [DataContract]
    public partial class TrunkInstanceTopicTrunkErrorInfoDetails :  IEquatable<TrunkInstanceTopicTrunkErrorInfoDetails>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrunkInstanceTopicTrunkErrorInfoDetails" /> class.
        /// </summary>
        /// <param name="Code">Code.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Hostname">Hostname.</param>
        public TrunkInstanceTopicTrunkErrorInfoDetails(string Code = null, string Message = null, string Hostname = null)
        {
            this.Code = Code;
            this.Message = Message;
            this.Hostname = Hostname;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Hostname
        /// </summary>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string Hostname { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrunkInstanceTopicTrunkErrorInfoDetails {\n");
            
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
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
            return this.Equals(obj as TrunkInstanceTopicTrunkErrorInfoDetails);
        }

        /// <summary>
        /// Returns true if TrunkInstanceTopicTrunkErrorInfoDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of TrunkInstanceTopicTrunkErrorInfoDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrunkInstanceTopicTrunkErrorInfoDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Hostname == other.Hostname ||
                    this.Hostname != null &&
                    this.Hostname.Equals(other.Hostname)
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
                
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                if (this.Hostname != null)
                    hash = hash * 59 + this.Hostname.GetHashCode();
                
                return hash;
            }
        }
    }

}
