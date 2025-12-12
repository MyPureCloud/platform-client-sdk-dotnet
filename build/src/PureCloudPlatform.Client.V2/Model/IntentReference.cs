using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// IntentReference
	/// </summary>
	[DataContract]
	public partial class IntentReference : IEquatable<IntentReference>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="IntentReference" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected IntentReference() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="IntentReference" /> class.
		/// </summary>
		/// <param name="Name">The name of the intent. (required).</param>
		public IntentReference(string Name = null)
		{
			this.Name = Name;

		}



		/// <summary>
		/// ID of the intent.
		/// </summary>
		/// <value>ID of the intent.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the intent.
		/// </summary>
		/// <value>The name of the intent.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class IntentReference {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
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
			return this.Equals(obj as IntentReference);
		}

		/// <summary>
		/// Returns true if IntentReference instances are equal
		/// </summary>
		/// <param name="other">Instance of IntentReference to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(IntentReference other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				return hash;
			}
		}
	}

}
