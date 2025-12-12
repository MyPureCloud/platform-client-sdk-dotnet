using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// HistoricalDataJobEntityStatus
	/// </summary>
	[DataContract]
	public partial class HistoricalDataJobEntityStatus : IEquatable<HistoricalDataJobEntityStatus>
	{
		/// <summary>
		/// Property denoting the status of the delete job
		/// </summary>
		/// <value>Property denoting the status of the delete job</value>
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
			/// Enum Processing for "Processing"
			/// </summary>
			[EnumMember(Value = "Processing")]
			Processing,

			/// <summary>
			/// Enum Complete for "Complete"
			/// </summary>
			[EnumMember(Value = "Complete")]
			Complete,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error
		}
		/// <summary>
		/// Property denoting the status of the delete job
		/// </summary>
		/// <value>Property denoting the status of the delete job</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="HistoricalDataJobEntityStatus" /> class.
		/// </summary>
		/// <param name="State">Property denoting the status of the delete job.</param>
		public HistoricalDataJobEntityStatus(StateEnum? State = null)
		{
			this.State = State;

		}



		/// <summary>
		/// The Job Id Request
		/// </summary>
		/// <value>The Job Id Request</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }





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
			sb.Append("class HistoricalDataJobEntityStatus {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
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
			return this.Equals(obj as HistoricalDataJobEntityStatus);
		}

		/// <summary>
		/// Returns true if HistoricalDataJobEntityStatus instances are equal
		/// </summary>
		/// <param name="other">Instance of HistoricalDataJobEntityStatus to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(HistoricalDataJobEntityStatus other)
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
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
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

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
