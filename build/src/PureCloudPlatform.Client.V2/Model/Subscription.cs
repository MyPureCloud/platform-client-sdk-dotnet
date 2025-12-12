using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Subscription
	/// </summary>
	[DataContract]
	public partial class Subscription : IEquatable<Subscription>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Subscription" /> class.
		/// </summary>
		/// <param name="Id">The subscription id.</param>
		/// <param name="Topic">Notification topic.</param>
		public Subscription(string Id = null, string Topic = null)
		{
			this.Id = Id;
			this.Topic = Topic;

		}



		/// <summary>
		/// The subscription id
		/// </summary>
		/// <value>The subscription id</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Notification topic
		/// </summary>
		/// <value>Notification topic</value>
		[DataMember(Name = "topic", EmitDefaultValue = false)]
		public string Topic { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Subscription {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Topic: ").Append(Topic).Append("\n");
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
			return this.Equals(obj as Subscription);
		}

		/// <summary>
		/// Returns true if Subscription instances are equal
		/// </summary>
		/// <param name="other">Instance of Subscription to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Subscription other)
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
					this.Topic == other.Topic ||
					this.Topic != null &&
					this.Topic.Equals(other.Topic)
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

				if (this.Topic != null)
					hash = hash * 59 + this.Topic.GetHashCode();

				return hash;
			}
		}
	}

}
