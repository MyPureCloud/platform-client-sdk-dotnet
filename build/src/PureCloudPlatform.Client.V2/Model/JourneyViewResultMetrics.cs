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
    /// The metrics of an element or a link in journey 
    /// </summary>
    [DataContract]
    public partial class JourneyViewResultMetrics :  IEquatable<JourneyViewResultMetrics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewResultMetrics" /> class.
        /// </summary>
        public JourneyViewResultMetrics()
        {
            
        }
        


        /// <summary>
        /// number of external contacts who participated at the element
        /// </summary>
        /// <value>number of external contacts who participated at the element</value>
        [DataMember(Name="participantCount", EmitDefaultValue=false)]
        public int? ParticipantCount { get; private set; }



        /// <summary>
        /// number of external contacts who could still complete the journey
        /// </summary>
        /// <value>number of external contacts who could still complete the journey</value>
        [DataMember(Name="activeCount", EmitDefaultValue=false)]
        public int? ActiveCount { get; private set; }



        /// <summary>
        /// number of external contacts who completed the journey forward
        /// </summary>
        /// <value>number of external contacts who completed the journey forward</value>
        [DataMember(Name="completedCount", EmitDefaultValue=false)]
        public int? CompletedCount { get; private set; }



        /// <summary>
        /// number of external contacts who did not make it to the next element
        /// </summary>
        /// <value>number of external contacts who did not make it to the next element</value>
        [DataMember(Name="dropoutCount", EmitDefaultValue=false)]
        public int? DropoutCount { get; private set; }



        /// <summary>
        /// number of external contacts who moved from one element to next element but did not complete the journey
        /// </summary>
        /// <value>number of external contacts who moved from one element to next element but did not complete the journey</value>
        [DataMember(Name="flowCount", EmitDefaultValue=false)]
        public int? FlowCount { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewResultMetrics {\n");

            sb.Append("  ParticipantCount: ").Append(ParticipantCount).Append("\n");
            sb.Append("  ActiveCount: ").Append(ActiveCount).Append("\n");
            sb.Append("  CompletedCount: ").Append(CompletedCount).Append("\n");
            sb.Append("  DropoutCount: ").Append(DropoutCount).Append("\n");
            sb.Append("  FlowCount: ").Append(FlowCount).Append("\n");
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
            return this.Equals(obj as JourneyViewResultMetrics);
        }

        /// <summary>
        /// Returns true if JourneyViewResultMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewResultMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewResultMetrics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ParticipantCount == other.ParticipantCount ||
                    this.ParticipantCount != null &&
                    this.ParticipantCount.Equals(other.ParticipantCount)
                ) &&
                (
                    this.ActiveCount == other.ActiveCount ||
                    this.ActiveCount != null &&
                    this.ActiveCount.Equals(other.ActiveCount)
                ) &&
                (
                    this.CompletedCount == other.CompletedCount ||
                    this.CompletedCount != null &&
                    this.CompletedCount.Equals(other.CompletedCount)
                ) &&
                (
                    this.DropoutCount == other.DropoutCount ||
                    this.DropoutCount != null &&
                    this.DropoutCount.Equals(other.DropoutCount)
                ) &&
                (
                    this.FlowCount == other.FlowCount ||
                    this.FlowCount != null &&
                    this.FlowCount.Equals(other.FlowCount)
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
                if (this.ParticipantCount != null)
                    hash = hash * 59 + this.ParticipantCount.GetHashCode();

                if (this.ActiveCount != null)
                    hash = hash * 59 + this.ActiveCount.GetHashCode();

                if (this.CompletedCount != null)
                    hash = hash * 59 + this.CompletedCount.GetHashCode();

                if (this.DropoutCount != null)
                    hash = hash * 59 + this.DropoutCount.GetHashCode();

                if (this.FlowCount != null)
                    hash = hash * 59 + this.FlowCount.GetHashCode();

                return hash;
            }
        }
    }

}
