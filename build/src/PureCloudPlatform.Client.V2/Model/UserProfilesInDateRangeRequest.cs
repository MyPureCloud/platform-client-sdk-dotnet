using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserProfilesInDateRangeRequest
	/// </summary>
	[DataContract]
	public partial class UserProfilesInDateRangeRequest : IEquatable<UserProfilesInDateRangeRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UserProfilesInDateRangeRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UserProfilesInDateRangeRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UserProfilesInDateRangeRequest" /> class.
		/// </summary>
		/// <param name="StartWorkday">Start work day in ISO-8601 format used in the date range. (required).</param>
		/// <param name="EndWorkday">End work day in ISO-8601 format used in the date range. (required).</param>
		public UserProfilesInDateRangeRequest(string StartWorkday = null, string EndWorkday = null)
		{
			this.StartWorkday = StartWorkday;
			this.EndWorkday = EndWorkday;

		}



		/// <summary>
		/// Start work day in ISO-8601 format used in the date range.
		/// </summary>
		/// <value>Start work day in ISO-8601 format used in the date range.</value>
		[DataMember(Name = "startWorkday", EmitDefaultValue = false)]
		public string StartWorkday { get; set; }



		/// <summary>
		/// End work day in ISO-8601 format used in the date range.
		/// </summary>
		/// <value>End work day in ISO-8601 format used in the date range.</value>
		[DataMember(Name = "endWorkday", EmitDefaultValue = false)]
		public string EndWorkday { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserProfilesInDateRangeRequest {\n");

			sb.Append("  StartWorkday: ").Append(StartWorkday).Append("\n");
			sb.Append("  EndWorkday: ").Append(EndWorkday).Append("\n");
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
			return this.Equals(obj as UserProfilesInDateRangeRequest);
		}

		/// <summary>
		/// Returns true if UserProfilesInDateRangeRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of UserProfilesInDateRangeRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserProfilesInDateRangeRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.StartWorkday == other.StartWorkday ||
					this.StartWorkday != null &&
					this.StartWorkday.Equals(other.StartWorkday)
				) &&
				(
					this.EndWorkday == other.EndWorkday ||
					this.EndWorkday != null &&
					this.EndWorkday.Equals(other.EndWorkday)
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
				if (this.StartWorkday != null)
					hash = hash * 59 + this.StartWorkday.GetHashCode();

				if (this.EndWorkday != null)
					hash = hash * 59 + this.EndWorkday.GetHashCode();

				return hash;
			}
		}
	}

}
