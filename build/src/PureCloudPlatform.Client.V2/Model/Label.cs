using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Label
	/// </summary>
	[DataContract]
	public partial class Label : IEquatable<Label>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="Label" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Label() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Label" /> class.
		/// </summary>
		/// <param name="Name">Name of the label (required).</param>
		/// <param name="Value">Value of the label (required).</param>
		public Label(string Name = null, string Value = null)
		{
			this.Name = Name;
			this.Value = Value;

		}



		/// <summary>
		/// Name of the label
		/// </summary>
		/// <value>Name of the label</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Value of the label
		/// </summary>
		/// <value>Value of the label</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }



		/// <summary>
		/// Whether the label is encoded or not
		/// </summary>
		/// <value>Whether the label is encoded or not</value>
		[DataMember(Name = "encoded", EmitDefaultValue = false)]
		public bool? Encoded { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Label {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
			sb.Append("  Encoded: ").Append(Encoded).Append("\n");
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
			return this.Equals(obj as Label);
		}

		/// <summary>
		/// Returns true if Label instances are equal
		/// </summary>
		/// <param name="other">Instance of Label to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Label other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
				) &&
				(
					this.Encoded == other.Encoded ||
					this.Encoded != null &&
					this.Encoded.Equals(other.Encoded)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				if (this.Encoded != null)
					hash = hash * 59 + this.Encoded.GetHashCode();

				return hash;
			}
		}
	}

}
