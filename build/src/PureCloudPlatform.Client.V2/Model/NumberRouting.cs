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
    /// NumberRouting
    /// </summary>
    [DataContract]
    public partial class NumberRouting :  IEquatable<NumberRouting>
    {
        /// <summary>
        /// The current status of the number routing
        /// </summary>
        /// <value>The current status of the number routing</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Normal for "Normal"
            /// </summary>
            [EnumMember(Value = "Normal")]
            Normal,
            
            /// <summary>
            /// Enum Redirected for "Redirected"
            /// </summary>
            [EnumMember(Value = "Redirected")]
            Redirected,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending
        }
        /// <summary>
        /// The current status of the number routing
        /// </summary>
        /// <value>The current status of the number routing</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberRouting" /> class.
        /// </summary>
        /// <param name="NumberId">Phone number Id that has a disaster recovery linking.</param>
        /// <param name="OwnerOrganizationId">Owner organization of numberId.</param>
        /// <param name="CarrierCode">Code that indicates which carrier manages the number ie. VERIZON.</param>
        /// <param name="PendingOrganizationId">OrganizationId where the number will be routed to during a change routing event.</param>
        /// <param name="Region">The current region where the number is located.</param>
        /// <param name="Status">The current status of the number routing.</param>
        /// <param name="ActiveOrganizationId">The orgId where the number is currently routing to.</param>
        /// <param name="LinkedOrganizationIds">List of linked organizations ids.</param>
        public NumberRouting(string NumberId = null, string OwnerOrganizationId = null, string CarrierCode = null, string PendingOrganizationId = null, string Region = null, StatusEnum? Status = null, string ActiveOrganizationId = null, List<string> LinkedOrganizationIds = null)
        {
            this.NumberId = NumberId;
            this.OwnerOrganizationId = OwnerOrganizationId;
            this.CarrierCode = CarrierCode;
            this.PendingOrganizationId = PendingOrganizationId;
            this.Region = Region;
            this.Status = Status;
            this.ActiveOrganizationId = ActiveOrganizationId;
            this.LinkedOrganizationIds = LinkedOrganizationIds;
            
        }
        


        /// <summary>
        /// Phone number Id that has a disaster recovery linking
        /// </summary>
        /// <value>Phone number Id that has a disaster recovery linking</value>
        [DataMember(Name="numberId", EmitDefaultValue=false)]
        public string NumberId { get; set; }



        /// <summary>
        /// Owner organization of numberId
        /// </summary>
        /// <value>Owner organization of numberId</value>
        [DataMember(Name="ownerOrganizationId", EmitDefaultValue=false)]
        public string OwnerOrganizationId { get; set; }



        /// <summary>
        /// Code that indicates which carrier manages the number ie. VERIZON
        /// </summary>
        /// <value>Code that indicates which carrier manages the number ie. VERIZON</value>
        [DataMember(Name="carrierCode", EmitDefaultValue=false)]
        public string CarrierCode { get; set; }



        /// <summary>
        /// OrganizationId where the number will be routed to during a change routing event
        /// </summary>
        /// <value>OrganizationId where the number will be routed to during a change routing event</value>
        [DataMember(Name="pendingOrganizationId", EmitDefaultValue=false)]
        public string PendingOrganizationId { get; set; }



        /// <summary>
        /// The current region where the number is located
        /// </summary>
        /// <value>The current region where the number is located</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }





        /// <summary>
        /// The orgId where the number is currently routing to
        /// </summary>
        /// <value>The orgId where the number is currently routing to</value>
        [DataMember(Name="activeOrganizationId", EmitDefaultValue=false)]
        public string ActiveOrganizationId { get; set; }



        /// <summary>
        /// List of linked organizations ids
        /// </summary>
        /// <value>List of linked organizations ids</value>
        [DataMember(Name="linkedOrganizationIds", EmitDefaultValue=false)]
        public List<string> LinkedOrganizationIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumberRouting {\n");

            sb.Append("  NumberId: ").Append(NumberId).Append("\n");
            sb.Append("  OwnerOrganizationId: ").Append(OwnerOrganizationId).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  PendingOrganizationId: ").Append(PendingOrganizationId).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ActiveOrganizationId: ").Append(ActiveOrganizationId).Append("\n");
            sb.Append("  LinkedOrganizationIds: ").Append(LinkedOrganizationIds).Append("\n");
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
            return this.Equals(obj as NumberRouting);
        }

        /// <summary>
        /// Returns true if NumberRouting instances are equal
        /// </summary>
        /// <param name="other">Instance of NumberRouting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumberRouting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.NumberId == other.NumberId ||
                    this.NumberId != null &&
                    this.NumberId.Equals(other.NumberId)
                ) &&
                (
                    this.OwnerOrganizationId == other.OwnerOrganizationId ||
                    this.OwnerOrganizationId != null &&
                    this.OwnerOrganizationId.Equals(other.OwnerOrganizationId)
                ) &&
                (
                    this.CarrierCode == other.CarrierCode ||
                    this.CarrierCode != null &&
                    this.CarrierCode.Equals(other.CarrierCode)
                ) &&
                (
                    this.PendingOrganizationId == other.PendingOrganizationId ||
                    this.PendingOrganizationId != null &&
                    this.PendingOrganizationId.Equals(other.PendingOrganizationId)
                ) &&
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ActiveOrganizationId == other.ActiveOrganizationId ||
                    this.ActiveOrganizationId != null &&
                    this.ActiveOrganizationId.Equals(other.ActiveOrganizationId)
                ) &&
                (
                    this.LinkedOrganizationIds == other.LinkedOrganizationIds ||
                    this.LinkedOrganizationIds != null &&
                    this.LinkedOrganizationIds.SequenceEqual(other.LinkedOrganizationIds)
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
                if (this.NumberId != null)
                    hash = hash * 59 + this.NumberId.GetHashCode();

                if (this.OwnerOrganizationId != null)
                    hash = hash * 59 + this.OwnerOrganizationId.GetHashCode();

                if (this.CarrierCode != null)
                    hash = hash * 59 + this.CarrierCode.GetHashCode();

                if (this.PendingOrganizationId != null)
                    hash = hash * 59 + this.PendingOrganizationId.GetHashCode();

                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ActiveOrganizationId != null)
                    hash = hash * 59 + this.ActiveOrganizationId.GetHashCode();

                if (this.LinkedOrganizationIds != null)
                    hash = hash * 59 + this.LinkedOrganizationIds.GetHashCode();

                return hash;
            }
        }
    }

}
