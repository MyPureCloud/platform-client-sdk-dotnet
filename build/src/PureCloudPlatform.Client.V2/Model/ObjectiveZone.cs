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
    /// ObjectiveZone
    /// </summary>
    [DataContract]
    public partial class ObjectiveZone :  IEquatable<ObjectiveZone>
    {
        
        
        
        
        
        /// <summary>
        /// direction type
        /// </summary>
        /// <value>direction type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Up for "Up"
            /// </summary>
            [EnumMember(Value = "Up")]
            Up,
            
            /// <summary>
            /// Enum Down for "Down"
            /// </summary>
            [EnumMember(Value = "Down")]
            Down,
            
            /// <summary>
            /// Enum Flat for "Flat"
            /// </summary>
            [EnumMember(Value = "Flat")]
            Flat
        }
        
        
        
        
        /// <summary>
        /// zone type
        /// </summary>
        /// <value>zone type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ZoneTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Good for "Good"
            /// </summary>
            [EnumMember(Value = "Good")]
            Good,
            
            /// <summary>
            /// Enum Target for "Target"
            /// </summary>
            [EnumMember(Value = "Target")]
            Target,
            
            /// <summary>
            /// Enum Great for "Great"
            /// </summary>
            [EnumMember(Value = "Great")]
            Great,
            
            /// <summary>
            /// Enum Out for "Out"
            /// </summary>
            [EnumMember(Value = "Out")]
            Out
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// direction type
        /// </summary>
        /// <value>direction type</value>
        [DataMember(Name="directionType", EmitDefaultValue=false)]
        public DirectionTypeEnum? DirectionType { get; set; }
        
        
        
        /// <summary>
        /// zone type
        /// </summary>
        /// <value>zone type</value>
        [DataMember(Name="zoneType", EmitDefaultValue=false)]
        public ZoneTypeEnum? ZoneType { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectiveZone" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObjectiveZone() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectiveZone" /> class.
        /// </summary>
        /// <param name="Label">label (required).</param>
        /// <param name="DirectionType">direction type (required).</param>
        /// <param name="ZoneType">zone type (required).</param>
        /// <param name="UpperLimitPoints">upper limit points (required).</param>
        /// <param name="LowerLimitPoints">lower limit points (required).</param>
        /// <param name="UpperLimitValue">upper limit value.</param>
        /// <param name="LowerLimitValue">lower limit value.</param>
        public ObjectiveZone(string Label = null, DirectionTypeEnum? DirectionType = null, ZoneTypeEnum? ZoneType = null, int? UpperLimitPoints = null, int? LowerLimitPoints = null, int? UpperLimitValue = null, int? LowerLimitValue = null)
        {
            this.Label = Label;
            this.DirectionType = DirectionType;
            this.ZoneType = ZoneType;
            this.UpperLimitPoints = UpperLimitPoints;
            this.LowerLimitPoints = LowerLimitPoints;
            this.UpperLimitValue = UpperLimitValue;
            this.LowerLimitValue = LowerLimitValue;
            
        }
        
        
        
        /// <summary>
        /// label
        /// </summary>
        /// <value>label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// upper limit points
        /// </summary>
        /// <value>upper limit points</value>
        [DataMember(Name="upperLimitPoints", EmitDefaultValue=false)]
        public int? UpperLimitPoints { get; set; }
        
        
        
        /// <summary>
        /// lower limit points
        /// </summary>
        /// <value>lower limit points</value>
        [DataMember(Name="lowerLimitPoints", EmitDefaultValue=false)]
        public int? LowerLimitPoints { get; set; }
        
        
        
        /// <summary>
        /// upper limit value
        /// </summary>
        /// <value>upper limit value</value>
        [DataMember(Name="upperLimitValue", EmitDefaultValue=false)]
        public int? UpperLimitValue { get; set; }
        
        
        
        /// <summary>
        /// lower limit value
        /// </summary>
        /// <value>lower limit value</value>
        [DataMember(Name="lowerLimitValue", EmitDefaultValue=false)]
        public int? LowerLimitValue { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectiveZone {\n");
            
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  DirectionType: ").Append(DirectionType).Append("\n");
            sb.Append("  ZoneType: ").Append(ZoneType).Append("\n");
            sb.Append("  UpperLimitPoints: ").Append(UpperLimitPoints).Append("\n");
            sb.Append("  LowerLimitPoints: ").Append(LowerLimitPoints).Append("\n");
            sb.Append("  UpperLimitValue: ").Append(UpperLimitValue).Append("\n");
            sb.Append("  LowerLimitValue: ").Append(LowerLimitValue).Append("\n");
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
            return this.Equals(obj as ObjectiveZone);
        }

        /// <summary>
        /// Returns true if ObjectiveZone instances are equal
        /// </summary>
        /// <param name="other">Instance of ObjectiveZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectiveZone other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) &&
                (
                    this.DirectionType == other.DirectionType ||
                    this.DirectionType != null &&
                    this.DirectionType.Equals(other.DirectionType)
                ) &&
                (
                    this.ZoneType == other.ZoneType ||
                    this.ZoneType != null &&
                    this.ZoneType.Equals(other.ZoneType)
                ) &&
                (
                    this.UpperLimitPoints == other.UpperLimitPoints ||
                    this.UpperLimitPoints != null &&
                    this.UpperLimitPoints.Equals(other.UpperLimitPoints)
                ) &&
                (
                    this.LowerLimitPoints == other.LowerLimitPoints ||
                    this.LowerLimitPoints != null &&
                    this.LowerLimitPoints.Equals(other.LowerLimitPoints)
                ) &&
                (
                    this.UpperLimitValue == other.UpperLimitValue ||
                    this.UpperLimitValue != null &&
                    this.UpperLimitValue.Equals(other.UpperLimitValue)
                ) &&
                (
                    this.LowerLimitValue == other.LowerLimitValue ||
                    this.LowerLimitValue != null &&
                    this.LowerLimitValue.Equals(other.LowerLimitValue)
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
                
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                
                if (this.DirectionType != null)
                    hash = hash * 59 + this.DirectionType.GetHashCode();
                
                if (this.ZoneType != null)
                    hash = hash * 59 + this.ZoneType.GetHashCode();
                
                if (this.UpperLimitPoints != null)
                    hash = hash * 59 + this.UpperLimitPoints.GetHashCode();
                
                if (this.LowerLimitPoints != null)
                    hash = hash * 59 + this.LowerLimitPoints.GetHashCode();
                
                if (this.UpperLimitValue != null)
                    hash = hash * 59 + this.UpperLimitValue.GetHashCode();
                
                if (this.LowerLimitValue != null)
                    hash = hash * 59 + this.LowerLimitValue.GetHashCode();
                
                return hash;
            }
        }
    }

}
