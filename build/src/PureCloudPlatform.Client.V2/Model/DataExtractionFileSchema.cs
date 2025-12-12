using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DataExtractionFileSchema
	/// </summary>
	[DataContract]
	public partial class DataExtractionFileSchema : IEquatable<DataExtractionFileSchema>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DataExtractionFileSchema" /> class.
		/// </summary>
		/// <param name="Id">The unique identifier for the file.</param>
		/// <param name="DataSchema">The data schema the file belongs to.</param>
		/// <param name="DateCreated">The date and time when this file was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateExpires">The date and time when this file becomes unavailable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public DataExtractionFileSchema(string Id = null, string DataSchema = null, DateTime? DateCreated = null, DateTime? DateExpires = null)
		{
			this.Id = Id;
			this.DataSchema = DataSchema;
			this.DateCreated = DateCreated;
			this.DateExpires = DateExpires;

		}



		/// <summary>
		/// The unique identifier for the file
		/// </summary>
		/// <value>The unique identifier for the file</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The data schema the file belongs to
		/// </summary>
		/// <value>The data schema the file belongs to</value>
		[DataMember(Name = "dataSchema", EmitDefaultValue = false)]
		public string DataSchema { get; set; }



		/// <summary>
		/// The date and time when this file was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date and time when this file was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// The date and time when this file becomes unavailable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date and time when this file becomes unavailable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateExpires", EmitDefaultValue = false)]
		public DateTime? DateExpires { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DataExtractionFileSchema {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  DataSchema: ").Append(DataSchema).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
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
			return this.Equals(obj as DataExtractionFileSchema);
		}

		/// <summary>
		/// Returns true if DataExtractionFileSchema instances are equal
		/// </summary>
		/// <param name="other">Instance of DataExtractionFileSchema to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DataExtractionFileSchema other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.DataSchema == other.DataSchema ||
					this.DataSchema != null &&
					this.DataSchema.Equals(other.DataSchema)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateExpires == other.DateExpires ||
					this.DateExpires != null &&
					this.DateExpires.Equals(other.DateExpires)
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

				if (this.DataSchema != null)
					hash = hash * 59 + this.DataSchema.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateExpires != null)
					hash = hash * 59 + this.DateExpires.GetHashCode();

				return hash;
			}
		}
	}

}
