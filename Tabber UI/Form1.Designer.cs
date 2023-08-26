namespace Tabber_UI
{
    partial class Form
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
            tabberButton1 = new unvell.ReoGrid.Editor.Custom_Control.FluentButtons.TabberButton();
            tabberPanel1 = new unvell.ReoGrid.Editor.Custom_Control.FluentPanel.TabberPanel();
            tabberTextBox1 = new TabberTextBox.TabberTextBox();
            SuspendLayout();
            // 
            // tabberButton1
            // 
            tabberButton1.BackColor = Color.FromArgb(251, 251, 251);
            tabberButton1.BackgroundColor = Color.FromArgb(251, 251, 251);
            tabberButton1.BorderColor = Color.FromArgb(229, 229, 229);
            tabberButton1.BorderRadius = 5;
            tabberButton1.BorderSize = 1;
            tabberButton1.FlatAppearance.BorderSize = 0;
            tabberButton1.FlatStyle = FlatStyle.Flat;
            tabberButton1.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tabberButton1.ForeColor = Color.FromArgb(27, 27, 27);
            tabberButton1.Location = new Point(12, 12);
            tabberButton1.Name = "tabberButton1";
            tabberButton1.Size = new Size(188, 50);
            tabberButton1.TabIndex = 0;
            tabberButton1.Text = "tabberButton1";
            tabberButton1.TextColor = Color.FromArgb(27, 27, 27);
            tabberButton1.UseVisualStyleBackColor = false;
            // 
            // tabberPanel1
            // 
            tabberPanel1.BackColor = Color.FromArgb(251, 251, 251);
            tabberPanel1.BackgroundColor = Color.FromArgb(251, 251, 251);
            tabberPanel1.BorderColor = Color.FromArgb(229, 229, 229);
            tabberPanel1.BorderRadius = 5;
            tabberPanel1.BorderSize = 1;
            tabberPanel1.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tabberPanel1.ForeColor = Color.FromArgb(27, 27, 27);
            tabberPanel1.Location = new Point(206, 12);
            tabberPanel1.Name = "tabberPanel1";
            tabberPanel1.Size = new Size(188, 50);
            tabberPanel1.TabIndex = 1;
            tabberPanel1.TextColor = Color.FromArgb(27, 27, 27);
            // 
            // tabberTextBox1
            // 
            tabberTextBox1.BackgroundColor = Color.FromArgb(251, 251, 251);
            tabberTextBox1.BorderColor = Color.FromArgb(229, 229, 229);
            tabberTextBox1.BorderSize = 1;
            tabberTextBox1.Location = new Point(12, 68);
            tabberTextBox1.Name = "tabberTextBox1";
            tabberTextBox1.Size = new Size(382, 34);
            tabberTextBox1.TabIndex = 2;
            tabberTextBox1.TextBoxMuntiline = false;
            tabberTextBox1.TextBoxText = "Text Box";
            tabberTextBox1.TextColor = SystemColors.WindowText;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(405, 111);
            Controls.Add(tabberTextBox1);
            Controls.Add(tabberPanel1);
            Controls.Add(tabberButton1);
            Name = "Form";
            Text = "Tabber UI";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private unvell.ReoGrid.Editor.Custom_Control.FluentButtons.TabberButton tabberButton1;
        private unvell.ReoGrid.Editor.Custom_Control.FluentPanel.TabberPanel tabberPanel1;
        private TabberTextBox.TabberTextBox tabberTextBox1;
    }
}