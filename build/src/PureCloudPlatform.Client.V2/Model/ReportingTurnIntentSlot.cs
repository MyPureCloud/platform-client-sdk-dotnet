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
    /// ReportingTurnIntentSlot
    /// </summary>
    [DataContract]
    public partial class ReportingTurnIntentSlot :  IEquatable<ReportingTurnIntentSlot>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingTurnIntentSlot" /> class.
        /// </summary>
        /// <param name="Name">The name of the slot..</param>
        /// <param name="Value">The value of the slot..</param>
        /// <param name="Type">The NLU entity type of the slot (either builtin or user defined).</param>
        /// <param name="Confidence">The confidence score this slot received during detection..</param>
        public ReportingTurnIntentSlot(string Name = null, string Value = null, string Type = null, double? Confidence = null)
        {
            this.Name = Name;
            this.Value = Value;
            this.Type = Type;
            this.Confidence = Confidence;
            
        }
        
        
        
        /// <summary>
        /// The name of the slot.
        /// </summary>
        /// <value>The name of the slot.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The value of the slot.
        /// </summary>
        /// <value>The value of the slot.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        /// <summary>
        /// The NLU entity type of the slot (either builtin or user defined)
        /// </summary>
        /// <value>The NLU entity type of the slot (either builtin or user defined)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        
        
        
        /// <summary>
        /// The confidence score this slot received during detection.
        /// </summary>
        /// <value>The confidence score this slot received during detection.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double? Confidence { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingTurnIntentSlot {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
            return this.Equals(obj as ReportingTurnIntentSlot);
        }

        /// <summary>
        /// Returns true if ReportingTurnIntentSlot instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingTurnIntentSlot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingTurnIntentSlot other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();
                
                return hash;
            }
        }
    }

}
