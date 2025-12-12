using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LexSlot
	/// </summary>
	[DataContract]
	public partial class LexSlot : IEquatable<LexSlot>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="LexSlot" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected LexSlot() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="LexSlot" /> class.
		/// </summary>
		/// <param name="Name">The slot name (required).</param>
		/// <param name="Description">The slot description.</param>
		/// <param name="Type">The slot type (required).</param>
		/// <param name="Priority">The priority of the slot.</param>
		public LexSlot(string Name = null, string Description = null, string Type = null, int? Priority = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.Type = Type;
			this.Priority = Priority;

		}



		/// <summary>
		/// The slot name
		/// </summary>
		/// <value>The slot name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The slot description
		/// </summary>
		/// <value>The slot description</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The slot type
		/// </summary>
		/// <value>The slot type</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }



		/// <summary>
		/// The priority of the slot
		/// </summary>
		/// <value>The priority of the slot</value>
		[DataMember(Name = "priority", EmitDefaultValue = false)]
		public int? Priority { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LexSlot {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Priority: ").Append(Priority).Append("\n");
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
			return this.Equals(obj as LexSlot);
		}

		/// <summary>
		/// Returns true if LexSlot instances are equal
		/// </summary>
		/// <param name="other">Instance of LexSlot to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LexSlot other)
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
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Priority == other.Priority ||
					this.Priority != null &&
					this.Priority.Equals(other.Priority)
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

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Priority != null)
					hash = hash * 59 + this.Priority.GetHashCode();

				return hash;
			}
		}
	}

}
