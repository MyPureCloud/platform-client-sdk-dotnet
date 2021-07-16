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
    /// LexIntent
    /// </summary>
    [DataContract]
    public partial class LexIntent :  IEquatable<LexIntent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LexIntent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LexIntent() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LexIntent" /> class.
        /// </summary>
        /// <param name="Name">The intent name (required).</param>
        /// <param name="Description">A description of the intent.</param>
        /// <param name="Slots">An object mapping slot names to Slot objects (required).</param>
        /// <param name="Version">The intent version (required).</param>
        public LexIntent(string Name = null, string Description = null, Dictionary<string, LexSlot> Slots = null, string Version = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Slots = Slots;
            this.Version = Version;
            
        }
        
        
        
        /// <summary>
        /// The intent name
        /// </summary>
        /// <value>The intent name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// A description of the intent
        /// </summary>
        /// <value>A description of the intent</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// An object mapping slot names to Slot objects
        /// </summary>
        /// <value>An object mapping slot names to Slot objects</value>
        [DataMember(Name="slots", EmitDefaultValue=false)]
        public Dictionary<string, LexSlot> Slots { get; set; }
        
        
        
        /// <summary>
        /// The intent version
        /// </summary>
        /// <value>The intent version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LexIntent {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Slots: ").Append(Slots).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as LexIntent);
        }

        /// <summary>
        /// Returns true if LexIntent instances are equal
        /// </summary>
        /// <param name="other">Instance of LexIntent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LexIntent other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Slots == other.Slots ||
                    this.Slots != null &&
                    this.Slots.SequenceEqual(other.Slots)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Slots != null)
                    hash = hash * 59 + this.Slots.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                return hash;
            }
        }
    }

}
