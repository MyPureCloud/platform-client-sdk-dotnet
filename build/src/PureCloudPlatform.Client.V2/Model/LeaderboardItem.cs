using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LeaderboardItem
	/// </summary>
	[DataContract]
	public partial class LeaderboardItem : IEquatable<LeaderboardItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LeaderboardItem" /> class.
		/// </summary>
		public LeaderboardItem()
		{

		}



		/// <summary>
		/// The user object for this leaderboard rank
		/// </summary>
		/// <value>The user object for this leaderboard rank</value>
		[DataMember(Name = "user", EmitDefaultValue = false)]
		public UserReference User { get; private set; }



		/// <summary>
		/// The rank of the user
		/// </summary>
		/// <value>The rank of the user</value>
		[DataMember(Name = "rank", EmitDefaultValue = false)]
		public int? Rank { get; private set; }



		/// <summary>
		/// The points collected by the user
		/// </summary>
		/// <value>The points collected by the user</value>
		[DataMember(Name = "points", EmitDefaultValue = false)]
		public long? Points { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LeaderboardItem {\n");

			sb.Append("  User: ").Append(User).Append("\n");
			sb.Append("  Rank: ").Append(Rank).Append("\n");
			sb.Append("  Points: ").Append(Points).Append("\n");
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
			return this.Equals(obj as LeaderboardItem);
		}

		/// <summary>
		/// Returns true if LeaderboardItem instances are equal
		/// </summary>
		/// <param name="other">Instance of LeaderboardItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LeaderboardItem other)
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
					this.Rank == other.Rank ||
					this.Rank != null &&
					this.Rank.Equals(other.Rank)
				) &&
				(
					this.Points == other.Points ||
					this.Points != null &&
					this.Points.Equals(other.Points)
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

				if (this.Rank != null)
					hash = hash * 59 + this.Rank.GetHashCode();

				if (this.Points != null)
					hash = hash * 59 + this.Points.GetHashCode();

				return hash;
			}
		}
	}

}
