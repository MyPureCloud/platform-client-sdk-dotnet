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
    /// UpdateTriggerRequest
    /// </summary>
    [DataContract]
    public partial class UpdateTriggerRequest :  IEquatable<UpdateTriggerRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTriggerRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateTriggerRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTriggerRequest" /> class.
        /// </summary>
        /// <param name="Version">Version of this trigger (required).</param>
        /// <param name="Enabled">Boolean indicating if Trigger is enabled (required).</param>
        /// <param name="Target">The target to invoke when a matching event is received (required).</param>
        /// <param name="MatchCriteria">The configuration for when a trigger is considered to be a match for an event.</param>
        /// <param name="Name">The name of the trigger (required).</param>
        /// <param name="TopicName">The topic that will cause the trigger to be invoked. Must match existing trigger topicName. (required).</param>
        /// <param name="EventTTLSeconds">Optional length of time that events are meaningful after origination. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely, otherwise must be set to at least 10 seconds. Only one of eventTTLSeconds or delayBySeconds can be set..</param>
        /// <param name="DelayBySeconds">Optional delay invoking target after trigger fires. Must be in the range of 60 to 900 seconds. Only one of eventTTLSeconds or delayBySeconds can be set. Until delayed triggers are released supplying this attribute will cause a failure..</param>
        /// <param name="Description">Description of the trigger. Can be up to 512 characters in length..</param>
        public UpdateTriggerRequest(long? Version = null, bool? Enabled = null, TriggerTarget Target = null, List<MatchCriteria> MatchCriteria = null, string Name = null, string TopicName = null, int? EventTTLSeconds = null, int? DelayBySeconds = null, string Description = null)
        {
            this.Version = Version;
            this.Enabled = Enabled;
            this.Target = Target;
            this.MatchCriteria = MatchCriteria;
            this.Name = Name;
            this.TopicName = TopicName;
            this.EventTTLSeconds = EventTTLSeconds;
            this.DelayBySeconds = DelayBySeconds;
            this.Description = Description;
            
        }
        


        /// <summary>
        /// Version of this trigger
        /// </summary>
        /// <value>Version of this trigger</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }



        /// <summary>
        /// Boolean indicating if Trigger is enabled
        /// </summary>
        /// <value>Boolean indicating if Trigger is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The target to invoke when a matching event is received
        /// </summary>
        /// <value>The target to invoke when a matching event is received</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public TriggerTarget Target { get; set; }



        /// <summary>
        /// The configuration for when a trigger is considered to be a match for an event
        /// </summary>
        /// <value>The configuration for when a trigger is considered to be a match for an event</value>
        [DataMember(Name="matchCriteria", EmitDefaultValue=false)]
        public List<MatchCriteria> MatchCriteria { get; set; }



        /// <summary>
        /// The name of the trigger
        /// </summary>
        /// <value>The name of the trigger</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The topic that will cause the trigger to be invoked. Must match existing trigger topicName.
        /// </summary>
        /// <value>The topic that will cause the trigger to be invoked. Must match existing trigger topicName.</value>
        [DataMember(Name="topicName", EmitDefaultValue=false)]
        public string TopicName { get; set; }



        /// <summary>
        /// Optional length of time that events are meaningful after origination. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely, otherwise must be set to at least 10 seconds. Only one of eventTTLSeconds or delayBySeconds can be set.
        /// </summary>
        /// <value>Optional length of time that events are meaningful after origination. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely, otherwise must be set to at least 10 seconds. Only one of eventTTLSeconds or delayBySeconds can be set.</value>
        [DataMember(Name="eventTTLSeconds", EmitDefaultValue=false)]
        public int? EventTTLSeconds { get; set; }



        /// <summary>
        /// Optional delay invoking target after trigger fires. Must be in the range of 60 to 900 seconds. Only one of eventTTLSeconds or delayBySeconds can be set. Until delayed triggers are released supplying this attribute will cause a failure.
        /// </summary>
        /// <value>Optional delay invoking target after trigger fires. Must be in the range of 60 to 900 seconds. Only one of eventTTLSeconds or delayBySeconds can be set. Until delayed triggers are released supplying this attribute will cause a failure.</value>
        [DataMember(Name="delayBySeconds", EmitDefaultValue=false)]
        public int? DelayBySeconds { get; set; }



        /// <summary>
        /// Description of the trigger. Can be up to 512 characters in length.
        /// </summary>
        /// <value>Description of the trigger. Can be up to 512 characters in length.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTriggerRequest {\n");

            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  MatchCriteria: ").Append(MatchCriteria).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TopicName: ").Append(TopicName).Append("\n");
            sb.Append("  EventTTLSeconds: ").Append(EventTTLSeconds).Append("\n");
            sb.Append("  DelayBySeconds: ").Append(DelayBySeconds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as UpdateTriggerRequest);
        }

        /// <summary>
        /// Returns true if UpdateTriggerRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateTriggerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTriggerRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) &&
                (
                    this.MatchCriteria == other.MatchCriteria ||
                    this.MatchCriteria != null &&
                    this.MatchCriteria.SequenceEqual(other.MatchCriteria)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.TopicName == other.TopicName ||
                    this.TopicName != null &&
                    this.TopicName.Equals(other.TopicName)
                ) &&
                (
                    this.EventTTLSeconds == other.EventTTLSeconds ||
                    this.EventTTLSeconds != null &&
                    this.EventTTLSeconds.Equals(other.EventTTLSeconds)
                ) &&
                (
                    this.DelayBySeconds == other.DelayBySeconds ||
                    this.DelayBySeconds != null &&
                    this.DelayBySeconds.Equals(other.DelayBySeconds)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();

                if (this.MatchCriteria != null)
                    hash = hash * 59 + this.MatchCriteria.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.TopicName != null)
                    hash = hash * 59 + this.TopicName.GetHashCode();

                if (this.EventTTLSeconds != null)
                    hash = hash * 59 + this.EventTTLSeconds.GetHashCode();

                if (this.DelayBySeconds != null)
                    hash = hash * 59 + this.DelayBySeconds.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                return hash;
            }
        }
    }

}
