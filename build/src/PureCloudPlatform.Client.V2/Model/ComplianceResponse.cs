using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ComplianceResponse
	/// </summary>
	[DataContract]
	public partial class ComplianceResponse : IEquatable<ComplianceResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ComplianceResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ComplianceResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ComplianceResponse" /> class.
		/// </summary>
		/// <param name="Message">Message response (required).</param>
		public ComplianceResponse(string Message = null)
		{
			this.Message = Message;

		}



		/// <summary>
		/// Message response
		/// </summary>
		/// <value>Message response</value>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string Message { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ComplianceResponse {\n");

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
			return this.Equals(obj as ComplianceResponse);
		}

		/// <summary>
		/// Returns true if ComplianceResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of ComplianceResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ComplianceResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
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
				if (this.Message != null)
					hash = hash * 59 + this.Message.GetHashCode();

				return hash;
			}
		}
	}

}
