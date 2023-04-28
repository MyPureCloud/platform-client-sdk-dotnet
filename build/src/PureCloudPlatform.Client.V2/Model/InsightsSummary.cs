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
    /// InsightsSummary
    /// </summary>
    [DataContract]
    public partial class InsightsSummary :  IEquatable<InsightsSummary>
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
        /// Initializes a new instance of the <see cref="InsightsSummary" /> class.
        /// </summary>
        /// <param name="Entities">Entities.</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="Total">Total.</param>
        /// <param name="PerformanceProfile">The performance profile.</param>
        /// <param name="Division">The division.</param>
        /// <param name="Granularity">Granularity.</param>
        /// <param name="ComparativePeriod">The comparative period work day date range.</param>
        /// <param name="PrimaryPeriod">The primary period work day date range.</param>
        /// <param name="PageCount">PageCount.</param>
        public InsightsSummary(List<InsightsSummaryUserItem> Entities = null, int? PageSize = null, int? PageNumber = null, long? Total = null, AddressableEntityRef PerformanceProfile = null, DivisionReference Division = null, GranularityEnum? Granularity = null, WorkdayPeriod ComparativePeriod = null, WorkdayPeriod PrimaryPeriod = null, int? PageCount = null)
        {
            this.Entities = Entities;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.Total = Total;
            this.PerformanceProfile = PerformanceProfile;
            this.Division = Division;
            this.Granularity = Granularity;
            this.ComparativePeriod = ComparativePeriod;
            this.PrimaryPeriod = PrimaryPeriod;
            this.PageCount = PageCount;
            
        }
        


        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<InsightsSummaryUserItem> Entities { get; set; }



        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }



        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }



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
        /// Gets or Sets PageCount
        /// </summary>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsightsSummary {\n");

            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  ComparativePeriod: ").Append(ComparativePeriod).Append("\n");
            sb.Append("  PrimaryPeriod: ").Append(PrimaryPeriod).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
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
            return this.Equals(obj as InsightsSummary);
        }

        /// <summary>
        /// Returns true if InsightsSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of InsightsSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) &&
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) &&
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
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
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
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();

                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();

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

                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();

                return hash;
            }
        }
    }

}
