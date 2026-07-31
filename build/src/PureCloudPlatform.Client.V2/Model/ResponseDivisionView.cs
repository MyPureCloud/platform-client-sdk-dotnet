using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Division view of a response management response.
    /// </summary>
    [DataContract]
    public partial class ResponseDivisionView :  IEquatable<ResponseDivisionView>
    {
        /// <summary>
        /// The response type represented by the response.
        /// </summary>
        /// <value>The response type represented by the response.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ResponseTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Messagingtemplate for "MessagingTemplate"
            /// </summary>
            [EnumMember(Value = "MessagingTemplate")]
            Messagingtemplate,
            
            /// <summary>
            /// Enum Campaignsmstemplate for "CampaignSmsTemplate"
            /// </summary>
            [EnumMember(Value = "CampaignSmsTemplate")]
            Campaignsmstemplate,
            
            /// <summary>
            /// Enum Campaignemailtemplate for "CampaignEmailTemplate"
            /// </summary>
            [EnumMember(Value = "CampaignEmailTemplate")]
            Campaignemailtemplate,
            
            /// <summary>
            /// Enum Footer for "Footer"
            /// </summary>
            [EnumMember(Value = "Footer")]
            Footer,
            
            /// <summary>
            /// Enum Form for "Form"
            /// </summary>
            [EnumMember(Value = "Form")]
            Form,
            
            /// <summary>
            /// Enum Appleinvitation for "AppleInvitation"
            /// </summary>
            [EnumMember(Value = "AppleInvitation")]
            Appleinvitation
        }
        /// <summary>
        /// The response type represented by the response.
        /// </summary>
        /// <value>The response type represented by the response.</value>
        [DataMember(Name="responseType", EmitDefaultValue=false)]
        public ResponseTypeEnum? ResponseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDivisionView" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ResponseType">The response type represented by the response..</param>
        /// <param name="Libraries">One or more libraries response is associated with..</param>
        /// <param name="Substitutions">Details about any text substitutions used in the texts for this response..</param>
        /// <param name="SubstitutionsSchema">Metadata about the text substitutions in json schema format..</param>
        /// <param name="MessagingTemplate">An optional messaging template definition for responseType.MessagingTemplate..</param>
        /// <param name="Form">Form template definition for responseType.Form..</param>
        public ResponseDivisionView(string Name = null, ResponseTypeEnum? ResponseType = null, List<LibraryDivisionView> Libraries = null, List<ResponseSubstitution> Substitutions = null, JsonSchemaDocument SubstitutionsSchema = null, MessagingTemplate MessagingTemplate = null, Form Form = null)
        {
            this.Name = Name;
            this.ResponseType = ResponseType;
            this.Libraries = Libraries;
            this.Substitutions = Substitutions;
            this.SubstitutionsSchema = SubstitutionsSchema;
            this.MessagingTemplate = MessagingTemplate;
            this.Form = Form;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// One or more libraries response is associated with.
        /// </summary>
        /// <value>One or more libraries response is associated with.</value>
        [DataMember(Name="libraries", EmitDefaultValue=false)]
        public List<LibraryDivisionView> Libraries { get; set; }



        /// <summary>
        /// Details about any text substitutions used in the texts for this response.
        /// </summary>
        /// <value>Details about any text substitutions used in the texts for this response.</value>
        [DataMember(Name="substitutions", EmitDefaultValue=false)]
        public List<ResponseSubstitution> Substitutions { get; set; }



        /// <summary>
        /// Metadata about the text substitutions in json schema format.
        /// </summary>
        /// <value>Metadata about the text substitutions in json schema format.</value>
        [DataMember(Name="substitutionsSchema", EmitDefaultValue=false)]
        public JsonSchemaDocument SubstitutionsSchema { get; set; }



        /// <summary>
        /// An optional messaging template definition for responseType.MessagingTemplate.
        /// </summary>
        /// <value>An optional messaging template definition for responseType.MessagingTemplate.</value>
        [DataMember(Name="messagingTemplate", EmitDefaultValue=false)]
        public MessagingTemplate MessagingTemplate { get; set; }



        /// <summary>
        /// Form template definition for responseType.Form.
        /// </summary>
        /// <value>Form template definition for responseType.Form.</value>
        [DataMember(Name="form", EmitDefaultValue=false)]
        public Form Form { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseDivisionView {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  Libraries: ").Append(Libraries).Append("\n");
            sb.Append("  Substitutions: ").Append(Substitutions).Append("\n");
            sb.Append("  SubstitutionsSchema: ").Append(SubstitutionsSchema).Append("\n");
            sb.Append("  MessagingTemplate: ").Append(MessagingTemplate).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as ResponseDivisionView);
        }

        /// <summary>
        /// Returns true if ResponseDivisionView instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseDivisionView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseDivisionView other)
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
                    this.ResponseType == other.ResponseType ||
                    this.ResponseType != null &&
                    this.ResponseType.Equals(other.ResponseType)
                ) &&
                (
                    this.Libraries == other.Libraries ||
                    this.Libraries != null &&
                    this.Libraries.SequenceEqual(other.Libraries)
                ) &&
                (
                    this.Substitutions == other.Substitutions ||
                    this.Substitutions != null &&
                    this.Substitutions.SequenceEqual(other.Substitutions)
                ) &&
                (
                    this.SubstitutionsSchema == other.SubstitutionsSchema ||
                    this.SubstitutionsSchema != null &&
                    this.SubstitutionsSchema.Equals(other.SubstitutionsSchema)
                ) &&
                (
                    this.MessagingTemplate == other.MessagingTemplate ||
                    this.MessagingTemplate != null &&
                    this.MessagingTemplate.Equals(other.MessagingTemplate)
                ) &&
                (
                    this.Form == other.Form ||
                    this.Form != null &&
                    this.Form.Equals(other.Form)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.ResponseType != null)
                    hash = hash * 59 + this.ResponseType.GetHashCode();

                if (this.Libraries != null)
                    hash = hash * 59 + this.Libraries.GetHashCode();

                if (this.Substitutions != null)
                    hash = hash * 59 + this.Substitutions.GetHashCode();

                if (this.SubstitutionsSchema != null)
                    hash = hash * 59 + this.SubstitutionsSchema.GetHashCode();

                if (this.MessagingTemplate != null)
                    hash = hash * 59 + this.MessagingTemplate.GetHashCode();

                if (this.Form != null)
                    hash = hash * 59 + this.Form.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
