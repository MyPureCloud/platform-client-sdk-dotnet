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
    /// WorkbinQueryRequest
    /// </summary>
    [DataContract]
    public partial class WorkbinQueryRequest :  IEquatable<WorkbinQueryRequest>
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
        /// Specify the value 'Count' for this parameter in order to return only the record count.
        /// </summary>
        /// <value>Specify the value 'Count' for this parameter in order to return only the record count.</value>
        [DataMember(Name="select", EmitDefaultValue=false)]
        public SelectEnum? Select { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbinQueryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkbinQueryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbinQueryRequest" /> class.
        /// </summary>
        /// <param name="PageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an `after` key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200..</param>
        /// <param name="Select">Specify the value 'Count' for this parameter in order to return only the record count..</param>
        /// <param name="Filters">List of filter objects to be used in the search. (required).</param>
        /// <param name="Attributes">List of entity attributes to be retrieved in the result..</param>
        /// <param name="After">The cursor that points to the end of the set of entities that has been returned..</param>
        /// <param name="Sort">Sort.</param>
        public WorkbinQueryRequest(int? PageSize = null, SelectEnum? Select = null, List<WorkitemFilter> Filters = null, List<string> Attributes = null, string After = null, WorkbinQuerySort Sort = null)
        {
            this.PageSize = PageSize;
            this.Select = Select;
            this.Filters = Filters;
            this.Attributes = Attributes;
            this.After = After;
            this.Sort = Sort;
            
        }
        


        /// <summary>
        /// Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an `after` key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200.
        /// </summary>
        /// <value>Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an `after` key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }





        /// <summary>
        /// List of filter objects to be used in the search.
        /// </summary>
        /// <value>List of filter objects to be used in the search.</value>
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
        public WorkbinQuerySort Sort { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkbinQueryRequest {\n");

            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Select: ").Append(Select).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  After: ").Append(After).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
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
            return this.Equals(obj as WorkbinQueryRequest);
        }

        /// <summary>
        /// Returns true if WorkbinQueryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkbinQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkbinQueryRequest other)
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

                return hash;
            }
        }
    }

}
