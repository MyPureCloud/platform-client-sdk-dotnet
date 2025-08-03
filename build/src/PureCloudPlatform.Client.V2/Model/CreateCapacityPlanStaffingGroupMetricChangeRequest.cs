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
    /// CreateCapacityPlanStaffingGroupMetricChangeRequest
    /// </summary>
    [DataContract]
    public partial class CreateCapacityPlanStaffingGroupMetricChangeRequest :  IEquatable<CreateCapacityPlanStaffingGroupMetricChangeRequest>
    {
        /// <summary>
        /// The metric which is going to be modified for the selected staffing groups
        /// </summary>
        /// <value>The metric which is going to be modified for the selected staffing groups</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Startingweeklyfulltimeequivalentcount for "StartingWeeklyFullTimeEquivalentCount"
            /// </summary>
            [EnumMember(Value = "StartingWeeklyFullTimeEquivalentCount")]
            Startingweeklyfulltimeequivalentcount,
            
            /// <summary>
            /// Enum Newhiresfulltimeequivalentcount for "NewHiresFullTimeEquivalentCount"
            /// </summary>
            [EnumMember(Value = "NewHiresFullTimeEquivalentCount")]
            Newhiresfulltimeequivalentcount,
            
            /// <summary>
            /// Enum Attritionpercentage for "AttritionPercentage"
            /// </summary>
            [EnumMember(Value = "AttritionPercentage")]
            Attritionpercentage,
            
            /// <summary>
            /// Enum Shrinkagepercentage for "ShrinkagePercentage"
            /// </summary>
            [EnumMember(Value = "ShrinkagePercentage")]
            Shrinkagepercentage
        }
        /// <summary>
        /// The metric which is going to be modified for the selected staffing groups
        /// </summary>
        /// <value>The metric which is going to be modified for the selected staffing groups</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCapacityPlanStaffingGroupMetricChangeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCapacityPlanStaffingGroupMetricChangeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCapacityPlanStaffingGroupMetricChangeRequest" /> class.
        /// </summary>
        /// <param name="NumberOfWeeks">The number of weeks to which the metric change applies (required).</param>
        /// <param name="WeekStartNumber">The start number of the week (starting from 1) to which the metric change applies, related to numberOfWeeks (required).</param>
        /// <param name="Value">The value of the metric (required).</param>
        /// <param name="Metric">The metric which is going to be modified for the selected staffing groups (required).</param>
        /// <param name="Notes">Notes about the staffing groups metric changes.</param>
        /// <param name="StaffingGroupIds">The IDs of the staffing groups affected by the metric change (required).</param>
        /// <param name="Version">The version of the capacity plan (required).</param>
        public CreateCapacityPlanStaffingGroupMetricChangeRequest(int? NumberOfWeeks = null, int? WeekStartNumber = null, double? Value = null, MetricEnum? Metric = null, string Notes = null, List<string> StaffingGroupIds = null, int? Version = null)
        {
            this.NumberOfWeeks = NumberOfWeeks;
            this.WeekStartNumber = WeekStartNumber;
            this.Value = Value;
            this.Metric = Metric;
            this.Notes = Notes;
            this.StaffingGroupIds = StaffingGroupIds;
            this.Version = Version;
            
        }
        


        /// <summary>
        /// The number of weeks to which the metric change applies
        /// </summary>
        /// <value>The number of weeks to which the metric change applies</value>
        [DataMember(Name="numberOfWeeks", EmitDefaultValue=false)]
        public int? NumberOfWeeks { get; set; }



        /// <summary>
        /// The start number of the week (starting from 1) to which the metric change applies, related to numberOfWeeks
        /// </summary>
        /// <value>The start number of the week (starting from 1) to which the metric change applies, related to numberOfWeeks</value>
        [DataMember(Name="weekStartNumber", EmitDefaultValue=false)]
        public int? WeekStartNumber { get; set; }



        /// <summary>
        /// The value of the metric
        /// </summary>
        /// <value>The value of the metric</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }





        /// <summary>
        /// Notes about the staffing groups metric changes
        /// </summary>
        /// <value>Notes about the staffing groups metric changes</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }



        /// <summary>
        /// The IDs of the staffing groups affected by the metric change
        /// </summary>
        /// <value>The IDs of the staffing groups affected by the metric change</value>
        [DataMember(Name="staffingGroupIds", EmitDefaultValue=false)]
        public List<string> StaffingGroupIds { get; set; }



        /// <summary>
        /// The version of the capacity plan
        /// </summary>
        /// <value>The version of the capacity plan</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCapacityPlanStaffingGroupMetricChangeRequest {\n");

            sb.Append("  NumberOfWeeks: ").Append(NumberOfWeeks).Append("\n");
            sb.Append("  WeekStartNumber: ").Append(WeekStartNumber).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  StaffingGroupIds: ").Append(StaffingGroupIds).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as CreateCapacityPlanStaffingGroupMetricChangeRequest);
        }

        /// <summary>
        /// Returns true if CreateCapacityPlanStaffingGroupMetricChangeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCapacityPlanStaffingGroupMetricChangeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCapacityPlanStaffingGroupMetricChangeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.NumberOfWeeks == other.NumberOfWeeks ||
                    this.NumberOfWeeks != null &&
                    this.NumberOfWeeks.Equals(other.NumberOfWeeks)
                ) &&
                (
                    this.WeekStartNumber == other.WeekStartNumber ||
                    this.WeekStartNumber != null &&
                    this.WeekStartNumber.Equals(other.WeekStartNumber)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.StaffingGroupIds == other.StaffingGroupIds ||
                    this.StaffingGroupIds != null &&
                    this.StaffingGroupIds.SequenceEqual(other.StaffingGroupIds)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.NumberOfWeeks != null)
                    hash = hash * 59 + this.NumberOfWeeks.GetHashCode();

                if (this.WeekStartNumber != null)
                    hash = hash * 59 + this.WeekStartNumber.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();

                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();

                if (this.StaffingGroupIds != null)
                    hash = hash * 59 + this.StaffingGroupIds.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                return hash;
            }
        }
    }

}
