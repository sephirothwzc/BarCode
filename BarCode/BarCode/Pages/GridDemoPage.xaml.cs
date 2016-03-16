using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BarCode.Pages
{
    public partial class GridDemoPage : ContentPage
    {
        public GridDemoPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing(); 
            datagrid.Rows = new ObservableCollection<object>
            {
                new SampleObject
                {
                    SampleName = "张三",
                    SampleDescription = "Shows images, dates. Includes headers and a frozen column.",
                    //OpenCode = () => { return new PresidentsCode(); },
                    //OpenXaml = () => { return new PresidentsXaml(); },
                },
                new SampleObject
                {
                    SampleName = "李四",
                    SampleDescription = "Lots of rows. Unicode text.",
                    //OpenCode = () => { return new CountriesCode(); },
                    //OpenXaml = () => { return new CountriesXaml(); },
                },
                new SampleObject
                {
                    SampleName = "王五",
                    SampleDescription = "Dynamic generation of one million 'virtual' rows.",
                    //OpenCode = () => { return new DynamicCode(); },
                    //OpenXaml = () => { return new DynamicXaml(); },
                },
                new SampleObject
                {
                    SampleName = "赵六",
                    SampleDescription = "Includes slider controls with two way binding.",
                    //OpenCode = () => { return new XSquaredCode(); },
                    //OpenXaml = () => { return new XSquaredXaml(); },
                },
            };
            for (int i = 0; i < 100; i++)
            {
                datagrid.Rows.Add(new SampleObject
                {
                    SampleName = "赵六",
                    SampleDescription = "Includes slider controls with two way binding.",
                    //OpenCode = () => { return new XSquaredCode(); },
                    //OpenXaml = () => { return new XSquaredXaml(); },
                });
            }
        }
        class SampleObject
        {
            public string SampleName { get; set; }
            public string SampleDescription { get; set; }

            //public Func<Page> OpenCode { get; set; }
            //public Func<Page> OpenXaml { get; set; }

        }
    }
}
