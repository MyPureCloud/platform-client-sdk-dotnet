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
    /// DraftIntents
    /// </summary>
    [DataContract]
    public partial class DraftIntents :  IEquatable<DraftIntents>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftIntents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DraftIntents() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftIntents" /> class.
        /// </summary>
        /// <param name="Id">Id for an intent. (required).</param>
        /// <param name="Name">Name/Label for an intent. (required).</param>
        /// <param name="Utterances">The utterances that are extracted for an Intent. (required).</param>
        public DraftIntents(string Id = null, string Name = null, List<string> Utterances = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Utterances = Utterances;
            
        }
        
        
        
        /// <summary>
        /// Id for an intent.
        /// </summary>
        /// <value>Id for an intent.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Name/Label for an intent.
        /// </summary>
        /// <value>Name/Label for an intent.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The utterances that are extracted for an Intent.
        /// </summary>
        /// <value>The utterances that are extracted for an Intent.</value>
        [DataMember(Name="utterances", EmitDefaultValue=false)]
        public List<string> Utterances { get; set; }
        
        
        
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
            sb.Append("class DraftIntents {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Utterances: ").Append(Utterances).Append("\n");
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
            return this.Equals(obj as DraftIntents);
        }

        /// <summary>
        /// Returns true if DraftIntents instances are equal
        /// </summary>
        /// <param name="other">Instance of DraftIntents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DraftIntents other)
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
                    this.Utterances == other.Utterances ||
                    this.Utterances != null &&
                    this.Utterances.SequenceEqual(other.Utterances)
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
                
                if (this.Utterances != null)
                    hash = hash * 59 + this.Utterances.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
