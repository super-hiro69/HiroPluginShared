using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiro.Plugin.Services
{
    public interface IHiroService
    {
        void Log(string message, string? source);
        string GetData(string key, List<object>? param);
        bool RunExe(string path, string? source);
    }
}
