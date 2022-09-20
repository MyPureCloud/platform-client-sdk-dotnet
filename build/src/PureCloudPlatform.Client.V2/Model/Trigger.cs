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
    /// Defines a process automation trigger.
    /// </summary>
    [DataContract]
    public partial class Trigger :  IEquatable<Trigger>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Trigger" /> class.
        /// </summary>
        /// <param name="Name">The name of the trigger.</param>
        /// <param name="TopicName">The topic that will cause the trigger to be invoked.</param>
        /// <param name="Target">The target to invoke when a matching event is received.</param>
        /// <param name="Version">Version of this trigger.</param>
        /// <param name="Enabled">Whether or not the trigger is enabled.</param>
        /// <param name="MatchCriteria">The configuration for when a trigger is considered to be a match for an event.</param>
        /// <param name="EventTTLSeconds">How long each event is meaningful after origination, in seconds. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely..</param>
        /// <param name="Description">Description of the trigger. Can be up to 512 characters in length..</param>
        public Trigger(string Name = null, string TopicName = null, TriggerTarget Target = null, long? Version = null, bool? Enabled = null, List<MatchCriteria> MatchCriteria = null, int? EventTTLSeconds = null, string Description = null)
        {
            this.Name = Name;
            this.TopicName = TopicName;
            this.Target = Target;
            this.Version = Version;
            this.Enabled = Enabled;
            this.MatchCriteria = MatchCriteria;
            this.EventTTLSeconds = EventTTLSeconds;
            this.Description = Description;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the trigger
        /// </summary>
        /// <value>The name of the trigger</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The topic that will cause the trigger to be invoked
        /// </summary>
        /// <value>The topic that will cause the trigger to be invoked</value>
        [DataMember(Name="topicName", EmitDefaultValue=false)]
        public string TopicName { get; set; }



        /// <summary>
        /// The target to invoke when a matching event is received
        /// </summary>
        /// <value>The target to invoke when a matching event is received</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public TriggerTarget Target { get; set; }



        /// <summary>
        /// Version of this trigger
        /// </summary>
        /// <value>Version of this trigger</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }



        /// <summary>
        /// Whether or not the trigger is enabled
        /// </summary>
        /// <value>Whether or not the trigger is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The configuration for when a trigger is considered to be a match for an event
        /// </summary>
        /// <value>The configuration for when a trigger is considered to be a match for an event</value>
        [DataMember(Name="matchCriteria", EmitDefaultValue=false)]
        public List<MatchCriteria> MatchCriteria { get; set; }



        /// <summary>
        /// How long each event is meaningful after origination, in seconds. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely.
        /// </summary>
        /// <value>How long each event is meaningful after origination, in seconds. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely.</value>
        [DataMember(Name="eventTTLSeconds", EmitDefaultValue=false)]
        public int? EventTTLSeconds { get; set; }



        /// <summary>
        /// Description of the trigger. Can be up to 512 characters in length.
        /// </summary>
        /// <value>Description of the trigger. Can be up to 512 characters in length.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



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
            sb.Append("class Trigger {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TopicName: ").Append(TopicName).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MatchCriteria: ").Append(MatchCriteria).Append("\n");
            sb.Append("  EventTTLSeconds: ").Append(EventTTLSeconds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as Trigger);
        }

        /// <summary>
        /// Returns true if Trigger instances are equal
        /// </summary>
        /// <param name="other">Instance of Trigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trigger other)
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
                    this.TopicName == other.TopicName ||
                    this.TopicName != null &&
                    this.TopicName.Equals(other.TopicName)
                ) &&
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) &&
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
                    this.MatchCriteria == other.MatchCriteria ||
                    this.MatchCriteria != null &&
                    this.MatchCriteria.SequenceEqual(other.MatchCriteria)
                ) &&
                (
                    this.EventTTLSeconds == other.EventTTLSeconds ||
                    this.EventTTLSeconds != null &&
                    this.EventTTLSeconds.Equals(other.EventTTLSeconds)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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

                if (this.TopicName != null)
                    hash = hash * 59 + this.TopicName.GetHashCode();

                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.MatchCriteria != null)
                    hash = hash * 59 + this.MatchCriteria.GetHashCode();

                if (this.EventTTLSeconds != null)
                    hash = hash * 59 + this.EventTTLSeconds.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
