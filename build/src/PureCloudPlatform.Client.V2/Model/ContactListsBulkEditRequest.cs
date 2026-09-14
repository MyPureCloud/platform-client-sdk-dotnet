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
    /// ContactListsBulkEditRequest
    /// </summary>
    [DataContract]
    public partial class ContactListsBulkEditRequest :  IEquatable<ContactListsBulkEditRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListsBulkEditRequest" /> class.
        /// </summary>
        /// <param name="ContactListIds">Contact List IDs to be bulk edited..</param>
        /// <param name="ContactList">Contact list object with details of fields used for patching. Accepted fields: retentionType, retentionDays, timeZone.</param>
        public ContactListsBulkEditRequest(List<string> ContactListIds = null, ContactList ContactList = null)
        {
            this.ContactListIds = ContactListIds;
            this.ContactList = ContactList;
            
        }
        


        /// <summary>
        /// Contact List IDs to be bulk edited.
        /// </summary>
        /// <value>Contact List IDs to be bulk edited.</value>
        [DataMember(Name="contactListIds", EmitDefaultValue=false)]
        public List<string> ContactListIds { get; set; }



        /// <summary>
        /// Contact list object with details of fields used for patching. Accepted fields: retentionType, retentionDays, timeZone
        /// </summary>
        /// <value>Contact list object with details of fields used for patching. Accepted fields: retentionType, retentionDays, timeZone</value>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public ContactList ContactList { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactListsBulkEditRequest {\n");

            sb.Append("  ContactListIds: ").Append(ContactListIds).Append("\n");
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
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
            return this.Equals(obj as ContactListsBulkEditRequest);
        }

        /// <summary>
        /// Returns true if ContactListsBulkEditRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactListsBulkEditRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListsBulkEditRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContactListIds == other.ContactListIds ||
                    this.ContactListIds != null &&
                    this.ContactListIds.SequenceEqual(other.ContactListIds)
                ) &&
                (
                    this.ContactList == other.ContactList ||
                    this.ContactList != null &&
                    this.ContactList.Equals(other.ContactList)
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
                if (this.ContactListIds != null)
                    hash = hash * 59 + this.ContactListIds.GetHashCode();

                if (this.ContactList != null)
                    hash = hash * 59 + this.ContactList.GetHashCode();

                return hash;
            }
        }
    }

}
