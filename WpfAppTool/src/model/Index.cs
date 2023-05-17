using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAppTool.src.entity;

namespace WpfAppTool.src.model
{
    public partial class Index: ObservableObject
    {
        [ObservableProperty]
        public List<BroadSide> broadsideList=new();

        public Index() {
            initBroadside();
        }
        public void initBroadside() {
            BroadSide bs = new BroadSide();
            bs.name = "首页";
            BroadsideList.Add(bs);

        }

        [RelayCommand]
        private void Test()
        {
            MessageBox.Show("展示数据");
        }
    }
}
