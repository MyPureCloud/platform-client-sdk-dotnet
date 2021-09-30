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
    /// KnowledgeTraining
    /// </summary>
    [DataContract]
    public partial class KnowledgeTraining :  IEquatable<KnowledgeTraining>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Training status.
        /// </summary>
        /// <value>Training status.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Queued for "Queued"
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Succeeded for "Succeeded"
            /// </summary>
            [EnumMember(Value = "Succeeded")]
            Succeeded,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// State of the Trained Documents, which can be one of these Draft, Active, Discarded, Archived.
        /// </summary>
        /// <value>State of the Trained Documents, which can be one of these Draft, Active, Discarded, Archived.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum KnowledgeDocumentsStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Draft for "Draft"
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Discarded for "Discarded"
            /// </summary>
            [EnumMember(Value = "Discarded")]
            Discarded,
            
            /// <summary>
            /// Enum Archived for "Archived"
            /// </summary>
            [EnumMember(Value = "Archived")]
            Archived
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Training status.
        /// </summary>
        /// <value>Training status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// State of the Trained Documents, which can be one of these Draft, Active, Discarded, Archived.
        /// </summary>
        /// <value>State of the Trained Documents, which can be one of these Draft, Active, Discarded, Archived.</value>
        [DataMember(Name="knowledgeDocumentsState", EmitDefaultValue=false)]
        public KnowledgeDocumentsStateEnum? KnowledgeDocumentsState { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeTraining" /> class.
        /// </summary>
        public KnowledgeTraining()
        {
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Trigger date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Trigger date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateTriggered", EmitDefaultValue=false)]
        public DateTime? DateTriggered { get; private set; }
        
        
        
        /// <summary>
        /// Training completed date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Training completed date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCompleted", EmitDefaultValue=false)]
        public DateTime? DateCompleted { get; private set; }
        
        
        
        
        
        /// <summary>
        /// Language of the documents that are trained.
        /// </summary>
        /// <value>Language of the documents that are trained.</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; private set; }
        
        
        
        /// <summary>
        /// Knowledge Base that the training belongs to.
        /// </summary>
        /// <value>Knowledge Base that the training belongs to.</value>
        [DataMember(Name="knowledgeBase", EmitDefaultValue=false)]
        public KnowledgeBase KnowledgeBase { get; private set; }
        
        
        
        /// <summary>
        /// Any error message during the Training or Promote action.
        /// </summary>
        /// <value>Any error message during the Training or Promote action.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; private set; }
        
        
        
        
        
        /// <summary>
        /// Trained Documents Promoted date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Trained Documents Promoted date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="datePromoted", EmitDefaultValue=false)]
        public DateTime? DatePromoted { get; private set; }
        
        
        
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
            sb.Append("class KnowledgeTraining {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DateTriggered: ").Append(DateTriggered).Append("\n");
            sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  KnowledgeDocumentsState: ").Append(KnowledgeDocumentsState).Append("\n");
            sb.Append("  DatePromoted: ").Append(DatePromoted).Append("\n");
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
            return this.Equals(obj as KnowledgeTraining);
        }

        /// <summary>
        /// Returns true if KnowledgeTraining instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeTraining to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeTraining other)
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
                    this.DateTriggered == other.DateTriggered ||
                    this.DateTriggered != null &&
                    this.DateTriggered.Equals(other.DateTriggered)
                ) &&
                (
                    this.DateCompleted == other.DateCompleted ||
                    this.DateCompleted != null &&
                    this.DateCompleted.Equals(other.DateCompleted)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
                ) &&
                (
                    this.KnowledgeBase == other.KnowledgeBase ||
                    this.KnowledgeBase != null &&
                    this.KnowledgeBase.Equals(other.KnowledgeBase)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) &&
                (
                    this.KnowledgeDocumentsState == other.KnowledgeDocumentsState ||
                    this.KnowledgeDocumentsState != null &&
                    this.KnowledgeDocumentsState.Equals(other.KnowledgeDocumentsState)
                ) &&
                (
                    this.DatePromoted == other.DatePromoted ||
                    this.DatePromoted != null &&
                    this.DatePromoted.Equals(other.DatePromoted)
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
                
                if (this.DateTriggered != null)
                    hash = hash * 59 + this.DateTriggered.GetHashCode();
                
                if (this.DateCompleted != null)
                    hash = hash * 59 + this.DateCompleted.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();
                
                if (this.KnowledgeBase != null)
                    hash = hash * 59 + this.KnowledgeBase.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                
                if (this.KnowledgeDocumentsState != null)
                    hash = hash * 59 + this.KnowledgeDocumentsState.GetHashCode();
                
                if (this.DatePromoted != null)
                    hash = hash * 59 + this.DatePromoted.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
