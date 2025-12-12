using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2FlowExecutionDataFlowidTopicFlowExecutionItem
	/// </summary>
	[DataContract]
	public partial class V2FlowExecutionDataFlowidTopicFlowExecutionItem : IEquatable<V2FlowExecutionDataFlowidTopicFlowExecutionItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicFlowExecutionItem" /> class.
		/// </summary>
		/// <param name="ObjectType">The type of executionItem that was executed..</param>
		/// <param name="ObjectId">If applicable, the actionId, menuId or taskId for the executionItem..</param>
		/// <param name="OutputPathId">If applicable, the identifier of the OutputPath that was taken..</param>
		/// <param name="ExecutionId">If applicable, the executionId for the executionItem..</param>
		/// <param name="StartDateTime">This is the starting time of the executionItem..</param>
		/// <param name="Error">Event generated when a Flow&#39;s Execution History is received and logged..</param>
		/// <param name="Warning">Event generated when a Flow&#39;s Execution History is received and logged..</param>
		/// <param name="LanguageTag">If applicable, the language tag associated set by the execution..</param>
		public V2FlowExecutionDataFlowidTopicFlowExecutionItem(string ObjectType = null, string ObjectId = null, string OutputPathId = null, string ExecutionId = null, DateTime? StartDateTime = null, V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo Error = null, V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo Warning = null, string LanguageTag = null)
		{
			this.ObjectType = ObjectType;
			this.ObjectId = ObjectId;
			this.OutputPathId = OutputPathId;
			this.ExecutionId = ExecutionId;
			this.StartDateTime = StartDateTime;
			this.Error = Error;
			this.Warning = Warning;
			this.LanguageTag = LanguageTag;

		}



		/// <summary>
		/// The type of executionItem that was executed.
		/// </summary>
		/// <value>The type of executionItem that was executed.</value>
		[DataMember(Name = "objectType", EmitDefaultValue = false)]
		public string ObjectType { get; set; }



		/// <summary>
		/// If applicable, the actionId, menuId or taskId for the executionItem.
		/// </summary>
		/// <value>If applicable, the actionId, menuId or taskId for the executionItem.</value>
		[DataMember(Name = "objectId", EmitDefaultValue = false)]
		public string ObjectId { get; set; }



		/// <summary>
		/// If applicable, the identifier of the OutputPath that was taken.
		/// </summary>
		/// <value>If applicable, the identifier of the OutputPath that was taken.</value>
		[DataMember(Name = "outputPathId", EmitDefaultValue = false)]
		public string OutputPathId { get; set; }



		/// <summary>
		/// If applicable, the executionId for the executionItem.
		/// </summary>
		/// <value>If applicable, the executionId for the executionItem.</value>
		[DataMember(Name = "executionId", EmitDefaultValue = false)]
		public string ExecutionId { get; set; }



		/// <summary>
		/// This is the starting time of the executionItem.
		/// </summary>
		/// <value>This is the starting time of the executionItem.</value>
		[DataMember(Name = "startDateTime", EmitDefaultValue = false)]
		public DateTime? StartDateTime { get; set; }



		/// <summary>
		/// Event generated when a Flow&#39;s Execution History is received and logged.
		/// </summary>
		/// <value>Event generated when a Flow&#39;s Execution History is received and logged.</value>
		[DataMember(Name = "error", EmitDefaultValue = false)]
		public V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo Error { get; set; }



		/// <summary>
		/// Event generated when a Flow&#39;s Execution History is received and logged.
		/// </summary>
		/// <value>Event generated when a Flow&#39;s Execution History is received and logged.</value>
		[DataMember(Name = "warning", EmitDefaultValue = false)]
		public V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo Warning { get; set; }



		/// <summary>
		/// If applicable, the language tag associated set by the execution.
		/// </summary>
		/// <value>If applicable, the language tag associated set by the execution.</value>
		[DataMember(Name = "languageTag", EmitDefaultValue = false)]
		public string LanguageTag { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2FlowExecutionDataFlowidTopicFlowExecutionItem {\n");

			sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
			sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
			sb.Append("  OutputPathId: ").Append(OutputPathId).Append("\n");
			sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
			sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
			sb.Append("  Error: ").Append(Error).Append("\n");
			sb.Append("  Warning: ").Append(Warning).Append("\n");
			sb.Append("  LanguageTag: ").Append(LanguageTag).Append("\n");
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
			return this.Equals(obj as V2FlowExecutionDataFlowidTopicFlowExecutionItem);
		}

		/// <summary>
		/// Returns true if V2FlowExecutionDataFlowidTopicFlowExecutionItem instances are equal
		/// </summary>
		/// <param name="other">Instance of V2FlowExecutionDataFlowidTopicFlowExecutionItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2FlowExecutionDataFlowidTopicFlowExecutionItem other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ObjectType == other.ObjectType ||
					this.ObjectType != null &&
					this.ObjectType.Equals(other.ObjectType)
				) &&
				(
					this.ObjectId == other.ObjectId ||
					this.ObjectId != null &&
					this.ObjectId.Equals(other.ObjectId)
				) &&
				(
					this.OutputPathId == other.OutputPathId ||
					this.OutputPathId != null &&
					this.OutputPathId.Equals(other.OutputPathId)
				) &&
				(
					this.ExecutionId == other.ExecutionId ||
					this.ExecutionId != null &&
					this.ExecutionId.Equals(other.ExecutionId)
				) &&
				(
					this.StartDateTime == other.StartDateTime ||
					this.StartDateTime != null &&
					this.StartDateTime.Equals(other.StartDateTime)
				) &&
				(
					this.Error == other.Error ||
					this.Error != null &&
					this.Error.Equals(other.Error)
				) &&
				(
					this.Warning == other.Warning ||
					this.Warning != null &&
					this.Warning.Equals(other.Warning)
				) &&
				(
					this.LanguageTag == other.LanguageTag ||
					this.LanguageTag != null &&
					this.LanguageTag.Equals(other.LanguageTag)
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
				if (this.ObjectType != null)
					hash = hash * 59 + this.ObjectType.GetHashCode();

				if (this.ObjectId != null)
					hash = hash * 59 + this.ObjectId.GetHashCode();

				if (this.OutputPathId != null)
					hash = hash * 59 + this.OutputPathId.GetHashCode();

				if (this.ExecutionId != null)
					hash = hash * 59 + this.ExecutionId.GetHashCode();

				if (this.StartDateTime != null)
					hash = hash * 59 + this.StartDateTime.GetHashCode();

				if (this.Error != null)
					hash = hash * 59 + this.Error.GetHashCode();

				if (this.Warning != null)
					hash = hash * 59 + this.Warning.GetHashCode();

				if (this.LanguageTag != null)
					hash = hash * 59 + this.LanguageTag.GetHashCode();

				return hash;
			}
		}
	}

}
