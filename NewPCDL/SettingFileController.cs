using System.IO;
using Newtonsoft.Json;

namespace NewPCDL
{
    class SettingFileController
    {
        // 读取设定文件
        internal static TaobaoApiSetting ReadSettingFile()
        {
            try
            {
                TaobaoApiSetting set = JsonConvert.DeserializeObject<TaobaoApiSetting>(File.ReadAllText(@"setting.json"));
                return set;
            }
            catch (FileNotFoundException fnfe)
            {
                fnfe.ToString();
                return createEmptySettingFile();
            }
            // 读取错误 例如不是json格式
            catch (JsonSerializationException jse)
            {
                jse.ToString();
                return createEmptySettingFile();
            }
        }

        private static TaobaoApiSetting createEmptySettingFile()
        {
            using (StreamWriter file = File.CreateText(@"setting.json"))
            {
                TaobaoApiSetting set = new TaobaoApiSetting();
                set.ApiUrl = "";
                set.AppKey = "";
                set.Secret = "";
                set.SessionKey = "";
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, set);
                return set;
            }
        }
    }
}
