using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A schedule group.
	/// </summary>
	[DataContract]
	public partial class ScheduleGroupDivisionView : IEquatable<ScheduleGroupDivisionView>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ScheduleGroupDivisionView" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ScheduleGroupDivisionView() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ScheduleGroupDivisionView" /> class.
		/// </summary>
		/// <param name="Id">The schedule group identifier.</param>
		/// <param name="Name">The schedule group name (required).</param>
		/// <param name="Division">The division to which this entity belongs..</param>
		public ScheduleGroupDivisionView(string Id = null, string Name = null, WritableDivision Division = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Division = Division;

		}



		/// <summary>
		/// The schedule group identifier
		/// </summary>
		/// <value>The schedule group identifier</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The schedule group name
		/// </summary>
		/// <value>The schedule group name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The division to which this entity belongs.
		/// </summary>
		/// <value>The division to which this entity belongs.</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public WritableDivision Division { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ScheduleGroupDivisionView {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as ScheduleGroupDivisionView);
		}

		/// <summary>
		/// Returns true if ScheduleGroupDivisionView instances are equal
		/// </summary>
		/// <param name="other">Instance of ScheduleGroupDivisionView to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ScheduleGroupDivisionView other)
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
				) &&
				(
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
