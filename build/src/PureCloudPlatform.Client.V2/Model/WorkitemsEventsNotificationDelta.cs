using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkitemsEventsNotificationDelta
	/// </summary>
	[DataContract]
	public partial class WorkitemsEventsNotificationDelta : IEquatable<WorkitemsEventsNotificationDelta>
	{
		/// <summary>
		/// Gets or Sets Op
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum OpEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Add for "add"
			/// </summary>
			[EnumMember(Value = "add")]
			Add,

			/// <summary>
			/// Enum Remove for "remove"
			/// </summary>
			[EnumMember(Value = "remove")]
			Remove,

			/// <summary>
			/// Enum Replace for "replace"
			/// </summary>
			[EnumMember(Value = "replace")]
			Replace,

			/// <summary>
			/// Enum Unknown for "unknown"
			/// </summary>
			[EnumMember(Value = "unknown")]
			Unknown
		}
		/// <summary>
		/// Gets or Sets Op
		/// </summary>
		[DataMember(Name = "op", EmitDefaultValue = false)]
		public OpEnum? Op { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemsEventsNotificationDelta" /> class.
		/// </summary>
		/// <param name="Op">Op.</param>
		/// <param name="Field">Field.</param>
		/// <param name="OldValue">OldValue.</param>
		/// <param name="NewValue">NewValue.</param>
		public WorkitemsEventsNotificationDelta(OpEnum? Op = null, string Field = null, string OldValue = null, string NewValue = null)
		{
			this.Op = Op;
			this.Field = Field;
			this.OldValue = OldValue;
			this.NewValue = NewValue;

		}





		/// <summary>
		/// Gets or Sets Field
		/// </summary>
		[DataMember(Name = "field", EmitDefaultValue = false)]
		public string Field { get; set; }



		/// <summary>
		/// Gets or Sets OldValue
		/// </summary>
		[DataMember(Name = "oldValue", EmitDefaultValue = false)]
		public string OldValue { get; set; }



		/// <summary>
		/// Gets or Sets NewValue
		/// </summary>
		[DataMember(Name = "newValue", EmitDefaultValue = false)]
		public string NewValue { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkitemsEventsNotificationDelta {\n");

			sb.Append("  Op: ").Append(Op).Append("\n");
			sb.Append("  Field: ").Append(Field).Append("\n");
			sb.Append("  OldValue: ").Append(OldValue).Append("\n");
			sb.Append("  NewValue: ").Append(NewValue).Append("\n");
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
			return this.Equals(obj as WorkitemsEventsNotificationDelta);
		}

		/// <summary>
		/// Returns true if WorkitemsEventsNotificationDelta instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkitemsEventsNotificationDelta to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkitemsEventsNotificationDelta other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Op == other.Op ||
					this.Op != null &&
					this.Op.Equals(other.Op)
				) &&
				(
					this.Field == other.Field ||
					this.Field != null &&
					this.Field.Equals(other.Field)
				) &&
				(
					this.OldValue == other.OldValue ||
					this.OldValue != null &&
					this.OldValue.Equals(other.OldValue)
				) &&
				(
					this.NewValue == other.NewValue ||
					this.NewValue != null &&
					this.NewValue.Equals(other.NewValue)
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
				if (this.Op != null)
					hash = hash * 59 + this.Op.GetHashCode();

				if (this.Field != null)
					hash = hash * 59 + this.Field.GetHashCode();

				if (this.OldValue != null)
					hash = hash * 59 + this.OldValue.GetHashCode();

				if (this.NewValue != null)
					hash = hash * 59 + this.NewValue.GetHashCode();

				return hash;
			}
		}
	}

}
