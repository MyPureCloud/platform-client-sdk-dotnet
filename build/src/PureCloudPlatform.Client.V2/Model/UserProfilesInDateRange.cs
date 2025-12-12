using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserProfilesInDateRange
	/// </summary>
	[DataContract]
	public partial class UserProfilesInDateRange : IEquatable<UserProfilesInDateRange>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserProfilesInDateRange" /> class.
		/// </summary>
		/// <param name="User">The query agent.</param>
		/// <param name="DateStartWorkday">Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="DateEndWorkday">End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="Profiles">The list of profiles of the agent.</param>
		public UserProfilesInDateRange(UserReference User = null, String DateStartWorkday = null, String DateEndWorkday = null, List<ProfileWithDateRange> Profiles = null)
		{
			this.User = User;
			this.DateStartWorkday = DateStartWorkday;
			this.DateEndWorkday = DateEndWorkday;
			this.Profiles = Profiles;

		}



		/// <summary>
		/// The query agent
		/// </summary>
		/// <value>The query agent</value>
		[DataMember(Name = "user", EmitDefaultValue = false)]
		public UserReference User { get; set; }



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
		/// The list of profiles of the agent
		/// </summary>
		/// <value>The list of profiles of the agent</value>
		[DataMember(Name = "profiles", EmitDefaultValue = false)]
		public List<ProfileWithDateRange> Profiles { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserProfilesInDateRange {\n");

			sb.Append("  User: ").Append(User).Append("\n");
			sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
			sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
			sb.Append("  Profiles: ").Append(Profiles).Append("\n");
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
			return this.Equals(obj as UserProfilesInDateRange);
		}

		/// <summary>
		/// Returns true if UserProfilesInDateRange instances are equal
		/// </summary>
		/// <param name="other">Instance of UserProfilesInDateRange to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserProfilesInDateRange other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.User == other.User ||
					this.User != null &&
					this.User.Equals(other.User)
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
					this.Profiles == other.Profiles ||
					this.Profiles != null &&
					this.Profiles.SequenceEqual(other.Profiles)
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
				if (this.User != null)
					hash = hash * 59 + this.User.GetHashCode();

				if (this.DateStartWorkday != null)
					hash = hash * 59 + this.DateStartWorkday.GetHashCode();

				if (this.DateEndWorkday != null)
					hash = hash * 59 + this.DateEndWorkday.GetHashCode();

				if (this.Profiles != null)
					hash = hash * 59 + this.Profiles.GetHashCode();

				return hash;
			}
		}
	}

}
