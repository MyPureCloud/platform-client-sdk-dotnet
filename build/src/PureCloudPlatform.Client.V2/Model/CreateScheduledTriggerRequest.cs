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
    /// CreateScheduledTriggerRequest
    /// </summary>
    [DataContract]
    public partial class CreateScheduledTriggerRequest :  IEquatable<CreateScheduledTriggerRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduledTriggerRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateScheduledTriggerRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduledTriggerRequest" /> class.
        /// </summary>
        /// <param name="Target">The target to invoke when the scheduled trigger fires (required).</param>
        /// <param name="Enabled">Boolean indicating if scheduled trigger is enabled (required).</param>
        /// <param name="Name">The name of the scheduled trigger. Can be up to 162 characters in length. (required).</param>
        /// <param name="Schedule">The schedule configuration for when this trigger should fire (required).</param>
        /// <param name="Description">Description of the trigger. Can be up to 512 characters in length..</param>
        public CreateScheduledTriggerRequest(TriggerTarget Target = null, bool? Enabled = null, string Name = null, TriggerSchedule Schedule = null, string Description = null)
        {
            this.Target = Target;
            this.Enabled = Enabled;
            this.Name = Name;
            this.Schedule = Schedule;
            this.Description = Description;
            
        }
        


        /// <summary>
        /// The target to invoke when the scheduled trigger fires
        /// </summary>
        /// <value>The target to invoke when the scheduled trigger fires</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public TriggerTarget Target { get; set; }



        /// <summary>
        /// Boolean indicating if scheduled trigger is enabled
        /// </summary>
        /// <value>Boolean indicating if scheduled trigger is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The name of the scheduled trigger. Can be up to 162 characters in length.
        /// </summary>
        /// <value>The name of the scheduled trigger. Can be up to 162 characters in length.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The schedule configuration for when this trigger should fire
        /// </summary>
        /// <value>The schedule configuration for when this trigger should fire</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public TriggerSchedule Schedule { get; set; }



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
            sb.Append("class CreateScheduledTriggerRequest {\n");

            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return this.Equals(obj as CreateScheduledTriggerRequest);
        }

        /// <summary>
        /// Returns true if CreateScheduledTriggerRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateScheduledTriggerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateScheduledTriggerRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
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
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                return hash;
            }
        }
    }

}
