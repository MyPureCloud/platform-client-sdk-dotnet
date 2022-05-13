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
    /// JourneyWebEventsNotificationDevice
    /// </summary>
    [DataContract]
    public partial class JourneyWebEventsNotificationDevice :  IEquatable<JourneyWebEventsNotificationDevice>
    {
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Desktop for "desktop"
            /// </summary>
            [EnumMember(Value = "desktop")]
            Desktop,
            
            /// <summary>
            /// Enum Mobile for "mobile"
            /// </summary>
            [EnumMember(Value = "mobile")]
            Mobile,
            
            /// <summary>
            /// Enum Tablet for "tablet"
            /// </summary>
            [EnumMember(Value = "tablet")]
            Tablet,
            
            /// <summary>
            /// Enum Other for "other"
            /// </summary>
            [EnumMember(Value = "other")]
            Other
        }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyWebEventsNotificationDevice" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="IsMobile">IsMobile.</param>
        /// <param name="ScreenHeight">ScreenHeight.</param>
        /// <param name="ScreenWidth">ScreenWidth.</param>
        /// <param name="Fingerprint">Fingerprint.</param>
        /// <param name="OsFamily">OsFamily.</param>
        /// <param name="OsVersion">OsVersion.</param>
        /// <param name="Category">Category.</param>
        public JourneyWebEventsNotificationDevice(string Type = null, bool? IsMobile = null, int? ScreenHeight = null, int? ScreenWidth = null, string Fingerprint = null, string OsFamily = null, string OsVersion = null, CategoryEnum? Category = null)
        {
            this.Type = Type;
            this.IsMobile = IsMobile;
            this.ScreenHeight = ScreenHeight;
            this.ScreenWidth = ScreenWidth;
            this.Fingerprint = Fingerprint;
            this.OsFamily = OsFamily;
            this.OsVersion = OsVersion;
            this.Category = Category;
            
        }
        


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// Gets or Sets IsMobile
        /// </summary>
        [DataMember(Name="isMobile", EmitDefaultValue=false)]
        public bool? IsMobile { get; set; }



        /// <summary>
        /// Gets or Sets ScreenHeight
        /// </summary>
        [DataMember(Name="screenHeight", EmitDefaultValue=false)]
        public int? ScreenHeight { get; set; }



        /// <summary>
        /// Gets or Sets ScreenWidth
        /// </summary>
        [DataMember(Name="screenWidth", EmitDefaultValue=false)]
        public int? ScreenWidth { get; set; }



        /// <summary>
        /// Gets or Sets Fingerprint
        /// </summary>
        [DataMember(Name="fingerprint", EmitDefaultValue=false)]
        public string Fingerprint { get; set; }



        /// <summary>
        /// Gets or Sets OsFamily
        /// </summary>
        [DataMember(Name="osFamily", EmitDefaultValue=false)]
        public string OsFamily { get; set; }



        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name="osVersion", EmitDefaultValue=false)]
        public string OsVersion { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyWebEventsNotificationDevice {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsMobile: ").Append(IsMobile).Append("\n");
            sb.Append("  ScreenHeight: ").Append(ScreenHeight).Append("\n");
            sb.Append("  ScreenWidth: ").Append(ScreenWidth).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  OsFamily: ").Append(OsFamily).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(obj as JourneyWebEventsNotificationDevice);
        }

        /// <summary>
        /// Returns true if JourneyWebEventsNotificationDevice instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyWebEventsNotificationDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyWebEventsNotificationDevice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.IsMobile == other.IsMobile ||
                    this.IsMobile != null &&
                    this.IsMobile.Equals(other.IsMobile)
                ) &&
                (
                    this.ScreenHeight == other.ScreenHeight ||
                    this.ScreenHeight != null &&
                    this.ScreenHeight.Equals(other.ScreenHeight)
                ) &&
                (
                    this.ScreenWidth == other.ScreenWidth ||
                    this.ScreenWidth != null &&
                    this.ScreenWidth.Equals(other.ScreenWidth)
                ) &&
                (
                    this.Fingerprint == other.Fingerprint ||
                    this.Fingerprint != null &&
                    this.Fingerprint.Equals(other.Fingerprint)
                ) &&
                (
                    this.OsFamily == other.OsFamily ||
                    this.OsFamily != null &&
                    this.OsFamily.Equals(other.OsFamily)
                ) &&
                (
                    this.OsVersion == other.OsVersion ||
                    this.OsVersion != null &&
                    this.OsVersion.Equals(other.OsVersion)
                ) &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.IsMobile != null)
                    hash = hash * 59 + this.IsMobile.GetHashCode();

                if (this.ScreenHeight != null)
                    hash = hash * 59 + this.ScreenHeight.GetHashCode();

                if (this.ScreenWidth != null)
                    hash = hash * 59 + this.ScreenWidth.GetHashCode();

                if (this.Fingerprint != null)
                    hash = hash * 59 + this.Fingerprint.GetHashCode();

                if (this.OsFamily != null)
                    hash = hash * 59 + this.OsFamily.GetHashCode();

                if (this.OsVersion != null)
                    hash = hash * 59 + this.OsVersion.GetHashCode();

                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();

                return hash;
            }
        }
    }

}
