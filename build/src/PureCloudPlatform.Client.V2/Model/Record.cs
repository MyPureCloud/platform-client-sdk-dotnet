using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Record
	/// </summary>
	[DataContract]
	public partial class Record : IEquatable<Record>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="Record" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Record() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Record" /> class.
		/// </summary>
		/// <param name="Name">The name of the record. (required).</param>
		/// <param name="Type">The type of the record. (Example values:  MX, TXT, CNAME) (required).</param>
		/// <param name="Value">The value of the record. (required).</param>
		public Record(string Name = null, string Type = null, string Value = null)
		{
			this.Name = Name;
			this.Type = Type;
			this.Value = Value;

		}



		/// <summary>
		/// The name of the record.
		/// </summary>
		/// <value>The name of the record.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The type of the record. (Example values:  MX, TXT, CNAME)
		/// </summary>
		/// <value>The type of the record. (Example values:  MX, TXT, CNAME)</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }



		/// <summary>
		/// The value of the record.
		/// </summary>
		/// <value>The value of the record.</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Record {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
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
			return this.Equals(obj as Record);
		}

		/// <summary>
		/// Returns true if Record instances are equal
		/// </summary>
		/// <param name="other">Instance of Record to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Record other)
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
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				return hash;
			}
		}
	}

}
