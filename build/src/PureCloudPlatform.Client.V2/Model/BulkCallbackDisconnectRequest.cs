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
    /// BulkCallbackDisconnectRequest
    /// </summary>
    [DataContract]
    public partial class BulkCallbackDisconnectRequest :  IEquatable<BulkCallbackDisconnectRequest>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCallbackDisconnectRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkCallbackDisconnectRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCallbackDisconnectRequest" /> class.
        /// </summary>
        /// <param name="CallbackDisconnectIdentifiers">The list of requests to disconnect callbacks in bulk (required).</param>
        public BulkCallbackDisconnectRequest(List<CallbackDisconnectIdentifier> CallbackDisconnectIdentifiers = null)
        {
            this.CallbackDisconnectIdentifiers = CallbackDisconnectIdentifiers;
            
        }
        
        
        
        /// <summary>
        /// The list of requests to disconnect callbacks in bulk
        /// </summary>
        /// <value>The list of requests to disconnect callbacks in bulk</value>
        [DataMember(Name="callbackDisconnectIdentifiers", EmitDefaultValue=false)]
        public List<CallbackDisconnectIdentifier> CallbackDisconnectIdentifiers { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkCallbackDisconnectRequest {\n");
            
            sb.Append("  CallbackDisconnectIdentifiers: ").Append(CallbackDisconnectIdentifiers).Append("\n");
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
            return this.Equals(obj as BulkCallbackDisconnectRequest);
        }

        /// <summary>
        /// Returns true if BulkCallbackDisconnectRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkCallbackDisconnectRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkCallbackDisconnectRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CallbackDisconnectIdentifiers == other.CallbackDisconnectIdentifiers ||
                    this.CallbackDisconnectIdentifiers != null &&
                    this.CallbackDisconnectIdentifiers.SequenceEqual(other.CallbackDisconnectIdentifiers)
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
                
                if (this.CallbackDisconnectIdentifiers != null)
                    hash = hash * 59 + this.CallbackDisconnectIdentifiers.GetHashCode();
                
                return hash;
            }
        }
    }

}
