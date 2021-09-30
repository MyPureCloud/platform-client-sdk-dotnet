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
    /// OverallBestPoints
    /// </summary>
    [DataContract]
    public partial class OverallBestPoints :  IEquatable<OverallBestPoints>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OverallBestPoints" /> class.
        /// </summary>
        public OverallBestPoints()
        {
            
        }
        
        
        
        /// <summary>
        /// The requested division
        /// </summary>
        /// <value>The requested division</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public Division Division { get; private set; }
        
        
        
        /// <summary>
        /// List of gamification best point items
        /// </summary>
        /// <value>List of gamification best point items</value>
        [DataMember(Name="bestPoints", EmitDefaultValue=false)]
        public List<OverallBestPointsItem> BestPoints { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OverallBestPoints {\n");
            
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  BestPoints: ").Append(BestPoints).Append("\n");
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
            return this.Equals(obj as OverallBestPoints);
        }

        /// <summary>
        /// Returns true if OverallBestPoints instances are equal
        /// </summary>
        /// <param name="other">Instance of OverallBestPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverallBestPoints other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.BestPoints == other.BestPoints ||
                    this.BestPoints != null &&
                    this.BestPoints.SequenceEqual(other.BestPoints)
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
                
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                
                if (this.BestPoints != null)
                    hash = hash * 59 + this.BestPoints.GetHashCode();
                
                return hash;
            }
        }
    }

}
