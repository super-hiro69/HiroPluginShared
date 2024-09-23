using Hiro.Plugin.Services;

namespace Hiro.Plugin.Modelviews
{
    public interface IHiroPlugin
    {
        /// <summary>
        /// 唯一标识符, 格式: com.domain.application.branch
        /// </summary>
        string? Id { get; }
        /// <summary>
        /// 作者, 格式: 任意文本, 256 字符以内
        /// </summary>
        string? Author { get; }
        /// <summary>
        /// 图标文件存放位置, 相对于 system/plugins/packageName/
        /// </summary>
        string? Icon { get; }
        /// <summary>
        /// 版本号
        /// </summary>
        HiroVersion? Version { get; }
        /// <summary>
        /// 是否允许自动加载, 允许自动加载且用户启用的插件将会在 Hiro 启动时自动加载
        /// </summary>
        bool? RunWithHiro {  get; }
        /// <summary>
        /// 是否在独立环境运行, 建议大型程序或资源占用较高的程序在独立环境运行, 以免造成主程序闪退
        /// </summary>
        bool? IsolateRun { get; }
        /// <summary>
        /// 基于当前语言获取名称
        /// </summary>
        /// <param name="language">当前语言代码</param>
        /// <returns></returns>
        string? GetName(string language);
        /// <summary>
        /// 基于当前语言获取描述
        /// </summary>
        /// <param name="language">当前语言代码</param>
        /// <returns></returns>
        string? GetDescription(string language);
        /// <summary>
        /// 插件首次被加载会触发此事件
        /// </summary>
        void FirstRun();
        /// <summary>
        /// 插件被更新后会触发此事件
        /// </summary>
        void UpdatedRun();
        void Initialize(IHiroService hostService); // 初始化插件并传递主程序服务
        /// <summary>
        /// 主程序传递的请求方法, 正常请求完整请返回 'success'
        /// </summary>
        /// <param name="input">输入的 URL 或文件名</param>
        /// <param name="para">额外附加的部分参数</param>
        /// <returns></returns>
        string? HiroWeGo(string input, List<object>? para);
        /// <summary>
        /// 主程序发出的系统消息, 类如 用户登出, 用户名改变等
        /// </summary>
        /// <param name="procID">消息 ID</param>
        /// <param name="para">额外附加的部分参数</param>
        /// <returns></returns>
        bool? HiroWndProc(int procID, List<object>? para);
        /// <summary>
        /// 释放所有资源, 卸载插件
        /// </summary>
        /// <returns></returns>
        bool? Dispose();
    }
}
