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
    /// TaskManagementObservationQueryResponse
    /// </summary>
    [DataContract]
    public partial class TaskManagementObservationQueryResponse :  IEquatable<TaskManagementObservationQueryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementObservationQueryResponse" /> class.
        /// </summary>
        /// <param name="Results">Query results grouped by the specified dimensions supplied in the groupBy parameter. Each result contains metrics for a specific group combination..</param>
        /// <param name="Details">Details about entities contained in results. Provides expanded information when requested through the expands parameter..</param>
        /// <param name="Cursors">Cursor tokens to be used for navigating paginated results.</param>
        /// <param name="NextUri">A URI to the next page in the listing..</param>
        public TaskManagementObservationQueryResponse(List<TaskManagementObservationResult> Results = null, TaskManagementObservationDetailContainer Details = null, Cursors Cursors = null, string NextUri = null)
        {
            this.Results = Results;
            this.Details = Details;
            this.Cursors = Cursors;
            this.NextUri = NextUri;
            
        }
        


        /// <summary>
        /// Query results grouped by the specified dimensions supplied in the groupBy parameter. Each result contains metrics for a specific group combination.
        /// </summary>
        /// <value>Query results grouped by the specified dimensions supplied in the groupBy parameter. Each result contains metrics for a specific group combination.</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<TaskManagementObservationResult> Results { get; set; }



        /// <summary>
        /// Details about entities contained in results. Provides expanded information when requested through the expands parameter.
        /// </summary>
        /// <value>Details about entities contained in results. Provides expanded information when requested through the expands parameter.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public TaskManagementObservationDetailContainer Details { get; set; }



        /// <summary>
        /// Cursor tokens to be used for navigating paginated results
        /// </summary>
        /// <value>Cursor tokens to be used for navigating paginated results</value>
        [DataMember(Name="cursors", EmitDefaultValue=false)]
        public Cursors Cursors { get; set; }



        /// <summary>
        /// A URI to the next page in the listing.
        /// </summary>
        /// <value>A URI to the next page in the listing.</value>
        [DataMember(Name="nextUri", EmitDefaultValue=false)]
        public string NextUri { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskManagementObservationQueryResponse {\n");

            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Cursors: ").Append(Cursors).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
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
            return this.Equals(obj as TaskManagementObservationQueryResponse);
        }

        /// <summary>
        /// Returns true if TaskManagementObservationQueryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskManagementObservationQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskManagementObservationQueryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) &&
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
                ) &&
                (
                    this.Cursors == other.Cursors ||
                    this.Cursors != null &&
                    this.Cursors.Equals(other.Cursors)
                ) &&
                (
                    this.NextUri == other.NextUri ||
                    this.NextUri != null &&
                    this.NextUri.Equals(other.NextUri)
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
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();

                if (this.Cursors != null)
                    hash = hash * 59 + this.Cursors.GetHashCode();

                if (this.NextUri != null)
                    hash = hash * 59 + this.NextUri.GetHashCode();

                return hash;
            }
        }
    }

}
