using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneySessionEventsNotificationSessionLastEvent
	/// </summary>
	[DataContract]
	public partial class JourneySessionEventsNotificationSessionLastEvent : IEquatable<JourneySessionEventsNotificationSessionLastEvent>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneySessionEventsNotificationSessionLastEvent" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="EventName">EventName.</param>
		/// <param name="CreatedDate">CreatedDate.</param>
		public JourneySessionEventsNotificationSessionLastEvent(string Id = null, string EventName = null, DateTime? CreatedDate = null)
		{
			this.Id = Id;
			this.EventName = EventName;
			this.CreatedDate = CreatedDate;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets EventName
		/// </summary>
		[DataMember(Name = "eventName", EmitDefaultValue = false)]
		public string EventName { get; set; }



		/// <summary>
		/// Gets or Sets CreatedDate
		/// </summary>
		[DataMember(Name = "createdDate", EmitDefaultValue = false)]
		public DateTime? CreatedDate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneySessionEventsNotificationSessionLastEvent {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  EventName: ").Append(EventName).Append("\n");
			sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
			return this.Equals(obj as JourneySessionEventsNotificationSessionLastEvent);
		}

		/// <summary>
		/// Returns true if JourneySessionEventsNotificationSessionLastEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneySessionEventsNotificationSessionLastEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneySessionEventsNotificationSessionLastEvent other)
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
					this.EventName == other.EventName ||
					this.EventName != null &&
					this.EventName.Equals(other.EventName)
				) &&
				(
					this.CreatedDate == other.CreatedDate ||
					this.CreatedDate != null &&
					this.CreatedDate.Equals(other.CreatedDate)
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

				if (this.EventName != null)
					hash = hash * 59 + this.EventName.GetHashCode();

				if (this.CreatedDate != null)
					hash = hash * 59 + this.CreatedDate.GetHashCode();

				return hash;
			}
		}
	}

}
