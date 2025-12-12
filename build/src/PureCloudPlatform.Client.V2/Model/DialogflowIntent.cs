using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialogflowIntent
	/// </summary>
	[DataContract]
	public partial class DialogflowIntent : IEquatable<DialogflowIntent>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="DialogflowIntent" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DialogflowIntent() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DialogflowIntent" /> class.
		/// </summary>
		/// <param name="Name">The intent name (required).</param>
		/// <param name="Parameters">An object mapping parameter names to Parameter objects (required).</param>
		public DialogflowIntent(string Name = null, Dictionary<string, DialogflowParameter> Parameters = null)
		{
			this.Name = Name;
			this.Parameters = Parameters;

		}



		/// <summary>
		/// The intent name
		/// </summary>
		/// <value>The intent name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// An object mapping parameter names to Parameter objects
		/// </summary>
		/// <value>An object mapping parameter names to Parameter objects</value>
		[DataMember(Name = "parameters", EmitDefaultValue = false)]
		public Dictionary<string, DialogflowParameter> Parameters { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DialogflowIntent {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
			return this.Equals(obj as DialogflowIntent);
		}

		/// <summary>
		/// Returns true if DialogflowIntent instances are equal
		/// </summary>
		/// <param name="other">Instance of DialogflowIntent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialogflowIntent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Parameters == other.Parameters ||
					this.Parameters != null &&
					this.Parameters.SequenceEqual(other.Parameters)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Parameters != null)
					hash = hash * 59 + this.Parameters.GetHashCode();

				return hash;
			}
		}
	}

}
