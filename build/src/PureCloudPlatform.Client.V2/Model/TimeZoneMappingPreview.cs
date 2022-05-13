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
    /// TimeZoneMappingPreview
    /// </summary>
    [DataContract]
    public partial class TimeZoneMappingPreview :  IEquatable<TimeZoneMappingPreview>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeZoneMappingPreview" /> class.
        /// </summary>
        /// <param name="ContactList">The associated ContactList.</param>
        /// <param name="ContactsPerTimeZone">The number of contacts per time zone that mapped to only that time zone.</param>
        /// <param name="ContactsMappedUsingZipCode">The number of contacts per time zone that mapped to only that time zone and were mapped using the zip code column.</param>
        /// <param name="ContactsMappedToASingleZone">The total number of contacts that mapped to a single time zone.</param>
        /// <param name="ContactsMappedToASingleZoneUsingZipCode">The total number of contacts that mapped to a single time zone and were mapped using the zip code column.</param>
        /// <param name="ContactsMappedToMultipleZones">The total number of contacts that mapped to multiple time zones.</param>
        /// <param name="ContactsMappedToMultipleZonesUsingZipCode">The total number of contacts that mapped to multiple time zones and were mapped using the zip code column.</param>
        /// <param name="ContactsInDefaultWindow">The total number of contacts that will be dialed during the default window.</param>
        /// <param name="ContactListSize">The total number of contacts in the contact list.</param>
        public TimeZoneMappingPreview(DomainEntityRef ContactList = null, Dictionary<string, long?> ContactsPerTimeZone = null, Dictionary<string, long?> ContactsMappedUsingZipCode = null, long? ContactsMappedToASingleZone = null, long? ContactsMappedToASingleZoneUsingZipCode = null, long? ContactsMappedToMultipleZones = null, long? ContactsMappedToMultipleZonesUsingZipCode = null, long? ContactsInDefaultWindow = null, long? ContactListSize = null)
        {
            this.ContactList = ContactList;
            this.ContactsPerTimeZone = ContactsPerTimeZone;
            this.ContactsMappedUsingZipCode = ContactsMappedUsingZipCode;
            this.ContactsMappedToASingleZone = ContactsMappedToASingleZone;
            this.ContactsMappedToASingleZoneUsingZipCode = ContactsMappedToASingleZoneUsingZipCode;
            this.ContactsMappedToMultipleZones = ContactsMappedToMultipleZones;
            this.ContactsMappedToMultipleZonesUsingZipCode = ContactsMappedToMultipleZonesUsingZipCode;
            this.ContactsInDefaultWindow = ContactsInDefaultWindow;
            this.ContactListSize = ContactListSize;
            
        }
        


        /// <summary>
        /// The associated ContactList
        /// </summary>
        /// <value>The associated ContactList</value>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public DomainEntityRef ContactList { get; set; }



        /// <summary>
        /// The number of contacts per time zone that mapped to only that time zone
        /// </summary>
        /// <value>The number of contacts per time zone that mapped to only that time zone</value>
        [DataMember(Name="contactsPerTimeZone", EmitDefaultValue=false)]
        public Dictionary<string, long?> ContactsPerTimeZone { get; set; }



        /// <summary>
        /// The number of contacts per time zone that mapped to only that time zone and were mapped using the zip code column
        /// </summary>
        /// <value>The number of contacts per time zone that mapped to only that time zone and were mapped using the zip code column</value>
        [DataMember(Name="contactsMappedUsingZipCode", EmitDefaultValue=false)]
        public Dictionary<string, long?> ContactsMappedUsingZipCode { get; set; }



        /// <summary>
        /// The total number of contacts that mapped to a single time zone
        /// </summary>
        /// <value>The total number of contacts that mapped to a single time zone</value>
        [DataMember(Name="contactsMappedToASingleZone", EmitDefaultValue=false)]
        public long? ContactsMappedToASingleZone { get; set; }



        /// <summary>
        /// The total number of contacts that mapped to a single time zone and were mapped using the zip code column
        /// </summary>
        /// <value>The total number of contacts that mapped to a single time zone and were mapped using the zip code column</value>
        [DataMember(Name="contactsMappedToASingleZoneUsingZipCode", EmitDefaultValue=false)]
        public long? ContactsMappedToASingleZoneUsingZipCode { get; set; }



        /// <summary>
        /// The total number of contacts that mapped to multiple time zones
        /// </summary>
        /// <value>The total number of contacts that mapped to multiple time zones</value>
        [DataMember(Name="contactsMappedToMultipleZones", EmitDefaultValue=false)]
        public long? ContactsMappedToMultipleZones { get; set; }



        /// <summary>
        /// The total number of contacts that mapped to multiple time zones and were mapped using the zip code column
        /// </summary>
        /// <value>The total number of contacts that mapped to multiple time zones and were mapped using the zip code column</value>
        [DataMember(Name="contactsMappedToMultipleZonesUsingZipCode", EmitDefaultValue=false)]
        public long? ContactsMappedToMultipleZonesUsingZipCode { get; set; }



        /// <summary>
        /// The total number of contacts that will be dialed during the default window
        /// </summary>
        /// <value>The total number of contacts that will be dialed during the default window</value>
        [DataMember(Name="contactsInDefaultWindow", EmitDefaultValue=false)]
        public long? ContactsInDefaultWindow { get; set; }



        /// <summary>
        /// The total number of contacts in the contact list
        /// </summary>
        /// <value>The total number of contacts in the contact list</value>
        [DataMember(Name="contactListSize", EmitDefaultValue=false)]
        public long? ContactListSize { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeZoneMappingPreview {\n");

            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            sb.Append("  ContactsPerTimeZone: ").Append(ContactsPerTimeZone).Append("\n");
            sb.Append("  ContactsMappedUsingZipCode: ").Append(ContactsMappedUsingZipCode).Append("\n");
            sb.Append("  ContactsMappedToASingleZone: ").Append(ContactsMappedToASingleZone).Append("\n");
            sb.Append("  ContactsMappedToASingleZoneUsingZipCode: ").Append(ContactsMappedToASingleZoneUsingZipCode).Append("\n");
            sb.Append("  ContactsMappedToMultipleZones: ").Append(ContactsMappedToMultipleZones).Append("\n");
            sb.Append("  ContactsMappedToMultipleZonesUsingZipCode: ").Append(ContactsMappedToMultipleZonesUsingZipCode).Append("\n");
            sb.Append("  ContactsInDefaultWindow: ").Append(ContactsInDefaultWindow).Append("\n");
            sb.Append("  ContactListSize: ").Append(ContactListSize).Append("\n");
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
            return this.Equals(obj as TimeZoneMappingPreview);
        }

        /// <summary>
        /// Returns true if TimeZoneMappingPreview instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeZoneMappingPreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeZoneMappingPreview other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContactList == other.ContactList ||
                    this.ContactList != null &&
                    this.ContactList.Equals(other.ContactList)
                ) &&
                (
                    this.ContactsPerTimeZone == other.ContactsPerTimeZone ||
                    this.ContactsPerTimeZone != null &&
                    this.ContactsPerTimeZone.SequenceEqual(other.ContactsPerTimeZone)
                ) &&
                (
                    this.ContactsMappedUsingZipCode == other.ContactsMappedUsingZipCode ||
                    this.ContactsMappedUsingZipCode != null &&
                    this.ContactsMappedUsingZipCode.SequenceEqual(other.ContactsMappedUsingZipCode)
                ) &&
                (
                    this.ContactsMappedToASingleZone == other.ContactsMappedToASingleZone ||
                    this.ContactsMappedToASingleZone != null &&
                    this.ContactsMappedToASingleZone.Equals(other.ContactsMappedToASingleZone)
                ) &&
                (
                    this.ContactsMappedToASingleZoneUsingZipCode == other.ContactsMappedToASingleZoneUsingZipCode ||
                    this.ContactsMappedToASingleZoneUsingZipCode != null &&
                    this.ContactsMappedToASingleZoneUsingZipCode.Equals(other.ContactsMappedToASingleZoneUsingZipCode)
                ) &&
                (
                    this.ContactsMappedToMultipleZones == other.ContactsMappedToMultipleZones ||
                    this.ContactsMappedToMultipleZones != null &&
                    this.ContactsMappedToMultipleZones.Equals(other.ContactsMappedToMultipleZones)
                ) &&
                (
                    this.ContactsMappedToMultipleZonesUsingZipCode == other.ContactsMappedToMultipleZonesUsingZipCode ||
                    this.ContactsMappedToMultipleZonesUsingZipCode != null &&
                    this.ContactsMappedToMultipleZonesUsingZipCode.Equals(other.ContactsMappedToMultipleZonesUsingZipCode)
                ) &&
                (
                    this.ContactsInDefaultWindow == other.ContactsInDefaultWindow ||
                    this.ContactsInDefaultWindow != null &&
                    this.ContactsInDefaultWindow.Equals(other.ContactsInDefaultWindow)
                ) &&
                (
                    this.ContactListSize == other.ContactListSize ||
                    this.ContactListSize != null &&
                    this.ContactListSize.Equals(other.ContactListSize)
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
                if (this.ContactList != null)
                    hash = hash * 59 + this.ContactList.GetHashCode();

                if (this.ContactsPerTimeZone != null)
                    hash = hash * 59 + this.ContactsPerTimeZone.GetHashCode();

                if (this.ContactsMappedUsingZipCode != null)
                    hash = hash * 59 + this.ContactsMappedUsingZipCode.GetHashCode();

                if (this.ContactsMappedToASingleZone != null)
                    hash = hash * 59 + this.ContactsMappedToASingleZone.GetHashCode();

                if (this.ContactsMappedToASingleZoneUsingZipCode != null)
                    hash = hash * 59 + this.ContactsMappedToASingleZoneUsingZipCode.GetHashCode();

                if (this.ContactsMappedToMultipleZones != null)
                    hash = hash * 59 + this.ContactsMappedToMultipleZones.GetHashCode();

                if (this.ContactsMappedToMultipleZonesUsingZipCode != null)
                    hash = hash * 59 + this.ContactsMappedToMultipleZonesUsingZipCode.GetHashCode();

                if (this.ContactsInDefaultWindow != null)
                    hash = hash * 59 + this.ContactsInDefaultWindow.GetHashCode();

                if (this.ContactListSize != null)
                    hash = hash * 59 + this.ContactListSize.GetHashCode();

                return hash;
            }
        }
    }

}
