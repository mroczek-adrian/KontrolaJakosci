using System.Collections.ObjectModel;
using System.Windows.Automation;
using System.Windows.Controls;

namespace WpfTestApplication
{
    public partial class ListViewWindow
    {
        private readonly ObservableCollection<ListViewData> listViewItems;
        private readonly ObservableCollection<ListViewData> listViewItemsWitScroll;

        public ListViewWindow()
        {
            DataContext = this;
            listViewItems = new ObservableCollection<ListViewData>
            {
                new ListViewData("Search", "Google"),
                new ListViewData("Mail", "GMail"),
                new ListViewData("Picture", "Piccasa"),
                new ListViewData("Action1", "App1"),
                new ListViewData("Action2", "App2"),
                new ListViewData("Action3", "App3"),
                new ListViewData("Action4", "App4"),
                new ListViewData("Action5", "App5"),
                new ListViewData("Action6", "App6"),
                new ListViewData("Action7", "App7"),
                new ListViewData("Action8", "App8"),
                new ListViewData("Action9", "App9"),
                new ListViewData("Action10", "App10"),
                new ListViewData("Action11", "App11"),
                new ListViewData("Action12", "App12"),
                new ListViewData("Action13", "App13"),
                new ListViewData("Action14", "App14"),
                new ListViewData("Action15", "App15")
            };
            listViewItemsWitScroll = new ObservableCollection<ListViewData>
            {
                new ListViewData("baz", null),
                new ListViewData("bardfgreerrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrre", null)
            }; 
            InitializeComponent();
        }

        public ObservableCollection<ListViewData> ListViewItems
        {
            get { return listViewItems; }
        }

        public ObservableCollection<ListViewData> ListViewItemsWithScroll
        {
            get { return listViewItemsWitScroll; }
        }

        private void ListViewOnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AutomationProperties.SetHelpText(ListView, "ListView item selected - " + ListView.SelectedIndex);
        }
    }
}
