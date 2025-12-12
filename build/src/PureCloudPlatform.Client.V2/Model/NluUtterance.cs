using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// NluUtterance
	/// </summary>
	[DataContract]
	public partial class NluUtterance : IEquatable<NluUtterance>
	{
		/// <summary>
		/// The source of the utterance.
		/// </summary>
		/// <value>The source of the utterance.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SourceEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Generated for "Generated"
			/// </summary>
			[EnumMember(Value = "Generated")]
			Generated,

			/// <summary>
			/// Enum User for "User"
			/// </summary>
			[EnumMember(Value = "User")]
			User
		}
		/// <summary>
		/// The source of the utterance.
		/// </summary>
		/// <value>The source of the utterance.</value>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public SourceEnum? Source { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="NluUtterance" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected NluUtterance() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="NluUtterance" /> class.
		/// </summary>
		/// <param name="Source">The source of the utterance..</param>
		/// <param name="Segments">The list of segments that that constitute this utterance for the given intent. (required).</param>
		public NluUtterance(SourceEnum? Source = null, List<NluUtteranceSegment> Segments = null)
		{
			this.Source = Source;
			this.Segments = Segments;

		}



		/// <summary>
		/// ID of the utterance.
		/// </summary>
		/// <value>ID of the utterance.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }





		/// <summary>
		/// The list of segments that that constitute this utterance for the given intent.
		/// </summary>
		/// <value>The list of segments that that constitute this utterance for the given intent.</value>
		[DataMember(Name = "segments", EmitDefaultValue = false)]
		public List<NluUtteranceSegment> Segments { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NluUtterance {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Source: ").Append(Source).Append("\n");
			sb.Append("  Segments: ").Append(Segments).Append("\n");
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
			return this.Equals(obj as NluUtterance);
		}

		/// <summary>
		/// Returns true if NluUtterance instances are equal
		/// </summary>
		/// <param name="other">Instance of NluUtterance to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NluUtterance other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Source == other.Source ||
					this.Source != null &&
					this.Source.Equals(other.Source)
				) &&
				(
					this.Segments == other.Segments ||
					this.Segments != null &&
					this.Segments.SequenceEqual(other.Segments)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Source != null)
					hash = hash * 59 + this.Source.GetHashCode();

				if (this.Segments != null)
					hash = hash * 59 + this.Segments.GetHashCode();

				return hash;
			}
		}
	}

}
