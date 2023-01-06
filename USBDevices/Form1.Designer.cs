namespace USBDevices
{
    partial class Form1
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
            this.listBoxUSBDeviceList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxUSBDeviceList
            // 
            this.listBoxUSBDeviceList.FormattingEnabled = true;
            this.listBoxUSBDeviceList.Location = new System.Drawing.Point(202, 42);
            this.listBoxUSBDeviceList.Name = "listBoxUSBDeviceList";
            this.listBoxUSBDeviceList.Size = new System.Drawing.Size(719, 394);
            this.listBoxUSBDeviceList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 447);
            this.Controls.Add(this.listBoxUSBDeviceList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUSBDeviceList;
    }
}

