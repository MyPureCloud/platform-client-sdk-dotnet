using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuActivitySettingsRequest
	/// </summary>
	[DataContract]
	public partial class BuActivitySettingsRequest : IEquatable<BuActivitySettingsRequest>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BuActivitySettingsRequest" /> class.
		/// </summary>
		/// <param name="DefaultActivityCodeId">The ID of the activity code. This is the activity code that will be used by default for agent development activities added to the schedule.</param>
		public BuActivitySettingsRequest(string DefaultActivityCodeId = null)
		{
			this.DefaultActivityCodeId = DefaultActivityCodeId;

		}



		/// <summary>
		/// The ID of the activity code. This is the activity code that will be used by default for agent development activities added to the schedule
		/// </summary>
		/// <value>The ID of the activity code. This is the activity code that will be used by default for agent development activities added to the schedule</value>
		[DataMember(Name = "defaultActivityCodeId", EmitDefaultValue = false)]
		public string DefaultActivityCodeId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BuActivitySettingsRequest {\n");

			sb.Append("  DefaultActivityCodeId: ").Append(DefaultActivityCodeId).Append("\n");
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
			return this.Equals(obj as BuActivitySettingsRequest);
		}

		/// <summary>
		/// Returns true if BuActivitySettingsRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of BuActivitySettingsRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuActivitySettingsRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DefaultActivityCodeId == other.DefaultActivityCodeId ||
					this.DefaultActivityCodeId != null &&
					this.DefaultActivityCodeId.Equals(other.DefaultActivityCodeId)
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
				if (this.DefaultActivityCodeId != null)
					hash = hash * 59 + this.DefaultActivityCodeId.GetHashCode();

				return hash;
			}
		}
	}

}
