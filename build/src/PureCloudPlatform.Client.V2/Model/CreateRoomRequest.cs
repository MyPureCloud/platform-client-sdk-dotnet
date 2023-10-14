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
    /// CreateRoomRequest
    /// </summary>
    [DataContract]
    public partial class CreateRoomRequest :  IEquatable<CreateRoomRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoomRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRoomRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoomRequest" /> class.
        /// </summary>
        /// <param name="Description">Room's description.</param>
        /// <param name="Subject">Room's subject (required).</param>
        /// <param name="UserIds">Users to add to the room.</param>
        public CreateRoomRequest(string Description = null, string Subject = null, List<string> UserIds = null)
        {
            this.Description = Description;
            this.Subject = Subject;
            this.UserIds = UserIds;
            
        }
        


        /// <summary>
        /// Room's description
        /// </summary>
        /// <value>Room's description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Room's subject
        /// </summary>
        /// <value>Room's subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }



        /// <summary>
        /// Users to add to the room
        /// </summary>
        /// <value>Users to add to the room</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<string> UserIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRoomRequest {\n");

            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
            return this.Equals(obj as CreateRoomRequest);
        }

        /// <summary>
        /// Returns true if CreateRoomRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateRoomRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRoomRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) &&
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();

                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();

                return hash;
            }
        }
    }

}
