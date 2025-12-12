using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialerContactlistfilterConfigChangeFilterClause
	/// </summary>
	[DataContract]
	public partial class DialerContactlistfilterConfigChangeFilterClause : IEquatable<DialerContactlistfilterConfigChangeFilterClause>
	{
		/// <summary>
		/// Contact list filter type
		/// </summary>
		/// <value>Contact list filter type</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum FilterTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum And for "AND"
			/// </summary>
			[EnumMember(Value = "AND")]
			And,

			/// <summary>
			/// Enum Or for "OR"
			/// </summary>
			[EnumMember(Value = "OR")]
			Or
		}
		/// <summary>
		/// Contact list filter type
		/// </summary>
		/// <value>Contact list filter type</value>
		[DataMember(Name = "filterType", EmitDefaultValue = false)]
		public FilterTypeEnum? FilterType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DialerContactlistfilterConfigChangeFilterClause" /> class.
		/// </summary>
		/// <param name="FilterType">Contact list filter type.</param>
		/// <param name="Predicates">The list of predicates in that clause.</param>
		/// <param name="AdditionalProperties">AdditionalProperties.</param>
		/// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
		public DialerContactlistfilterConfigChangeFilterClause(FilterTypeEnum? FilterType = null, List<DialerContactlistfilterConfigChangeFilterPredicate> Predicates = null, Dictionary<string, Object> AdditionalProperties = null, Dictionary<string, Object> GetAdditionalProperties = null)
		{
			this.FilterType = FilterType;
			this.Predicates = Predicates;
			this.AdditionalProperties = AdditionalProperties;
			this.GetAdditionalProperties = GetAdditionalProperties;

		}





		/// <summary>
		/// The list of predicates in that clause
		/// </summary>
		/// <value>The list of predicates in that clause</value>
		[DataMember(Name = "predicates", EmitDefaultValue = false)]
		public List<DialerContactlistfilterConfigChangeFilterPredicate> Predicates { get; set; }



		/// <summary>
		/// Gets or Sets AdditionalProperties
		/// </summary>
		[DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> AdditionalProperties { get; set; }



		/// <summary>
		/// Gets or Sets GetAdditionalProperties
		/// </summary>
		[DataMember(Name = "getAdditionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> GetAdditionalProperties { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DialerContactlistfilterConfigChangeFilterClause {\n");

			sb.Append("  FilterType: ").Append(FilterType).Append("\n");
			sb.Append("  Predicates: ").Append(Predicates).Append("\n");
			sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
			sb.Append("  GetAdditionalProperties: ").Append(GetAdditionalProperties).Append("\n");
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
			return this.Equals(obj as DialerContactlistfilterConfigChangeFilterClause);
		}

		/// <summary>
		/// Returns true if DialerContactlistfilterConfigChangeFilterClause instances are equal
		/// </summary>
		/// <param name="other">Instance of DialerContactlistfilterConfigChangeFilterClause to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialerContactlistfilterConfigChangeFilterClause other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.FilterType == other.FilterType ||
					this.FilterType != null &&
					this.FilterType.Equals(other.FilterType)
				) &&
				(
					this.Predicates == other.Predicates ||
					this.Predicates != null &&
					this.Predicates.SequenceEqual(other.Predicates)
				) &&
				(
					this.AdditionalProperties == other.AdditionalProperties ||
					this.AdditionalProperties != null &&
					this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
				) &&
				(
					this.GetAdditionalProperties == other.GetAdditionalProperties ||
					this.GetAdditionalProperties != null &&
					this.GetAdditionalProperties.SequenceEqual(other.GetAdditionalProperties)
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
				if (this.FilterType != null)
					hash = hash * 59 + this.FilterType.GetHashCode();

				if (this.Predicates != null)
					hash = hash * 59 + this.Predicates.GetHashCode();

				if (this.AdditionalProperties != null)
					hash = hash * 59 + this.AdditionalProperties.GetHashCode();

				if (this.GetAdditionalProperties != null)
					hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

				return hash;
			}
		}
	}

}
