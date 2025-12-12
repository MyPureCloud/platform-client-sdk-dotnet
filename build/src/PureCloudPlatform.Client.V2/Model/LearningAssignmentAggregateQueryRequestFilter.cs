using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LearningAssignmentAggregateQueryRequestFilter
	/// </summary>
	[DataContract]
	public partial class LearningAssignmentAggregateQueryRequestFilter : IEquatable<LearningAssignmentAggregateQueryRequestFilter>
	{
		/// <summary>
		/// The logic used to combine the clauses
		/// </summary>
		/// <value>The logic used to combine the clauses</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum And for "And"
			/// </summary>
			[EnumMember(Value = "And")]
			And,

			/// <summary>
			/// Enum Or for "Or"
			/// </summary>
			[EnumMember(Value = "Or")]
			Or
		}
		/// <summary>
		/// The logic used to combine the clauses
		/// </summary>
		/// <value>The logic used to combine the clauses</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="LearningAssignmentAggregateQueryRequestFilter" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected LearningAssignmentAggregateQueryRequestFilter() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="LearningAssignmentAggregateQueryRequestFilter" /> class.
		/// </summary>
		/// <param name="Type">The logic used to combine the clauses (required).</param>
		/// <param name="Clauses">The list of clauses used to filter the data. Note that clauses must filter by attendeeId and a maximum of 100 user IDs are allowed (required).</param>
		public LearningAssignmentAggregateQueryRequestFilter(TypeEnum? Type = null, List<LearningAssignmentAggregateQueryRequestClause> Clauses = null)
		{
			this.Type = Type;
			this.Clauses = Clauses;

		}





		/// <summary>
		/// The list of clauses used to filter the data. Note that clauses must filter by attendeeId and a maximum of 100 user IDs are allowed
		/// </summary>
		/// <value>The list of clauses used to filter the data. Note that clauses must filter by attendeeId and a maximum of 100 user IDs are allowed</value>
		[DataMember(Name = "clauses", EmitDefaultValue = false)]
		public List<LearningAssignmentAggregateQueryRequestClause> Clauses { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LearningAssignmentAggregateQueryRequestFilter {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Clauses: ").Append(Clauses).Append("\n");
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
			return this.Equals(obj as LearningAssignmentAggregateQueryRequestFilter);
		}

		/// <summary>
		/// Returns true if LearningAssignmentAggregateQueryRequestFilter instances are equal
		/// </summary>
		/// <param name="other">Instance of LearningAssignmentAggregateQueryRequestFilter to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LearningAssignmentAggregateQueryRequestFilter other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Clauses == other.Clauses ||
					this.Clauses != null &&
					this.Clauses.SequenceEqual(other.Clauses)
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
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Clauses != null)
					hash = hash * 59 + this.Clauses.GetHashCode();

				return hash;
			}
		}
	}

}
