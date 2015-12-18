using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace App9
{
    public sealed partial class PeopleLine : UserControl
    {
        public static readonly DependencyProperty PeopleListProperty = DependencyProperty.Register("PeopleList", typeof(List<PeopleModel>), typeof(PeopleLine), new PropertyMetadata(default(List<PeopleModel>)));

        public static readonly DependencyProperty PeopleModelsProperty = DependencyProperty.Register(
            "PeopleModels", typeof (List<PeopleModel>), typeof (PeopleLine), new PropertyMetadata(default(List<PeopleModel>)));

        public List<PeopleModel> PeopleList
        {
            get { return (List<PeopleModel>)GetValue(PeopleListProperty); }
            set { SetValue(PeopleListProperty, value); }
        }

        public PeopleLine()
        {
            this.InitializeComponent();

            //(this.Content as FrameworkElement).DataContext = this;
        }
    }

    public class PeopleModel
    {
        public string Name { get; set; }

        public PeopleModel(string name)
        {
            Name = name;
        }
    }
}
