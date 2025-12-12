using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SourceSyncResponse
	/// </summary>
	[DataContract]
	public partial class SourceSyncResponse : IEquatable<SourceSyncResponse>
	{
		/// <summary>
		/// Sync state.
		/// </summary>
		/// <value>Sync state.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Success for "Success"
			/// </summary>
			[EnumMember(Value = "Success")]
			Success,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed,

			/// <summary>
			/// Enum Inprogress for "InProgress"
			/// </summary>
			[EnumMember(Value = "InProgress")]
			Inprogress,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// Sync state.
		/// </summary>
		/// <value>Sync state.</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="SourceSyncResponse" /> class.
		/// </summary>
		/// <param name="State">Sync state..</param>
		/// <param name="Error">Sync error..</param>
		/// <param name="DateCreated">Synchronization creation date-time for this source. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateModified">Synchronization last modification date-time for this source. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="KnowledgeBase">Knowledge base to which this synchronization belongs..</param>
		/// <param name="Source">Source to which this synchronization belongs..</param>
		public SourceSyncResponse(StateEnum? State = null, ErrorBody Error = null, DateTime? DateCreated = null, DateTime? DateModified = null, AddressableEntityRef KnowledgeBase = null, AddressableEntityRef Source = null)
		{
			this.State = State;
			this.Error = Error;
			this.DateCreated = DateCreated;
			this.DateModified = DateModified;
			this.KnowledgeBase = KnowledgeBase;
			this.Source = Source;

		}





		/// <summary>
		/// Sync error.
		/// </summary>
		/// <value>Sync error.</value>
		[DataMember(Name = "error", EmitDefaultValue = false)]
		public ErrorBody Error { get; set; }



		/// <summary>
		/// Synchronization creation date-time for this source. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Synchronization creation date-time for this source. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// Synchronization last modification date-time for this source. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Synchronization last modification date-time for this source. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



		/// <summary>
		/// Knowledge base to which this synchronization belongs.
		/// </summary>
		/// <value>Knowledge base to which this synchronization belongs.</value>
		[DataMember(Name = "knowledgeBase", EmitDefaultValue = false)]
		public AddressableEntityRef KnowledgeBase { get; set; }



		/// <summary>
		/// Source to which this synchronization belongs.
		/// </summary>
		/// <value>Source to which this synchronization belongs.</value>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public AddressableEntityRef Source { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SourceSyncResponse {\n");

			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  Error: ").Append(Error).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
			sb.Append("  Source: ").Append(Source).Append("\n");
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
			return this.Equals(obj as SourceSyncResponse);
		}

		/// <summary>
		/// Returns true if SourceSyncResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of SourceSyncResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SourceSyncResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
				) &&
				(
					this.Error == other.Error ||
					this.Error != null &&
					this.Error.Equals(other.Error)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.KnowledgeBase == other.KnowledgeBase ||
					this.KnowledgeBase != null &&
					this.KnowledgeBase.Equals(other.KnowledgeBase)
				) &&
				(
					this.Source == other.Source ||
					this.Source != null &&
					this.Source.Equals(other.Source)
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
				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.Error != null)
					hash = hash * 59 + this.Error.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.KnowledgeBase != null)
					hash = hash * 59 + this.KnowledgeBase.GetHashCode();

				if (this.Source != null)
					hash = hash * 59 + this.Source.GetHashCode();

				return hash;
			}
		}
	}

}
