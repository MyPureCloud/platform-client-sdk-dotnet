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
    /// InsightsDetails
    /// </summary>
    [DataContract]
    public partial class InsightsDetails :  IEquatable<InsightsDetails>
    {
        /// <summary>
        /// Granularity
        /// </summary>
        /// <value>Granularity</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GranularityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Daily for "Daily"
            /// </summary>
            [EnumMember(Value = "Daily")]
            Daily,
            
            /// <summary>
            /// Enum Weekly for "Weekly"
            /// </summary>
            [EnumMember(Value = "Weekly")]
            Weekly,
            
            /// <summary>
            /// Enum Monthly for "Monthly"
            /// </summary>
            [EnumMember(Value = "Monthly")]
            Monthly
        }
        /// <summary>
        /// Granularity
        /// </summary>
        /// <value>Granularity</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public GranularityEnum? Granularity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsDetails" /> class.
        /// </summary>
        /// <param name="PerformanceProfile">The performance profile.</param>
        /// <param name="Division">The division.</param>
        /// <param name="Granularity">Granularity.</param>
        /// <param name="ComparativePeriod">The comparative period work day date range.</param>
        /// <param name="PrimaryPeriod">The primary period work day date range.</param>
        /// <param name="User">The query user.</param>
        /// <param name="MetricData">The list of insights data for each metric of the user.</param>
        /// <param name="OverallData">Overall insights data of the user.</param>
        public InsightsDetails(AddressableEntityRef PerformanceProfile = null, DivisionReference Division = null, GranularityEnum? Granularity = null, WorkdayPeriod ComparativePeriod = null, WorkdayPeriod PrimaryPeriod = null, UserReference User = null, List<InsightsDetailsMetricItem> MetricData = null, InsightsDetailsOverallItem OverallData = null)
        {
            this.PerformanceProfile = PerformanceProfile;
            this.Division = Division;
            this.Granularity = Granularity;
            this.ComparativePeriod = ComparativePeriod;
            this.PrimaryPeriod = PrimaryPeriod;
            this.User = User;
            this.MetricData = MetricData;
            this.OverallData = OverallData;
            
        }
        


        /// <summary>
        /// The performance profile
        /// </summary>
        /// <value>The performance profile</value>
        [DataMember(Name="performanceProfile", EmitDefaultValue=false)]
        public AddressableEntityRef PerformanceProfile { get; set; }



        /// <summary>
        /// The division
        /// </summary>
        /// <value>The division</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public DivisionReference Division { get; set; }





        /// <summary>
        /// The comparative period work day date range
        /// </summary>
        /// <value>The comparative period work day date range</value>
        [DataMember(Name="comparativePeriod", EmitDefaultValue=false)]
        public WorkdayPeriod ComparativePeriod { get; set; }



        /// <summary>
        /// The primary period work day date range
        /// </summary>
        /// <value>The primary period work day date range</value>
        [DataMember(Name="primaryPeriod", EmitDefaultValue=false)]
        public WorkdayPeriod PrimaryPeriod { get; set; }



        /// <summary>
        /// The query user
        /// </summary>
        /// <value>The query user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// The list of insights data for each metric of the user
        /// </summary>
        /// <value>The list of insights data for each metric of the user</value>
        [DataMember(Name="metricData", EmitDefaultValue=false)]
        public List<InsightsDetailsMetricItem> MetricData { get; set; }



        /// <summary>
        /// Overall insights data of the user
        /// </summary>
        /// <value>Overall insights data of the user</value>
        [DataMember(Name="overallData", EmitDefaultValue=false)]
        public InsightsDetailsOverallItem OverallData { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsightsDetails {\n");

            sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  ComparativePeriod: ").Append(ComparativePeriod).Append("\n");
            sb.Append("  PrimaryPeriod: ").Append(PrimaryPeriod).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  MetricData: ").Append(MetricData).Append("\n");
            sb.Append("  OverallData: ").Append(OverallData).Append("\n");
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
            return this.Equals(obj as InsightsDetails);
        }

        /// <summary>
        /// Returns true if InsightsDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of InsightsDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PerformanceProfile == other.PerformanceProfile ||
                    this.PerformanceProfile != null &&
                    this.PerformanceProfile.Equals(other.PerformanceProfile)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.ComparativePeriod == other.ComparativePeriod ||
                    this.ComparativePeriod != null &&
                    this.ComparativePeriod.Equals(other.ComparativePeriod)
                ) &&
                (
                    this.PrimaryPeriod == other.PrimaryPeriod ||
                    this.PrimaryPeriod != null &&
                    this.PrimaryPeriod.Equals(other.PrimaryPeriod)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.MetricData == other.MetricData ||
                    this.MetricData != null &&
                    this.MetricData.SequenceEqual(other.MetricData)
                ) &&
                (
                    this.OverallData == other.OverallData ||
                    this.OverallData != null &&
                    this.OverallData.Equals(other.OverallData)
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
                if (this.PerformanceProfile != null)
                    hash = hash * 59 + this.PerformanceProfile.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.ComparativePeriod != null)
                    hash = hash * 59 + this.ComparativePeriod.GetHashCode();

                if (this.PrimaryPeriod != null)
                    hash = hash * 59 + this.PrimaryPeriod.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.MetricData != null)
                    hash = hash * 59 + this.MetricData.GetHashCode();

                if (this.OverallData != null)
                    hash = hash * 59 + this.OverallData.GetHashCode();

                return hash;
            }
        }
    }

}
