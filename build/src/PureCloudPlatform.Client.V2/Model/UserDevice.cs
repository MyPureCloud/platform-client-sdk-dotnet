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
    /// UserDevice
    /// </summary>
    [DataContract]
    public partial class UserDevice :  IEquatable<UserDevice>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// type of the device; ios or android
        /// </summary>
        /// <value>type of the device; ios or android</value>
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
            /// Enum Android for "android"
            /// </summary>
            [EnumMember(Value = "android")]
            Android,
            
            /// <summary>
            /// Enum Ios for "ios"
            /// </summary>
            [EnumMember(Value = "ios")]
            Ios
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// type of the device; ios or android
        /// </summary>
        /// <value>type of the device; ios or android</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDevice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserDevice() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDevice" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="DeviceToken">device token sent by mobile clients. (required).</param>
        
        
        
        /// <param name="NotificationId">notification id of the device. (required).</param>
        
        
        
        /// <param name="Make">make of the device. (required).</param>
        
        
        
        /// <param name="Model">Device model (required).</param>
        
        
        
        /// <param name="AcceptNotifications">if the device accepts notifications (required).</param>
        
        
        
        /// <param name="Type">type of the device; ios or android (required).</param>
        
        
        
        /// <param name="SessionHash">SessionHash.</param>
        
        
        
        
        public UserDevice(string Name = null, string DeviceToken = null, string NotificationId = null, string Make = null, string Model = null, bool? AcceptNotifications = null, TypeEnum? Type = null, string SessionHash = null)
        {
            
            
            
            
            
            
            
            
            
            // to ensure "DeviceToken" is required (not null)
            if (DeviceToken == null)
            {
                throw new InvalidDataException("DeviceToken is a required property for UserDevice and cannot be null");
            }
            else
            {
                this.DeviceToken = DeviceToken;
            }
            
            
            
            
            
            // to ensure "NotificationId" is required (not null)
            if (NotificationId == null)
            {
                throw new InvalidDataException("NotificationId is a required property for UserDevice and cannot be null");
            }
            else
            {
                this.NotificationId = NotificationId;
            }
            
            
            
            
            
            // to ensure "Make" is required (not null)
            if (Make == null)
            {
                throw new InvalidDataException("Make is a required property for UserDevice and cannot be null");
            }
            else
            {
                this.Make = Make;
            }
            
            
            
            
            
            // to ensure "Model" is required (not null)
            if (Model == null)
            {
                throw new InvalidDataException("Model is a required property for UserDevice and cannot be null");
            }
            else
            {
                this.Model = Model;
            }
            
            
            
            
            
            // to ensure "AcceptNotifications" is required (not null)
            if (AcceptNotifications == null)
            {
                throw new InvalidDataException("AcceptNotifications is a required property for UserDevice and cannot be null");
            }
            else
            {
                this.AcceptNotifications = AcceptNotifications;
            }
            
            
            
            
            
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for UserDevice and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.SessionHash = SessionHash;
            
            
            
            
            
            
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
        /// device token sent by mobile clients.
        /// </summary>
        /// <value>device token sent by mobile clients.</value>
        [DataMember(Name="deviceToken", EmitDefaultValue=false)]
        public string DeviceToken { get; set; }
        
        
        
        /// <summary>
        /// notification id of the device.
        /// </summary>
        /// <value>notification id of the device.</value>
        [DataMember(Name="notificationId", EmitDefaultValue=false)]
        public string NotificationId { get; set; }
        
        
        
        /// <summary>
        /// make of the device.
        /// </summary>
        /// <value>make of the device.</value>
        [DataMember(Name="make", EmitDefaultValue=false)]
        public string Make { get; set; }
        
        
        
        /// <summary>
        /// Device model
        /// </summary>
        /// <value>Device model</value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }
        
        
        
        /// <summary>
        /// if the device accepts notifications
        /// </summary>
        /// <value>if the device accepts notifications</value>
        [DataMember(Name="acceptNotifications", EmitDefaultValue=false)]
        public bool? AcceptNotifications { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets SessionHash
        /// </summary>
        [DataMember(Name="sessionHash", EmitDefaultValue=false)]
        public string SessionHash { get; set; }
        
        
        
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
            sb.Append("class UserDevice {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  DeviceToken: ").Append(DeviceToken).Append("\n");
            
            sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
            
            sb.Append("  Make: ").Append(Make).Append("\n");
            
            sb.Append("  Model: ").Append(Model).Append("\n");
            
            sb.Append("  AcceptNotifications: ").Append(AcceptNotifications).Append("\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            
            sb.Append("  SessionHash: ").Append(SessionHash).Append("\n");
            
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
            return this.Equals(obj as UserDevice);
        }

        /// <summary>
        /// Returns true if UserDevice instances are equal
        /// </summary>
        /// <param name="other">Instance of UserDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDevice other)
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
                    this.DeviceToken == other.DeviceToken ||
                    this.DeviceToken != null &&
                    this.DeviceToken.Equals(other.DeviceToken)
                ) &&
                (
                    this.NotificationId == other.NotificationId ||
                    this.NotificationId != null &&
                    this.NotificationId.Equals(other.NotificationId)
                ) &&
                (
                    this.Make == other.Make ||
                    this.Make != null &&
                    this.Make.Equals(other.Make)
                ) &&
                (
                    this.Model == other.Model ||
                    this.Model != null &&
                    this.Model.Equals(other.Model)
                ) &&
                (
                    this.AcceptNotifications == other.AcceptNotifications ||
                    this.AcceptNotifications != null &&
                    this.AcceptNotifications.Equals(other.AcceptNotifications)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.SessionHash == other.SessionHash ||
                    this.SessionHash != null &&
                    this.SessionHash.Equals(other.SessionHash)
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
                
                if (this.DeviceToken != null)
                    hash = hash * 59 + this.DeviceToken.GetHashCode();
                
                if (this.NotificationId != null)
                    hash = hash * 59 + this.NotificationId.GetHashCode();
                
                if (this.Make != null)
                    hash = hash * 59 + this.Make.GetHashCode();
                
                if (this.Model != null)
                    hash = hash * 59 + this.Model.GetHashCode();
                
                if (this.AcceptNotifications != null)
                    hash = hash * 59 + this.AcceptNotifications.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.SessionHash != null)
                    hash = hash * 59 + this.SessionHash.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
