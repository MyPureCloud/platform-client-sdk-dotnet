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
    /// DigitalAction
    /// </summary>
    [DataContract]
    public partial class DigitalAction :  IEquatable<DigitalAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DigitalAction" /> class.
        /// </summary>
        /// <param name="UpdateContactColumnActionSettings">The settings for an &#39;update contact column&#39; action..</param>
        /// <param name="DoNotSendActionSettings">The settings for a &#39;do not send&#39; action..</param>
        /// <param name="AppendToDncActionSettings">The settings for an &#39;Append to DNC&#39; action..</param>
        /// <param name="MarkContactUncontactableActionSettings">The settings for a &#39;mark contact uncontactable&#39; action..</param>
        /// <param name="MarkContactAddressUncontactableActionSettings">The settings for an &#39;mark contact address uncontactable&#39; action..</param>
        /// <param name="SetContentTemplateActionSettings">The settings for a &#39;Set content template&#39; action..</param>
        /// <param name="SetSmsPhoneNumberActionSettings">The settings for a &#39;set sms phone number&#39; action..</param>
        public DigitalAction(UpdateContactColumnActionSettings UpdateContactColumnActionSettings = null, Object DoNotSendActionSettings = null, AppendToDncActionSettings AppendToDncActionSettings = null, MarkContactUncontactableActionSettings MarkContactUncontactableActionSettings = null, Object MarkContactAddressUncontactableActionSettings = null, SetContentTemplateActionSettings SetContentTemplateActionSettings = null, SetSmsPhoneNumberActionSettings SetSmsPhoneNumberActionSettings = null)
        {
            this.UpdateContactColumnActionSettings = UpdateContactColumnActionSettings;
            this.DoNotSendActionSettings = DoNotSendActionSettings;
            this.AppendToDncActionSettings = AppendToDncActionSettings;
            this.MarkContactUncontactableActionSettings = MarkContactUncontactableActionSettings;
            this.MarkContactAddressUncontactableActionSettings = MarkContactAddressUncontactableActionSettings;
            this.SetContentTemplateActionSettings = SetContentTemplateActionSettings;
            this.SetSmsPhoneNumberActionSettings = SetSmsPhoneNumberActionSettings;
            
        }
        


        /// <summary>
        /// The settings for an &#39;update contact column&#39; action.
        /// </summary>
        /// <value>The settings for an &#39;update contact column&#39; action.</value>
        [DataMember(Name="updateContactColumnActionSettings", EmitDefaultValue=false)]
        public UpdateContactColumnActionSettings UpdateContactColumnActionSettings { get; set; }



        /// <summary>
        /// The settings for a &#39;do not send&#39; action.
        /// </summary>
        /// <value>The settings for a &#39;do not send&#39; action.</value>
        [DataMember(Name="doNotSendActionSettings", EmitDefaultValue=false)]
        public Object DoNotSendActionSettings { get; set; }



        /// <summary>
        /// The settings for an &#39;Append to DNC&#39; action.
        /// </summary>
        /// <value>The settings for an &#39;Append to DNC&#39; action.</value>
        [DataMember(Name="appendToDncActionSettings", EmitDefaultValue=false)]
        public AppendToDncActionSettings AppendToDncActionSettings { get; set; }



        /// <summary>
        /// The settings for a &#39;mark contact uncontactable&#39; action.
        /// </summary>
        /// <value>The settings for a &#39;mark contact uncontactable&#39; action.</value>
        [DataMember(Name="markContactUncontactableActionSettings", EmitDefaultValue=false)]
        public MarkContactUncontactableActionSettings MarkContactUncontactableActionSettings { get; set; }



        /// <summary>
        /// The settings for an &#39;mark contact address uncontactable&#39; action.
        /// </summary>
        /// <value>The settings for an &#39;mark contact address uncontactable&#39; action.</value>
        [DataMember(Name="markContactAddressUncontactableActionSettings", EmitDefaultValue=false)]
        public Object MarkContactAddressUncontactableActionSettings { get; set; }



        /// <summary>
        /// The settings for a &#39;Set content template&#39; action.
        /// </summary>
        /// <value>The settings for a &#39;Set content template&#39; action.</value>
        [DataMember(Name="setContentTemplateActionSettings", EmitDefaultValue=false)]
        public SetContentTemplateActionSettings SetContentTemplateActionSettings { get; set; }



        /// <summary>
        /// The settings for a &#39;set sms phone number&#39; action.
        /// </summary>
        /// <value>The settings for a &#39;set sms phone number&#39; action.</value>
        [DataMember(Name="setSmsPhoneNumberActionSettings", EmitDefaultValue=false)]
        public SetSmsPhoneNumberActionSettings SetSmsPhoneNumberActionSettings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DigitalAction {\n");

            sb.Append("  UpdateContactColumnActionSettings: ").Append(UpdateContactColumnActionSettings).Append("\n");
            sb.Append("  DoNotSendActionSettings: ").Append(DoNotSendActionSettings).Append("\n");
            sb.Append("  AppendToDncActionSettings: ").Append(AppendToDncActionSettings).Append("\n");
            sb.Append("  MarkContactUncontactableActionSettings: ").Append(MarkContactUncontactableActionSettings).Append("\n");
            sb.Append("  MarkContactAddressUncontactableActionSettings: ").Append(MarkContactAddressUncontactableActionSettings).Append("\n");
            sb.Append("  SetContentTemplateActionSettings: ").Append(SetContentTemplateActionSettings).Append("\n");
            sb.Append("  SetSmsPhoneNumberActionSettings: ").Append(SetSmsPhoneNumberActionSettings).Append("\n");
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
            return this.Equals(obj as DigitalAction);
        }

        /// <summary>
        /// Returns true if DigitalAction instances are equal
        /// </summary>
        /// <param name="other">Instance of DigitalAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DigitalAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UpdateContactColumnActionSettings == other.UpdateContactColumnActionSettings ||
                    this.UpdateContactColumnActionSettings != null &&
                    this.UpdateContactColumnActionSettings.Equals(other.UpdateContactColumnActionSettings)
                ) &&
                (
                    this.DoNotSendActionSettings == other.DoNotSendActionSettings ||
                    this.DoNotSendActionSettings != null &&
                    this.DoNotSendActionSettings.Equals(other.DoNotSendActionSettings)
                ) &&
                (
                    this.AppendToDncActionSettings == other.AppendToDncActionSettings ||
                    this.AppendToDncActionSettings != null &&
                    this.AppendToDncActionSettings.Equals(other.AppendToDncActionSettings)
                ) &&
                (
                    this.MarkContactUncontactableActionSettings == other.MarkContactUncontactableActionSettings ||
                    this.MarkContactUncontactableActionSettings != null &&
                    this.MarkContactUncontactableActionSettings.Equals(other.MarkContactUncontactableActionSettings)
                ) &&
                (
                    this.MarkContactAddressUncontactableActionSettings == other.MarkContactAddressUncontactableActionSettings ||
                    this.MarkContactAddressUncontactableActionSettings != null &&
                    this.MarkContactAddressUncontactableActionSettings.Equals(other.MarkContactAddressUncontactableActionSettings)
                ) &&
                (
                    this.SetContentTemplateActionSettings == other.SetContentTemplateActionSettings ||
                    this.SetContentTemplateActionSettings != null &&
                    this.SetContentTemplateActionSettings.Equals(other.SetContentTemplateActionSettings)
                ) &&
                (
                    this.SetSmsPhoneNumberActionSettings == other.SetSmsPhoneNumberActionSettings ||
                    this.SetSmsPhoneNumberActionSettings != null &&
                    this.SetSmsPhoneNumberActionSettings.Equals(other.SetSmsPhoneNumberActionSettings)
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
                if (this.UpdateContactColumnActionSettings != null)
                    hash = hash * 59 + this.UpdateContactColumnActionSettings.GetHashCode();

                if (this.DoNotSendActionSettings != null)
                    hash = hash * 59 + this.DoNotSendActionSettings.GetHashCode();

                if (this.AppendToDncActionSettings != null)
                    hash = hash * 59 + this.AppendToDncActionSettings.GetHashCode();

                if (this.MarkContactUncontactableActionSettings != null)
                    hash = hash * 59 + this.MarkContactUncontactableActionSettings.GetHashCode();

                if (this.MarkContactAddressUncontactableActionSettings != null)
                    hash = hash * 59 + this.MarkContactAddressUncontactableActionSettings.GetHashCode();

                if (this.SetContentTemplateActionSettings != null)
                    hash = hash * 59 + this.SetContentTemplateActionSettings.GetHashCode();

                if (this.SetSmsPhoneNumberActionSettings != null)
                    hash = hash * 59 + this.SetSmsPhoneNumberActionSettings.GetHashCode();

                return hash;
            }
        }
    }

}
