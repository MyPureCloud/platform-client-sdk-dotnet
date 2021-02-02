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
    /// WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer
    /// </summary>
    [DataContract]
    public partial class WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer :  IEquatable<WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer>
    {
        
        
        /// <summary>
        /// Gets or Sets DayOfWeek
        /// </summary>
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
            Saturday,
            
            /// <summary>
            /// Enum Eighthday for "EighthDay"
            /// </summary>
            [EnumMember(Value = "EighthDay")]
            Eighthday
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DayOfWeek
        /// </summary>
        [DataMember(Name="dayOfWeek", EmitDefaultValue=false)]
        public DayOfWeekEnum? DayOfWeek { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer" /> class.
        /// </summary>
        /// <param name="DayOfWeek">DayOfWeek.</param>
        /// <param name="Weight">Weight.</param>
        /// <param name="Date">Date.</param>
        /// <param name="FileName">FileName.</param>
        /// <param name="DataKey">DataKey.</param>
        public WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer(DayOfWeekEnum? DayOfWeek = null, int? Weight = null, string Date = null, string FileName = null, string DataKey = null)
        {
            this.DayOfWeek = DayOfWeek;
            this.Weight = Weight;
            this.Date = Date;
            this.FileName = FileName;
            this.DataKey = DataKey;
            
        }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DataKey
        /// </summary>
        [DataMember(Name="dataKey", EmitDefaultValue=false)]
        public string DataKey { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer {\n");
            
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  DataKey: ").Append(DataKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer);
        }

        /// <summary>
        /// Returns true if WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer other)
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
                    this.Weight == other.Weight ||
                    this.Weight != null &&
                    this.Weight.Equals(other.Weight)
                ) &&
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) &&
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) &&
                (
                    this.DataKey == other.DataKey ||
                    this.DataKey != null &&
                    this.DataKey.Equals(other.DataKey)
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
                
                if (this.Weight != null)
                    hash = hash * 59 + this.Weight.GetHashCode();
                
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                
                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();
                
                if (this.DataKey != null)
                    hash = hash * 59 + this.DataKey.GetHashCode();
                
                return hash;
            }
        }
    }

}
