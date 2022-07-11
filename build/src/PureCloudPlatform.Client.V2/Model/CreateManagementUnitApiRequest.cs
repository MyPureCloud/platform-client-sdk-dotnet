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
    /// CreateManagementUnitApiRequest
    /// </summary>
    [DataContract]
    public partial class CreateManagementUnitApiRequest :  IEquatable<CreateManagementUnitApiRequest>
    {
        /// <summary>
        /// The configured first day of the week for scheduling and forecasting purposes. Moving to Business Unit
        /// </summary>
        /// <value>The configured first day of the week for scheduling and forecasting purposes. Moving to Business Unit</value>
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
            /// Enum Sunday for "Sunday"
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday,
            
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
            Saturday
        }
        /// <summary>
        /// The configured first day of the week for scheduling and forecasting purposes. Moving to Business Unit
        /// </summary>
        /// <value>The configured first day of the week for scheduling and forecasting purposes. Moving to Business Unit</value>
        [DataMember(Name="startDayOfWeek", EmitDefaultValue=false)]
        public StartDayOfWeekEnum? StartDayOfWeek { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagementUnitApiRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateManagementUnitApiRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagementUnitApiRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the management unit (required).</param>
        /// <param name="TimeZone">The default time zone to use for this management unit.  Moving to Business Unit.</param>
        /// <param name="StartDayOfWeek">The configured first day of the week for scheduling and forecasting purposes. Moving to Business Unit.</param>
        /// <param name="Settings">The configuration for the management unit.  If omitted, reasonable defaults will be assigned.</param>
        /// <param name="DivisionId">The id of the division to which this management unit belongs.  Defaults to home division ID.</param>
        /// <param name="BusinessUnitId">The id of the business unit to which this management unit belongs (required).</param>
        public CreateManagementUnitApiRequest(string Name = null, string TimeZone = null, StartDayOfWeekEnum? StartDayOfWeek = null, CreateManagementUnitSettingsRequest Settings = null, string DivisionId = null, string BusinessUnitId = null)
        {
            this.Name = Name;
            this.TimeZone = TimeZone;
            this.StartDayOfWeek = StartDayOfWeek;
            this.Settings = Settings;
            this.DivisionId = DivisionId;
            this.BusinessUnitId = BusinessUnitId;
            
        }
        


        /// <summary>
        /// The name of the management unit
        /// </summary>
        /// <value>The name of the management unit</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The default time zone to use for this management unit.  Moving to Business Unit
        /// </summary>
        /// <value>The default time zone to use for this management unit.  Moving to Business Unit</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }





        /// <summary>
        /// The configuration for the management unit.  If omitted, reasonable defaults will be assigned
        /// </summary>
        /// <value>The configuration for the management unit.  If omitted, reasonable defaults will be assigned</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public CreateManagementUnitSettingsRequest Settings { get; set; }



        /// <summary>
        /// The id of the division to which this management unit belongs.  Defaults to home division ID
        /// </summary>
        /// <value>The id of the division to which this management unit belongs.  Defaults to home division ID</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }



        /// <summary>
        /// The id of the business unit to which this management unit belongs
        /// </summary>
        /// <value>The id of the business unit to which this management unit belongs</value>
        [DataMember(Name="businessUnitId", EmitDefaultValue=false)]
        public string BusinessUnitId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateManagementUnitApiRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
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
            return this.Equals(obj as CreateManagementUnitApiRequest);
        }

        /// <summary>
        /// Returns true if CreateManagementUnitApiRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateManagementUnitApiRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateManagementUnitApiRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) &&
                (
                    this.StartDayOfWeek == other.StartDayOfWeek ||
                    this.StartDayOfWeek != null &&
                    this.StartDayOfWeek.Equals(other.StartDayOfWeek)
                ) &&
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.BusinessUnitId == other.BusinessUnitId ||
                    this.BusinessUnitId != null &&
                    this.BusinessUnitId.Equals(other.BusinessUnitId)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();

                if (this.StartDayOfWeek != null)
                    hash = hash * 59 + this.StartDayOfWeek.GetHashCode();

                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.BusinessUnitId != null)
                    hash = hash * 59 + this.BusinessUnitId.GetHashCode();

                return hash;
            }
        }
    }

}
