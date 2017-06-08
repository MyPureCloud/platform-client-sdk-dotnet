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
    /// Used to filter response queries
    /// </summary>
    [DataContract]
    public partial class ResponseFilter :  IEquatable<ResponseFilter>
    {
        
        
        
        
        
        /// <summary>
        /// Filter operation: IN, EQUALS, NOTEQUALS.
        /// </summary>
        /// <value>Filter operation: IN, EQUALS, NOTEQUALS.</value>
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
            /// Enum Equals for "EQUALS"
            /// </summary>
            [EnumMember(Value = "EQUALS")]
            Equals,
            
            /// <summary>
            /// Enum Notequals for "NOTEQUALS"
            /// </summary>
            [EnumMember(Value = "NOTEQUALS")]
            Notequals
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Filter operation: IN, EQUALS, NOTEQUALS.
        /// </summary>
        /// <value>Filter operation: IN, EQUALS, NOTEQUALS.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseFilter() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFilter" /> class.
        /// </summary>
        
        
        /// <param name="Name">Field to filter on. Allowed values are &#39;name&#39; and &#39;libraryId. (required).</param>
        
        
        
        /// <param name="_Operator">Filter operation: IN, EQUALS, NOTEQUALS. (required).</param>
        
        
        
        /// <param name="Values">Values to filter on. (required).</param>
        
        
        public ResponseFilter(string Name = null, OperatorEnum? _Operator = null, List<string> Values = null)
        {
            
            
            
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ResponseFilter and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
            
            
            
            
            // to ensure "_Operator" is required (not null)
            if (_Operator == null)
            {
                throw new InvalidDataException("_Operator is a required property for ResponseFilter and cannot be null");
            }
            else
            {
                this._Operator = _Operator;
            }
            
            
            
            
            
            // to ensure "Values" is required (not null)
            if (Values == null)
            {
                throw new InvalidDataException("Values is a required property for ResponseFilter and cannot be null");
            }
            else
            {
                this.Values = Values;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Field to filter on. Allowed values are &#39;name&#39; and &#39;libraryId.
        /// </summary>
        /// <value>Field to filter on. Allowed values are &#39;name&#39; and &#39;libraryId.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        
        
        /// <summary>
        /// Values to filter on.
        /// </summary>
        /// <value>Values to filter on.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseFilter {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
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
            return this.Equals(obj as ResponseFilter);
        }

        /// <summary>
        /// Returns true if ResponseFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                
                return hash;
            }
        }
    }

}
