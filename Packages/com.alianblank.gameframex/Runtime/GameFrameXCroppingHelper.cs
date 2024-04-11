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

            _ = typeof(GameFrameX.BaseEventArgs);


            _ = typeof(GameFrameX.EventPool<>);
            _ = typeof(GameFrameX.EventPoolMode);

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


            _ = typeof(GameFrameX.ObjectPool.IObjectPool<>);
            _ = typeof(GameFrameX.ObjectPool.IObjectPoolManager);
            _ = typeof(GameFrameX.ObjectPool.ObjectBase);
            _ = typeof(GameFrameX.ObjectPool.ObjectInfo);
            _ = typeof(GameFrameX.ObjectPool.ObjectPoolBase);
            _ = typeof(GameFrameX.ObjectPool.ObjectPoolManager);
            _ = typeof(GameFrameX.ObjectPool.ReleaseObjectFilterCallback<>);

            _ = typeof(GameFrameX.ReferencePool);
            _ = typeof(GameFrameX.ReferencePoolInfo);
            _ = typeof(GameFrameX.Runtime.ApplicationHelper);
            _ = typeof(GameFrameX.Runtime.BaseComponent);
            _ = typeof(GameFrameX.Runtime.CameraHelper);
            // _ = typeof(GameFrameX.Runtime.ConfigHelperBase);

            _ = typeof(GameFrameX.Runtime.DefaultCompressionHelper);


            _ = typeof(GameFrameX.Runtime.DefaultLogHelper);


            _ = typeof(GameFrameX.Runtime.DefaultTextHelper);
            _ = typeof(GameFrameX.Runtime.DefaultVersionHelper);
            _ = typeof(GameFrameX.Runtime.DistinctHelper);
            _ = typeof(GameFrameX.Runtime.DoTweenHelper);

            _ = typeof(GameFrameX.Runtime.FileHelper);


            _ = typeof(GameFrameX.Runtime.GameEntry);
            _ = typeof(GameFrameX.Runtime.GameFrameworkComponent);
            _ = typeof(GameFrameX.Runtime.GameFrameXCroppingHelper);
            _ = typeof(GameFrameX.Runtime.GameObjectHelper);
            _ = typeof(GameFrameX.Runtime.GameTimeHelper);
            _ = typeof(GameFrameX.Runtime.Helper);

            _ = typeof(GameFrameX.Runtime.Log);
            _ = typeof(GameFrameX.Runtime.LuaComponent);
            _ = typeof(GameFrameX.Runtime.MathHelper);

            _ = typeof(GameFrameX.Runtime.NetworkHelper);
            _ = typeof(GameFrameX.Runtime.NewtonsoftJsonHelper);
            _ = typeof(GameFrameX.Runtime.ObjectHelper);
            _ = typeof(GameFrameX.Runtime.ObjectPoolComponent);
            _ = typeof(GameFrameX.Runtime.PathHelper);

            _ = typeof(GameFrameX.Runtime.PositionHelper);
            _ = typeof(GameFrameX.Runtime.RandomHelper);
            _ = typeof(GameFrameX.Runtime.ReferencePoolComponent);
            _ = typeof(GameFrameX.Runtime.ReferenceStrictCheckType);


            _ = typeof(GameFrameX.Runtime.SequenceReader<>);
            _ = typeof(GameFrameX.Runtime.SequenceReaderExtensions);


            _ = typeof(GameFrameX.Runtime.ShutdownType);

            _ = typeof(GameFrameX.Runtime.UnityRendererHelper);
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
            _ = typeof(GameFrameX.Runtime.ZipHelper);

            _ = typeof(GameFrameX.StartTaskStatus);
            _ = typeof(GameFrameX.TaskBase);
            _ = typeof(GameFrameX.TaskInfo);
            _ = typeof(GameFrameX.TaskPool<>);
            _ = typeof(GameFrameX.TaskStatus);
            _ = typeof(GameFrameX.TypeNamePair);

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