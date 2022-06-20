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
    /// JourneyOutcomeEventsNotificationOutcomeAttributionMessage
    /// </summary>
    [DataContract]
    public partial class JourneyOutcomeEventsNotificationOutcomeAttributionMessage :  IEquatable<JourneyOutcomeEventsNotificationOutcomeAttributionMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyOutcomeEventsNotificationOutcomeAttributionMessage" /> class.
        /// </summary>
        /// <param name="Outcome">Outcome.</param>
        /// <param name="OutcomeTouchpoints">OutcomeTouchpoints.</param>
        /// <param name="SegmentAssignments">SegmentAssignments.</param>
        /// <param name="AssociatedValue">AssociatedValue.</param>
        public JourneyOutcomeEventsNotificationOutcomeAttributionMessage(JourneyOutcomeEventsNotificationOutcome Outcome = null, List<JourneyOutcomeEventsNotificationOutcomeTouchpoint> OutcomeTouchpoints = null, List<JourneyOutcomeEventsNotificationSegment> SegmentAssignments = null, JourneyOutcomeEventsNotificationAssociatedValue AssociatedValue = null)
        {
            this.Outcome = Outcome;
            this.OutcomeTouchpoints = OutcomeTouchpoints;
            this.SegmentAssignments = SegmentAssignments;
            this.AssociatedValue = AssociatedValue;
            
        }
        


        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name="outcome", EmitDefaultValue=false)]
        public JourneyOutcomeEventsNotificationOutcome Outcome { get; set; }



        /// <summary>
        /// Gets or Sets OutcomeTouchpoints
        /// </summary>
        [DataMember(Name="outcomeTouchpoints", EmitDefaultValue=false)]
        public List<JourneyOutcomeEventsNotificationOutcomeTouchpoint> OutcomeTouchpoints { get; set; }



        /// <summary>
        /// Gets or Sets SegmentAssignments
        /// </summary>
        [DataMember(Name="segmentAssignments", EmitDefaultValue=false)]
        public List<JourneyOutcomeEventsNotificationSegment> SegmentAssignments { get; set; }



        /// <summary>
        /// Gets or Sets AssociatedValue
        /// </summary>
        [DataMember(Name="associatedValue", EmitDefaultValue=false)]
        public JourneyOutcomeEventsNotificationAssociatedValue AssociatedValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyOutcomeEventsNotificationOutcomeAttributionMessage {\n");

            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  OutcomeTouchpoints: ").Append(OutcomeTouchpoints).Append("\n");
            sb.Append("  SegmentAssignments: ").Append(SegmentAssignments).Append("\n");
            sb.Append("  AssociatedValue: ").Append(AssociatedValue).Append("\n");
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
            return this.Equals(obj as JourneyOutcomeEventsNotificationOutcomeAttributionMessage);
        }

        /// <summary>
        /// Returns true if JourneyOutcomeEventsNotificationOutcomeAttributionMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyOutcomeEventsNotificationOutcomeAttributionMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyOutcomeEventsNotificationOutcomeAttributionMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Outcome == other.Outcome ||
                    this.Outcome != null &&
                    this.Outcome.Equals(other.Outcome)
                ) &&
                (
                    this.OutcomeTouchpoints == other.OutcomeTouchpoints ||
                    this.OutcomeTouchpoints != null &&
                    this.OutcomeTouchpoints.SequenceEqual(other.OutcomeTouchpoints)
                ) &&
                (
                    this.SegmentAssignments == other.SegmentAssignments ||
                    this.SegmentAssignments != null &&
                    this.SegmentAssignments.SequenceEqual(other.SegmentAssignments)
                ) &&
                (
                    this.AssociatedValue == other.AssociatedValue ||
                    this.AssociatedValue != null &&
                    this.AssociatedValue.Equals(other.AssociatedValue)
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
                if (this.Outcome != null)
                    hash = hash * 59 + this.Outcome.GetHashCode();

                if (this.OutcomeTouchpoints != null)
                    hash = hash * 59 + this.OutcomeTouchpoints.GetHashCode();

                if (this.SegmentAssignments != null)
                    hash = hash * 59 + this.SegmentAssignments.GetHashCode();

                if (this.AssociatedValue != null)
                    hash = hash * 59 + this.AssociatedValue.GetHashCode();

                return hash;
            }
        }
    }

}
