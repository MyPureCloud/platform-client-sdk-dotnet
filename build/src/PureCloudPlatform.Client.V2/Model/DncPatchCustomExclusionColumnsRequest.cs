using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DncPatchCustomExclusionColumnsRequest
	/// </summary>
	[DataContract]
	public partial class DncPatchCustomExclusionColumnsRequest : IEquatable<DncPatchCustomExclusionColumnsRequest>
	{
		/// <summary>
		/// The action to perform
		/// </summary>
		/// <value>The action to perform</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ActionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Add for "Add"
			/// </summary>
			[EnumMember(Value = "Add")]
			Add,

			/// <summary>
			/// Enum Remove for "Remove"
			/// </summary>
			[EnumMember(Value = "Remove")]
			Remove
		}
		/// <summary>
		/// The action to perform
		/// </summary>
		/// <value>The action to perform</value>
		[DataMember(Name = "action", EmitDefaultValue = false)]
		public ActionEnum? Action { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DncPatchCustomExclusionColumnsRequest" /> class.
		/// </summary>
		/// <param name="Action">The action to perform.</param>
		/// <param name="CustomExclusionColumnEntries">The list of custom exclusion column entries to Add to / Remove from the DNC list .</param>
		/// <param name="ExpirationDateTime">Expiration date for DNC customExclusionColumnEntries in yyyy-MM-ddTHH:mmZ format.</param>
		public DncPatchCustomExclusionColumnsRequest(ActionEnum? Action = null, List<string> CustomExclusionColumnEntries = null, string ExpirationDateTime = null)
		{
			this.Action = Action;
			this.CustomExclusionColumnEntries = CustomExclusionColumnEntries;
			this.ExpirationDateTime = ExpirationDateTime;

		}





		/// <summary>
		/// The list of custom exclusion column entries to Add to / Remove from the DNC list 
		/// </summary>
		/// <value>The list of custom exclusion column entries to Add to / Remove from the DNC list </value>
		[DataMember(Name = "customExclusionColumnEntries", EmitDefaultValue = false)]
		public List<string> CustomExclusionColumnEntries { get; set; }



		/// <summary>
		/// Expiration date for DNC customExclusionColumnEntries in yyyy-MM-ddTHH:mmZ format
		/// </summary>
		/// <value>Expiration date for DNC customExclusionColumnEntries in yyyy-MM-ddTHH:mmZ format</value>
		[DataMember(Name = "expirationDateTime", EmitDefaultValue = false)]
		public string ExpirationDateTime { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DncPatchCustomExclusionColumnsRequest {\n");

			sb.Append("  Action: ").Append(Action).Append("\n");
			sb.Append("  CustomExclusionColumnEntries: ").Append(CustomExclusionColumnEntries).Append("\n");
			sb.Append("  ExpirationDateTime: ").Append(ExpirationDateTime).Append("\n");
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
			return this.Equals(obj as DncPatchCustomExclusionColumnsRequest);
		}

		/// <summary>
		/// Returns true if DncPatchCustomExclusionColumnsRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of DncPatchCustomExclusionColumnsRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DncPatchCustomExclusionColumnsRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Action == other.Action ||
					this.Action != null &&
					this.Action.Equals(other.Action)
				) &&
				(
					this.CustomExclusionColumnEntries == other.CustomExclusionColumnEntries ||
					this.CustomExclusionColumnEntries != null &&
					this.CustomExclusionColumnEntries.SequenceEqual(other.CustomExclusionColumnEntries)
				) &&
				(
					this.ExpirationDateTime == other.ExpirationDateTime ||
					this.ExpirationDateTime != null &&
					this.ExpirationDateTime.Equals(other.ExpirationDateTime)
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
				if (this.Action != null)
					hash = hash * 59 + this.Action.GetHashCode();

				if (this.CustomExclusionColumnEntries != null)
					hash = hash * 59 + this.CustomExclusionColumnEntries.GetHashCode();

				if (this.ExpirationDateTime != null)
					hash = hash * 59 + this.ExpirationDateTime.GetHashCode();

				return hash;
			}
		}
	}

}
