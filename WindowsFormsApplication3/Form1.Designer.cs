namespace WindowsFormsApplication3
{
    partial class Main
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
            this.button_GetInfo = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.buttonSnow = new System.Windows.Forms.Button();
            this.buttonFlood = new System.Windows.Forms.Button();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblInfoType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbHelpful_Info = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_GetInfo
            // 
            this.button_GetInfo.Location = new System.Drawing.Point(66, 226);
            this.button_GetInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_GetInfo.Name = "button_GetInfo";
            this.button_GetInfo.Size = new System.Drawing.Size(132, 43);
            this.button_GetInfo.TabIndex = 0;
            this.button_GetInfo.Text = "&Get Info";
            this.button_GetInfo.UseVisualStyleBackColor = true;
            this.button_GetInfo.Click += new System.EventHandler(this.button_GetInfo_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Exit.Location = new System.Drawing.Point(715, 424);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(70, 28);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "&Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(79, 85);
            this.textBoxZip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(125, 22);
            this.textBoxZip.TabIndex = 2;
            this.textBoxZip.Text = "- enter your zip - ";
            this.textBoxZip.Click += new System.EventHandler(this.textBoxZip_Click);
            // 
            // buttonSnow
            // 
            this.buttonSnow.Location = new System.Drawing.Point(372, 75);
            this.buttonSnow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSnow.Name = "buttonSnow";
            this.buttonSnow.Size = new System.Drawing.Size(67, 61);
            this.buttonSnow.TabIndex = 3;
            this.buttonSnow.Text = "&Snow";
            this.buttonSnow.UseVisualStyleBackColor = true;
            this.buttonSnow.Click += new System.EventHandler(this.buttonSnow_Click);
            // 
            // buttonFlood
            // 
            this.buttonFlood.Location = new System.Drawing.Point(284, 75);
            this.buttonFlood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFlood.Name = "buttonFlood";
            this.buttonFlood.Size = new System.Drawing.Size(67, 61);
            this.buttonFlood.TabIndex = 4;
            this.buttonFlood.Text = "&Flood";
            this.buttonFlood.UseVisualStyleBackColor = true;
            this.buttonFlood.Click += new System.EventHandler(this.buttonFlood_Click);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(44, 42);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(98, 17);
            this.lblZip.TabIndex = 6;
            this.lblZip.Text = "Enter your Zip";
            // 
            // lblInfoType
            // 
            this.lblInfoType.AutoSize = true;
            this.lblInfoType.Location = new System.Drawing.Point(260, 193);
            this.lblInfoType.Name = "lblInfoType";
            this.lblInfoType.Size = new System.Drawing.Size(93, 17);
            this.lblInfoType.TabIndex = 8;
            this.lblInfoType.Text = "warning Type";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(271, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 80);
            this.panel1.TabIndex = 9;
            // 
            // rtbHelpful_Info
            // 
            this.rtbHelpful_Info.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHelpful_Info.Location = new System.Drawing.Point(247, 234);
            this.rtbHelpful_Info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbHelpful_Info.Name = "rtbHelpful_Info";
            this.rtbHelpful_Info.ReadOnly = true;
            this.rtbHelpful_Info.Size = new System.Drawing.Size(538, 186);
            this.rtbHelpful_Info.TabIndex = 5;
            this.rtbHelpful_Info.Text = "";
            // 
            // Main
            // 
            this.AcceptButton = this.button_GetInfo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Exit;
            this.ClientSize = new System.Drawing.Size(808, 462);
            this.Controls.Add(this.lblInfoType);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.rtbHelpful_Info);
            this.Controls.Add(this.buttonFlood);
            this.Controls.Add(this.buttonSnow);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_GetInfo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Disater Preperation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_GetInfo;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.Button buttonSnow;
        private System.Windows.Forms.Button buttonFlood;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblInfoType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbHelpful_Info;
    }
}

