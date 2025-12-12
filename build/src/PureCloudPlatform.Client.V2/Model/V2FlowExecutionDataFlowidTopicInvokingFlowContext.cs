using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// This contains information about the flow that invoked this execution.  Both a flow execution and action identifier are needed to uniquely identify the invocation point.
	/// </summary>
	[DataContract]
	public partial class V2FlowExecutionDataFlowidTopicInvokingFlowContext : IEquatable<V2FlowExecutionDataFlowidTopicInvokingFlowContext>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicInvokingFlowContext" /> class.
		/// </summary>
		/// <param name="FlowExecutionId">The flow execution identifier whose runtime that invoked this..</param>
		/// <param name="ObjectExecutionId">The object execution identifier within the flow whose runtime that invoked this.  In Architect flows, this object execution identifier will be either an action execution identifier or a menu execution identifier..</param>
		public V2FlowExecutionDataFlowidTopicInvokingFlowContext(string FlowExecutionId = null, string ObjectExecutionId = null)
		{
			this.FlowExecutionId = FlowExecutionId;
			this.ObjectExecutionId = ObjectExecutionId;

		}



		/// <summary>
		/// The flow execution identifier whose runtime that invoked this.
		/// </summary>
		/// <value>The flow execution identifier whose runtime that invoked this.</value>
		[DataMember(Name = "flowExecutionId", EmitDefaultValue = false)]
		public string FlowExecutionId { get; set; }



		/// <summary>
		/// The object execution identifier within the flow whose runtime that invoked this.  In Architect flows, this object execution identifier will be either an action execution identifier or a menu execution identifier.
		/// </summary>
		/// <value>The object execution identifier within the flow whose runtime that invoked this.  In Architect flows, this object execution identifier will be either an action execution identifier or a menu execution identifier.</value>
		[DataMember(Name = "objectExecutionId", EmitDefaultValue = false)]
		public string ObjectExecutionId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2FlowExecutionDataFlowidTopicInvokingFlowContext {\n");

			sb.Append("  FlowExecutionId: ").Append(FlowExecutionId).Append("\n");
			sb.Append("  ObjectExecutionId: ").Append(ObjectExecutionId).Append("\n");
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
			return this.Equals(obj as V2FlowExecutionDataFlowidTopicInvokingFlowContext);
		}

		/// <summary>
		/// Returns true if V2FlowExecutionDataFlowidTopicInvokingFlowContext instances are equal
		/// </summary>
		/// <param name="other">Instance of V2FlowExecutionDataFlowidTopicInvokingFlowContext to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2FlowExecutionDataFlowidTopicInvokingFlowContext other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.FlowExecutionId == other.FlowExecutionId ||
					this.FlowExecutionId != null &&
					this.FlowExecutionId.Equals(other.FlowExecutionId)
				) &&
				(
					this.ObjectExecutionId == other.ObjectExecutionId ||
					this.ObjectExecutionId != null &&
					this.ObjectExecutionId.Equals(other.ObjectExecutionId)
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
				if (this.FlowExecutionId != null)
					hash = hash * 59 + this.FlowExecutionId.GetHashCode();

				if (this.ObjectExecutionId != null)
					hash = hash * 59 + this.ObjectExecutionId.GetHashCode();

				return hash;
			}
		}
	}

}
