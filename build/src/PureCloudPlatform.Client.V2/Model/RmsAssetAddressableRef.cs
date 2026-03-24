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
    /// RmsAssetAddressableRef
    /// </summary>
    [DataContract]
    public partial class RmsAssetAddressableRef :  IEquatable<RmsAssetAddressableRef>
    {
        /// <summary>
        /// Usage of the asset. Null for inline images, 'FileAttachments' for file attachments
        /// </summary>
        /// <value>Usage of the asset. Null for inline images, 'FileAttachments' for file attachments</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AssetUsageEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Fileattachments for "FileAttachments"
            /// </summary>
            [EnumMember(Value = "FileAttachments")]
            Fileattachments
        }
        /// <summary>
        /// Usage of the asset. Null for inline images, 'FileAttachments' for file attachments
        /// </summary>
        /// <value>Usage of the asset. Null for inline images, 'FileAttachments' for file attachments</value>
        [DataMember(Name="assetUsage", EmitDefaultValue=false)]
        public AssetUsageEnum? AssetUsage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RmsAssetAddressableRef" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="AssetUsage">Usage of the asset. Null for inline images, &#39;FileAttachments&#39; for file attachments.</param>
        /// <param name="ContentLocation">Content location URL for the asset.</param>
        public RmsAssetAddressableRef(string Id = null, string SelfUri = null, AssetUsageEnum? AssetUsage = null, string ContentLocation = null)
        {
            this.Id = Id;
            this.SelfUri = SelfUri;
            this.AssetUsage = AssetUsage;
            this.ContentLocation = ContentLocation;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }





        /// <summary>
        /// Content location URL for the asset
        /// </summary>
        /// <value>Content location URL for the asset</value>
        [DataMember(Name="contentLocation", EmitDefaultValue=false)]
        public string ContentLocation { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RmsAssetAddressableRef {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  AssetUsage: ").Append(AssetUsage).Append("\n");
            sb.Append("  ContentLocation: ").Append(ContentLocation).Append("\n");
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
            return this.Equals(obj as RmsAssetAddressableRef);
        }

        /// <summary>
        /// Returns true if RmsAssetAddressableRef instances are equal
        /// </summary>
        /// <param name="other">Instance of RmsAssetAddressableRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RmsAssetAddressableRef other)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.AssetUsage == other.AssetUsage ||
                    this.AssetUsage != null &&
                    this.AssetUsage.Equals(other.AssetUsage)
                ) &&
                (
                    this.ContentLocation == other.ContentLocation ||
                    this.ContentLocation != null &&
                    this.ContentLocation.Equals(other.ContentLocation)
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

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.AssetUsage != null)
                    hash = hash * 59 + this.AssetUsage.GetHashCode();

                if (this.ContentLocation != null)
                    hash = hash * 59 + this.ContentLocation.GetHashCode();

                return hash;
            }
        }
    }

}
