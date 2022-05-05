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
    /// Settings concerning support center
    /// </summary>
    [DataContract]
    public partial class SupportCenterSettings :  IEquatable<SupportCenterSettings>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Router type for support center
        /// </summary>
        /// <value>Router type for support center</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RouterTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Hash for "Hash"
            /// </summary>
            [EnumMember(Value = "Hash")]
            Hash,
            
            /// <summary>
            /// Enum Browser for "Browser"
            /// </summary>
            [EnumMember(Value = "Browser")]
            Browser
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Router type for support center
        /// </summary>
        /// <value>Router type for support center</value>
        [DataMember(Name="routerType", EmitDefaultValue=false)]
        public RouterTypeEnum? RouterType { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterSettings" /> class.
        /// </summary>
        /// <param name="Enabled">Whether or not support center is enabled.</param>
        /// <param name="KnowledgeBase">The knowledge base for support center.</param>
        /// <param name="CustomMessages">Customizable display texts for support center.</param>
        /// <param name="RouterType">Router type for support center.</param>
        /// <param name="Screens">Available screens for the support center with its modules.</param>
        /// <param name="EnabledCategories">Enabled article categories for support center.</param>
        /// <param name="StyleSetting">Style attributes for support center.</param>
        public SupportCenterSettings(bool? Enabled = null, AddressableEntityRef KnowledgeBase = null, List<SupportCenterCustomMessage> CustomMessages = null, RouterTypeEnum? RouterType = null, List<SupportCenterScreen> Screens = null, List<AddressableEntityRef> EnabledCategories = null, SupportCenterStyleSetting StyleSetting = null)
        {
            this.Enabled = Enabled;
            this.KnowledgeBase = KnowledgeBase;
            this.CustomMessages = CustomMessages;
            this.RouterType = RouterType;
            this.Screens = Screens;
            this.EnabledCategories = EnabledCategories;
            this.StyleSetting = StyleSetting;
            
        }
        
        
        
        /// <summary>
        /// Whether or not support center is enabled
        /// </summary>
        /// <value>Whether or not support center is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// The knowledge base for support center
        /// </summary>
        /// <value>The knowledge base for support center</value>
        [DataMember(Name="knowledgeBase", EmitDefaultValue=false)]
        public AddressableEntityRef KnowledgeBase { get; set; }
        
        
        
        /// <summary>
        /// Customizable display texts for support center
        /// </summary>
        /// <value>Customizable display texts for support center</value>
        [DataMember(Name="customMessages", EmitDefaultValue=false)]
        public List<SupportCenterCustomMessage> CustomMessages { get; set; }
        
        
        
        
        
        /// <summary>
        /// Available screens for the support center with its modules
        /// </summary>
        /// <value>Available screens for the support center with its modules</value>
        [DataMember(Name="screens", EmitDefaultValue=false)]
        public List<SupportCenterScreen> Screens { get; set; }
        
        
        
        /// <summary>
        /// Enabled article categories for support center
        /// </summary>
        /// <value>Enabled article categories for support center</value>
        [DataMember(Name="enabledCategories", EmitDefaultValue=false)]
        public List<AddressableEntityRef> EnabledCategories { get; set; }
        
        
        
        /// <summary>
        /// Style attributes for support center
        /// </summary>
        /// <value>Style attributes for support center</value>
        [DataMember(Name="styleSetting", EmitDefaultValue=false)]
        public SupportCenterStyleSetting StyleSetting { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportCenterSettings {\n");
            
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
            sb.Append("  CustomMessages: ").Append(CustomMessages).Append("\n");
            sb.Append("  RouterType: ").Append(RouterType).Append("\n");
            sb.Append("  Screens: ").Append(Screens).Append("\n");
            sb.Append("  EnabledCategories: ").Append(EnabledCategories).Append("\n");
            sb.Append("  StyleSetting: ").Append(StyleSetting).Append("\n");
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
            return this.Equals(obj as SupportCenterSettings);
        }

        /// <summary>
        /// Returns true if SupportCenterSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportCenterSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportCenterSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.KnowledgeBase == other.KnowledgeBase ||
                    this.KnowledgeBase != null &&
                    this.KnowledgeBase.Equals(other.KnowledgeBase)
                ) &&
                (
                    this.CustomMessages == other.CustomMessages ||
                    this.CustomMessages != null &&
                    this.CustomMessages.SequenceEqual(other.CustomMessages)
                ) &&
                (
                    this.RouterType == other.RouterType ||
                    this.RouterType != null &&
                    this.RouterType.Equals(other.RouterType)
                ) &&
                (
                    this.Screens == other.Screens ||
                    this.Screens != null &&
                    this.Screens.SequenceEqual(other.Screens)
                ) &&
                (
                    this.EnabledCategories == other.EnabledCategories ||
                    this.EnabledCategories != null &&
                    this.EnabledCategories.SequenceEqual(other.EnabledCategories)
                ) &&
                (
                    this.StyleSetting == other.StyleSetting ||
                    this.StyleSetting != null &&
                    this.StyleSetting.Equals(other.StyleSetting)
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
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.KnowledgeBase != null)
                    hash = hash * 59 + this.KnowledgeBase.GetHashCode();
                
                if (this.CustomMessages != null)
                    hash = hash * 59 + this.CustomMessages.GetHashCode();
                
                if (this.RouterType != null)
                    hash = hash * 59 + this.RouterType.GetHashCode();
                
                if (this.Screens != null)
                    hash = hash * 59 + this.Screens.GetHashCode();
                
                if (this.EnabledCategories != null)
                    hash = hash * 59 + this.EnabledCategories.GetHashCode();
                
                if (this.StyleSetting != null)
                    hash = hash * 59 + this.StyleSetting.GetHashCode();
                
                return hash;
            }
        }
    }

}
