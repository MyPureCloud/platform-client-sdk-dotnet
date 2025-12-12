using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkitemDateBasedConditionUpdate
	/// </summary>
	[DataContract]
	public partial class WorkitemDateBasedConditionUpdate : IEquatable<WorkitemDateBasedConditionUpdate>
	{
		/// <summary>
		/// The name of the workitem date attribute.
		/// </summary>
		/// <value>The name of the workitem date attribute.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum AttributeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Datedue for "dateDue"
			/// </summary>
			[EnumMember(Value = "dateDue")]
			Datedue,

			/// <summary>
			/// Enum Dateexpires for "dateExpires"
			/// </summary>
			[EnumMember(Value = "dateExpires")]
			Dateexpires,

			/// <summary>
			/// Enum Ttl for "ttl"
			/// </summary>
			[EnumMember(Value = "ttl")]
			Ttl,

			/// <summary>
			/// Enum Datecreated for "dateCreated"
			/// </summary>
			[EnumMember(Value = "dateCreated")]
			Datecreated
		}
		/// <summary>
		/// The name of the workitem date attribute.
		/// </summary>
		/// <value>The name of the workitem date attribute.</value>
		[DataMember(Name = "attribute", EmitDefaultValue = false)]
		public AttributeEnum? Attribute { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemDateBasedConditionUpdate" /> class.
		/// </summary>
		/// <param name="Attribute">The name of the workitem date attribute..</param>
		/// <param name="RelativeMinutesToInvocation">The time in minutes before or after the date attribute..</param>
		public WorkitemDateBasedConditionUpdate(AttributeEnum? Attribute = null, int? RelativeMinutesToInvocation = null)
		{
			this.Attribute = Attribute;
			this.RelativeMinutesToInvocation = RelativeMinutesToInvocation;

		}





		/// <summary>
		/// The time in minutes before or after the date attribute.
		/// </summary>
		/// <value>The time in minutes before or after the date attribute.</value>
		[DataMember(Name = "relativeMinutesToInvocation", EmitDefaultValue = false)]
		public int? RelativeMinutesToInvocation { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkitemDateBasedConditionUpdate {\n");

			sb.Append("  Attribute: ").Append(Attribute).Append("\n");
			sb.Append("  RelativeMinutesToInvocation: ").Append(RelativeMinutesToInvocation).Append("\n");
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
			return this.Equals(obj as WorkitemDateBasedConditionUpdate);
		}

		/// <summary>
		/// Returns true if WorkitemDateBasedConditionUpdate instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkitemDateBasedConditionUpdate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkitemDateBasedConditionUpdate other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Attribute == other.Attribute ||
					this.Attribute != null &&
					this.Attribute.Equals(other.Attribute)
				) &&
				(
					this.RelativeMinutesToInvocation == other.RelativeMinutesToInvocation ||
					this.RelativeMinutesToInvocation != null &&
					this.RelativeMinutesToInvocation.Equals(other.RelativeMinutesToInvocation)
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
				if (this.Attribute != null)
					hash = hash * 59 + this.Attribute.GetHashCode();

				if (this.RelativeMinutesToInvocation != null)
					hash = hash * 59 + this.RelativeMinutesToInvocation.GetHashCode();

				return hash;
			}
		}
	}

}
