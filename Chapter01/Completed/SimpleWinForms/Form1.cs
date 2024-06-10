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
            mainViewModelBindingSource.DataSource = MainViewModel;
            // AcrylicUI
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Colors.GreyBackground;
            IsAcrylic = true;
  

        }

    }
}
