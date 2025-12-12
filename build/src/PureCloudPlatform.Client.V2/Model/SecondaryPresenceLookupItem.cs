using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SecondaryPresenceLookupItem
	/// </summary>
	[DataContract]
	public partial class SecondaryPresenceLookupItem : IEquatable<SecondaryPresenceLookupItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SecondaryPresenceLookupItem" /> class.
		/// </summary>
		/// <param name="LookupId">The lookupId of secondary presence id.</param>
		/// <param name="SecondaryPresence">The secondary presence Id.</param>
		public SecondaryPresenceLookupItem(string LookupId = null, SecondaryPresence SecondaryPresence = null)
		{
			this.LookupId = LookupId;
			this.SecondaryPresence = SecondaryPresence;

		}



		/// <summary>
		/// The lookupId of secondary presence id
		/// </summary>
		/// <value>The lookupId of secondary presence id</value>
		[DataMember(Name = "lookupId", EmitDefaultValue = false)]
		public string LookupId { get; set; }



		/// <summary>
		/// The secondary presence Id
		/// </summary>
		/// <value>The secondary presence Id</value>
		[DataMember(Name = "secondaryPresence", EmitDefaultValue = false)]
		public SecondaryPresence SecondaryPresence { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SecondaryPresenceLookupItem {\n");

			sb.Append("  LookupId: ").Append(LookupId).Append("\n");
			sb.Append("  SecondaryPresence: ").Append(SecondaryPresence).Append("\n");
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
			return this.Equals(obj as SecondaryPresenceLookupItem);
		}

		/// <summary>
		/// Returns true if SecondaryPresenceLookupItem instances are equal
		/// </summary>
		/// <param name="other">Instance of SecondaryPresenceLookupItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SecondaryPresenceLookupItem other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.LookupId == other.LookupId ||
					this.LookupId != null &&
					this.LookupId.Equals(other.LookupId)
				) &&
				(
					this.SecondaryPresence == other.SecondaryPresence ||
					this.SecondaryPresence != null &&
					this.SecondaryPresence.Equals(other.SecondaryPresence)
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
				if (this.LookupId != null)
					hash = hash * 59 + this.LookupId.GetHashCode();

				if (this.SecondaryPresence != null)
					hash = hash * 59 + this.SecondaryPresence.GetHashCode();

				return hash;
			}
		}
	}

}
