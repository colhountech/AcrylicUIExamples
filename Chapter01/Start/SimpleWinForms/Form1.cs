namespace SimpleWinForms
{
    public partial class Form1 : Form
    {
        public MainViewModel MainViewModel { get; set; }
        public Form1()
        {
          
            InitializeComponent();

            MainViewModel = new MainViewModel { Name = "Test" };
            mainViewModelBindingSource.DataSource = MainViewModel;

        }

    }
}
