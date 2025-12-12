using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// This contains contextual information about an invoking entity.
	/// </summary>
	[DataContract]
	public partial class V2FlowExecutionDataFlowidTopicInvokingContextInfo : IEquatable<V2FlowExecutionDataFlowidTopicInvokingContextInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicInvokingContextInfo" /> class.
		/// </summary>
		/// <param name="Flow">Flow.</param>
		/// <param name="JourneyActionMap">JourneyActionMap.</param>
		/// <param name="ProcessAutomation">ProcessAutomation.</param>
		/// <param name="Quality">Quality.</param>
		/// <param name="Workitem">Workitem.</param>
		public V2FlowExecutionDataFlowidTopicInvokingContextInfo(V2FlowExecutionDataFlowidTopicInvokingFlowContext Flow = null, V2FlowExecutionDataFlowidTopicInvokingJourneyActionMapContext JourneyActionMap = null, V2FlowExecutionDataFlowidTopicInvokingProcessAutomationContext ProcessAutomation = null, V2FlowExecutionDataFlowidTopicInvokingQualityContext Quality = null, V2FlowExecutionDataFlowidTopicInvokingWorkitemContext Workitem = null)
		{
			this.Flow = Flow;
			this.JourneyActionMap = JourneyActionMap;
			this.ProcessAutomation = ProcessAutomation;
			this.Quality = Quality;
			this.Workitem = Workitem;

		}



		/// <summary>
		/// Gets or Sets Flow
		/// </summary>
		[DataMember(Name = "flow", EmitDefaultValue = false)]
		public V2FlowExecutionDataFlowidTopicInvokingFlowContext Flow { get; set; }



		/// <summary>
		/// Gets or Sets JourneyActionMap
		/// </summary>
		[DataMember(Name = "journeyActionMap", EmitDefaultValue = false)]
		public V2FlowExecutionDataFlowidTopicInvokingJourneyActionMapContext JourneyActionMap { get; set; }



		/// <summary>
		/// Gets or Sets ProcessAutomation
		/// </summary>
		[DataMember(Name = "processAutomation", EmitDefaultValue = false)]
		public V2FlowExecutionDataFlowidTopicInvokingProcessAutomationContext ProcessAutomation { get; set; }



		/// <summary>
		/// Gets or Sets Quality
		/// </summary>
		[DataMember(Name = "quality", EmitDefaultValue = false)]
		public V2FlowExecutionDataFlowidTopicInvokingQualityContext Quality { get; set; }



		/// <summary>
		/// Gets or Sets Workitem
		/// </summary>
		[DataMember(Name = "workitem", EmitDefaultValue = false)]
		public V2FlowExecutionDataFlowidTopicInvokingWorkitemContext Workitem { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2FlowExecutionDataFlowidTopicInvokingContextInfo {\n");

			sb.Append("  Flow: ").Append(Flow).Append("\n");
			sb.Append("  JourneyActionMap: ").Append(JourneyActionMap).Append("\n");
			sb.Append("  ProcessAutomation: ").Append(ProcessAutomation).Append("\n");
			sb.Append("  Quality: ").Append(Quality).Append("\n");
			sb.Append("  Workitem: ").Append(Workitem).Append("\n");
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
			return this.Equals(obj as V2FlowExecutionDataFlowidTopicInvokingContextInfo);
		}

		/// <summary>
		/// Returns true if V2FlowExecutionDataFlowidTopicInvokingContextInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of V2FlowExecutionDataFlowidTopicInvokingContextInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2FlowExecutionDataFlowidTopicInvokingContextInfo other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Flow == other.Flow ||
					this.Flow != null &&
					this.Flow.Equals(other.Flow)
				) &&
				(
					this.JourneyActionMap == other.JourneyActionMap ||
					this.JourneyActionMap != null &&
					this.JourneyActionMap.Equals(other.JourneyActionMap)
				) &&
				(
					this.ProcessAutomation == other.ProcessAutomation ||
					this.ProcessAutomation != null &&
					this.ProcessAutomation.Equals(other.ProcessAutomation)
				) &&
				(
					this.Quality == other.Quality ||
					this.Quality != null &&
					this.Quality.Equals(other.Quality)
				) &&
				(
					this.Workitem == other.Workitem ||
					this.Workitem != null &&
					this.Workitem.Equals(other.Workitem)
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
				if (this.Flow != null)
					hash = hash * 59 + this.Flow.GetHashCode();

				if (this.JourneyActionMap != null)
					hash = hash * 59 + this.JourneyActionMap.GetHashCode();

				if (this.ProcessAutomation != null)
					hash = hash * 59 + this.ProcessAutomation.GetHashCode();

				if (this.Quality != null)
					hash = hash * 59 + this.Quality.GetHashCode();

				if (this.Workitem != null)
					hash = hash * 59 + this.Workitem.GetHashCode();

				return hash;
			}
		}
	}

}
