/* 
 * Ladybug Display Schema
 *
 * Documentation for Ladybug display schema
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
    /// A Polyface in 3D space with display properties.
    /// </summary>
    [Serializable]
    [DataContract(Name = "DisplayPolyface3D")]
    public partial class DisplayPolyface3D : DisplayBaseModel, IEquatable<DisplayPolyface3D>, IValidatableObject
    {
        /// <summary>
        /// Text to indicate the display mode (shaded, wireframe, etc.). The DisplayModes enumeration contains all acceptable types.
        /// </summary>
        /// <value>Text to indicate the display mode (shaded, wireframe, etc.). The DisplayModes enumeration contains all acceptable types.</value>
        [DataMember(Name="display_mode")]
        public DisplayModes DisplayMode { get; set; } = DisplayModes.Shaded;
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayPolyface3D" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DisplayPolyface3D() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DisplayPolyface3D";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayPolyface3D" /> class.
        /// </summary>
        /// <param name="geometry">Polyface3D for the geometry. (required).</param>
        /// <param name="colors">A list of colors that correspond to either the faces of the polyface or the vertices of the polyface. It can also be a single color for the entire polyface. (required).</param>
        /// <param name="displayMode">Text to indicate the display mode (shaded, wireframe, etc.). The DisplayModes enumeration contains all acceptable types..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public DisplayPolyface3D
        (
           Polyface3D geometry, List<Color> colors, // Required parameters
            Object userData= default, DisplayModes displayMode= DisplayModes.Shaded// Optional parameters
        ) : base(userData: userData)// BaseClass
        {
            // to ensure "geometry" is required (not null)
            this.Geometry = geometry ?? throw new ArgumentNullException("geometry is a required property for DisplayPolyface3D and cannot be null");
            // to ensure "colors" is required (not null)
            this.Colors = colors ?? throw new ArgumentNullException("colors is a required property for DisplayPolyface3D and cannot be null");
            this.DisplayMode = displayMode;

            // Set non-required readonly properties with defaultValue
            this.Type = "DisplayPolyface3D";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(DisplayPolyface3D))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "DisplayPolyface3D";

        /// <summary>
        /// Polyface3D for the geometry.
        /// </summary>
        /// <value>Polyface3D for the geometry.</value>
        [DataMember(Name = "geometry", IsRequired = true)]
        public Polyface3D Geometry { get; set; } 
        /// <summary>
        /// A list of colors that correspond to either the faces of the polyface or the vertices of the polyface. It can also be a single color for the entire polyface.
        /// </summary>
        /// <value>A list of colors that correspond to either the faces of the polyface or the vertices of the polyface. It can also be a single color for the entire polyface.</value>
        [DataMember(Name = "colors", IsRequired = true)]
        public List<Color> Colors { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DisplayPolyface3D";
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
            sb.Append("DisplayPolyface3D:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            sb.Append("  DisplayMode: ").Append(DisplayMode).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DisplayPolyface3D object</returns>
        public static DisplayPolyface3D FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DisplayPolyface3D>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DisplayPolyface3D object</returns>
        public virtual DisplayPolyface3D DuplicateDisplayPolyface3D()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDisplayPolyface3D();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override DisplayBaseModel DuplicateDisplayBaseModel()
        {
            return DuplicateDisplayPolyface3D();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DisplayPolyface3D);
        }

        /// <summary>
        /// Returns true if DisplayPolyface3D instances are equal
        /// </summary>
        /// <param name="input">Instance of DisplayPolyface3D to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisplayPolyface3D input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Geometry, input.Geometry) && 
                (
                    this.Colors == input.Colors ||
                    Extension.AllEquals(this.Colors, input.Colors)
                ) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.DisplayMode, input.DisplayMode);
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
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.Colors != null)
                    hashCode = hashCode * 59 + this.Colors.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DisplayMode != null)
                    hashCode = hashCode * 59 + this.DisplayMode.GetHashCode();
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
            Regex regexType = new Regex(@"^DisplayPolyface3D$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}