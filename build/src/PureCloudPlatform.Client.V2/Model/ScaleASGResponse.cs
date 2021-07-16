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
    /// ScaleASGResponse
    /// </summary>
    [DataContract]
    public partial class ScaleASGResponse :  IEquatable<ScaleASGResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScaleASGResponse" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DesiredCapacity">Desired capacity for the ASG.</param>
        /// <param name="MinSize">Minimum size for the ASG.</param>
        /// <param name="MaxSize">Maximum size for the ASG.</param>
        public ScaleASGResponse(string Name = null, int? DesiredCapacity = null, int? MinSize = null, int? MaxSize = null)
        {
            this.Name = Name;
            this.DesiredCapacity = DesiredCapacity;
            this.MinSize = MinSize;
            this.MaxSize = MaxSize;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Desired capacity for the ASG
        /// </summary>
        /// <value>Desired capacity for the ASG</value>
        [DataMember(Name="desiredCapacity", EmitDefaultValue=false)]
        public int? DesiredCapacity { get; set; }
        
        
        
        /// <summary>
        /// Minimum size for the ASG
        /// </summary>
        /// <value>Minimum size for the ASG</value>
        [DataMember(Name="minSize", EmitDefaultValue=false)]
        public int? MinSize { get; set; }
        
        
        
        /// <summary>
        /// Maximum size for the ASG
        /// </summary>
        /// <value>Maximum size for the ASG</value>
        [DataMember(Name="maxSize", EmitDefaultValue=false)]
        public int? MaxSize { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScaleASGResponse {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DesiredCapacity: ").Append(DesiredCapacity).Append("\n");
            sb.Append("  MinSize: ").Append(MinSize).Append("\n");
            sb.Append("  MaxSize: ").Append(MaxSize).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as ScaleASGResponse);
        }

        /// <summary>
        /// Returns true if ScaleASGResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ScaleASGResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScaleASGResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.DesiredCapacity == other.DesiredCapacity ||
                    this.DesiredCapacity != null &&
                    this.DesiredCapacity.Equals(other.DesiredCapacity)
                ) &&
                (
                    this.MinSize == other.MinSize ||
                    this.MinSize != null &&
                    this.MinSize.Equals(other.MinSize)
                ) &&
                (
                    this.MaxSize == other.MaxSize ||
                    this.MaxSize != null &&
                    this.MaxSize.Equals(other.MaxSize)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.DesiredCapacity != null)
                    hash = hash * 59 + this.DesiredCapacity.GetHashCode();
                
                if (this.MinSize != null)
                    hash = hash * 59 + this.MinSize.GetHashCode();
                
                if (this.MaxSize != null)
                    hash = hash * 59 + this.MaxSize.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
