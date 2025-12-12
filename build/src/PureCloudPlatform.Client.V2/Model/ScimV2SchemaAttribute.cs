using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A complex type that defines service provider attributes or subattributes and their qualities.
	/// </summary>
	[DataContract]
	public partial class ScimV2SchemaAttribute : IEquatable<ScimV2SchemaAttribute>
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
			/// Enum String for "string"
			/// </summary>
			[EnumMember(Value = "string")]
			String,

			/// <summary>
			/// Enum Boolean for "boolean"
			/// </summary>
			[EnumMember(Value = "boolean")]
			Boolean,

			/// <summary>
			/// Enum Decimal for "decimal"
			/// </summary>
			[EnumMember(Value = "decimal")]
			Decimal,

			/// <summary>
			/// Enum Integer for "integer"
			/// </summary>
			[EnumMember(Value = "integer")]
			Integer,

			/// <summary>
			/// Enum Datetime for "dateTime"
			/// </summary>
			[EnumMember(Value = "dateTime")]
			Datetime,

			/// <summary>
			/// Enum Reference for "reference"
			/// </summary>
			[EnumMember(Value = "reference")]
			Reference,

			/// <summary>
			/// Enum Complex for "complex"
			/// </summary>
			[EnumMember(Value = "complex")]
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
			/// Enum Always for "always"
			/// </summary>
			[EnumMember(Value = "always")]
			Always,

			/// <summary>
			/// Enum Never for "never"
			/// </summary>
			[EnumMember(Value = "never")]
			Never,

			/// <summary>
			/// Enum Default for "default"
			/// </summary>
			[EnumMember(Value = "default")]
			Default,

			/// <summary>
			/// Enum Request for "request"
			/// </summary>
			[EnumMember(Value = "request")]
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
			/// Enum None for "none"
			/// </summary>
			[EnumMember(Value = "none")]
			None,

			/// <summary>
			/// Enum Server for "server"
			/// </summary>
			[EnumMember(Value = "server")]
			Server,

			/// <summary>
			/// Enum Global for "global"
			/// </summary>
			[EnumMember(Value = "global")]
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
			/// Enum User for "User"
			/// </summary>
			[EnumMember(Value = "User")]
			User,

			/// <summary>
			/// Enum Group for "Group"
			/// </summary>
			[EnumMember(Value = "Group")]
			Group,

			/// <summary>
			/// Enum External for "external"
			/// </summary>
			[EnumMember(Value = "external")]
			External,

			/// <summary>
			/// Enum Uri for "uri"
			/// </summary>
			[EnumMember(Value = "uri")]
			Uri
		}
		/// <summary>
		/// The data type of the attribute.
		/// </summary>
		/// <value>The data type of the attribute.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; private set; }
		/// <summary>
		/// The circumstances under which an attribute can be defined or redefined. The default is \"readWrite\".
		/// </summary>
		/// <value>The circumstances under which an attribute can be defined or redefined. The default is \"readWrite\".</value>
		[DataMember(Name = "mutability", EmitDefaultValue = false)]
		public MutabilityEnum? Mutability { get; private set; }
		/// <summary>
		/// The circumstances under which an attribute and its values are returned in response to a GET, PUT, POST, or PATCH request.
		/// </summary>
		/// <value>The circumstances under which an attribute and its values are returned in response to a GET, PUT, POST, or PATCH request.</value>
		[DataMember(Name = "returned", EmitDefaultValue = false)]
		public ReturnedEnum? Returned { get; private set; }
		/// <summary>
		/// The method by which the service provider enforces the uniqueness of an attribute value. A server can reject a value by returning the HTTP response code 400 (Bad Request). A client can enforce uniqueness to a greater degree than the server provider enforces. For example, a client could make a value unique even though the server has \"uniqueness\" set to \"none\".
		/// </summary>
		/// <value>The method by which the service provider enforces the uniqueness of an attribute value. A server can reject a value by returning the HTTP response code 400 (Bad Request). A client can enforce uniqueness to a greater degree than the server provider enforces. For example, a client could make a value unique even though the server has \"uniqueness\" set to \"none\".</value>
		[DataMember(Name = "uniqueness", EmitDefaultValue = false)]
		public UniquenessEnum? Uniqueness { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ScimV2SchemaAttribute" /> class.
		/// </summary>
		public ScimV2SchemaAttribute()
		{

		}



		/// <summary>
		/// The name of the attribute.
		/// </summary>
		/// <value>The name of the attribute.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; private set; }





		/// <summary>
		/// The list of subattributes for an attribute of the type \&quot;complex\&quot;. Uses the same schema as \&quot;attributes\&quot;.
		/// </summary>
		/// <value>The list of subattributes for an attribute of the type \&quot;complex\&quot;. Uses the same schema as \&quot;attributes\&quot;.</value>
		[DataMember(Name = "subAttributes", EmitDefaultValue = false)]
		public List<ScimV2SchemaAttribute> SubAttributes { get; private set; }



		/// <summary>
		/// Indicates whether an attribute contains multiple values.
		/// </summary>
		/// <value>Indicates whether an attribute contains multiple values.</value>
		[DataMember(Name = "multiValued", EmitDefaultValue = false)]
		public bool? MultiValued { get; private set; }



		/// <summary>
		/// The description of the attribute.
		/// </summary>
		/// <value>The description of the attribute.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; private set; }



		/// <summary>
		/// Indicates whether an attribute is required.
		/// </summary>
		/// <value>Indicates whether an attribute is required.</value>
		[DataMember(Name = "required", EmitDefaultValue = false)]
		public bool? Required { get; private set; }



		/// <summary>
		/// The list of standard values that service providers may use. Service providers may ignore unsupported values.
		/// </summary>
		/// <value>The list of standard values that service providers may use. Service providers may ignore unsupported values.</value>
		[DataMember(Name = "canonicalValues", EmitDefaultValue = false)]
		public List<string> CanonicalValues { get; private set; }



		/// <summary>
		/// Indicates whether a string attribute is case-sensitive. If set to \&quot;true\&quot;, the server preserves case sensitivity. If set to \&quot;false\&quot;, the server may change the case. The server also uses case sensitivity when evaluating filters. See section 3.4.2.2 \&quot;Filtering\&quot; in RFC 7644 for details.
		/// </summary>
		/// <value>Indicates whether a string attribute is case-sensitive. If set to \&quot;true\&quot;, the server preserves case sensitivity. If set to \&quot;false\&quot;, the server may change the case. The server also uses case sensitivity when evaluating filters. See section 3.4.2.2 \&quot;Filtering\&quot; in RFC 7644 for details.</value>
		[DataMember(Name = "caseExact", EmitDefaultValue = false)]
		public bool? CaseExact { get; private set; }









		/// <summary>
		/// The list of SCIM resource types that may be referenced. Only applies when \&quot;type\&quot; is set to \&quot;reference\&quot;.
		/// </summary>
		/// <value>The list of SCIM resource types that may be referenced. Only applies when \&quot;type\&quot; is set to \&quot;reference\&quot;.</value>
		[DataMember(Name = "referenceTypes", EmitDefaultValue = false)]
		public List<ReferenceTypesEnum> ReferenceTypes { get; private set; }


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
