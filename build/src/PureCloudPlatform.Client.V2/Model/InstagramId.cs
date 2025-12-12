using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// User information for an Instagram account
	/// </summary>
	[DataContract]
	public partial class InstagramId : IEquatable<InstagramId>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InstagramId" /> class.
		/// </summary>
		/// <param name="Ids">The set of scopedIds that this person has. Each scopedId is specific to an Instagram page or app that the user interacts with..</param>
		/// <param name="DisplayName">The displayName of the person who owns this Instagram account.</param>
		/// <param name="Handle">The handle of the person who owns this Instagram account.</param>
		public InstagramId(List<InstagramScopedId> Ids = null, string DisplayName = null, string Handle = null)
		{
			this.Ids = Ids;
			this.DisplayName = DisplayName;
			this.Handle = Handle;

		}



		/// <summary>
		/// The set of scopedIds that this person has. Each scopedId is specific to an Instagram page or app that the user interacts with.
		/// </summary>
		/// <value>The set of scopedIds that this person has. Each scopedId is specific to an Instagram page or app that the user interacts with.</value>
		[DataMember(Name = "ids", EmitDefaultValue = false)]
		public List<InstagramScopedId> Ids { get; set; }



		/// <summary>
		/// The displayName of the person who owns this Instagram account
		/// </summary>
		/// <value>The displayName of the person who owns this Instagram account</value>
		[DataMember(Name = "displayName", EmitDefaultValue = false)]
		public string DisplayName { get; set; }



		/// <summary>
		/// The handle of the person who owns this Instagram account
		/// </summary>
		/// <value>The handle of the person who owns this Instagram account</value>
		[DataMember(Name = "handle", EmitDefaultValue = false)]
		public string Handle { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InstagramId {\n");

			sb.Append("  Ids: ").Append(Ids).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
			sb.Append("  Handle: ").Append(Handle).Append("\n");
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
			return this.Equals(obj as InstagramId);
		}

		/// <summary>
		/// Returns true if InstagramId instances are equal
		/// </summary>
		/// <param name="other">Instance of InstagramId to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(InstagramId other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Ids == other.Ids ||
					this.Ids != null &&
					this.Ids.SequenceEqual(other.Ids)
				) &&
				(
					this.DisplayName == other.DisplayName ||
					this.DisplayName != null &&
					this.DisplayName.Equals(other.DisplayName)
				) &&
				(
					this.Handle == other.Handle ||
					this.Handle != null &&
					this.Handle.Equals(other.Handle)
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
				if (this.Ids != null)
					hash = hash * 59 + this.Ids.GetHashCode();

				if (this.DisplayName != null)
					hash = hash * 59 + this.DisplayName.GetHashCode();

				if (this.Handle != null)
					hash = hash * 59 + this.Handle.GetHashCode();

				return hash;
			}
		}
	}

}
