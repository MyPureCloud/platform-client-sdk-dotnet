using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2WebMessagingUndeliveredMessageTopicMessage
	/// </summary>
	[DataContract]
	public partial class V2WebMessagingUndeliveredMessageTopicMessage : IEquatable<V2WebMessagingUndeliveredMessageTopicMessage>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2WebMessagingUndeliveredMessageTopicMessage" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="EventTimeMs">EventTimeMs.</param>
		public V2WebMessagingUndeliveredMessageTopicMessage(string Id = null, long? EventTimeMs = null)
		{
			this.Id = Id;
			this.EventTimeMs = EventTimeMs;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets EventTimeMs
		/// </summary>
		[DataMember(Name = "eventTimeMs", EmitDefaultValue = false)]
		public long? EventTimeMs { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2WebMessagingUndeliveredMessageTopicMessage {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  EventTimeMs: ").Append(EventTimeMs).Append("\n");
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
			return this.Equals(obj as V2WebMessagingUndeliveredMessageTopicMessage);
		}

		/// <summary>
		/// Returns true if V2WebMessagingUndeliveredMessageTopicMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of V2WebMessagingUndeliveredMessageTopicMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2WebMessagingUndeliveredMessageTopicMessage other)
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
					this.EventTimeMs == other.EventTimeMs ||
					this.EventTimeMs != null &&
					this.EventTimeMs.Equals(other.EventTimeMs)
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

				if (this.EventTimeMs != null)
					hash = hash * 59 + this.EventTimeMs.GetHashCode();

				return hash;
			}
		}
	}

}
