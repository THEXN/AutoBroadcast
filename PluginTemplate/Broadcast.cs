using Newtonsoft.Json;

public class Broadcast
{
    [JsonProperty("名称")]
    public string Name { get; set; } = string.Empty;
    [JsonProperty("是否启用")]
    public bool Enabled { get; set; } = false;
    [JsonProperty("消息列表")]
    public string[] Messages { get; set; } = new string[0];
    [JsonProperty("颜色RGB")]
    public float[] ColorRGB { get; set; } = new float[3];
    [JsonProperty("间隔时间")]
    public int Interval { get; set; } = 0;
    [JsonProperty("延迟时间")]
    public int StartDelay { get; set; } = 0;
    [JsonProperty("触发区域")]
    public string[] TriggerRegions { get; set; } = new string[0];
    [JsonProperty("区域触发器")]
    public string RegionTrigger { get; set; } = "none";
    [JsonProperty("组")]
    public string[] Groups { get; set; } = new string[0];
    [JsonProperty("触发词")]
    public string[] TriggerWords { get; set; } = new string[0];
    [JsonProperty("是否触发整个组")]
    public bool TriggerToWholeGroup { get; set; } = false;
}