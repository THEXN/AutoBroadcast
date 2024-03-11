using System.IO;
using System.Xml;
using AutoBroadcast;
using Newtonsoft.Json;

public class ABConfig
{
    public Broadcast[] Broadcasts = new Broadcast[0];

    public ABConfig Write(string file)
    {
        File.WriteAllText(file, JsonConvert.SerializeObject((object)this, (Formatting)1));
        return this;
    }

    public static ABConfig Read(string file)
    {
        if (!File.Exists(file))
        {
            WriteExample(file);
        }
        return JsonConvert.DeserializeObject<ABConfig>(File.ReadAllText(file));
    }

    public static void WriteExample(string file)
    {
        Broadcast broadcast = new Broadcast();
        broadcast.Name = "示例广播";
        broadcast.Enabled = false;
        broadcast.Messages = new string[4] { "这是一个广播示例", "每5分钟播出一次", "广播也可以执行命令", "/time noon" };
        broadcast.ColorRGB = new float[3] { 255f, 0f, 0f };
        broadcast.Interval = 300;
        broadcast.StartDelay = 60;
        Broadcast broadcast2 = broadcast;
        ABConfig aBConfig = new ABConfig();
        aBConfig.Broadcasts = new Broadcast[1] { broadcast2 };
        ABConfig aBConfig2 = aBConfig;
        aBConfig2.Write(file);
    }
}