namespace IntelliImage
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceList = new Telerik.WinControls.UI.RadTextBox();
            this.SourceType = new Telerik.WinControls.UI.RadDropDownButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.sourceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceList
            // 
            this.sourceList.Location = new System.Drawing.Point(13, 48);
            this.sourceList.Multiline = true;
            this.sourceList.Name = "sourceList";
            this.sourceList.NullText = "Enter the URL list here";
            // 
            // 
            // 
            this.sourceList.RootElement.StretchVertically = true;
            this.sourceList.Size = new System.Drawing.Size(551, 105);
            this.sourceList.TabIndex = 10;
            this.sourceList.TabStop = false;
            // 
            // SourceType
            // 
            this.SourceType.Location = new System.Drawing.Point(172, 18);
            this.SourceType.Name = "SourceType";
            this.SourceType.Size = new System.Drawing.Size(392, 24);
            this.SourceType.TabIndex = 7;
            this.SourceType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 22);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(152, 18);
            this.radLabel1.TabIndex = 11;
            this.radLabel1.Text = "Source of grabbing images is";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(434, 159);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(130, 24);
            this.radButton1.TabIndex = 12;
            this.radButton1.Text = "Start";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 335);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.sourceList);
            this.Controls.Add(this.SourceType);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intelligent Image Grabber v1.0";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox sourceList;
        private Telerik.WinControls.UI.RadDropDownButton SourceType;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
