using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        MainModel vm;
        public MainWindow()
        {
            vm = new MainModel();
            this.DataContext = vm;
            vm.ListItem = new ObservableCollection<TestModel>()
            {
                new TestModel(){Column1="123"},
                new TestModel(){Column1="456"},
                new TestModel(){Column1="789"},
            };
        }
        public class MainModel : ViewModelBase
        {
            ObservableCollection<TestModel> _ListItem;

            public ObservableCollection<TestModel> ListItem { get => _ListItem; set { UpdateProper(ref _ListItem, value); } }
        }
        public class TestModel : ViewModelBase
        {
            string column1;
            string column2;
            bool column3;

            public string Column1 { get => column1; set { UpdateProper(ref column1, value); } }
            public string Column2 { get => column2; set { UpdateProper(ref column2, value); } }
            public bool Column3 { get => column3; set { UpdateProper(ref column3, value); } }
        }
    }
}