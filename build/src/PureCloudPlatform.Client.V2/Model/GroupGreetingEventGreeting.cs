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
    /// GroupGreetingEventGreeting
    /// </summary>
    [DataContract]
    public partial class GroupGreetingEventGreeting :  IEquatable<GroupGreetingEventGreeting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupGreetingEventGreeting" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        /// <param name="OwnerType">OwnerType.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="GreetingAudioFile">GreetingAudioFile.</param>
        /// <param name="AudioTTS">AudioTTS.</param>
        public GroupGreetingEventGreeting(string Id = null, string Name = null, string Type = null, string OwnerType = null, GroupGreetingEventGreetingOwner Owner = null, GroupGreetingEventGreetingAudioFile GreetingAudioFile = null, string AudioTTS = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Type = Type;
            this.OwnerType = OwnerType;
            this.Owner = Owner;
            this.GreetingAudioFile = GreetingAudioFile;
            this.AudioTTS = AudioTTS;
            
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
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// Gets or Sets OwnerType
        /// </summary>
        [DataMember(Name="ownerType", EmitDefaultValue=false)]
        public string OwnerType { get; set; }



        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public GroupGreetingEventGreetingOwner Owner { get; set; }



        /// <summary>
        /// Gets or Sets GreetingAudioFile
        /// </summary>
        [DataMember(Name="greetingAudioFile", EmitDefaultValue=false)]
        public GroupGreetingEventGreetingAudioFile GreetingAudioFile { get; set; }



        /// <summary>
        /// Gets or Sets AudioTTS
        /// </summary>
        [DataMember(Name="audioTTS", EmitDefaultValue=false)]
        public string AudioTTS { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupGreetingEventGreeting {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  GreetingAudioFile: ").Append(GreetingAudioFile).Append("\n");
            sb.Append("  AudioTTS: ").Append(AudioTTS).Append("\n");
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
            return this.Equals(obj as GroupGreetingEventGreeting);
        }

        /// <summary>
        /// Returns true if GroupGreetingEventGreeting instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupGreetingEventGreeting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupGreetingEventGreeting other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.OwnerType == other.OwnerType ||
                    this.OwnerType != null &&
                    this.OwnerType.Equals(other.OwnerType)
                ) &&
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) &&
                (
                    this.GreetingAudioFile == other.GreetingAudioFile ||
                    this.GreetingAudioFile != null &&
                    this.GreetingAudioFile.Equals(other.GreetingAudioFile)
                ) &&
                (
                    this.AudioTTS == other.AudioTTS ||
                    this.AudioTTS != null &&
                    this.AudioTTS.Equals(other.AudioTTS)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.OwnerType != null)
                    hash = hash * 59 + this.OwnerType.GetHashCode();

                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();

                if (this.GreetingAudioFile != null)
                    hash = hash * 59 + this.GreetingAudioFile.GetHashCode();

                if (this.AudioTTS != null)
                    hash = hash * 59 + this.AudioTTS.GetHashCode();

                return hash;
            }
        }
    }

}
