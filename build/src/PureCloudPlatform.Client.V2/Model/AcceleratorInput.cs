using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Identity of a CX infrastructure as code accelerator to be run and its inputs
	/// </summary>
	[DataContract]
	public partial class AcceleratorInput : IEquatable<AcceleratorInput>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AcceleratorInput" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AcceleratorInput() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AcceleratorInput" /> class.
		/// </summary>
		/// <param name="DryRun">Set this true to test the job without making any changes. Defaults to false..</param>
		/// <param name="AcceleratorId">Accelerator ID (required).</param>
		/// <param name="Parameters">Parameters required for this accelerator.</param>
		public AcceleratorInput(bool? DryRun = null, string AcceleratorId = null, List<AcceleratorParameter> Parameters = null)
		{
			this.DryRun = DryRun;
			this.AcceleratorId = AcceleratorId;
			this.Parameters = Parameters;

		}



		/// <summary>
		/// Set this true to test the job without making any changes. Defaults to false.
		/// </summary>
		/// <value>Set this true to test the job without making any changes. Defaults to false.</value>
		[DataMember(Name = "dryRun", EmitDefaultValue = false)]
		public bool? DryRun { get; set; }



		/// <summary>
		/// Accelerator ID
		/// </summary>
		/// <value>Accelerator ID</value>
		[DataMember(Name = "acceleratorId", EmitDefaultValue = false)]
		public string AcceleratorId { get; set; }



		/// <summary>
		/// Parameters required for this accelerator
		/// </summary>
		/// <value>Parameters required for this accelerator</value>
		[DataMember(Name = "parameters", EmitDefaultValue = false)]
		public List<AcceleratorParameter> Parameters { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AcceleratorInput {\n");

			sb.Append("  DryRun: ").Append(DryRun).Append("\n");
			sb.Append("  AcceleratorId: ").Append(AcceleratorId).Append("\n");
			sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
			return this.Equals(obj as AcceleratorInput);
		}

		/// <summary>
		/// Returns true if AcceleratorInput instances are equal
		/// </summary>
		/// <param name="other">Instance of AcceleratorInput to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AcceleratorInput other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DryRun == other.DryRun ||
					this.DryRun != null &&
					this.DryRun.Equals(other.DryRun)
				) &&
				(
					this.AcceleratorId == other.AcceleratorId ||
					this.AcceleratorId != null &&
					this.AcceleratorId.Equals(other.AcceleratorId)
				) &&
				(
					this.Parameters == other.Parameters ||
					this.Parameters != null &&
					this.Parameters.SequenceEqual(other.Parameters)
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
				if (this.DryRun != null)
					hash = hash * 59 + this.DryRun.GetHashCode();

				if (this.AcceleratorId != null)
					hash = hash * 59 + this.AcceleratorId.GetHashCode();

				if (this.Parameters != null)
					hash = hash * 59 + this.Parameters.GetHashCode();

				return hash;
			}
		}
	}

}
