using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ClientUsageQueryResponse
	/// </summary>
	[DataContract]
	public partial class ClientUsageQueryResponse : IEquatable<ClientUsageQueryResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientUsageQueryResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ClientUsageQueryResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ClientUsageQueryResponse" /> class.
		/// </summary>
		/// <param name="Id">The jobId of the query. (required).</param>
		/// <param name="Name">Name.</param>
		/// <param name="ResultsUri">The uri to get the results..</param>
		public ClientUsageQueryResponse(string Id = null, string Name = null, string ResultsUri = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.ResultsUri = ResultsUri;

		}



		/// <summary>
		/// The jobId of the query.
		/// </summary>
		/// <value>The jobId of the query.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The uri to get the results.
		/// </summary>
		/// <value>The uri to get the results.</value>
		[DataMember(Name = "resultsUri", EmitDefaultValue = false)]
		public string ResultsUri { get; set; }



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
			sb.Append("class ClientUsageQueryResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ResultsUri: ").Append(ResultsUri).Append("\n");
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
			return this.Equals(obj as ClientUsageQueryResponse);
		}

		/// <summary>
		/// Returns true if ClientUsageQueryResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of ClientUsageQueryResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ClientUsageQueryResponse other)
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
					this.ResultsUri == other.ResultsUri ||
					this.ResultsUri != null &&
					this.ResultsUri.Equals(other.ResultsUri)
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

				if (this.ResultsUri != null)
					hash = hash * 59 + this.ResultsUri.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
