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
    /// A maximum of 100 events are allowed per request
    /// </summary>
    [DataContract]
    public partial class BatchUserRoutingStatusEventRequest :  IEquatable<BatchUserRoutingStatusEventRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchUserRoutingStatusEventRequest" /> class.
        /// </summary>
        /// <param name="UserRoutingStatusEvents">UserRoutingStatus events for this batch.</param>
        public BatchUserRoutingStatusEventRequest(List<UserRoutingStatusEvent> UserRoutingStatusEvents = null)
        {
            this.UserRoutingStatusEvents = UserRoutingStatusEvents;
            
        }
        


        /// <summary>
        /// UserRoutingStatus events for this batch
        /// </summary>
        /// <value>UserRoutingStatus events for this batch</value>
        [DataMember(Name="userRoutingStatusEvents", EmitDefaultValue=false)]
        public List<UserRoutingStatusEvent> UserRoutingStatusEvents { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUserRoutingStatusEventRequest {\n");

            sb.Append("  UserRoutingStatusEvents: ").Append(UserRoutingStatusEvents).Append("\n");
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
            return this.Equals(obj as BatchUserRoutingStatusEventRequest);
        }

        /// <summary>
        /// Returns true if BatchUserRoutingStatusEventRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchUserRoutingStatusEventRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchUserRoutingStatusEventRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserRoutingStatusEvents == other.UserRoutingStatusEvents ||
                    this.UserRoutingStatusEvents != null &&
                    this.UserRoutingStatusEvents.SequenceEqual(other.UserRoutingStatusEvents)
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
                if (this.UserRoutingStatusEvents != null)
                    hash = hash * 59 + this.UserRoutingStatusEvents.GetHashCode();

                return hash;
            }
        }
    }

}
