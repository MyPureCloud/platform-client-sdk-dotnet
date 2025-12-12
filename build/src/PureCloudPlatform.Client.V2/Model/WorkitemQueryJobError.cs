using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkitemQueryJobError
	/// </summary>
	[DataContract]
	public partial class WorkitemQueryJobError : IEquatable<WorkitemQueryJobError>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemQueryJobError" /> class.
		/// </summary>
		/// <param name="Code">System defined error code for the error..</param>
		/// <param name="Message">Error message for the failed job..</param>
		public WorkitemQueryJobError(string Code = null, string Message = null)
		{
			this.Code = Code;
			this.Message = Message;

		}



		/// <summary>
		/// System defined error code for the error.
		/// </summary>
		/// <value>System defined error code for the error.</value>
		[DataMember(Name = "code", EmitDefaultValue = false)]
		public string Code { get; set; }



		/// <summary>
		/// Error message for the failed job.
		/// </summary>
		/// <value>Error message for the failed job.</value>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string Message { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkitemQueryJobError {\n");

			sb.Append("  Code: ").Append(Code).Append("\n");
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
			return this.Equals(obj as WorkitemQueryJobError);
		}

		/// <summary>
		/// Returns true if WorkitemQueryJobError instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkitemQueryJobError to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkitemQueryJobError other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Code == other.Code ||
					this.Code != null &&
					this.Code.Equals(other.Code)
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
				if (this.Code != null)
					hash = hash * 59 + this.Code.GetHashCode();

				if (this.Message != null)
					hash = hash * 59 + this.Message.GetHashCode();

				return hash;
			}
		}
	}

}
