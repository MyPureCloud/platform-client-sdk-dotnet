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
    /// PresenceSettings
    /// </summary>
    [DataContract]
    public partial class PresenceSettings :  IEquatable<PresenceSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceSettings" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="RestorePresenceSettings">The settings for the restore presence feature.</param>
        /// <param name="RequestingOffQueueEnabled">Whether requesting off queue is enabled for the organization.</param>
        /// <param name="DefaultPrimaryPresenceRegisteredSourceId">The default primary presence registered source ID for the organization.</param>
        public PresenceSettings(string Name = null, RestorePresenceSettings RestorePresenceSettings = null, bool? RequestingOffQueueEnabled = null, string DefaultPrimaryPresenceRegisteredSourceId = null)
        {
            this.Name = Name;
            this.RestorePresenceSettings = RestorePresenceSettings;
            this.RequestingOffQueueEnabled = RequestingOffQueueEnabled;
            this.DefaultPrimaryPresenceRegisteredSourceId = DefaultPrimaryPresenceRegisteredSourceId;
            
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
        /// The settings for the restore presence feature
        /// </summary>
        /// <value>The settings for the restore presence feature</value>
        [DataMember(Name="restorePresenceSettings", EmitDefaultValue=false)]
        public RestorePresenceSettings RestorePresenceSettings { get; set; }



        /// <summary>
        /// Whether requesting off queue is enabled for the organization
        /// </summary>
        /// <value>Whether requesting off queue is enabled for the organization</value>
        [DataMember(Name="requestingOffQueueEnabled", EmitDefaultValue=false)]
        public bool? RequestingOffQueueEnabled { get; set; }



        /// <summary>
        /// The default primary presence registered source ID for the organization
        /// </summary>
        /// <value>The default primary presence registered source ID for the organization</value>
        [DataMember(Name="defaultPrimaryPresenceRegisteredSourceId", EmitDefaultValue=false)]
        public string DefaultPrimaryPresenceRegisteredSourceId { get; set; }



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
            sb.Append("class PresenceSettings {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RestorePresenceSettings: ").Append(RestorePresenceSettings).Append("\n");
            sb.Append("  RequestingOffQueueEnabled: ").Append(RequestingOffQueueEnabled).Append("\n");
            sb.Append("  DefaultPrimaryPresenceRegisteredSourceId: ").Append(DefaultPrimaryPresenceRegisteredSourceId).Append("\n");
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
            return this.Equals(obj as PresenceSettings);
        }

        /// <summary>
        /// Returns true if PresenceSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of PresenceSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PresenceSettings other)
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
                    this.RestorePresenceSettings == other.RestorePresenceSettings ||
                    this.RestorePresenceSettings != null &&
                    this.RestorePresenceSettings.Equals(other.RestorePresenceSettings)
                ) &&
                (
                    this.RequestingOffQueueEnabled == other.RequestingOffQueueEnabled ||
                    this.RequestingOffQueueEnabled != null &&
                    this.RequestingOffQueueEnabled.Equals(other.RequestingOffQueueEnabled)
                ) &&
                (
                    this.DefaultPrimaryPresenceRegisteredSourceId == other.DefaultPrimaryPresenceRegisteredSourceId ||
                    this.DefaultPrimaryPresenceRegisteredSourceId != null &&
                    this.DefaultPrimaryPresenceRegisteredSourceId.Equals(other.DefaultPrimaryPresenceRegisteredSourceId)
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

                if (this.RestorePresenceSettings != null)
                    hash = hash * 59 + this.RestorePresenceSettings.GetHashCode();

                if (this.RequestingOffQueueEnabled != null)
                    hash = hash * 59 + this.RequestingOffQueueEnabled.GetHashCode();

                if (this.DefaultPrimaryPresenceRegisteredSourceId != null)
                    hash = hash * 59 + this.DefaultPrimaryPresenceRegisteredSourceId.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
