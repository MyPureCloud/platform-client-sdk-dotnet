using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Cursors
	/// </summary>
	[DataContract]
	public partial class Cursors : IEquatable<Cursors>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Cursors" /> class.
		/// </summary>
		/// <param name="Before">Before.</param>
		/// <param name="After">After.</param>
		public Cursors(string Before = null, string After = null)
		{
			this.Before = Before;
			this.After = After;

		}



		/// <summary>
		/// Gets or Sets Before
		/// </summary>
		[DataMember(Name = "before", EmitDefaultValue = false)]
		public string Before { get; set; }



		/// <summary>
		/// Gets or Sets After
		/// </summary>
		[DataMember(Name = "after", EmitDefaultValue = false)]
		public string After { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Cursors {\n");

			sb.Append("  Before: ").Append(Before).Append("\n");
			sb.Append("  After: ").Append(After).Append("\n");
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
			return this.Equals(obj as Cursors);
		}

		/// <summary>
		/// Returns true if Cursors instances are equal
		/// </summary>
		/// <param name="other">Instance of Cursors to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Cursors other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Before == other.Before ||
					this.Before != null &&
					this.Before.Equals(other.Before)
				) &&
				(
					this.After == other.After ||
					this.After != null &&
					this.After.Equals(other.After)
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
				if (this.Before != null)
					hash = hash * 59 + this.Before.GetHashCode();

				if (this.After != null)
					hash = hash * 59 + this.After.GetHashCode();

				return hash;
			}
		}
	}

}
