//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.Sarif.Multitool {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ValidatorResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidatorResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.Sarif.Multitool.ValidatorResources", typeof(ValidatorResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} version {1}.
        /// </summary>
        internal static string Banner {
            get {
                return ResourceManager.GetString("Banner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validation time: {0}.
        /// </summary>
        internal static string ElapsedTime {
            get {
                return ResourceManager.GetString("ElapsedTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema does not define a property named &quot;{1}&quot;, and the schema does not permit additional properties..
        /// </summary>
        internal static string ErrorAdditionalPropertiesProhibited {
            get {
                return ResourceManager.GetString("ErrorAdditionalPropertiesProhibited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This schema does not contain the sub-schema definition referred to by the $ref value &quot;{0}&quot;..
        /// </summary>
        internal static string ErrorDefinitionDoesNotExist {
            get {
                return ResourceManager.GetString("ErrorDefinitionDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema requires that when property &quot;{1}&quot; is present, properties [{2}] are also present, but properties [{3}] are missing..
        /// </summary>
        internal static string ErrorDependentPropertyMissing {
            get {
                return ResourceManager.GetString("ErrorDependentPropertyMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to JSON schema requires the value of &quot;additionalItems&quot; to be either a Boolean or a schema, but a token of type &quot;{1}&quot; was seen..
        /// </summary>
        internal static string ErrorInvalidAdditionalItemsType {
            get {
                return ResourceManager.GetString("ErrorInvalidAdditionalItemsType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to JSON schema requires the value of &quot;additionalProperties&quot; to be either a Boolean or a schema, but a token of type &quot;{1}&quot; was seen..
        /// </summary>
        internal static string ErrorInvalidAdditionalPropertiesType {
            get {
                return ResourceManager.GetString("ErrorInvalidAdditionalPropertiesType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to JSON schema requires the value of each property of the &quot;dependencies&quot;  object, to be either an schema or an array of strings, but a token of type &quot;{1}&quot; was seen..
        /// </summary>
        internal static string ErrorInvalidDependencyType {
            get {
                return ResourceManager.GetString("ErrorInvalidDependencyType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{1}&quot; does not match any of the enum values [{2}]..
        /// </summary>
        internal static string ErrorInvalidEnumValue {
            get {
                return ResourceManager.GetString("ErrorInvalidEnumValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to JSON schema requires the value of &quot;items&quot; to be either a schema or an array of schemas, but a token of type &quot;{1}&quot; was seen..
        /// </summary>
        internal static string ErrorInvalidItemsType {
            get {
                return ResourceManager.GetString("ErrorInvalidItemsType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to JSON requires that if the value of a property of the &quot;dependencies&quot; object is an array, then every element of the array must be a string, but a token of type &quot;{1}&quot; was seen..
        /// </summary>
        internal static string ErrorInvalidPropertyDependencyType {
            get {
                return ResourceManager.GetString("ErrorInvalidPropertyDependencyType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{1}&quot; is not a valid schema type..
        /// </summary>
        internal static string ErrorInvalidTypeString {
            get {
                return ResourceManager.GetString("ErrorInvalidTypeString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to JSON schema requires the value of &quot;type&quot; to be either a string or an array of strings, but a token of type &quot;{1}&quot; was seen..
        /// </summary>
        internal static string ErrorInvalidTypeType {
            get {
                return ResourceManager.GetString("ErrorInvalidTypeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to at &quot;{{0}}&quot;: {0}.
        /// </summary>
        internal static string ErrorMessageFormatWithPath {
            get {
                return ResourceManager.GetString("ErrorMessageFormatWithPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The instance does not validate successfully against all of the {1} schemas specified by &quot;allOf&quot;..
        /// </summary>
        internal static string ErrorNotAllOf {
            get {
                return ResourceManager.GetString("ErrorNotAllOf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value {1} is not a multiple of {2}..
        /// </summary>
        internal static string ErrorNotAMultiple {
            get {
                return ResourceManager.GetString("ErrorNotAMultiple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The instance does validate successfully against any of the {1} schemas specified by &quot;anyOf&quot;..
        /// </summary>
        internal static string ErrorNotAnyOf {
            get {
                return ResourceManager.GetString("ErrorNotAnyOf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property is required to be a string, but the token is of type &quot;{1}&quot;..
        /// </summary>
        internal static string ErrorNotAString {
            get {
                return ResourceManager.GetString("ErrorNotAString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The instance validates successfully against {1} of the {2} schemas specified by &quot;oneOf&quot;, instead of validating successfully against exactly one of them..
        /// </summary>
        internal static string ErrorNotOneOf {
            get {
                return ResourceManager.GetString("ErrorNotOneOf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The elements of the array are not unique..
        /// </summary>
        internal static string ErrorNotUnique {
            get {
                return ResourceManager.GetString("ErrorNotUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This partial implementation of JSON Schema only accepts $ref values in the form of fragments that refer to sub-properties of the &quot;definitions&quot; property, for example &quot;#/definitions/def1&quot;. The URI reference&quot;{0}&quot; is not supported..
        /// </summary>
        internal static string ErrorOnlyDefinitionFragmentsSupported {
            get {
                return ResourceManager.GetString("ErrorOnlyDefinitionFragmentsSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The required property &quot;{1}&quot; is missing..
        /// </summary>
        internal static string ErrorRequiredPropertyMissing {
            get {
                return ResourceManager.GetString("ErrorRequiredPropertyMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string &quot;{1}&quot; does not match the regular expression &quot;{2}&quot;..
        /// </summary>
        internal static string ErrorStringDoesNotMatchPattern {
            get {
                return ResourceManager.GetString("ErrorStringDoesNotMatchPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string &quot;{1}&quot; has length {2}, which is greater than the maximum length {3}.
        ///.
        /// </summary>
        internal static string ErrorStringTooLong {
            get {
                return ResourceManager.GetString("ErrorStringTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string &quot;{1}&quot; has length {2}, which is less than the minimum length {3}..
        /// </summary>
        internal static string ErrorStringTooShort {
            get {
                return ResourceManager.GetString("ErrorStringTooShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to JSON syntax error: {1}.
        /// </summary>
        internal static string ErrorSyntaxError {
            get {
                return ResourceManager.GetString("ErrorSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema requires at least {1} array items, but there are {2}..
        /// </summary>
        internal static string ErrorTooFewArrayItems {
            get {
                return ResourceManager.GetString("ErrorTooFewArrayItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The array has {1} items, but the array of schemas specified by  &quot;items&quot; has only {2} items, and &quot;additionalItems&quot; is not specified to allow additional array items..
        /// </summary>
        internal static string ErrorTooFewItemSchemas {
            get {
                return ResourceManager.GetString("ErrorTooFewItemSchemas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema requires at least {1} object properties, but there are {2}..
        /// </summary>
        internal static string ErrorTooFewProperties {
            get {
                return ResourceManager.GetString("ErrorTooFewProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema permits at most {1} array items, but there are {2}..
        /// </summary>
        internal static string ErrorTooManyArrayItems {
            get {
                return ResourceManager.GetString("ErrorTooManyArrayItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema permits at most {1} object properties, but there are {2}..
        /// </summary>
        internal static string ErrorTooManyProperties {
            get {
                return ResourceManager.GetString("ErrorTooManyProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The instance validates successfully against the schema specified by &quot;not&quot;..
        /// </summary>
        internal static string ErrorValidatesAgainstNotSchema {
            get {
                return ResourceManager.GetString("ErrorValidatesAgainstNotSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value {1} is greater than the maximum value of {2}..
        /// </summary>
        internal static string ErrorValueTooLarge {
            get {
                return ResourceManager.GetString("ErrorValueTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value {1} is greater than or equal to the exclusive maximum value of {2}..
        /// </summary>
        internal static string ErrorValueTooLargeExclusive {
            get {
                return ResourceManager.GetString("ErrorValueTooLargeExclusive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value {1} is less than the minimum value of {2}..
        /// </summary>
        internal static string ErrorValueTooSmall {
            get {
                return ResourceManager.GetString("ErrorValueTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value {1} is less than or equal to the exclusive minimum value of {2}..
        /// </summary>
        internal static string ErrorValueTooSmallExclusive {
            get {
                return ResourceManager.GetString("ErrorValueTooSmallExclusive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ({0},{1}): error {2}: {3}.
        /// </summary>
        internal static string ErrorWithLineInfo {
            get {
                return ResourceManager.GetString("ErrorWithLineInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ({0},{1}): error {2}: at {3}: {4}.
        /// </summary>
        internal static string ErrorWithLineInfoAndPath {
            get {
                return ResourceManager.GetString("ErrorWithLineInfoAndPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema requires one of the types [{1}], but a token of type &quot;{2}&quot; was found..
        /// </summary>
        internal static string ErrorWrongType {
            get {
                return ResourceManager.GetString("ErrorWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema does not specify a single schema for all array items. Access the per-item schemas through the Schemas property..
        /// </summary>
        internal static string ExceptionNotASingleSchema {
            get {
                return ResourceManager.GetString("ExceptionNotASingleSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An object contains a property not defined by the schema is present, and the schema does not permit additional properties..
        /// </summary>
        internal static string RuleDescriptionAdditionalPropertiesProhibited {
            get {
                return ResourceManager.GetString("RuleDescriptionAdditionalPropertiesProhibited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An instance does not have all the properties specified in the schema by a property dependency..
        /// </summary>
        internal static string RuleDescriptionDependentPropertyMissing {
            get {
                return ResourceManager.GetString("RuleDescriptionDependentPropertyMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the &quot;additionalItems&quot; schema property is neither a Boolean nor a schema..
        /// </summary>
        internal static string RuleDescriptionInvalidAdditionalItemsType {
            get {
                return ResourceManager.GetString("RuleDescriptionInvalidAdditionalItemsType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the &quot;additionalProperties&quot; schema property is neither a boolean nor an object..
        /// </summary>
        internal static string RuleDescriptionInvalidAdditionalPropertiesType {
            get {
                return ResourceManager.GetString("RuleDescriptionInvalidAdditionalPropertiesType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of one of the properties of the &quot;dependencies&quot; schema property is either a schema nor an array of strings..
        /// </summary>
        internal static string RuleDescriptionInvalidDependencyType {
            get {
                return ResourceManager.GetString("RuleDescriptionInvalidDependencyType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A string does not match any of the values specified by the schema&apos;s &quot;enum&quot; property..
        /// </summary>
        internal static string RuleDescriptionInvalidEnumValue {
            get {
                return ResourceManager.GetString("RuleDescriptionInvalidEnumValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the &quot;items&quot; property is neither a schema nor an array of schemas..
        /// </summary>
        internal static string RuleDescriptionInvalidItemsType {
            get {
                return ResourceManager.GetString("RuleDescriptionInvalidItemsType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of one of the properties of the &quot;dependencies&quot; schema property is an array which contains an element which is not a string..
        /// </summary>
        internal static string RuleDescriptionInvalidPropertyDependencyType {
            get {
                return ResourceManager.GetString("RuleDescriptionInvalidPropertyDependencyType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string value of the &quot;type&quot; schema property is not one of the valid values..
        /// </summary>
        internal static string RuleDescriptionInvalidTypeString {
            get {
                return ResourceManager.GetString("RuleDescriptionInvalidTypeString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the &quot;type&quot; schema property is neither a string nor an array of strings..
        /// </summary>
        internal static string RuleDescriptionInvalidTypeType {
            get {
                return ResourceManager.GetString("RuleDescriptionInvalidTypeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to n instance does not successfully validate against all of the schemas by the schema&apos;s &quot;allOf&quot; property..
        /// </summary>
        internal static string RuleDescriptionNotAllOf {
            get {
                return ResourceManager.GetString("RuleDescriptionNotAllOf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A numeric value is not a multiple of the value specified by the schema&apos;s &quot;multipleOf&quot; property..
        /// </summary>
        internal static string RuleDescriptionNotAMultiple {
            get {
                return ResourceManager.GetString("RuleDescriptionNotAMultiple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An instance does not successfully validate against any of the schemas by the schema&apos;s &quot;anyOf&quot; property..
        /// </summary>
        internal static string RuleDescriptionNotAnyOf {
            get {
                return ResourceManager.GetString("RuleDescriptionNotAnyOf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A schema property that is required to be a string is not a string..
        /// </summary>
        internal static string RuleDescriptionNotAString {
            get {
                return ResourceManager.GetString("RuleDescriptionNotAString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An instance does not successfully validate against exactly one of the schemas by the schema&apos;s &quot;oneOf&quot; property..
        /// </summary>
        internal static string RuleDescriptionNotOneOf {
            get {
                return ResourceManager.GetString("RuleDescriptionNotOneOf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An array&apos;s elements are not unique, as required by the schema&apos;s &quot;uniqueItems&quot; property..
        /// </summary>
        internal static string RuleDescriptionNotUnique {
            get {
                return ResourceManager.GetString("RuleDescriptionNotUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A property required by the schema&apos;s &quot;required&quot; property is missing..
        /// </summary>
        internal static string RuleDescriptionRequiredPropertyMissing {
            get {
                return ResourceManager.GetString("RuleDescriptionRequiredPropertyMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A string does not match the regular expression pattern specified by the schema&apos;s &quot;pattern&quot; property..
        /// </summary>
        internal static string RuleDescriptionStringDoesNotMatchPattern {
            get {
                return ResourceManager.GetString("RuleDescriptionStringDoesNotMatchPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A string is longer than permitted by the schema&apos;s &quot;maxLength&quot; property..
        /// </summary>
        internal static string RuleDescriptionStringTooLong {
            get {
                return ResourceManager.GetString("RuleDescriptionStringTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A string is shorter than permitted by the schema&apos;s &quot;minLength&quot; property..
        /// </summary>
        internal static string RuleDescriptionStringTooShort {
            get {
                return ResourceManager.GetString("RuleDescriptionStringTooShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema is not a valid JSON document..
        /// </summary>
        internal static string RuleDescriptionSyntaxError {
            get {
                return ResourceManager.GetString("RuleDescriptionSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An array has fewer elements than permitted by the schema&apos;s &quot;minItems&quot; property..
        /// </summary>
        internal static string RuleDescriptionTooFewArrayItems {
            get {
                return ResourceManager.GetString("RuleDescriptionTooFewArrayItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An array has more elements than the number of elements in the array specified by the schema&apos;s &quot;items&quot; property, and the schema does not permit additional array items..
        /// </summary>
        internal static string RuleDescriptionTooFewItemSchemas {
            get {
                return ResourceManager.GetString("RuleDescriptionTooFewItemSchemas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An object has fewer properties than permitted by the schema&apos;s &quot;minProperties&quot; property..
        /// </summary>
        internal static string RuleDescriptionTooFewProperties {
            get {
                return ResourceManager.GetString("RuleDescriptionTooFewProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An array has more elements than permitted by the schema&apos;s &quot;maxItems&quot; property..
        /// </summary>
        internal static string RuleDescriptionTooManyArrayItems {
            get {
                return ResourceManager.GetString("RuleDescriptionTooManyArrayItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An object has more properties than permitted by the schema&apos;s &quot;maxProperties&quot; property..
        /// </summary>
        internal static string RuleDescriptionTooManyProperties {
            get {
                return ResourceManager.GetString("RuleDescriptionTooManyProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An instance successfully validates against the schema specified by the schema&apos;s &quot;not&quot; property..
        /// </summary>
        internal static string RuleDescriptionValidatesAgainstNotSchema {
            get {
                return ResourceManager.GetString("RuleDescriptionValidatesAgainstNotSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A numeric value is greater than the maximum value permitted by the schema&apos;s &quot;maximum&quot; property..
        /// </summary>
        internal static string RuleDescriptionValueTooLarge {
            get {
                return ResourceManager.GetString("RuleDescriptionValueTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A numeric value is greater than or equal to the exclusive maximum value permitted by the schema&apos;s &quot;maximum&quot; and &quot;exclusiveMaximum&quot; properties..
        /// </summary>
        internal static string RuleDescriptionValueTooLargeExclusive {
            get {
                return ResourceManager.GetString("RuleDescriptionValueTooLargeExclusive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A numeric value is less than the minimum value permitted by the schema&apos;s &quot;minimum&quot; property..
        /// </summary>
        internal static string RuleDescriptionValueTooSmall {
            get {
                return ResourceManager.GetString("RuleDescriptionValueTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A numeric value is less than or equal to the exclusive minimum value permitted by the schema&apos;s &quot;minimum&quot; and &quot;exclusiveMinimum&quot; properties..
        /// </summary>
        internal static string RuleDescriptionValueTooSmallExclusive {
            get {
                return ResourceManager.GetString("RuleDescriptionValueTooSmallExclusive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An instance has a type that is not permitted by the schema&apos;s &quot;type&quot; property..
        /// </summary>
        internal static string RuleDescriptionWrongType {
            get {
                return ResourceManager.GetString("RuleDescriptionWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Success: The file is valid according to the schema..
        /// </summary>
        internal static string Success {
            get {
                return ResourceManager.GetString("Success", resourceCulture);
            }
        }
    }
}
