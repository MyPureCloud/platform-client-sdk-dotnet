using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// VisibilityCondition
	/// </summary>
	[DataContract]
	public partial class VisibilityCondition : IEquatable<VisibilityCondition>
	{
		/// <summary>
		/// Gets or Sets CombiningOperation
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum CombiningOperationEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum And for "AND"
			/// </summary>
			[EnumMember(Value = "AND")]
			And,

			/// <summary>
			/// Enum Or for "OR"
			/// </summary>
			[EnumMember(Value = "OR")]
			Or
		}
		/// <summary>
		/// Gets or Sets CombiningOperation
		/// </summary>
		[DataMember(Name = "combiningOperation", EmitDefaultValue = false)]
		public CombiningOperationEnum? CombiningOperation { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="VisibilityCondition" /> class.
		/// </summary>
		/// <param name="CombiningOperation">CombiningOperation.</param>
		/// <param name="Predicates">A list of strings, each representing the location in the form of the Answer Option to depend on. In the format of \&quot;/form/questionGroup/{questionGroupIndex}/question/{questionIndex}/answer/{answerIndex}\&quot; or, to assume the current question group, \&quot;../question/{questionIndex}/answer/{answerIndex}\&quot;. Note: Indexes are zero-based.</param>
		public VisibilityCondition(CombiningOperationEnum? CombiningOperation = null, List<Object> Predicates = null)
		{
			this.CombiningOperation = CombiningOperation;
			this.Predicates = Predicates;

		}





		/// <summary>
		/// A list of strings, each representing the location in the form of the Answer Option to depend on. In the format of \&quot;/form/questionGroup/{questionGroupIndex}/question/{questionIndex}/answer/{answerIndex}\&quot; or, to assume the current question group, \&quot;../question/{questionIndex}/answer/{answerIndex}\&quot;. Note: Indexes are zero-based
		/// </summary>
		/// <value>A list of strings, each representing the location in the form of the Answer Option to depend on. In the format of \&quot;/form/questionGroup/{questionGroupIndex}/question/{questionIndex}/answer/{answerIndex}\&quot; or, to assume the current question group, \&quot;../question/{questionIndex}/answer/{answerIndex}\&quot;. Note: Indexes are zero-based</value>
		[DataMember(Name = "predicates", EmitDefaultValue = false)]
		public List<Object> Predicates { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class VisibilityCondition {\n");

			sb.Append("  CombiningOperation: ").Append(CombiningOperation).Append("\n");
			sb.Append("  Predicates: ").Append(Predicates).Append("\n");
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
			return this.Equals(obj as VisibilityCondition);
		}

		/// <summary>
		/// Returns true if VisibilityCondition instances are equal
		/// </summary>
		/// <param name="other">Instance of VisibilityCondition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(VisibilityCondition other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.CombiningOperation == other.CombiningOperation ||
					this.CombiningOperation != null &&
					this.CombiningOperation.Equals(other.CombiningOperation)
				) &&
				(
					this.Predicates == other.Predicates ||
					this.Predicates != null &&
					this.Predicates.SequenceEqual(other.Predicates)
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
				if (this.CombiningOperation != null)
					hash = hash * 59 + this.CombiningOperation.GetHashCode();

				if (this.Predicates != null)
					hash = hash * 59 + this.Predicates.GetHashCode();

				return hash;
			}
		}
	}

}
