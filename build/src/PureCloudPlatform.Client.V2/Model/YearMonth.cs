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
    /// YearMonth
    /// </summary>
    [DataContract]
    public partial class YearMonth :  IEquatable<YearMonth>
    {
        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MonthEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum January for "JANUARY"
            /// </summary>
            [EnumMember(Value = "JANUARY")]
            January,
            
            /// <summary>
            /// Enum February for "FEBRUARY"
            /// </summary>
            [EnumMember(Value = "FEBRUARY")]
            February,
            
            /// <summary>
            /// Enum March for "MARCH"
            /// </summary>
            [EnumMember(Value = "MARCH")]
            March,
            
            /// <summary>
            /// Enum April for "APRIL"
            /// </summary>
            [EnumMember(Value = "APRIL")]
            April,
            
            /// <summary>
            /// Enum May for "MAY"
            /// </summary>
            [EnumMember(Value = "MAY")]
            May,
            
            /// <summary>
            /// Enum June for "JUNE"
            /// </summary>
            [EnumMember(Value = "JUNE")]
            June,
            
            /// <summary>
            /// Enum July for "JULY"
            /// </summary>
            [EnumMember(Value = "JULY")]
            July,
            
            /// <summary>
            /// Enum August for "AUGUST"
            /// </summary>
            [EnumMember(Value = "AUGUST")]
            August,
            
            /// <summary>
            /// Enum September for "SEPTEMBER"
            /// </summary>
            [EnumMember(Value = "SEPTEMBER")]
            September,
            
            /// <summary>
            /// Enum October for "OCTOBER"
            /// </summary>
            [EnumMember(Value = "OCTOBER")]
            October,
            
            /// <summary>
            /// Enum November for "NOVEMBER"
            /// </summary>
            [EnumMember(Value = "NOVEMBER")]
            November,
            
            /// <summary>
            /// Enum December for "DECEMBER"
            /// </summary>
            [EnumMember(Value = "DECEMBER")]
            December
        }
        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public MonthEnum? Month { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="YearMonth" /> class.
        /// </summary>
        /// <param name="Year">Year.</param>
        /// <param name="Month">Month.</param>
        /// <param name="MonthValue">MonthValue.</param>
        /// <param name="LeapYear">LeapYear.</param>
        public YearMonth(int? Year = null, MonthEnum? Month = null, int? MonthValue = null, bool? LeapYear = null)
        {
            this.Year = Year;
            this.Month = Month;
            this.MonthValue = MonthValue;
            this.LeapYear = LeapYear;
            
        }
        


        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }





        /// <summary>
        /// Gets or Sets MonthValue
        /// </summary>
        [DataMember(Name="monthValue", EmitDefaultValue=false)]
        public int? MonthValue { get; set; }



        /// <summary>
        /// Gets or Sets LeapYear
        /// </summary>
        [DataMember(Name="leapYear", EmitDefaultValue=false)]
        public bool? LeapYear { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class YearMonth {\n");

            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  MonthValue: ").Append(MonthValue).Append("\n");
            sb.Append("  LeapYear: ").Append(LeapYear).Append("\n");
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
            return this.Equals(obj as YearMonth);
        }

        /// <summary>
        /// Returns true if YearMonth instances are equal
        /// </summary>
        /// <param name="other">Instance of YearMonth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(YearMonth other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Year == other.Year ||
                    this.Year != null &&
                    this.Year.Equals(other.Year)
                ) &&
                (
                    this.Month == other.Month ||
                    this.Month != null &&
                    this.Month.Equals(other.Month)
                ) &&
                (
                    this.MonthValue == other.MonthValue ||
                    this.MonthValue != null &&
                    this.MonthValue.Equals(other.MonthValue)
                ) &&
                (
                    this.LeapYear == other.LeapYear ||
                    this.LeapYear != null &&
                    this.LeapYear.Equals(other.LeapYear)
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
                if (this.Year != null)
                    hash = hash * 59 + this.Year.GetHashCode();

                if (this.Month != null)
                    hash = hash * 59 + this.Month.GetHashCode();

                if (this.MonthValue != null)
                    hash = hash * 59 + this.MonthValue.GetHashCode();

                if (this.LeapYear != null)
                    hash = hash * 59 + this.LeapYear.GetHashCode();

                return hash;
            }
        }
    }

}
