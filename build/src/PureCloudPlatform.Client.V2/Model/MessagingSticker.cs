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
    /// MessagingSticker
    /// </summary>
    [DataContract]
    public partial class MessagingSticker :  IEquatable<MessagingSticker>
    {
        /// <summary>
        /// The type of the messenger provider.
        /// </summary>
        /// <value>The type of the messenger provider.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessengerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sms for "sms"
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms,
            
            /// <summary>
            /// Enum Facebook for "facebook"
            /// </summary>
            [EnumMember(Value = "facebook")]
            Facebook,
            
            /// <summary>
            /// Enum Twitter for "twitter"
            /// </summary>
            [EnumMember(Value = "twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Line for "line"
            /// </summary>
            [EnumMember(Value = "line")]
            Line,
            
            /// <summary>
            /// Enum Whatsapp for "whatsapp"
            /// </summary>
            [EnumMember(Value = "whatsapp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Webmessaging for "webmessaging"
            /// </summary>
            [EnumMember(Value = "webmessaging")]
            Webmessaging,
            
            /// <summary>
            /// Enum Instagram for "instagram"
            /// </summary>
            [EnumMember(Value = "instagram")]
            Instagram,
            
            /// <summary>
            /// Enum Open for "open"
            /// </summary>
            [EnumMember(Value = "open")]
            Open
        }
        /// <summary>
        /// The type of the sticker.
        /// </summary>
        /// <value>The type of the sticker.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StickerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Standard for "standard"
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard,
            
            /// <summary>
            /// Enum Free for "free"
            /// </summary>
            [EnumMember(Value = "free")]
            Free,
            
            /// <summary>
            /// Enum Paid for "paid"
            /// </summary>
            [EnumMember(Value = "paid")]
            Paid
        }
        /// <summary>
        /// The type of the messenger provider.
        /// </summary>
        /// <value>The type of the messenger provider.</value>
        [DataMember(Name="messengerType", EmitDefaultValue=false)]
        public MessengerTypeEnum? MessengerType { get; set; }
        /// <summary>
        /// The type of the sticker.
        /// </summary>
        /// <value>The type of the sticker.</value>
        [DataMember(Name="stickerType", EmitDefaultValue=false)]
        public StickerTypeEnum? StickerType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingSticker" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagingSticker() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingSticker" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ProviderStickerId">The sticker Id of the sticker, assigned by the sticker provider. (required).</param>
        /// <param name="ProviderPackageId">The package Id of the sticker, assigned by the sticker provider..</param>
        /// <param name="PackageName">The package name of the sticker, assigned by the sticker provider..</param>
        /// <param name="MessengerType">The type of the messenger provider. (required).</param>
        /// <param name="StickerType">The type of the sticker. (required).</param>
        /// <param name="ProviderVersion">The version of the sticker, assigned by the provider..</param>
        /// <param name="UriLocation">UriLocation.</param>
        public MessagingSticker(string Name = null, int? ProviderStickerId = null, int? ProviderPackageId = null, string PackageName = null, MessengerTypeEnum? MessengerType = null, StickerTypeEnum? StickerType = null, long? ProviderVersion = null, string UriLocation = null)
        {
            this.Name = Name;
            this.ProviderStickerId = ProviderStickerId;
            this.ProviderPackageId = ProviderPackageId;
            this.PackageName = PackageName;
            this.MessengerType = MessengerType;
            this.StickerType = StickerType;
            this.ProviderVersion = ProviderVersion;
            this.UriLocation = UriLocation;
            
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
        /// The sticker Id of the sticker, assigned by the sticker provider.
        /// </summary>
        /// <value>The sticker Id of the sticker, assigned by the sticker provider.</value>
        [DataMember(Name="providerStickerId", EmitDefaultValue=false)]
        public int? ProviderStickerId { get; set; }



        /// <summary>
        /// The package Id of the sticker, assigned by the sticker provider.
        /// </summary>
        /// <value>The package Id of the sticker, assigned by the sticker provider.</value>
        [DataMember(Name="providerPackageId", EmitDefaultValue=false)]
        public int? ProviderPackageId { get; set; }



        /// <summary>
        /// The package name of the sticker, assigned by the sticker provider.
        /// </summary>
        /// <value>The package name of the sticker, assigned by the sticker provider.</value>
        [DataMember(Name="packageName", EmitDefaultValue=false)]
        public string PackageName { get; set; }







        /// <summary>
        /// The version of the sticker, assigned by the provider.
        /// </summary>
        /// <value>The version of the sticker, assigned by the provider.</value>
        [DataMember(Name="providerVersion", EmitDefaultValue=false)]
        public long? ProviderVersion { get; set; }



        /// <summary>
        /// Gets or Sets UriLocation
        /// </summary>
        [DataMember(Name="uriLocation", EmitDefaultValue=false)]
        public string UriLocation { get; set; }



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
            sb.Append("class MessagingSticker {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProviderStickerId: ").Append(ProviderStickerId).Append("\n");
            sb.Append("  ProviderPackageId: ").Append(ProviderPackageId).Append("\n");
            sb.Append("  PackageName: ").Append(PackageName).Append("\n");
            sb.Append("  MessengerType: ").Append(MessengerType).Append("\n");
            sb.Append("  StickerType: ").Append(StickerType).Append("\n");
            sb.Append("  ProviderVersion: ").Append(ProviderVersion).Append("\n");
            sb.Append("  UriLocation: ").Append(UriLocation).Append("\n");
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
            return this.Equals(obj as MessagingSticker);
        }

        /// <summary>
        /// Returns true if MessagingSticker instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingSticker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingSticker other)
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
                    this.ProviderStickerId == other.ProviderStickerId ||
                    this.ProviderStickerId != null &&
                    this.ProviderStickerId.Equals(other.ProviderStickerId)
                ) &&
                (
                    this.ProviderPackageId == other.ProviderPackageId ||
                    this.ProviderPackageId != null &&
                    this.ProviderPackageId.Equals(other.ProviderPackageId)
                ) &&
                (
                    this.PackageName == other.PackageName ||
                    this.PackageName != null &&
                    this.PackageName.Equals(other.PackageName)
                ) &&
                (
                    this.MessengerType == other.MessengerType ||
                    this.MessengerType != null &&
                    this.MessengerType.Equals(other.MessengerType)
                ) &&
                (
                    this.StickerType == other.StickerType ||
                    this.StickerType != null &&
                    this.StickerType.Equals(other.StickerType)
                ) &&
                (
                    this.ProviderVersion == other.ProviderVersion ||
                    this.ProviderVersion != null &&
                    this.ProviderVersion.Equals(other.ProviderVersion)
                ) &&
                (
                    this.UriLocation == other.UriLocation ||
                    this.UriLocation != null &&
                    this.UriLocation.Equals(other.UriLocation)
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

                if (this.ProviderStickerId != null)
                    hash = hash * 59 + this.ProviderStickerId.GetHashCode();

                if (this.ProviderPackageId != null)
                    hash = hash * 59 + this.ProviderPackageId.GetHashCode();

                if (this.PackageName != null)
                    hash = hash * 59 + this.PackageName.GetHashCode();

                if (this.MessengerType != null)
                    hash = hash * 59 + this.MessengerType.GetHashCode();

                if (this.StickerType != null)
                    hash = hash * 59 + this.StickerType.GetHashCode();

                if (this.ProviderVersion != null)
                    hash = hash * 59 + this.ProviderVersion.GetHashCode();

                if (this.UriLocation != null)
                    hash = hash * 59 + this.UriLocation.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
