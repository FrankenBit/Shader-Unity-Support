﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
internal class Resource {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal Resource() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resource", typeof(Resource).Assembly);
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
    ///   Looks up a localized string similar to #ifndef@#ifndef@Example: #ifndef AUTOLIGHT_INCLUDED
    ///AUTOLIGHT_INCLUDED@AUTOLIGHT_INCLUDED@Example: #ifndef AUTOLIGHT_INCLUDED
    ///AUTOLIGHT_INCLUDED@AUTOLIGHT_INCLUDED@Body: #define AUTOLIGHT_INCLUDED
    ///#include@#include@Example: #include &quot;HLSLSupport.cginc&quot;
    ///HLSLSupport@HLSLSupport@Example: #include &quot;HLSLSupport.cginc&quot;
    ///cginc@cginc@Example: #include &quot;HLSLSupport.cginc&quot;
    ///defined@defined@Example: #if defined(SHADOWS_NATIVE)
    ///SHADOWS_NATIVE@SHADOWS_NATIVE@Example: #if defined(SHADOWS_NATIVE)
    ///UNITY_DECLARE_SHADO [rest of string was truncated]&quot;;.
    /// </summary>
    internal static string AutoLight_cginc {
        get {
            return ResourceManager.GetString("AutoLight_cginc", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to abs( x ) @abs( x ) @Absolute value of x .
    ///acos( x ) @acos( x ) @Arccosine of x in range [0, p], x in [–1, 1].
    ///all( x ) @all( x ) @@Returns true if every component of x is not equal to 0.
    ///Returns false otherwise.@
    ///any( x ) @any( x ) @@Returns true if any component of x is not equal to 0.
    ///Returns false otherwise.@
    ///asin( x ) @asin( x ) @Arcsine of x in range [–p/2, p/2]; x should be in [–1, 1].
    ///atan( x ) @atan( x ) @Arctangent of x in range [–p/2, p/2].
    ///atan2( y , x ) @atan2( y , x ) @Arctangent of y / [rest of string was truncated]&quot;;.
    /// </summary>
    internal static string LanguageData {
        get {
            return ResourceManager.GetString("LanguageData", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to #ifndef@#ifndef@Example: #ifndef LIGHTING_INCLUDED
    ///LIGHTING_INCLUDED@LIGHTING_INCLUDED@Example: #ifndef LIGHTING_INCLUDED
    ///LIGHTING_INCLUDED@LIGHTING_INCLUDED@Body: #define LIGHTING_INCLUDED
    ///fixed3@fixed3@Example: fixed3 Albedo;
    ///Albedo@Albedo@Example: fixed3 Albedo;
    ///fixed3@fixed3@Example: fixed3 Normal;
    ///Normal@Normal@Example: fixed3 Normal;
    ///fixed3@fixed3@Example: fixed3 Emission;
    ///Emission@Emission@Example: fixed3 Emission;
    ///half@half@Example: half Specular;
    ///Specular@Specular@Example: half Specular;    /// [rest of string was truncated]&quot;;.
    /// </summary>
    internal static string Lighting_cginc {
        get {
            return ResourceManager.GetString("Lighting_cginc", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to #ifndef@#ifndef@Example: #ifndef TERRAIN_ENGINE_INCLUDED
    ///TERRAIN_ENGINE_INCLUDED@TERRAIN_ENGINE_INCLUDED@Example: #ifndef TERRAIN_ENGINE_INCLUDED
    ///TERRAIN_ENGINE_INCLUDED@TERRAIN_ENGINE_INCLUDED@Body: #define TERRAIN_ENGINE_INCLUDED
    ///Terrain@Terrain@Example: // Terrain engine shader helpers
    ///engine@engine@Example: // Terrain engine shader helpers
    ///shader@shader@Example: // Terrain engine shader helpers
    ///helpers@helpers@Example: // Terrain engine shader helpers
    ///CBUFFER_START@CBUFFER_START@Example: CBUFFER_ [rest of string was truncated]&quot;;.
    /// </summary>
    internal static string TerrainEngine_cginc {
        get {
            return ResourceManager.GetString("TerrainEngine_cginc", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to #ifndef@#ifndef@Example: #ifndef TESSELLATION_CGINC_INCLUDED
    ///TESSELLATION_CGINC_INCLUDED@TESSELLATION_CGINC_INCLUDED@Example: #ifndef TESSELLATION_CGINC_INCLUDED
    ///TESSELLATION_CGINC_INCLUDED@TESSELLATION_CGINC_INCLUDED@Body: #define TESSELLATION_CGINC_INCLUDED
    ///&quot;UnityShaderVariables.cginc&quot;//----utilityfunctionsfloatUnityCalcDistanceTessFactor(float4vertex,floatminDist,floatmaxDist,floattess)@&quot;UnityShaderVariables.cginc&quot;// ---- utility functionsfloat UnityCalcDistanceTessFactor (float4 vertex, float minDist [rest of string was truncated]&quot;;.
    /// </summary>
    internal static string Tessellation_cginc {
        get {
            return ResourceManager.GetString("Tessellation_cginc", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to #ifndef@#ifndef@Example: #ifndef UNITY_CG_INCLUDED
    ///UNITY_CG_INCLUDED@UNITY_CG_INCLUDED@Example: #ifndef UNITY_CG_INCLUDED
    ///UNITY_CG_INCLUDED@UNITY_CG_INCLUDED@Body: #define UNITY_CG_INCLUDED
    ///#include@#include@Example: #include &quot;UnityShaderVariables.cginc&quot;
    ///UnityShaderVariables@UnityShaderVariables@Example: #include &quot;UnityShaderVariables.cginc&quot;
    ///cginc@cginc@Example: #include &quot;UnityShaderVariables.cginc&quot;
    ///#endif@#endif@Body: #endif
    ///defined@defined@Example: #if defined(SHADER_API_PS3)
    ///SHADER_API_PS3@SHADER [rest of string was truncated]&quot;;.
    /// </summary>
    internal static string UnityCG_cginc {
        get {
            return ResourceManager.GetString("UnityCG_cginc", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to #ifndef@#ifndef@Example: #ifndef UNITY_CG_INCLUDED
    ///UNITY_CG_INCLUDED@UNITY_CG_INCLUDED@Example: #ifndef UNITY_CG_INCLUDED
    ///UNITY_CG_INCLUDED@UNITY_CG_INCLUDED@Body: #define UNITY_CG_INCLUDED
    ///Common@Common@Example: // Common functions
    ///functions@functions@Example: // Common functions
    ///saturate(floatx)@saturate(float x) @@Body: float saturate(float x) 
    ///{
    ///return max(0.0, min(1.0, x));
    ///
    ///}
    ///@
    ///builtin@builtin@Example: //  builtin values exposed from Unity
    ///values@values@Example: //  builtin values exposed  [rest of string was truncated]&quot;;.
    /// </summary>
    internal static string UnityCG_glslinc {
        get {
            return ResourceManager.GetString("UnityCG_glslinc", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to #ifndef@#ifndef@Example: #ifndef UNITY_SHADER_VARIABLES_INCLUDED
    ///UNITY_SHADER_VARIABLES_INCLUDED@UNITY_SHADER_VARIABLES_INCLUDED@Example: #ifndef UNITY_SHADER_VARIABLES_INCLUDED
    ///UNITY_SHADER_VARIABLES_INCLUDED@UNITY_SHADER_VARIABLES_INCLUDED@Body: #define UNITY_SHADER_VARIABLES_INCLUDED
    ///#include@#include@Example: #include &quot;HLSLSupport.cginc&quot;
    ///HLSLSupport@HLSLSupport@Example: #include &quot;HLSLSupport.cginc&quot;
    ///cginc@cginc@Example: #include &quot;HLSLSupport.cginc&quot;
    ///uniform@uniform@Example: uniform float4 _SinTime;    /// [rest of string was truncated]&quot;;.
    /// </summary>
    internal static string UnityShaderVariables_cginc {
        get {
            return ResourceManager.GetString("UnityShaderVariables_cginc", resourceCulture);
        }
    }
}
