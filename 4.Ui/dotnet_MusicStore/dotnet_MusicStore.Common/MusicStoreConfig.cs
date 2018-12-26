using dotnet_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_MusicStore.Common
{
    public class MusicStoreConfig : ConfigurationBase
    {
        public MusicStoreConfig(IConfigurationProvider provider)
            : base(provider)
        {
            Initialize();
        }

        public int ExceptionBeforeCircuit { get; set; }
        public TimeSpan DurationOfBreak { get; set; }
        public TimeSpan TimeoutValue { get; set; }
        public string RedisConnStr { get; set; }
        public int RedisDbIndex { get; set; }
        public object RedisAsyncObject { get; set; }
        public string ConnStr { get; set; }


        public string MkUrl { get; set; }
        public string JmUrl { get; set; }

        public string AccessKeyId { get; set; }
        public string AccessKeySecret { get; set; }

        public override void Initialize()
        {
            #region 初始化Redis配置
            RedisConnStr = getString("RedisConfig:Conn");
            RedisDbIndex = getInteger("RedisConfig:DbIndex", -1);
            RedisAsyncObject = new object();
            #endregion

            ExceptionBeforeCircuit = getInteger("CircuitPolicy:ExceptionBeforeCircuit", 3);
            DurationOfBreak = TimeSpan.FromMilliseconds(getInteger("CircuitPolicy:DurationOfBreak", 3000));
            TimeoutValue = TimeSpan.FromMilliseconds(getInteger("CircuitPolicy:TimeOutValue", 3000));
            ConnStr = getString("DbConnects:ConnStr");

            MkUrl = getString("Url:MkUrl");
            JmUrl = getString("Url:JmUrl");

            AccessKeyId = getString("QRCodeInterfaceConfig:AccessKeyId");
            AccessKeySecret = getString("QRCodeInterfaceConfig:AccessKeySecret");
        }


    }
}
