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
    /// ChartColumn
    /// </summary>
    [DataContract]
    public partial class ChartColumn :  IEquatable<ChartColumn>
    {
        /// <summary>
        /// Type of column
        /// </summary>
        /// <value>Type of column</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ColumnTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            [EnumMember(Value = "Default")]
            Default,
            
            /// <summary>
            /// Enum Topic for "Topic"
            /// </summary>
            [EnumMember(Value = "Topic")]
            Topic,
            
            /// <summary>
            /// Enum Secondarystatus for "SecondaryStatus"
            /// </summary>
            [EnumMember(Value = "SecondaryStatus")]
            Secondarystatus,
            
            /// <summary>
            /// Enum Customcalculation for "CustomCalculation"
            /// </summary>
            [EnumMember(Value = "CustomCalculation")]
            Customcalculation
        }
        /// <summary>
        /// Type of column
        /// </summary>
        /// <value>Type of column</value>
        [DataMember(Name="columnType", EmitDefaultValue=false)]
        public ColumnTypeEnum? ColumnType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartColumn" /> class.
        /// </summary>
        /// <param name="Id">Column Id.</param>
        /// <param name="ColumnType">Type of column.</param>
        public ChartColumn(string Id = null, ColumnTypeEnum? ColumnType = null)
        {
            this.Id = Id;
            this.ColumnType = ColumnType;
            
        }
        


        /// <summary>
        /// Column Id
        /// </summary>
        /// <value>Column Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartColumn {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ColumnType: ").Append(ColumnType).Append("\n");
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
            return this.Equals(obj as ChartColumn);
        }

        /// <summary>
        /// Returns true if ChartColumn instances are equal
        /// </summary>
        /// <param name="other">Instance of ChartColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChartColumn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.ColumnType == other.ColumnType ||
                    this.ColumnType != null &&
                    this.ColumnType.Equals(other.ColumnType)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.ColumnType != null)
                    hash = hash * 59 + this.ColumnType.GetHashCode();

                return hash;
            }
        }
    }

}
