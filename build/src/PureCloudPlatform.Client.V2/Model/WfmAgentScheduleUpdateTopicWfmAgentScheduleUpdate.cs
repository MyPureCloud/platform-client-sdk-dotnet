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
    /// WfmAgentScheduleUpdateTopicWfmAgentScheduleUpdate
    /// </summary>
    [DataContract]
    public partial class WfmAgentScheduleUpdateTopicWfmAgentScheduleUpdate :  IEquatable<WfmAgentScheduleUpdateTopicWfmAgentScheduleUpdate>
    {
        /// <summary>
        /// Gets or Sets UpdateType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UpdateTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Added for "Added"
            /// </summary>
            [EnumMember(Value = "Added")]
            Added,
            
            /// <summary>
            /// Enum Edited for "Edited"
            /// </summary>
            [EnumMember(Value = "Edited")]
            Edited,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted
        }
        /// <summary>
        /// Gets or Sets UpdateType
        /// </summary>
        [DataMember(Name="updateType", EmitDefaultValue=false)]
        public UpdateTypeEnum? UpdateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmAgentScheduleUpdateTopicWfmAgentScheduleUpdate" /> class.
        /// </summary>
        /// <param name="UpdateType">UpdateType.</param>
        /// <param name="ShiftStartDates">ShiftStartDates.</param>
        public WfmAgentScheduleUpdateTopicWfmAgentScheduleUpdate(UpdateTypeEnum? UpdateType = null, List<DateTime?> ShiftStartDates = null)
        {
            this.UpdateType = UpdateType;
            this.ShiftStartDates = ShiftStartDates;
            
        }
        




        /// <summary>
        /// Gets or Sets ShiftStartDates
        /// </summary>
        [DataMember(Name="shiftStartDates", EmitDefaultValue=false)]
        public List<DateTime?> ShiftStartDates { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmAgentScheduleUpdateTopicWfmAgentScheduleUpdate {\n");

            sb.Append("  UpdateType: ").Append(UpdateType).Append("\n");
            sb.Append("  ShiftStartDates: ").Append(ShiftStartDates).Append("\n");
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
            return this.Equals(obj as WfmAgentScheduleUpdateTopicWfmAgentScheduleUpdate);
        }

        /// <summary>
        /// Returns true if WfmAgentScheduleUpdateTopicWfmAgentScheduleUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmAgentScheduleUpdateTopicWfmAgentScheduleUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmAgentScheduleUpdateTopicWfmAgentScheduleUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UpdateType == other.UpdateType ||
                    this.UpdateType != null &&
                    this.UpdateType.Equals(other.UpdateType)
                ) &&
                (
                    this.ShiftStartDates == other.ShiftStartDates ||
                    this.ShiftStartDates != null &&
                    this.ShiftStartDates.SequenceEqual(other.ShiftStartDates)
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
                if (this.UpdateType != null)
                    hash = hash * 59 + this.UpdateType.GetHashCode();

                if (this.ShiftStartDates != null)
                    hash = hash * 59 + this.ShiftStartDates.GetHashCode();

                return hash;
            }
        }
    }

}
