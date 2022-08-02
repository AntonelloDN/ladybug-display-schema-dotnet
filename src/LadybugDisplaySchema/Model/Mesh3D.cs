/* 
 * Ladybug Graphic Schema
 *
 * Documentation for Ladybug graphic schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace LadybugDisplaySchema
{
    /// <summary>
    /// A mesh in 3D space.
    /// </summary>
    [Serializable]
    [DataContract(Name = "Mesh3D")]
    public partial class Mesh3D : OpenAPIGenBaseModel, IEquatable<Mesh3D>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh3D" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Mesh3D() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Mesh3D";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh3D" /> class.
        /// </summary>
        /// <param name="vertices">A list of points representing the vertices of the mesh. The list should include at least 3 points and each point should be a list of 3 (x, y, z) values. (required).</param>
        /// <param name="faces">A list of lists with each sub-list having either 3 or 4 integers. These integers correspond to indices within the list of vertices. (required).</param>
        /// <param name="colors">An optional list of colors that correspond to either the faces of the mesh or the vertices of the mesh..</param>
        public Mesh3D
        (
           List<List<double>> vertices, List<List<int>> faces, // Required parameters
           List<Color> colors= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "vertices" is required (not null)
            this.Vertices = vertices ?? throw new ArgumentNullException("vertices is a required property for Mesh3D and cannot be null");
            // to ensure "faces" is required (not null)
            this.Faces = faces ?? throw new ArgumentNullException("faces is a required property for Mesh3D and cannot be null");
            this.Colors = colors;

            // Set non-required readonly properties with defaultValue
            this.Type = "Mesh3D";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Mesh3D))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Mesh3D";

        /// <summary>
        /// A list of points representing the vertices of the mesh. The list should include at least 3 points and each point should be a list of 3 (x, y, z) values.
        /// </summary>
        /// <value>A list of points representing the vertices of the mesh. The list should include at least 3 points and each point should be a list of 3 (x, y, z) values.</value>
        [DataMember(Name = "vertices", IsRequired = true)]
        public List<List<double>> Vertices { get; set; } 
        /// <summary>
        /// A list of lists with each sub-list having either 3 or 4 integers. These integers correspond to indices within the list of vertices.
        /// </summary>
        /// <value>A list of lists with each sub-list having either 3 or 4 integers. These integers correspond to indices within the list of vertices.</value>
        [DataMember(Name = "faces", IsRequired = true)]
        public List<List<int>> Faces { get; set; } 
        /// <summary>
        /// An optional list of colors that correspond to either the faces of the mesh or the vertices of the mesh.
        /// </summary>
        /// <value>An optional list of colors that correspond to either the faces of the mesh or the vertices of the mesh.</value>
        [DataMember(Name = "colors")]
        public List<Color> Colors { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Mesh3D";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("Mesh3D:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Vertices: ").Append(Vertices).Append("\n");
            sb.Append("  Faces: ").Append(Faces).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Mesh3D object</returns>
        public static Mesh3D FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Mesh3D>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Mesh3D object</returns>
        public virtual Mesh3D DuplicateMesh3D()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateMesh3D();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateMesh3D();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Mesh3D);
        }

        /// <summary>
        /// Returns true if Mesh3D instances are equal
        /// </summary>
        /// <param name="input">Instance of Mesh3D to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mesh3D input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Vertices == input.Vertices ||
                    Extension.AllEquals(this.Vertices, input.Vertices)
                ) && 
                (
                    this.Faces == input.Faces ||
                    Extension.AllEquals(this.Faces, input.Faces)
                ) && 
                    Extension.Equals(this.Type, input.Type) && 
                (
                    this.Colors == input.Colors ||
                    Extension.AllEquals(this.Colors, input.Colors)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Vertices != null)
                    hashCode = hashCode * 59 + this.Vertices.GetHashCode();
                if (this.Faces != null)
                    hashCode = hashCode * 59 + this.Faces.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Colors != null)
                    hashCode = hashCode * 59 + this.Colors.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            

            

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^Mesh3D$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
