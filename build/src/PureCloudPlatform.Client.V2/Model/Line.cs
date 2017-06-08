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
    /// Line
    /// </summary>
    [DataContract]
    public partial class Line :  IEquatable<Line>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "inactive"
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Deleted for "deleted"
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Line" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Line() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Line" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">The name of the entity. (required).</param>
        
        
        
        /// <param name="Description">Description.</param>
        
        
        
        /// <param name="Version">Version.</param>
        
        
        
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="ModifiedBy">ModifiedBy.</param>
        
        
        
        /// <param name="CreatedBy">CreatedBy.</param>
        
        
        
        /// <param name="State">State.</param>
        
        
        
        /// <param name="ModifiedByApp">ModifiedByApp.</param>
        
        
        
        /// <param name="CreatedByApp">CreatedByApp.</param>
        
        
        
        /// <param name="Properties">Properties.</param>
        
        
        
        /// <param name="EdgeGroup">EdgeGroup.</param>
        
        
        
        /// <param name="Template">Template.</param>
        
        
        
        /// <param name="Site">Site.</param>
        
        
        
        /// <param name="LineBaseSettings">LineBaseSettings.</param>
        
        
        
        /// <param name="PrimaryEdge">The primary edge associated to the line. (Deprecated).</param>
        
        
        
        /// <param name="SecondaryEdge">The secondary edge associated to the line. (Deprecated).</param>
        
        
        
        /// <param name="LoggedInUser">LoggedInUser.</param>
        
        
        
        /// <param name="DefaultForUser">DefaultForUser.</param>
        
        
        
        
        public Line(string Name = null, string Description = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, StateEnum? State = null, string ModifiedByApp = null, string CreatedByApp = null, Dictionary<string, Object> Properties = null, UriReference EdgeGroup = null, UriReference Template = null, UriReference Site = null, UriReference LineBaseSettings = null, Edge PrimaryEdge = null, Edge SecondaryEdge = null, UriReference LoggedInUser = null, UriReference DefaultForUser = null)
        {
            
            
            
            
            
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Line and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Description = Description;
            
            
            
            
            
            
            
            
this.Version = Version;
            
            
            
            
            
            
            
            
this.DateCreated = DateCreated;
            
            
            
            
            
            
            
            
this.DateModified = DateModified;
            
            
            
            
            
            
            
            
this.ModifiedBy = ModifiedBy;
            
            
            
            
            
            
            
            
this.CreatedBy = CreatedBy;
            
            
            
            
            
            
            
            
this.State = State;
            
            
            
            
            
            
            
            
this.ModifiedByApp = ModifiedByApp;
            
            
            
            
            
            
            
            
this.CreatedByApp = CreatedByApp;
            
            
            
            
            
            
            
            
this.Properties = Properties;
            
            
            
            
            
            
            
            
this.EdgeGroup = EdgeGroup;
            
            
            
            
            
            
            
            
this.Template = Template;
            
            
            
            
            
            
            
            
this.Site = Site;
            
            
            
            
            
            
            
            
this.LineBaseSettings = LineBaseSettings;
            
            
            
            
            
            
            
            
this.PrimaryEdge = PrimaryEdge;
            
            
            
            
            
            
            
            
this.SecondaryEdge = SecondaryEdge;
            
            
            
            
            
            
            
            
this.LoggedInUser = LoggedInUser;
            
            
            
            
            
            
            
            
this.DefaultForUser = DefaultForUser;
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the entity.
        /// </summary>
        /// <value>The name of the entity.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ModifiedByApp
        /// </summary>
        [DataMember(Name="modifiedByApp", EmitDefaultValue=false)]
        public string ModifiedByApp { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CreatedByApp
        /// </summary>
        [DataMember(Name="createdByApp", EmitDefaultValue=false)]
        public string CreatedByApp { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, Object> Properties { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EdgeGroup
        /// </summary>
        [DataMember(Name="edgeGroup", EmitDefaultValue=false)]
        public UriReference EdgeGroup { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public UriReference Template { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Site
        /// </summary>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public UriReference Site { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets LineBaseSettings
        /// </summary>
        [DataMember(Name="lineBaseSettings", EmitDefaultValue=false)]
        public UriReference LineBaseSettings { get; set; }
        
        
        
        /// <summary>
        /// The primary edge associated to the line. (Deprecated)
        /// </summary>
        /// <value>The primary edge associated to the line. (Deprecated)</value>
        [DataMember(Name="primaryEdge", EmitDefaultValue=false)]
        public Edge PrimaryEdge { get; set; }
        
        
        
        /// <summary>
        /// The secondary edge associated to the line. (Deprecated)
        /// </summary>
        /// <value>The secondary edge associated to the line. (Deprecated)</value>
        [DataMember(Name="secondaryEdge", EmitDefaultValue=false)]
        public Edge SecondaryEdge { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets LoggedInUser
        /// </summary>
        [DataMember(Name="loggedInUser", EmitDefaultValue=false)]
        public UriReference LoggedInUser { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DefaultForUser
        /// </summary>
        [DataMember(Name="defaultForUser", EmitDefaultValue=false)]
        public UriReference DefaultForUser { get; set; }
        
        
        
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
            sb.Append("class Line {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            
            sb.Append("  Version: ").Append(Version).Append("\n");
            
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            
            sb.Append("  State: ").Append(State).Append("\n");
            
            sb.Append("  ModifiedByApp: ").Append(ModifiedByApp).Append("\n");
            
            sb.Append("  CreatedByApp: ").Append(CreatedByApp).Append("\n");
            
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            
            sb.Append("  EdgeGroup: ").Append(EdgeGroup).Append("\n");
            
            sb.Append("  Template: ").Append(Template).Append("\n");
            
            sb.Append("  Site: ").Append(Site).Append("\n");
            
            sb.Append("  LineBaseSettings: ").Append(LineBaseSettings).Append("\n");
            
            sb.Append("  PrimaryEdge: ").Append(PrimaryEdge).Append("\n");
            
            sb.Append("  SecondaryEdge: ").Append(SecondaryEdge).Append("\n");
            
            sb.Append("  LoggedInUser: ").Append(LoggedInUser).Append("\n");
            
            sb.Append("  DefaultForUser: ").Append(DefaultForUser).Append("\n");
            
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
            return this.Equals(obj as Line);
        }

        /// <summary>
        /// Returns true if Line instances are equal
        /// </summary>
        /// <param name="other">Instance of Line to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Line other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ModifiedByApp == other.ModifiedByApp ||
                    this.ModifiedByApp != null &&
                    this.ModifiedByApp.Equals(other.ModifiedByApp)
                ) &&
                (
                    this.CreatedByApp == other.CreatedByApp ||
                    this.CreatedByApp != null &&
                    this.CreatedByApp.Equals(other.CreatedByApp)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) &&
                (
                    this.EdgeGroup == other.EdgeGroup ||
                    this.EdgeGroup != null &&
                    this.EdgeGroup.Equals(other.EdgeGroup)
                ) &&
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) &&
                (
                    this.Site == other.Site ||
                    this.Site != null &&
                    this.Site.Equals(other.Site)
                ) &&
                (
                    this.LineBaseSettings == other.LineBaseSettings ||
                    this.LineBaseSettings != null &&
                    this.LineBaseSettings.Equals(other.LineBaseSettings)
                ) &&
                (
                    this.PrimaryEdge == other.PrimaryEdge ||
                    this.PrimaryEdge != null &&
                    this.PrimaryEdge.Equals(other.PrimaryEdge)
                ) &&
                (
                    this.SecondaryEdge == other.SecondaryEdge ||
                    this.SecondaryEdge != null &&
                    this.SecondaryEdge.Equals(other.SecondaryEdge)
                ) &&
                (
                    this.LoggedInUser == other.LoggedInUser ||
                    this.LoggedInUser != null &&
                    this.LoggedInUser.Equals(other.LoggedInUser)
                ) &&
                (
                    this.DefaultForUser == other.DefaultForUser ||
                    this.DefaultForUser != null &&
                    this.DefaultForUser.Equals(other.DefaultForUser)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.ModifiedByApp != null)
                    hash = hash * 59 + this.ModifiedByApp.GetHashCode();
                
                if (this.CreatedByApp != null)
                    hash = hash * 59 + this.CreatedByApp.GetHashCode();
                
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                
                if (this.EdgeGroup != null)
                    hash = hash * 59 + this.EdgeGroup.GetHashCode();
                
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                
                if (this.Site != null)
                    hash = hash * 59 + this.Site.GetHashCode();
                
                if (this.LineBaseSettings != null)
                    hash = hash * 59 + this.LineBaseSettings.GetHashCode();
                
                if (this.PrimaryEdge != null)
                    hash = hash * 59 + this.PrimaryEdge.GetHashCode();
                
                if (this.SecondaryEdge != null)
                    hash = hash * 59 + this.SecondaryEdge.GetHashCode();
                
                if (this.LoggedInUser != null)
                    hash = hash * 59 + this.LoggedInUser.GetHashCode();
                
                if (this.DefaultForUser != null)
                    hash = hash * 59 + this.DefaultForUser.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
