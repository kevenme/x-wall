﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XWall.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SSH")]
        public string ProxyType {
            get {
                return ((string)(this["ProxyType"]));
            }
            set {
                this["ProxyType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SshServer {
            get {
                return ((string)(this["SshServer"]));
            }
            set {
                this["SshServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("22")]
        public int SshPort {
            get {
                return ((int)(this["SshPort"]));
            }
            set {
                this["SshPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SshUsername {
            get {
                return ((string)(this["SshUsername"]));
            }
            set {
                this["SshUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SshPassword {
            get {
                return ((string)(this["SshPassword"]));
            }
            set {
                this["SshPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HttpServer {
            get {
                return ((string)(this["HttpServer"]));
            }
            set {
                this["HttpServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("80")]
        public int HttpPort {
            get {
                return ((int)(this["HttpPort"]));
            }
            set {
                this["HttpPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoStart {
            get {
                return ((bool)(this["AutoStart"]));
            }
            set {
                this["AutoStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ListenToLocalOnly {
            get {
                return ((bool)(this["ListenToLocalOnly"]));
            }
            set {
                this["ListenToLocalOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9257")]
        public int ProxyPort {
            get {
                return ((int)(this["ProxyPort"]));
            }
            set {
                this["ProxyPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SshCompression {
            get {
                return ((bool)(this["SshCompression"]));
            }
            set {
                this["SshCompression"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4220")]
        public int SshSocksPort {
            get {
                return ((int)(this["SshSocksPort"]));
            }
            set {
                this["SshSocksPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CustomRulesAddSubdomains {
            get {
                return ((bool)(this["CustomRulesAddSubdomains"]));
            }
            set {
                this["CustomRulesAddSubdomains"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeRequired {
            get {
                return ((bool)(this["UpgradeRequired"]));
            }
            set {
                this["UpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("plink.exe")]
        public string PlinkFileName {
            get {
                return ((string)(this["PlinkFileName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("privoxy.exe")]
        public string PrivoxyFileName {
            get {
                return ((string)(this["PrivoxyFileName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("privoxy.config")]
        public string PrivoxyConfigFileName {
            get {
                return ((string)(this["PrivoxyConfigFileName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SshAutoReconnect {
            get {
                return ((bool)(this["SshAutoReconnect"]));
            }
            set {
                this["SshAutoReconnect"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.github.com/vilic/x-wall/master/rules/rules-v2")]
        public string OnlineRulesUrl {
            get {
                return ((string)(this["OnlineRulesUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("online-rules")]
        public string OnlineRulesFileName {
            get {
                return ((string)(this["OnlineRulesFileName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime OnlineRulesLastUpdateTime {
            get {
                return ((global::System.DateTime)(this["OnlineRulesLastUpdateTime"]));
            }
            set {
                this["OnlineRulesLastUpdateTime"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("86400")]
        public int OnlineRulesUpdateInterval {
            get {
                return ((int)(this["OnlineRulesUpdateInterval"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseOnlineRules {
            get {
                return ((bool)(this["UseOnlineRules"]));
            }
            set {
                this["UseOnlineRules"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseCustomRules {
            get {
                return ((bool)(this["UseCustomRules"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CustomRules {
            get {
                return ((string)(this["CustomRules"]));
            }
            set {
                this["CustomRules"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("privoxy.action")]
        public string PrivoxyActionFileName {
            get {
                return ((string)(this["PrivoxyActionFileName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FirstRun {
            get {
                return ((bool)(this["FirstRun"]));
            }
            set {
                this["FirstRun"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30000")]
        public int SshConnectTimeout {
            get {
                return ((int)(this["SshConnectTimeout"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60000")]
        public int RuleUpdateTimeout {
            get {
                return ((int)(this["RuleUpdateTimeout"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int AbortionBeforeReconnect {
            get {
                return ((int)(this["AbortionBeforeReconnect"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("128")]
        public int MaxReconnectPeriod {
            get {
                return ((int)(this["MaxReconnectPeriod"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string OriginalProxies {
            get {
                return ((string)(this["OriginalProxies"]));
            }
            set {
                this["OriginalProxies"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("i@vilic.info")]
        public string FeedbackEmail {
            get {
                return ((string)(this["FeedbackEmail"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://x-wall.org")]
        public string WebsiteUrl {
            get {
                return ((string)(this["WebsiteUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.github.com/vilic/x-wall/master/release/x-wall-setup.exe")]
        public string UpdateInstallerUrl {
            get {
                return ((string)(this["UpdateInstallerUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.github.com/vilic/x-wall/master/release/version")]
        public string OnlineVersionUrl {
            get {
                return ((string)(this["OnlineVersionUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("setup.exe")]
        public string UpdateInstallerName {
            get {
                return ((string)(this["UpdateInstallerName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DismissedUpdateVersion {
            get {
                return ((string)(this["DismissedUpdateVersion"]));
            }
            set {
                this["DismissedUpdateVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SshNotification {
            get {
                return ((bool)(this["SshNotification"]));
            }
            set {
                this["SshNotification"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int ForwardConnectionRetries {
            get {
                return ((int)(this["ForwardConnectionRetries"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("update-mark")]
        public string UpdateMarkName {
            get {
                return ((string)(this["UpdateMarkName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("new-rule-cmd")]
        public string NewRuleFileName {
            get {
                return ((string)(this["NewRuleFileName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("del-rule-cmd")]
        public string DeleteRuleFileName {
            get {
                return ((string)(this["DeleteRuleFileName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SubmitNewRule {
            get {
                return ((bool)(this["SubmitNewRule"]));
            }
            set {
                this["SubmitNewRule"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SubmitNewRuleAsked {
            get {
                return ((bool)(this["SubmitNewRuleAsked"]));
            }
            set {
                this["SubmitNewRuleAsked"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("submit-new-rule-toggle")]
        public string SubmitNewRuleToggleFileName {
            get {
                return ((string)(this["SubmitNewRuleToggleFileName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://config.privoxy.org/show-url-info")]
        public string ShowUrlInfoUrl {
            get {
                return ((string)(this["ShowUrlInfoUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("privoxy-templates\\")]
        public string PrivoxyTemplatesFolderName {
            get {
                return ((string)(this["PrivoxyTemplatesFolderName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SshUsePlonk {
            get {
                return ((bool)(this["SshUsePlonk"]));
            }
            set {
                this["SshUsePlonk"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("plonk.exe")]
        public string PlonkFileName {
            get {
                return ((string)(this["PlonkFileName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SshPlonkKeyword {
            get {
                return ((string)(this["SshPlonkKeyword"]));
            }
            set {
                this["SshPlonkKeyword"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string PrivoxyKeepAliveTimeout {
            get {
                return ((string)(this["PrivoxyKeepAliveTimeout"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SshReconnectAnyCondition {
            get {
                return ((bool)(this["SshReconnectAnyCondition"]));
            }
            set {
                this["SshReconnectAnyCondition"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int PlinkConnectTimeout {
            get {
                return ((int)(this["PlinkConnectTimeout"]));
            }
        }
    }
}
