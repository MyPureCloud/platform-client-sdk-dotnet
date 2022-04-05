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
    /// EncryptionKey
    /// </summary>
    [DataContract]
    public partial class EncryptionKey :  IEquatable<EncryptionKey>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Key type used in this configuration
        /// </summary>
        /// <value>Key type used in this configuration</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum KeyConfigurationTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Kmssymmetric for "KmsSymmetric"
            /// </summary>
            [EnumMember(Value = "KmsSymmetric")]
            Kmssymmetric,
            
            /// <summary>
            /// Enum Localkeymanager for "LocalKeyManager"
            /// </summary>
            [EnumMember(Value = "LocalKeyManager")]
            Localkeymanager,
            
            /// <summary>
            /// Enum Native for "Native"
            /// </summary>
            [EnumMember(Value = "Native")]
            Native,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Key type used in this configuration
        /// </summary>
        /// <value>Key type used in this configuration</value>
        [DataMember(Name="keyConfigurationType", EmitDefaultValue=false)]
        public KeyConfigurationTypeEnum? KeyConfigurationType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionKey" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="CreateDate">create date of the key pair. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="KeydataSummary">key data summary (base 64 encoded public key).</param>
        /// <param name="User">user that requested generation of public key.</param>
        /// <param name="LocalEncryptionConfiguration">Local configuration.</param>
        /// <param name="KeyConfigurationType">Key type used in this configuration.</param>
        /// <param name="KmsKeyArn">ARN of internal key to be wrapped by AWS KMS Symmetric key.</param>
        public EncryptionKey(string Name = null, DateTime? CreateDate = null, string KeydataSummary = null, User User = null, LocalEncryptionConfiguration LocalEncryptionConfiguration = null, KeyConfigurationTypeEnum? KeyConfigurationType = null, string KmsKeyArn = null)
        {
            this.Name = Name;
            this.CreateDate = CreateDate;
            this.KeydataSummary = KeydataSummary;
            this.User = User;
            this.LocalEncryptionConfiguration = LocalEncryptionConfiguration;
            this.KeyConfigurationType = KeyConfigurationType;
            this.KmsKeyArn = KmsKeyArn;
            
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
        /// create date of the key pair. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>create date of the key pair. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }
        
        
        
        /// <summary>
        /// key data summary (base 64 encoded public key)
        /// </summary>
        /// <value>key data summary (base 64 encoded public key)</value>
        [DataMember(Name="keydataSummary", EmitDefaultValue=false)]
        public string KeydataSummary { get; set; }
        
        
        
        /// <summary>
        /// user that requested generation of public key
        /// </summary>
        /// <value>user that requested generation of public key</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        
        
        
        /// <summary>
        /// Local configuration
        /// </summary>
        /// <value>Local configuration</value>
        [DataMember(Name="localEncryptionConfiguration", EmitDefaultValue=false)]
        public LocalEncryptionConfiguration LocalEncryptionConfiguration { get; set; }
        
        
        
        
        
        /// <summary>
        /// ARN of internal key to be wrapped by AWS KMS Symmetric key
        /// </summary>
        /// <value>ARN of internal key to be wrapped by AWS KMS Symmetric key</value>
        [DataMember(Name="kmsKeyArn", EmitDefaultValue=false)]
        public string KmsKeyArn { get; set; }
        
        
        
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
            sb.Append("class EncryptionKey {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  KeydataSummary: ").Append(KeydataSummary).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  LocalEncryptionConfiguration: ").Append(LocalEncryptionConfiguration).Append("\n");
            sb.Append("  KeyConfigurationType: ").Append(KeyConfigurationType).Append("\n");
            sb.Append("  KmsKeyArn: ").Append(KmsKeyArn).Append("\n");
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
            return this.Equals(obj as EncryptionKey);
        }

        /// <summary>
        /// Returns true if EncryptionKey instances are equal
        /// </summary>
        /// <param name="other">Instance of EncryptionKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncryptionKey other)
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
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) &&
                (
                    this.KeydataSummary == other.KeydataSummary ||
                    this.KeydataSummary != null &&
                    this.KeydataSummary.Equals(other.KeydataSummary)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.LocalEncryptionConfiguration == other.LocalEncryptionConfiguration ||
                    this.LocalEncryptionConfiguration != null &&
                    this.LocalEncryptionConfiguration.Equals(other.LocalEncryptionConfiguration)
                ) &&
                (
                    this.KeyConfigurationType == other.KeyConfigurationType ||
                    this.KeyConfigurationType != null &&
                    this.KeyConfigurationType.Equals(other.KeyConfigurationType)
                ) &&
                (
                    this.KmsKeyArn == other.KmsKeyArn ||
                    this.KmsKeyArn != null &&
                    this.KmsKeyArn.Equals(other.KmsKeyArn)
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
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.KeydataSummary != null)
                    hash = hash * 59 + this.KeydataSummary.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.LocalEncryptionConfiguration != null)
                    hash = hash * 59 + this.LocalEncryptionConfiguration.GetHashCode();
                
                if (this.KeyConfigurationType != null)
                    hash = hash * 59 + this.KeyConfigurationType.GetHashCode();
                
                if (this.KmsKeyArn != null)
                    hash = hash * 59 + this.KmsKeyArn.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
