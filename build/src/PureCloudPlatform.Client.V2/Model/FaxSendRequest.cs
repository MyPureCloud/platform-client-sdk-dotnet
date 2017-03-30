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
    /// FaxSendRequest
    /// </summary>
    [DataContract]
    public partial class FaxSendRequest :  IEquatable<FaxSendRequest>
    {
        /// <summary>
        /// The content type that is going to be uploaded. If Content Management document is used for faxing, contentType will be ignored
        /// </summary>
        /// <value>The content type that is going to be uploaded. If Content Management document is used for faxing, contentType will be ignored</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ContentTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Applicationpdf for "application/pdf"
            /// </summary>
            [EnumMember(Value = "application/pdf")]
            Applicationpdf,
            
            /// <summary>
            /// Enum Imagetiff for "image/tiff"
            /// </summary>
            [EnumMember(Value = "image/tiff")]
            Imagetiff,
            
            /// <summary>
            /// Enum Applicationmsword for "application/msword"
            /// </summary>
            [EnumMember(Value = "application/msword")]
            Applicationmsword,
            
            /// <summary>
            /// Enum Applicationvndoasisopendocumenttext for "application/vnd.oasis.opendocument.text"
            /// </summary>
            [EnumMember(Value = "application/vnd.oasis.opendocument.text")]
            Applicationvndoasisopendocumenttext,
            
            /// <summary>
            /// Enum Applicationvndopenxmlformatsofficedocumentwordprocessingmldocument for "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
            /// </summary>
            [EnumMember(Value = "application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
            Applicationvndopenxmlformatsofficedocumentwordprocessingmldocument
        }
        /// <summary>
        /// The content type that is going to be uploaded. If Content Management document is used for faxing, contentType will be ignored
        /// </summary>
        /// <value>The content type that is going to be uploaded. If Content Management document is used for faxing, contentType will be ignored</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FaxSendRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FaxSendRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FaxSendRequest" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Addresses">A list of outbound fax dialing addresses. E.g. +13175555555 or 3175555555 (required).</param>
        /// <param name="DocumentId">DocumentId of Content Management artifact. If Content Management document is not used for faxing, documentId should be null.</param>
        /// <param name="ContentType">The content type that is going to be uploaded. If Content Management document is used for faxing, contentType will be ignored.</param>
        /// <param name="Workspace">Workspace in which the document should be stored. If Content Management document is used for faxing, workspace will be ignored.</param>
        /// <param name="CoverSheet">Data for coversheet generation..</param>
        /// <param name="TimeZoneOffsetMinutes">Time zone offset minutes from GMT.</param>
        public FaxSendRequest(string Name = null, List<string> Addresses = null, string DocumentId = null, ContentTypeEnum? ContentType = null, Workspace Workspace = null, CoverSheet CoverSheet = null, int? TimeZoneOffsetMinutes = null)
        {
            // to ensure "Addresses" is required (not null)
            if (Addresses == null)
            {
                throw new InvalidDataException("Addresses is a required property for FaxSendRequest and cannot be null");
            }
            else
            {
                this.Addresses = Addresses;
            }
            this.Name = Name;
            this.DocumentId = DocumentId;
            this.ContentType = ContentType;
            this.Workspace = Workspace;
            this.CoverSheet = CoverSheet;
            this.TimeZoneOffsetMinutes = TimeZoneOffsetMinutes;
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
        /// A list of outbound fax dialing addresses. E.g. +13175555555 or 3175555555
        /// </summary>
        /// <value>A list of outbound fax dialing addresses. E.g. +13175555555 or 3175555555</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<string> Addresses { get; set; }
        /// <summary>
        /// DocumentId of Content Management artifact. If Content Management document is not used for faxing, documentId should be null
        /// </summary>
        /// <value>DocumentId of Content Management artifact. If Content Management document is not used for faxing, documentId should be null</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
        /// <summary>
        /// Workspace in which the document should be stored. If Content Management document is used for faxing, workspace will be ignored
        /// </summary>
        /// <value>Workspace in which the document should be stored. If Content Management document is used for faxing, workspace will be ignored</value>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public Workspace Workspace { get; set; }
        /// <summary>
        /// Data for coversheet generation.
        /// </summary>
        /// <value>Data for coversheet generation.</value>
        [DataMember(Name="coverSheet", EmitDefaultValue=false)]
        public CoverSheet CoverSheet { get; set; }
        /// <summary>
        /// Time zone offset minutes from GMT
        /// </summary>
        /// <value>Time zone offset minutes from GMT</value>
        [DataMember(Name="timeZoneOffsetMinutes", EmitDefaultValue=false)]
        public int? TimeZoneOffsetMinutes { get; set; }
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
            sb.Append("class FaxSendRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  CoverSheet: ").Append(CoverSheet).Append("\n");
            sb.Append("  TimeZoneOffsetMinutes: ").Append(TimeZoneOffsetMinutes).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FaxSendRequest);
        }

        /// <summary>
        /// Returns true if FaxSendRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FaxSendRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaxSendRequest other)
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
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) &&
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.Workspace == other.Workspace ||
                    this.Workspace != null &&
                    this.Workspace.Equals(other.Workspace)
                ) &&
                (
                    this.CoverSheet == other.CoverSheet ||
                    this.CoverSheet != null &&
                    this.CoverSheet.Equals(other.CoverSheet)
                ) &&
                (
                    this.TimeZoneOffsetMinutes == other.TimeZoneOffsetMinutes ||
                    this.TimeZoneOffsetMinutes != null &&
                    this.TimeZoneOffsetMinutes.Equals(other.TimeZoneOffsetMinutes)
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
                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                if (this.Workspace != null)
                    hash = hash * 59 + this.Workspace.GetHashCode();
                if (this.CoverSheet != null)
                    hash = hash * 59 + this.CoverSheet.GetHashCode();
                if (this.TimeZoneOffsetMinutes != null)
                    hash = hash * 59 + this.TimeZoneOffsetMinutes.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
