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
    /// DayOfWeekMinimums
    /// </summary>
    [DataContract]
    public partial class DayOfWeekMinimums :  IEquatable<DayOfWeekMinimums>
    {
        /// <summary>
        /// Gets or Sets DaysOfWeek
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DaysOfWeekEnum
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
        /// Initializes a new instance of the <see cref="DayOfWeekMinimums" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DayOfWeekMinimums() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DayOfWeekMinimums" /> class.
        /// </summary>
        /// <param name="MinimumValue">The minimum staff value to be applied to this planning group (required).</param>
        /// <param name="DaysOfWeek">Days of week this minimum staff value applies to (required).</param>
        public DayOfWeekMinimums(double? MinimumValue = null, List<DaysOfWeekEnum> DaysOfWeek = null)
        {
            this.MinimumValue = MinimumValue;
            this.DaysOfWeek = DaysOfWeek;
            
        }
        


        /// <summary>
        /// The minimum staff value to be applied to this planning group
        /// </summary>
        /// <value>The minimum staff value to be applied to this planning group</value>
        [DataMember(Name="minimumValue", EmitDefaultValue=false)]
        public double? MinimumValue { get; set; }



        /// <summary>
        /// Days of week this minimum staff value applies to
        /// </summary>
        /// <value>Days of week this minimum staff value applies to</value>
        [DataMember(Name="daysOfWeek", EmitDefaultValue=false)]
        public List<DaysOfWeekEnum> DaysOfWeek { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DayOfWeekMinimums {\n");

            sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
            sb.Append("  DaysOfWeek: ").Append(DaysOfWeek).Append("\n");
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
            return this.Equals(obj as DayOfWeekMinimums);
        }

        /// <summary>
        /// Returns true if DayOfWeekMinimums instances are equal
        /// </summary>
        /// <param name="other">Instance of DayOfWeekMinimums to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DayOfWeekMinimums other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MinimumValue == other.MinimumValue ||
                    this.MinimumValue != null &&
                    this.MinimumValue.Equals(other.MinimumValue)
                ) &&
                (
                    this.DaysOfWeek == other.DaysOfWeek ||
                    this.DaysOfWeek != null &&
                    this.DaysOfWeek.SequenceEqual(other.DaysOfWeek)
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
                if (this.MinimumValue != null)
                    hash = hash * 59 + this.MinimumValue.GetHashCode();

                if (this.DaysOfWeek != null)
                    hash = hash * 59 + this.DaysOfWeek.GetHashCode();

                return hash;
            }
        }
    }

}
