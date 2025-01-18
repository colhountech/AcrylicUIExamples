using AcrylicUI.Forms;
using AcrylicUI.Resources;

namespace SimpleWinForms
{
    public partial class Form1 : AcrylicForm
    {
        public MainViewModel MainViewModel { get; set; }
        public Form1()
        {
          
            InitializeComponent();

            MainViewModel = new MainViewModel { Name = "Test" };
            MainViewModel.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == nameof(MainViewModel.Name))
                {
                    lblOutput.Text = MainViewModel.Name;
                }
            };
            mainViewModelBindingSource.DataSource = MainViewModel;
            // AcrylicUI
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Colors.GreyBackground;
            IsAcrylic = true;
  

        }

    }
}
