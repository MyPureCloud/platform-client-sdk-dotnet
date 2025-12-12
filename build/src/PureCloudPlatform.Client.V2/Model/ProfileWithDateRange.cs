using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ProfileWithDateRange
	/// </summary>
	[DataContract]
	public partial class ProfileWithDateRange : IEquatable<ProfileWithDateRange>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProfileWithDateRange" /> class.
		/// </summary>
		/// <param name="Id">Profile ID.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Division">The division to which this entity belongs..</param>
		/// <param name="DateStartWorkday">Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="DateEndWorkday">End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		public ProfileWithDateRange(string Id = null, string Name = null, Division Division = null, String DateStartWorkday = null, String DateEndWorkday = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Division = Division;
			this.DateStartWorkday = DateStartWorkday;
			this.DateEndWorkday = DateEndWorkday;

		}



		/// <summary>
		/// Profile ID
		/// </summary>
		/// <value>Profile ID</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The division to which this entity belongs.
		/// </summary>
		/// <value>The division to which this entity belongs.</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public Division Division { get; set; }



		/// <summary>
		/// Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateStartWorkday", EmitDefaultValue = false)]
		public String DateStartWorkday { get; set; }



		/// <summary>
		/// End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateEndWorkday", EmitDefaultValue = false)]
		public String DateEndWorkday { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProfileWithDateRange {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
			sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as ProfileWithDateRange);
		}

		/// <summary>
		/// Returns true if ProfileWithDateRange instances are equal
		/// </summary>
		/// <param name="other">Instance of ProfileWithDateRange to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ProfileWithDateRange other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.DateStartWorkday == other.DateStartWorkday ||
					this.DateStartWorkday != null &&
					this.DateStartWorkday.Equals(other.DateStartWorkday)
				) &&
				(
					this.DateEndWorkday == other.DateEndWorkday ||
					this.DateEndWorkday != null &&
					this.DateEndWorkday.Equals(other.DateEndWorkday)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.DateStartWorkday != null)
					hash = hash * 59 + this.DateStartWorkday.GetHashCode();

				if (this.DateEndWorkday != null)
					hash = hash * 59 + this.DateEndWorkday.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
