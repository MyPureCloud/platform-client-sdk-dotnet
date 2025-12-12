using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LexV2Slot
	/// </summary>
	[DataContract]
	public partial class LexV2Slot : IEquatable<LexV2Slot>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="LexV2Slot" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected LexV2Slot() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="LexV2Slot" /> class.
		/// </summary>
		/// <param name="SlotName">The slot name (required).</param>
		/// <param name="Description">The slot description.</param>
		/// <param name="SlotId">The slot id (required).</param>
		/// <param name="Type">The slot type (required).</param>
		/// <param name="SlotTypeId">The slot type id (required).</param>
		public LexV2Slot(string SlotName = null, string Description = null, string SlotId = null, string Type = null, string SlotTypeId = null)
		{
			this.SlotName = SlotName;
			this.Description = Description;
			this.SlotId = SlotId;
			this.Type = Type;
			this.SlotTypeId = SlotTypeId;

		}



		/// <summary>
		/// The slot name
		/// </summary>
		/// <value>The slot name</value>
		[DataMember(Name = "slotName", EmitDefaultValue = false)]
		public string SlotName { get; set; }



		/// <summary>
		/// The slot description
		/// </summary>
		/// <value>The slot description</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The slot id
		/// </summary>
		/// <value>The slot id</value>
		[DataMember(Name = "slotId", EmitDefaultValue = false)]
		public string SlotId { get; set; }



		/// <summary>
		/// The slot type
		/// </summary>
		/// <value>The slot type</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }



		/// <summary>
		/// The slot type id
		/// </summary>
		/// <value>The slot type id</value>
		[DataMember(Name = "slotTypeId", EmitDefaultValue = false)]
		public string SlotTypeId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LexV2Slot {\n");

			sb.Append("  SlotName: ").Append(SlotName).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  SlotId: ").Append(SlotId).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  SlotTypeId: ").Append(SlotTypeId).Append("\n");
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
			return this.Equals(obj as LexV2Slot);
		}

		/// <summary>
		/// Returns true if LexV2Slot instances are equal
		/// </summary>
		/// <param name="other">Instance of LexV2Slot to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LexV2Slot other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SlotName == other.SlotName ||
					this.SlotName != null &&
					this.SlotName.Equals(other.SlotName)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.SlotId == other.SlotId ||
					this.SlotId != null &&
					this.SlotId.Equals(other.SlotId)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.SlotTypeId == other.SlotTypeId ||
					this.SlotTypeId != null &&
					this.SlotTypeId.Equals(other.SlotTypeId)
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
				if (this.SlotName != null)
					hash = hash * 59 + this.SlotName.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.SlotId != null)
					hash = hash * 59 + this.SlotId.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.SlotTypeId != null)
					hash = hash * 59 + this.SlotTypeId.GetHashCode();

				return hash;
			}
		}
	}

}
