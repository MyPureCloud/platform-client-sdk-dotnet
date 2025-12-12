using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DraftManipulationRequest
	/// </summary>
	[DataContract]
	public partial class DraftManipulationRequest : IEquatable<DraftManipulationRequest>
	{
		/// <summary>
		/// The kind of draft that as to be treated. Used to prefix response subject or auto-include information
		/// </summary>
		/// <value>The kind of draft that as to be treated. Used to prefix response subject or auto-include information</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DraftTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Reply for "Reply"
			/// </summary>
			[EnumMember(Value = "Reply")]
			Reply,

			/// <summary>
			/// Enum Replyall for "ReplyAll"
			/// </summary>
			[EnumMember(Value = "ReplyAll")]
			Replyall,

			/// <summary>
			/// Enum Forward for "Forward"
			/// </summary>
			[EnumMember(Value = "Forward")]
			Forward
		}
		/// <summary>
		/// The kind of draft that as to be treated. Used to prefix response subject or auto-include information
		/// </summary>
		/// <value>The kind of draft that as to be treated. Used to prefix response subject or auto-include information</value>
		[DataMember(Name = "draftType", EmitDefaultValue = false)]
		public DraftTypeEnum? DraftType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DraftManipulationRequest" /> class.
		/// </summary>
		/// <param name="Translate">A set of definitions to translate email attributes and correctly display date and time, for a given language.</param>
		/// <param name="DraftType">The kind of draft that as to be treated. Used to prefix response subject or auto-include information.</param>
		public DraftManipulationRequest(HistoryHeadersTranslation Translate = null, DraftTypeEnum? DraftType = null)
		{
			this.Translate = Translate;
			this.DraftType = DraftType;

		}



		/// <summary>
		/// A set of definitions to translate email attributes and correctly display date and time, for a given language
		/// </summary>
		/// <value>A set of definitions to translate email attributes and correctly display date and time, for a given language</value>
		[DataMember(Name = "translate", EmitDefaultValue = false)]
		public HistoryHeadersTranslation Translate { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DraftManipulationRequest {\n");

			sb.Append("  Translate: ").Append(Translate).Append("\n");
			sb.Append("  DraftType: ").Append(DraftType).Append("\n");
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
			return this.Equals(obj as DraftManipulationRequest);
		}

		/// <summary>
		/// Returns true if DraftManipulationRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of DraftManipulationRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DraftManipulationRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Translate == other.Translate ||
					this.Translate != null &&
					this.Translate.Equals(other.Translate)
				) &&
				(
					this.DraftType == other.DraftType ||
					this.DraftType != null &&
					this.DraftType.Equals(other.DraftType)
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
				if (this.Translate != null)
					hash = hash * 59 + this.Translate.GetHashCode();

				if (this.DraftType != null)
					hash = hash * 59 + this.DraftType.GetHashCode();

				return hash;
			}
		}
	}

}
