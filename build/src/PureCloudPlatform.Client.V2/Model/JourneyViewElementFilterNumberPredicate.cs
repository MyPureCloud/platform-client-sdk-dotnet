using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A numeric filter on an element within a journey view
	/// </summary>
	[DataContract]
	public partial class JourneyViewElementFilterNumberPredicate : IEquatable<JourneyViewElementFilterNumberPredicate>
	{
		/// <summary>
		/// Optional operator, default is Matches. Valid values: Matches
		/// </summary>
		/// <value>Optional operator, default is Matches. Valid values: Matches</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum OperatorEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Matches for "Matches"
			/// </summary>
			[EnumMember(Value = "Matches")]
			Matches,

			/// <summary>
			/// Enum Notmatches for "NotMatches"
			/// </summary>
			[EnumMember(Value = "NotMatches")]
			Notmatches
		}
		/// <summary>
		/// Optional operator, default is Matches. Valid values: Matches
		/// </summary>
		/// <value>Optional operator, default is Matches. Valid values: Matches</value>
		[DataMember(Name = "operator", EmitDefaultValue = false)]
		public OperatorEnum? Operator { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyViewElementFilterNumberPredicate" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected JourneyViewElementFilterNumberPredicate() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyViewElementFilterNumberPredicate" /> class.
		/// </summary>
		/// <param name="Dimension">the element&#39;s attribute being filtered on (required).</param>
		/// <param name="Operator">Optional operator, default is Matches. Valid values: Matches.</param>
		/// <param name="NoValue">set this to true if no specific value to be considered.</param>
		/// <param name="Range">the range of comparators to filter on (required).</param>
		public JourneyViewElementFilterNumberPredicate(string Dimension = null, OperatorEnum? Operator = null, bool? NoValue = null, JourneyViewElementFilterRange Range = null)
		{
			this.Dimension = Dimension;
			this.Operator = Operator;
			this.NoValue = NoValue;
			this.Range = Range;

		}



		/// <summary>
		/// the element&#39;s attribute being filtered on
		/// </summary>
		/// <value>the element&#39;s attribute being filtered on</value>
		[DataMember(Name = "dimension", EmitDefaultValue = false)]
		public string Dimension { get; set; }





		/// <summary>
		/// set this to true if no specific value to be considered
		/// </summary>
		/// <value>set this to true if no specific value to be considered</value>
		[DataMember(Name = "noValue", EmitDefaultValue = false)]
		public bool? NoValue { get; set; }



		/// <summary>
		/// the range of comparators to filter on
		/// </summary>
		/// <value>the range of comparators to filter on</value>
		[DataMember(Name = "range", EmitDefaultValue = false)]
		public JourneyViewElementFilterRange Range { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyViewElementFilterNumberPredicate {\n");

			sb.Append("  Dimension: ").Append(Dimension).Append("\n");
			sb.Append("  Operator: ").Append(Operator).Append("\n");
			sb.Append("  NoValue: ").Append(NoValue).Append("\n");
			sb.Append("  Range: ").Append(Range).Append("\n");
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
			return this.Equals(obj as JourneyViewElementFilterNumberPredicate);
		}

		/// <summary>
		/// Returns true if JourneyViewElementFilterNumberPredicate instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyViewElementFilterNumberPredicate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyViewElementFilterNumberPredicate other)
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
					this.Operator == other.Operator ||
					this.Operator != null &&
					this.Operator.Equals(other.Operator)
				) &&
				(
					this.NoValue == other.NoValue ||
					this.NoValue != null &&
					this.NoValue.Equals(other.NoValue)
				) &&
				(
					this.Range == other.Range ||
					this.Range != null &&
					this.Range.Equals(other.Range)
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

				if (this.Operator != null)
					hash = hash * 59 + this.Operator.GetHashCode();

				if (this.NoValue != null)
					hash = hash * 59 + this.NoValue.GetHashCode();

				if (this.Range != null)
					hash = hash * 59 + this.Range.GetHashCode();

				return hash;
			}
		}
	}

}
