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
    /// CaseplanQueryRequest
    /// </summary>
    [DataContract]
    public partial class CaseplanQueryRequest :  IEquatable<CaseplanQueryRequest>
    {
        /// <summary>
        /// Type of name search to perform. Default is BEGINS_WITH.
        /// </summary>
        /// <value>Type of name search to perform. Default is BEGINS_WITH.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NameSearchTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum BeginsWith for "BEGINS_WITH"
            /// </summary>
            [EnumMember(Value = "BEGINS_WITH")]
            BeginsWith,
            
            /// <summary>
            /// Enum Contains for "CONTAINS"
            /// </summary>
            [EnumMember(Value = "CONTAINS")]
            Contains
        }
        /// <summary>
        /// Type of name search to perform. Default is BEGINS_WITH.
        /// </summary>
        /// <value>Type of name search to perform. Default is BEGINS_WITH.</value>
        [DataMember(Name="nameSearchType", EmitDefaultValue=false)]
        public NameSearchTypeEnum? NameSearchType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseplanQueryRequest" /> class.
        /// </summary>
        /// <param name="Name">Filter by Caseplan name (case-insensitive, partial match). Omitting name returns all Caseplans (subject to pagination)..</param>
        /// <param name="NameSearchType">Type of name search to perform. Default is BEGINS_WITH..</param>
        /// <param name="DivisionIds">Divisions to filter by. Accepts a list of UUIDs and/or &#39;*&#39;..</param>
        /// <param name="Filters">List of filter objects to be used in the search. Valid filter names are: &#39;id&#39;, &#39;name&#39;, &#39;divisionId&#39;. Multiple filters are combined with AND logic..</param>
        /// <param name="Attributes">List of entity attributes to be retrieved in the result..</param>
        /// <param name="PageSize">Number of results per page. Maximum is 200. Default is 25..</param>
        /// <param name="After">Cursor for pagination. Use the \&quot;after\&quot; value from the previous response..</param>
        public CaseplanQueryRequest(string Name = null, NameSearchTypeEnum? NameSearchType = null, List<string> DivisionIds = null, List<CaseplanFilter> Filters = null, List<string> Attributes = null, int? PageSize = null, string After = null)
        {
            this.Name = Name;
            this.NameSearchType = NameSearchType;
            this.DivisionIds = DivisionIds;
            this.Filters = Filters;
            this.Attributes = Attributes;
            this.PageSize = PageSize;
            this.After = After;
            
        }
        


        /// <summary>
        /// Filter by Caseplan name (case-insensitive, partial match). Omitting name returns all Caseplans (subject to pagination).
        /// </summary>
        /// <value>Filter by Caseplan name (case-insensitive, partial match). Omitting name returns all Caseplans (subject to pagination).</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// Divisions to filter by. Accepts a list of UUIDs and/or &#39;*&#39;.
        /// </summary>
        /// <value>Divisions to filter by. Accepts a list of UUIDs and/or &#39;*&#39;.</value>
        [DataMember(Name="divisionIds", EmitDefaultValue=false)]
        public List<string> DivisionIds { get; set; }



        /// <summary>
        /// List of filter objects to be used in the search. Valid filter names are: &#39;id&#39;, &#39;name&#39;, &#39;divisionId&#39;. Multiple filters are combined with AND logic.
        /// </summary>
        /// <value>List of filter objects to be used in the search. Valid filter names are: &#39;id&#39;, &#39;name&#39;, &#39;divisionId&#39;. Multiple filters are combined with AND logic.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<CaseplanFilter> Filters { get; set; }



        /// <summary>
        /// List of entity attributes to be retrieved in the result.
        /// </summary>
        /// <value>List of entity attributes to be retrieved in the result.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<string> Attributes { get; set; }



        /// <summary>
        /// Number of results per page. Maximum is 200. Default is 25.
        /// </summary>
        /// <value>Number of results per page. Maximum is 200. Default is 25.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Cursor for pagination. Use the \&quot;after\&quot; value from the previous response.
        /// </summary>
        /// <value>Cursor for pagination. Use the \&quot;after\&quot; value from the previous response.</value>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseplanQueryRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameSearchType: ").Append(NameSearchType).Append("\n");
            sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  After: ").Append(After).Append("\n");
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
            return this.Equals(obj as CaseplanQueryRequest);
        }

        /// <summary>
        /// Returns true if CaseplanQueryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseplanQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseplanQueryRequest other)
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
                    this.NameSearchType == other.NameSearchType ||
                    this.NameSearchType != null &&
                    this.NameSearchType.Equals(other.NameSearchType)
                ) &&
                (
                    this.DivisionIds == other.DivisionIds ||
                    this.DivisionIds != null &&
                    this.DivisionIds.SequenceEqual(other.DivisionIds)
                ) &&
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.After == other.After ||
                    this.After != null &&
                    this.After.Equals(other.After)
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

                if (this.NameSearchType != null)
                    hash = hash * 59 + this.NameSearchType.GetHashCode();

                if (this.DivisionIds != null)
                    hash = hash * 59 + this.DivisionIds.GetHashCode();

                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                if (this.After != null)
                    hash = hash * 59 + this.After.GetHashCode();

                return hash;
            }
        }
    }

}
