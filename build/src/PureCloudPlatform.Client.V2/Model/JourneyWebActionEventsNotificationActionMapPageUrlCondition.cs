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
    /// JourneyWebActionEventsNotificationActionMapPageUrlCondition
    /// </summary>
    [DataContract]
    public partial class JourneyWebActionEventsNotificationActionMapPageUrlCondition :  IEquatable<JourneyWebActionEventsNotificationActionMapPageUrlCondition>
    {
        
        
        
        
        
        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
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
            /// Enum Equal for "equal"
            /// </summary>
            [EnumMember(Value = "equal")]
            Equal,
            
            /// <summary>
            /// Enum Notequal for "notEqual"
            /// </summary>
            [EnumMember(Value = "notEqual")]
            Notequal,
            
            /// <summary>
            /// Enum Like for "like"
            /// </summary>
            [EnumMember(Value = "like")]
            Like,
            
            /// <summary>
            /// Enum Notlike for "notLike"
            /// </summary>
            [EnumMember(Value = "notLike")]
            Notlike,
            
            /// <summary>
            /// Enum Greaterthan for "greaterThan"
            /// </summary>
            [EnumMember(Value = "greaterThan")]
            Greaterthan,
            
            /// <summary>
            /// Enum Greaterthanorequal for "greaterThanOrEqual"
            /// </summary>
            [EnumMember(Value = "greaterThanOrEqual")]
            Greaterthanorequal,
            
            /// <summary>
            /// Enum Lessthan for "lessThan"
            /// </summary>
            [EnumMember(Value = "lessThan")]
            Lessthan,
            
            /// <summary>
            /// Enum Lessthanorequal for "lessThanOrEqual"
            /// </summary>
            [EnumMember(Value = "lessThanOrEqual")]
            Lessthanorequal,
            
            /// <summary>
            /// Enum Startswith for "startsWith"
            /// </summary>
            [EnumMember(Value = "startsWith")]
            Startswith,
            
            /// <summary>
            /// Enum Endswith for "endsWith"
            /// </summary>
            [EnumMember(Value = "endsWith")]
            Endswith,
            
            /// <summary>
            /// Enum Containsany for "containsAny"
            /// </summary>
            [EnumMember(Value = "containsAny")]
            Containsany,
            
            /// <summary>
            /// Enum Notcontainsany for "notContainsAny"
            /// </summary>
            [EnumMember(Value = "notContainsAny")]
            Notcontainsany,
            
            /// <summary>
            /// Enum Containsall for "containsAll"
            /// </summary>
            [EnumMember(Value = "containsAll")]
            Containsall,
            
            /// <summary>
            /// Enum Notcontainsal for "notContainsAl"
            /// </summary>
            [EnumMember(Value = "notContainsAl")]
            Notcontainsal
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyWebActionEventsNotificationActionMapPageUrlCondition" /> class.
        /// </summary>
        /// <param name="Values">Values.</param>
        /// <param name="_Operator">_Operator.</param>
        public JourneyWebActionEventsNotificationActionMapPageUrlCondition(List<string> Values = null, OperatorEnum? _Operator = null)
        {
            this.Values = Values;
            this._Operator = _Operator;
            
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
            sb.Append("class JourneyWebActionEventsNotificationActionMapPageUrlCondition {\n");
            
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
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
            return this.Equals(obj as JourneyWebActionEventsNotificationActionMapPageUrlCondition);
        }

        /// <summary>
        /// Returns true if JourneyWebActionEventsNotificationActionMapPageUrlCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyWebActionEventsNotificationActionMapPageUrlCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyWebActionEventsNotificationActionMapPageUrlCondition other)
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
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
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
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                return hash;
            }
        }
    }

}
