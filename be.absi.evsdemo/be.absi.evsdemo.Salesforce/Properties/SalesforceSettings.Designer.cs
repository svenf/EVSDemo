﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace be.absi.evsdemo.Salesforce.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class SalesforceSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static SalesforceSettings defaultInstance = ((SalesforceSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SalesforceSettings())));
        
        public static SalesforceSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("svenf@evsdemo.com")]
        public string Username {
            get {
                return ((string)(this["Username"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("EVSdemo1MY5MPCyjyZBBpgImqmDi6mWU")]
        public string Password {
            get {
                return ((string)(this["Password"]));
            }
        }
    }
}
