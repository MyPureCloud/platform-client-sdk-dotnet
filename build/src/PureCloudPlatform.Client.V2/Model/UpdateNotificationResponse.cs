using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UpdateNotificationResponse
	/// </summary>
	[DataContract]
	public partial class UpdateNotificationResponse : IEquatable<UpdateNotificationResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateNotificationResponse" /> class.
		/// </summary>
		/// <param name="MutableGroupId">The mutableGroupId of the notification.</param>
		/// <param name="Id">The id of the notification for mapping the potentially new mutableGroupId.</param>
		public UpdateNotificationResponse(string MutableGroupId = null, string Id = null)
		{
			this.MutableGroupId = MutableGroupId;
			this.Id = Id;

		}



		/// <summary>
		/// The mutableGroupId of the notification
		/// </summary>
		/// <value>The mutableGroupId of the notification</value>
		[DataMember(Name = "mutableGroupId", EmitDefaultValue = false)]
		public string MutableGroupId { get; set; }



		/// <summary>
		/// The id of the notification for mapping the potentially new mutableGroupId
		/// </summary>
		/// <value>The id of the notification for mapping the potentially new mutableGroupId</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateNotificationResponse {\n");

			sb.Append("  MutableGroupId: ").Append(MutableGroupId).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
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
			return this.Equals(obj as UpdateNotificationResponse);
		}

		/// <summary>
		/// Returns true if UpdateNotificationResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateNotificationResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateNotificationResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MutableGroupId == other.MutableGroupId ||
					this.MutableGroupId != null &&
					this.MutableGroupId.Equals(other.MutableGroupId)
				) &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
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
				if (this.MutableGroupId != null)
					hash = hash * 59 + this.MutableGroupId.GetHashCode();

				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				return hash;
			}
		}
	}

}
