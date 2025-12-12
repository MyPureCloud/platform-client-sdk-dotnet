using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PolicyTestResult
	/// </summary>
	[DataContract]
	public partial class PolicyTestResult : IEquatable<PolicyTestResult>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PolicyTestResult" /> class.
		/// </summary>
		/// <param name="Id">The ID of the policy being tested..</param>
		/// <param name="Name">The name of the policy being tested..</param>
		/// <param name="Result">The result of the evaluation against supplied test data..</param>
		/// <param name="PolicyConditionResults">The results of conditions, with their boolean result..</param>
		public PolicyTestResult(string Id = null, string Name = null, string Result = null, List<PolicyConditionResult> PolicyConditionResults = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Result = Result;
			this.PolicyConditionResults = PolicyConditionResults;

		}



		/// <summary>
		/// The ID of the policy being tested.
		/// </summary>
		/// <value>The ID of the policy being tested.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The name of the policy being tested.
		/// </summary>
		/// <value>The name of the policy being tested.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The result of the evaluation against supplied test data.
		/// </summary>
		/// <value>The result of the evaluation against supplied test data.</value>
		[DataMember(Name = "result", EmitDefaultValue = false)]
		public string Result { get; set; }



		/// <summary>
		/// The results of conditions, with their boolean result.
		/// </summary>
		/// <value>The results of conditions, with their boolean result.</value>
		[DataMember(Name = "policyConditionResults", EmitDefaultValue = false)]
		public List<PolicyConditionResult> PolicyConditionResults { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PolicyTestResult {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Result: ").Append(Result).Append("\n");
			sb.Append("  PolicyConditionResults: ").Append(PolicyConditionResults).Append("\n");
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
			return this.Equals(obj as PolicyTestResult);
		}

		/// <summary>
		/// Returns true if PolicyTestResult instances are equal
		/// </summary>
		/// <param name="other">Instance of PolicyTestResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PolicyTestResult other)
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
					this.Result == other.Result ||
					this.Result != null &&
					this.Result.Equals(other.Result)
				) &&
				(
					this.PolicyConditionResults == other.PolicyConditionResults ||
					this.PolicyConditionResults != null &&
					this.PolicyConditionResults.SequenceEqual(other.PolicyConditionResults)
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

				if (this.Result != null)
					hash = hash * 59 + this.Result.GetHashCode();

				if (this.PolicyConditionResults != null)
					hash = hash * 59 + this.PolicyConditionResults.GetHashCode();

				return hash;
			}
		}
	}

}
