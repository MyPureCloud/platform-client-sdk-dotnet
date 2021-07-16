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
    /// MediaTranscription
    /// </summary>
    [DataContract]
    public partial class MediaTranscription :  IEquatable<MediaTranscription>
    {
        
        
        
        
        
        /// <summary>
        /// Gets or Sets TranscriptionProvider
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TranscriptionProviderEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voci for "VOCI"
            /// </summary>
            [EnumMember(Value = "VOCI")]
            Voci,
            
            /// <summary>
            /// Enum Calljourney for "CALLJOURNEY"
            /// </summary>
            [EnumMember(Value = "CALLJOURNEY")]
            Calljourney
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets TranscriptionProvider
        /// </summary>
        [DataMember(Name="transcriptionProvider", EmitDefaultValue=false)]
        public TranscriptionProviderEnum? TranscriptionProvider { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaTranscription" /> class.
        /// </summary>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="TranscriptionProvider">TranscriptionProvider.</param>
        /// <param name="IntegrationId">IntegrationId.</param>
        public MediaTranscription(string DisplayName = null, TranscriptionProviderEnum? TranscriptionProvider = null, string IntegrationId = null)
        {
            this.DisplayName = DisplayName;
            this.TranscriptionProvider = TranscriptionProvider;
            this.IntegrationId = IntegrationId;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets IntegrationId
        /// </summary>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaTranscription {\n");
            
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  TranscriptionProvider: ").Append(TranscriptionProvider).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
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
            return this.Equals(obj as MediaTranscription);
        }

        /// <summary>
        /// Returns true if MediaTranscription instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaTranscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaTranscription other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.TranscriptionProvider == other.TranscriptionProvider ||
                    this.TranscriptionProvider != null &&
                    this.TranscriptionProvider.Equals(other.TranscriptionProvider)
                ) &&
                (
                    this.IntegrationId == other.IntegrationId ||
                    this.IntegrationId != null &&
                    this.IntegrationId.Equals(other.IntegrationId)
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
                
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                
                if (this.TranscriptionProvider != null)
                    hash = hash * 59 + this.TranscriptionProvider.GetHashCode();
                
                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();
                
                return hash;
            }
        }
    }

}
