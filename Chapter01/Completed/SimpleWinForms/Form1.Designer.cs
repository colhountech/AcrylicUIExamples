using AcrylicUI.Controls;

namespace SimpleWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblName = new AcrylicLabel();
            txtName = new AcrylicTextBox();
            lblOutput = new AcrylicLabel();
            mainViewModelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)mainViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(12, 8);
            lblName.Margin = new Padding(1, 0, 1, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.DataBindings.Add(new Binding("Text", mainViewModelBindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(84, 8);
            txtName.Margin = new Padding(1);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter Your Name";
            txtName.Size = new Size(186, 25);
            txtName.TabIndex = 1;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(12, 32);
            lblOutput.Margin = new Padding(1, 0, 1, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(52, 20);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "Watch This Text";
            //
            // mainViewModelBindingSource
            //
            mainViewModelBindingSource.DataSource = typeof(MainViewModel);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(280, 141);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblOutput);
            Margin = new Padding(1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)mainViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AcrylicLabel lblName;
        private AcrylicTextBox txtName;
        private AcrylicLabel lblOutput;
        private BindingSource mainViewModelBindingSource;
    }
}
