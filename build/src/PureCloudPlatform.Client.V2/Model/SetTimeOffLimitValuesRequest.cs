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
    /// The non-empty list of the time off limit value intervals
    /// </summary>
    [DataContract]
    public partial class SetTimeOffLimitValuesRequest :  IEquatable<SetTimeOffLimitValuesRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SetTimeOffLimitValuesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetTimeOffLimitValuesRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SetTimeOffLimitValuesRequest" /> class.
        /// </summary>
        /// <param name="Values">Values.</param>
        /// <param name="Metadata">Version metadata for the time off limit (required).</param>
        public SetTimeOffLimitValuesRequest(List<TimeOffLimitRange> Values = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Values = Values;
            this.Metadata = Metadata;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<TimeOffLimitRange> Values { get; set; }
        
        
        
        /// <summary>
        /// Version metadata for the time off limit
        /// </summary>
        /// <value>Version metadata for the time off limit</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetTimeOffLimitValuesRequest {\n");
            
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as SetTimeOffLimitValuesRequest);
        }

        /// <summary>
        /// Returns true if SetTimeOffLimitValuesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SetTimeOffLimitValuesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetTimeOffLimitValuesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                return hash;
            }
        }
    }

}
