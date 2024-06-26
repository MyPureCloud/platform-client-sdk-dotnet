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
    /// RecordingAnnotationQueue
    /// </summary>
    [DataContract]
    public partial class RecordingAnnotationQueue :  IEquatable<RecordingAnnotationQueue>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingAnnotationQueue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecordingAnnotationQueue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingAnnotationQueue" /> class.
        /// </summary>
        /// <param name="Name">The queue name (required).</param>
        /// <param name="Id">The queue Id (required).</param>
        public RecordingAnnotationQueue(string Name = null, string Id = null)
        {
            this.Name = Name;
            this.Id = Id;
            
        }
        


        /// <summary>
        /// The queue name
        /// </summary>
        /// <value>The queue name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The queue Id
        /// </summary>
        /// <value>The queue Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingAnnotationQueue {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as RecordingAnnotationQueue);
        }

        /// <summary>
        /// Returns true if RecordingAnnotationQueue instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingAnnotationQueue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingAnnotationQueue other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                return hash;
            }
        }
    }

}
