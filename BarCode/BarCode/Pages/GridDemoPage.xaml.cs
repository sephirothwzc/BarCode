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
		/// 添加一行
		/// </summary>
		/// <returns>The clicked.</returns>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			this.datagrid.Rows.Add(new SampleObject
			{
				SampleName = string.Format("我是第{0}行",this.datagrid.Rows.Count),
				SampleDescription = "XXXXXXXXX",
				OpenCode = () => {return new BarCode.Pages.Receipt.PoAPage();}

			});
		}

		/// <summary>
		/// 姓名点击弹出新窗体
		/// </summary>
		/// <returns>The code button clicked.</returns>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		void OnCodeButtonClicked(object sender, EventArgs args)
		{

			Button button = (Button)sender;
			var tpage = ((SampleObject)button.BindingContext).OpenCode();
			tpage.Title = ((SampleObject)button.BindingContext).SampleName;
			Navigation.PushAsync(tpage);

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
					OpenCode = () => {return new BarCode.Pages.Receipt.PoAPage();}
                    //OpenCode = () => { return new PresidentsCode(); },
                    //OpenXaml = () => { return new PresidentsXaml(); },
                },
                new SampleObject
                {
                    SampleName = "李四",
                    SampleDescription = "Lots of rows. Unicode text.",
					OpenCode = () => {return new BarCode.Pages.Receipt.PoAPage();}
                    //OpenCode = () => { return new CountriesCode(); },
                    //OpenXaml = () => { return new CountriesXaml(); },
                },
                new SampleObject
                {
                    SampleName = "王五三",
                    SampleDescription = "Dynamic generation",
					OpenCode = () => {return new BarCode.Pages.Receipt.PoAPage();}
                    //OpenCode = () => { return new DynamicCode(); },
                    //OpenXaml = () => { return new DynamicXaml(); },
                },
                new SampleObject
                {
                    SampleName = "赵六",
                    SampleDescription = "Includes slider controls with two way binding.",
					OpenCode = () => {return new BarCode.Pages.Receipt.PoAPage();}
                    //OpenCode = () => { return new XSquaredCode(); },
                    //OpenXaml = () => { return new XSquaredXaml(); },
                },
            };

            //this.datagrid.Columns[0].Width = this.datagrid.Rows.Max(x => ((SampleObject)x).SampleName.Length) * 20;
            //this.datagrid.Columns[1].Width = this.datagrid.Rows.Max(x => ((SampleObject)x).SampleDescription.Length) * 20;
            //for (int i = 0; i < this.datagrid.Columns.Count(); i++)
            //{
            //    this.datagrid.Columns[i].Width = this.datagrid.Rows.Max(x => CommonCLR.BaseModel.GetPropertyValueLenth(x, this.datagrid.Columns[i].BindingContext.ToString()));
            //}
            /*
            for (int i = 0; i < 100; i++)
            {
                datagrid.Rows.Add(new SampleObject
                {
                    SampleName = "赵六",
                    SampleDescription = "Includes slider controls with two way binding.",
					OpenCode = () => {return new BarCode.Pages.Receipt.PoAPage();}
                    //OpenCode = () => { return new XSquaredCode(); },
                    //OpenXaml = () => { return new XSquaredXaml(); },
                });
            }
            */
        }
        class SampleObject
        {
            public string SampleName { get; set; }
            public string SampleDescription { get; set; }

            public Func<Page> OpenCode { get; set; }
            //public Func<Page> OpenXaml { get; set; }

        }
    }
}
