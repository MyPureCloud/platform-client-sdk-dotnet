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
    /// ConversationThreadingWindow
    /// </summary>
    [DataContract]
    public partial class ConversationThreadingWindow :  IEquatable<ConversationThreadingWindow>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationThreadingWindow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationThreadingWindow() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationThreadingWindow" /> class.
        /// </summary>
        /// <param name="Settings">The conversation threading window timeout (Minutes) for each messaging type (required).</param>
        public ConversationThreadingWindow(List<ConversationThreadingWindowSetting> Settings = null)
        {
            this.Settings = Settings;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The conversation threading window timeout (Minutes) for each messaging type
        /// </summary>
        /// <value>The conversation threading window timeout (Minutes) for each messaging type</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public List<ConversationThreadingWindowSetting> Settings { get; set; }
        
        
        
        /// <summary>
        /// The default conversation threading window timeout (Minutes)
        /// </summary>
        /// <value>The default conversation threading window timeout (Minutes)</value>
        [DataMember(Name="defaultTimeoutMinutes", EmitDefaultValue=false)]
        public long? DefaultTimeoutMinutes { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationThreadingWindow {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  DefaultTimeoutMinutes: ").Append(DefaultTimeoutMinutes).Append("\n");
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
            return this.Equals(obj as ConversationThreadingWindow);
        }

        /// <summary>
        /// Returns true if ConversationThreadingWindow instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationThreadingWindow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationThreadingWindow other)
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
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.SequenceEqual(other.Settings)
                ) &&
                (
                    this.DefaultTimeoutMinutes == other.DefaultTimeoutMinutes ||
                    this.DefaultTimeoutMinutes != null &&
                    this.DefaultTimeoutMinutes.Equals(other.DefaultTimeoutMinutes)
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
                
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                
                if (this.DefaultTimeoutMinutes != null)
                    hash = hash * 59 + this.DefaultTimeoutMinutes.GetHashCode();
                
                return hash;
            }
        }
    }

}
