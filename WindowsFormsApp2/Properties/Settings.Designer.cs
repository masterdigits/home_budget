﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\baza.mdf;Inte" +
            "grated Security=True;Connect Timeout=30")]
        public string bazaConnectionString {
            get {
                return ((string)(this["bazaConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-6AR3PUB\\SQL2017;Initial Catalog=baza_danych;Integrated Securi" +
            "ty=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string baza_danychConnectionString {
            get {
                return ((string)(this["baza_danychConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=baza-home-budget-pentagram.database.windows.net;Initial Catalog=baza_" +
            "danych;User ID=kornfix1991;Password=WoJz48LBA<;Connect Timeout=60;Encrypt=True;T" +
            "rustServerCertificate=False")]
        public string baza_danychConnectionString1 {
            get {
                return ((string)(this["baza_danychConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=homebudget.database.windows.net;Initial Catalog=home_budget_db;User I" +
            "D=hbAdmin;Password=Qwerty123;Connect Timeout=30;Encrypt=True;TrustServerCertific" +
            "ate=False")]
        public string home_budget_dbConnectionString {
            get {
                return ((string)(this["home_budget_dbConnectionString"]));
            }
        }
    }
}
