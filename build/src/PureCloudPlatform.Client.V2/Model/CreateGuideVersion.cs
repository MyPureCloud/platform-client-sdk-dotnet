using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CreateGuideVersion
	/// </summary>
	[DataContract]
	public partial class CreateGuideVersion : IEquatable<CreateGuideVersion>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateGuideVersion" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CreateGuideVersion() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateGuideVersion" /> class.
		/// </summary>
		/// <param name="Instruction">The instruction given to this version of the guide, for how it should behave when interacting with a User. (required).</param>
		/// <param name="Variables">The variables associated with this version of the guide. Includes input variables (provided) and output variables (captured during execution)..</param>
		/// <param name="Resources">The resources associated with this version of the guide..</param>
		public CreateGuideVersion(string Instruction = null, List<Variable> Variables = null, GuideVersionResources Resources = null)
		{
			this.Instruction = Instruction;
			this.Variables = Variables;
			this.Resources = Resources;

		}



		/// <summary>
		/// The instruction given to this version of the guide, for how it should behave when interacting with a User.
		/// </summary>
		/// <value>The instruction given to this version of the guide, for how it should behave when interacting with a User.</value>
		[DataMember(Name = "instruction", EmitDefaultValue = false)]
		public string Instruction { get; set; }



		/// <summary>
		/// The variables associated with this version of the guide. Includes input variables (provided) and output variables (captured during execution).
		/// </summary>
		/// <value>The variables associated with this version of the guide. Includes input variables (provided) and output variables (captured during execution).</value>
		[DataMember(Name = "variables", EmitDefaultValue = false)]
		public List<Variable> Variables { get; set; }



		/// <summary>
		/// The resources associated with this version of the guide.
		/// </summary>
		/// <value>The resources associated with this version of the guide.</value>
		[DataMember(Name = "resources", EmitDefaultValue = false)]
		public GuideVersionResources Resources { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateGuideVersion {\n");

			sb.Append("  Instruction: ").Append(Instruction).Append("\n");
			sb.Append("  Variables: ").Append(Variables).Append("\n");
			sb.Append("  Resources: ").Append(Resources).Append("\n");
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
			return this.Equals(obj as CreateGuideVersion);
		}

		/// <summary>
		/// Returns true if CreateGuideVersion instances are equal
		/// </summary>
		/// <param name="other">Instance of CreateGuideVersion to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CreateGuideVersion other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Instruction == other.Instruction ||
					this.Instruction != null &&
					this.Instruction.Equals(other.Instruction)
				) &&
				(
					this.Variables == other.Variables ||
					this.Variables != null &&
					this.Variables.SequenceEqual(other.Variables)
				) &&
				(
					this.Resources == other.Resources ||
					this.Resources != null &&
					this.Resources.Equals(other.Resources)
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
				if (this.Instruction != null)
					hash = hash * 59 + this.Instruction.GetHashCode();

				if (this.Variables != null)
					hash = hash * 59 + this.Variables.GetHashCode();

				if (this.Resources != null)
					hash = hash * 59 + this.Resources.GetHashCode();

				return hash;
			}
		}
	}

}
