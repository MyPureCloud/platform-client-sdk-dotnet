using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ListWrapperAlternativeShiftBuSettingsGranularity
	/// </summary>
	[DataContract]
	public partial class ListWrapperAlternativeShiftBuSettingsGranularity : IEquatable<ListWrapperAlternativeShiftBuSettingsGranularity>
	{
		/// <summary>
		/// Gets or Sets Values
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ValuesEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Daily for "Daily"
			/// </summary>
			[EnumMember(Value = "Daily")]
			Daily
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="ListWrapperAlternativeShiftBuSettingsGranularity" /> class.
		/// </summary>
		/// <param name="Values">Values.</param>
		public ListWrapperAlternativeShiftBuSettingsGranularity(List<ValuesEnum> Values = null)
		{
			this.Values = Values;

		}



		/// <summary>
		/// Gets or Sets Values
		/// </summary>
		[DataMember(Name = "values", EmitDefaultValue = false)]
		public List<ValuesEnum> Values { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ListWrapperAlternativeShiftBuSettingsGranularity {\n");

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
			return this.Equals(obj as ListWrapperAlternativeShiftBuSettingsGranularity);
		}

		/// <summary>
		/// Returns true if ListWrapperAlternativeShiftBuSettingsGranularity instances are equal
		/// </summary>
		/// <param name="other">Instance of ListWrapperAlternativeShiftBuSettingsGranularity to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ListWrapperAlternativeShiftBuSettingsGranularity other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
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
				if (this.Values != null)
					hash = hash * 59 + this.Values.GetHashCode();

				return hash;
			}
		}
	}

}
