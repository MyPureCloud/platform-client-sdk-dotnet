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
    /// IdentityResolutionQueueConfig
    /// </summary>
    [DataContract]
    public partial class IdentityResolutionQueueConfig :  IEquatable<IdentityResolutionQueueConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityResolutionQueueConfig" /> class.
        /// </summary>
        /// <param name="CallOnBehalfOfQueue">CallOnBehalfOfQueue.</param>
        public IdentityResolutionQueueConfig(OutboundQueueIdentityResolutionConfig CallOnBehalfOfQueue = null)
        {
            this.CallOnBehalfOfQueue = CallOnBehalfOfQueue;
            
        }
        


        /// <summary>
        /// Gets or Sets CallOnBehalfOfQueue
        /// </summary>
        [DataMember(Name="callOnBehalfOfQueue", EmitDefaultValue=false)]
        public OutboundQueueIdentityResolutionConfig CallOnBehalfOfQueue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityResolutionQueueConfig {\n");

            sb.Append("  CallOnBehalfOfQueue: ").Append(CallOnBehalfOfQueue).Append("\n");
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
            return this.Equals(obj as IdentityResolutionQueueConfig);
        }

        /// <summary>
        /// Returns true if IdentityResolutionQueueConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of IdentityResolutionQueueConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityResolutionQueueConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CallOnBehalfOfQueue == other.CallOnBehalfOfQueue ||
                    this.CallOnBehalfOfQueue != null &&
                    this.CallOnBehalfOfQueue.Equals(other.CallOnBehalfOfQueue)
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
                if (this.CallOnBehalfOfQueue != null)
                    hash = hash * 59 + this.CallOnBehalfOfQueue.GetHashCode();

                return hash;
            }
        }
    }

}
