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
    /// EventDefinitionAggregates
    /// </summary>
    [DataContract]
    public partial class EventDefinitionAggregates :  IEquatable<EventDefinitionAggregates>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventDefinitionAggregates" /> class.
        /// </summary>
        /// <param name="EventDefinition">Event definition..</param>
        /// <param name="EventCount">How many events have occurred..</param>
        public EventDefinitionAggregates(AddressableEntityRef EventDefinition = null, int? EventCount = null)
        {
            this.EventDefinition = EventDefinition;
            this.EventCount = EventCount;
            
        }
        


        /// <summary>
        /// Event definition.
        /// </summary>
        /// <value>Event definition.</value>
        [DataMember(Name="eventDefinition", EmitDefaultValue=false)]
        public AddressableEntityRef EventDefinition { get; set; }



        /// <summary>
        /// How many events have occurred.
        /// </summary>
        /// <value>How many events have occurred.</value>
        [DataMember(Name="eventCount", EmitDefaultValue=false)]
        public int? EventCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventDefinitionAggregates {\n");

            sb.Append("  EventDefinition: ").Append(EventDefinition).Append("\n");
            sb.Append("  EventCount: ").Append(EventCount).Append("\n");
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
            return this.Equals(obj as EventDefinitionAggregates);
        }

        /// <summary>
        /// Returns true if EventDefinitionAggregates instances are equal
        /// </summary>
        /// <param name="other">Instance of EventDefinitionAggregates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventDefinitionAggregates other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventDefinition == other.EventDefinition ||
                    this.EventDefinition != null &&
                    this.EventDefinition.Equals(other.EventDefinition)
                ) &&
                (
                    this.EventCount == other.EventCount ||
                    this.EventCount != null &&
                    this.EventCount.Equals(other.EventCount)
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
                if (this.EventDefinition != null)
                    hash = hash * 59 + this.EventDefinition.GetHashCode();

                if (this.EventCount != null)
                    hash = hash * 59 + this.EventCount.GetHashCode();

                return hash;
            }
        }
    }

}
