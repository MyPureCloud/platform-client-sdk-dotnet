using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Form configuration for response management
	/// </summary>
	[DataContract]
	public partial class Form : IEquatable<Form>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="Form" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Form() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Form" /> class.
		/// </summary>
		/// <param name="FormDescription">Description of the form (required).</param>
		/// <param name="ReceivedMessage">Message displayed when response is received (required).</param>
		/// <param name="ReplyMessage">Message displayed as reply (required).</param>
		/// <param name="Introduction">Introduction section of the form.</param>
		/// <param name="FormPages">Pages of the form (required).</param>
		/// <param name="ShowSummary">Whether to show a summary after form completion (required).</param>
		public Form(string FormDescription = null, FormMessage ReceivedMessage = null, FormMessage ReplyMessage = null, FormIntroduction Introduction = null, List<FormPage> FormPages = null, bool? ShowSummary = null)
		{
			this.FormDescription = FormDescription;
			this.ReceivedMessage = ReceivedMessage;
			this.ReplyMessage = ReplyMessage;
			this.Introduction = Introduction;
			this.FormPages = FormPages;
			this.ShowSummary = ShowSummary;

		}



		/// <summary>
		/// Description of the form
		/// </summary>
		/// <value>Description of the form</value>
		[DataMember(Name = "formDescription", EmitDefaultValue = false)]
		public string FormDescription { get; set; }



		/// <summary>
		/// Message displayed when response is received
		/// </summary>
		/// <value>Message displayed when response is received</value>
		[DataMember(Name = "receivedMessage", EmitDefaultValue = false)]
		public FormMessage ReceivedMessage { get; set; }



		/// <summary>
		/// Message displayed as reply
		/// </summary>
		/// <value>Message displayed as reply</value>
		[DataMember(Name = "replyMessage", EmitDefaultValue = false)]
		public FormMessage ReplyMessage { get; set; }



		/// <summary>
		/// Introduction section of the form
		/// </summary>
		/// <value>Introduction section of the form</value>
		[DataMember(Name = "introduction", EmitDefaultValue = false)]
		public FormIntroduction Introduction { get; set; }



		/// <summary>
		/// Pages of the form
		/// </summary>
		/// <value>Pages of the form</value>
		[DataMember(Name = "formPages", EmitDefaultValue = false)]
		public List<FormPage> FormPages { get; set; }



		/// <summary>
		/// Whether to show a summary after form completion
		/// </summary>
		/// <value>Whether to show a summary after form completion</value>
		[DataMember(Name = "showSummary", EmitDefaultValue = false)]
		public bool? ShowSummary { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Form {\n");

			sb.Append("  FormDescription: ").Append(FormDescription).Append("\n");
			sb.Append("  ReceivedMessage: ").Append(ReceivedMessage).Append("\n");
			sb.Append("  ReplyMessage: ").Append(ReplyMessage).Append("\n");
			sb.Append("  Introduction: ").Append(Introduction).Append("\n");
			sb.Append("  FormPages: ").Append(FormPages).Append("\n");
			sb.Append("  ShowSummary: ").Append(ShowSummary).Append("\n");
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
			return this.Equals(obj as Form);
		}

		/// <summary>
		/// Returns true if Form instances are equal
		/// </summary>
		/// <param name="other">Instance of Form to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Form other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.FormDescription == other.FormDescription ||
					this.FormDescription != null &&
					this.FormDescription.Equals(other.FormDescription)
				) &&
				(
					this.ReceivedMessage == other.ReceivedMessage ||
					this.ReceivedMessage != null &&
					this.ReceivedMessage.Equals(other.ReceivedMessage)
				) &&
				(
					this.ReplyMessage == other.ReplyMessage ||
					this.ReplyMessage != null &&
					this.ReplyMessage.Equals(other.ReplyMessage)
				) &&
				(
					this.Introduction == other.Introduction ||
					this.Introduction != null &&
					this.Introduction.Equals(other.Introduction)
				) &&
				(
					this.FormPages == other.FormPages ||
					this.FormPages != null &&
					this.FormPages.SequenceEqual(other.FormPages)
				) &&
				(
					this.ShowSummary == other.ShowSummary ||
					this.ShowSummary != null &&
					this.ShowSummary.Equals(other.ShowSummary)
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
				if (this.FormDescription != null)
					hash = hash * 59 + this.FormDescription.GetHashCode();

				if (this.ReceivedMessage != null)
					hash = hash * 59 + this.ReceivedMessage.GetHashCode();

				if (this.ReplyMessage != null)
					hash = hash * 59 + this.ReplyMessage.GetHashCode();

				if (this.Introduction != null)
					hash = hash * 59 + this.Introduction.GetHashCode();

				if (this.FormPages != null)
					hash = hash * 59 + this.FormPages.GetHashCode();

				if (this.ShowSummary != null)
					hash = hash * 59 + this.ShowSummary.GetHashCode();

				return hash;
			}
		}
	}

}
