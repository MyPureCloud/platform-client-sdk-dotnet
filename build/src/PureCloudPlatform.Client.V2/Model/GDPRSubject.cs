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
    /// GDPRSubject
    /// </summary>
    [DataContract]
    public partial class GDPRSubject :  IEquatable<GDPRSubject>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GDPRSubject" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="ExternalContactId">ExternalContactId.</param>
        /// <param name="DialerContactId">DialerContactId.</param>
        /// <param name="JourneyCustomer">JourneyCustomer.</param>
        /// <param name="SocialHandle">SocialHandle.</param>
        /// <param name="Addresses">Addresses.</param>
        /// <param name="PhoneNumbers">PhoneNumbers.</param>
        /// <param name="EmailAddresses">EmailAddresses.</param>
        public GDPRSubject(string Name = null, string UserId = null, string ExternalContactId = null, DialerContactId DialerContactId = null, GDPRJourneyCustomer JourneyCustomer = null, SocialHandle SocialHandle = null, List<string> Addresses = null, List<string> PhoneNumbers = null, List<string> EmailAddresses = null)
        {
            this.Name = Name;
            this.UserId = UserId;
            this.ExternalContactId = ExternalContactId;
            this.DialerContactId = DialerContactId;
            this.JourneyCustomer = JourneyCustomer;
            this.SocialHandle = SocialHandle;
            this.Addresses = Addresses;
            this.PhoneNumbers = PhoneNumbers;
            this.EmailAddresses = EmailAddresses;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExternalContactId
        /// </summary>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DialerContactId
        /// </summary>
        [DataMember(Name="dialerContactId", EmitDefaultValue=false)]
        public DialerContactId DialerContactId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets JourneyCustomer
        /// </summary>
        [DataMember(Name="journeyCustomer", EmitDefaultValue=false)]
        public GDPRJourneyCustomer JourneyCustomer { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SocialHandle
        /// </summary>
        [DataMember(Name="socialHandle", EmitDefaultValue=false)]
        public SocialHandle SocialHandle { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<string> Addresses { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        [DataMember(Name="phoneNumbers", EmitDefaultValue=false)]
        public List<string> PhoneNumbers { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EmailAddresses
        /// </summary>
        [DataMember(Name="emailAddresses", EmitDefaultValue=false)]
        public List<string> EmailAddresses { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GDPRSubject {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  DialerContactId: ").Append(DialerContactId).Append("\n");
            sb.Append("  JourneyCustomer: ").Append(JourneyCustomer).Append("\n");
            sb.Append("  SocialHandle: ").Append(SocialHandle).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
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
            return this.Equals(obj as GDPRSubject);
        }

        /// <summary>
        /// Returns true if GDPRSubject instances are equal
        /// </summary>
        /// <param name="other">Instance of GDPRSubject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GDPRSubject other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.DialerContactId == other.DialerContactId ||
                    this.DialerContactId != null &&
                    this.DialerContactId.Equals(other.DialerContactId)
                ) &&
                (
                    this.JourneyCustomer == other.JourneyCustomer ||
                    this.JourneyCustomer != null &&
                    this.JourneyCustomer.Equals(other.JourneyCustomer)
                ) &&
                (
                    this.SocialHandle == other.SocialHandle ||
                    this.SocialHandle != null &&
                    this.SocialHandle.Equals(other.SocialHandle)
                ) &&
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) &&
                (
                    this.PhoneNumbers == other.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(other.PhoneNumbers)
                ) &&
                (
                    this.EmailAddresses == other.EmailAddresses ||
                    this.EmailAddresses != null &&
                    this.EmailAddresses.SequenceEqual(other.EmailAddresses)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();
                
                if (this.DialerContactId != null)
                    hash = hash * 59 + this.DialerContactId.GetHashCode();
                
                if (this.JourneyCustomer != null)
                    hash = hash * 59 + this.JourneyCustomer.GetHashCode();
                
                if (this.SocialHandle != null)
                    hash = hash * 59 + this.SocialHandle.GetHashCode();
                
                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                
                if (this.PhoneNumbers != null)
                    hash = hash * 59 + this.PhoneNumbers.GetHashCode();
                
                if (this.EmailAddresses != null)
                    hash = hash * 59 + this.EmailAddresses.GetHashCode();
                
                return hash;
            }
        }
    }

}
