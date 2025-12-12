using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Contains localized labels used in messenger apps
	/// </summary>
	[DataContract]
	public partial class LocalizedLabels : IEquatable<LocalizedLabels>
	{
		/// <summary>
		/// Contains localized label key used in messenger homescreen and push notification. PushNotificationTitle and PushNotificationBody keys are required when notifications are enabled.
		/// </summary>
		/// <value>Contains localized label key used in messenger homescreen and push notification. PushNotificationTitle and PushNotificationBody keys are required when notifications are enabled.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum KeyEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Messengerhomeheadertitle for "MessengerHomeHeaderTitle"
			/// </summary>
			[EnumMember(Value = "MessengerHomeHeaderTitle")]
			Messengerhomeheadertitle,

			/// <summary>
			/// Enum Messengerhomeheadersubtitle for "MessengerHomeHeaderSubTitle"
			/// </summary>
			[EnumMember(Value = "MessengerHomeHeaderSubTitle")]
			Messengerhomeheadersubtitle,

			/// <summary>
			/// Enum Pushnotificationtitle for "PushNotificationTitle"
			/// </summary>
			[EnumMember(Value = "PushNotificationTitle")]
			Pushnotificationtitle,

			/// <summary>
			/// Enum Pushnotificationbody for "PushNotificationBody"
			/// </summary>
			[EnumMember(Value = "PushNotificationBody")]
			Pushnotificationbody
		}
		/// <summary>
		/// Contains localized label key used in messenger homescreen and push notification. PushNotificationTitle and PushNotificationBody keys are required when notifications are enabled.
		/// </summary>
		/// <value>Contains localized label key used in messenger homescreen and push notification. PushNotificationTitle and PushNotificationBody keys are required when notifications are enabled.</value>
		[DataMember(Name = "key", EmitDefaultValue = false)]
		public KeyEnum? Key { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="LocalizedLabels" /> class.
		/// </summary>
		/// <param name="Key">Contains localized label key used in messenger homescreen and push notification. PushNotificationTitle and PushNotificationBody keys are required when notifications are enabled..</param>
		/// <param name="Value">Contains localized label value used in messenger homescreen and push notification.</param>
		public LocalizedLabels(KeyEnum? Key = null, string Value = null)
		{
			this.Key = Key;
			this.Value = Value;

		}





		/// <summary>
		/// Contains localized label value used in messenger homescreen and push notification
		/// </summary>
		/// <value>Contains localized label value used in messenger homescreen and push notification</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LocalizedLabels {\n");

			sb.Append("  Key: ").Append(Key).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return this.Equals(obj as LocalizedLabels);
		}

		/// <summary>
		/// Returns true if LocalizedLabels instances are equal
		/// </summary>
		/// <param name="other">Instance of LocalizedLabels to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LocalizedLabels other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Key == other.Key ||
					this.Key != null &&
					this.Key.Equals(other.Key)
				) &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
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
				if (this.Key != null)
					hash = hash * 59 + this.Key.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				return hash;
			}
		}
	}

}
