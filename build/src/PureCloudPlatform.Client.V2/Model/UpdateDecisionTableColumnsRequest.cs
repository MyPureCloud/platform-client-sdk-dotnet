using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Decision table columns will equal the columns contained in this request after the update is performed. If a list of columns types is not provided (i.e. is null) then no update is performed for that column type
	/// </summary>
	[DataContract]
	public partial class UpdateDecisionTableColumnsRequest : IEquatable<UpdateDecisionTableColumnsRequest>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateDecisionTableColumnsRequest" /> class.
		/// </summary>
		/// <param name="Inputs">The input columns of the decision table..</param>
		/// <param name="Outputs">The output columns of the decision table..</param>
		public UpdateDecisionTableColumnsRequest(List<DecisionTableInputColumnRequest> Inputs = null, List<DecisionTableOutputColumnRequest> Outputs = null)
		{
			this.Inputs = Inputs;
			this.Outputs = Outputs;

		}



		/// <summary>
		/// The input columns of the decision table.
		/// </summary>
		/// <value>The input columns of the decision table.</value>
		[DataMember(Name = "inputs", EmitDefaultValue = false)]
		public List<DecisionTableInputColumnRequest> Inputs { get; set; }



		/// <summary>
		/// The output columns of the decision table.
		/// </summary>
		/// <value>The output columns of the decision table.</value>
		[DataMember(Name = "outputs", EmitDefaultValue = false)]
		public List<DecisionTableOutputColumnRequest> Outputs { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateDecisionTableColumnsRequest {\n");

			sb.Append("  Inputs: ").Append(Inputs).Append("\n");
			sb.Append("  Outputs: ").Append(Outputs).Append("\n");
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
			return this.Equals(obj as UpdateDecisionTableColumnsRequest);
		}

		/// <summary>
		/// Returns true if UpdateDecisionTableColumnsRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateDecisionTableColumnsRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateDecisionTableColumnsRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Inputs == other.Inputs ||
					this.Inputs != null &&
					this.Inputs.SequenceEqual(other.Inputs)
				) &&
				(
					this.Outputs == other.Outputs ||
					this.Outputs != null &&
					this.Outputs.SequenceEqual(other.Outputs)
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
				if (this.Inputs != null)
					hash = hash * 59 + this.Inputs.GetHashCode();

				if (this.Outputs != null)
					hash = hash * 59 + this.Outputs.GetHashCode();

				return hash;
			}
		}
	}

}
