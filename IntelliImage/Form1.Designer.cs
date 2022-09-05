namespace IntelliImage
{
    partial class MainForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputSource = new System.Windows.Forms.TextBox();
            this.buttonAutoIdentify = new System.Windows.Forms.Button();
            this.sourceType1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SourceType = new Telerik.WinControls.UI.RadDropDownButton();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SourceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL/Keyword";
            // 
            // inputSource
            // 
            this.inputSource.Location = new System.Drawing.Point(115, 142);
            this.inputSource.Name = "inputSource";
            this.inputSource.Size = new System.Drawing.Size(436, 20);
            this.inputSource.TabIndex = 1;
            this.inputSource.Text = "http://www.sankakucomplex.com/forums/";
            // 
            // buttonAutoIdentify
            // 
            this.buttonAutoIdentify.Location = new System.Drawing.Point(325, 166);
            this.buttonAutoIdentify.Name = "buttonAutoIdentify";
            this.buttonAutoIdentify.Size = new System.Drawing.Size(131, 23);
            this.buttonAutoIdentify.TabIndex = 2;
            this.buttonAutoIdentify.Text = "Auto Identify";
            this.buttonAutoIdentify.UseVisualStyleBackColor = true;
            this.buttonAutoIdentify.Click += new System.EventHandler(this.buttonAutoIdentify_Click);
            // 
            // sourceType1
            // 
            this.sourceType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceType1.FormattingEnabled = true;
            this.sourceType1.Items.AddRange(new object[] {
            "bbPress forum",
            "Google Image (Keyword)",
            "Invision power board forum",
            "phpBB forum",
            "Simple Machines forum",
            "vBulletin forum"});
            this.sourceType1.Location = new System.Drawing.Point(115, 168);
            this.sourceType1.Name = "sourceType1";
            this.sourceType1.Size = new System.Drawing.Size(204, 21);
            this.sourceType1.Sorted = true;
            this.sourceType1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(463, 166);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // SourceType
            // 
            this.SourceType.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem9,
            this.radMenuItem10,
            this.radMenuItem2,
            this.radMenuItem8,
            this.radMenuItem7,
            this.radMenuItem6,
            this.radMenuItem5,
            this.radMenuItem4,
            this.radMenuItem3});
            this.SourceType.Location = new System.Drawing.Point(12, 29);
            this.SourceType.Name = "SourceType";
            this.SourceType.Size = new System.Drawing.Size(140, 24);
            this.SourceType.TabIndex = 7;
            this.SourceType.Text = "radDropDownButton1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "URL";
            this.radMenuItem1.AccessibleName = "URL";
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "URL";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.AccessibleDescription = "bbPress Topic URL";
            this.radMenuItem9.AccessibleName = "bbPress Topic URL";
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "bbPress Topic URL";
            this.radMenuItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.AccessibleDescription = "bbPress Thread URL";
            this.radMenuItem10.AccessibleName = "bbPress Thread URL";
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "bbPress Thread URL";
            this.radMenuItem10.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Google Images";
            this.radMenuItem2.AccessibleName = "Google Images";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Google Images";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.AccessibleDescription = "Invision Power Thread URL";
            this.radMenuItem8.AccessibleName = "Invision Power Thread URL";
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Invision Power Thread URL";
            this.radMenuItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.AccessibleDescription = "Invision Power Topic URL";
            this.radMenuItem7.AccessibleName = "Invision Power Topic URL";
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Invision Power Topic URL";
            this.radMenuItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.AccessibleDescription = "phpBB Thread URL";
            this.radMenuItem6.AccessibleName = "phpBB Thread URL";
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "phpBB Thread URL";
            this.radMenuItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.AccessibleDescription = "phpBB Topic URL";
            this.radMenuItem5.AccessibleName = "phpBB Topic URL";
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "phpBB Topic URL";
            this.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.AccessibleDescription = "vBulletin Thread URL";
            this.radMenuItem4.AccessibleName = "vBulletin Thread URL";
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "vBulletin Thread URL";
            this.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "vBulletin Topic URL";
            this.radMenuItem3.AccessibleName = "vBulletin Topic URL";
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "vBulletin Topic URL";
            this.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(171, 30);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(380, 20);
            this.radTextBox1.TabIndex = 8;
            this.radTextBox1.TabStop = false;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 426);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.SourceType);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourceType1);
            this.Controls.Add(this.buttonAutoIdentify);
            this.Controls.Add(this.inputSource);
            this.Controls.Add(this.label1);
            this.Name = "MainForm1";
            this.Text = "Intelligent Image Grabber v1.0";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SourceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputSource;
        private System.Windows.Forms.Button buttonAutoIdentify;
        private System.Windows.Forms.ComboBox sourceType1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private Telerik.WinControls.UI.RadDropDownButton SourceType;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
    }
}

