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
    /// Schema
    /// </summary>
    [DataContract]
    public partial class Schema :  IEquatable<Schema>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Schema" /> class.
        /// </summary>
        public Schema()
        {
            
        }
        
        
        
        /// <summary>
        /// A core type&#39;s title
        /// </summary>
        /// <value>A core type&#39;s title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; private set; }
        
        
        
        /// <summary>
        /// A core type&#39;s description
        /// </summary>
        /// <value>A core type&#39;s description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }
        
        
        
        /// <summary>
        /// An array of fundamental JSON Schema primitive types on which the core type is based
        /// </summary>
        /// <value>An array of fundamental JSON Schema primitive types on which the core type is based</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public List<string> Type { get; private set; }
        
        
        
        /// <summary>
        /// Denotes the type and pattern of the items in an enum core type
        /// </summary>
        /// <value>Denotes the type and pattern of the items in an enum core type</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public Items Items { get; private set; }
        
        
        
        /// <summary>
        /// For the \&quot;date\&quot; and \&quot;datetime\&quot; core types, denotes the regex prescribing the allowable date/datetime format
        /// </summary>
        /// <value>For the \&quot;date\&quot; and \&quot;datetime\&quot; core types, denotes the regex prescribing the allowable date/datetime format</value>
        [DataMember(Name="pattern", EmitDefaultValue=false)]
        public string Pattern { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Schema {\n");
            
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
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
            return this.Equals(obj as Schema);
        }

        /// <summary>
        /// Returns true if Schema instances are equal
        /// </summary>
        /// <param name="other">Instance of Schema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Schema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.SequenceEqual(other.Type)
                ) &&
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.Equals(other.Items)
                ) &&
                (
                    this.Pattern == other.Pattern ||
                    this.Pattern != null &&
                    this.Pattern.Equals(other.Pattern)
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
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                
                if (this.Pattern != null)
                    hash = hash * 59 + this.Pattern.GetHashCode();
                
                return hash;
            }
        }
    }

}
