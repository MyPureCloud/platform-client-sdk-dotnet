using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AlertablePresences
	/// </summary>
	[DataContract]
	public partial class AlertablePresences : IEquatable<AlertablePresences>
	{
		/// <summary>
		/// Gets or Sets AlertablePresences
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum AlertablePresencesEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Available for "Available"
			/// </summary>
			[EnumMember(Value = "Available")]
			Available,

			/// <summary>
			/// Enum Away for "Away"
			/// </summary>
			[EnumMember(Value = "Away")]
			Away,

			/// <summary>
			/// Enum Busy for "Busy"
			/// </summary>
			[EnumMember(Value = "Busy")]
			Busy,

			/// <summary>
			/// Enum Offline for "Offline"
			/// </summary>
			[EnumMember(Value = "Offline")]
			Offline,

			/// <summary>
			/// Enum Idle for "Idle"
			/// </summary>
			[EnumMember(Value = "Idle")]
			Idle,

			/// <summary>
			/// Enum Onqueue for "OnQueue"
			/// </summary>
			[EnumMember(Value = "OnQueue")]
			Onqueue,

			/// <summary>
			/// Enum Meal for "Meal"
			/// </summary>
			[EnumMember(Value = "Meal")]
			Meal,

			/// <summary>
			/// Enum Training for "Training"
			/// </summary>
			[EnumMember(Value = "Training")]
			Training,

			/// <summary>
			/// Enum Meeting for "Meeting"
			/// </summary>
			[EnumMember(Value = "Meeting")]
			Meeting,

			/// <summary>
			/// Enum Break for "Break"
			/// </summary>
			[EnumMember(Value = "Break")]
			Break
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AlertablePresences" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AlertablePresences() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AlertablePresences" /> class.
		/// </summary>
		/// <param name="_AlertablePresences">The list of alertable system presences. (required).</param>
		public AlertablePresences(List<AlertablePresencesEnum> _AlertablePresences = null)
		{
			this._AlertablePresences = _AlertablePresences;

		}



		/// <summary>
		/// The list of alertable system presences.
		/// </summary>
		/// <value>The list of alertable system presences.</value>
		[DataMember(Name = "alertablePresences", EmitDefaultValue = false)]
		public List<AlertablePresencesEnum> _AlertablePresences { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlertablePresences {\n");

			sb.Append("  _AlertablePresences: ").Append(_AlertablePresences).Append("\n");
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
			return this.Equals(obj as AlertablePresences);
		}

		/// <summary>
		/// Returns true if AlertablePresences instances are equal
		/// </summary>
		/// <param name="other">Instance of AlertablePresences to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AlertablePresences other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this._AlertablePresences == other._AlertablePresences ||
					this._AlertablePresences != null &&
					this._AlertablePresences.SequenceEqual(other._AlertablePresences)
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
				if (this._AlertablePresences != null)
					hash = hash * 59 + this._AlertablePresences.GetHashCode();

				return hash;
			}
		}
	}

}
