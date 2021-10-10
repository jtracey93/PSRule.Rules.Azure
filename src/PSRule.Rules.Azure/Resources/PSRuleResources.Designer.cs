﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSRule.Rules.Azure.Resources
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class PSRuleResources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PSRuleResources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PSRule.Rules.Azure.Resources.PSRuleResources", typeof(PSRuleResources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The arguments for &apos;{0}&apos; are not in the expected format or type..
        /// </summary>
        internal static string ArgumentFormatInvalid
        {
            get
            {
                return ResourceManager.GetString("ArgumentFormatInvalid", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; for &apos;{1}&apos; is not a valid boolean..
        /// </summary>
        internal static string ArgumentInvalidBoolean
        {
            get
            {
                return ResourceManager.GetString("ArgumentInvalidBoolean", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; for &apos;{1}&apos; is not a valid integer..
        /// </summary>
        internal static string ArgumentInvalidInteger
        {
            get
            {
                return ResourceManager.GetString("ArgumentInvalidInteger", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The resource type &apos;{1}/{2}&apos; for &apos;{0}&apos; is not known..
        /// </summary>
        internal static string ArgumentInvalidResourceType
        {
            get
            {
                return ResourceManager.GetString("ArgumentInvalidResourceType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; for &apos;{1}&apos; is not a valid string..
        /// </summary>
        internal static string ArgumentInvalidString
        {
            get
            {
                return ResourceManager.GetString("ArgumentInvalidString", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The number of arguments &apos;{1}&apos; is not within the allowed range for &apos;{0}&apos;..
        /// </summary>
        internal static string ArgumentsOutOfRange
        {
            get
            {
                return ResourceManager.GetString("ArgumentsOutOfRange", resourceCulture);
            }
        }

        /// <summary>
        /// ///   Looks up a localized string similar to Bicep ({0}) compilation of &apos;{1}&apos; failed with: {2}.
        /// </summary>
        internal static string BicepCompileError
        {
            get
            {
                return ResourceManager.GetString("BicepCompileError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Bicep compilation hasn&apos;t completed within the timeout window. This can be caused by errors or warnings. Check the Bicep output by running bicep build and addressing any issues..
        /// </summary>
        internal static string BicepCompileTimeout
        {
            get
            {
                return ResourceManager.GetString("BicepCompileTimeout", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to expand resources because the source file &apos;{0}&apos; was not valid. {1}.
        /// </summary>
        internal static string BicepExpandInvalid
        {
            get
            {
                return ResourceManager.GetString("BicepExpandInvalid", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Bicep CLI can not be found. Consider installing Bicep or setting the PSRULE_AZURE_BICEP_PATH environment variable to resolve this issue..
        /// </summary>
        internal static string BicepNotFound
        {
            get
            {
                return ResourceManager.GetString("BicepNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to An error occurred evaluating expression &apos;{0}&apos; line {1}. {2}.
        /// </summary>
        internal static string ExpressionEvaluateError
        {
            get
            {
                return ResourceManager.GetString("ExpressionEvaluateError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Failed to parse expression. The expression may not be valid. Expression: &quot;{0}&quot;.
        /// </summary>
        internal static string ExpressionInvalid
        {
            get
            {
                return ResourceManager.GetString("ExpressionInvalid", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The specified parameter is not a valid string..
        /// </summary>
        internal static string FunctionInvalidString
        {
            get
            {
                return ResourceManager.GetString("FunctionInvalidString", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The function &quot;{0}&quot; was not found..
        /// </summary>
        internal static string FunctionNotFound
        {
            get
            {
                return ResourceManager.GetString("FunctionNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The language expression index &apos;{0}&apos; is not valid for the object..
        /// </summary>
        internal static string IndexInvalid
        {
            get
            {
                return ResourceManager.GetString("IndexInvalid", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to read file &apos;{0}&apos; because the JSON format was not valid. {1}.
        /// </summary>
        internal static string JsonFileFormatInvalid
        {
            get
            {
                return ResourceManager.GetString("JsonFileFormatInvalid", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The parameter file &apos;{0}&apos; does not contain a metadata property..
        /// </summary>
        internal static string MetadataNotFound
        {
            get
            {
                return ResourceManager.GetString("MetadataNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The number of resource segments needs to match the provided resource type..
        /// </summary>
        internal static string MismatchingResourceSegments
        {
            get
            {
                return ResourceManager.GetString("MismatchingResourceSegments", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to find the specified parameter file &apos;{0}&apos;..
        /// </summary>
        internal static string ParameterFileNotFound
        {
            get
            {
                return ResourceManager.GetString("ParameterFileNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The parameter named &apos;{0}&apos; was not set or a defaultValue was defined..
        /// </summary>
        internal static string ParameterNotFound
        {
            get
            {
                return ResourceManager.GetString("ParameterNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The template file &apos;{0}&apos; must be within the current working directory..
        /// </summary>
        internal static string PathTraversal
        {
            get
            {
                return ResourceManager.GetString("PathTraversal", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The language expression property &apos;{0}&apos; doesn&apos;t exist..
        /// </summary>
        internal static string PropertyNotFound
        {
            get
            {
                return ResourceManager.GetString("PropertyNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Read JSON failed..
        /// </summary>
        internal static string ReadJsonFailed
        {
            get
            {
                return ResourceManager.GetString("ReadJsonFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Can not serialize a null PSObject..
        /// </summary>
        internal static string SerializeNullPSObject
        {
            get
            {
                return ResourceManager.GetString("SerializeNullPSObject", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Create path.
        /// </summary>
        internal static string ShouldCreatePath
        {
            get
            {
                return ResourceManager.GetString("ShouldCreatePath", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Write file.
        /// </summary>
        internal static string ShouldWriteFile
        {
            get
            {
                return ResourceManager.GetString("ShouldWriteFile", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to expand resources because the template &apos;{0}&apos; was not valid with parameters &apos;{1}&apos;. {2}.
        /// </summary>
        internal static string TemplateExpandInvalid
        {
            get
            {
                return ResourceManager.GetString("TemplateExpandInvalid", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The template expression &apos;{0}&apos; exceeded the maximum length of 100K characters..
        /// </summary>
        internal static string TemplateExpressionTooLong
        {
            get
            {
                return ResourceManager.GetString("TemplateExpressionTooLong", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to find the specified template file &apos;{0}&apos;..
        /// </summary>
        internal static string TemplateFileNotFound
        {
            get
            {
                return ResourceManager.GetString("TemplateFileNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to find template referenced within parameter file &apos;{0}&apos;..
        /// </summary>
        internal static string TemplateFileReferenceNotFound
        {
            get
            {
                return ResourceManager.GetString("TemplateFileReferenceNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The parameter file &apos;{0}&apos; does not reference a linked template..
        /// </summary>
        internal static string TemplateLinkNotFound
        {
            get
            {
                return ResourceManager.GetString("TemplateLinkNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The template parameter &apos;{0}&apos; does not use the required format..
        /// </summary>
        internal static string TemplateParameterInvalid
        {
            get
            {
                return ResourceManager.GetString("TemplateParameterInvalid", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The variable named &apos;{0}&apos; was not defined in the template..
        /// </summary>
        internal static string VariableNotFound
        {
            get
            {
                return ResourceManager.GetString("VariableNotFound", resourceCulture);
            }
        }
    }
}
