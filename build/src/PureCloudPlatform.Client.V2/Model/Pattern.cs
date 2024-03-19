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
    /// Pattern
    /// </summary>
    [DataContract]
    public partial class Pattern :  IEquatable<Pattern>
    {
        /// <summary>
        /// Pattern type (Daily/Weekly)
        /// </summary>
        /// <value>Pattern type (Daily/Weekly)</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
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
            Weekly
        }
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
        /// Pattern type (Daily/Weekly)
        /// </summary>
        /// <value>Pattern type (Daily/Weekly)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pattern" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Pattern() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pattern" /> class.
        /// </summary>
        /// <param name="Type">Pattern type (Daily/Weekly) (required).</param>
        /// <param name="Interval">The interval of days between the occurrences for Daily pattern type, and weeks between the occurrences for Weekly (required).</param>
        /// <param name="DaysOfWeek">The day(s) of week the occurrence should be repeated. Required to set for Weekly pattern type. E.g. [\"Monday\", \"Wednesday\"].</param>
        public Pattern(TypeEnum? Type = null, int? Interval = null, List<DaysOfWeekEnum> DaysOfWeek = null)
        {
            this.Type = Type;
            this.Interval = Interval;
            this.DaysOfWeek = DaysOfWeek;
            
        }
        




        /// <summary>
        /// The interval of days between the occurrences for Daily pattern type, and weeks between the occurrences for Weekly
        /// </summary>
        /// <value>The interval of days between the occurrences for Daily pattern type, and weeks between the occurrences for Weekly</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public int? Interval { get; set; }



        /// <summary>
        /// The day(s) of week the occurrence should be repeated. Required to set for Weekly pattern type. E.g. [\"Monday\", \"Wednesday\"]
        /// </summary>
        /// <value>The day(s) of week the occurrence should be repeated. Required to set for Weekly pattern type. E.g. [\"Monday\", \"Wednesday\"]</value>
        [DataMember(Name="daysOfWeek", EmitDefaultValue=false)]
        public List<DaysOfWeekEnum> DaysOfWeek { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pattern {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
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
            return this.Equals(obj as Pattern);
        }

        /// <summary>
        /// Returns true if Pattern instances are equal
        /// </summary>
        /// <param name="other">Instance of Pattern to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pattern other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                if (this.DaysOfWeek != null)
                    hash = hash * 59 + this.DaysOfWeek.GetHashCode();

                return hash;
            }
        }
    }

}
