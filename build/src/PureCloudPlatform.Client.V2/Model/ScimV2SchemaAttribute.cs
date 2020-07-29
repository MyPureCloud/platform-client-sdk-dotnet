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
    /// A complex type that defines service provider attributes or subattributes and their qualities.
    /// </summary>
    [DataContract]
    public partial class ScimV2SchemaAttribute :  IEquatable<ScimV2SchemaAttribute>
    {
        
        
        
        
        
        /// <summary>
        /// The data type of the attribute.
        /// </summary>
        /// <value>The data type of the attribute.</value>
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
        /// The circumstances under which an attribute can be defined or redefined. The default is \"readWrite\".
        /// </summary>
        /// <value>The circumstances under which an attribute can be defined or redefined. The default is \"readWrite\".</value>
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
        /// The circumstances under which an attribute and its values are returned in response to a GET, PUT, POST, or PATCH request.
        /// </summary>
        /// <value>The circumstances under which an attribute and its values are returned in response to a GET, PUT, POST, or PATCH request.</value>
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
        /// The method by which the service provider enforces the uniqueness of an attribute value. A server can reject a value by returning the HTTP response code 400 (Bad Request). A client can enforce uniqueness to a greater degree than the server provider enforces. For example, a client could make a value unique even though the server has \"uniqueness\" set to \"none\".
        /// </summary>
        /// <value>The method by which the service provider enforces the uniqueness of an attribute value. A server can reject a value by returning the HTTP response code 400 (Bad Request). A client can enforce uniqueness to a greater degree than the server provider enforces. For example, a client could make a value unique even though the server has \"uniqueness\" set to \"none\".</value>
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
        /// The data type of the attribute.
        /// </summary>
        /// <value>The data type of the attribute.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The circumstances under which an attribute can be defined or redefined. The default is \"readWrite\".
        /// </summary>
        /// <value>The circumstances under which an attribute can be defined or redefined. The default is \"readWrite\".</value>
        [DataMember(Name="mutability", EmitDefaultValue=false)]
        public MutabilityEnum? Mutability { get; set; }
        
        
        
        /// <summary>
        /// The circumstances under which an attribute and its values are returned in response to a GET, PUT, POST, or PATCH request.
        /// </summary>
        /// <value>The circumstances under which an attribute and its values are returned in response to a GET, PUT, POST, or PATCH request.</value>
        [DataMember(Name="returned", EmitDefaultValue=false)]
        public ReturnedEnum? Returned { get; set; }
        
        
        
        /// <summary>
        /// The method by which the service provider enforces the uniqueness of an attribute value. A server can reject a value by returning the HTTP response code 400 (Bad Request). A client can enforce uniqueness to a greater degree than the server provider enforces. For example, a client could make a value unique even though the server has \"uniqueness\" set to \"none\".
        /// </summary>
        /// <value>The method by which the service provider enforces the uniqueness of an attribute value. A server can reject a value by returning the HTTP response code 400 (Bad Request). A client can enforce uniqueness to a greater degree than the server provider enforces. For example, a client could make a value unique even though the server has \"uniqueness\" set to \"none\".</value>
        [DataMember(Name="uniqueness", EmitDefaultValue=false)]
        public UniquenessEnum? Uniqueness { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimV2SchemaAttribute" /> class.
        /// </summary>
        /// <param name="SubAttributes">The list of subattributes for an attribute of the type \&quot;complex\&quot;. Uses the same schema as \&quot;attributes\&quot;..</param>
        /// <param name="CanonicalValues">The list of standard values that service providers may use. Service providers may ignore unsupported values..</param>
        /// <param name="ReferenceTypes">The list of SCIM resource types that may be referenced. Only applies when \&quot;type\&quot; is set to \&quot;reference\&quot;..</param>
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
        /// The list of subattributes for an attribute of the type \&quot;complex\&quot;. Uses the same schema as \&quot;attributes\&quot;.
        /// </summary>
        /// <value>The list of subattributes for an attribute of the type \&quot;complex\&quot;. Uses the same schema as \&quot;attributes\&quot;.</value>
        [DataMember(Name="subAttributes", EmitDefaultValue=false)]
        public List<ScimV2SchemaAttribute> SubAttributes { get; set; }
        
        
        
        /// <summary>
        /// Indicates whether an attribute contains multiple values.
        /// </summary>
        /// <value>Indicates whether an attribute contains multiple values.</value>
        [DataMember(Name="multiValued", EmitDefaultValue=false)]
        public bool? MultiValued { get; private set; }
        
        
        
        /// <summary>
        /// The description of the attribute.
        /// </summary>
        /// <value>The description of the attribute.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }
        
        
        
        /// <summary>
        /// Indicates whether an attribute is required.
        /// </summary>
        /// <value>Indicates whether an attribute is required.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; private set; }
        
        
        
        /// <summary>
        /// The list of standard values that service providers may use. Service providers may ignore unsupported values.
        /// </summary>
        /// <value>The list of standard values that service providers may use. Service providers may ignore unsupported values.</value>
        [DataMember(Name="canonicalValues", EmitDefaultValue=false)]
        public List<string> CanonicalValues { get; set; }
        
        
        
        /// <summary>
        /// Indicates whether a string attribute is case-sensitive. If set to \&quot;true\&quot;, the server preserves case sensitivity. If set to \&quot;false\&quot;, the server may change the case. The server also uses case sensitivity when evaluating filters. See section 3.4.2.2 \&quot;Filtering\&quot; in RFC 7644 for details.
        /// </summary>
        /// <value>Indicates whether a string attribute is case-sensitive. If set to \&quot;true\&quot;, the server preserves case sensitivity. If set to \&quot;false\&quot;, the server may change the case. The server also uses case sensitivity when evaluating filters. See section 3.4.2.2 \&quot;Filtering\&quot; in RFC 7644 for details.</value>
        [DataMember(Name="caseExact", EmitDefaultValue=false)]
        public bool? CaseExact { get; private set; }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The list of SCIM resource types that may be referenced. Only applies when \&quot;type\&quot; is set to \&quot;reference\&quot;.
        /// </summary>
        /// <value>The list of SCIM resource types that may be referenced. Only applies when \&quot;type\&quot; is set to \&quot;reference\&quot;.</value>
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
