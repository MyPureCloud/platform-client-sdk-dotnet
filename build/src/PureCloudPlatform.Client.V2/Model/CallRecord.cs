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
    /// CallRecord
    /// </summary>
    [DataContract]
    public partial class CallRecord :  IEquatable<CallRecord>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CallRecord" /> class.
        /// </summary>
        public CallRecord()
        {
            
        }
        
        
        
        /// <summary>
        /// Timestamp of the last attempt to reach this number. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp of the last attempt to reach this number. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="lastAttempt", EmitDefaultValue=false)]
        public DateTime? LastAttempt { get; private set; }
        
        
        
        /// <summary>
        /// Result of the last attempt to reach this number
        /// </summary>
        /// <value>Result of the last attempt to reach this number</value>
        [DataMember(Name="lastResult", EmitDefaultValue=false)]
        public string LastResult { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallRecord {\n");
            
            sb.Append("  LastAttempt: ").Append(LastAttempt).Append("\n");
            sb.Append("  LastResult: ").Append(LastResult).Append("\n");
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
            return this.Equals(obj as CallRecord);
        }

        /// <summary>
        /// Returns true if CallRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of CallRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LastAttempt == other.LastAttempt ||
                    this.LastAttempt != null &&
                    this.LastAttempt.Equals(other.LastAttempt)
                ) &&
                (
                    this.LastResult == other.LastResult ||
                    this.LastResult != null &&
                    this.LastResult.Equals(other.LastResult)
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
                
                if (this.LastAttempt != null)
                    hash = hash * 59 + this.LastAttempt.GetHashCode();
                
                if (this.LastResult != null)
                    hash = hash * 59 + this.LastResult.GetHashCode();
                
                return hash;
            }
        }
    }

}
