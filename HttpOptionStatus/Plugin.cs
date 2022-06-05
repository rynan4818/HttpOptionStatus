using IPA;
using IPA.Config;
using IPA.Config.Stores;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;

namespace HttpOptionStatus
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static Plugin Instance { get; private set; }
        internal static IPALogger Log { get; private set; }

        [Init]
        /// <summary>
        /// IPAによってプラグインが最初にロードされたときに呼び出されます。（ゲームが開始されたとき、またはプラグインが無効の状態で開始された場合は有効化されたときのいずれか）
        /// [Init]はコンストラクタのメソッド、InitWithConfig のような通常のメソッドの前に呼び出されます。
        /// [Init]は１つのコンストラクタのみを使用して下さい。
        /// </summary>
        public void Init(IPALogger logger)
        {
            Instance = this;
            Log = logger;
            Log.Info("HttpOptionStatus initialized.");
        }

        #region BSIPA Config
        //BSIPAのコンフィグレーション機能を使用する場合は、コメントを外してください。
        /*
        [Init]
        public void InitWithConfig(Config conf)
        {
            Configuration.PluginConfig.Instance = conf.Generated<Configuration.PluginConfig>();
            Log.Debug("Config loaded");
        }
        */
        #endregion

        [OnStart]
        public void OnApplicationStart()
        {
            Log.Debug("OnApplicationStart");
            new GameObject("HttpOptionStatusController").AddComponent<HttpOptionStatusController>();

        }

        [OnExit]
        public void OnApplicationQuit()
        {
            Log.Debug("OnApplicationQuit");

        }
    }
}
