using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App9
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var peopleList = new List<PeopleModel>
            {
                new PeopleModel("Hello"),
                new PeopleModel("Hi"),
                new PeopleModel("Hey")
            };

            var peopleList2 = new List<PeopleModel>
            {
                new PeopleModel("More"),
                new PeopleModel("Names"),
            };

            var list = new PeopleList(peopleList);
            var list2 = new PeopleList(peopleList2);

            this.DataContext = new MainPageVm(new List<PeopleList> { list, list2});
        }
    }

    public class MainPageVm
    {
        public List<PeopleList> LinePeopleList { get; set; }

        public MainPageVm(List<PeopleList> people)
        {
            LinePeopleList = people;
        }
    }

    public class PeopleList
    {
        public List<PeopleModel> People { get; set; }

        public PeopleList(List<PeopleModel> linePeopleList)
        {
            People = linePeopleList;
        }
    }
}
