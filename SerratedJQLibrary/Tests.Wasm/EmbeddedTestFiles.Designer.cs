﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tests.Wasm {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class EmbeddedTestFiles {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal EmbeddedTestFiles() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tests.Wasm.EmbeddedTestFiles", typeof(EmbeddedTestFiles).Assembly);
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
        ///   Looks up a localized string similar to &quot;-prompt(8)-&quot;
        ///&apos;-prompt(8)-&apos;
        ///&quot;;a=prompt,a()//
        ///&apos;;a=prompt,a()//
        ///&apos;-eval(&quot;window[&apos;pro&apos;%2B&apos;mpt&apos;](8)&quot;)-&apos;
        ///&quot;-eval(&quot;window[&apos;pro&apos;%2B&apos;mpt&apos;](8)&quot;)-&quot;
        ///&quot;onclick=prompt(8)&gt;&quot;@x.y
        ///&quot;onclick=prompt(8)&gt;&lt;svg/onload=prompt(8)&gt;&quot;@x.y
        ///&lt;image/src/onerror=prompt(8)&gt;
        ///&lt;img/src/onerror=prompt(8)&gt;
        ///&lt;image src/onerror=prompt(8)&gt;
        ///&lt;img src/onerror=prompt(8)&gt;
        ///&lt;image src =q onerror=prompt(8)&gt;
        ///&lt;img src =q onerror=prompt(8)&gt;
        ///&lt;/scrip&lt;/script&gt;t&gt;&lt;img src =q onerror=prompt(8)&gt;
        ///&lt;svg onload=alert(1)&gt;
        ///&quot;&gt;&lt;svg onload=alert(1)//
        ///&quot;onmouseove [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string XssPayloads1 {
            get {
                return ResourceManager.GetString("XssPayloads1", resourceCulture);
            }
        }
    }
}
