﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoogleChartsNGraphsControls {
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
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GoogleChartsNGraphsControls.Resource1", typeof(Resource1).Assembly);
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
        ///   Looks up a localized string similar to jx={getHTTPObject:function(){var A=false;if(typeof ActiveXObject!=&quot;undefined&quot;){try{A=new ActiveXObject(&quot;Msxml2.XMLHTTP&quot;)}catch(C){try{A=new ActiveXObject(&quot;Microsoft.XMLHTTP&quot;)}catch(B){A=false}}}else{if(window.XMLHttpRequest){try{A=new XMLHttpRequest()}catch(C){A=false}}}return A},load:function(url,callback,format){var http=this.init();if(!http||!url){return }if(http.overrideMimeType){http.overrideMimeType(&quot;text/xml&quot;)}if(!format){var format=&quot;text&quot;}format=format.toLowerCase();var now=&quot;uid=&quot;+new Date().getTime [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string jx {
            get {
                return ResourceManager.GetString("jx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ////**
        /// * Registered by GoogleVisualizationsDotNet to facilitate the reload() function 
        /// * for each control.  Reload will proxy this to this call with the control and container
        /// * data.  Do not call directly. 
        /// *
        /// * PLEASE READ:
        /// * When loading data from the data source, there will be a GET parameter in the request - tqx - with a value like: &quot;reqId:0&quot;. 
        /// * You must return the same reqId in your response.
        /// *
        /// */
        ///function m_JustDraw(container, chart, data){
        ///    var objAjaxCallback = new AjaxCallback [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SendAndDraw {
            get {
                return ResourceManager.GetString("SendAndDraw", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Visualization {
            get {
                object obj = ResourceManager.GetObject("Visualization", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
