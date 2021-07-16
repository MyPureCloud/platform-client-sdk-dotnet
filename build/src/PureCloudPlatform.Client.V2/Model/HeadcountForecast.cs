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
    /// Headcount interval information for schedule
    /// </summary>
    [DataContract]
    public partial class HeadcountForecast :  IEquatable<HeadcountForecast>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HeadcountForecast" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HeadcountForecast() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HeadcountForecast" /> class.
        /// </summary>
        /// <param name="Required">Headcount information with shrinkage (required).</param>
        /// <param name="RequiredWithoutShrinkage">Headcount information without shrinkage (required).</param>
        public HeadcountForecast(List<HeadcountInterval> Required = null, List<HeadcountInterval> RequiredWithoutShrinkage = null)
        {
            this.Required = Required;
            this.RequiredWithoutShrinkage = RequiredWithoutShrinkage;
            
        }
        
        
        
        /// <summary>
        /// Headcount information with shrinkage
        /// </summary>
        /// <value>Headcount information with shrinkage</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public List<HeadcountInterval> Required { get; set; }
        
        
        
        /// <summary>
        /// Headcount information without shrinkage
        /// </summary>
        /// <value>Headcount information without shrinkage</value>
        [DataMember(Name="requiredWithoutShrinkage", EmitDefaultValue=false)]
        public List<HeadcountInterval> RequiredWithoutShrinkage { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HeadcountForecast {\n");
            
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  RequiredWithoutShrinkage: ").Append(RequiredWithoutShrinkage).Append("\n");
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
            return this.Equals(obj as HeadcountForecast);
        }

        /// <summary>
        /// Returns true if HeadcountForecast instances are equal
        /// </summary>
        /// <param name="other">Instance of HeadcountForecast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HeadcountForecast other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.SequenceEqual(other.Required)
                ) &&
                (
                    this.RequiredWithoutShrinkage == other.RequiredWithoutShrinkage ||
                    this.RequiredWithoutShrinkage != null &&
                    this.RequiredWithoutShrinkage.SequenceEqual(other.RequiredWithoutShrinkage)
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
                
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                
                if (this.RequiredWithoutShrinkage != null)
                    hash = hash * 59 + this.RequiredWithoutShrinkage.GetHashCode();
                
                return hash;
            }
        }
    }

}
