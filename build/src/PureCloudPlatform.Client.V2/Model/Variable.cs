using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Variable
	/// </summary>
	[DataContract]
	public partial class Variable : IEquatable<Variable>
	{
		/// <summary>
		/// The data type of the variable.
		/// </summary>
		/// <value>The data type of the variable.</value>
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
			/// Enum String for "String"
			/// </summary>
			[EnumMember(Value = "String")]
			String,

			/// <summary>
			/// Enum Integer for "Integer"
			/// </summary>
			[EnumMember(Value = "Integer")]
			Integer,

			/// <summary>
			/// Enum Number for "Number"
			/// </summary>
			[EnumMember(Value = "Number")]
			Number,

			/// <summary>
			/// Enum Boolean for "Boolean"
			/// </summary>
			[EnumMember(Value = "Boolean")]
			Boolean
		}
		/// <summary>
		/// The scope that determines the variable's usage context within Guides runtime.
		/// </summary>
		/// <value>The scope that determines the variable's usage context within Guides runtime.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ScopeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Input for "Input"
			/// </summary>
			[EnumMember(Value = "Input")]
			Input,

			/// <summary>
			/// Enum Output for "Output"
			/// </summary>
			[EnumMember(Value = "Output")]
			Output,

			/// <summary>
			/// Enum Inputandoutput for "InputAndOutput"
			/// </summary>
			[EnumMember(Value = "InputAndOutput")]
			Inputandoutput
		}
		/// <summary>
		/// The data type of the variable.
		/// </summary>
		/// <value>The data type of the variable.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// The scope that determines the variable's usage context within Guides runtime.
		/// </summary>
		/// <value>The scope that determines the variable's usage context within Guides runtime.</value>
		[DataMember(Name = "scope", EmitDefaultValue = false)]
		public ScopeEnum? Scope { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Variable" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Variable() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Variable" /> class.
		/// </summary>
		/// <param name="Name">The name of the variable. (required).</param>
		/// <param name="Type">The data type of the variable. (required).</param>
		/// <param name="Scope">The scope that determines the variable&#39;s usage context within Guides runtime. (required).</param>
		/// <param name="Description">The description of the variable used by Guides runtime for input/output handling..</param>
		public Variable(string Name = null, TypeEnum? Type = null, ScopeEnum? Scope = null, string Description = null)
		{
			this.Name = Name;
			this.Type = Type;
			this.Scope = Scope;
			this.Description = Description;

		}



		/// <summary>
		/// The name of the variable.
		/// </summary>
		/// <value>The name of the variable.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }







		/// <summary>
		/// The description of the variable used by Guides runtime for input/output handling.
		/// </summary>
		/// <value>The description of the variable used by Guides runtime for input/output handling.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Variable {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Scope: ").Append(Scope).Append("\n");
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
			return this.Equals(obj as Variable);
		}

		/// <summary>
		/// Returns true if Variable instances are equal
		/// </summary>
		/// <param name="other">Instance of Variable to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Variable other)
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
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Scope == other.Scope ||
					this.Scope != null &&
					this.Scope.Equals(other.Scope)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Scope != null)
					hash = hash * 59 + this.Scope.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				return hash;
			}
		}
	}

}
