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
    /// ObservationDataContainer
    /// </summary>
    [DataContract]
    public partial class ObservationDataContainer :  IEquatable<ObservationDataContainer>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationDataContainer" /> class.
        /// </summary>
        
        
        /// <param name="Group">A mapping from dimension to value.</param>
        
        
        
        /// <param name="Data">Data.</param>
        
        
        public ObservationDataContainer(Dictionary<string, string> Group = null, List<AggregateMetricData> Data = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Group = Group;
            
            
            
            
            
            
            
            
this.Data = Data;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// A mapping from dimension to value
        /// </summary>
        /// <value>A mapping from dimension to value</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public Dictionary<string, string> Group { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<AggregateMetricData> Data { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObservationDataContainer {\n");
            
            sb.Append("  Group: ").Append(Group).Append("\n");
            
            sb.Append("  Data: ").Append(Data).Append("\n");
            
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
            return this.Equals(obj as ObservationDataContainer);
        }

        /// <summary>
        /// Returns true if ObservationDataContainer instances are equal
        /// </summary>
        /// <param name="other">Instance of ObservationDataContainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObservationDataContainer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.SequenceEqual(other.Group)
                ) &&
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
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
                
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                return hash;
            }
        }
    }

}
