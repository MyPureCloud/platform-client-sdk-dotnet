using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Contractual
	/// </summary>
	[DataContract]
	public partial class Contractual : IEquatable<Contractual>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="Contractual" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Contractual() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Contractual" /> class.
		/// </summary>
		/// <param name="SchemaPropertyKey">The contract schema property key that describes the input value of this column. (required).</param>
		/// <param name="_Contractual">The nested contractual definition that is defined by a contract schema, if any..</param>
		public Contractual(string SchemaPropertyKey = null, Contractual _Contractual = null)
		{
			this.SchemaPropertyKey = SchemaPropertyKey;
			this._Contractual = _Contractual;

		}



		/// <summary>
		/// The contract schema property key that describes the input value of this column.
		/// </summary>
		/// <value>The contract schema property key that describes the input value of this column.</value>
		[DataMember(Name = "schemaPropertyKey", EmitDefaultValue = false)]
		public string SchemaPropertyKey { get; set; }



		/// <summary>
		/// The nested contractual definition that is defined by a contract schema, if any.
		/// </summary>
		/// <value>The nested contractual definition that is defined by a contract schema, if any.</value>
		[DataMember(Name = "contractual", EmitDefaultValue = false)]
		public Contractual _Contractual { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Contractual {\n");

			sb.Append("  SchemaPropertyKey: ").Append(SchemaPropertyKey).Append("\n");
			sb.Append("  _Contractual: ").Append(_Contractual).Append("\n");
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
			return this.Equals(obj as Contractual);
		}

		/// <summary>
		/// Returns true if Contractual instances are equal
		/// </summary>
		/// <param name="other">Instance of Contractual to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Contractual other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SchemaPropertyKey == other.SchemaPropertyKey ||
					this.SchemaPropertyKey != null &&
					this.SchemaPropertyKey.Equals(other.SchemaPropertyKey)
				) &&
				(
					this._Contractual == other._Contractual ||
					this._Contractual != null &&
					this._Contractual.Equals(other._Contractual)
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
				if (this.SchemaPropertyKey != null)
					hash = hash * 59 + this.SchemaPropertyKey.GetHashCode();

				if (this._Contractual != null)
					hash = hash * 59 + this._Contractual.GetHashCode();

				return hash;
			}
		}
	}

}
