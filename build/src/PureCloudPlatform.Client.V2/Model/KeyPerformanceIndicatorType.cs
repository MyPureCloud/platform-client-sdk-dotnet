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
    /// KeyPerformanceIndicatorType
    /// </summary>
    [DataContract]
    public partial class KeyPerformanceIndicatorType :  IEquatable<KeyPerformanceIndicatorType>
    {
        /// <summary>
        /// The id the Key Performance Indicator Type.
        /// </summary>
        /// <value>The id the Key Performance Indicator Type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum IdEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Salesconversion for "SalesConversion"
            /// </summary>
            [EnumMember(Value = "SalesConversion")]
            Salesconversion,
            
            /// <summary>
            /// Enum Churn for "Churn"
            /// </summary>
            [EnumMember(Value = "Churn")]
            Churn,
            
            /// <summary>
            /// Enum Retention for "Retention"
            /// </summary>
            [EnumMember(Value = "Retention")]
            Retention,
            
            /// <summary>
            /// Enum Salesvalue for "SalesValue"
            /// </summary>
            [EnumMember(Value = "SalesValue")]
            Salesvalue,
            
            /// <summary>
            /// Enum Handletime for "HandleTime"
            /// </summary>
            [EnumMember(Value = "HandleTime")]
            Handletime,
            
            /// <summary>
            /// Enum Nextcontactavoidance for "NextContactAvoidance"
            /// </summary>
            [EnumMember(Value = "NextContactAvoidance")]
            Nextcontactavoidance
        }
        /// <summary>
        /// Gets or Sets Sources
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SourcesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Wrapupcode for "WrapUpCode"
            /// </summary>
            [EnumMember(Value = "WrapUpCode")]
            Wrapupcode,
            
            /// <summary>
            /// Enum Outcome for "Outcome"
            /// </summary>
            [EnumMember(Value = "Outcome")]
            Outcome,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None
        }
        /// <summary>
        /// The id the Key Performance Indicator Type.
        /// </summary>
        /// <value>The id the Key Performance Indicator Type.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public IdEnum? Id { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyPerformanceIndicatorType" /> class.
        /// </summary>
        public KeyPerformanceIndicatorType()
        {
            
        }
        




        /// <summary>
        /// A set of kpi sources where values for a Key Performance Indicator are retrieved from.
        /// </summary>
        /// <value>A set of kpi sources where values for a Key Performance Indicator are retrieved from.</value>
        [DataMember(Name="sources", EmitDefaultValue=false)]
        public List<SourcesEnum> Sources { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyPerformanceIndicatorType {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
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
            return this.Equals(obj as KeyPerformanceIndicatorType);
        }

        /// <summary>
        /// Returns true if KeyPerformanceIndicatorType instances are equal
        /// </summary>
        /// <param name="other">Instance of KeyPerformanceIndicatorType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyPerformanceIndicatorType other)
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
                    this.Sources == other.Sources ||
                    this.Sources != null &&
                    this.Sources.SequenceEqual(other.Sources)
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

                if (this.Sources != null)
                    hash = hash * 59 + this.Sources.GetHashCode();

                return hash;
            }
        }
    }

}
