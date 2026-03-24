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
    /// V3StartManualSyncRequest
    /// </summary>
    [DataContract]
    public partial class V3StartManualSyncRequest :  IEquatable<V3StartManualSyncRequest>
    {
        /// <summary>
        ///  Optional field that specifies the synchronization type. For SharePoint only Full synchronization is supported, therefore that is the default. For FileUpload both Full and Incremental is supported, default is Incremental.
        /// </summary>
        /// <value> Optional field that specifies the synchronization type. For SharePoint only Full synchronization is supported, therefore that is the default. For FileUpload both Full and Incremental is supported, default is Incremental.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Incremental for "Incremental"
            /// </summary>
            [EnumMember(Value = "Incremental")]
            Incremental,
            
            /// <summary>
            /// Enum Full for "Full"
            /// </summary>
            [EnumMember(Value = "Full")]
            Full
        }
        /// <summary>
        ///  Optional field that specifies the synchronization type. For SharePoint only Full synchronization is supported, therefore that is the default. For FileUpload both Full and Incremental is supported, default is Incremental.
        /// </summary>
        /// <value> Optional field that specifies the synchronization type. For SharePoint only Full synchronization is supported, therefore that is the default. For FileUpload both Full and Incremental is supported, default is Incremental.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V3StartManualSyncRequest" /> class.
        /// </summary>
        /// <param name="Type"> Optional field that specifies the synchronization type. For SharePoint only Full synchronization is supported, therefore that is the default. For FileUpload both Full and Incremental is supported, default is Incremental..</param>
        public V3StartManualSyncRequest(TypeEnum? Type = null)
        {
            this.Type = Type;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3StartManualSyncRequest {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as V3StartManualSyncRequest);
        }

        /// <summary>
        /// Returns true if V3StartManualSyncRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of V3StartManualSyncRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3StartManualSyncRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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

                return hash;
            }
        }
    }

}
