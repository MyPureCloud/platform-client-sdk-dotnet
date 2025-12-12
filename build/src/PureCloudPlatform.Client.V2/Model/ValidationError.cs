using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ValidationError
	/// </summary>
	[DataContract]
	public partial class ValidationError : IEquatable<ValidationError>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ValidationError" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ValidationError() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ValidationError" /> class.
		/// </summary>
		/// <param name="LineNumber">Line number for the error in CSV (required).</param>
		/// <param name="Message">Detail of the error in CSV (required).</param>
		public ValidationError(long? LineNumber = null, string Message = null)
		{
			this.LineNumber = LineNumber;
			this.Message = Message;

		}



		/// <summary>
		/// Line number for the error in CSV
		/// </summary>
		/// <value>Line number for the error in CSV</value>
		[DataMember(Name = "lineNumber", EmitDefaultValue = false)]
		public long? LineNumber { get; set; }



		/// <summary>
		/// Detail of the error in CSV
		/// </summary>
		/// <value>Detail of the error in CSV</value>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string Message { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ValidationError {\n");

			sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
			sb.Append("  Message: ").Append(Message).Append("\n");
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
			return this.Equals(obj as ValidationError);
		}

		/// <summary>
		/// Returns true if ValidationError instances are equal
		/// </summary>
		/// <param name="other">Instance of ValidationError to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ValidationError other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.LineNumber == other.LineNumber ||
					this.LineNumber != null &&
					this.LineNumber.Equals(other.LineNumber)
				) &&
				(
					this.Message == other.Message ||
					this.Message != null &&
					this.Message.Equals(other.Message)
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
				if (this.LineNumber != null)
					hash = hash * 59 + this.LineNumber.GetHashCode();

				if (this.Message != null)
					hash = hash * 59 + this.Message.GetHashCode();

				return hash;
			}
		}
	}

}
