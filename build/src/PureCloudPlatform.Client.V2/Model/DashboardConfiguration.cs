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
    /// DashboardConfiguration
    /// </summary>
    [DataContract]
    public partial class DashboardConfiguration :  IEquatable<DashboardConfiguration>
    {
        /// <summary>
        /// The layout type of the dashboard
        /// </summary>
        /// <value>The layout type of the dashboard</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LayoutTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Grid for "Grid"
            /// </summary>
            [EnumMember(Value = "Grid")]
            Grid,
            
            /// <summary>
            /// Enum Flow for "Flow"
            /// </summary>
            [EnumMember(Value = "Flow")]
            Flow
        }
        /// <summary>
        /// The layout type of the dashboard
        /// </summary>
        /// <value>The layout type of the dashboard</value>
        [DataMember(Name="layoutType", EmitDefaultValue=false)]
        public LayoutTypeEnum? LayoutType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DashboardConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardConfiguration" /> class.
        /// </summary>
        /// <param name="Name">The name of dashboard configuration. (required).</param>
        /// <param name="Rows">The count of rows for the specific dashboard configuration..</param>
        /// <param name="Columns">The count of columns for the specific dashboard..</param>
        /// <param name="Widgets">List of widgets for dashboard configuration. (required).</param>
        /// <param name="Favorite">The flag indicates if the dashboard is favorited by the user.</param>
        /// <param name="PublicDashboard">The flag to indicate if the dashboard is published by an user.</param>
        /// <param name="LayoutType">The layout type of the dashboard.</param>
        /// <param name="DateCreated">The created date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="DateModified">The last modified date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="DateDeleted">The deleted date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="Shared">The flag to indicate if the dashboard is shared.</param>
        /// <param name="DashboardsSharedWith">The list of users and teams the dashboard is shared with.</param>
        public DashboardConfiguration(string Name = null, int? Rows = null, int? Columns = null, List<Widget> Widgets = null, bool? Favorite = null, bool? PublicDashboard = null, LayoutTypeEnum? LayoutType = null, DateTime? DateCreated = null, DateTime? DateModified = null, DateTime? DateDeleted = null, bool? Shared = null, DashboardsSharedWith DashboardsSharedWith = null)
        {
            this.Name = Name;
            this.Rows = Rows;
            this.Columns = Columns;
            this.Widgets = Widgets;
            this.Favorite = Favorite;
            this.PublicDashboard = PublicDashboard;
            this.LayoutType = LayoutType;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.DateDeleted = DateDeleted;
            this.Shared = Shared;
            this.DashboardsSharedWith = DashboardsSharedWith;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of dashboard configuration.
        /// </summary>
        /// <value>The name of dashboard configuration.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The count of rows for the specific dashboard configuration.
        /// </summary>
        /// <value>The count of rows for the specific dashboard configuration.</value>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public int? Rows { get; set; }



        /// <summary>
        /// The count of columns for the specific dashboard.
        /// </summary>
        /// <value>The count of columns for the specific dashboard.</value>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public int? Columns { get; set; }



        /// <summary>
        /// List of widgets for dashboard configuration.
        /// </summary>
        /// <value>List of widgets for dashboard configuration.</value>
        [DataMember(Name="widgets", EmitDefaultValue=false)]
        public List<Widget> Widgets { get; set; }



        /// <summary>
        /// The flag indicates if the dashboard is favorited by the user
        /// </summary>
        /// <value>The flag indicates if the dashboard is favorited by the user</value>
        [DataMember(Name="favorite", EmitDefaultValue=false)]
        public bool? Favorite { get; set; }



        /// <summary>
        /// The flag to indicate if the dashboard is published by an user
        /// </summary>
        /// <value>The flag to indicate if the dashboard is published by an user</value>
        [DataMember(Name="publicDashboard", EmitDefaultValue=false)]
        public bool? PublicDashboard { get; set; }



        /// <summary>
        /// The flag to indicate if the dashboard has any restricted data for that user
        /// </summary>
        /// <value>The flag to indicate if the dashboard has any restricted data for that user</value>
        [DataMember(Name="restricted", EmitDefaultValue=false)]
        public bool? Restricted { get; private set; }





        /// <summary>
        /// The created date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The created date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The last modified date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The last modified date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// The deleted date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The deleted date of the dashboard. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateDeleted", EmitDefaultValue=false)]
        public DateTime? DateDeleted { get; set; }



        /// <summary>
        /// The id of user who created the dashboard
        /// </summary>
        /// <value>The id of user who created the dashboard</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public AddressableEntityRef CreatedBy { get; private set; }



        /// <summary>
        /// The flag to indicate if the dashboard is shared
        /// </summary>
        /// <value>The flag to indicate if the dashboard is shared</value>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public bool? Shared { get; set; }



        /// <summary>
        /// The list of users and teams the dashboard is shared with
        /// </summary>
        /// <value>The list of users and teams the dashboard is shared with</value>
        [DataMember(Name="dashboardsSharedWith", EmitDefaultValue=false)]
        public DashboardsSharedWith DashboardsSharedWith { get; set; }



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
            sb.Append("class DashboardConfiguration {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Widgets: ").Append(Widgets).Append("\n");
            sb.Append("  Favorite: ").Append(Favorite).Append("\n");
            sb.Append("  PublicDashboard: ").Append(PublicDashboard).Append("\n");
            sb.Append("  Restricted: ").Append(Restricted).Append("\n");
            sb.Append("  LayoutType: ").Append(LayoutType).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DateDeleted: ").Append(DateDeleted).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  DashboardsSharedWith: ").Append(DashboardsSharedWith).Append("\n");
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
            return this.Equals(obj as DashboardConfiguration);
        }

        /// <summary>
        /// Returns true if DashboardConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of DashboardConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardConfiguration other)
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
                    this.Rows == other.Rows ||
                    this.Rows != null &&
                    this.Rows.Equals(other.Rows)
                ) &&
                (
                    this.Columns == other.Columns ||
                    this.Columns != null &&
                    this.Columns.Equals(other.Columns)
                ) &&
                (
                    this.Widgets == other.Widgets ||
                    this.Widgets != null &&
                    this.Widgets.SequenceEqual(other.Widgets)
                ) &&
                (
                    this.Favorite == other.Favorite ||
                    this.Favorite != null &&
                    this.Favorite.Equals(other.Favorite)
                ) &&
                (
                    this.PublicDashboard == other.PublicDashboard ||
                    this.PublicDashboard != null &&
                    this.PublicDashboard.Equals(other.PublicDashboard)
                ) &&
                (
                    this.Restricted == other.Restricted ||
                    this.Restricted != null &&
                    this.Restricted.Equals(other.Restricted)
                ) &&
                (
                    this.LayoutType == other.LayoutType ||
                    this.LayoutType != null &&
                    this.LayoutType.Equals(other.LayoutType)
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
                    this.DateDeleted == other.DateDeleted ||
                    this.DateDeleted != null &&
                    this.DateDeleted.Equals(other.DateDeleted)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
                ) &&
                (
                    this.DashboardsSharedWith == other.DashboardsSharedWith ||
                    this.DashboardsSharedWith != null &&
                    this.DashboardsSharedWith.Equals(other.DashboardsSharedWith)
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

                if (this.Rows != null)
                    hash = hash * 59 + this.Rows.GetHashCode();

                if (this.Columns != null)
                    hash = hash * 59 + this.Columns.GetHashCode();

                if (this.Widgets != null)
                    hash = hash * 59 + this.Widgets.GetHashCode();

                if (this.Favorite != null)
                    hash = hash * 59 + this.Favorite.GetHashCode();

                if (this.PublicDashboard != null)
                    hash = hash * 59 + this.PublicDashboard.GetHashCode();

                if (this.Restricted != null)
                    hash = hash * 59 + this.Restricted.GetHashCode();

                if (this.LayoutType != null)
                    hash = hash * 59 + this.LayoutType.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DateDeleted != null)
                    hash = hash * 59 + this.DateDeleted.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.Shared != null)
                    hash = hash * 59 + this.Shared.GetHashCode();

                if (this.DashboardsSharedWith != null)
                    hash = hash * 59 + this.DashboardsSharedWith.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
