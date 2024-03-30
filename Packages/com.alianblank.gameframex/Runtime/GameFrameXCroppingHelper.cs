using System;
using UnityEngine;

namespace GameFrameX.Runtime
{
    public class GameFrameXCroppingHelper : MonoBehaviour
    {
        private void Start()
        {
            _ = typeof(BinaryExtension);
            _ = typeof(BufferExtension);
            _ = typeof(GameApp);
            _ = typeof(GameFrameX.Asset.AssetManager);
            _ = typeof(GameFrameX.Asset.Constant);
            _ = typeof(GameFrameX.Asset.IAssetManager);
            _ = typeof(GameFrameX.BaseEventArgs);
            _ = typeof(GameFrameX.Config.ConfigManager);
            _ = typeof(GameFrameX.Config.IConfigData);
            _ = typeof(GameFrameX.Config.IConfigHelper);
            _ = typeof(GameFrameX.Config.IConfigManager);
            _ = typeof(GameFrameX.Config.LoadConfigFailureEventArgs);
            _ = typeof(GameFrameX.Config.LoadConfigSuccessEventArgs);
            _ = typeof(GameFrameX.Config.LoadConfigUpdateEventArgs);
            _ = typeof(GameFrameX.Download.Constant);
            _ = typeof(GameFrameX.Download.DownloadAgentHelperCompleteEventArgs);
            _ = typeof(GameFrameX.Download.DownloadAgentHelperErrorEventArgs);
            _ = typeof(GameFrameX.Download.DownloadAgentHelperUpdateBytesEventArgs);
            _ = typeof(GameFrameX.Download.DownloadAgentHelperUpdateLengthEventArgs);
            _ = typeof(GameFrameX.Download.DownloadFailureEventArgs);
            _ = typeof(GameFrameX.Download.DownloadManager);
            _ = typeof(GameFrameX.Download.DownloadStartEventArgs);
            _ = typeof(GameFrameX.Download.DownloadSuccessEventArgs);
            _ = typeof(GameFrameX.Download.DownloadUpdateEventArgs);
            _ = typeof(GameFrameX.Download.IDownloadAgentHelper);
            _ = typeof(GameFrameX.Download.IDownloadManager);
            _ = typeof(GameFrameX.Entity.EntityManager);
            _ = typeof(GameFrameX.Entity.HideEntityCompleteEventArgs);
            _ = typeof(GameFrameX.Entity.IEntity);
            _ = typeof(GameFrameX.Entity.IEntityGroup);
            _ = typeof(GameFrameX.Entity.IEntityGroupHelper);
            _ = typeof(GameFrameX.Entity.IEntityHelper);
            _ = typeof(GameFrameX.Entity.IEntityManager);
            _ = typeof(GameFrameX.Entity.ShowEntityDependencyAssetEventArgs);
            _ = typeof(GameFrameX.Entity.ShowEntityFailureEventArgs);
            _ = typeof(GameFrameX.Entity.ShowEntitySuccessEventArgs);
            _ = typeof(GameFrameX.Entity.ShowEntityUpdateEventArgs);
            _ = typeof(GameFrameX.Event.EventManager);
            _ = typeof(GameFrameX.Event.GameEventArgs);
            _ = typeof(GameFrameX.Event.IEventManager);
            _ = typeof(GameFrameX.EventPool<>);
            _ = typeof(GameFrameX.EventPoolMode);
            _ = typeof(GameFrameX.Fsm.Fsm<>);
            _ = typeof(GameFrameX.Fsm.FsmBase);
            _ = typeof(GameFrameX.Fsm.FsmManager);
            _ = typeof(GameFrameX.Fsm.FsmState<>);
            _ = typeof(GameFrameX.Fsm.IFsm<>);
            _ = typeof(GameFrameX.Fsm.IFsmManager);
            _ = typeof(GameFrameX.GameAnalytics.GameAnalyticsManager);
            _ = typeof(GameFrameX.GameAnalytics.IGameAnalyticsManager);
            _ = typeof(GameFrameX.GameFrameworkEntry);
            _ = typeof(GameFrameX.GameFrameworkEventArgs);
            _ = typeof(GameFrameX.GameFrameworkException);
            _ = typeof(GameFrameX.GameFrameworkGuard);
            _ = typeof(GameFrameX.GameFrameworkLinkedList<>);
            _ = typeof(GameFrameX.GameFrameworkLinkedListRange<>);
            _ = typeof(GameFrameX.GameFrameworkLinkedListRange<>.Enumerator);
            _ = typeof(GameFrameX.GameFrameworkLog);
            _ = typeof(GameFrameX.GameFrameworkLog.ILogHelper);
            _ = typeof(GameFrameX.GameFrameworkLogLevel);
            _ = typeof(GameFrameX.GameFrameworkModule);
            _ = typeof(GameFrameX.GameFrameworkMultiDictionary<,>);
            _ = typeof(GameFrameX.GameFrameworkMultiDictionary<,>.Enumerator);
            _ = typeof(GameFrameX.GameFrameworkSerializer<>);
            _ = typeof(GameFrameX.GameFrameworkSerializer<>.DeserializeCallback);
            _ = typeof(GameFrameX.GameFrameworkSerializer<>.SerializeCallback);
            _ = typeof(GameFrameX.GameFrameworkSerializer<>.TryGetValueCallback);
            _ = typeof(GameFrameX.IReference);
            _ = typeof(GameFrameX.ITaskAgent<>);
            _ = typeof(GameFrameX.Localization.ILocalizationHelper);
            _ = typeof(GameFrameX.Localization.ILocalizationManager);
            _ = typeof(GameFrameX.Localization.Language);
            _ = typeof(GameFrameX.Localization.LoadDictionaryFailureEventArgs);
            _ = typeof(GameFrameX.Localization.LoadDictionarySuccessEventArgs);
            _ = typeof(GameFrameX.Localization.LoadDictionaryUpdateEventArgs);
            _ = typeof(GameFrameX.Localization.LocalizationManager);
            _ = typeof(GameFrameX.Mono.IMonoManager);
            _ = typeof(GameFrameX.Mono.MonoManager);
            _ = typeof(GameFrameX.Mono.OnApplicationFocusChangedEventArgs);
            _ = typeof(GameFrameX.Mono.OnApplicationPauseChangedEventArgs);
            _ = typeof(GameFrameX.Network.AddressFamily);
            _ = typeof(GameFrameX.Network.DefaultPacketReceiveBodyHandler);
            _ = typeof(GameFrameX.Network.DefaultPacketReceiveHeaderHandler);
            _ = typeof(GameFrameX.Network.DefaultPacketSendBodyHandler);
            _ = typeof(GameFrameX.Network.DefaultPacketSendHeaderHandler);
            _ = typeof(GameFrameX.Network.INetworkChannel);
            _ = typeof(GameFrameX.Network.INetworkChannelHelper);
            _ = typeof(GameFrameX.Network.INetworkManager);
            _ = typeof(GameFrameX.Network.INetworkSocket);
            _ = typeof(GameFrameX.Network.IPacketHandler);
            _ = typeof(GameFrameX.Network.IPacketHeartBeatHandler);
            _ = typeof(GameFrameX.Network.IPacketReceiveBodyHandler);
            _ = typeof(GameFrameX.Network.IPacketReceiveHeaderHandler);
            _ = typeof(GameFrameX.Network.IPacketSendBodyHandler);
            _ = typeof(GameFrameX.Network.IPacketSendHeaderHandler);
            _ = typeof(GameFrameX.Network.IRequestMessage);
            _ = typeof(GameFrameX.Network.IResponseMessage);
            _ = typeof(GameFrameX.Network.MessagePackageObjectAttribute);
            _ = typeof(GameFrameX.Network.MessageTypeHandlerAttribute);
            _ = typeof(GameFrameX.Network.NetworkClosedEventArgs);
            _ = typeof(GameFrameX.Network.NetworkConnectedEventArgs);
            _ = typeof(GameFrameX.Network.NetworkCustomErrorEventArgs);
            _ = typeof(GameFrameX.Network.NetworkErrorCode);
            _ = typeof(GameFrameX.Network.NetworkErrorEventArgs);
            _ = typeof(GameFrameX.Network.NetworkManager);
            _ = typeof(GameFrameX.Network.NetworkManager.ConnectState);
            _ = typeof(GameFrameX.Network.NetworkManager.HeartBeatState);
            _ = typeof(GameFrameX.Network.NetworkManager.NetworkChannelBase);
            _ = typeof(GameFrameX.Network.NetworkManager.ReceiveState);
            _ = typeof(GameFrameX.Network.NetworkManager.SendState);
            _ = typeof(GameFrameX.Network.NetworkMissHeartBeatEventArgs);
            _ = typeof(GameFrameX.Network.Packet);
            _ = typeof(GameFrameX.Network.PacketBase);
            _ = typeof(GameFrameX.Network.ProtoMessageIdHandler);
            _ = typeof(GameFrameX.Network.ServiceType);
            _ = typeof(GameFrameX.ObjectPool.IObjectPool<>);
            _ = typeof(GameFrameX.ObjectPool.IObjectPoolManager);
            _ = typeof(GameFrameX.ObjectPool.ObjectBase);
            _ = typeof(GameFrameX.ObjectPool.ObjectInfo);
            _ = typeof(GameFrameX.ObjectPool.ObjectPoolBase);
            _ = typeof(GameFrameX.ObjectPool.ObjectPoolManager);
            _ = typeof(GameFrameX.ObjectPool.ReleaseObjectFilterCallback<>);
            _ = typeof(GameFrameX.Procedure.IProcedureManager);
            _ = typeof(GameFrameX.Procedure.ProcedureBase);
            _ = typeof(GameFrameX.Procedure.ProcedureManager);
            _ = typeof(GameFrameX.ReferencePool);
            _ = typeof(GameFrameX.ReferencePoolInfo);
            _ = typeof(GameFrameX.Runtime.ApplicationHelper);
            _ = typeof(GameFrameX.Runtime.AssetComponent);
            _ = typeof(GameFrameX.Runtime.AttachEntityInfo);
            _ = typeof(GameFrameX.Runtime.BaseComponent);
            _ = typeof(GameFrameX.Runtime.CameraHelper);
            _ = typeof(GameFrameX.Runtime.ConfigComponent);
            _ = typeof(GameFrameX.Runtime.ConfigHelperBase);
            _ = typeof(GameFrameX.Runtime.CoroutineComponent);
            _ = typeof(GameFrameX.Runtime.DefaultCompressionHelper);
            _ = typeof(GameFrameX.Runtime.DefaultEntityGroupHelper);
            _ = typeof(GameFrameX.Runtime.DefaultEntityHelper);
            _ = typeof(GameFrameX.Runtime.DefaultLocalizationHelper);
            _ = typeof(GameFrameX.Runtime.DefaultLogHelper);
            _ = typeof(GameFrameX.Runtime.DefaultSetting);
            _ = typeof(GameFrameX.Runtime.DefaultSettingHelper);
            _ = typeof(GameFrameX.Runtime.DefaultSettingSerializer);
            _ = typeof(GameFrameX.Runtime.DefaultSoundAgentHelper);
            _ = typeof(GameFrameX.Runtime.DefaultSoundGroupHelper);
            _ = typeof(GameFrameX.Runtime.DefaultSoundHelper);
            _ = typeof(GameFrameX.Runtime.DefaultTextHelper);
            _ = typeof(GameFrameX.Runtime.DefaultVersionHelper);
            _ = typeof(GameFrameX.Runtime.DistinctHelper);
            _ = typeof(GameFrameX.Runtime.DoTweenHelper);
            _ = typeof(GameFrameX.Runtime.DownloadAgentHelperBase);
            _ = typeof(GameFrameX.Runtime.DownloadComponent);
            _ = typeof(GameFrameX.Runtime.Entity);
            _ = typeof(GameFrameX.Runtime.EntityComponent);
            _ = typeof(GameFrameX.Runtime.EntityGroupHelperBase);
            _ = typeof(GameFrameX.Runtime.EntityHelperBase);
            _ = typeof(GameFrameX.Runtime.EntityLogic);
            _ = typeof(GameFrameX.Runtime.EventComponent);
            _ = typeof(GameFrameX.Runtime.FileHelper);
            _ = typeof(GameFrameX.Runtime.FsmComponent);
            _ = typeof(GameFrameX.Runtime.FUI);
            _ = typeof(GameFrameX.Runtime.FUIComponent);
            _ = typeof(GameFrameX.Runtime.FUILoadAsyncResourceHelper);
            _ = typeof(GameFrameX.Runtime.FUIPackageComponent);
            _ = typeof(GameFrameX.Runtime.FUIPathFinderHelper);
            _ = typeof(GameFrameX.Runtime.GameAnalyticsComponent);
            _ = typeof(GameFrameX.Runtime.GameEntry);
            _ = typeof(GameFrameX.Runtime.GameFrameworkComponent);
            _ = typeof(GameFrameX.Runtime.GameFrameXCroppingHelper);
            _ = typeof(GameFrameX.Runtime.GameObjectHelper);
            _ = typeof(GameFrameX.Runtime.GameTimeHelper);
            _ = typeof(GameFrameX.Runtime.GlobalConfigComponent);
            _ = typeof(GameFrameX.Runtime.GObjectHelper);
            _ = typeof(GameFrameX.Runtime.Helper);
            _ = typeof(GameFrameX.Runtime.HttpJsonResult);
            _ = typeof(GameFrameX.Runtime.LocalizationComponent);
            _ = typeof(GameFrameX.Runtime.LocalizationHelperBase);
            _ = typeof(GameFrameX.Runtime.Log);
            _ = typeof(GameFrameX.Runtime.LuaComponent);
            _ = typeof(GameFrameX.Runtime.MathHelper);
            _ = typeof(GameFrameX.Runtime.MonoComponent);
            _ = typeof(GameFrameX.Runtime.NetworkComponent);
            _ = typeof(GameFrameX.Runtime.NetworkHelper);
            _ = typeof(GameFrameX.Runtime.NewtonsoftJsonHelper);
            _ = typeof(GameFrameX.Runtime.ObjectHelper);
            _ = typeof(GameFrameX.Runtime.ObjectPoolComponent);
            _ = typeof(GameFrameX.Runtime.PathHelper);
            _ = typeof(GameFrameX.Runtime.PlayerPrefsSettingHelper);
            _ = typeof(GameFrameX.Runtime.PlaySoundInfo);
            _ = typeof(GameFrameX.Runtime.PositionHelper);
            _ = typeof(GameFrameX.Runtime.ProcedureComponent);
            _ = typeof(GameFrameX.Runtime.RandomHelper);
            _ = typeof(GameFrameX.Runtime.ReferencePoolComponent);
            _ = typeof(GameFrameX.Runtime.ReferenceStrictCheckType);
            _ = typeof(GameFrameX.Runtime.ResponseGameAppVersion);
            _ = typeof(GameFrameX.Runtime.ResponseGlobalInfo);
            _ = typeof(GameFrameX.Runtime.SceneComponent);
            _ = typeof(GameFrameX.Runtime.SequenceReader<>);
            _ = typeof(GameFrameX.Runtime.SequenceReaderExtensions);
            _ = typeof(GameFrameX.Runtime.SettingComponent);
            _ = typeof(GameFrameX.Runtime.SettingHelperBase);
            _ = typeof(GameFrameX.Runtime.ShowEntityInfo);
            _ = typeof(GameFrameX.Runtime.ShutdownType);
            _ = typeof(GameFrameX.Runtime.SoundAgentHelperBase);
            _ = typeof(GameFrameX.Runtime.SoundComponent);
            _ = typeof(GameFrameX.Runtime.SoundGroupHelperBase);
            _ = typeof(GameFrameX.Runtime.SoundHelperBase);
            _ = typeof(GameFrameX.Runtime.StringHelper);
            _ = typeof(GameFrameX.Runtime.TimerComponent);
            _ = typeof(GameFrameX.Runtime.UILayer);
            _ = typeof(GameFrameX.Runtime.UnityRendererHelper);
            _ = typeof(GameFrameX.Runtime.UnityWebRequestDownloadAgentHelper);
            _ = typeof(GameFrameX.Runtime.VarBoolean);
            _ = typeof(GameFrameX.Runtime.VarByte);
            _ = typeof(GameFrameX.Runtime.VarByteArray);
            _ = typeof(GameFrameX.Runtime.VarChar);
            _ = typeof(GameFrameX.Runtime.VarCharArray);
            _ = typeof(GameFrameX.Runtime.VarColor);
            _ = typeof(GameFrameX.Runtime.VarColor32);
            _ = typeof(GameFrameX.Runtime.VarDateTime);
            _ = typeof(GameFrameX.Runtime.VarDecimal);
            _ = typeof(GameFrameX.Runtime.VarDouble);
            _ = typeof(GameFrameX.Runtime.VarGameObject);
            _ = typeof(GameFrameX.Runtime.VarInt16);
            _ = typeof(GameFrameX.Runtime.VarInt32);
            _ = typeof(GameFrameX.Runtime.VarInt64);
            _ = typeof(GameFrameX.Runtime.VarMaterial);
            _ = typeof(GameFrameX.Runtime.VarObject);
            _ = typeof(GameFrameX.Runtime.VarQuaternion);
            _ = typeof(GameFrameX.Runtime.VarRect);
            _ = typeof(GameFrameX.Runtime.VarSByte);
            _ = typeof(GameFrameX.Runtime.VarSingle);
            _ = typeof(GameFrameX.Runtime.VarString);
            _ = typeof(GameFrameX.Runtime.VarTexture);
            _ = typeof(GameFrameX.Runtime.VarTransform);
            _ = typeof(GameFrameX.Runtime.VarUInt16);
            _ = typeof(GameFrameX.Runtime.VarUInt32);
            _ = typeof(GameFrameX.Runtime.VarUInt64);
            _ = typeof(GameFrameX.Runtime.VarUnityObject);
            _ = typeof(GameFrameX.Runtime.VarVector2);
            _ = typeof(GameFrameX.Runtime.VarVector3);
            _ = typeof(GameFrameX.Runtime.VarVector4);
            _ = typeof(GameFrameX.Runtime.WebComponent);
            _ = typeof(GameFrameX.Runtime.ZipHelper);
            _ = typeof(GameFrameX.Scene.ActiveSceneChangedEventArgs);
            _ = typeof(GameFrameX.Scene.GameSceneManager);
            _ = typeof(GameFrameX.Scene.IGameSceneManager);
            _ = typeof(GameFrameX.Scene.LoadSceneFailureEventArgs);
            _ = typeof(GameFrameX.Scene.LoadSceneSuccessEventArgs);
            _ = typeof(GameFrameX.Scene.LoadSceneUpdateEventArgs);
            _ = typeof(GameFrameX.Scene.UnloadSceneFailureEventArgs);
            _ = typeof(GameFrameX.Scene.UnloadSceneSuccessEventArgs);
            _ = typeof(GameFrameX.Setting.ISettingHelper);
            _ = typeof(GameFrameX.Setting.ISettingManager);
            _ = typeof(GameFrameX.Setting.SettingManager);
            _ = typeof(GameFrameX.Sound.Constant);
            _ = typeof(GameFrameX.Sound.ISoundAgent);
            _ = typeof(GameFrameX.Sound.ISoundAgentHelper);
            _ = typeof(GameFrameX.Sound.ISoundGroup);
            _ = typeof(GameFrameX.Sound.ISoundGroupHelper);
            _ = typeof(GameFrameX.Sound.ISoundHelper);
            _ = typeof(GameFrameX.Sound.ISoundManager);
            _ = typeof(GameFrameX.Sound.PlaySoundErrorCode);
            _ = typeof(GameFrameX.Sound.PlaySoundFailureEventArgs);
            _ = typeof(GameFrameX.Sound.PlaySoundParams);
            _ = typeof(GameFrameX.Sound.PlaySoundSuccessEventArgs);
            _ = typeof(GameFrameX.Sound.PlaySoundUpdateEventArgs);
            _ = typeof(GameFrameX.Sound.ResetSoundAgentEventArgs);
            _ = typeof(GameFrameX.Sound.SoundManager);
            _ = typeof(GameFrameX.StartTaskStatus);
            _ = typeof(GameFrameX.TaskBase);
            _ = typeof(GameFrameX.TaskInfo);
            _ = typeof(GameFrameX.TaskPool<>);
            _ = typeof(GameFrameX.TaskStatus);
            _ = typeof(GameFrameX.Timer.ITimerManager);
            _ = typeof(GameFrameX.Timer.TimerManager);
            _ = typeof(GameFrameX.TypeNamePair);
            _ = typeof(GameFrameX.UI.CloseUIFormCompleteEventArgs);
            _ = typeof(GameFrameX.UI.IUIForm);
            _ = typeof(GameFrameX.UI.IUIFormHelper);
            _ = typeof(GameFrameX.UI.IUIGroup);
            _ = typeof(GameFrameX.UI.IUIGroupHelper);
            _ = typeof(GameFrameX.UI.IUIManager);
            _ = typeof(GameFrameX.UI.OpenUIFormDependencyAssetEventArgs);
            _ = typeof(GameFrameX.UI.OpenUIFormFailureEventArgs);
            _ = typeof(GameFrameX.UI.OpenUIFormSuccessEventArgs);
            _ = typeof(GameFrameX.UI.OpenUIFormUpdateEventArgs);
            _ = typeof(GameFrameX.UI.UIManager);
            _ = typeof(GameFrameX.Utility);
            _ = typeof(GameFrameX.Utility.Assembly);
            _ = typeof(GameFrameX.Utility.Asset);
            _ = typeof(GameFrameX.Utility.Asset.Path);
            _ = typeof(GameFrameX.Utility.Compression);
            _ = typeof(GameFrameX.Utility.Compression.ICompressionHelper);
            _ = typeof(GameFrameX.Utility.Const);
            _ = typeof(GameFrameX.Utility.Const.FileNameSuffix);
            _ = typeof(GameFrameX.Utility.Converter);
            _ = typeof(GameFrameX.Utility.Encryption);
            _ = typeof(GameFrameX.Utility.Encryption.Aes);
            _ = typeof(GameFrameX.Utility.Encryption.Dsa);
            _ = typeof(GameFrameX.Utility.Encryption.Rsa);
            _ = typeof(GameFrameX.Utility.File);
            _ = typeof(GameFrameX.Utility.Hash);
            _ = typeof(GameFrameX.Utility.Hash.HMACSha256);
            _ = typeof(GameFrameX.Utility.Hash.MD5);
            _ = typeof(GameFrameX.Utility.Hash.MurmurHash3);
            _ = typeof(GameFrameX.Utility.Hash.Sha1);
            _ = typeof(GameFrameX.Utility.Hash.XXHash);
            _ = typeof(GameFrameX.Utility.Json);
            _ = typeof(GameFrameX.Utility.Json.IJsonHelper);
            _ = typeof(GameFrameX.Utility.Marshal);
            _ = typeof(GameFrameX.Utility.Net);
            _ = typeof(GameFrameX.Utility.Object);
            _ = typeof(GameFrameX.Utility.Path);
            _ = typeof(GameFrameX.Utility.Random);
            _ = typeof(GameFrameX.Utility.Text);
            _ = typeof(GameFrameX.Utility.Text.ITextHelper);
            _ = typeof(GameFrameX.Utility.Verifier);
            _ = typeof(GameFrameX.Utility.Verifier.Crc64);
            _ = typeof(GameFrameX.Utility.Verifier.NonCryptographicHashAlgorithm);
            _ = typeof(GameFrameX.Variable);
            _ = typeof(GameFrameX.Variable<>);
            _ = typeof(GameFrameX.Version);
            _ = typeof(GameFrameX.Version.IVersionHelper);
            _ = typeof(GameFrameX.Web.IWebManager);
            _ = typeof(GameFrameX.Web.WebManager);
            _ = typeof(GameMain.DefaultNetworkChannelHelper);
            _ = typeof(Server.Utility.ThreadLocalRandom);
            _ = typeof(SpanExtension);
            _ = typeof(StringExtension);
            _ = typeof(System.Collections.Generic.BidirectionalDictionary<,>);
            _ = typeof(System.Collections.Generic.CollectionExtensions);
            _ = typeof(System.DateTimeExtensions);
            _ = typeof(System.TypeExtensions);
            _ = typeof(UnityEngageGameObjectExtension);
            _ = typeof(UnityEngineTransformExtension);
            _ = typeof(UnityEngineVector2Extension);
            _ = typeof(UnityEngineVector3Extension);
        }
    }
}