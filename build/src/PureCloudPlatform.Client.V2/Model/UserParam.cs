using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserParam
	/// </summary>
	[DataContract]
	public partial class UserParam : IEquatable<UserParam>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserParam" /> class.
		/// </summary>
		/// <param name="Key">Key.</param>
		/// <param name="Value">Value.</param>
		public UserParam(string Key = null, string Value = null)
		{
			this.Key = Key;
			this.Value = Value;

		}



		/// <summary>
		/// Gets or Sets Key
		/// </summary>
		[DataMember(Name = "key", EmitDefaultValue = false)]
		public string Key { get; set; }



		/// <summary>
		/// Gets or Sets Value
		/// </summary>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserParam {\n");

			sb.Append("  Key: ").Append(Key).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return this.Equals(obj as UserParam);
		}

		/// <summary>
		/// Returns true if UserParam instances are equal
		/// </summary>
		/// <param name="other">Instance of UserParam to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserParam other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Key == other.Key ||
					this.Key != null &&
					this.Key.Equals(other.Key)
				) &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
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
				if (this.Key != null)
					hash = hash * 59 + this.Key.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				return hash;
			}
		}
	}

}
