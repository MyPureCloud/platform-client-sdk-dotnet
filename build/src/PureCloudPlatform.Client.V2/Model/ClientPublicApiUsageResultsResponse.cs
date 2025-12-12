using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ClientPublicApiUsageResultsResponse
	/// </summary>
	[DataContract]
	public partial class ClientPublicApiUsageResultsResponse : IEquatable<ClientPublicApiUsageResultsResponse>
	{
		/// <summary>
		/// The status of the query.
		/// </summary>
		/// <value>The status of the query.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum QueryStatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Queued for "Queued"
			/// </summary>
			[EnumMember(Value = "Queued")]
			Queued,

			/// <summary>
			/// Enum Running for "Running"
			/// </summary>
			[EnumMember(Value = "Running")]
			Running,

			/// <summary>
			/// Enum Succeeded for "Succeeded"
			/// </summary>
			[EnumMember(Value = "Succeeded")]
			Succeeded,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed,

			/// <summary>
			/// Enum Cancelled for "Cancelled"
			/// </summary>
			[EnumMember(Value = "Cancelled")]
			Cancelled
		}
		/// <summary>
		/// The status of the query.
		/// </summary>
		/// <value>The status of the query.</value>
		[DataMember(Name = "queryStatus", EmitDefaultValue = false)]
		public QueryStatusEnum? QueryStatus { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientPublicApiUsageResultsResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ClientPublicApiUsageResultsResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ClientPublicApiUsageResultsResponse" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="QueryStatus">The status of the query. (required).</param>
		/// <param name="ErrorBody">The reason for the failure. This will only be present if the query is in a FAILURE state but may not be included even if the state is FAILURE.</param>
		/// <param name="NextUri">The uri to get the next set of results. Will only be included if there is another page to retrieve..</param>
		/// <param name="Entities">The results of the query..</param>
		public ClientPublicApiUsageResultsResponse(string Name = null, QueryStatusEnum? QueryStatus = null, ErrorBody ErrorBody = null, string NextUri = null, List<ClientPublicApiUsage> Entities = null)
		{
			this.Name = Name;
			this.QueryStatus = QueryStatus;
			this.ErrorBody = ErrorBody;
			this.NextUri = NextUri;
			this.Entities = Entities;

		}



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }





		/// <summary>
		/// The reason for the failure. This will only be present if the query is in a FAILURE state but may not be included even if the state is FAILURE
		/// </summary>
		/// <value>The reason for the failure. This will only be present if the query is in a FAILURE state but may not be included even if the state is FAILURE</value>
		[DataMember(Name = "errorBody", EmitDefaultValue = false)]
		public ErrorBody ErrorBody { get; set; }



		/// <summary>
		/// The uri to get the next set of results. Will only be included if there is another page to retrieve.
		/// </summary>
		/// <value>The uri to get the next set of results. Will only be included if there is another page to retrieve.</value>
		[DataMember(Name = "nextUri", EmitDefaultValue = false)]
		public string NextUri { get; set; }



		/// <summary>
		/// The results of the query.
		/// </summary>
		/// <value>The results of the query.</value>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<ClientPublicApiUsage> Entities { get; set; }



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
			sb.Append("class ClientPublicApiUsageResultsResponse {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  QueryStatus: ").Append(QueryStatus).Append("\n");
			sb.Append("  ErrorBody: ").Append(ErrorBody).Append("\n");
			sb.Append("  NextUri: ").Append(NextUri).Append("\n");
			sb.Append("  Entities: ").Append(Entities).Append("\n");
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
			return this.Equals(obj as ClientPublicApiUsageResultsResponse);
		}

		/// <summary>
		/// Returns true if ClientPublicApiUsageResultsResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of ClientPublicApiUsageResultsResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ClientPublicApiUsageResultsResponse other)
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
					this.QueryStatus == other.QueryStatus ||
					this.QueryStatus != null &&
					this.QueryStatus.Equals(other.QueryStatus)
				) &&
				(
					this.ErrorBody == other.ErrorBody ||
					this.ErrorBody != null &&
					this.ErrorBody.Equals(other.ErrorBody)
				) &&
				(
					this.NextUri == other.NextUri ||
					this.NextUri != null &&
					this.NextUri.Equals(other.NextUri)
				) &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.QueryStatus != null)
					hash = hash * 59 + this.QueryStatus.GetHashCode();

				if (this.ErrorBody != null)
					hash = hash * 59 + this.ErrorBody.GetHashCode();

				if (this.NextUri != null)
					hash = hash * 59 + this.NextUri.GetHashCode();

				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
