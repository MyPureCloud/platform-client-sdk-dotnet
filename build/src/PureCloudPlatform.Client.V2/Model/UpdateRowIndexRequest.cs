using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UpdateRowIndexRequest
	/// </summary>
	[DataContract]
	public partial class UpdateRowIndexRequest : IEquatable<UpdateRowIndexRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateRowIndexRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UpdateRowIndexRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateRowIndexRequest" /> class.
		/// </summary>
		/// <param name="RowId">The row UUID. (required).</param>
		/// <param name="RowIndex">The updated row index. Must be an integer value greater than or equal to 1. Must be less than or equal to x, where x is the number of rows in the decision table version. (required).</param>
		public UpdateRowIndexRequest(string RowId = null, int? RowIndex = null)
		{
			this.RowId = RowId;
			this.RowIndex = RowIndex;

		}



		/// <summary>
		/// The row UUID.
		/// </summary>
		/// <value>The row UUID.</value>
		[DataMember(Name = "rowId", EmitDefaultValue = false)]
		public string RowId { get; set; }



		/// <summary>
		/// The updated row index. Must be an integer value greater than or equal to 1. Must be less than or equal to x, where x is the number of rows in the decision table version.
		/// </summary>
		/// <value>The updated row index. Must be an integer value greater than or equal to 1. Must be less than or equal to x, where x is the number of rows in the decision table version.</value>
		[DataMember(Name = "rowIndex", EmitDefaultValue = false)]
		public int? RowIndex { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateRowIndexRequest {\n");

			sb.Append("  RowId: ").Append(RowId).Append("\n");
			sb.Append("  RowIndex: ").Append(RowIndex).Append("\n");
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
			return this.Equals(obj as UpdateRowIndexRequest);
		}

		/// <summary>
		/// Returns true if UpdateRowIndexRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateRowIndexRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateRowIndexRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.RowId == other.RowId ||
					this.RowId != null &&
					this.RowId.Equals(other.RowId)
				) &&
				(
					this.RowIndex == other.RowIndex ||
					this.RowIndex != null &&
					this.RowIndex.Equals(other.RowIndex)
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
				if (this.RowId != null)
					hash = hash * 59 + this.RowId.GetHashCode();

				if (this.RowIndex != null)
					hash = hash * 59 + this.RowIndex.GetHashCode();

				return hash;
			}
		}
	}

}
