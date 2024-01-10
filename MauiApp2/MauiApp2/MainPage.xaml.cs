namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        public int ColumnCount { get; set; } = 3;
        private void UpdateColumnCount(object sender, EventArgs e)
        {
            ColumnCount++;
            Dispatcher.Dispatch(() =>
            {
                OnPropertyChanged("ColumnCount");
            });
        }
    }

}
