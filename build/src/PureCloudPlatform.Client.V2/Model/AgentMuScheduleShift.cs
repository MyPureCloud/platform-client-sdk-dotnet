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
    /// AgentMuScheduleShift
    /// </summary>
    [DataContract]
    public partial class AgentMuScheduleShift :  IEquatable<AgentMuScheduleShift>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMuScheduleShift" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentMuScheduleShift() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMuScheduleShift" /> class.
        /// </summary>
        /// <param name="StartOffsetMinutes">The start offset of the shift, relative to referenceStartDate at the top level (required).</param>
        /// <param name="LengthMinutes">The length of the shift in minutes (required).</param>
        /// <param name="Activities">The activities associated with this shift (required).</param>
        public AgentMuScheduleShift(int? StartOffsetMinutes = null, int? LengthMinutes = null, List<AgentScheduleShiftActivity> Activities = null)
        {
            this.StartOffsetMinutes = StartOffsetMinutes;
            this.LengthMinutes = LengthMinutes;
            this.Activities = Activities;
            
        }
        


        /// <summary>
        /// The start offset of the shift, relative to referenceStartDate at the top level
        /// </summary>
        /// <value>The start offset of the shift, relative to referenceStartDate at the top level</value>
        [DataMember(Name="startOffsetMinutes", EmitDefaultValue=false)]
        public int? StartOffsetMinutes { get; set; }



        /// <summary>
        /// The length of the shift in minutes
        /// </summary>
        /// <value>The length of the shift in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }



        /// <summary>
        /// The activities associated with this shift
        /// </summary>
        /// <value>The activities associated with this shift</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<AgentScheduleShiftActivity> Activities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentMuScheduleShift {\n");

            sb.Append("  StartOffsetMinutes: ").Append(StartOffsetMinutes).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
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
            return this.Equals(obj as AgentMuScheduleShift);
        }

        /// <summary>
        /// Returns true if AgentMuScheduleShift instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentMuScheduleShift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentMuScheduleShift other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartOffsetMinutes == other.StartOffsetMinutes ||
                    this.StartOffsetMinutes != null &&
                    this.StartOffsetMinutes.Equals(other.StartOffsetMinutes)
                ) &&
                (
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
                ) &&
                (
                    this.Activities == other.Activities ||
                    this.Activities != null &&
                    this.Activities.SequenceEqual(other.Activities)
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
                if (this.StartOffsetMinutes != null)
                    hash = hash * 59 + this.StartOffsetMinutes.GetHashCode();

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                if (this.Activities != null)
                    hash = hash * 59 + this.Activities.GetHashCode();

                return hash;
            }
        }
    }

}
