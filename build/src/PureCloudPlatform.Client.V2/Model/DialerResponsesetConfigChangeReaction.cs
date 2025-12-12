using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialerResponsesetConfigChangeReaction
	/// </summary>
	[DataContract]
	public partial class DialerResponsesetConfigChangeReaction : IEquatable<DialerResponsesetConfigChangeReaction>
	{
		/// <summary>
		/// Gets or Sets ReactionType
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ReactionTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Hangup for "hangup"
			/// </summary>
			[EnumMember(Value = "hangup")]
			Hangup,

			/// <summary>
			/// Enum Transfer for "transfer"
			/// </summary>
			[EnumMember(Value = "transfer")]
			Transfer,

			/// <summary>
			/// Enum TransferFlow for "transfer_flow"
			/// </summary>
			[EnumMember(Value = "transfer_flow")]
			TransferFlow,

			/// <summary>
			/// Enum PlayFile for "play_file"
			/// </summary>
			[EnumMember(Value = "play_file")]
			PlayFile
		}
		/// <summary>
		/// Gets or Sets ReactionType
		/// </summary>
		[DataMember(Name = "reactionType", EmitDefaultValue = false)]
		public ReactionTypeEnum? ReactionType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DialerResponsesetConfigChangeReaction" /> class.
		/// </summary>
		/// <param name="Data">Data.</param>
		/// <param name="Name">Name.</param>
		/// <param name="ReactionType">ReactionType.</param>
		/// <param name="AdditionalProperties">AdditionalProperties.</param>
		/// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
		public DialerResponsesetConfigChangeReaction(string Data = null, string Name = null, ReactionTypeEnum? ReactionType = null, Dictionary<string, Object> AdditionalProperties = null, Dictionary<string, Object> GetAdditionalProperties = null)
		{
			this.Data = Data;
			this.Name = Name;
			this.ReactionType = ReactionType;
			this.AdditionalProperties = AdditionalProperties;
			this.GetAdditionalProperties = GetAdditionalProperties;

		}



		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name = "data", EmitDefaultValue = false)]
		public string Data { get; set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }





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
			sb.Append("class DialerResponsesetConfigChangeReaction {\n");

			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ReactionType: ").Append(ReactionType).Append("\n");
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
			return this.Equals(obj as DialerResponsesetConfigChangeReaction);
		}

		/// <summary>
		/// Returns true if DialerResponsesetConfigChangeReaction instances are equal
		/// </summary>
		/// <param name="other">Instance of DialerResponsesetConfigChangeReaction to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialerResponsesetConfigChangeReaction other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Data == other.Data ||
					this.Data != null &&
					this.Data.Equals(other.Data)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.ReactionType == other.ReactionType ||
					this.ReactionType != null &&
					this.ReactionType.Equals(other.ReactionType)
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
				if (this.Data != null)
					hash = hash * 59 + this.Data.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.ReactionType != null)
					hash = hash * 59 + this.ReactionType.GetHashCode();

				if (this.AdditionalProperties != null)
					hash = hash * 59 + this.AdditionalProperties.GetHashCode();

				if (this.GetAdditionalProperties != null)
					hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

				return hash;
			}
		}
	}

}
