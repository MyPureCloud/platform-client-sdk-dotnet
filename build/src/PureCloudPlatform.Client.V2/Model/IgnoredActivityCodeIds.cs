using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// IgnoredActivityCodeIds
	/// </summary>
	[DataContract]
	public partial class IgnoredActivityCodeIds : IEquatable<IgnoredActivityCodeIds>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="IgnoredActivityCodeIds" /> class.
		/// </summary>
		/// <param name="Values">List of activity code IDs.</param>
		public IgnoredActivityCodeIds(List<string> Values = null)
		{
			this.Values = Values;

		}



		/// <summary>
		/// List of activity code IDs
		/// </summary>
		/// <value>List of activity code IDs</value>
		[DataMember(Name = "values", EmitDefaultValue = false)]
		public List<string> Values { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class IgnoredActivityCodeIds {\n");

			sb.Append("  Values: ").Append(Values).Append("\n");
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
			return this.Equals(obj as IgnoredActivityCodeIds);
		}

		/// <summary>
		/// Returns true if IgnoredActivityCodeIds instances are equal
		/// </summary>
		/// <param name="other">Instance of IgnoredActivityCodeIds to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(IgnoredActivityCodeIds other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Values == other.Values ||
					this.Values != null &&
					this.Values.SequenceEqual(other.Values)
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
				if (this.Values != null)
					hash = hash * 59 + this.Values.GetHashCode();

				return hash;
			}
		}
	}

}
