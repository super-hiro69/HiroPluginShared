using Hiro.Plugin.Modelviews;

namespace Hiro.Plugin.Services
{
    public interface IHiroService
    {
        /// <summary>
        /// 输出日志内容到日志文件
        /// </summary>
        /// <param name="message">日志文本</param>
        /// <param name="source">来源</param>
        void Log(string message, string? source = null);
        /// <summary>
        /// 输出错误信息到日志文件
        /// </summary>
        /// <param name="ex">错误信息</param>
        /// <param name="Module">模块名称, 方便定位错误</param>
        void LogError(Exception ex, string Module);
        /// <summary>
        /// 获取指定 Key 值的数据
        /// </summary>
        /// <param name="key">Key 值</param>
        /// <param name="param">附加参数</param>
        /// <returns></returns>
        List<object>? GetData(string key, List<object>? param = null);
        /// <summary>
        /// 调用主程序运行文件
        /// </summary>
        /// <param name="path">运行路径</param>
        /// <param name="source">来源</param>
        /// <returns></returns>
        bool? RunExe(string path, string? source);
        /// <summary>
        /// 关联指定协议或拓展名到插件
        /// </summary>
        /// <param name="protocol">协议或拓展名, 示例: "https:", ".txt"</param>
        /// <param name="RunParam">运行方式, 示例: "hiro(%1)"</param>
        /// <returns></returns>
        bool? Link(string protocol, string RunParam);
        /// <summary>
        /// 托管主程序发送通知
        /// </summary>
        /// <param name="i">要发送的通知内容</param>
        void Notify(Hiro_Notice i);
        /// <summary>
        /// 读取设置内容
        /// </summary>
        /// <param name="Section">设置节标题</param>
        /// <param name="Key">设置键</param>
        /// <param name="defaultText">默认内容</param>
        /// <returns></returns>
        string ReadConfig(string Section,string Key, string defaultText);
    }
}
