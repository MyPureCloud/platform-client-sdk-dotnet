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
    /// WorkitemQueryPostRequest
    /// </summary>
    [DataContract]
    public partial class WorkitemQueryPostRequest :  IEquatable<WorkitemQueryPostRequest>
    {
        /// <summary>
        /// Specify the value 'Count' for this parameter in order to return only the record count.
        /// </summary>
        /// <value>Specify the value 'Count' for this parameter in order to return only the record count.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SelectEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Count for "Count"
            /// </summary>
            [EnumMember(Value = "Count")]
            Count
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
            /// Enum Type for "type"
            /// </summary>
            [EnumMember(Value = "type")]
            Type,
            
            /// <summary>
            /// Enum Workbin for "workbin"
            /// </summary>
            [EnumMember(Value = "workbin")]
            Workbin,
            
            /// <summary>
            /// Enum Status for "status"
            /// </summary>
            [EnumMember(Value = "status")]
            Status,
            
            /// <summary>
            /// Enum Assignee for "assignee"
            /// </summary>
            [EnumMember(Value = "assignee")]
            Assignee,
            
            /// <summary>
            /// Enum Reporter for "reporter"
            /// </summary>
            [EnumMember(Value = "reporter")]
            Reporter,
            
            /// <summary>
            /// Enum Queue for "queue"
            /// </summary>
            [EnumMember(Value = "queue")]
            Queue
        }
        /// <summary>
        /// Specify the value 'Count' for this parameter in order to return only the record count.
        /// </summary>
        /// <value>Specify the value 'Count' for this parameter in order to return only the record count.</value>
        [DataMember(Name="select", EmitDefaultValue=false)]
        public SelectEnum? Select { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemQueryPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkitemQueryPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemQueryPostRequest" /> class.
        /// </summary>
        /// <param name="PageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200..</param>
        /// <param name="Select">Specify the value &#39;Count&#39; for this parameter in order to return only the record count..</param>
        /// <param name="Filters">List of filter objects to be used in the search. Valid filter names are: &#39;id&#39;, &#39;name&#39;, &#39;description&#39;, &#39;languageId&#39;, &#39;priority&#39;, &#39;dateCreated&#39;, &#39;dateModified&#39;, &#39;dateDue&#39;, &#39;dateExpires&#39;, &#39;durationInSeconds&#39;, &#39;ttl&#39;, &#39;statusId&#39;, &#39;statusCategory&#39;, &#39;dateClosed&#39;, &#39;externalContactId&#39;, &#39;reporterId&#39;, &#39;queueId&#39;, &#39;externalTag&#39;, &#39;modifiedBy&#39;, &#39;assignmentState&#39;, &#39;divisionId&#39;, &#39;customFields.&lt;custom field name&gt;&#39; (required).</param>
        /// <param name="Attributes">List of entity attributes to be retrieved in the result..</param>
        /// <param name="After">The cursor that points to the end of the set of entities that has been returned..</param>
        /// <param name="Sort">Sort.</param>
        /// <param name="Expands">List of entity attributes to be expanded in the result..</param>
        public WorkitemQueryPostRequest(int? PageSize = null, SelectEnum? Select = null, List<WorkitemFilter> Filters = null, List<string> Attributes = null, string After = null, WorkitemQuerySort Sort = null, List<ExpandsEnum> Expands = null)
        {
            this.PageSize = PageSize;
            this.Select = Select;
            this.Filters = Filters;
            this.Attributes = Attributes;
            this.After = After;
            this.Sort = Sort;
            this.Expands = Expands;
            
        }
        


        /// <summary>
        /// Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200.
        /// </summary>
        /// <value>Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }





        /// <summary>
        /// List of filter objects to be used in the search. Valid filter names are: &#39;id&#39;, &#39;name&#39;, &#39;description&#39;, &#39;languageId&#39;, &#39;priority&#39;, &#39;dateCreated&#39;, &#39;dateModified&#39;, &#39;dateDue&#39;, &#39;dateExpires&#39;, &#39;durationInSeconds&#39;, &#39;ttl&#39;, &#39;statusId&#39;, &#39;statusCategory&#39;, &#39;dateClosed&#39;, &#39;externalContactId&#39;, &#39;reporterId&#39;, &#39;queueId&#39;, &#39;externalTag&#39;, &#39;modifiedBy&#39;, &#39;assignmentState&#39;, &#39;divisionId&#39;, &#39;customFields.&lt;custom field name&gt;&#39;
        /// </summary>
        /// <value>List of filter objects to be used in the search. Valid filter names are: &#39;id&#39;, &#39;name&#39;, &#39;description&#39;, &#39;languageId&#39;, &#39;priority&#39;, &#39;dateCreated&#39;, &#39;dateModified&#39;, &#39;dateDue&#39;, &#39;dateExpires&#39;, &#39;durationInSeconds&#39;, &#39;ttl&#39;, &#39;statusId&#39;, &#39;statusCategory&#39;, &#39;dateClosed&#39;, &#39;externalContactId&#39;, &#39;reporterId&#39;, &#39;queueId&#39;, &#39;externalTag&#39;, &#39;modifiedBy&#39;, &#39;assignmentState&#39;, &#39;divisionId&#39;, &#39;customFields.&lt;custom field name&gt;&#39;</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<WorkitemFilter> Filters { get; set; }



        /// <summary>
        /// List of entity attributes to be retrieved in the result.
        /// </summary>
        /// <value>List of entity attributes to be retrieved in the result.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<string> Attributes { get; set; }



        /// <summary>
        /// The cursor that points to the end of the set of entities that has been returned.
        /// </summary>
        /// <value>The cursor that points to the end of the set of entities that has been returned.</value>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }



        /// <summary>
        /// Sort
        /// </summary>
        /// <value>Sort</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public WorkitemQuerySort Sort { get; set; }



        /// <summary>
        /// List of entity attributes to be expanded in the result.
        /// </summary>
        /// <value>List of entity attributes to be expanded in the result.</value>
        [DataMember(Name="expands", EmitDefaultValue=false)]
        public List<ExpandsEnum> Expands { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemQueryPostRequest {\n");

            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Select: ").Append(Select).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  After: ").Append(After).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
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
            return this.Equals(obj as WorkitemQueryPostRequest);
        }

        /// <summary>
        /// Returns true if WorkitemQueryPostRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemQueryPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemQueryPostRequest other)
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
                    this.Select == other.Select ||
                    this.Select != null &&
                    this.Select.Equals(other.Select)
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
                    this.After == other.After ||
                    this.After != null &&
                    this.After.Equals(other.After)
                ) &&
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
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

                if (this.Select != null)
                    hash = hash * 59 + this.Select.GetHashCode();

                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.After != null)
                    hash = hash * 59 + this.After.GetHashCode();

                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();

                if (this.Expands != null)
                    hash = hash * 59 + this.Expands.GetHashCode();

                return hash;
            }
        }
    }

}
