using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RecurrencePeriod
	/// </summary>
	[DataContract]
	public partial class RecurrencePeriod : IEquatable<RecurrencePeriod>
	{
		/// <summary>
		/// The granularity unit to interpret the period of this activity plan
		/// </summary>
		/// <value>The granularity unit to interpret the period of this activity plan</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum GranularityEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Days for "Days"
			/// </summary>
			[EnumMember(Value = "Days")]
			Days,

			/// <summary>
			/// Enum Weeks for "Weeks"
			/// </summary>
			[EnumMember(Value = "Weeks")]
			Weeks
		}
		/// <summary>
		/// The granularity unit to interpret the period of this activity plan
		/// </summary>
		/// <value>The granularity unit to interpret the period of this activity plan</value>
		[DataMember(Name = "granularity", EmitDefaultValue = false)]
		public GranularityEnum? Granularity { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="RecurrencePeriod" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected RecurrencePeriod() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="RecurrencePeriod" /> class.
		/// </summary>
		/// <param name="Magnitude">The period of the activity plan in granularity units (required).</param>
		/// <param name="Granularity">The granularity unit to interpret the period of this activity plan (required).</param>
		public RecurrencePeriod(int? Magnitude = null, GranularityEnum? Granularity = null)
		{
			this.Magnitude = Magnitude;
			this.Granularity = Granularity;

		}



		/// <summary>
		/// The period of the activity plan in granularity units
		/// </summary>
		/// <value>The period of the activity plan in granularity units</value>
		[DataMember(Name = "magnitude", EmitDefaultValue = false)]
		public int? Magnitude { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RecurrencePeriod {\n");

			sb.Append("  Magnitude: ").Append(Magnitude).Append("\n");
			sb.Append("  Granularity: ").Append(Granularity).Append("\n");
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
			return this.Equals(obj as RecurrencePeriod);
		}

		/// <summary>
		/// Returns true if RecurrencePeriod instances are equal
		/// </summary>
		/// <param name="other">Instance of RecurrencePeriod to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RecurrencePeriod other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Magnitude == other.Magnitude ||
					this.Magnitude != null &&
					this.Magnitude.Equals(other.Magnitude)
				) &&
				(
					this.Granularity == other.Granularity ||
					this.Granularity != null &&
					this.Granularity.Equals(other.Granularity)
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
				if (this.Magnitude != null)
					hash = hash * 59 + this.Magnitude.GetHashCode();

				if (this.Granularity != null)
					hash = hash * 59 + this.Granularity.GetHashCode();

				return hash;
			}
		}
	}

}
