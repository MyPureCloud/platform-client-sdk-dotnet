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
    /// Path
    /// </summary>
    [DataContract]
    public partial class Path :  IEquatable<Path>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Path" /> class.
        /// </summary>
        /// <param name="SchemaUrn">SchemaUrn.</param>
        /// <param name="Root">Root.</param>
        public Path(string SchemaUrn = null, bool? Root = null)
        {
            this.SchemaUrn = SchemaUrn;
            this.Root = Root;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets SchemaUrn
        /// </summary>
        [DataMember(Name="schemaUrn", EmitDefaultValue=false)]
        public string SchemaUrn { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name="root", EmitDefaultValue=false)]
        public bool? Root { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Path {\n");
            
            sb.Append("  SchemaUrn: ").Append(SchemaUrn).Append("\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
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
            return this.Equals(obj as Path);
        }

        /// <summary>
        /// Returns true if Path instances are equal
        /// </summary>
        /// <param name="other">Instance of Path to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Path other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SchemaUrn == other.SchemaUrn ||
                    this.SchemaUrn != null &&
                    this.SchemaUrn.Equals(other.SchemaUrn)
                ) &&
                (
                    this.Root == other.Root ||
                    this.Root != null &&
                    this.Root.Equals(other.Root)
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
                
                if (this.SchemaUrn != null)
                    hash = hash * 59 + this.SchemaUrn.GetHashCode();
                
                if (this.Root != null)
                    hash = hash * 59 + this.Root.GetHashCode();
                
                return hash;
            }
        }
    }

}
