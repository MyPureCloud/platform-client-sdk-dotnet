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
    /// Management Unit object for Workforce Management.
    /// </summary>
    [DataContract]
    public partial class ManagementUnit :  IEquatable<ManagementUnit>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// Start day of week for workforce management planning purposes
        /// </summary>
        /// <value>Start day of week for workforce management planning purposes</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StartDayOfWeekEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Monday for "Monday"
            /// </summary>
            [EnumMember(Value = "Monday")]
            Monday,
            
            /// <summary>
            /// Enum Tuesday for "Tuesday"
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            Tuesday,
            
            /// <summary>
            /// Enum Wednesday for "Wednesday"
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            Wednesday,
            
            /// <summary>
            /// Enum Thursday for "Thursday"
            /// </summary>
            [EnumMember(Value = "Thursday")]
            Thursday,
            
            /// <summary>
            /// Enum Friday for "Friday"
            /// </summary>
            [EnumMember(Value = "Friday")]
            Friday,
            
            /// <summary>
            /// Enum Saturday for "Saturday"
            /// </summary>
            [EnumMember(Value = "Saturday")]
            Saturday,
            
            /// <summary>
            /// Enum Sunday for "Sunday"
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Start day of week for workforce management planning purposes
        /// </summary>
        /// <value>Start day of week for workforce management planning purposes</value>
        [DataMember(Name="startDayOfWeek", EmitDefaultValue=false)]
        public StartDayOfWeekEnum? StartDayOfWeek { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementUnit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ManagementUnit() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementUnit" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="StartDayOfWeek">Start day of week for workforce management planning purposes.</param>
        
        
        
        /// <param name="Timezone">The time zone for the management unit in standard Olson Format (See https://en.wikipedia.org/wiki/Tz_database).</param>
        
        
        
        /// <param name="Version">The version of the underlying ManagementUnit object. Useful for handling eventual consistency issues.  User must submit the current version they of the ManagementUnit in any write requests (required).</param>
        
        
        
        /// <param name="DateModified">The date and time at which this management unit was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        
        public ManagementUnit(string Name = null, StartDayOfWeekEnum? StartDayOfWeek = null, string Timezone = null, int? Version = null, DateTime? DateModified = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new InvalidDataException("Version is a required property for ManagementUnit and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.StartDayOfWeek = StartDayOfWeek;
            
            
            
            
            
            
            
            
this.Timezone = Timezone;
            
            
            
            
            
            
            
            
            
            
            
            
this.DateModified = DateModified;
            
            
            
            
            
            
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
        /// The time zone for the management unit in standard Olson Format (See https://en.wikipedia.org/wiki/Tz_database)
        /// </summary>
        /// <value>The time zone for the management unit in standard Olson Format (See https://en.wikipedia.org/wiki/Tz_database)</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }
        
        
        
        /// <summary>
        /// The version of the underlying ManagementUnit object. Useful for handling eventual consistency issues.  User must submit the current version they of the ManagementUnit in any write requests
        /// </summary>
        /// <value>The version of the underlying ManagementUnit object. Useful for handling eventual consistency issues.  User must submit the current version they of the ManagementUnit in any write requests</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// The date and time at which this management unit was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date and time at which this management unit was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
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
            sb.Append("class ManagementUnit {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
            
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            
            sb.Append("  Version: ").Append(Version).Append("\n");
            
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            
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
            return this.Equals(obj as ManagementUnit);
        }

        /// <summary>
        /// Returns true if ManagementUnit instances are equal
        /// </summary>
        /// <param name="other">Instance of ManagementUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagementUnit other)
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
                    this.StartDayOfWeek == other.StartDayOfWeek ||
                    this.StartDayOfWeek != null &&
                    this.StartDayOfWeek.Equals(other.StartDayOfWeek)
                ) &&
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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
                
                if (this.StartDayOfWeek != null)
                    hash = hash * 59 + this.StartDayOfWeek.GetHashCode();
                
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
