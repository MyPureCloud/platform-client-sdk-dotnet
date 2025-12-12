using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Term
	/// </summary>
	[DataContract]
	public partial class Term : IEquatable<Term>
	{
		/// <summary>
		/// Dictates if term operand must come from the internal, external or both participants
		/// </summary>
		/// <value>Dictates if term operand must come from the internal, external or both participants</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ParticipantTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Internal for "Internal"
			/// </summary>
			[EnumMember(Value = "Internal")]
			Internal,

			/// <summary>
			/// Enum External for "External"
			/// </summary>
			[EnumMember(Value = "External")]
			External,

			/// <summary>
			/// Enum Both for "Both"
			/// </summary>
			[EnumMember(Value = "Both")]
			Both
		}
		/// <summary>
		/// Dictates if term operand must come from the internal, external or both participants
		/// </summary>
		/// <value>Dictates if term operand must come from the internal, external or both participants</value>
		[DataMember(Name = "participantType", EmitDefaultValue = false)]
		public ParticipantTypeEnum? ParticipantType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Term" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Term() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Term" /> class.
		/// </summary>
		/// <param name="Word">Find term in interaction (required).</param>
		/// <param name="ParticipantType">Dictates if term operand must come from the internal, external or both participants (required).</param>
		public Term(string Word = null, ParticipantTypeEnum? ParticipantType = null)
		{
			this.Word = Word;
			this.ParticipantType = ParticipantType;

		}



		/// <summary>
		/// Find term in interaction
		/// </summary>
		/// <value>Find term in interaction</value>
		[DataMember(Name = "word", EmitDefaultValue = false)]
		public string Word { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Term {\n");

			sb.Append("  Word: ").Append(Word).Append("\n");
			sb.Append("  ParticipantType: ").Append(ParticipantType).Append("\n");
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
			return this.Equals(obj as Term);
		}

		/// <summary>
		/// Returns true if Term instances are equal
		/// </summary>
		/// <param name="other">Instance of Term to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Term other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Word == other.Word ||
					this.Word != null &&
					this.Word.Equals(other.Word)
				) &&
				(
					this.ParticipantType == other.ParticipantType ||
					this.ParticipantType != null &&
					this.ParticipantType.Equals(other.ParticipantType)
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
				if (this.Word != null)
					hash = hash * 59 + this.Word.GetHashCode();

				if (this.ParticipantType != null)
					hash = hash * 59 + this.ParticipantType.GetHashCode();

				return hash;
			}
		}
	}

}
