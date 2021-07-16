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
    /// AsgScaleRequest
    /// </summary>
    [DataContract]
    public partial class AsgScaleRequest :  IEquatable<AsgScaleRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AsgScaleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AsgScaleRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AsgScaleRequest" /> class.
        /// </summary>
        /// <param name="DesiredCapacity">The desired capacity of the ASG (required).</param>
        /// <param name="MinimumCapacity">The minimum capacity of the ASG (required).</param>
        public AsgScaleRequest(int? DesiredCapacity = null, int? MinimumCapacity = null)
        {
            this.DesiredCapacity = DesiredCapacity;
            this.MinimumCapacity = MinimumCapacity;
            
        }
        
        
        
        /// <summary>
        /// The desired capacity of the ASG
        /// </summary>
        /// <value>The desired capacity of the ASG</value>
        [DataMember(Name="desiredCapacity", EmitDefaultValue=false)]
        public int? DesiredCapacity { get; set; }
        
        
        
        /// <summary>
        /// The minimum capacity of the ASG
        /// </summary>
        /// <value>The minimum capacity of the ASG</value>
        [DataMember(Name="minimumCapacity", EmitDefaultValue=false)]
        public int? MinimumCapacity { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsgScaleRequest {\n");
            
            sb.Append("  DesiredCapacity: ").Append(DesiredCapacity).Append("\n");
            sb.Append("  MinimumCapacity: ").Append(MinimumCapacity).Append("\n");
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
            return this.Equals(obj as AsgScaleRequest);
        }

        /// <summary>
        /// Returns true if AsgScaleRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AsgScaleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsgScaleRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DesiredCapacity == other.DesiredCapacity ||
                    this.DesiredCapacity != null &&
                    this.DesiredCapacity.Equals(other.DesiredCapacity)
                ) &&
                (
                    this.MinimumCapacity == other.MinimumCapacity ||
                    this.MinimumCapacity != null &&
                    this.MinimumCapacity.Equals(other.MinimumCapacity)
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
                
                if (this.DesiredCapacity != null)
                    hash = hash * 59 + this.DesiredCapacity.GetHashCode();
                
                if (this.MinimumCapacity != null)
                    hash = hash * 59 + this.MinimumCapacity.GetHashCode();
                
                return hash;
            }
        }
    }

}
