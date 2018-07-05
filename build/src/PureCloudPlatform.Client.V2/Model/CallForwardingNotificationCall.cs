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
    /// CallForwardingNotificationCall
    /// </summary>
    [DataContract]
    public partial class CallForwardingNotificationCall :  IEquatable<CallForwardingNotificationCall>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CallForwardingNotificationCall" /> class.
        /// </summary>
        /// <param name="Targets">Targets.</param>
        public CallForwardingNotificationCall(List<CallForwardingNotificationTargets> Targets = null)
        {
            this.Targets = Targets;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Targets
        /// </summary>
        [DataMember(Name="targets", EmitDefaultValue=false)]
        public List<CallForwardingNotificationTargets> Targets { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallForwardingNotificationCall {\n");
            
            sb.Append("  Targets: ").Append(Targets).Append("\n");
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
            return this.Equals(obj as CallForwardingNotificationCall);
        }

        /// <summary>
        /// Returns true if CallForwardingNotificationCall instances are equal
        /// </summary>
        /// <param name="other">Instance of CallForwardingNotificationCall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallForwardingNotificationCall other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Targets == other.Targets ||
                    this.Targets != null &&
                    this.Targets.SequenceEqual(other.Targets)
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
                
                if (this.Targets != null)
                    hash = hash * 59 + this.Targets.GetHashCode();
                
                return hash;
            }
        }
    }

}
