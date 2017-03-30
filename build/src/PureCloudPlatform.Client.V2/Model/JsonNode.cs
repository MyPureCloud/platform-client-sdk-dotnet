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
    /// JsonNode
    /// </summary>
    [DataContract]
    public partial class JsonNode :  IEquatable<JsonNode>
    {
        /// <summary>
        /// Gets or Sets NodeType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NodeTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Array for "ARRAY"
            /// </summary>
            [EnumMember(Value = "ARRAY")]
            Array,
            
            /// <summary>
            /// Enum Binary for "BINARY"
            /// </summary>
            [EnumMember(Value = "BINARY")]
            Binary,
            
            /// <summary>
            /// Enum Boolean for "BOOLEAN"
            /// </summary>
            [EnumMember(Value = "BOOLEAN")]
            Boolean,
            
            /// <summary>
            /// Enum Missing for "MISSING"
            /// </summary>
            [EnumMember(Value = "MISSING")]
            Missing,
            
            /// <summary>
            /// Enum Null for "NULL"
            /// </summary>
            [EnumMember(Value = "NULL")]
            Null,
            
            /// <summary>
            /// Enum Number for "NUMBER"
            /// </summary>
            [EnumMember(Value = "NUMBER")]
            Number,
            
            /// <summary>
            /// Enum Object for "OBJECT"
            /// </summary>
            [EnumMember(Value = "OBJECT")]
            Object,
            
            /// <summary>
            /// Enum Pojo for "POJO"
            /// </summary>
            [EnumMember(Value = "POJO")]
            Pojo,
            
            /// <summary>
            /// Enum String for "STRING"
            /// </summary>
            [EnumMember(Value = "STRING")]
            String
        }
        /// <summary>
        /// Gets or Sets NodeType
        /// </summary>
        [DataMember(Name="nodeType", EmitDefaultValue=false)]
        public NodeTypeEnum? NodeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonNode" /> class.
        /// </summary>
        /// <param name="NodeType">NodeType.</param>
        /// <param name="_Float">_Float.</param>
        /// <param name="_Object">_Object.</param>
        /// <param name="Boolean">Boolean.</param>
        /// <param name="Number">Number.</param>
        /// <param name="ValueNode">ValueNode.</param>
        /// <param name="ContainerNode">ContainerNode.</param>
        /// <param name="MissingNode">MissingNode.</param>
        /// <param name="Pojo">Pojo.</param>
        /// <param name="IntegralNumber">IntegralNumber.</param>
        /// <param name="FloatingPointNumber">FloatingPointNumber.</param>
        /// <param name="_Short">_Short.</param>
        /// <param name="_Int">_Int.</param>
        /// <param name="_Long">_Long.</param>
        /// <param name="_Double">_Double.</param>
        /// <param name="BigDecimal">BigDecimal.</param>
        /// <param name="BigInteger">BigInteger.</param>
        /// <param name="Textual">Textual.</param>
        /// <param name="Binary">Binary.</param>
        /// <param name="Array">Array.</param>
        /// <param name="_Null">_Null.</param>
        public JsonNode(NodeTypeEnum? NodeType = null, bool? _Float = null, bool? _Object = null, bool? Boolean = null, bool? Number = null, bool? ValueNode = null, bool? ContainerNode = null, bool? MissingNode = null, bool? Pojo = null, bool? IntegralNumber = null, bool? FloatingPointNumber = null, bool? _Short = null, bool? _Int = null, bool? _Long = null, bool? _Double = null, bool? BigDecimal = null, bool? BigInteger = null, bool? Textual = null, bool? Binary = null, bool? Array = null, bool? _Null = null)
        {
            this.NodeType = NodeType;
            this._Float = _Float;
            this._Object = _Object;
            this.Boolean = Boolean;
            this.Number = Number;
            this.ValueNode = ValueNode;
            this.ContainerNode = ContainerNode;
            this.MissingNode = MissingNode;
            this.Pojo = Pojo;
            this.IntegralNumber = IntegralNumber;
            this.FloatingPointNumber = FloatingPointNumber;
            this._Short = _Short;
            this._Int = _Int;
            this._Long = _Long;
            this._Double = _Double;
            this.BigDecimal = BigDecimal;
            this.BigInteger = BigInteger;
            this.Textual = Textual;
            this.Binary = Binary;
            this.Array = Array;
            this._Null = _Null;
        }
        
        /// <summary>
        /// Gets or Sets _Float
        /// </summary>
        [DataMember(Name="float", EmitDefaultValue=false)]
        public bool? _Float { get; set; }
        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public bool? _Object { get; set; }
        /// <summary>
        /// Gets or Sets Boolean
        /// </summary>
        [DataMember(Name="boolean", EmitDefaultValue=false)]
        public bool? Boolean { get; set; }
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public bool? Number { get; set; }
        /// <summary>
        /// Gets or Sets ValueNode
        /// </summary>
        [DataMember(Name="valueNode", EmitDefaultValue=false)]
        public bool? ValueNode { get; set; }
        /// <summary>
        /// Gets or Sets ContainerNode
        /// </summary>
        [DataMember(Name="containerNode", EmitDefaultValue=false)]
        public bool? ContainerNode { get; set; }
        /// <summary>
        /// Gets or Sets MissingNode
        /// </summary>
        [DataMember(Name="missingNode", EmitDefaultValue=false)]
        public bool? MissingNode { get; set; }
        /// <summary>
        /// Gets or Sets Pojo
        /// </summary>
        [DataMember(Name="pojo", EmitDefaultValue=false)]
        public bool? Pojo { get; set; }
        /// <summary>
        /// Gets or Sets IntegralNumber
        /// </summary>
        [DataMember(Name="integralNumber", EmitDefaultValue=false)]
        public bool? IntegralNumber { get; set; }
        /// <summary>
        /// Gets or Sets FloatingPointNumber
        /// </summary>
        [DataMember(Name="floatingPointNumber", EmitDefaultValue=false)]
        public bool? FloatingPointNumber { get; set; }
        /// <summary>
        /// Gets or Sets _Short
        /// </summary>
        [DataMember(Name="short", EmitDefaultValue=false)]
        public bool? _Short { get; set; }
        /// <summary>
        /// Gets or Sets _Int
        /// </summary>
        [DataMember(Name="int", EmitDefaultValue=false)]
        public bool? _Int { get; set; }
        /// <summary>
        /// Gets or Sets _Long
        /// </summary>
        [DataMember(Name="long", EmitDefaultValue=false)]
        public bool? _Long { get; set; }
        /// <summary>
        /// Gets or Sets _Double
        /// </summary>
        [DataMember(Name="double", EmitDefaultValue=false)]
        public bool? _Double { get; set; }
        /// <summary>
        /// Gets or Sets BigDecimal
        /// </summary>
        [DataMember(Name="bigDecimal", EmitDefaultValue=false)]
        public bool? BigDecimal { get; set; }
        /// <summary>
        /// Gets or Sets BigInteger
        /// </summary>
        [DataMember(Name="bigInteger", EmitDefaultValue=false)]
        public bool? BigInteger { get; set; }
        /// <summary>
        /// Gets or Sets Textual
        /// </summary>
        [DataMember(Name="textual", EmitDefaultValue=false)]
        public bool? Textual { get; set; }
        /// <summary>
        /// Gets or Sets Binary
        /// </summary>
        [DataMember(Name="binary", EmitDefaultValue=false)]
        public bool? Binary { get; set; }
        /// <summary>
        /// Gets or Sets Array
        /// </summary>
        [DataMember(Name="array", EmitDefaultValue=false)]
        public bool? Array { get; set; }
        /// <summary>
        /// Gets or Sets _Null
        /// </summary>
        [DataMember(Name="null", EmitDefaultValue=false)]
        public bool? _Null { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonNode {\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  _Float: ").Append(_Float).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Boolean: ").Append(Boolean).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ValueNode: ").Append(ValueNode).Append("\n");
            sb.Append("  ContainerNode: ").Append(ContainerNode).Append("\n");
            sb.Append("  MissingNode: ").Append(MissingNode).Append("\n");
            sb.Append("  Pojo: ").Append(Pojo).Append("\n");
            sb.Append("  IntegralNumber: ").Append(IntegralNumber).Append("\n");
            sb.Append("  FloatingPointNumber: ").Append(FloatingPointNumber).Append("\n");
            sb.Append("  _Short: ").Append(_Short).Append("\n");
            sb.Append("  _Int: ").Append(_Int).Append("\n");
            sb.Append("  _Long: ").Append(_Long).Append("\n");
            sb.Append("  _Double: ").Append(_Double).Append("\n");
            sb.Append("  BigDecimal: ").Append(BigDecimal).Append("\n");
            sb.Append("  BigInteger: ").Append(BigInteger).Append("\n");
            sb.Append("  Textual: ").Append(Textual).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  Array: ").Append(Array).Append("\n");
            sb.Append("  _Null: ").Append(_Null).Append("\n");
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
            return this.Equals(obj as JsonNode);
        }

        /// <summary>
        /// Returns true if JsonNode instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonNode other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.NodeType == other.NodeType ||
                    this.NodeType != null &&
                    this.NodeType.Equals(other.NodeType)
                ) &&
                (
                    this._Float == other._Float ||
                    this._Float != null &&
                    this._Float.Equals(other._Float)
                ) &&
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) &&
                (
                    this.Boolean == other.Boolean ||
                    this.Boolean != null &&
                    this.Boolean.Equals(other.Boolean)
                ) &&
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) &&
                (
                    this.ValueNode == other.ValueNode ||
                    this.ValueNode != null &&
                    this.ValueNode.Equals(other.ValueNode)
                ) &&
                (
                    this.ContainerNode == other.ContainerNode ||
                    this.ContainerNode != null &&
                    this.ContainerNode.Equals(other.ContainerNode)
                ) &&
                (
                    this.MissingNode == other.MissingNode ||
                    this.MissingNode != null &&
                    this.MissingNode.Equals(other.MissingNode)
                ) &&
                (
                    this.Pojo == other.Pojo ||
                    this.Pojo != null &&
                    this.Pojo.Equals(other.Pojo)
                ) &&
                (
                    this.IntegralNumber == other.IntegralNumber ||
                    this.IntegralNumber != null &&
                    this.IntegralNumber.Equals(other.IntegralNumber)
                ) &&
                (
                    this.FloatingPointNumber == other.FloatingPointNumber ||
                    this.FloatingPointNumber != null &&
                    this.FloatingPointNumber.Equals(other.FloatingPointNumber)
                ) &&
                (
                    this._Short == other._Short ||
                    this._Short != null &&
                    this._Short.Equals(other._Short)
                ) &&
                (
                    this._Int == other._Int ||
                    this._Int != null &&
                    this._Int.Equals(other._Int)
                ) &&
                (
                    this._Long == other._Long ||
                    this._Long != null &&
                    this._Long.Equals(other._Long)
                ) &&
                (
                    this._Double == other._Double ||
                    this._Double != null &&
                    this._Double.Equals(other._Double)
                ) &&
                (
                    this.BigDecimal == other.BigDecimal ||
                    this.BigDecimal != null &&
                    this.BigDecimal.Equals(other.BigDecimal)
                ) &&
                (
                    this.BigInteger == other.BigInteger ||
                    this.BigInteger != null &&
                    this.BigInteger.Equals(other.BigInteger)
                ) &&
                (
                    this.Textual == other.Textual ||
                    this.Textual != null &&
                    this.Textual.Equals(other.Textual)
                ) &&
                (
                    this.Binary == other.Binary ||
                    this.Binary != null &&
                    this.Binary.Equals(other.Binary)
                ) &&
                (
                    this.Array == other.Array ||
                    this.Array != null &&
                    this.Array.Equals(other.Array)
                ) &&
                (
                    this._Null == other._Null ||
                    this._Null != null &&
                    this._Null.Equals(other._Null)
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
                if (this.NodeType != null)
                    hash = hash * 59 + this.NodeType.GetHashCode();
                if (this._Float != null)
                    hash = hash * 59 + this._Float.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.Boolean != null)
                    hash = hash * 59 + this.Boolean.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.ValueNode != null)
                    hash = hash * 59 + this.ValueNode.GetHashCode();
                if (this.ContainerNode != null)
                    hash = hash * 59 + this.ContainerNode.GetHashCode();
                if (this.MissingNode != null)
                    hash = hash * 59 + this.MissingNode.GetHashCode();
                if (this.Pojo != null)
                    hash = hash * 59 + this.Pojo.GetHashCode();
                if (this.IntegralNumber != null)
                    hash = hash * 59 + this.IntegralNumber.GetHashCode();
                if (this.FloatingPointNumber != null)
                    hash = hash * 59 + this.FloatingPointNumber.GetHashCode();
                if (this._Short != null)
                    hash = hash * 59 + this._Short.GetHashCode();
                if (this._Int != null)
                    hash = hash * 59 + this._Int.GetHashCode();
                if (this._Long != null)
                    hash = hash * 59 + this._Long.GetHashCode();
                if (this._Double != null)
                    hash = hash * 59 + this._Double.GetHashCode();
                if (this.BigDecimal != null)
                    hash = hash * 59 + this.BigDecimal.GetHashCode();
                if (this.BigInteger != null)
                    hash = hash * 59 + this.BigInteger.GetHashCode();
                if (this.Textual != null)
                    hash = hash * 59 + this.Textual.GetHashCode();
                if (this.Binary != null)
                    hash = hash * 59 + this.Binary.GetHashCode();
                if (this.Array != null)
                    hash = hash * 59 + this.Array.GetHashCode();
                if (this._Null != null)
                    hash = hash * 59 + this._Null.GetHashCode();
                return hash;
            }
        }
    }

}
