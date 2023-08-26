namespace Tabber_UI.TabberTextBox
{
    partial class TabberTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabberPanel = new unvell.ReoGrid.Editor.Custom_Control.FluentPanel.TabberPanel();
            TextBox = new TextBox();
            TabberPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TabberPanel
            // 
            TabberPanel.BackColor = Color.FromArgb(251, 251, 251);
            TabberPanel.BackgroundColor = Color.FromArgb(251, 251, 251);
            TabberPanel.BorderColor = Color.FromArgb(229, 229, 229);
            TabberPanel.BorderRadius = 5;
            TabberPanel.BorderSize = 1;
            TabberPanel.Controls.Add(TextBox);
            TabberPanel.Dock = DockStyle.Fill;
            TabberPanel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TabberPanel.ForeColor = Color.FromArgb(27, 27, 27);
            TabberPanel.Location = new Point(0, 0);
            TabberPanel.Name = "TabberPanel";
            TabberPanel.Size = new Size(223, 34);
            TabberPanel.TabIndex = 0;
            TabberPanel.TextColor = Color.FromArgb(27, 27, 27);
            // 
            // TextBox
            // 
            TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBox.BorderStyle = BorderStyle.None;
            TextBox.Location = new Point(6, 5);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(214, 24);
            TextBox.TabIndex = 1;
            TextBox.Text = "Text Box";
            // 
            // TabberTextBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TabberPanel);
            Name = "TabberTextBox";
            Size = new Size(223, 34);
            TabberPanel.ResumeLayout(false);
            TabberPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private unvell.ReoGrid.Editor.Custom_Control.FluentPanel.TabberPanel TabberPanel;
        private TextBox TextBox;
    }
}
