using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PersistentConnectionChangeTopicErrorInfo
	/// </summary>
	[DataContract]
	public partial class PersistentConnectionChangeTopicErrorInfo : IEquatable<PersistentConnectionChangeTopicErrorInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PersistentConnectionChangeTopicErrorInfo" /> class.
		/// </summary>
		/// <param name="Text">Text.</param>
		/// <param name="Code">Code.</param>
		/// <param name="UserMessage">UserMessage.</param>
		/// <param name="UserParams">UserParams.</param>
		/// <param name="NestedErrorDetails">NestedErrorDetails.</param>
		public PersistentConnectionChangeTopicErrorInfo(string Text = null, string Code = null, string UserMessage = null, Dictionary<string, string> UserParams = null, List<PersistentConnectionChangeTopicErrorInfoDetails> NestedErrorDetails = null)
		{
			this.Text = Text;
			this.Code = Code;
			this.UserMessage = UserMessage;
			this.UserParams = UserParams;
			this.NestedErrorDetails = NestedErrorDetails;

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
		/// Gets or Sets UserMessage
		/// </summary>
		[DataMember(Name = "userMessage", EmitDefaultValue = false)]
		public string UserMessage { get; set; }



		/// <summary>
		/// Gets or Sets UserParams
		/// </summary>
		[DataMember(Name = "userParams", EmitDefaultValue = false)]
		public Dictionary<string, string> UserParams { get; set; }



		/// <summary>
		/// Gets or Sets NestedErrorDetails
		/// </summary>
		[DataMember(Name = "nestedErrorDetails", EmitDefaultValue = false)]
		public List<PersistentConnectionChangeTopicErrorInfoDetails> NestedErrorDetails { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PersistentConnectionChangeTopicErrorInfo {\n");

			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  Code: ").Append(Code).Append("\n");
			sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
			sb.Append("  UserParams: ").Append(UserParams).Append("\n");
			sb.Append("  NestedErrorDetails: ").Append(NestedErrorDetails).Append("\n");
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
			return this.Equals(obj as PersistentConnectionChangeTopicErrorInfo);
		}

		/// <summary>
		/// Returns true if PersistentConnectionChangeTopicErrorInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of PersistentConnectionChangeTopicErrorInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PersistentConnectionChangeTopicErrorInfo other)
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
					this.UserMessage == other.UserMessage ||
					this.UserMessage != null &&
					this.UserMessage.Equals(other.UserMessage)
				) &&
				(
					this.UserParams == other.UserParams ||
					this.UserParams != null &&
					this.UserParams.SequenceEqual(other.UserParams)
				) &&
				(
					this.NestedErrorDetails == other.NestedErrorDetails ||
					this.NestedErrorDetails != null &&
					this.NestedErrorDetails.SequenceEqual(other.NestedErrorDetails)
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

				if (this.UserMessage != null)
					hash = hash * 59 + this.UserMessage.GetHashCode();

				if (this.UserParams != null)
					hash = hash * 59 + this.UserParams.GetHashCode();

				if (this.NestedErrorDetails != null)
					hash = hash * 59 + this.NestedErrorDetails.GetHashCode();

				return hash;
			}
		}
	}

}
