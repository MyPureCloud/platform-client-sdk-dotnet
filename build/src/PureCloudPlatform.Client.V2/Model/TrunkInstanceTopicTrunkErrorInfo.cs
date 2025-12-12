using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TrunkInstanceTopicTrunkErrorInfo
	/// </summary>
	[DataContract]
	public partial class TrunkInstanceTopicTrunkErrorInfo : IEquatable<TrunkInstanceTopicTrunkErrorInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TrunkInstanceTopicTrunkErrorInfo" /> class.
		/// </summary>
		/// <param name="Text">Text.</param>
		/// <param name="Code">Code.</param>
		/// <param name="Details">Details.</param>
		public TrunkInstanceTopicTrunkErrorInfo(string Text = null, string Code = null, TrunkInstanceTopicTrunkErrorInfoDetails Details = null)
		{
			this.Text = Text;
			this.Code = Code;
			this.Details = Details;

		}



		/// <summary>
		/// Gets or Sets Text
		/// </summary>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; set; }



		/// <summary>
		/// Gets or Sets Code
		/// </summary>
		[DataMember(Name = "code", EmitDefaultValue = false)]
		public string Code { get; set; }



		/// <summary>
		/// Gets or Sets Details
		/// </summary>
		[DataMember(Name = "details", EmitDefaultValue = false)]
		public TrunkInstanceTopicTrunkErrorInfoDetails Details { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TrunkInstanceTopicTrunkErrorInfo {\n");

			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  Code: ").Append(Code).Append("\n");
			sb.Append("  Details: ").Append(Details).Append("\n");
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
			return this.Equals(obj as TrunkInstanceTopicTrunkErrorInfo);
		}

		/// <summary>
		/// Returns true if TrunkInstanceTopicTrunkErrorInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of TrunkInstanceTopicTrunkErrorInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TrunkInstanceTopicTrunkErrorInfo other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) &&
				(
					this.Code == other.Code ||
					this.Code != null &&
					this.Code.Equals(other.Code)
				) &&
				(
					this.Details == other.Details ||
					this.Details != null &&
					this.Details.Equals(other.Details)
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
				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.Code != null)
					hash = hash * 59 + this.Code.GetHashCode();

				if (this.Details != null)
					hash = hash * 59 + this.Details.GetHashCode();

				return hash;
			}
		}
	}

}
