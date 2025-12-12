using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuAgentScheduleUpdate
	/// </summary>
	[DataContract]
	public partial class BuAgentScheduleUpdate : IEquatable<BuAgentScheduleUpdate>
	{
		/// <summary>
		/// The type of update
		/// </summary>
		/// <value>The type of update</value>
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
			/// Enum Added for "Added"
			/// </summary>
			[EnumMember(Value = "Added")]
			Added,

			/// <summary>
			/// Enum Edited for "Edited"
			/// </summary>
			[EnumMember(Value = "Edited")]
			Edited,

			/// <summary>
			/// Enum Deleted for "Deleted"
			/// </summary>
			[EnumMember(Value = "Deleted")]
			Deleted
		}
		/// <summary>
		/// The type of update
		/// </summary>
		/// <value>The type of update</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="BuAgentScheduleUpdate" /> class.
		/// </summary>
		/// <param name="Type">The type of update.</param>
		/// <param name="ShiftStartDates">The start date for the affected shifts.</param>
		public BuAgentScheduleUpdate(TypeEnum? Type = null, List<DateTime?> ShiftStartDates = null)
		{
			this.Type = Type;
			this.ShiftStartDates = ShiftStartDates;

		}





		/// <summary>
		/// The start date for the affected shifts
		/// </summary>
		/// <value>The start date for the affected shifts</value>
		[DataMember(Name = "shiftStartDates", EmitDefaultValue = false)]
		public List<DateTime?> ShiftStartDates { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BuAgentScheduleUpdate {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  ShiftStartDates: ").Append(ShiftStartDates).Append("\n");
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
			return this.Equals(obj as BuAgentScheduleUpdate);
		}

		/// <summary>
		/// Returns true if BuAgentScheduleUpdate instances are equal
		/// </summary>
		/// <param name="other">Instance of BuAgentScheduleUpdate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuAgentScheduleUpdate other)
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
					this.ShiftStartDates == other.ShiftStartDates ||
					this.ShiftStartDates != null &&
					this.ShiftStartDates.SequenceEqual(other.ShiftStartDates)
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

				if (this.ShiftStartDates != null)
					hash = hash * 59 + this.ShiftStartDates.GetHashCode();

				return hash;
			}
		}
	}

}
