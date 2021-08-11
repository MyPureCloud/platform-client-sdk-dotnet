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
    /// Details about an idle event trigger
    /// </summary>
    [DataContract]
    public partial class IdleEventTrigger :  IEquatable<IdleEventTrigger>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IdleEventTrigger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IdleEventTrigger() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IdleEventTrigger" /> class.
        /// </summary>
        /// <param name="EventName">Name of event triggered after period of inactivity. (required).</param>
        /// <param name="IdleAfterSeconds">Number of seconds of inactivity before an event is triggered..</param>
        public IdleEventTrigger(string EventName = null, long? IdleAfterSeconds = null)
        {
            this.EventName = EventName;
            this.IdleAfterSeconds = IdleAfterSeconds;
            
        }
        
        
        
        /// <summary>
        /// Name of event triggered after period of inactivity.
        /// </summary>
        /// <value>Name of event triggered after period of inactivity.</value>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; set; }
        
        
        
        /// <summary>
        /// Number of seconds of inactivity before an event is triggered.
        /// </summary>
        /// <value>Number of seconds of inactivity before an event is triggered.</value>
        [DataMember(Name="idleAfterSeconds", EmitDefaultValue=false)]
        public long? IdleAfterSeconds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdleEventTrigger {\n");
            
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  IdleAfterSeconds: ").Append(IdleAfterSeconds).Append("\n");
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
            return this.Equals(obj as IdleEventTrigger);
        }

        /// <summary>
        /// Returns true if IdleEventTrigger instances are equal
        /// </summary>
        /// <param name="other">Instance of IdleEventTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdleEventTrigger other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventName == other.EventName ||
                    this.EventName != null &&
                    this.EventName.Equals(other.EventName)
                ) &&
                (
                    this.IdleAfterSeconds == other.IdleAfterSeconds ||
                    this.IdleAfterSeconds != null &&
                    this.IdleAfterSeconds.Equals(other.IdleAfterSeconds)
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
                
                if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();
                
                if (this.IdleAfterSeconds != null)
                    hash = hash * 59 + this.IdleAfterSeconds.GetHashCode();
                
                return hash;
            }
        }
    }

}
