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
    /// SetRecordingState
    /// </summary>
    [DataContract]
    public partial class SetRecordingState :  IEquatable<SetRecordingState>
    {
        /// <summary>
        /// The value of the recordingState to set.
        /// </summary>
        /// <value>The value of the recordingState to set.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RecordingStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "ACTIVE"
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            /// <summary>
            /// Enum Paused for "PAUSED"
            /// </summary>
            [EnumMember(Value = "PAUSED")]
            Paused,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None
        }
        /// <summary>
        /// The value of the recordingState to set.
        /// </summary>
        /// <value>The value of the recordingState to set.</value>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public RecordingStateEnum? RecordingState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetRecordingState" /> class.
        /// </summary>
        /// <param name="RecordingState">The value of the recordingState to set..</param>
        public SetRecordingState(RecordingStateEnum? RecordingState = null)
        {
            this.RecordingState = RecordingState;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetRecordingState {\n");

            sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
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
            return this.Equals(obj as SetRecordingState);
        }

        /// <summary>
        /// Returns true if SetRecordingState instances are equal
        /// </summary>
        /// <param name="other">Instance of SetRecordingState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetRecordingState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RecordingState == other.RecordingState ||
                    this.RecordingState != null &&
                    this.RecordingState.Equals(other.RecordingState)
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
                if (this.RecordingState != null)
                    hash = hash * 59 + this.RecordingState.GetHashCode();

                return hash;
            }
        }
    }

}
