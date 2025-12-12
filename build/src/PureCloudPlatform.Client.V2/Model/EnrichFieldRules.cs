using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// EnrichFieldRules
	/// </summary>
	[DataContract]
	public partial class EnrichFieldRules : IEquatable<EnrichFieldRules>
	{
		/// <summary>
		/// Default behavior for combining data from the submitted request with any entity found in the database. The default behavior if unspecified is `PreferProvided`, meaning any non-null fields in the submitted request will override data in the database, but all null fields will remain unchanged. Omitting a field in the request payload means that it will be treated as null.
		/// </summary>
		/// <value>Default behavior for combining data from the submitted request with any entity found in the database. The default behavior if unspecified is `PreferProvided`, meaning any non-null fields in the submitted request will override data in the database, but all null fields will remain unchanged. Omitting a field in the request payload means that it will be treated as null.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DefaultActionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Alwaysuseprovided for "AlwaysUseProvided"
			/// </summary>
			[EnumMember(Value = "AlwaysUseProvided")]
			Alwaysuseprovided,

			/// <summary>
			/// Enum Preferexisting for "PreferExisting"
			/// </summary>
			[EnumMember(Value = "PreferExisting")]
			Preferexisting,

			/// <summary>
			/// Enum Preferprovided for "PreferProvided"
			/// </summary>
			[EnumMember(Value = "PreferProvided")]
			Preferprovided
		}
		/// <summary>
		/// Default behavior for combining items in array field from the submitted request with any array entity found in the database. The default behavior if unspecified is `fill`, meaning the field value will always be the partial concatenation of both the array in the Database and the array in the contact body, up to the size limit of the array
		/// </summary>
		/// <value>Default behavior for combining items in array field from the submitted request with any array entity found in the database. The default behavior if unspecified is `fill`, meaning the field value will always be the partial concatenation of both the array in the Database and the array in the contact body, up to the size limit of the array</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DefaultArrayActionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Replace for "Replace"
			/// </summary>
			[EnumMember(Value = "Replace")]
			Replace,

			/// <summary>
			/// Enum Extend for "Extend"
			/// </summary>
			[EnumMember(Value = "Extend")]
			Extend,

			/// <summary>
			/// Enum Fill for "Fill"
			/// </summary>
			[EnumMember(Value = "Fill")]
			Fill
		}
		/// <summary>
		/// Default behavior for combining data from the submitted request with any entity found in the database. The default behavior if unspecified is `PreferProvided`, meaning any non-null fields in the submitted request will override data in the database, but all null fields will remain unchanged. Omitting a field in the request payload means that it will be treated as null.
		/// </summary>
		/// <value>Default behavior for combining data from the submitted request with any entity found in the database. The default behavior if unspecified is `PreferProvided`, meaning any non-null fields in the submitted request will override data in the database, but all null fields will remain unchanged. Omitting a field in the request payload means that it will be treated as null.</value>
		[DataMember(Name = "defaultAction", EmitDefaultValue = false)]
		public DefaultActionEnum? DefaultAction { get; set; }
		/// <summary>
		/// Default behavior for combining items in array field from the submitted request with any array entity found in the database. The default behavior if unspecified is `fill`, meaning the field value will always be the partial concatenation of both the array in the Database and the array in the contact body, up to the size limit of the array
		/// </summary>
		/// <value>Default behavior for combining items in array field from the submitted request with any array entity found in the database. The default behavior if unspecified is `fill`, meaning the field value will always be the partial concatenation of both the array in the Database and the array in the contact body, up to the size limit of the array</value>
		[DataMember(Name = "defaultArrayAction", EmitDefaultValue = false)]
		public DefaultArrayActionEnum? DefaultArrayAction { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="EnrichFieldRules" /> class.
		/// </summary>
		/// <param name="DefaultAction">Default behavior for combining data from the submitted request with any entity found in the database. The default behavior if unspecified is &#x60;PreferProvided&#x60;, meaning any non-null fields in the submitted request will override data in the database, but all null fields will remain unchanged. Omitting a field in the request payload means that it will be treated as null..</param>
		/// <param name="Rules">Field-specific behaviors for how to combine data from different sources. For example, you can set a &#x60;defaultAction&#x60; of &#x60;PreferProvided&#x60;, but use different behaviors such as &#x60;AlwaysUseProvided&#x60; or &#x60;PreferExisting&#x60; for specific fields..</param>
		/// <param name="DefaultArrayAction">Default behavior for combining items in array field from the submitted request with any array entity found in the database. The default behavior if unspecified is &#x60;fill&#x60;, meaning the field value will always be the partial concatenation of both the array in the Database and the array in the contact body, up to the size limit of the array.</param>
		public EnrichFieldRules(DefaultActionEnum? DefaultAction = null, List<EnrichFieldRule> Rules = null, DefaultArrayActionEnum? DefaultArrayAction = null)
		{
			this.DefaultAction = DefaultAction;
			this.Rules = Rules;
			this.DefaultArrayAction = DefaultArrayAction;

		}





		/// <summary>
		/// Field-specific behaviors for how to combine data from different sources. For example, you can set a &#x60;defaultAction&#x60; of &#x60;PreferProvided&#x60;, but use different behaviors such as &#x60;AlwaysUseProvided&#x60; or &#x60;PreferExisting&#x60; for specific fields.
		/// </summary>
		/// <value>Field-specific behaviors for how to combine data from different sources. For example, you can set a &#x60;defaultAction&#x60; of &#x60;PreferProvided&#x60;, but use different behaviors such as &#x60;AlwaysUseProvided&#x60; or &#x60;PreferExisting&#x60; for specific fields.</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<EnrichFieldRule> Rules { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EnrichFieldRules {\n");

			sb.Append("  DefaultAction: ").Append(DefaultAction).Append("\n");
			sb.Append("  Rules: ").Append(Rules).Append("\n");
			sb.Append("  DefaultArrayAction: ").Append(DefaultArrayAction).Append("\n");
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
			return this.Equals(obj as EnrichFieldRules);
		}

		/// <summary>
		/// Returns true if EnrichFieldRules instances are equal
		/// </summary>
		/// <param name="other">Instance of EnrichFieldRules to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EnrichFieldRules other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DefaultAction == other.DefaultAction ||
					this.DefaultAction != null &&
					this.DefaultAction.Equals(other.DefaultAction)
				) &&
				(
					this.Rules == other.Rules ||
					this.Rules != null &&
					this.Rules.SequenceEqual(other.Rules)
				) &&
				(
					this.DefaultArrayAction == other.DefaultArrayAction ||
					this.DefaultArrayAction != null &&
					this.DefaultArrayAction.Equals(other.DefaultArrayAction)
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
				if (this.DefaultAction != null)
					hash = hash * 59 + this.DefaultAction.GetHashCode();

				if (this.Rules != null)
					hash = hash * 59 + this.Rules.GetHashCode();

				if (this.DefaultArrayAction != null)
					hash = hash * 59 + this.DefaultArrayAction.GetHashCode();

				return hash;
			}
		}
	}

}
