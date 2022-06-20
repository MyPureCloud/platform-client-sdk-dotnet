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
    /// UC Integration UI configuration data
    /// </summary>
    [DataContract]
    public partial class UCIntegration :  IEquatable<UCIntegration>
    {
        /// <summary>
        /// integrationPresenceType
        /// </summary>
        /// <value>integrationPresenceType</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum IntegrationPresenceSourceEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Microsoftteams for "MicrosoftTeams"
            /// </summary>
            [EnumMember(Value = "MicrosoftTeams")]
            Microsoftteams,
            
            /// <summary>
            /// Enum Zoomphone for "ZoomPhone"
            /// </summary>
            [EnumMember(Value = "ZoomPhone")]
            Zoomphone,
            
            /// <summary>
            /// Enum Eightbyeight for "EightByEight"
            /// </summary>
            [EnumMember(Value = "EightByEight")]
            Eightbyeight
        }
        /// <summary>
        /// integrationPresenceType
        /// </summary>
        /// <value>integrationPresenceType</value>
        [DataMember(Name="integrationPresenceSource", EmitDefaultValue=false)]
        public IntegrationPresenceSourceEnum? IntegrationPresenceSource { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UCIntegration" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        public UCIntegration(string Name = null)
        {
            this.Name = Name;
            
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
        /// ucIntegrationKey
        /// </summary>
        /// <value>ucIntegrationKey</value>
        [DataMember(Name="ucIntegrationKey", EmitDefaultValue=false)]
        public string UcIntegrationKey { get; private set; }





        /// <summary>
        /// pbxPermission
        /// </summary>
        /// <value>pbxPermission</value>
        [DataMember(Name="pbxPermission", EmitDefaultValue=false)]
        public string PbxPermission { get; private set; }



        /// <summary>
        /// icon
        /// </summary>
        /// <value>icon</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public UCIcon Icon { get; private set; }



        /// <summary>
        /// badgeIcon
        /// </summary>
        /// <value>badgeIcon</value>
        [DataMember(Name="badgeIcons", EmitDefaultValue=false)]
        public Dictionary<string, UCIcon> BadgeIcons { get; private set; }



        /// <summary>
        /// i10n
        /// </summary>
        /// <value>i10n</value>
        [DataMember(Name="i10n", EmitDefaultValue=false)]
        public Dictionary<string, UCI10n> I10n { get; private set; }



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
            sb.Append("class UCIntegration {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UcIntegrationKey: ").Append(UcIntegrationKey).Append("\n");
            sb.Append("  IntegrationPresenceSource: ").Append(IntegrationPresenceSource).Append("\n");
            sb.Append("  PbxPermission: ").Append(PbxPermission).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  BadgeIcons: ").Append(BadgeIcons).Append("\n");
            sb.Append("  I10n: ").Append(I10n).Append("\n");
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
            return this.Equals(obj as UCIntegration);
        }

        /// <summary>
        /// Returns true if UCIntegration instances are equal
        /// </summary>
        /// <param name="other">Instance of UCIntegration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UCIntegration other)
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
                    this.UcIntegrationKey == other.UcIntegrationKey ||
                    this.UcIntegrationKey != null &&
                    this.UcIntegrationKey.Equals(other.UcIntegrationKey)
                ) &&
                (
                    this.IntegrationPresenceSource == other.IntegrationPresenceSource ||
                    this.IntegrationPresenceSource != null &&
                    this.IntegrationPresenceSource.Equals(other.IntegrationPresenceSource)
                ) &&
                (
                    this.PbxPermission == other.PbxPermission ||
                    this.PbxPermission != null &&
                    this.PbxPermission.Equals(other.PbxPermission)
                ) &&
                (
                    this.Icon == other.Icon ||
                    this.Icon != null &&
                    this.Icon.Equals(other.Icon)
                ) &&
                (
                    this.BadgeIcons == other.BadgeIcons ||
                    this.BadgeIcons != null &&
                    this.BadgeIcons.SequenceEqual(other.BadgeIcons)
                ) &&
                (
                    this.I10n == other.I10n ||
                    this.I10n != null &&
                    this.I10n.SequenceEqual(other.I10n)
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

                if (this.UcIntegrationKey != null)
                    hash = hash * 59 + this.UcIntegrationKey.GetHashCode();

                if (this.IntegrationPresenceSource != null)
                    hash = hash * 59 + this.IntegrationPresenceSource.GetHashCode();

                if (this.PbxPermission != null)
                    hash = hash * 59 + this.PbxPermission.GetHashCode();

                if (this.Icon != null)
                    hash = hash * 59 + this.Icon.GetHashCode();

                if (this.BadgeIcons != null)
                    hash = hash * 59 + this.BadgeIcons.GetHashCode();

                if (this.I10n != null)
                    hash = hash * 59 + this.I10n.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
