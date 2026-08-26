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
    /// Graph
    /// </summary>
    [DataContract]
    public partial class Graph :  IEquatable<Graph>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Graph" /> class.
        /// </summary>
        public Graph()
        {
            
        }
        


        /// <summary>
        /// The list of graph vertices
        /// </summary>
        /// <value>The list of graph vertices</value>
        [DataMember(Name="vertices", EmitDefaultValue=false)]
        public GraphVertices Vertices { get; private set; }



        /// <summary>
        /// The list of graph edges
        /// </summary>
        /// <value>The list of graph edges</value>
        [DataMember(Name="edges", EmitDefaultValue=false)]
        public List<GraphEdge> Edges { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Graph {\n");

            sb.Append("  Vertices: ").Append(Vertices).Append("\n");
            sb.Append("  Edges: ").Append(Edges).Append("\n");
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
            return this.Equals(obj as Graph);
        }

        /// <summary>
        /// Returns true if Graph instances are equal
        /// </summary>
        /// <param name="other">Instance of Graph to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Graph other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Vertices == other.Vertices ||
                    this.Vertices != null &&
                    this.Vertices.Equals(other.Vertices)
                ) &&
                (
                    this.Edges == other.Edges ||
                    this.Edges != null &&
                    this.Edges.SequenceEqual(other.Edges)
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
                if (this.Vertices != null)
                    hash = hash * 59 + this.Vertices.GetHashCode();

                if (this.Edges != null)
                    hash = hash * 59 + this.Edges.GetHashCode();

                return hash;
            }
        }
    }

}
