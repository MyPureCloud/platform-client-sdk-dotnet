using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialerAttemptLimitsConfigChangeAttemptLimits
	/// </summary>
	[DataContract]
	public partial class DialerAttemptLimitsConfigChangeAttemptLimits : IEquatable<DialerAttemptLimitsConfigChangeAttemptLimits>
	{
		/// <summary>
		/// After how long the number of attempts will be set back to 0
		/// </summary>
		/// <value>After how long the number of attempts will be set back to 0</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ResetPeriodEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Never for "NEVER"
			/// </summary>
			[EnumMember(Value = "NEVER")]
			Never,

			/// <summary>
			/// Enum Today for "TODAY"
			/// </summary>
			[EnumMember(Value = "TODAY")]
			Today
		}
		/// <summary>
		/// After how long the number of attempts will be set back to 0
		/// </summary>
		/// <value>After how long the number of attempts will be set back to 0</value>
		[DataMember(Name = "resetPeriod", EmitDefaultValue = false)]
		public ResetPeriodEnum? ResetPeriod { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DialerAttemptLimitsConfigChangeAttemptLimits" /> class.
		/// </summary>
		/// <param name="MaxAttemptsPerContact">MaxAttemptsPerContact.</param>
		/// <param name="MaxAttemptsPerNumber">MaxAttemptsPerNumber.</param>
		/// <param name="TimeZoneId">The timezone is necessary to define when \&quot;today\&quot; starts and ends.</param>
		/// <param name="ResetPeriod">After how long the number of attempts will be set back to 0.</param>
		/// <param name="RecallEntries">Configuration for recall attempts.</param>
		/// <param name="BreadthFirstRecalls">Whether recalls are performed before considering other numbers (true) or after (false).</param>
		/// <param name="AdditionalProperties">AdditionalProperties.</param>
		/// <param name="Id">The globally unique identifier for the object..</param>
		/// <param name="Name">The UI-visible name of the object.</param>
		/// <param name="DateCreated">Creation time of the entity.</param>
		/// <param name="DateModified">Last modified time of the entity.</param>
		/// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
		/// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
		public DialerAttemptLimitsConfigChangeAttemptLimits(long? MaxAttemptsPerContact = null, long? MaxAttemptsPerNumber = null, string TimeZoneId = null, ResetPeriodEnum? ResetPeriod = null, Dictionary<string, DialerAttemptLimitsConfigChangeRecallEntry> RecallEntries = null, bool? BreadthFirstRecalls = null, Dictionary<string, Object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null, Dictionary<string, Object> GetAdditionalProperties = null)
		{
			this.MaxAttemptsPerContact = MaxAttemptsPerContact;
			this.MaxAttemptsPerNumber = MaxAttemptsPerNumber;
			this.TimeZoneId = TimeZoneId;
			this.ResetPeriod = ResetPeriod;
			this.RecallEntries = RecallEntries;
			this.BreadthFirstRecalls = BreadthFirstRecalls;
			this.AdditionalProperties = AdditionalProperties;
			this.Id = Id;
			this.Name = Name;
			this.DateCreated = DateCreated;
			this.DateModified = DateModified;
			this.Version = Version;
			this.GetAdditionalProperties = GetAdditionalProperties;

		}



		/// <summary>
		/// Gets or Sets MaxAttemptsPerContact
		/// </summary>
		[DataMember(Name = "maxAttemptsPerContact", EmitDefaultValue = false)]
		public long? MaxAttemptsPerContact { get; set; }



		/// <summary>
		/// Gets or Sets MaxAttemptsPerNumber
		/// </summary>
		[DataMember(Name = "maxAttemptsPerNumber", EmitDefaultValue = false)]
		public long? MaxAttemptsPerNumber { get; set; }



		/// <summary>
		/// The timezone is necessary to define when \&quot;today\&quot; starts and ends
		/// </summary>
		/// <value>The timezone is necessary to define when \&quot;today\&quot; starts and ends</value>
		[DataMember(Name = "timeZoneId", EmitDefaultValue = false)]
		public string TimeZoneId { get; set; }





		/// <summary>
		/// Configuration for recall attempts
		/// </summary>
		/// <value>Configuration for recall attempts</value>
		[DataMember(Name = "recallEntries", EmitDefaultValue = false)]
		public Dictionary<string, DialerAttemptLimitsConfigChangeRecallEntry> RecallEntries { get; set; }



		/// <summary>
		/// Whether recalls are performed before considering other numbers (true) or after (false)
		/// </summary>
		/// <value>Whether recalls are performed before considering other numbers (true) or after (false)</value>
		[DataMember(Name = "breadthFirstRecalls", EmitDefaultValue = false)]
		public bool? BreadthFirstRecalls { get; set; }



		/// <summary>
		/// Gets or Sets AdditionalProperties
		/// </summary>
		[DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> AdditionalProperties { get; set; }



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The UI-visible name of the object
		/// </summary>
		/// <value>The UI-visible name of the object</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Creation time of the entity
		/// </summary>
		/// <value>Creation time of the entity</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// Last modified time of the entity
		/// </summary>
		/// <value>Last modified time of the entity</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



		/// <summary>
		/// Required for updates, must match the version number of the most recent update
		/// </summary>
		/// <value>Required for updates, must match the version number of the most recent update</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public long? Version { get; set; }



		/// <summary>
		/// Gets or Sets GetAdditionalProperties
		/// </summary>
		[DataMember(Name = "getAdditionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> GetAdditionalProperties { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DialerAttemptLimitsConfigChangeAttemptLimits {\n");

			sb.Append("  MaxAttemptsPerContact: ").Append(MaxAttemptsPerContact).Append("\n");
			sb.Append("  MaxAttemptsPerNumber: ").Append(MaxAttemptsPerNumber).Append("\n");
			sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
			sb.Append("  ResetPeriod: ").Append(ResetPeriod).Append("\n");
			sb.Append("  RecallEntries: ").Append(RecallEntries).Append("\n");
			sb.Append("  BreadthFirstRecalls: ").Append(BreadthFirstRecalls).Append("\n");
			sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  GetAdditionalProperties: ").Append(GetAdditionalProperties).Append("\n");
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
			return this.Equals(obj as DialerAttemptLimitsConfigChangeAttemptLimits);
		}

		/// <summary>
		/// Returns true if DialerAttemptLimitsConfigChangeAttemptLimits instances are equal
		/// </summary>
		/// <param name="other">Instance of DialerAttemptLimitsConfigChangeAttemptLimits to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialerAttemptLimitsConfigChangeAttemptLimits other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MaxAttemptsPerContact == other.MaxAttemptsPerContact ||
					this.MaxAttemptsPerContact != null &&
					this.MaxAttemptsPerContact.Equals(other.MaxAttemptsPerContact)
				) &&
				(
					this.MaxAttemptsPerNumber == other.MaxAttemptsPerNumber ||
					this.MaxAttemptsPerNumber != null &&
					this.MaxAttemptsPerNumber.Equals(other.MaxAttemptsPerNumber)
				) &&
				(
					this.TimeZoneId == other.TimeZoneId ||
					this.TimeZoneId != null &&
					this.TimeZoneId.Equals(other.TimeZoneId)
				) &&
				(
					this.ResetPeriod == other.ResetPeriod ||
					this.ResetPeriod != null &&
					this.ResetPeriod.Equals(other.ResetPeriod)
				) &&
				(
					this.RecallEntries == other.RecallEntries ||
					this.RecallEntries != null &&
					this.RecallEntries.SequenceEqual(other.RecallEntries)
				) &&
				(
					this.BreadthFirstRecalls == other.BreadthFirstRecalls ||
					this.BreadthFirstRecalls != null &&
					this.BreadthFirstRecalls.Equals(other.BreadthFirstRecalls)
				) &&
				(
					this.AdditionalProperties == other.AdditionalProperties ||
					this.AdditionalProperties != null &&
					this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
				) &&
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
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.GetAdditionalProperties == other.GetAdditionalProperties ||
					this.GetAdditionalProperties != null &&
					this.GetAdditionalProperties.SequenceEqual(other.GetAdditionalProperties)
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
				if (this.MaxAttemptsPerContact != null)
					hash = hash * 59 + this.MaxAttemptsPerContact.GetHashCode();

				if (this.MaxAttemptsPerNumber != null)
					hash = hash * 59 + this.MaxAttemptsPerNumber.GetHashCode();

				if (this.TimeZoneId != null)
					hash = hash * 59 + this.TimeZoneId.GetHashCode();

				if (this.ResetPeriod != null)
					hash = hash * 59 + this.ResetPeriod.GetHashCode();

				if (this.RecallEntries != null)
					hash = hash * 59 + this.RecallEntries.GetHashCode();

				if (this.BreadthFirstRecalls != null)
					hash = hash * 59 + this.BreadthFirstRecalls.GetHashCode();

				if (this.AdditionalProperties != null)
					hash = hash * 59 + this.AdditionalProperties.GetHashCode();

				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.GetAdditionalProperties != null)
					hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

				return hash;
			}
		}
	}

}
