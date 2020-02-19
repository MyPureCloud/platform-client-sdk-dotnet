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
    /// A complex type that defines service provider attributes, or sub-attributes and their qualities.
    /// </summary>
    [DataContract]
    public partial class ScimV2SchemaAttribute :  IEquatable<ScimV2SchemaAttribute>
    {
        
        
        
        
        
        /// <summary>
        /// The attribute's data type.  Valid values are \"string\", \"boolean\", \"decimal\", \"integer\", \"dateTime\", \"reference\", and \"complex\".
        /// </summary>
        /// <value>The attribute's data type.  Valid values are \"string\", \"boolean\", \"decimal\", \"integer\", \"dateTime\", \"reference\", and \"complex\".</value>
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
            /// Enum String for "STRING"
            /// </summary>
            [EnumMember(Value = "STRING")]
            String,
            
            /// <summary>
            /// Enum Boolean for "BOOLEAN"
            /// </summary>
            [EnumMember(Value = "BOOLEAN")]
            Boolean,
            
            /// <summary>
            /// Enum Decimal for "DECIMAL"
            /// </summary>
            [EnumMember(Value = "DECIMAL")]
            Decimal,
            
            /// <summary>
            /// Enum Integer for "INTEGER"
            /// </summary>
            [EnumMember(Value = "INTEGER")]
            Integer,
            
            /// <summary>
            /// Enum DateTime for "DATE_TIME"
            /// </summary>
            [EnumMember(Value = "DATE_TIME")]
            DateTime,
            
            /// <summary>
            /// Enum Reference for "REFERENCE"
            /// </summary>
            [EnumMember(Value = "REFERENCE")]
            Reference,
            
            /// <summary>
            /// Enum Complex for "COMPLEX"
            /// </summary>
            [EnumMember(Value = "COMPLEX")]
            Complex
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// A single keyword indicating the circumstances under which the value of the attribute can be (re)defined. Value are readOnly, readWrite, immutable, writeOnly
        /// </summary>
        /// <value>A single keyword indicating the circumstances under which the value of the attribute can be (re)defined. Value are readOnly, readWrite, immutable, writeOnly</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MutabilityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Readwrite for "readWrite"
            /// </summary>
            [EnumMember(Value = "readWrite")]
            Readwrite,
            
            /// <summary>
            /// Enum Readonly for "readOnly"
            /// </summary>
            [EnumMember(Value = "readOnly")]
            Readonly,
            
            /// <summary>
            /// Enum Immutable for "immutable"
            /// </summary>
            [EnumMember(Value = "immutable")]
            Immutable,
            
            /// <summary>
            /// Enum Writeonly for "writeOnly"
            /// </summary>
            [EnumMember(Value = "writeOnly")]
            Writeonly
        }
        
        
        
        
        /// <summary>
        /// A single keyword that indicates when an attribute and associated values are returned in response to a GET request, or in response to a PUT, POST, or PATCH request.  Valid keywords are as follows: always, never, default, request
        /// </summary>
        /// <value>A single keyword that indicates when an attribute and associated values are returned in response to a GET request, or in response to a PUT, POST, or PATCH request.  Valid keywords are as follows: always, never, default, request</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ReturnedEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Always for "ALWAYS"
            /// </summary>
            [EnumMember(Value = "ALWAYS")]
            Always,
            
            /// <summary>
            /// Enum Never for "NEVER"
            /// </summary>
            [EnumMember(Value = "NEVER")]
            Never,
            
            /// <summary>
            /// Enum Default for "DEFAULT"
            /// </summary>
            [EnumMember(Value = "DEFAULT")]
            Default,
            
            /// <summary>
            /// Enum Request for "REQUEST"
            /// </summary>
            [EnumMember(Value = "REQUEST")]
            Request
        }
        
        
        
        
        /// <summary>
        /// A single keyword value that specifies how the service provider enforces uniqueness of attribute values.  A server MAY reject an invalid value based on uniqueness by returning HTTP response code 400 (Bad Request).  A client MAY enforce uniqueness on the client side to a greater degree than the service provider enforces.  For example, a client could make a value unique while the server has uniqueness of \"none\".  Valid keywords are as follows: none, server, global
        /// </summary>
        /// <value>A single keyword value that specifies how the service provider enforces uniqueness of attribute values.  A server MAY reject an invalid value based on uniqueness by returning HTTP response code 400 (Bad Request).  A client MAY enforce uniqueness on the client side to a greater degree than the service provider enforces.  For example, a client could make a value unique while the server has uniqueness of \"none\".  Valid keywords are as follows: none, server, global</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UniquenessEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None,
            
            /// <summary>
            /// Enum Server for "SERVER"
            /// </summary>
            [EnumMember(Value = "SERVER")]
            Server,
            
            /// <summary>
            /// Enum Global for "GLOBAL"
            /// </summary>
            [EnumMember(Value = "GLOBAL")]
            Global
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ReferenceTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ReferenceTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum User for "USER"
            /// </summary>
            [EnumMember(Value = "USER")]
            User,
            
            /// <summary>
            /// Enum Group for "GROUP"
            /// </summary>
            [EnumMember(Value = "GROUP")]
            Group,
            
            /// <summary>
            /// Enum External for "EXTERNAL"
            /// </summary>
            [EnumMember(Value = "EXTERNAL")]
            External,
            
            /// <summary>
            /// Enum Uri for "URI"
            /// </summary>
            [EnumMember(Value = "URI")]
            Uri
        }
        
        
        
        
        
        
        
        /// <summary>
        /// The attribute's data type.  Valid values are \"string\", \"boolean\", \"decimal\", \"integer\", \"dateTime\", \"reference\", and \"complex\".
        /// </summary>
        /// <value>The attribute's data type.  Valid values are \"string\", \"boolean\", \"decimal\", \"integer\", \"dateTime\", \"reference\", and \"complex\".</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// A single keyword indicating the circumstances under which the value of the attribute can be (re)defined. Value are readOnly, readWrite, immutable, writeOnly
        /// </summary>
        /// <value>A single keyword indicating the circumstances under which the value of the attribute can be (re)defined. Value are readOnly, readWrite, immutable, writeOnly</value>
        [DataMember(Name="mutability", EmitDefaultValue=false)]
        public MutabilityEnum? Mutability { get; set; }
        
        
        
        /// <summary>
        /// A single keyword that indicates when an attribute and associated values are returned in response to a GET request, or in response to a PUT, POST, or PATCH request.  Valid keywords are as follows: always, never, default, request
        /// </summary>
        /// <value>A single keyword that indicates when an attribute and associated values are returned in response to a GET request, or in response to a PUT, POST, or PATCH request.  Valid keywords are as follows: always, never, default, request</value>
        [DataMember(Name="returned", EmitDefaultValue=false)]
        public ReturnedEnum? Returned { get; set; }
        
        
        
        /// <summary>
        /// A single keyword value that specifies how the service provider enforces uniqueness of attribute values.  A server MAY reject an invalid value based on uniqueness by returning HTTP response code 400 (Bad Request).  A client MAY enforce uniqueness on the client side to a greater degree than the service provider enforces.  For example, a client could make a value unique while the server has uniqueness of \"none\".  Valid keywords are as follows: none, server, global
        /// </summary>
        /// <value>A single keyword value that specifies how the service provider enforces uniqueness of attribute values.  A server MAY reject an invalid value based on uniqueness by returning HTTP response code 400 (Bad Request).  A client MAY enforce uniqueness on the client side to a greater degree than the service provider enforces.  For example, a client could make a value unique while the server has uniqueness of \"none\".  Valid keywords are as follows: none, server, global</value>
        [DataMember(Name="uniqueness", EmitDefaultValue=false)]
        public UniquenessEnum? Uniqueness { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimV2SchemaAttribute" /> class.
        /// </summary>
        /// <param name="SubAttributes">When an attribute is of type \&quot;complex\&quot;, \&quot;subAttributes\&quot; defines a set of sub-attributes. \&quot;subAttributes\&quot; has the same schema sub-attributes as \&quot;attributes\&quot;.</param>
        /// <param name="CanonicalValues">A collection of suggested canonical values that MAY be used (e.g., \&quot;work\&quot; and \&quot;home\&quot;).  In some cases, service providers MAY choose to ignore unsupported values.  OPTIONAL..</param>
        /// <param name="ReferenceTypes">A multi-valued array of JSON strings that indicate the SCIM resource types that may be referenced. Values include User, Group, external and uri..</param>
        public ScimV2SchemaAttribute(List<ScimV2SchemaAttribute> SubAttributes = null, List<string> CanonicalValues = null, List<ReferenceTypesEnum> ReferenceTypes = null)
        {
            this.SubAttributes = SubAttributes;
            this.CanonicalValues = CanonicalValues;
            this.ReferenceTypes = ReferenceTypes;
            
        }
        
        
        
        /// <summary>
        /// The attribute&#39;s name
        /// </summary>
        /// <value>The attribute&#39;s name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        
        
        
        
        
        /// <summary>
        /// When an attribute is of type \&quot;complex\&quot;, \&quot;subAttributes\&quot; defines a set of sub-attributes. \&quot;subAttributes\&quot; has the same schema sub-attributes as \&quot;attributes\&quot;
        /// </summary>
        /// <value>When an attribute is of type \&quot;complex\&quot;, \&quot;subAttributes\&quot; defines a set of sub-attributes. \&quot;subAttributes\&quot; has the same schema sub-attributes as \&quot;attributes\&quot;</value>
        [DataMember(Name="subAttributes", EmitDefaultValue=false)]
        public List<ScimV2SchemaAttribute> SubAttributes { get; set; }
        
        
        
        /// <summary>
        /// A Boolean value indicating the attribute&#39;s plurality.
        /// </summary>
        /// <value>A Boolean value indicating the attribute&#39;s plurality.</value>
        [DataMember(Name="multiValued", EmitDefaultValue=false)]
        public bool? MultiValued { get; private set; }
        
        
        
        /// <summary>
        /// The attribute&#39;s human-readable description.
        /// </summary>
        /// <value>The attribute&#39;s human-readable description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }
        
        
        
        /// <summary>
        /// A Boolean value that specifies whether or not the attribute is required.
        /// </summary>
        /// <value>A Boolean value that specifies whether or not the attribute is required.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; private set; }
        
        
        
        /// <summary>
        /// A collection of suggested canonical values that MAY be used (e.g., \&quot;work\&quot; and \&quot;home\&quot;).  In some cases, service providers MAY choose to ignore unsupported values.  OPTIONAL.
        /// </summary>
        /// <value>A collection of suggested canonical values that MAY be used (e.g., \&quot;work\&quot; and \&quot;home\&quot;).  In some cases, service providers MAY choose to ignore unsupported values.  OPTIONAL.</value>
        [DataMember(Name="canonicalValues", EmitDefaultValue=false)]
        public List<string> CanonicalValues { get; set; }
        
        
        
        /// <summary>
        /// A Boolean value that specifies whether or not a string attribute is case sensitive.  The server SHALL use case sensitivity when evaluating filters.  For attributes that are case exact, the server SHALL preserve case for any value submitted.  If the attribute is case insensitive, the server MAY alter case for a submitted value.  Case sensitivity also impacts how attribute values MAY be compared against filter values (see Section 3.4.2.2 of [RFC7644])
        /// </summary>
        /// <value>A Boolean value that specifies whether or not a string attribute is case sensitive.  The server SHALL use case sensitivity when evaluating filters.  For attributes that are case exact, the server SHALL preserve case for any value submitted.  If the attribute is case insensitive, the server MAY alter case for a submitted value.  Case sensitivity also impacts how attribute values MAY be compared against filter values (see Section 3.4.2.2 of [RFC7644])</value>
        [DataMember(Name="caseExact", EmitDefaultValue=false)]
        public bool? CaseExact { get; private set; }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// A multi-valued array of JSON strings that indicate the SCIM resource types that may be referenced. Values include User, Group, external and uri.
        /// </summary>
        /// <value>A multi-valued array of JSON strings that indicate the SCIM resource types that may be referenced. Values include User, Group, external and uri.</value>
        [DataMember(Name="referenceTypes", EmitDefaultValue=false)]
        public List<ReferenceTypesEnum> ReferenceTypes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimV2SchemaAttribute {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubAttributes: ").Append(SubAttributes).Append("\n");
            sb.Append("  MultiValued: ").Append(MultiValued).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  CanonicalValues: ").Append(CanonicalValues).Append("\n");
            sb.Append("  CaseExact: ").Append(CaseExact).Append("\n");
            sb.Append("  Mutability: ").Append(Mutability).Append("\n");
            sb.Append("  Returned: ").Append(Returned).Append("\n");
            sb.Append("  Uniqueness: ").Append(Uniqueness).Append("\n");
            sb.Append("  ReferenceTypes: ").Append(ReferenceTypes).Append("\n");
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
            return this.Equals(obj as ScimV2SchemaAttribute);
        }

        /// <summary>
        /// Returns true if ScimV2SchemaAttribute instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimV2SchemaAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimV2SchemaAttribute other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.SubAttributes == other.SubAttributes ||
                    this.SubAttributes != null &&
                    this.SubAttributes.SequenceEqual(other.SubAttributes)
                ) &&
                (
                    this.MultiValued == other.MultiValued ||
                    this.MultiValued != null &&
                    this.MultiValued.Equals(other.MultiValued)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) &&
                (
                    this.CanonicalValues == other.CanonicalValues ||
                    this.CanonicalValues != null &&
                    this.CanonicalValues.SequenceEqual(other.CanonicalValues)
                ) &&
                (
                    this.CaseExact == other.CaseExact ||
                    this.CaseExact != null &&
                    this.CaseExact.Equals(other.CaseExact)
                ) &&
                (
                    this.Mutability == other.Mutability ||
                    this.Mutability != null &&
                    this.Mutability.Equals(other.Mutability)
                ) &&
                (
                    this.Returned == other.Returned ||
                    this.Returned != null &&
                    this.Returned.Equals(other.Returned)
                ) &&
                (
                    this.Uniqueness == other.Uniqueness ||
                    this.Uniqueness != null &&
                    this.Uniqueness.Equals(other.Uniqueness)
                ) &&
                (
                    this.ReferenceTypes == other.ReferenceTypes ||
                    this.ReferenceTypes != null &&
                    this.ReferenceTypes.SequenceEqual(other.ReferenceTypes)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.SubAttributes != null)
                    hash = hash * 59 + this.SubAttributes.GetHashCode();
                
                if (this.MultiValued != null)
                    hash = hash * 59 + this.MultiValued.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                
                if (this.CanonicalValues != null)
                    hash = hash * 59 + this.CanonicalValues.GetHashCode();
                
                if (this.CaseExact != null)
                    hash = hash * 59 + this.CaseExact.GetHashCode();
                
                if (this.Mutability != null)
                    hash = hash * 59 + this.Mutability.GetHashCode();
                
                if (this.Returned != null)
                    hash = hash * 59 + this.Returned.GetHashCode();
                
                if (this.Uniqueness != null)
                    hash = hash * 59 + this.Uniqueness.GetHashCode();
                
                if (this.ReferenceTypes != null)
                    hash = hash * 59 + this.ReferenceTypes.GetHashCode();
                
                return hash;
            }
        }
    }

}
