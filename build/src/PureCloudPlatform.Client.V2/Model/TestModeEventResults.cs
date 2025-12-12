using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Information about event test mode execution
	/// </summary>
	[DataContract]
	public partial class TestModeEventResults : IEquatable<TestModeEventResults>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TestModeEventResults" /> class.
		/// </summary>
		/// <param name="SchemaValidation">Information about the validation of the schema of the event body passed in to test mode.</param>
		/// <param name="TriggerMatchValidation">Information about matched and unmatched triggers.</param>
		public TestModeEventResults(TestSchemaOperation SchemaValidation = null, TestMatchesEventOperation TriggerMatchValidation = null)
		{
			this.SchemaValidation = SchemaValidation;
			this.TriggerMatchValidation = TriggerMatchValidation;

		}



		/// <summary>
		/// Information about the validation of the schema of the event body passed in to test mode
		/// </summary>
		/// <value>Information about the validation of the schema of the event body passed in to test mode</value>
		[DataMember(Name = "schemaValidation", EmitDefaultValue = false)]
		public TestSchemaOperation SchemaValidation { get; set; }



		/// <summary>
		/// Information about matched and unmatched triggers
		/// </summary>
		/// <value>Information about matched and unmatched triggers</value>
		[DataMember(Name = "triggerMatchValidation", EmitDefaultValue = false)]
		public TestMatchesEventOperation TriggerMatchValidation { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TestModeEventResults {\n");

			sb.Append("  SchemaValidation: ").Append(SchemaValidation).Append("\n");
			sb.Append("  TriggerMatchValidation: ").Append(TriggerMatchValidation).Append("\n");
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
			return this.Equals(obj as TestModeEventResults);
		}

		/// <summary>
		/// Returns true if TestModeEventResults instances are equal
		/// </summary>
		/// <param name="other">Instance of TestModeEventResults to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TestModeEventResults other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SchemaValidation == other.SchemaValidation ||
					this.SchemaValidation != null &&
					this.SchemaValidation.Equals(other.SchemaValidation)
				) &&
				(
					this.TriggerMatchValidation == other.TriggerMatchValidation ||
					this.TriggerMatchValidation != null &&
					this.TriggerMatchValidation.Equals(other.TriggerMatchValidation)
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
				if (this.SchemaValidation != null)
					hash = hash * 59 + this.SchemaValidation.GetHashCode();

				if (this.TriggerMatchValidation != null)
					hash = hash * 59 + this.TriggerMatchValidation.GetHashCode();

				return hash;
			}
		}
	}

}
