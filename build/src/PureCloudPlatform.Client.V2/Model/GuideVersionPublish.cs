using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// GuideVersionPublish
	/// </summary>
	[DataContract]
	public partial class GuideVersionPublish : IEquatable<GuideVersionPublish>
	{
		/// <summary>
		/// The desired state of the guide version being published.
		/// </summary>
		/// <value>The desired state of the guide version being published.</value>
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
			/// Enum Testready for "TestReady"
			/// </summary>
			[EnumMember(Value = "TestReady")]
			Testready,

			/// <summary>
			/// Enum Productionready for "ProductionReady"
			/// </summary>
			[EnumMember(Value = "ProductionReady")]
			Productionready
		}
		/// <summary>
		/// The desired state of the guide version being published.
		/// </summary>
		/// <value>The desired state of the guide version being published.</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="GuideVersionPublish" /> class.
		/// </summary>
		/// <param name="State">The desired state of the guide version being published..</param>
		public GuideVersionPublish(StateEnum? State = null)
		{
			this.State = State;

		}




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GuideVersionPublish {\n");

			sb.Append("  State: ").Append(State).Append("\n");
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
			return this.Equals(obj as GuideVersionPublish);
		}

		/// <summary>
		/// Returns true if GuideVersionPublish instances are equal
		/// </summary>
		/// <param name="other">Instance of GuideVersionPublish to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GuideVersionPublish other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
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

				return hash;
			}
		}
	}

}
