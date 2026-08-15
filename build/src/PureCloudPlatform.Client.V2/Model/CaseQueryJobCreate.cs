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
    /// CaseQueryJobCreate
    /// </summary>
    [DataContract]
    public partial class CaseQueryJobCreate :  IEquatable<CaseQueryJobCreate>
    {
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AttributesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Id for "id"
            /// </summary>
            [EnumMember(Value = "id")]
            Id,
            
            /// <summary>
            /// Enum Reference for "reference"
            /// </summary>
            [EnumMember(Value = "reference")]
            Reference,
            
            /// <summary>
            /// Enum Caseplanid for "caseplanId"
            /// </summary>
            [EnumMember(Value = "caseplanId")]
            Caseplanid,
            
            /// <summary>
            /// Enum Caseplanversion for "caseplanVersion"
            /// </summary>
            [EnumMember(Value = "caseplanVersion")]
            Caseplanversion,
            
            /// <summary>
            /// Enum Owner for "owner"
            /// </summary>
            [EnumMember(Value = "owner")]
            Owner,
            
            /// <summary>
            /// Enum Status for "status"
            /// </summary>
            [EnumMember(Value = "status")]
            Status,
            
            /// <summary>
            /// Enum Priority for "priority"
            /// </summary>
            [EnumMember(Value = "priority")]
            Priority,
            
            /// <summary>
            /// Enum Externalcontactid for "externalContactId"
            /// </summary>
            [EnumMember(Value = "externalContactId")]
            Externalcontactid,
            
            /// <summary>
            /// Enum Customerintent for "customerIntent"
            /// </summary>
            [EnumMember(Value = "customerIntent")]
            Customerintent,
            
            /// <summary>
            /// Enum Division for "division"
            /// </summary>
            [EnumMember(Value = "division")]
            Division,
            
            /// <summary>
            /// Enum Datedue for "dateDue"
            /// </summary>
            [EnumMember(Value = "dateDue")]
            Datedue,
            
            /// <summary>
            /// Enum Datestarted for "dateStarted"
            /// </summary>
            [EnumMember(Value = "dateStarted")]
            Datestarted,
            
            /// <summary>
            /// Enum Dateclosed for "dateClosed"
            /// </summary>
            [EnumMember(Value = "dateClosed")]
            Dateclosed,
            
            /// <summary>
            /// Enum Datecreated for "dateCreated"
            /// </summary>
            [EnumMember(Value = "dateCreated")]
            Datecreated,
            
            /// <summary>
            /// Enum Datemodified for "dateModified"
            /// </summary>
            [EnumMember(Value = "dateModified")]
            Datemodified,
            
            /// <summary>
            /// Enum Modifiedby for "modifiedBy"
            /// </summary>
            [EnumMember(Value = "modifiedBy")]
            Modifiedby,
            
            /// <summary>
            /// Enum Summary for "summary"
            /// </summary>
            [EnumMember(Value = "summary")]
            Summary,
            
            /// <summary>
            /// Enum Version for "version"
            /// </summary>
            [EnumMember(Value = "version")]
            Version,
            
            /// <summary>
            /// Enum Ttlseconds for "ttlSeconds"
            /// </summary>
            [EnumMember(Value = "ttlSeconds")]
            Ttlseconds,
            
            /// <summary>
            /// Enum Creationstatus for "creationStatus"
            /// </summary>
            [EnumMember(Value = "creationStatus")]
            Creationstatus
        }
        /// <summary>
        /// Gets or Sets Expands
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExpandsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Caseplan for "caseplan"
            /// </summary>
            [EnumMember(Value = "caseplan")]
            Caseplan,
            
            /// <summary>
            /// Enum Owner for "owner"
            /// </summary>
            [EnumMember(Value = "owner")]
            Owner,
            
            /// <summary>
            /// Enum Modifiedby for "modifiedBy"
            /// </summary>
            [EnumMember(Value = "modifiedBy")]
            Modifiedby,
            
            /// <summary>
            /// Enum Externalcontact for "externalContact"
            /// </summary>
            [EnumMember(Value = "externalContact")]
            Externalcontact,
            
            /// <summary>
            /// Enum Customerintent for "customerIntent"
            /// </summary>
            [EnumMember(Value = "customerIntent")]
            Customerintent
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseQueryJobCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseQueryJobCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseQueryJobCreate" /> class.
        /// </summary>
        /// <param name="PageSize">The total page size requested (default 25)..</param>
        /// <param name="PageNumber">The requested page number..</param>
        /// <param name="Filters">List of filter objects to be used in the search. Use an empty list to run the query with no filters. (required).</param>
        /// <param name="Sort">Sort order for results..</param>
        /// <param name="Attributes">List of entity attributes to be retrieved in the result..</param>
        /// <param name="Expands">Attributes to expand on each case in the job results. Expands are stored on the job and enriched by PubAPI when results are fetched..</param>
        public CaseQueryJobCreate(int? PageSize = null, int? PageNumber = null, List<CaseQueryJobFilter> Filters = null, CaseQueryJobSort Sort = null, List<AttributesEnum> Attributes = null, List<ExpandsEnum> Expands = null)
        {
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.Filters = Filters;
            this.Sort = Sort;
            this.Attributes = Attributes;
            this.Expands = Expands;
            
        }
        


        /// <summary>
        /// The total page size requested (default 25).
        /// </summary>
        /// <value>The total page size requested (default 25).</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// The requested page number.
        /// </summary>
        /// <value>The requested page number.</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }



        /// <summary>
        /// List of filter objects to be used in the search. Use an empty list to run the query with no filters.
        /// </summary>
        /// <value>List of filter objects to be used in the search. Use an empty list to run the query with no filters.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<CaseQueryJobFilter> Filters { get; set; }



        /// <summary>
        /// Sort order for results.
        /// </summary>
        /// <value>Sort order for results.</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public CaseQueryJobSort Sort { get; set; }



        /// <summary>
        /// List of entity attributes to be retrieved in the result.
        /// </summary>
        /// <value>List of entity attributes to be retrieved in the result.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<AttributesEnum> Attributes { get; set; }



        /// <summary>
        /// Attributes to expand on each case in the job results. Expands are stored on the job and enriched by PubAPI when results are fetched.
        /// </summary>
        /// <value>Attributes to expand on each case in the job results. Expands are stored on the job and enriched by PubAPI when results are fetched.</value>
        [DataMember(Name="expands", EmitDefaultValue=false)]
        public List<ExpandsEnum> Expands { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseQueryJobCreate {\n");

            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Expands: ").Append(Expands).Append("\n");
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
            return this.Equals(obj as CaseQueryJobCreate);
        }

        /// <summary>
        /// Returns true if CaseQueryJobCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseQueryJobCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseQueryJobCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) &&
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
                ) &&
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.Expands == other.Expands ||
                    this.Expands != null &&
                    this.Expands.SequenceEqual(other.Expands)
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
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();

                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();

                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.Expands != null)
                    hash = hash * 59 + this.Expands.GetHashCode();

                return hash;
            }
        }
    }

}
