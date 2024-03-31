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
    /// DashboardUser
    /// </summary>
    [DataContract]
    public partial class DashboardUser :  IEquatable<DashboardUser>
    {
        /// <summary>
        /// The state of the user
        /// </summary>
        /// <value>The state of the user</value>
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
            Inactive
        }
        /// <summary>
        /// The state of the user
        /// </summary>
        /// <value>The state of the user</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardUser" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DashboardCount">The count of dashboards for the user.</param>
        /// <param name="PublicDashboardCount">The count of public dashboards for the user.</param>
        /// <param name="State">The state of the user.</param>
        public DashboardUser(string Name = null, int? DashboardCount = null, int? PublicDashboardCount = null, StateEnum? State = null)
        {
            this.Name = Name;
            this.DashboardCount = DashboardCount;
            this.PublicDashboardCount = PublicDashboardCount;
            this.State = State;
            
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
        /// The count of dashboards for the user
        /// </summary>
        /// <value>The count of dashboards for the user</value>
        [DataMember(Name="dashboardCount", EmitDefaultValue=false)]
        public int? DashboardCount { get; set; }



        /// <summary>
        /// The count of public dashboards for the user
        /// </summary>
        /// <value>The count of public dashboards for the user</value>
        [DataMember(Name="publicDashboardCount", EmitDefaultValue=false)]
        public int? PublicDashboardCount { get; set; }





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
            sb.Append("class DashboardUser {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DashboardCount: ").Append(DashboardCount).Append("\n");
            sb.Append("  PublicDashboardCount: ").Append(PublicDashboardCount).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as DashboardUser);
        }

        /// <summary>
        /// Returns true if DashboardUser instances are equal
        /// </summary>
        /// <param name="other">Instance of DashboardUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardUser other)
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
                    this.DashboardCount == other.DashboardCount ||
                    this.DashboardCount != null &&
                    this.DashboardCount.Equals(other.DashboardCount)
                ) &&
                (
                    this.PublicDashboardCount == other.PublicDashboardCount ||
                    this.PublicDashboardCount != null &&
                    this.PublicDashboardCount.Equals(other.PublicDashboardCount)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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

                if (this.DashboardCount != null)
                    hash = hash * 59 + this.DashboardCount.GetHashCode();

                if (this.PublicDashboardCount != null)
                    hash = hash * 59 + this.PublicDashboardCount.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
