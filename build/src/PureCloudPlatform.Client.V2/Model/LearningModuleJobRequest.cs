using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Learning module job request
	/// </summary>
	[DataContract]
	public partial class LearningModuleJobRequest : IEquatable<LearningModuleJobRequest>
	{
		/// <summary>
		/// The type for the learning module job
		/// </summary>
		/// <value>The type for the learning module job</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ActionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Reassign for "Reassign"
			/// </summary>
			[EnumMember(Value = "Reassign")]
			Reassign,

			/// <summary>
			/// Enum Gracefularchive for "GracefulArchive"
			/// </summary>
			[EnumMember(Value = "GracefulArchive")]
			Gracefularchive,

			/// <summary>
			/// Enum Immediatearchive for "ImmediateArchive"
			/// </summary>
			[EnumMember(Value = "ImmediateArchive")]
			Immediatearchive,

			/// <summary>
			/// Enum Unarchive for "Unarchive"
			/// </summary>
			[EnumMember(Value = "Unarchive")]
			Unarchive,

			/// <summary>
			/// Enum Assign for "Assign"
			/// </summary>
			[EnumMember(Value = "Assign")]
			Assign
		}
		/// <summary>
		/// The type for the learning module job
		/// </summary>
		/// <value>The type for the learning module job</value>
		[DataMember(Name = "action", EmitDefaultValue = false)]
		public ActionEnum? Action { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="LearningModuleJobRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected LearningModuleJobRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="LearningModuleJobRequest" /> class.
		/// </summary>
		/// <param name="Action">The type for the learning module job (required).</param>
		public LearningModuleJobRequest(ActionEnum? Action = null)
		{
			this.Action = Action;

		}




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LearningModuleJobRequest {\n");

			sb.Append("  Action: ").Append(Action).Append("\n");
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
			return this.Equals(obj as LearningModuleJobRequest);
		}

		/// <summary>
		/// Returns true if LearningModuleJobRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of LearningModuleJobRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LearningModuleJobRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Action == other.Action ||
					this.Action != null &&
					this.Action.Equals(other.Action)
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
				if (this.Action != null)
					hash = hash * 59 + this.Action.GetHashCode();

				return hash;
			}
		}
	}

}
