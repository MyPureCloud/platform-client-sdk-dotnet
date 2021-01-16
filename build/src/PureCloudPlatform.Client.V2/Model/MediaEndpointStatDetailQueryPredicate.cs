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
    /// MediaEndpointStatDetailQueryPredicate
    /// </summary>
    [DataContract]
    public partial class MediaEndpointStatDetailQueryPredicate :  IEquatable<MediaEndpointStatDetailQueryPredicate>
    {
        
        
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
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
            /// Enum Dimension for "dimension"
            /// </summary>
            [EnumMember(Value = "dimension")]
            Dimension,
            
            /// <summary>
            /// Enum Property for "property"
            /// </summary>
            [EnumMember(Value = "property")]
            Property,
            
            /// <summary>
            /// Enum Metric for "metric"
            /// </summary>
            [EnumMember(Value = "metric")]
            Metric
        }
        
        
        
        
        /// <summary>
        /// Left hand side for dimension predicates
        /// </summary>
        /// <value>Left hand side for dimension predicates</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DimensionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Codec for "codec"
            /// </summary>
            [EnumMember(Value = "codec")]
            Codec,
            
            /// <summary>
            /// Enum Discardedpackets for "discardedPackets"
            /// </summary>
            [EnumMember(Value = "discardedPackets")]
            Discardedpackets,
            
            /// <summary>
            /// Enum Duplicatepackets for "duplicatePackets"
            /// </summary>
            [EnumMember(Value = "duplicatePackets")]
            Duplicatepackets,
            
            /// <summary>
            /// Enum Eventtime for "eventTime"
            /// </summary>
            [EnumMember(Value = "eventTime")]
            Eventtime,
            
            /// <summary>
            /// Enum Invalidpackets for "invalidPackets"
            /// </summary>
            [EnumMember(Value = "invalidPackets")]
            Invalidpackets,
            
            /// <summary>
            /// Enum Maxlatencyms for "maxLatencyMs"
            /// </summary>
            [EnumMember(Value = "maxLatencyMs")]
            Maxlatencyms,
            
            /// <summary>
            /// Enum Overrunpackets for "overrunPackets"
            /// </summary>
            [EnumMember(Value = "overrunPackets")]
            Overrunpackets,
            
            /// <summary>
            /// Enum Receivedpackets for "receivedPackets"
            /// </summary>
            [EnumMember(Value = "receivedPackets")]
            Receivedpackets,
            
            /// <summary>
            /// Enum Underrunpackets for "underrunPackets"
            /// </summary>
            [EnumMember(Value = "underrunPackets")]
            Underrunpackets
        }
        
        
        
        
        /// <summary>
        /// Optional operator, default is matches
        /// </summary>
        /// <value>Optional operator, default is matches</value>
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
            /// Enum Matches for "matches"
            /// </summary>
            [EnumMember(Value = "matches")]
            Matches,
            
            /// <summary>
            /// Enum Exists for "exists"
            /// </summary>
            [EnumMember(Value = "exists")]
            Exists,
            
            /// <summary>
            /// Enum Notexists for "notExists"
            /// </summary>
            [EnumMember(Value = "notExists")]
            Notexists
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        /// <summary>
        /// Left hand side for dimension predicates
        /// </summary>
        /// <value>Left hand side for dimension predicates</value>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public DimensionEnum? Dimension { get; set; }
        
        
        
        /// <summary>
        /// Optional operator, default is matches
        /// </summary>
        /// <value>Optional operator, default is matches</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaEndpointStatDetailQueryPredicate" /> class.
        /// </summary>
        /// <param name="Type">Optional type, can usually be inferred.</param>
        /// <param name="Dimension">Left hand side for dimension predicates.</param>
        /// <param name="_Operator">Optional operator, default is matches.</param>
        /// <param name="Value">Right hand side for dimension predicates.</param>
        /// <param name="Range">Right hand side for dimension predicates.</param>
        public MediaEndpointStatDetailQueryPredicate(TypeEnum? Type = null, DimensionEnum? Dimension = null, OperatorEnum? _Operator = null, string Value = null, NumericRange Range = null)
        {
            this.Type = Type;
            this.Dimension = Dimension;
            this._Operator = _Operator;
            this.Value = Value;
            this.Range = Range;
            
        }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Right hand side for dimension predicates
        /// </summary>
        /// <value>Right hand side for dimension predicates</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        /// <summary>
        /// Right hand side for dimension predicates
        /// </summary>
        /// <value>Right hand side for dimension predicates</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public NumericRange Range { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaEndpointStatDetailQueryPredicate {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(obj as MediaEndpointStatDetailQueryPredicate);
        }

        /// <summary>
        /// Returns true if MediaEndpointStatDetailQueryPredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaEndpointStatDetailQueryPredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaEndpointStatDetailQueryPredicate other)
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
                    this.Dimension == other.Dimension ||
                    this.Dimension != null &&
                    this.Dimension.Equals(other.Dimension)
                ) &&
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
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
                
                if (this.Dimension != null)
                    hash = hash * 59 + this.Dimension.GetHashCode();
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();
                
                return hash;
            }
        }
    }

}
