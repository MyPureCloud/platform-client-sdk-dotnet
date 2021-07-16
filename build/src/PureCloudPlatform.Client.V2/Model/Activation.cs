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
    /// Activation
    /// </summary>
    [DataContract]
    public partial class Activation :  IEquatable<Activation>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Activation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Activation() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Activation" /> class.
        /// </summary>
        /// <param name="Type">Type of activation. (required).</param>
        /// <param name="DelayInSeconds">Activation delay time amount..</param>
        public Activation(string Type = null, int? DelayInSeconds = null)
        {
            this.Type = Type;
            this.DelayInSeconds = DelayInSeconds;
            
        }
        
        
        
        /// <summary>
        /// Type of activation.
        /// </summary>
        /// <value>Type of activation.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        
        
        
        /// <summary>
        /// Activation delay time amount.
        /// </summary>
        /// <value>Activation delay time amount.</value>
        [DataMember(Name="delayInSeconds", EmitDefaultValue=false)]
        public int? DelayInSeconds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Activation {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DelayInSeconds: ").Append(DelayInSeconds).Append("\n");
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
            return this.Equals(obj as Activation);
        }

        /// <summary>
        /// Returns true if Activation instances are equal
        /// </summary>
        /// <param name="other">Instance of Activation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.DelayInSeconds == other.DelayInSeconds ||
                    this.DelayInSeconds != null &&
                    this.DelayInSeconds.Equals(other.DelayInSeconds)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.DelayInSeconds != null)
                    hash = hash * 59 + this.DelayInSeconds.GetHashCode();
                
                return hash;
            }
        }
    }

}
