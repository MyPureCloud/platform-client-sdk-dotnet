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
    /// JourneySegment
    /// </summary>
    [DataContract]
    public partial class JourneySegment :  IEquatable<JourneySegment>
    {
        /// <summary>
        /// The target entity that a segment applies to.
        /// </summary>
        /// <value>The target entity that a segment applies to.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ScopeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Session for "Session"
            /// </summary>
            [EnumMember(Value = "Session")]
            Session,
            
            /// <summary>
            /// Enum Customer for "Customer"
            /// </summary>
            [EnumMember(Value = "Customer")]
            Customer
        }
        /// <summary>
        /// The target entity that a segment applies to.
        /// </summary>
        /// <value>The target entity that a segment applies to.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public ScopeEnum? Scope { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneySegment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneySegment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneySegment" /> class.
        /// </summary>
        /// <param name="Id">The ID of the segment. (required).</param>
        /// <param name="IsActive">Whether or not the segment is active. (required).</param>
        /// <param name="DisplayName">The display name of the segment. (required).</param>
        /// <param name="Version">The version of the segment. (required).</param>
        /// <param name="Description">A description of the segment..</param>
        /// <param name="Color">The hexadecimal color value of the segment. (required).</param>
        /// <param name="Scope">The target entity that a segment applies to. (required).</param>
        /// <param name="ShouldDisplayToAgent">Whether or not the segment should be displayed to agent/supervisor users. (required).</param>
        /// <param name="Context">The context of the segment. (required).</param>
        /// <param name="Journey">The pattern of rules defining the segment. (required).</param>
        /// <param name="ExternalSegment">Details of an entity corresponding to this segment in an external system..</param>
        /// <param name="AssignmentExpirationDays">Time, in days, from when the segment is assigned until it is automatically unassigned..</param>
        /// <param name="CreatedDate">Timestamp indicating when the segment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="ModifiedDate">Timestamp indicating when the segment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        public JourneySegment(string Id = null, bool? IsActive = null, string DisplayName = null, int? Version = null, string Description = null, string Color = null, ScopeEnum? Scope = null, bool? ShouldDisplayToAgent = null, Context Context = null, Journey Journey = null, ExternalSegment ExternalSegment = null, int? AssignmentExpirationDays = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null)
        {
            this.Id = Id;
            this.IsActive = IsActive;
            this.DisplayName = DisplayName;
            this.Version = Version;
            this.Description = Description;
            this.Color = Color;
            this.Scope = Scope;
            this.ShouldDisplayToAgent = ShouldDisplayToAgent;
            this.Context = Context;
            this.Journey = Journey;
            this.ExternalSegment = ExternalSegment;
            this.AssignmentExpirationDays = AssignmentExpirationDays;
            this.CreatedDate = CreatedDate;
            this.ModifiedDate = ModifiedDate;
            
        }
        


        /// <summary>
        /// The ID of the segment.
        /// </summary>
        /// <value>The ID of the segment.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Whether or not the segment is active.
        /// </summary>
        /// <value>Whether or not the segment is active.</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }



        /// <summary>
        /// The display name of the segment.
        /// </summary>
        /// <value>The display name of the segment.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }



        /// <summary>
        /// The version of the segment.
        /// </summary>
        /// <value>The version of the segment.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// A description of the segment.
        /// </summary>
        /// <value>A description of the segment.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The hexadecimal color value of the segment.
        /// </summary>
        /// <value>The hexadecimal color value of the segment.</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }





        /// <summary>
        /// Whether or not the segment should be displayed to agent/supervisor users.
        /// </summary>
        /// <value>Whether or not the segment should be displayed to agent/supervisor users.</value>
        [DataMember(Name="shouldDisplayToAgent", EmitDefaultValue=false)]
        public bool? ShouldDisplayToAgent { get; set; }



        /// <summary>
        /// The context of the segment.
        /// </summary>
        /// <value>The context of the segment.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public Context Context { get; set; }



        /// <summary>
        /// The pattern of rules defining the segment.
        /// </summary>
        /// <value>The pattern of rules defining the segment.</value>
        [DataMember(Name="journey", EmitDefaultValue=false)]
        public Journey Journey { get; set; }



        /// <summary>
        /// Details of an entity corresponding to this segment in an external system.
        /// </summary>
        /// <value>Details of an entity corresponding to this segment in an external system.</value>
        [DataMember(Name="externalSegment", EmitDefaultValue=false)]
        public ExternalSegment ExternalSegment { get; set; }



        /// <summary>
        /// Time, in days, from when the segment is assigned until it is automatically unassigned.
        /// </summary>
        /// <value>Time, in days, from when the segment is assigned until it is automatically unassigned.</value>
        [DataMember(Name="assignmentExpirationDays", EmitDefaultValue=false)]
        public int? AssignmentExpirationDays { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }



        /// <summary>
        /// Timestamp indicating when the segment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the segment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }



        /// <summary>
        /// Timestamp indicating when the segment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the segment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneySegment {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ShouldDisplayToAgent: ").Append(ShouldDisplayToAgent).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Journey: ").Append(Journey).Append("\n");
            sb.Append("  ExternalSegment: ").Append(ExternalSegment).Append("\n");
            sb.Append("  AssignmentExpirationDays: ").Append(AssignmentExpirationDays).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(obj as JourneySegment);
        }

        /// <summary>
        /// Returns true if JourneySegment instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneySegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneySegment other)
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
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) &&
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) &&
                (
                    this.ShouldDisplayToAgent == other.ShouldDisplayToAgent ||
                    this.ShouldDisplayToAgent != null &&
                    this.ShouldDisplayToAgent.Equals(other.ShouldDisplayToAgent)
                ) &&
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
                ) &&
                (
                    this.Journey == other.Journey ||
                    this.Journey != null &&
                    this.Journey.Equals(other.Journey)
                ) &&
                (
                    this.ExternalSegment == other.ExternalSegment ||
                    this.ExternalSegment != null &&
                    this.ExternalSegment.Equals(other.ExternalSegment)
                ) &&
                (
                    this.AssignmentExpirationDays == other.AssignmentExpirationDays ||
                    this.AssignmentExpirationDays != null &&
                    this.AssignmentExpirationDays.Equals(other.AssignmentExpirationDays)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
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

                if (this.IsActive != null)
                    hash = hash * 59 + this.IsActive.GetHashCode();

                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();

                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();

                if (this.ShouldDisplayToAgent != null)
                    hash = hash * 59 + this.ShouldDisplayToAgent.GetHashCode();

                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();

                if (this.Journey != null)
                    hash = hash * 59 + this.Journey.GetHashCode();

                if (this.ExternalSegment != null)
                    hash = hash * 59 + this.ExternalSegment.GetHashCode();

                if (this.AssignmentExpirationDays != null)
                    hash = hash * 59 + this.AssignmentExpirationDays.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();

                return hash;
            }
        }
    }

}
