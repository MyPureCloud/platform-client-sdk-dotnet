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
    /// AgentSchedulingPreference
    /// </summary>
    [DataContract]
    public partial class AgentSchedulingPreference :  IEquatable<AgentSchedulingPreference>
    {
        /// <summary>
        /// The preference level for this time span
        /// </summary>
        /// <value>The preference level for this time span</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PreferenceLevelEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Stronglyprefer for "StronglyPrefer"
            /// </summary>
            [EnumMember(Value = "StronglyPrefer")]
            Stronglyprefer,
            
            /// <summary>
            /// Enum Prefer for "Prefer"
            /// </summary>
            [EnumMember(Value = "Prefer")]
            Prefer,
            
            /// <summary>
            /// Enum Avoid for "Avoid"
            /// </summary>
            [EnumMember(Value = "Avoid")]
            Avoid,
            
            /// <summary>
            /// Enum Stronglyavoid for "StronglyAvoid"
            /// </summary>
            [EnumMember(Value = "StronglyAvoid")]
            Stronglyavoid
        }
        /// <summary>
        /// The preference level for this time span
        /// </summary>
        /// <value>The preference level for this time span</value>
        [DataMember(Name="preferenceLevel", EmitDefaultValue=false)]
        public PreferenceLevelEnum? PreferenceLevel { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSchedulingPreference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentSchedulingPreference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSchedulingPreference" /> class.
        /// </summary>
        /// <param name="TimeSpan">Exact date, time and length of the scheduling preference time span (required).</param>
        /// <param name="PreferenceLevel">The preference level for this time span (required).</param>
        public AgentSchedulingPreference(WfmTimeSpan TimeSpan = null, PreferenceLevelEnum? PreferenceLevel = null)
        {
            this.TimeSpan = TimeSpan;
            this.PreferenceLevel = PreferenceLevel;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the scheduling preference
        /// </summary>
        /// <value>The globally unique identifier for the scheduling preference</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Exact date, time and length of the scheduling preference time span
        /// </summary>
        /// <value>Exact date, time and length of the scheduling preference time span</value>
        [DataMember(Name="timeSpan", EmitDefaultValue=false)]
        public WfmTimeSpan TimeSpan { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentSchedulingPreference {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TimeSpan: ").Append(TimeSpan).Append("\n");
            sb.Append("  PreferenceLevel: ").Append(PreferenceLevel).Append("\n");
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
            return this.Equals(obj as AgentSchedulingPreference);
        }

        /// <summary>
        /// Returns true if AgentSchedulingPreference instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentSchedulingPreference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentSchedulingPreference other)
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
                    this.TimeSpan == other.TimeSpan ||
                    this.TimeSpan != null &&
                    this.TimeSpan.Equals(other.TimeSpan)
                ) &&
                (
                    this.PreferenceLevel == other.PreferenceLevel ||
                    this.PreferenceLevel != null &&
                    this.PreferenceLevel.Equals(other.PreferenceLevel)
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

                if (this.TimeSpan != null)
                    hash = hash * 59 + this.TimeSpan.GetHashCode();

                if (this.PreferenceLevel != null)
                    hash = hash * 59 + this.PreferenceLevel.GetHashCode();

                return hash;
            }
        }
    }

}
