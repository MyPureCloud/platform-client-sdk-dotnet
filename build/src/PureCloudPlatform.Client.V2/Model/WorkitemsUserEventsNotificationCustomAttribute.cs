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
    /// WorkitemsUserEventsNotificationCustomAttribute
    /// </summary>
    [DataContract]
    public partial class WorkitemsUserEventsNotificationCustomAttribute :  IEquatable<WorkitemsUserEventsNotificationCustomAttribute>
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
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum String for "string"
            /// </summary>
            [EnumMember(Value = "string")]
            String,
            
            /// <summary>
            /// Enum Number for "number"
            /// </summary>
            [EnumMember(Value = "number")]
            Number,
            
            /// <summary>
            /// Enum Boolean for "boolean$"
            /// </summary>
            [EnumMember(Value = "boolean$")]
            Boolean,
            
            /// <summary>
            /// Enum Integer for "integer"
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer
        }
        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public DataTypeEnum? DataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemsUserEventsNotificationCustomAttribute" /> class.
        /// </summary>
        /// <param name="DataType">DataType.</param>
        /// <param name="Value">Value.</param>
        public WorkitemsUserEventsNotificationCustomAttribute(DataTypeEnum? DataType = null, string Value = null)
        {
            this.DataType = DataType;
            this.Value = Value;
            
        }
        




        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemsUserEventsNotificationCustomAttribute {\n");

            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as WorkitemsUserEventsNotificationCustomAttribute);
        }

        /// <summary>
        /// Returns true if WorkitemsUserEventsNotificationCustomAttribute instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemsUserEventsNotificationCustomAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemsUserEventsNotificationCustomAttribute other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DataType == other.DataType ||
                    this.DataType != null &&
                    this.DataType.Equals(other.DataType)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.DataType != null)
                    hash = hash * 59 + this.DataType.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
