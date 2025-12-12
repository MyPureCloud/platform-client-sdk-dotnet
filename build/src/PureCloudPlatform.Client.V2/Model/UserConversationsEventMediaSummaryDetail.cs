using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserConversationsEventMediaSummaryDetail
	/// </summary>
	[DataContract]
	public partial class UserConversationsEventMediaSummaryDetail : IEquatable<UserConversationsEventMediaSummaryDetail>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserConversationsEventMediaSummaryDetail" /> class.
		/// </summary>
		/// <param name="Active">Active.</param>
		/// <param name="Acw">Acw.</param>
		public UserConversationsEventMediaSummaryDetail(long? Active = null, long? Acw = null)
		{
			this.Active = Active;
			this.Acw = Acw;

		}



		/// <summary>
		/// Gets or Sets Active
		/// </summary>
		[DataMember(Name = "active", EmitDefaultValue = false)]
		public long? Active { get; set; }



		/// <summary>
		/// Gets or Sets Acw
		/// </summary>
		[DataMember(Name = "acw", EmitDefaultValue = false)]
		public long? Acw { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserConversationsEventMediaSummaryDetail {\n");

			sb.Append("  Active: ").Append(Active).Append("\n");
			sb.Append("  Acw: ").Append(Acw).Append("\n");
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
			return this.Equals(obj as UserConversationsEventMediaSummaryDetail);
		}

		/// <summary>
		/// Returns true if UserConversationsEventMediaSummaryDetail instances are equal
		/// </summary>
		/// <param name="other">Instance of UserConversationsEventMediaSummaryDetail to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserConversationsEventMediaSummaryDetail other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Active == other.Active ||
					this.Active != null &&
					this.Active.Equals(other.Active)
				) &&
				(
					this.Acw == other.Acw ||
					this.Acw != null &&
					this.Acw.Equals(other.Acw)
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
				if (this.Active != null)
					hash = hash * 59 + this.Active.GetHashCode();

				if (this.Acw != null)
					hash = hash * 59 + this.Acw.GetHashCode();

				return hash;
			}
		}
	}

}
