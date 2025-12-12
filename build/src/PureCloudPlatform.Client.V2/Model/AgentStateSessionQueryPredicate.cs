using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AgentStateSessionQueryPredicate
	/// </summary>
	[DataContract]
	public partial class AgentStateSessionQueryPredicate : IEquatable<AgentStateSessionQueryPredicate>
	{
		/// <summary>
		/// Left hand side for dimension predicates
		/// </summary>
		/// <value>Left hand side for dimension predicates</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DimensionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Mediatype for "mediaType"
			/// </summary>
			[EnumMember(Value = "mediaType")]
			Mediatype,

			/// <summary>
			/// Enum Originatingdirection for "originatingDirection"
			/// </summary>
			[EnumMember(Value = "originatingDirection")]
			Originatingdirection,

			/// <summary>
			/// Enum Requestedlanguageid for "requestedLanguageId"
			/// </summary>
			[EnumMember(Value = "requestedLanguageId")]
			Requestedlanguageid,

			/// <summary>
			/// Enum Requestedroutingskillid for "requestedRoutingSkillId"
			/// </summary>
			[EnumMember(Value = "requestedRoutingSkillId")]
			Requestedroutingskillid,

			/// <summary>
			/// Enum Routedqueueid for "routedQueueId"
			/// </summary>
			[EnumMember(Value = "routedQueueId")]
			Routedqueueid,

			/// <summary>
			/// Enum Segmenttype for "segmentType"
			/// </summary>
			[EnumMember(Value = "segmentType")]
			Segmenttype
		}
		/// <summary>
		/// Left hand side for dimension predicates
		/// </summary>
		/// <value>Left hand side for dimension predicates</value>
		[DataMember(Name = "dimension", EmitDefaultValue = false)]
		public DimensionEnum? Dimension { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="AgentStateSessionQueryPredicate" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AgentStateSessionQueryPredicate() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentStateSessionQueryPredicate" /> class.
		/// </summary>
		/// <param name="Dimension">Left hand side for dimension predicates (required).</param>
		/// <param name="Value">Right hand side for dimension predicates (required).</param>
		public AgentStateSessionQueryPredicate(DimensionEnum? Dimension = null, string Value = null)
		{
			this.Dimension = Dimension;
			this.Value = Value;

		}





		/// <summary>
		/// Right hand side for dimension predicates
		/// </summary>
		/// <value>Right hand side for dimension predicates</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AgentStateSessionQueryPredicate {\n");

			sb.Append("  Dimension: ").Append(Dimension).Append("\n");
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
			return this.Equals(obj as AgentStateSessionQueryPredicate);
		}

		/// <summary>
		/// Returns true if AgentStateSessionQueryPredicate instances are equal
		/// </summary>
		/// <param name="other">Instance of AgentStateSessionQueryPredicate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AgentStateSessionQueryPredicate other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Dimension == other.Dimension ||
					this.Dimension != null &&
					this.Dimension.Equals(other.Dimension)
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
				if (this.Dimension != null)
					hash = hash * 59 + this.Dimension.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				return hash;
			}
		}
	}

}
