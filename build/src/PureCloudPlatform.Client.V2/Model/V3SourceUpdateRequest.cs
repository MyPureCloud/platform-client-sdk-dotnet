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
    /// V3SourceUpdateRequest
    /// </summary>
    [DataContract]
    public partial class V3SourceUpdateRequest :  IEquatable<V3SourceUpdateRequest>
    {
        /// <summary>
        /// The trigger type of the source.
        /// </summary>
        /// <value>The trigger type of the source.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TriggerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Scheduled for "Scheduled"
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual
        }
        /// <summary>
        /// The trigger type of the source.
        /// </summary>
        /// <value>The trigger type of the source.</value>
        [DataMember(Name="triggerType", EmitDefaultValue=false)]
        public TriggerTypeEnum? TriggerType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V3SourceUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceUpdateRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the source. (required).</param>
        /// <param name="TriggerType">The trigger type of the source. (required).</param>
        /// <param name="ScheduleSettings">Settings that determine when the source starts a sync..</param>
        public V3SourceUpdateRequest(string Name = null, TriggerTypeEnum? TriggerType = null, V3SourceScheduleSettings ScheduleSettings = null)
        {
            this.Name = Name;
            this.TriggerType = TriggerType;
            this.ScheduleSettings = ScheduleSettings;
            
        }
        


        /// <summary>
        /// The name of the source.
        /// </summary>
        /// <value>The name of the source.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// Settings that determine when the source starts a sync.
        /// </summary>
        /// <value>Settings that determine when the source starts a sync.</value>
        [DataMember(Name="scheduleSettings", EmitDefaultValue=false)]
        public V3SourceScheduleSettings ScheduleSettings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SourceUpdateRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  ScheduleSettings: ").Append(ScheduleSettings).Append("\n");
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
            return this.Equals(obj as V3SourceUpdateRequest);
        }

        /// <summary>
        /// Returns true if V3SourceUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SourceUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SourceUpdateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.TriggerType == other.TriggerType ||
                    this.TriggerType != null &&
                    this.TriggerType.Equals(other.TriggerType)
                ) &&
                (
                    this.ScheduleSettings == other.ScheduleSettings ||
                    this.ScheduleSettings != null &&
                    this.ScheduleSettings.Equals(other.ScheduleSettings)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.TriggerType != null)
                    hash = hash * 59 + this.TriggerType.GetHashCode();

                if (this.ScheduleSettings != null)
                    hash = hash * 59 + this.ScheduleSettings.GetHashCode();

                return hash;
            }
        }
    }

}
