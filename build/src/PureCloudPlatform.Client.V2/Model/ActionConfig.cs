using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Defines components of the Action Config.
	/// </summary>
	[DataContract]
	public partial class ActionConfig : IEquatable<ActionConfig>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ActionConfig" /> class.
		/// </summary>
		/// <param name="TimeoutSeconds">Optional 1-60 second timeout enforced on the execution or test of this action. This setting is invalid for Custom Authentication Actions..</param>
		/// <param name="Request">Configuration of outbound request..</param>
		/// <param name="Response">Configuration of response processing..</param>
		public ActionConfig(int? TimeoutSeconds = null, RequestConfig Request = null, ResponseConfig Response = null)
		{
			this.TimeoutSeconds = TimeoutSeconds;
			this.Request = Request;
			this.Response = Response;

		}



		/// <summary>
		/// Optional 1-60 second timeout enforced on the execution or test of this action. This setting is invalid for Custom Authentication Actions.
		/// </summary>
		/// <value>Optional 1-60 second timeout enforced on the execution or test of this action. This setting is invalid for Custom Authentication Actions.</value>
		[DataMember(Name = "timeoutSeconds", EmitDefaultValue = false)]
		public int? TimeoutSeconds { get; set; }



		/// <summary>
		/// Configuration of outbound request.
		/// </summary>
		/// <value>Configuration of outbound request.</value>
		[DataMember(Name = "request", EmitDefaultValue = false)]
		public RequestConfig Request { get; set; }



		/// <summary>
		/// Configuration of response processing.
		/// </summary>
		/// <value>Configuration of response processing.</value>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public ResponseConfig Response { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ActionConfig {\n");

			sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
			sb.Append("  Request: ").Append(Request).Append("\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
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
			return this.Equals(obj as ActionConfig);
		}

		/// <summary>
		/// Returns true if ActionConfig instances are equal
		/// </summary>
		/// <param name="other">Instance of ActionConfig to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ActionConfig other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.TimeoutSeconds == other.TimeoutSeconds ||
					this.TimeoutSeconds != null &&
					this.TimeoutSeconds.Equals(other.TimeoutSeconds)
				) &&
				(
					this.Request == other.Request ||
					this.Request != null &&
					this.Request.Equals(other.Request)
				) &&
				(
					this.Response == other.Response ||
					this.Response != null &&
					this.Response.Equals(other.Response)
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
				if (this.TimeoutSeconds != null)
					hash = hash * 59 + this.TimeoutSeconds.GetHashCode();

				if (this.Request != null)
					hash = hash * 59 + this.Request.GetHashCode();

				if (this.Response != null)
					hash = hash * 59 + this.Response.GetHashCode();

				return hash;
			}
		}
	}

}
