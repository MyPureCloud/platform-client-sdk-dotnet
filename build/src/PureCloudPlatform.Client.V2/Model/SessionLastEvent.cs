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
    /// SessionLastEvent
    /// </summary>
    [DataContract]
    public partial class SessionLastEvent :  IEquatable<SessionLastEvent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLastEvent" /> class.
        /// </summary>
        /// <param name="EventName">The name of the event..</param>
        /// <param name="CreatedDate">Timestamp indicating when the event was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public SessionLastEvent(string EventName = null, DateTime? CreatedDate = null)
        {
            this.EventName = EventName;
            this.CreatedDate = CreatedDate;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the event.
        /// </summary>
        /// <value>The name of the event.</value>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; set; }
        
        
        
        /// <summary>
        /// Timestamp indicating when the event was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the event was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionLastEvent {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
            return this.Equals(obj as SessionLastEvent);
        }

        /// <summary>
        /// Returns true if SessionLastEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of SessionLastEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionLastEvent other)
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
                    this.EventName == other.EventName ||
                    this.EventName != null &&
                    this.EventName.Equals(other.EventName)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
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
                
                if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
