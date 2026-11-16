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
    /// CapacityPlanForecastDistribution
    /// </summary>
    [DataContract]
    public partial class CapacityPlanForecastDistribution :  IEquatable<CapacityPlanForecastDistribution>
    {
        /// <summary>
        /// The day of the week to which this distribution applies
        /// </summary>
        /// <value>The day of the week to which this distribution applies</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DayOfWeekEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sunday for "Sunday"
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday,
            
            /// <summary>
            /// Enum Monday for "Monday"
            /// </summary>
            [EnumMember(Value = "Monday")]
            Monday,
            
            /// <summary>
            /// Enum Tuesday for "Tuesday"
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            Tuesday,
            
            /// <summary>
            /// Enum Wednesday for "Wednesday"
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            Wednesday,
            
            /// <summary>
            /// Enum Thursday for "Thursday"
            /// </summary>
            [EnumMember(Value = "Thursday")]
            Thursday,
            
            /// <summary>
            /// Enum Friday for "Friday"
            /// </summary>
            [EnumMember(Value = "Friday")]
            Friday,
            
            /// <summary>
            /// Enum Saturday for "Saturday"
            /// </summary>
            [EnumMember(Value = "Saturday")]
            Saturday
        }
        /// <summary>
        /// The day of the week to which this distribution applies
        /// </summary>
        /// <value>The day of the week to which this distribution applies</value>
        [DataMember(Name="dayOfWeek", EmitDefaultValue=false)]
        public DayOfWeekEnum? DayOfWeek { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastDistribution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanForecastDistribution() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastDistribution" /> class.
        /// </summary>
        /// <param name="DayOfWeek">The day of the week to which this distribution applies (required).</param>
        /// <param name="DistributionPerInterval">Hourly distribution values for the day, ordered from hour 0 to hour 23 (required).</param>
        public CapacityPlanForecastDistribution(DayOfWeekEnum? DayOfWeek = null, List<double?> DistributionPerInterval = null)
        {
            this.DayOfWeek = DayOfWeek;
            this.DistributionPerInterval = DistributionPerInterval;
            
        }
        




        /// <summary>
        /// Hourly distribution values for the day, ordered from hour 0 to hour 23
        /// </summary>
        /// <value>Hourly distribution values for the day, ordered from hour 0 to hour 23</value>
        [DataMember(Name="distributionPerInterval", EmitDefaultValue=false)]
        public List<double?> DistributionPerInterval { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanForecastDistribution {\n");

            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  DistributionPerInterval: ").Append(DistributionPerInterval).Append("\n");
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
            return this.Equals(obj as CapacityPlanForecastDistribution);
        }

        /// <summary>
        /// Returns true if CapacityPlanForecastDistribution instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanForecastDistribution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanForecastDistribution other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DayOfWeek == other.DayOfWeek ||
                    this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(other.DayOfWeek)
                ) &&
                (
                    this.DistributionPerInterval == other.DistributionPerInterval ||
                    this.DistributionPerInterval != null &&
                    this.DistributionPerInterval.SequenceEqual(other.DistributionPerInterval)
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
                if (this.DayOfWeek != null)
                    hash = hash * 59 + this.DayOfWeek.GetHashCode();

                if (this.DistributionPerInterval != null)
                    hash = hash * 59 + this.DistributionPerInterval.GetHashCode();

                return hash;
            }
        }
    }

}
