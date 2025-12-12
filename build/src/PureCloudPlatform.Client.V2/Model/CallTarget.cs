using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CallTarget
	/// </summary>
	[DataContract]
	public partial class CallTarget : IEquatable<CallTarget>
	{
		/// <summary>
		/// The type of call
		/// </summary>
		/// <value>The type of call</value>
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
			/// Enum Station for "STATION"
			/// </summary>
			[EnumMember(Value = "STATION")]
			Station,

			/// <summary>
			/// Enum Phonenumber for "PHONENUMBER"
			/// </summary>
			[EnumMember(Value = "PHONENUMBER")]
			Phonenumber
		}
		/// <summary>
		/// The type of call
		/// </summary>
		/// <value>The type of call</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="CallTarget" /> class.
		/// </summary>
		/// <param name="Type">The type of call.</param>
		/// <param name="Value">The id of the station or an E.164 formatted phone number.</param>
		public CallTarget(TypeEnum? Type = null, string Value = null)
		{
			this.Type = Type;
			this.Value = Value;

		}





		/// <summary>
		/// The id of the station or an E.164 formatted phone number
		/// </summary>
		/// <value>The id of the station or an E.164 formatted phone number</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CallTarget {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return this.Equals(obj as CallTarget);
		}

		/// <summary>
		/// Returns true if CallTarget instances are equal
		/// </summary>
		/// <param name="other">Instance of CallTarget to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CallTarget other)
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
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
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

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				return hash;
			}
		}
	}

}
