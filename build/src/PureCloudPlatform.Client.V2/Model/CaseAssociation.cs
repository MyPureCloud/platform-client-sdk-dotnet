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
    /// Represents an association between a case and an interaction
    /// </summary>
    [DataContract]
    public partial class CaseAssociation :  IEquatable<CaseAssociation>
    {
        /// <summary>
        /// Association type.
        /// </summary>
        /// <value>Association type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AssociationTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Activity for "Activity"
            /// </summary>
            [EnumMember(Value = "Activity")]
            Activity,
            
            /// <summary>
            /// Enum Enquiry for "Enquiry"
            /// </summary>
            [EnumMember(Value = "Enquiry")]
            Enquiry,
            
            /// <summary>
            /// Enum Initiation for "Initiation"
            /// </summary>
            [EnumMember(Value = "Initiation")]
            Initiation
        }
        /// <summary>
        /// Association type.
        /// </summary>
        /// <value>Association type.</value>
        [DataMember(Name="associationType", EmitDefaultValue=false)]
        public AssociationTypeEnum? AssociationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseAssociation" /> class.
        /// </summary>
        /// <param name="Id">The ID of the association..</param>
        /// <param name="Name">Name.</param>
        /// <param name="AssociationType">Association type..</param>
        /// <param name="DateAssociated">Interaction association date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Workitem">Associated workitem ID..</param>
        /// <param name="Conversation">Associated conversation ID..</param>
        /// <param name="Stage">The stage related to this association..</param>
        /// <param name="Step">The step related to this association..</param>
        /// <param name="Case">Case ID.</param>
        public CaseAssociation(string Id = null, string Name = null, AssociationTypeEnum? AssociationType = null, DateTime? DateAssociated = null, WorkitemReference Workitem = null, ConversationReference Conversation = null, StageReference Stage = null, StepReference Step = null, CaseReference Case = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.AssociationType = AssociationType;
            this.DateAssociated = DateAssociated;
            this.Workitem = Workitem;
            this.Conversation = Conversation;
            this.Stage = Stage;
            this.Step = Step;
            this.Case = Case;
            
        }
        


        /// <summary>
        /// The ID of the association.
        /// </summary>
        /// <value>The ID of the association.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// Interaction association date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Interaction association date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateAssociated", EmitDefaultValue=false)]
        public DateTime? DateAssociated { get; set; }



        /// <summary>
        /// Associated workitem ID.
        /// </summary>
        /// <value>Associated workitem ID.</value>
        [DataMember(Name="workitem", EmitDefaultValue=false)]
        public WorkitemReference Workitem { get; set; }



        /// <summary>
        /// Associated conversation ID.
        /// </summary>
        /// <value>Associated conversation ID.</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public ConversationReference Conversation { get; set; }



        /// <summary>
        /// The stage related to this association.
        /// </summary>
        /// <value>The stage related to this association.</value>
        [DataMember(Name="stage", EmitDefaultValue=false)]
        public StageReference Stage { get; set; }



        /// <summary>
        /// The step related to this association.
        /// </summary>
        /// <value>The step related to this association.</value>
        [DataMember(Name="step", EmitDefaultValue=false)]
        public StepReference Step { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }



        /// <summary>
        /// Case ID
        /// </summary>
        /// <value>Case ID</value>
        [DataMember(Name="case", EmitDefaultValue=false)]
        public CaseReference Case { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseAssociation {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AssociationType: ").Append(AssociationType).Append("\n");
            sb.Append("  DateAssociated: ").Append(DateAssociated).Append("\n");
            sb.Append("  Workitem: ").Append(Workitem).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  Step: ").Append(Step).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Case: ").Append(Case).Append("\n");
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
            return this.Equals(obj as CaseAssociation);
        }

        /// <summary>
        /// Returns true if CaseAssociation instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseAssociation other)
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
                    this.AssociationType == other.AssociationType ||
                    this.AssociationType != null &&
                    this.AssociationType.Equals(other.AssociationType)
                ) &&
                (
                    this.DateAssociated == other.DateAssociated ||
                    this.DateAssociated != null &&
                    this.DateAssociated.Equals(other.DateAssociated)
                ) &&
                (
                    this.Workitem == other.Workitem ||
                    this.Workitem != null &&
                    this.Workitem.Equals(other.Workitem)
                ) &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.Stage == other.Stage ||
                    this.Stage != null &&
                    this.Stage.Equals(other.Stage)
                ) &&
                (
                    this.Step == other.Step ||
                    this.Step != null &&
                    this.Step.Equals(other.Step)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.Case == other.Case ||
                    this.Case != null &&
                    this.Case.Equals(other.Case)
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

                if (this.AssociationType != null)
                    hash = hash * 59 + this.AssociationType.GetHashCode();

                if (this.DateAssociated != null)
                    hash = hash * 59 + this.DateAssociated.GetHashCode();

                if (this.Workitem != null)
                    hash = hash * 59 + this.Workitem.GetHashCode();

                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();

                if (this.Stage != null)
                    hash = hash * 59 + this.Stage.GetHashCode();

                if (this.Step != null)
                    hash = hash * 59 + this.Step.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.Case != null)
                    hash = hash * 59 + this.Case.GetHashCode();

                return hash;
            }
        }
    }

}
