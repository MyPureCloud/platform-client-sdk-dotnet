using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2MobiusRulesTopicAlertingAddressableEntityRef
	/// </summary>
	[DataContract]
	public partial class V2MobiusRulesTopicAlertingAddressableEntityRef : IEquatable<V2MobiusRulesTopicAlertingAddressableEntityRef>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2MobiusRulesTopicAlertingAddressableEntityRef" /> class.
		/// </summary>
		/// <param name="Id">The ID of the resource.</param>
		/// <param name="DisplayName">DisplayName.</param>
		public V2MobiusRulesTopicAlertingAddressableEntityRef(string Id = null, string DisplayName = null)
		{
			this.Id = Id;
			this.DisplayName = DisplayName;

		}



		/// <summary>
		/// The ID of the resource
		/// </summary>
		/// <value>The ID of the resource</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets DisplayName
		/// </summary>
		[DataMember(Name = "displayName", EmitDefaultValue = false)]
		public string DisplayName { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2MobiusRulesTopicAlertingAddressableEntityRef {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
			return this.Equals(obj as V2MobiusRulesTopicAlertingAddressableEntityRef);
		}

		/// <summary>
		/// Returns true if V2MobiusRulesTopicAlertingAddressableEntityRef instances are equal
		/// </summary>
		/// <param name="other">Instance of V2MobiusRulesTopicAlertingAddressableEntityRef to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2MobiusRulesTopicAlertingAddressableEntityRef other)
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
					this.DisplayName == other.DisplayName ||
					this.DisplayName != null &&
					this.DisplayName.Equals(other.DisplayName)
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

				if (this.DisplayName != null)
					hash = hash * 59 + this.DisplayName.GetHashCode();

				return hash;
			}
		}
	}

}
