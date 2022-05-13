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
    /// OrganizationFeatures
    /// </summary>
    [DataContract]
    public partial class OrganizationFeatures :  IEquatable<OrganizationFeatures>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationFeatures" /> class.
        /// </summary>
        /// <param name="RealtimeCIC">RealtimeCIC.</param>
        /// <param name="Purecloud">Purecloud.</param>
        /// <param name="Hipaa">Hipaa.</param>
        /// <param name="UcEnabled">UcEnabled.</param>
        /// <param name="Pci">Pci.</param>
        /// <param name="PurecloudVoice">PurecloudVoice.</param>
        /// <param name="XmppFederation">XmppFederation.</param>
        /// <param name="Chat">Chat.</param>
        /// <param name="InformalPhotos">InformalPhotos.</param>
        /// <param name="Directory">Directory.</param>
        /// <param name="ContactCenter">ContactCenter.</param>
        /// <param name="UnifiedCommunications">UnifiedCommunications.</param>
        /// <param name="Custserv">Custserv.</param>
        public OrganizationFeatures(bool? RealtimeCIC = null, bool? Purecloud = null, bool? Hipaa = null, bool? UcEnabled = null, bool? Pci = null, bool? PurecloudVoice = null, bool? XmppFederation = null, bool? Chat = null, bool? InformalPhotos = null, bool? Directory = null, bool? ContactCenter = null, bool? UnifiedCommunications = null, bool? Custserv = null)
        {
            this.RealtimeCIC = RealtimeCIC;
            this.Purecloud = Purecloud;
            this.Hipaa = Hipaa;
            this.UcEnabled = UcEnabled;
            this.Pci = Pci;
            this.PurecloudVoice = PurecloudVoice;
            this.XmppFederation = XmppFederation;
            this.Chat = Chat;
            this.InformalPhotos = InformalPhotos;
            this.Directory = Directory;
            this.ContactCenter = ContactCenter;
            this.UnifiedCommunications = UnifiedCommunications;
            this.Custserv = Custserv;
            
        }
        


        /// <summary>
        /// Gets or Sets RealtimeCIC
        /// </summary>
        [DataMember(Name="realtimeCIC", EmitDefaultValue=false)]
        public bool? RealtimeCIC { get; set; }



        /// <summary>
        /// Gets or Sets Purecloud
        /// </summary>
        [DataMember(Name="purecloud", EmitDefaultValue=false)]
        public bool? Purecloud { get; set; }



        /// <summary>
        /// Gets or Sets Hipaa
        /// </summary>
        [DataMember(Name="hipaa", EmitDefaultValue=false)]
        public bool? Hipaa { get; set; }



        /// <summary>
        /// Gets or Sets UcEnabled
        /// </summary>
        [DataMember(Name="ucEnabled", EmitDefaultValue=false)]
        public bool? UcEnabled { get; set; }



        /// <summary>
        /// Gets or Sets Pci
        /// </summary>
        [DataMember(Name="pci", EmitDefaultValue=false)]
        public bool? Pci { get; set; }



        /// <summary>
        /// Gets or Sets PurecloudVoice
        /// </summary>
        [DataMember(Name="purecloudVoice", EmitDefaultValue=false)]
        public bool? PurecloudVoice { get; set; }



        /// <summary>
        /// Gets or Sets XmppFederation
        /// </summary>
        [DataMember(Name="xmppFederation", EmitDefaultValue=false)]
        public bool? XmppFederation { get; set; }



        /// <summary>
        /// Gets or Sets Chat
        /// </summary>
        [DataMember(Name="chat", EmitDefaultValue=false)]
        public bool? Chat { get; set; }



        /// <summary>
        /// Gets or Sets InformalPhotos
        /// </summary>
        [DataMember(Name="informalPhotos", EmitDefaultValue=false)]
        public bool? InformalPhotos { get; set; }



        /// <summary>
        /// Gets or Sets Directory
        /// </summary>
        [DataMember(Name="directory", EmitDefaultValue=false)]
        public bool? Directory { get; set; }



        /// <summary>
        /// Gets or Sets ContactCenter
        /// </summary>
        [DataMember(Name="contactCenter", EmitDefaultValue=false)]
        public bool? ContactCenter { get; set; }



        /// <summary>
        /// Gets or Sets UnifiedCommunications
        /// </summary>
        [DataMember(Name="unifiedCommunications", EmitDefaultValue=false)]
        public bool? UnifiedCommunications { get; set; }



        /// <summary>
        /// Gets or Sets Custserv
        /// </summary>
        [DataMember(Name="custserv", EmitDefaultValue=false)]
        public bool? Custserv { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationFeatures {\n");

            sb.Append("  RealtimeCIC: ").Append(RealtimeCIC).Append("\n");
            sb.Append("  Purecloud: ").Append(Purecloud).Append("\n");
            sb.Append("  Hipaa: ").Append(Hipaa).Append("\n");
            sb.Append("  UcEnabled: ").Append(UcEnabled).Append("\n");
            sb.Append("  Pci: ").Append(Pci).Append("\n");
            sb.Append("  PurecloudVoice: ").Append(PurecloudVoice).Append("\n");
            sb.Append("  XmppFederation: ").Append(XmppFederation).Append("\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  InformalPhotos: ").Append(InformalPhotos).Append("\n");
            sb.Append("  Directory: ").Append(Directory).Append("\n");
            sb.Append("  ContactCenter: ").Append(ContactCenter).Append("\n");
            sb.Append("  UnifiedCommunications: ").Append(UnifiedCommunications).Append("\n");
            sb.Append("  Custserv: ").Append(Custserv).Append("\n");
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
            return this.Equals(obj as OrganizationFeatures);
        }

        /// <summary>
        /// Returns true if OrganizationFeatures instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationFeatures other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RealtimeCIC == other.RealtimeCIC ||
                    this.RealtimeCIC != null &&
                    this.RealtimeCIC.Equals(other.RealtimeCIC)
                ) &&
                (
                    this.Purecloud == other.Purecloud ||
                    this.Purecloud != null &&
                    this.Purecloud.Equals(other.Purecloud)
                ) &&
                (
                    this.Hipaa == other.Hipaa ||
                    this.Hipaa != null &&
                    this.Hipaa.Equals(other.Hipaa)
                ) &&
                (
                    this.UcEnabled == other.UcEnabled ||
                    this.UcEnabled != null &&
                    this.UcEnabled.Equals(other.UcEnabled)
                ) &&
                (
                    this.Pci == other.Pci ||
                    this.Pci != null &&
                    this.Pci.Equals(other.Pci)
                ) &&
                (
                    this.PurecloudVoice == other.PurecloudVoice ||
                    this.PurecloudVoice != null &&
                    this.PurecloudVoice.Equals(other.PurecloudVoice)
                ) &&
                (
                    this.XmppFederation == other.XmppFederation ||
                    this.XmppFederation != null &&
                    this.XmppFederation.Equals(other.XmppFederation)
                ) &&
                (
                    this.Chat == other.Chat ||
                    this.Chat != null &&
                    this.Chat.Equals(other.Chat)
                ) &&
                (
                    this.InformalPhotos == other.InformalPhotos ||
                    this.InformalPhotos != null &&
                    this.InformalPhotos.Equals(other.InformalPhotos)
                ) &&
                (
                    this.Directory == other.Directory ||
                    this.Directory != null &&
                    this.Directory.Equals(other.Directory)
                ) &&
                (
                    this.ContactCenter == other.ContactCenter ||
                    this.ContactCenter != null &&
                    this.ContactCenter.Equals(other.ContactCenter)
                ) &&
                (
                    this.UnifiedCommunications == other.UnifiedCommunications ||
                    this.UnifiedCommunications != null &&
                    this.UnifiedCommunications.Equals(other.UnifiedCommunications)
                ) &&
                (
                    this.Custserv == other.Custserv ||
                    this.Custserv != null &&
                    this.Custserv.Equals(other.Custserv)
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
                if (this.RealtimeCIC != null)
                    hash = hash * 59 + this.RealtimeCIC.GetHashCode();

                if (this.Purecloud != null)
                    hash = hash * 59 + this.Purecloud.GetHashCode();

                if (this.Hipaa != null)
                    hash = hash * 59 + this.Hipaa.GetHashCode();

                if (this.UcEnabled != null)
                    hash = hash * 59 + this.UcEnabled.GetHashCode();

                if (this.Pci != null)
                    hash = hash * 59 + this.Pci.GetHashCode();

                if (this.PurecloudVoice != null)
                    hash = hash * 59 + this.PurecloudVoice.GetHashCode();

                if (this.XmppFederation != null)
                    hash = hash * 59 + this.XmppFederation.GetHashCode();

                if (this.Chat != null)
                    hash = hash * 59 + this.Chat.GetHashCode();

                if (this.InformalPhotos != null)
                    hash = hash * 59 + this.InformalPhotos.GetHashCode();

                if (this.Directory != null)
                    hash = hash * 59 + this.Directory.GetHashCode();

                if (this.ContactCenter != null)
                    hash = hash * 59 + this.ContactCenter.GetHashCode();

                if (this.UnifiedCommunications != null)
                    hash = hash * 59 + this.UnifiedCommunications.GetHashCode();

                if (this.Custserv != null)
                    hash = hash * 59 + this.Custserv.GetHashCode();

                return hash;
            }
        }
    }

}
