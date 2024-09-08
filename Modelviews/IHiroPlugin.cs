using Hiro.Plugin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiro.Plugin.Modelviews
{
    public interface IHiroPlugin
    {
        string Id { get; } // 唯一标识符
        string Author { get; } // 作者
        string GetName(string language); // 根据语言返回插件名称
        string GetDescription(string language); // 根据语言返回插件描述
        void Initialize(IHiroService hostService); // 初始化插件并传递主程序服务
        string HiroWeGo(string input, List<object>? para); // 处理请求的方法

        bool Dispose();//释放所有资源, 卸载插件
    }
}
