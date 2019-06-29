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
    /// Represents a SCIM V2 Enterprise Manager
    /// </summary>
    [DataContract]
    public partial class Manager :  IEquatable<Manager>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Manager" /> class.
        /// </summary>
        /// <param name="DisplayName">Display Name.</param>
        /// <param name="Active">Active flag.</param>
        /// <param name="UserName">User Name (Must be Unique) maps to PureCloud e-mail address.</param>
        /// <param name="Password">Password (updateOnly).</param>
        /// <param name="Title">Title.</param>
        /// <param name="PhoneNumbers">Phone numbers.</param>
        /// <param name="Emails">Emails.</param>
        /// <param name="Photos">Photos.</param>
        /// <param name="ExternalId">External ID.</param>
        /// <param name="Groups">Group References.</param>
        /// <param name="Meta">Meta.</param>
        /// <param name="Urnietfparamsscimschemasextensionenterprise20User">Urnietfparamsscimschemasextensionenterprise20User.</param>
        /// <param name="Value">Identifier of the Manager.</param>
        public Manager(string DisplayName = null, bool? Active = null, string UserName = null, string Password = null, string Title = null, List<ScimPhoneNumber> PhoneNumbers = null, List<ScimEmail> Emails = null, List<Photo> Photos = null, string ExternalId = null, List<ScimV2GroupReference> Groups = null, ScimMetadata Meta = null, ScimV2EnterpriseUser Urnietfparamsscimschemasextensionenterprise20User = null, string Value = null)
        {
            this.DisplayName = DisplayName;
            this.Active = Active;
            this.UserName = UserName;
            this.Password = Password;
            this.Title = Title;
            this.PhoneNumbers = PhoneNumbers;
            this.Emails = Emails;
            this.Photos = Photos;
            this.ExternalId = ExternalId;
            this.Groups = Groups;
            this.Meta = Meta;
            this.Urnietfparamsscimschemasextensionenterprise20User = Urnietfparamsscimschemasextensionenterprise20User;
            this.Value = Value;
            
        }
        
        
        
        /// <summary>
        /// Display Name
        /// </summary>
        /// <value>Display Name</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        
        
        
        /// <summary>
        /// Active flag
        /// </summary>
        /// <value>Active flag</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        
        
        
        /// <summary>
        /// User Name (Must be Unique) maps to PureCloud e-mail address
        /// </summary>
        /// <value>User Name (Must be Unique) maps to PureCloud e-mail address</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        
        
        
        /// <summary>
        /// Password (updateOnly)
        /// </summary>
        /// <value>Password (updateOnly)</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        
        
        
        /// <summary>
        /// Title
        /// </summary>
        /// <value>Title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        
        
        
        /// <summary>
        /// Phone numbers
        /// </summary>
        /// <value>Phone numbers</value>
        [DataMember(Name="phoneNumbers", EmitDefaultValue=false)]
        public List<ScimPhoneNumber> PhoneNumbers { get; set; }
        
        
        
        /// <summary>
        /// Emails
        /// </summary>
        /// <value>Emails</value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<ScimEmail> Emails { get; set; }
        
        
        
        /// <summary>
        /// Photos
        /// </summary>
        /// <value>Photos</value>
        [DataMember(Name="photos", EmitDefaultValue=false)]
        public List<Photo> Photos { get; set; }
        
        
        
        /// <summary>
        /// External ID
        /// </summary>
        /// <value>External ID</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }
        
        
        
        /// <summary>
        /// Group References
        /// </summary>
        /// <value>Group References</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<ScimV2GroupReference> Groups { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public ScimMetadata Meta { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Urnietfparamsscimschemasextensionenterprise20User
        /// </summary>
        [DataMember(Name="urn:ietf:params:scim:schemas:extension:enterprise:2.0:User", EmitDefaultValue=false)]
        public ScimV2EnterpriseUser Urnietfparamsscimschemasextensionenterprise20User { get; set; }
        
        
        
        /// <summary>
        /// Identifier of the Manager
        /// </summary>
        /// <value>Identifier of the Manager</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        /// <summary>
        /// Ref to entity
        /// </summary>
        /// <value>Ref to entity</value>
        [DataMember(Name="$ref", EmitDefaultValue=false)]
        public string _Ref { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Manager {\n");
            
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Photos: ").Append(Photos).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Urnietfparamsscimschemasextensionenterprise20User: ").Append(Urnietfparamsscimschemasextensionenterprise20User).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  _Ref: ").Append(_Ref).Append("\n");
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
            return this.Equals(obj as Manager);
        }

        /// <summary>
        /// Returns true if Manager instances are equal
        /// </summary>
        /// <param name="other">Instance of Manager to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Manager other)
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
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) &&
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) &&
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.PhoneNumbers == other.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(other.PhoneNumbers)
                ) &&
                (
                    this.Emails == other.Emails ||
                    this.Emails != null &&
                    this.Emails.SequenceEqual(other.Emails)
                ) &&
                (
                    this.Photos == other.Photos ||
                    this.Photos != null &&
                    this.Photos.SequenceEqual(other.Photos)
                ) &&
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) &&
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) &&
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
                ) &&
                (
                    this.Urnietfparamsscimschemasextensionenterprise20User == other.Urnietfparamsscimschemasextensionenterprise20User ||
                    this.Urnietfparamsscimschemasextensionenterprise20User != null &&
                    this.Urnietfparamsscimschemasextensionenterprise20User.Equals(other.Urnietfparamsscimschemasextensionenterprise20User)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this._Ref == other._Ref ||
                    this._Ref != null &&
                    this._Ref.Equals(other._Ref)
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
                
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.PhoneNumbers != null)
                    hash = hash * 59 + this.PhoneNumbers.GetHashCode();
                
                if (this.Emails != null)
                    hash = hash * 59 + this.Emails.GetHashCode();
                
                if (this.Photos != null)
                    hash = hash * 59 + this.Photos.GetHashCode();
                
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                if (this.Urnietfparamsscimschemasextensionenterprise20User != null)
                    hash = hash * 59 + this.Urnietfparamsscimschemasextensionenterprise20User.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this._Ref != null)
                    hash = hash * 59 + this._Ref.GetHashCode();
                
                return hash;
            }
        }
    }

}
