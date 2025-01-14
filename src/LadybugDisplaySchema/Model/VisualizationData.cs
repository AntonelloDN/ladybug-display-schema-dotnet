/* 
 * Ladybug Visualization Schema
 *
 * Documentation for Ladybug visualization schema
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
    /// Represents a data set for visualization with legend parameters and data type.
    /// </summary>
    [Serializable]
    [DataContract(Name = "VisualizationData")]
    public partial class VisualizationData : OpenAPIGenBaseModel, IEquatable<VisualizationData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualizationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VisualizationData() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "VisualizationData";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualizationData" /> class.
        /// </summary>
        /// <param name="values">A list of numerical values that will be used to generate the visualization colors. (required).</param>
        /// <param name="legendParameters">An Optional LegendParameters object to override default parameters of the legend. None indicates that default legend parameters will be used..</param>
        /// <param name="dataType">Optional DataType from the ladybug datatype subpackage (ie. Temperature()) , which will be used to assign default legend properties. If None, the legend associated with this object will contain no units unless a unit below is specified..</param>
        /// <param name="unit">Optional text string for the units of the values. (ie. \&quot;C\&quot;). If None, the default units of the data_type will be used. (default to &quot;&quot;).</param>
        public VisualizationData
        (
           List<double> values, // Required parameters
           LegendParameters legendParameters= default, DataType dataType= default, string unit = ""// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "values" is required (not null)
            this.Values = values ?? throw new ArgumentNullException("values is a required property for VisualizationData and cannot be null");
            this.LegendParameters = legendParameters;
            this.DataType = dataType;
            // use default value if no "unit" provided
            this.Unit = unit ?? "";

            // Set non-required readonly properties with defaultValue
            this.Type = "VisualizationData";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(VisualizationData))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "VisualizationData";

        /// <summary>
        /// A list of numerical values that will be used to generate the visualization colors.
        /// </summary>
        /// <value>A list of numerical values that will be used to generate the visualization colors.</value>
        [DataMember(Name = "values", IsRequired = true)]
        public List<double> Values { get; set; } 
        /// <summary>
        /// An Optional LegendParameters object to override default parameters of the legend. None indicates that default legend parameters will be used.
        /// </summary>
        /// <value>An Optional LegendParameters object to override default parameters of the legend. None indicates that default legend parameters will be used.</value>
        [DataMember(Name = "legend_parameters")]
        public LegendParameters LegendParameters { get; set; } 
        /// <summary>
        /// Optional DataType from the ladybug datatype subpackage (ie. Temperature()) , which will be used to assign default legend properties. If None, the legend associated with this object will contain no units unless a unit below is specified.
        /// </summary>
        /// <value>Optional DataType from the ladybug datatype subpackage (ie. Temperature()) , which will be used to assign default legend properties. If None, the legend associated with this object will contain no units unless a unit below is specified.</value>
        [DataMember(Name = "data_type")]
        public DataType DataType { get; set; } 
        /// <summary>
        /// Optional text string for the units of the values. (ie. \&quot;C\&quot;). If None, the default units of the data_type will be used.
        /// </summary>
        /// <value>Optional text string for the units of the values. (ie. \&quot;C\&quot;). If None, the default units of the data_type will be used.</value>
        [DataMember(Name = "unit")]
        public string Unit { get; set; }  = "";

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "VisualizationData";
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
            sb.Append("VisualizationData:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Values: ").Append(this.Values).Append("\n");
            sb.Append("  LegendParameters: ").Append(this.LegendParameters).Append("\n");
            sb.Append("  DataType: ").Append(this.DataType).Append("\n");
            sb.Append("  Unit: ").Append(this.Unit).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>VisualizationData object</returns>
        public static VisualizationData FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<VisualizationData>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>VisualizationData object</returns>
        public virtual VisualizationData DuplicateVisualizationData()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateVisualizationData();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateVisualizationData();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as VisualizationData);
        }

        /// <summary>
        /// Returns true if VisualizationData instances are equal
        /// </summary>
        /// <param name="input">Instance of VisualizationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VisualizationData input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Values == input.Values ||
                    Extension.AllEquals(this.Values, input.Values)
                ) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.LegendParameters, input.LegendParameters) && 
                    Extension.Equals(this.DataType, input.DataType) && 
                    Extension.Equals(this.Unit, input.Unit);
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
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.LegendParameters != null)
                    hashCode = hashCode * 59 + this.LegendParameters.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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
            Regex regexType = new Regex(@"^VisualizationData$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
