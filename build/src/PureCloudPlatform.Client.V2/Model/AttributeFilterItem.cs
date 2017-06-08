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
    /// AttributeFilterItem
    /// </summary>
    [DataContract]
    public partial class AttributeFilterItem :  IEquatable<AttributeFilterItem>
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
            /// Enum In for "IN"
            /// </summary>
            [EnumMember(Value = "IN")]
            In,
            
            /// <summary>
            /// Enum Range for "RANGE"
            /// </summary>
            [EnumMember(Value = "RANGE")]
            Range,
            
            /// <summary>
            /// Enum Equals for "EQUALS"
            /// </summary>
            [EnumMember(Value = "EQUALS")]
            Equals,
            
            /// <summary>
            /// Enum Notequals for "NOTEQUALS"
            /// </summary>
            [EnumMember(Value = "NOTEQUALS")]
            Notequals,
            
            /// <summary>
            /// Enum Lessthan for "LESSTHAN"
            /// </summary>
            [EnumMember(Value = "LESSTHAN")]
            Lessthan,
            
            /// <summary>
            /// Enum Lessthanequals for "LESSTHANEQUALS"
            /// </summary>
            [EnumMember(Value = "LESSTHANEQUALS")]
            Lessthanequals,
            
            /// <summary>
            /// Enum Greaterthan for "GREATERTHAN"
            /// </summary>
            [EnumMember(Value = "GREATERTHAN")]
            Greaterthan,
            
            /// <summary>
            /// Enum Greaterthanequals for "GREATERTHANEQUALS"
            /// </summary>
            [EnumMember(Value = "GREATERTHANEQUALS")]
            Greaterthanequals,
            
            /// <summary>
            /// Enum Contains for "CONTAINS"
            /// </summary>
            [EnumMember(Value = "CONTAINS")]
            Contains
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeFilterItem" /> class.
        /// </summary>
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="_Operator">_Operator.</param>
        
        
        
        /// <param name="Values">Values.</param>
        
        
        public AttributeFilterItem(string Id = null, OperatorEnum? _Operator = null, List<string> Values = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this._Operator = _Operator;
            
            
            
            
            
            
            
            
this.Values = Values;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        
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
            sb.Append("class AttributeFilterItem {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            
            sb.Append("  Values: ").Append(Values).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AttributeFilterItem);
        }

        /// <summary>
        /// Returns true if AttributeFilterItem instances are equal
        /// </summary>
        /// <param name="other">Instance of AttributeFilterItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeFilterItem other)
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
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                
                return hash;
            }
        }
    }

}
