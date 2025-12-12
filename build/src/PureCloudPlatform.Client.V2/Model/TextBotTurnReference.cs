using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A reference to a bot flow turn.
	/// </summary>
	[DataContract]
	public partial class TextBotTurnReference : IEquatable<TextBotTurnReference>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="TextBotTurnReference" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TextBotTurnReference() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TextBotTurnReference" /> class.
		/// </summary>
		/// <param name="Id">The id of the turn. (required).</param>
		public TextBotTurnReference(string Id = null)
		{
			this.Id = Id;

		}



		/// <summary>
		/// The id of the turn.
		/// </summary>
		/// <value>The id of the turn.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TextBotTurnReference {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
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
			return this.Equals(obj as TextBotTurnReference);
		}

		/// <summary>
		/// Returns true if TextBotTurnReference instances are equal
		/// </summary>
		/// <param name="other">Instance of TextBotTurnReference to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TextBotTurnReference other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				return hash;
			}
		}
	}

}
