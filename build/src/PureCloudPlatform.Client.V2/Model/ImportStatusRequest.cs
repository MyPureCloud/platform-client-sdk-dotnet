using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ImportStatusRequest
	/// </summary>
	[DataContract]
	public partial class ImportStatusRequest : IEquatable<ImportStatusRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ImportStatusRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ImportStatusRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ImportStatusRequest" /> class.
		/// </summary>
		/// <param name="Status">New status for existing import operation (required).</param>
		public ImportStatusRequest(string Status = null)
		{
			this.Status = Status;

		}



		/// <summary>
		/// New status for existing import operation
		/// </summary>
		/// <value>New status for existing import operation</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string Status { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ImportStatusRequest {\n");

			sb.Append("  Status: ").Append(Status).Append("\n");
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
			return this.Equals(obj as ImportStatusRequest);
		}

		/// <summary>
		/// Returns true if ImportStatusRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of ImportStatusRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ImportStatusRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
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
				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				return hash;
			}
		}
	}

}
