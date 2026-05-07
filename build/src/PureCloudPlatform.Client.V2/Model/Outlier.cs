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
    /// Outlier
    /// </summary>
    [DataContract]
    public partial class Outlier :  IEquatable<Outlier>
    {
        /// <summary>
        /// The type of the anomaly
        /// </summary>
        /// <value>The type of the anomaly</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AnomalyEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Additiveoutlier for "AdditiveOutlier"
            /// </summary>
            [EnumMember(Value = "AdditiveOutlier")]
            Additiveoutlier,
            
            /// <summary>
            /// Enum Innovativeoutlier for "InnovativeOutlier"
            /// </summary>
            [EnumMember(Value = "InnovativeOutlier")]
            Innovativeoutlier,
            
            /// <summary>
            /// Enum Levelshift for "LevelShift"
            /// </summary>
            [EnumMember(Value = "LevelShift")]
            Levelshift,
            
            /// <summary>
            /// Enum Seasonallevelshift for "SeasonalLevelShift"
            /// </summary>
            [EnumMember(Value = "SeasonalLevelShift")]
            Seasonallevelshift,
            
            /// <summary>
            /// Enum Temporarychange for "TemporaryChange"
            /// </summary>
            [EnumMember(Value = "TemporaryChange")]
            Temporarychange
        }
        /// <summary>
        /// The type of the anomaly
        /// </summary>
        /// <value>The type of the anomaly</value>
        [DataMember(Name="anomaly", EmitDefaultValue=false)]
        public AnomalyEnum? Anomaly { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Outlier" /> class.
        /// </summary>
        /// <param name="Timestamp">Timestamp of the outlier. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Anomaly">The type of the anomaly.</param>
        /// <param name="NormalizedValue">Normalized value of the outlier.</param>
        public Outlier(DateTime? Timestamp = null, AnomalyEnum? Anomaly = null, double? NormalizedValue = null)
        {
            this.Timestamp = Timestamp;
            this.Anomaly = Anomaly;
            this.NormalizedValue = NormalizedValue;
            
        }
        


        /// <summary>
        /// Timestamp of the outlier. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp of the outlier. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }





        /// <summary>
        /// Normalized value of the outlier
        /// </summary>
        /// <value>Normalized value of the outlier</value>
        [DataMember(Name="normalizedValue", EmitDefaultValue=false)]
        public double? NormalizedValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Outlier {\n");

            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Anomaly: ").Append(Anomaly).Append("\n");
            sb.Append("  NormalizedValue: ").Append(NormalizedValue).Append("\n");
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
            return this.Equals(obj as Outlier);
        }

        /// <summary>
        /// Returns true if Outlier instances are equal
        /// </summary>
        /// <param name="other">Instance of Outlier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Outlier other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.Anomaly == other.Anomaly ||
                    this.Anomaly != null &&
                    this.Anomaly.Equals(other.Anomaly)
                ) &&
                (
                    this.NormalizedValue == other.NormalizedValue ||
                    this.NormalizedValue != null &&
                    this.NormalizedValue.Equals(other.NormalizedValue)
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
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();

                if (this.Anomaly != null)
                    hash = hash * 59 + this.Anomaly.GetHashCode();

                if (this.NormalizedValue != null)
                    hash = hash * 59 + this.NormalizedValue.GetHashCode();

                return hash;
            }
        }
    }

}
