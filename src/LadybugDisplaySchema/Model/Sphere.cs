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
    /// A sphere object.
    /// </summary>
    [Serializable]
    [DataContract(Name = "Sphere")]
    public partial class Sphere : OpenAPIGenBaseModel, IEquatable<Sphere>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sphere" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Sphere() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Sphere";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Sphere" /> class.
        /// </summary>
        /// <param name="center">The center of the sphere as 3 (x, y, z) values. (required).</param>
        /// <param name="radius">A number representing the radius of the sphere. (required).</param>
        public Sphere
        (
           List<double> center, double radius// Required parameters
            // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "center" is required (not null)
            this.Center = center ?? throw new ArgumentNullException("center is a required property for Sphere and cannot be null");
            this.Radius = radius;

            // Set non-required readonly properties with defaultValue
            this.Type = "Sphere";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Sphere))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Sphere";

        /// <summary>
        /// The center of the sphere as 3 (x, y, z) values.
        /// </summary>
        /// <value>The center of the sphere as 3 (x, y, z) values.</value>
        [DataMember(Name = "center", IsRequired = true)]
        public List<double> Center { get; set; } 
        /// <summary>
        /// A number representing the radius of the sphere.
        /// </summary>
        /// <value>A number representing the radius of the sphere.</value>
        [DataMember(Name = "radius", IsRequired = true)]
        public double Radius { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Sphere";
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
            sb.Append("Sphere:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Center: ").Append(Center).Append("\n");
            sb.Append("  Radius: ").Append(Radius).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Sphere object</returns>
        public static Sphere FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Sphere>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Sphere object</returns>
        public virtual Sphere DuplicateSphere()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateSphere();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateSphere();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Sphere);
        }

        /// <summary>
        /// Returns true if Sphere instances are equal
        /// </summary>
        /// <param name="input">Instance of Sphere to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sphere input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Center == input.Center ||
                    Extension.AllEquals(this.Center, input.Center)
                ) && 
                    Extension.Equals(this.Radius, input.Radius) && 
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
                if (this.Center != null)
                    hashCode = hashCode * 59 + this.Center.GetHashCode();
                if (this.Radius != null)
                    hashCode = hashCode * 59 + this.Radius.GetHashCode();
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
            Regex regexType = new Regex(@"^Sphere$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
