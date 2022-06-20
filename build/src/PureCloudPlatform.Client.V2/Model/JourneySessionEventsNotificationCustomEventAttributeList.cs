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
    /// JourneySessionEventsNotificationCustomEventAttributeList
    /// </summary>
    [DataContract]
    public partial class JourneySessionEventsNotificationCustomEventAttributeList :  IEquatable<JourneySessionEventsNotificationCustomEventAttributeList>
    {
        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DataTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum String for "STRING"
            /// </summary>
            [EnumMember(Value = "STRING")]
            String,
            
            /// <summary>
            /// Enum Boolean for "BOOLEAN"
            /// </summary>
            [EnumMember(Value = "BOOLEAN")]
            Boolean,
            
            /// <summary>
            /// Enum Number for "NUMBER"
            /// </summary>
            [EnumMember(Value = "NUMBER")]
            Number
        }
        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public DataTypeEnum? DataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneySessionEventsNotificationCustomEventAttributeList" /> class.
        /// </summary>
        /// <param name="Values">Values.</param>
        /// <param name="DataType">DataType.</param>
        public JourneySessionEventsNotificationCustomEventAttributeList(List<string> Values = null, DataTypeEnum? DataType = null)
        {
            this.Values = Values;
            this.DataType = DataType;
            
        }
        


        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneySessionEventsNotificationCustomEventAttributeList {\n");

            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
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
            return this.Equals(obj as JourneySessionEventsNotificationCustomEventAttributeList);
        }

        /// <summary>
        /// Returns true if JourneySessionEventsNotificationCustomEventAttributeList instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneySessionEventsNotificationCustomEventAttributeList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneySessionEventsNotificationCustomEventAttributeList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) &&
                (
                    this.DataType == other.DataType ||
                    this.DataType != null &&
                    this.DataType.Equals(other.DataType)
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
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                if (this.DataType != null)
                    hash = hash * 59 + this.DataType.GetHashCode();

                return hash;
            }
        }
    }

}
