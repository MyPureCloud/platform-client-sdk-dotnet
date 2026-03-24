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
    /// MinimumStaffingRequest
    /// </summary>
    [DataContract]
    public partial class MinimumStaffingRequest :  IEquatable<MinimumStaffingRequest>
    {
        /// <summary>
        /// The intervals to which the minimum staff values will apply
        /// </summary>
        /// <value>The intervals to which the minimum staff values will apply</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ApplicableIntervalsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Allintervals for "AllIntervals"
            /// </summary>
            [EnumMember(Value = "AllIntervals")]
            Allintervals,
            
            /// <summary>
            /// Enum Volumeonlyintervals for "VolumeOnlyIntervals"
            /// </summary>
            [EnumMember(Value = "VolumeOnlyIntervals")]
            Volumeonlyintervals
        }
        /// <summary>
        /// The intervals to which the minimum staff values will apply
        /// </summary>
        /// <value>The intervals to which the minimum staff values will apply</value>
        [DataMember(Name="applicableIntervals", EmitDefaultValue=false)]
        public ApplicableIntervalsEnum? ApplicableIntervals { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MinimumStaffingRequest" /> class.
        /// </summary>
        /// <param name="Enabled">Whether the setting is turned on or off.</param>
        /// <param name="MinimumValue">Default minimum staff value to be applied to all planning groups.</param>
        /// <param name="PlanningGroupOverrides">List of planning groups with their minimum staff value overrides and the days to which the overrides apply. Setting the enclosed list to empty will clear out all existing overrides.</param>
        /// <param name="ApplicableIntervals">The intervals to which the minimum staff values will apply.</param>
        public MinimumStaffingRequest(bool? Enabled = null, double? MinimumValue = null, ListWrapperPlanningGroupMinimumsRequest PlanningGroupOverrides = null, ApplicableIntervalsEnum? ApplicableIntervals = null)
        {
            this.Enabled = Enabled;
            this.MinimumValue = MinimumValue;
            this.PlanningGroupOverrides = PlanningGroupOverrides;
            this.ApplicableIntervals = ApplicableIntervals;
            
        }
        


        /// <summary>
        /// Whether the setting is turned on or off
        /// </summary>
        /// <value>Whether the setting is turned on or off</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Default minimum staff value to be applied to all planning groups
        /// </summary>
        /// <value>Default minimum staff value to be applied to all planning groups</value>
        [DataMember(Name="minimumValue", EmitDefaultValue=false)]
        public double? MinimumValue { get; set; }



        /// <summary>
        /// List of planning groups with their minimum staff value overrides and the days to which the overrides apply. Setting the enclosed list to empty will clear out all existing overrides
        /// </summary>
        /// <value>List of planning groups with their minimum staff value overrides and the days to which the overrides apply. Setting the enclosed list to empty will clear out all existing overrides</value>
        [DataMember(Name="planningGroupOverrides", EmitDefaultValue=false)]
        public ListWrapperPlanningGroupMinimumsRequest PlanningGroupOverrides { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MinimumStaffingRequest {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
            sb.Append("  PlanningGroupOverrides: ").Append(PlanningGroupOverrides).Append("\n");
            sb.Append("  ApplicableIntervals: ").Append(ApplicableIntervals).Append("\n");
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
            return this.Equals(obj as MinimumStaffingRequest);
        }

        /// <summary>
        /// Returns true if MinimumStaffingRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MinimumStaffingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MinimumStaffingRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.MinimumValue == other.MinimumValue ||
                    this.MinimumValue != null &&
                    this.MinimumValue.Equals(other.MinimumValue)
                ) &&
                (
                    this.PlanningGroupOverrides == other.PlanningGroupOverrides ||
                    this.PlanningGroupOverrides != null &&
                    this.PlanningGroupOverrides.Equals(other.PlanningGroupOverrides)
                ) &&
                (
                    this.ApplicableIntervals == other.ApplicableIntervals ||
                    this.ApplicableIntervals != null &&
                    this.ApplicableIntervals.Equals(other.ApplicableIntervals)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.MinimumValue != null)
                    hash = hash * 59 + this.MinimumValue.GetHashCode();

                if (this.PlanningGroupOverrides != null)
                    hash = hash * 59 + this.PlanningGroupOverrides.GetHashCode();

                if (this.ApplicableIntervals != null)
                    hash = hash * 59 + this.ApplicableIntervals.GetHashCode();

                return hash;
            }
        }
    }

}
