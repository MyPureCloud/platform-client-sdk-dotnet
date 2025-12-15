using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Action function settings.
	/// </summary>
	[DataContract]
	public partial class Function : IEquatable<Function>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="Function" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Function() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Function" /> class.
		/// </summary>
		/// <param name="Description">Description of the function. Limit 255 characters. (required).</param>
		/// <param name="Handler">Handler entry point into zip file to execute function. Should be path within upload function package to the invocation module without language extension, followed by a period and then exported invocation method name. e.g. &#39;src/index.handler&#39; (required).</param>
		/// <param name="Runtime">Runtime required for execution. Valid runtimes change over time as versions are deprecated. Use /integrations/actions/functions/runtimes for current list. (required).</param>
		/// <param name="TimeoutSeconds">Execution timeout to apply to function. Value is in seconds. Range allowed 1 to 15. Default value 15 seconds..</param>
		public Function(string Description = null, string Handler = null, string Runtime = null, int? TimeoutSeconds = null)
		{
			this.Description = Description;
			this.Handler = Handler;
			this.Runtime = Runtime;
			this.TimeoutSeconds = TimeoutSeconds;

		}



		/// <summary>
		/// Function identifier.
		/// </summary>
		/// <value>Function identifier.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Function name. This is automatically created based on the Action Id.
		/// </summary>
		/// <value>Function name. This is automatically created based on the Action Id.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; private set; }



		/// <summary>
		/// Description of the function. Limit 255 characters.
		/// </summary>
		/// <value>Description of the function. Limit 255 characters.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Date and time function was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date and time function was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// Zip file identifier.
		/// </summary>
		/// <value>Zip file identifier.</value>
		[DataMember(Name = "zipId", EmitDefaultValue = false)]
		public string ZipId { get; private set; }



		/// <summary>
		/// Handler entry point into zip file to execute function. Should be path within upload function package to the invocation module without language extension, followed by a period and then exported invocation method name. e.g. &#39;src/index.handler&#39;
		/// </summary>
		/// <value>Handler entry point into zip file to execute function. Should be path within upload function package to the invocation module without language extension, followed by a period and then exported invocation method name. e.g. &#39;src/index.handler&#39;</value>
		[DataMember(Name = "handler", EmitDefaultValue = false)]
		public string Handler { get; set; }



		/// <summary>
		/// Runtime required for execution. Valid runtimes change over time as versions are deprecated. Use /integrations/actions/functions/runtimes for current list.
		/// </summary>
		/// <value>Runtime required for execution. Valid runtimes change over time as versions are deprecated. Use /integrations/actions/functions/runtimes for current list.</value>
		[DataMember(Name = "runtime", EmitDefaultValue = false)]
		public string Runtime { get; set; }



		/// <summary>
		/// Execution timeout to apply to function. Value is in seconds. Range allowed 1 to 15. Default value 15 seconds.
		/// </summary>
		/// <value>Execution timeout to apply to function. Value is in seconds. Range allowed 1 to 15. Default value 15 seconds.</value>
		[DataMember(Name = "timeoutSeconds", EmitDefaultValue = false)]
		public int? TimeoutSeconds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Function {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  ZipId: ").Append(ZipId).Append("\n");
			sb.Append("  Handler: ").Append(Handler).Append("\n");
			sb.Append("  Runtime: ").Append(Runtime).Append("\n");
			sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
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
			return this.Equals(obj as Function);
		}

		/// <summary>
		/// Returns true if Function instances are equal
		/// </summary>
		/// <param name="other">Instance of Function to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Function other)
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
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.ZipId == other.ZipId ||
					this.ZipId != null &&
					this.ZipId.Equals(other.ZipId)
				) &&
				(
					this.Handler == other.Handler ||
					this.Handler != null &&
					this.Handler.Equals(other.Handler)
				) &&
				(
					this.Runtime == other.Runtime ||
					this.Runtime != null &&
					this.Runtime.Equals(other.Runtime)
				) &&
				(
					this.TimeoutSeconds == other.TimeoutSeconds ||
					this.TimeoutSeconds != null &&
					this.TimeoutSeconds.Equals(other.TimeoutSeconds)
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

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.ZipId != null)
					hash = hash * 59 + this.ZipId.GetHashCode();

				if (this.Handler != null)
					hash = hash * 59 + this.Handler.GetHashCode();

				if (this.Runtime != null)
					hash = hash * 59 + this.Runtime.GetHashCode();

				if (this.TimeoutSeconds != null)
					hash = hash * 59 + this.TimeoutSeconds.GetHashCode();

				return hash;
			}
		}
	}

}
