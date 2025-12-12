using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CallMediaPolicy
	/// </summary>
	[DataContract]
	public partial class CallMediaPolicy : IEquatable<CallMediaPolicy>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CallMediaPolicy" /> class.
		/// </summary>
		/// <param name="Actions">Actions applied when specified conditions are met.</param>
		/// <param name="Conditions">Conditions for when actions should be applied.</param>
		public CallMediaPolicy(PolicyActions Actions = null, CallMediaPolicyConditions Conditions = null)
		{
			this.Actions = Actions;
			this.Conditions = Conditions;

		}



		/// <summary>
		/// Actions applied when specified conditions are met
		/// </summary>
		/// <value>Actions applied when specified conditions are met</value>
		[DataMember(Name = "actions", EmitDefaultValue = false)]
		public PolicyActions Actions { get; set; }



		/// <summary>
		/// Conditions for when actions should be applied
		/// </summary>
		/// <value>Conditions for when actions should be applied</value>
		[DataMember(Name = "conditions", EmitDefaultValue = false)]
		public CallMediaPolicyConditions Conditions { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CallMediaPolicy {\n");

			sb.Append("  Actions: ").Append(Actions).Append("\n");
			sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
			return this.Equals(obj as CallMediaPolicy);
		}

		/// <summary>
		/// Returns true if CallMediaPolicy instances are equal
		/// </summary>
		/// <param name="other">Instance of CallMediaPolicy to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CallMediaPolicy other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Actions == other.Actions ||
					this.Actions != null &&
					this.Actions.Equals(other.Actions)
				) &&
				(
					this.Conditions == other.Conditions ||
					this.Conditions != null &&
					this.Conditions.Equals(other.Conditions)
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
				if (this.Actions != null)
					hash = hash * 59 + this.Actions.GetHashCode();

				if (this.Conditions != null)
					hash = hash * 59 + this.Conditions.GetHashCode();

				return hash;
			}
		}
	}

}
