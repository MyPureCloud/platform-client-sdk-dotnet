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
    /// Adjacents
    /// </summary>
    [DataContract]
    public partial class Adjacents :  IEquatable<Adjacents>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Adjacents" /> class.
        /// </summary>
        
        
        /// <param name="Superiors">Superiors.</param>
        
        
        
        /// <param name="Siblings">Siblings.</param>
        
        
        
        /// <param name="DirectReports">DirectReports.</param>
        
        
        public Adjacents(List<User> Superiors = null, List<User> Siblings = null, List<User> DirectReports = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Superiors = Superiors;
            
            
            
            
            
            
            
            
this.Siblings = Siblings;
            
            
            
            
            
            
            
            
this.DirectReports = DirectReports;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Superiors
        /// </summary>
        [DataMember(Name="superiors", EmitDefaultValue=false)]
        public List<User> Superiors { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Siblings
        /// </summary>
        [DataMember(Name="siblings", EmitDefaultValue=false)]
        public List<User> Siblings { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DirectReports
        /// </summary>
        [DataMember(Name="directReports", EmitDefaultValue=false)]
        public List<User> DirectReports { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Adjacents {\n");
            
            sb.Append("  Superiors: ").Append(Superiors).Append("\n");
            
            sb.Append("  Siblings: ").Append(Siblings).Append("\n");
            
            sb.Append("  DirectReports: ").Append(DirectReports).Append("\n");
            
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
            return this.Equals(obj as Adjacents);
        }

        /// <summary>
        /// Returns true if Adjacents instances are equal
        /// </summary>
        /// <param name="other">Instance of Adjacents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Adjacents other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Superiors == other.Superiors ||
                    this.Superiors != null &&
                    this.Superiors.SequenceEqual(other.Superiors)
                ) &&
                (
                    this.Siblings == other.Siblings ||
                    this.Siblings != null &&
                    this.Siblings.SequenceEqual(other.Siblings)
                ) &&
                (
                    this.DirectReports == other.DirectReports ||
                    this.DirectReports != null &&
                    this.DirectReports.SequenceEqual(other.DirectReports)
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
                
                if (this.Superiors != null)
                    hash = hash * 59 + this.Superiors.GetHashCode();
                
                if (this.Siblings != null)
                    hash = hash * 59 + this.Siblings.GetHashCode();
                
                if (this.DirectReports != null)
                    hash = hash * 59 + this.DirectReports.GetHashCode();
                
                return hash;
            }
        }
    }

}
