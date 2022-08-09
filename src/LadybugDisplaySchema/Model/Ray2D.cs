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
    /// A ray object in 2D space.
    /// </summary>
    [Serializable]
    [DataContract(Name = "Ray2D")]
    public partial class Ray2D : OpenAPIGenBaseModel, IEquatable<Ray2D>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ray2D" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Ray2D() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Ray2D";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Ray2D" /> class.
        /// </summary>
        /// <param name="p">Ray base point as 2 (x, y) values. (required).</param>
        /// <param name="v">Ray direction vector as 2 (x, y) values. (required).</param>
        public Ray2D
        (
           List<double> p, List<double> v// Required parameters
            // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "p" is required (not null)
            this.P = p ?? throw new ArgumentNullException("p is a required property for Ray2D and cannot be null");
            // to ensure "v" is required (not null)
            this.V = v ?? throw new ArgumentNullException("v is a required property for Ray2D and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "Ray2D";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Ray2D))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Ray2D";

        /// <summary>
        /// Ray base point as 2 (x, y) values.
        /// </summary>
        /// <value>Ray base point as 2 (x, y) values.</value>
        [DataMember(Name = "p", IsRequired = true)]
        public List<double> P { get; set; } 
        /// <summary>
        /// Ray direction vector as 2 (x, y) values.
        /// </summary>
        /// <value>Ray direction vector as 2 (x, y) values.</value>
        [DataMember(Name = "v", IsRequired = true)]
        public List<double> V { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Ray2D";
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
            sb.Append("Ray2D:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  P: ").Append(P).Append("\n");
            sb.Append("  V: ").Append(V).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Ray2D object</returns>
        public static Ray2D FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Ray2D>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Ray2D object</returns>
        public virtual Ray2D DuplicateRay2D()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateRay2D();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRay2D();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Ray2D);
        }

        /// <summary>
        /// Returns true if Ray2D instances are equal
        /// </summary>
        /// <param name="input">Instance of Ray2D to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ray2D input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.P == input.P ||
                    Extension.AllEquals(this.P, input.P)
                ) && 
                (
                    this.V == input.V ||
                    Extension.AllEquals(this.V, input.V)
                ) && 
                    Extension.Equals(this.Type, input.Type);
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
                if (this.P != null)
                    hashCode = hashCode * 59 + this.P.GetHashCode();
                if (this.V != null)
                    hashCode = hashCode * 59 + this.V.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            Regex regexType = new Regex(@"^Ray2D$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}