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
    /// ChatUserRef
    /// </summary>
    [DataContract]
    public partial class ChatUserRef :  IEquatable<ChatUserRef>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUserRef" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="Jid">Jid.</param>
        /// <param name="Inactive">Inactive.</param>
        /// <param name="Integrations">Integrations.</param>
        /// <param name="Presence">Presence.</param>
        public ChatUserRef(string Id = null, string Name = null, string SelfUri = null, string Jid = null, bool? Inactive = null, List<Contact> Integrations = null, ChatPresence Presence = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.SelfUri = SelfUri;
            this.Jid = Jid;
            this.Inactive = Inactive;
            this.Integrations = Integrations;
            this.Presence = Presence;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }



        /// <summary>
        /// Gets or Sets Jid
        /// </summary>
        [DataMember(Name="jid", EmitDefaultValue=false)]
        public string Jid { get; set; }



        /// <summary>
        /// Gets or Sets Inactive
        /// </summary>
        [DataMember(Name="inactive", EmitDefaultValue=false)]
        public bool? Inactive { get; set; }



        /// <summary>
        /// Gets or Sets Integrations
        /// </summary>
        [DataMember(Name="integrations", EmitDefaultValue=false)]
        public List<Contact> Integrations { get; set; }



        /// <summary>
        /// Gets or Sets Presence
        /// </summary>
        [DataMember(Name="presence", EmitDefaultValue=false)]
        public ChatPresence Presence { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatUserRef {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Jid: ").Append(Jid).Append("\n");
            sb.Append("  Inactive: ").Append(Inactive).Append("\n");
            sb.Append("  Integrations: ").Append(Integrations).Append("\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
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
            return this.Equals(obj as ChatUserRef);
        }

        /// <summary>
        /// Returns true if ChatUserRef instances are equal
        /// </summary>
        /// <param name="other">Instance of ChatUserRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatUserRef other)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.Jid == other.Jid ||
                    this.Jid != null &&
                    this.Jid.Equals(other.Jid)
                ) &&
                (
                    this.Inactive == other.Inactive ||
                    this.Inactive != null &&
                    this.Inactive.Equals(other.Inactive)
                ) &&
                (
                    this.Integrations == other.Integrations ||
                    this.Integrations != null &&
                    this.Integrations.SequenceEqual(other.Integrations)
                ) &&
                (
                    this.Presence == other.Presence ||
                    this.Presence != null &&
                    this.Presence.Equals(other.Presence)
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

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.Jid != null)
                    hash = hash * 59 + this.Jid.GetHashCode();

                if (this.Inactive != null)
                    hash = hash * 59 + this.Inactive.GetHashCode();

                if (this.Integrations != null)
                    hash = hash * 59 + this.Integrations.GetHashCode();

                if (this.Presence != null)
                    hash = hash * 59 + this.Presence.GetHashCode();

                return hash;
            }
        }
    }

}
