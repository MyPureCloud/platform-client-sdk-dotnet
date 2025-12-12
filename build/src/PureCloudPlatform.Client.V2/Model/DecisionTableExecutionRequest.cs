using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DecisionTableExecutionRequest
	/// </summary>
	[DataContract]
	public partial class DecisionTableExecutionRequest : IEquatable<DecisionTableExecutionRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="DecisionTableExecutionRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DecisionTableExecutionRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DecisionTableExecutionRequest" /> class.
		/// </summary>
		/// <param name="Inputs">The JSON input data for executing the decision table. Must be valid according to the execution input contract defined on the table. In the case of enum decision table columns the enum options key should be provided as the value, not the enum options label as this can be changed. For business rules queue columns both “queue” and “id” keys will be required regardless of the queue attribute key and these do not change. (required).</param>
		public DecisionTableExecutionRequest(Dictionary<string, Object> Inputs = null)
		{
			this.Inputs = Inputs;

		}



		/// <summary>
		/// The JSON input data for executing the decision table. Must be valid according to the execution input contract defined on the table. In the case of enum decision table columns the enum options key should be provided as the value, not the enum options label as this can be changed. For business rules queue columns both “queue” and “id” keys will be required regardless of the queue attribute key and these do not change.
		/// </summary>
		/// <value>The JSON input data for executing the decision table. Must be valid according to the execution input contract defined on the table. In the case of enum decision table columns the enum options key should be provided as the value, not the enum options label as this can be changed. For business rules queue columns both “queue” and “id” keys will be required regardless of the queue attribute key and these do not change.</value>
		[DataMember(Name = "inputs", EmitDefaultValue = false)]
		public Dictionary<string, Object> Inputs { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DecisionTableExecutionRequest {\n");

			sb.Append("  Inputs: ").Append(Inputs).Append("\n");
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
			return this.Equals(obj as DecisionTableExecutionRequest);
		}

		/// <summary>
		/// Returns true if DecisionTableExecutionRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of DecisionTableExecutionRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DecisionTableExecutionRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Inputs == other.Inputs ||
					this.Inputs != null &&
					this.Inputs.SequenceEqual(other.Inputs)
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

				return hash;
			}
		}
	}

}
