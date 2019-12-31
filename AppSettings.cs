using System;
using System.Configuration;

namespace CmdQueue
{
    using System.Collections.Generic;
    using System.Collections.Specialized;

    public class AppSettings : ApplicationSettingsBase
    {
        private static readonly object InstanceLock = new object();
        private static AppSettings instance;

        private AppSettings() {}

        public static AppSettings Instance {
            get {
                lock ( InstanceLock ) {
                    if ( instance == null ) {
                        instance = new AppSettings();
                    }
                }

                return instance;
            }
        }

        [UserScopedSetting]
        [SettingsSerializeAs( SettingsSerializeAs.Binary )]
        public List<Job> CurrentQueue {
            get {
                try {
                    if ( this["CurrentQueue"] != null ) {
                        return (List<Job>)this["CurrentQueue"];
                    }
                } catch (Exception error ) { }
                return null;
            }
            set {
                this["CurrentQueue"] = value;
            }
        }

        [UserScopedSetting]
        [SettingsSerializeAs( SettingsSerializeAs.Binary )]
        public StringCollection CommandHistory {
            get {
                try {
                    if ( this["CommandHistory"] != null ) {
                        return (StringCollection)this["CommandHistory"];
                    }
                } catch (Exception error ) { }
                return null;
            }
            set {
                this["CommandHistory"] = value;
            }
        }
    }
}