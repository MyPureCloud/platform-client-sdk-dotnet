using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UsageExecutionResult
	/// </summary>
	[DataContract]
	public partial class UsageExecutionResult : IEquatable<UsageExecutionResult>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UsageExecutionResult" /> class.
		/// </summary>
		/// <param name="ExecutionId">The id of the query execution.</param>
		/// <param name="ResultsUri">URI where the query results can be retrieved.</param>
		public UsageExecutionResult(string ExecutionId = null, string ResultsUri = null)
		{
			this.ExecutionId = ExecutionId;
			this.ResultsUri = ResultsUri;

		}



		/// <summary>
		/// The id of the query execution
		/// </summary>
		/// <value>The id of the query execution</value>
		[DataMember(Name = "executionId", EmitDefaultValue = false)]
		public string ExecutionId { get; set; }



		/// <summary>
		/// URI where the query results can be retrieved
		/// </summary>
		/// <value>URI where the query results can be retrieved</value>
		[DataMember(Name = "resultsUri", EmitDefaultValue = false)]
		public string ResultsUri { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UsageExecutionResult {\n");

			sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
			sb.Append("  ResultsUri: ").Append(ResultsUri).Append("\n");
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
			return this.Equals(obj as UsageExecutionResult);
		}

		/// <summary>
		/// Returns true if UsageExecutionResult instances are equal
		/// </summary>
		/// <param name="other">Instance of UsageExecutionResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UsageExecutionResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ExecutionId == other.ExecutionId ||
					this.ExecutionId != null &&
					this.ExecutionId.Equals(other.ExecutionId)
				) &&
				(
					this.ResultsUri == other.ResultsUri ||
					this.ResultsUri != null &&
					this.ResultsUri.Equals(other.ResultsUri)
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
				if (this.ExecutionId != null)
					hash = hash * 59 + this.ExecutionId.GetHashCode();

				if (this.ResultsUri != null)
					hash = hash * 59 + this.ResultsUri.GetHashCode();

				return hash;
			}
		}
	}

}
