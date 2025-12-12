using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Model for a Nuance bot transfer node
	/// </summary>
	[DataContract]
	public partial class NuanceBotTransferNode : IEquatable<NuanceBotTransferNode>
	{
		/// <summary>
		/// The transfer node type
		/// </summary>
		/// <value>The transfer node type</value>
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
			/// Enum End for "End"
			/// </summary>
			[EnumMember(Value = "End")]
			End,

			/// <summary>
			/// Enum Escalate for "Escalate"
			/// </summary>
			[EnumMember(Value = "Escalate")]
			Escalate
		}
		/// <summary>
		/// The transfer node type
		/// </summary>
		/// <value>The transfer node type</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="NuanceBotTransferNode" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected NuanceBotTransferNode() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="NuanceBotTransferNode" /> class.
		/// </summary>
		/// <param name="Id">The transfer node ID (required).</param>
		/// <param name="Name">The transfer node name (required).</param>
		/// <param name="Type">The transfer node type (required).</param>
		/// <param name="Description">The transfer node description.</param>
		/// <param name="RequestVariables">List of variables associated with this transfer node.</param>
		public NuanceBotTransferNode(string Id = null, string Name = null, TypeEnum? Type = null, string Description = null, List<NuanceBotVariable> RequestVariables = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Type = Type;
			this.Description = Description;
			this.RequestVariables = RequestVariables;

		}



		/// <summary>
		/// The transfer node ID
		/// </summary>
		/// <value>The transfer node ID</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The transfer node name
		/// </summary>
		/// <value>The transfer node name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }





		/// <summary>
		/// The transfer node description
		/// </summary>
		/// <value>The transfer node description</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// List of variables associated with this transfer node
		/// </summary>
		/// <value>List of variables associated with this transfer node</value>
		[DataMember(Name = "requestVariables", EmitDefaultValue = false)]
		public List<NuanceBotVariable> RequestVariables { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NuanceBotTransferNode {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  RequestVariables: ").Append(RequestVariables).Append("\n");
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
			return this.Equals(obj as NuanceBotTransferNode);
		}

		/// <summary>
		/// Returns true if NuanceBotTransferNode instances are equal
		/// </summary>
		/// <param name="other">Instance of NuanceBotTransferNode to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NuanceBotTransferNode other)
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
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.RequestVariables == other.RequestVariables ||
					this.RequestVariables != null &&
					this.RequestVariables.SequenceEqual(other.RequestVariables)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.RequestVariables != null)
					hash = hash * 59 + this.RequestVariables.GetHashCode();

				return hash;
			}
		}
	}

}
