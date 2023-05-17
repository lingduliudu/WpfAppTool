using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTool.src.entity
{
    // 侧边工具
    public partial class BroadSide: ObservableObject
    {
        [ObservableProperty]
        public string name;
        [ObservableProperty]
        public string imageUrl;
        [ObservableProperty]
        public int sort;
    }
}
