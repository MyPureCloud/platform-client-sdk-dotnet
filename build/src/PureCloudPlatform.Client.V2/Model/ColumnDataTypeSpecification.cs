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
    /// ColumnDataTypeSpecification
    /// </summary>
    [DataContract]
    public partial class ColumnDataTypeSpecification :  IEquatable<ColumnDataTypeSpecification>
    {
        /// <summary>
        /// The data type of the column selected for dynamic queueing (TEXT, NUMERIC or TIMESTAMP)
        /// </summary>
        /// <value>The data type of the column selected for dynamic queueing (TEXT, NUMERIC or TIMESTAMP)</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ColumnDataTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Numeric for "NUMERIC"
            /// </summary>
            [EnumMember(Value = "NUMERIC")]
            Numeric,
            
            /// <summary>
            /// Enum Text for "TEXT"
            /// </summary>
            [EnumMember(Value = "TEXT")]
            Text,
            
            /// <summary>
            /// Enum Timestamp for "TIMESTAMP"
            /// </summary>
            [EnumMember(Value = "TIMESTAMP")]
            Timestamp
        }
        /// <summary>
        /// The data type of the column selected for dynamic queueing (TEXT, NUMERIC or TIMESTAMP)
        /// </summary>
        /// <value>The data type of the column selected for dynamic queueing (TEXT, NUMERIC or TIMESTAMP)</value>
        [DataMember(Name="columnDataType", EmitDefaultValue=false)]
        public ColumnDataTypeEnum? ColumnDataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnDataTypeSpecification" /> class.
        /// </summary>
        /// <param name="ColumnName">The column name of a column selected for dynamic queueing.</param>
        /// <param name="ColumnDataType">The data type of the column selected for dynamic queueing (TEXT, NUMERIC or TIMESTAMP).</param>
        /// <param name="Min">The minimum length of the numeric column selected for dynamic queueing.</param>
        /// <param name="Max">The maximum length of the numeric column selected for dynamic queueing.</param>
        /// <param name="MaxLength">The maximum length of the text column selected for dynamic queueing.</param>
        public ColumnDataTypeSpecification(string ColumnName = null, ColumnDataTypeEnum? ColumnDataType = null, int? Min = null, int? Max = null, int? MaxLength = null)
        {
            this.ColumnName = ColumnName;
            this.ColumnDataType = ColumnDataType;
            this.Min = Min;
            this.Max = Max;
            this.MaxLength = MaxLength;
            
        }
        


        /// <summary>
        /// The column name of a column selected for dynamic queueing
        /// </summary>
        /// <value>The column name of a column selected for dynamic queueing</value>
        [DataMember(Name="columnName", EmitDefaultValue=false)]
        public string ColumnName { get; set; }





        /// <summary>
        /// The minimum length of the numeric column selected for dynamic queueing
        /// </summary>
        /// <value>The minimum length of the numeric column selected for dynamic queueing</value>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public int? Min { get; set; }



        /// <summary>
        /// The maximum length of the numeric column selected for dynamic queueing
        /// </summary>
        /// <value>The maximum length of the numeric column selected for dynamic queueing</value>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public int? Max { get; set; }



        /// <summary>
        /// The maximum length of the text column selected for dynamic queueing
        /// </summary>
        /// <value>The maximum length of the text column selected for dynamic queueing</value>
        [DataMember(Name="maxLength", EmitDefaultValue=false)]
        public int? MaxLength { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColumnDataTypeSpecification {\n");

            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  ColumnDataType: ").Append(ColumnDataType).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
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
            return this.Equals(obj as ColumnDataTypeSpecification);
        }

        /// <summary>
        /// Returns true if ColumnDataTypeSpecification instances are equal
        /// </summary>
        /// <param name="other">Instance of ColumnDataTypeSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ColumnDataTypeSpecification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ColumnName == other.ColumnName ||
                    this.ColumnName != null &&
                    this.ColumnName.Equals(other.ColumnName)
                ) &&
                (
                    this.ColumnDataType == other.ColumnDataType ||
                    this.ColumnDataType != null &&
                    this.ColumnDataType.Equals(other.ColumnDataType)
                ) &&
                (
                    this.Min == other.Min ||
                    this.Min != null &&
                    this.Min.Equals(other.Min)
                ) &&
                (
                    this.Max == other.Max ||
                    this.Max != null &&
                    this.Max.Equals(other.Max)
                ) &&
                (
                    this.MaxLength == other.MaxLength ||
                    this.MaxLength != null &&
                    this.MaxLength.Equals(other.MaxLength)
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
                if (this.ColumnName != null)
                    hash = hash * 59 + this.ColumnName.GetHashCode();

                if (this.ColumnDataType != null)
                    hash = hash * 59 + this.ColumnDataType.GetHashCode();

                if (this.Min != null)
                    hash = hash * 59 + this.Min.GetHashCode();

                if (this.Max != null)
                    hash = hash * 59 + this.Max.GetHashCode();

                if (this.MaxLength != null)
                    hash = hash * 59 + this.MaxLength.GetHashCode();

                return hash;
            }
        }
    }

}
