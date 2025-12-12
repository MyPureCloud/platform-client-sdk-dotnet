using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LongTermRequirementsErrorDetail
	/// </summary>
	[DataContract]
	public partial class LongTermRequirementsErrorDetail : IEquatable<LongTermRequirementsErrorDetail>
	{
		/// <summary>
		/// The error code
		/// </summary>
		/// <value>The error code</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum InternalErrorCodeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Timedout for "TimedOut"
			/// </summary>
			[EnumMember(Value = "TimedOut")]
			Timedout,

			/// <summary>
			/// Enum Nodata for "NoData"
			/// </summary>
			[EnumMember(Value = "NoData")]
			Nodata,

			/// <summary>
			/// Enum Clientdatainvalid for "ClientDataInvalid"
			/// </summary>
			[EnumMember(Value = "ClientDataInvalid")]
			Clientdatainvalid,

			/// <summary>
			/// Enum Configurationinvalid for "ConfigurationInvalid"
			/// </summary>
			[EnumMember(Value = "ConfigurationInvalid")]
			Configurationinvalid,

			/// <summary>
			/// Enum Requirementsfailed for "RequirementsFailed"
			/// </summary>
			[EnumMember(Value = "RequirementsFailed")]
			Requirementsfailed
		}
		/// <summary>
		/// The error code
		/// </summary>
		/// <value>The error code</value>
		[DataMember(Name = "internalErrorCode", EmitDefaultValue = false)]
		public InternalErrorCodeEnum? InternalErrorCode { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="LongTermRequirementsErrorDetail" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected LongTermRequirementsErrorDetail() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="LongTermRequirementsErrorDetail" /> class.
		/// </summary>
		/// <param name="InternalErrorCode">The error code (required).</param>
		/// <param name="Description">The description of the error code (required).</param>
		public LongTermRequirementsErrorDetail(InternalErrorCodeEnum? InternalErrorCode = null, string Description = null)
		{
			this.InternalErrorCode = InternalErrorCode;
			this.Description = Description;

		}





		/// <summary>
		/// The description of the error code
		/// </summary>
		/// <value>The description of the error code</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LongTermRequirementsErrorDetail {\n");

			sb.Append("  InternalErrorCode: ").Append(InternalErrorCode).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
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
			return this.Equals(obj as LongTermRequirementsErrorDetail);
		}

		/// <summary>
		/// Returns true if LongTermRequirementsErrorDetail instances are equal
		/// </summary>
		/// <param name="other">Instance of LongTermRequirementsErrorDetail to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LongTermRequirementsErrorDetail other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.InternalErrorCode == other.InternalErrorCode ||
					this.InternalErrorCode != null &&
					this.InternalErrorCode.Equals(other.InternalErrorCode)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
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
				if (this.InternalErrorCode != null)
					hash = hash * 59 + this.InternalErrorCode.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				return hash;
			}
		}
	}

}
