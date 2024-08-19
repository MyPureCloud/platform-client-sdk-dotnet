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
    /// ContactBulkSearchParameters
    /// </summary>
    [DataContract]
    public partial class ContactBulkSearchParameters :  IEquatable<ContactBulkSearchParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactBulkSearchParameters" /> class.
        /// </summary>
        /// <param name="ContactListFilterId">Contact List Filter ID. Either this property or criteria is required..</param>
        /// <param name="Criteria">Criteria to filter the contacts by. Either this property or contactListFilterId is required..</param>
        public ContactBulkSearchParameters(string ContactListFilterId = null, ContactBulkSearchCriteria Criteria = null)
        {
            this.ContactListFilterId = ContactListFilterId;
            this.Criteria = Criteria;
            
        }
        


        /// <summary>
        /// Contact List Filter ID. Either this property or criteria is required.
        /// </summary>
        /// <value>Contact List Filter ID. Either this property or criteria is required.</value>
        [DataMember(Name="contactListFilterId", EmitDefaultValue=false)]
        public string ContactListFilterId { get; set; }



        /// <summary>
        /// Criteria to filter the contacts by. Either this property or contactListFilterId is required.
        /// </summary>
        /// <value>Criteria to filter the contacts by. Either this property or contactListFilterId is required.</value>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public ContactBulkSearchCriteria Criteria { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactBulkSearchParameters {\n");

            sb.Append("  ContactListFilterId: ").Append(ContactListFilterId).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
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
            return this.Equals(obj as ContactBulkSearchParameters);
        }

        /// <summary>
        /// Returns true if ContactBulkSearchParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactBulkSearchParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactBulkSearchParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContactListFilterId == other.ContactListFilterId ||
                    this.ContactListFilterId != null &&
                    this.ContactListFilterId.Equals(other.ContactListFilterId)
                ) &&
                (
                    this.Criteria == other.Criteria ||
                    this.Criteria != null &&
                    this.Criteria.Equals(other.Criteria)
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
                if (this.ContactListFilterId != null)
                    hash = hash * 59 + this.ContactListFilterId.GetHashCode();

                if (this.Criteria != null)
                    hash = hash * 59 + this.Criteria.GetHashCode();

                return hash;
            }
        }
    }

}
