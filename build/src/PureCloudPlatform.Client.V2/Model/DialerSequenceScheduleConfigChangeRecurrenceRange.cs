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
    /// the schedule range
    /// </summary>
    [DataContract]
    public partial class DialerSequenceScheduleConfigChangeRecurrenceRange :  IEquatable<DialerSequenceScheduleConfigChangeRecurrenceRange>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
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
            /// Enum Noend for "NoEnd"
            /// </summary>
            [EnumMember(Value = "NoEnd")]
            Noend,
            
            /// <summary>
            /// Enum Numbered for "Numbered"
            /// </summary>
            [EnumMember(Value = "Numbered")]
            Numbered,
            
            /// <summary>
            /// Enum Enddate for "EndDate"
            /// </summary>
            [EnumMember(Value = "EndDate")]
            Enddate
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerSequenceScheduleConfigChangeRecurrenceRange" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="End">the range end date.</param>
        /// <param name="NumberOfOccurrences">the number of occurrences to happen before ending.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public DialerSequenceScheduleConfigChangeRecurrenceRange(TypeEnum? Type = null, string End = null, int? NumberOfOccurrences = null, Dictionary<string, Object> AdditionalProperties = null)
        {
            this.Type = Type;
            this.End = End;
            this.NumberOfOccurrences = NumberOfOccurrences;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        




        /// <summary>
        /// the range end date
        /// </summary>
        /// <value>the range end date</value>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public string End { get; set; }



        /// <summary>
        /// the number of occurrences to happen before ending
        /// </summary>
        /// <value>the number of occurrences to happen before ending</value>
        [DataMember(Name="numberOfOccurrences", EmitDefaultValue=false)]
        public int? NumberOfOccurrences { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerSequenceScheduleConfigChangeRecurrenceRange {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  NumberOfOccurrences: ").Append(NumberOfOccurrences).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as DialerSequenceScheduleConfigChangeRecurrenceRange);
        }

        /// <summary>
        /// Returns true if DialerSequenceScheduleConfigChangeRecurrenceRange instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerSequenceScheduleConfigChangeRecurrenceRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerSequenceScheduleConfigChangeRecurrenceRange other)
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
                    this.End == other.End ||
                    this.End != null &&
                    this.End.Equals(other.End)
                ) &&
                (
                    this.NumberOfOccurrences == other.NumberOfOccurrences ||
                    this.NumberOfOccurrences != null &&
                    this.NumberOfOccurrences.Equals(other.NumberOfOccurrences)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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

                if (this.End != null)
                    hash = hash * 59 + this.End.GetHashCode();

                if (this.NumberOfOccurrences != null)
                    hash = hash * 59 + this.NumberOfOccurrences.GetHashCode();

                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

                return hash;
            }
        }
    }

}
