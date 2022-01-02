namespace PortableWebServer
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.Page1_FolderPath = new System.Windows.Forms.TextBox();
            this.Page1_Button = new System.Windows.Forms.Button();
            this.Page1_FolderSelect = new System.Windows.Forms.Button();
            this.Page2_ApacheTitle = new System.Windows.Forms.Label();
            this.Page2_ApacheStart = new System.Windows.Forms.Button();
            this.Page2_ApacheStop = new System.Windows.Forms.Button();
            this.Page2_MySQLTitle = new System.Windows.Forms.Label();
            this.Page2_ApacheStatus = new System.Windows.Forms.Label();
            this.Page2_MySQLStart = new System.Windows.Forms.Button();
            this.Page2_MySQLStatus = new System.Windows.Forms.Label();
            this.Page2_MySQLStop = new System.Windows.Forms.Button();
            this.Page2_MySQLAdmin = new System.Windows.Forms.Button();
            this.CheckServices = new System.Windows.Forms.Timer(this.components);
            this.Page1_Icon = new System.Windows.Forms.PictureBox();
            this.Page2_Icon = new System.Windows.Forms.PictureBox();
            this.TabControl.SuspendLayout();
            this.Page1.SuspendLayout();
            this.Page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Page1_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Page2_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Page1);
            this.TabControl.Controls.Add(this.Page2);
            this.TabControl.Location = new System.Drawing.Point(9, 6);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(10, 5);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(469, 256);
            this.TabControl.TabIndex = 0;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.Page1_FolderSelect);
            this.Page1.Controls.Add(this.Page1_Icon);
            this.Page1.Controls.Add(this.Page1_Button);
            this.Page1.Controls.Add(this.Page1_FolderPath);
            this.Page1.Location = new System.Drawing.Point(4, 26);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(461, 226);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Install";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.Page2_MySQLAdmin);
            this.Page2.Controls.Add(this.Page2_MySQLStatus);
            this.Page2.Controls.Add(this.Page2_ApacheStatus);
            this.Page2.Controls.Add(this.Page2_MySQLStop);
            this.Page2.Controls.Add(this.Page2_MySQLStart);
            this.Page2.Controls.Add(this.Page2_MySQLTitle);
            this.Page2.Controls.Add(this.Page2_ApacheStop);
            this.Page2.Controls.Add(this.Page2_ApacheStart);
            this.Page2.Controls.Add(this.Page2_ApacheTitle);
            this.Page2.Controls.Add(this.Page2_Icon);
            this.Page2.Location = new System.Drawing.Point(4, 26);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(461, 226);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "Management Panel";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // Page1_FolderPath
            // 
            this.Page1_FolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Page1_FolderPath.Location = new System.Drawing.Point(34, 141);
            this.Page1_FolderPath.Multiline = true;
            this.Page1_FolderPath.Name = "Page1_FolderPath";
            this.Page1_FolderPath.ReadOnly = true;
            this.Page1_FolderPath.Size = new System.Drawing.Size(371, 26);
            this.Page1_FolderPath.TabIndex = 0;
            // 
            // Page1_Button
            // 
            this.Page1_Button.Location = new System.Drawing.Point(74, 175);
            this.Page1_Button.Name = "Page1_Button";
            this.Page1_Button.Size = new System.Drawing.Size(323, 35);
            this.Page1_Button.TabIndex = 1;
            this.Page1_Button.Text = "Install";
            this.Page1_Button.UseVisualStyleBackColor = true;
            this.Page1_Button.Click += new System.EventHandler(this.Page1_Button_Click);
            // 
            // Page1_FolderSelect
            // 
            this.Page1_FolderSelect.Location = new System.Drawing.Point(411, 141);
            this.Page1_FolderSelect.Name = "Page1_FolderSelect";
            this.Page1_FolderSelect.Size = new System.Drawing.Size(25, 25);
            this.Page1_FolderSelect.TabIndex = 3;
            this.Page1_FolderSelect.Text = "...";
            this.Page1_FolderSelect.UseVisualStyleBackColor = true;
            this.Page1_FolderSelect.Click += new System.EventHandler(this.Page1_FolderSelect_Click);
            // 
            // Page2_ApacheTitle
            // 
            this.Page2_ApacheTitle.AutoSize = true;
            this.Page2_ApacheTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Page2_ApacheTitle.Location = new System.Drawing.Point(11, 31);
            this.Page2_ApacheTitle.Name = "Page2_ApacheTitle";
            this.Page2_ApacheTitle.Size = new System.Drawing.Size(80, 22);
            this.Page2_ApacheTitle.TabIndex = 4;
            this.Page2_ApacheTitle.Text = "Apache:";
            // 
            // Page2_ApacheStart
            // 
            this.Page2_ApacheStart.Location = new System.Drawing.Point(14, 59);
            this.Page2_ApacheStart.Name = "Page2_ApacheStart";
            this.Page2_ApacheStart.Size = new System.Drawing.Size(147, 23);
            this.Page2_ApacheStart.TabIndex = 5;
            this.Page2_ApacheStart.Text = "Start";
            this.Page2_ApacheStart.UseVisualStyleBackColor = true;
            this.Page2_ApacheStart.Click += new System.EventHandler(this.Page2_ApacheStart_Click);
            // 
            // Page2_ApacheStop
            // 
            this.Page2_ApacheStop.Location = new System.Drawing.Point(167, 59);
            this.Page2_ApacheStop.Name = "Page2_ApacheStop";
            this.Page2_ApacheStop.Size = new System.Drawing.Size(147, 23);
            this.Page2_ApacheStop.TabIndex = 6;
            this.Page2_ApacheStop.Text = "Stop";
            this.Page2_ApacheStop.UseVisualStyleBackColor = true;
            this.Page2_ApacheStop.Click += new System.EventHandler(this.Page2_ApacheStop_Click);
            // 
            // Page2_MySQLTitle
            // 
            this.Page2_MySQLTitle.AutoSize = true;
            this.Page2_MySQLTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Page2_MySQLTitle.Location = new System.Drawing.Point(11, 131);
            this.Page2_MySQLTitle.Name = "Page2_MySQLTitle";
            this.Page2_MySQLTitle.Size = new System.Drawing.Size(78, 22);
            this.Page2_MySQLTitle.TabIndex = 7;
            this.Page2_MySQLTitle.Text = "MySQL:";
            // 
            // Page2_ApacheStatus
            // 
            this.Page2_ApacheStatus.AutoSize = true;
            this.Page2_ApacheStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Page2_ApacheStatus.ForeColor = System.Drawing.Color.Red;
            this.Page2_ApacheStatus.Location = new System.Drawing.Point(86, 32);
            this.Page2_ApacheStatus.Name = "Page2_ApacheStatus";
            this.Page2_ApacheStatus.Size = new System.Drawing.Size(66, 22);
            this.Page2_ApacheStatus.TabIndex = 10;
            this.Page2_ApacheStatus.Text = "Offline";
            // 
            // Page2_MySQLStart
            // 
            this.Page2_MySQLStart.Location = new System.Drawing.Point(14, 159);
            this.Page2_MySQLStart.Name = "Page2_MySQLStart";
            this.Page2_MySQLStart.Size = new System.Drawing.Size(147, 23);
            this.Page2_MySQLStart.TabIndex = 8;
            this.Page2_MySQLStart.Text = "Start";
            this.Page2_MySQLStart.UseVisualStyleBackColor = true;
            this.Page2_MySQLStart.Click += new System.EventHandler(this.Page2_MySQLStart_Click);
            // 
            // Page2_MySQLStatus
            // 
            this.Page2_MySQLStatus.AutoSize = true;
            this.Page2_MySQLStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Page2_MySQLStatus.ForeColor = System.Drawing.Color.Red;
            this.Page2_MySQLStatus.Location = new System.Drawing.Point(86, 131);
            this.Page2_MySQLStatus.Name = "Page2_MySQLStatus";
            this.Page2_MySQLStatus.Size = new System.Drawing.Size(66, 22);
            this.Page2_MySQLStatus.TabIndex = 11;
            this.Page2_MySQLStatus.Text = "Offline";
            // 
            // Page2_MySQLStop
            // 
            this.Page2_MySQLStop.Location = new System.Drawing.Point(167, 159);
            this.Page2_MySQLStop.Name = "Page2_MySQLStop";
            this.Page2_MySQLStop.Size = new System.Drawing.Size(147, 23);
            this.Page2_MySQLStop.TabIndex = 9;
            this.Page2_MySQLStop.Text = "Stop";
            this.Page2_MySQLStop.UseVisualStyleBackColor = true;
            this.Page2_MySQLStop.Click += new System.EventHandler(this.Page2_MySQLStop_Click);
            // 
            // Page2_MySQLAdmin
            // 
            this.Page2_MySQLAdmin.Location = new System.Drawing.Point(90, 188);
            this.Page2_MySQLAdmin.Name = "Page2_MySQLAdmin";
            this.Page2_MySQLAdmin.Size = new System.Drawing.Size(147, 23);
            this.Page2_MySQLAdmin.TabIndex = 12;
            this.Page2_MySQLAdmin.Text = "Admin";
            this.Page2_MySQLAdmin.UseVisualStyleBackColor = true;
            this.Page2_MySQLAdmin.Click += new System.EventHandler(this.Page2_MySQLAdmin_Click);
            // 
            // CheckServices
            // 
            this.CheckServices.Enabled = true;
            this.CheckServices.Tick += new System.EventHandler(this.CheckServices_Tick);
            // 
            // Page1_Icon
            // 
            this.Page1_Icon.Image = global::PortableWebServer.Properties.Resources.icon1;
            this.Page1_Icon.Location = new System.Drawing.Point(185, 15);
            this.Page1_Icon.Name = "Page1_Icon";
            this.Page1_Icon.Size = new System.Drawing.Size(101, 119);
            this.Page1_Icon.TabIndex = 2;
            this.Page1_Icon.TabStop = false;
            // 
            // Page2_Icon
            // 
            this.Page2_Icon.Image = global::PortableWebServer.Properties.Resources.icon2;
            this.Page2_Icon.Location = new System.Drawing.Point(359, 59);
            this.Page2_Icon.Name = "Page2_Icon";
            this.Page2_Icon.Size = new System.Drawing.Size(82, 91);
            this.Page2_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Page2_Icon.TabIndex = 3;
            this.Page2_Icon.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 271);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 310);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 310);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portable Web Server";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TabControl.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.Page2.ResumeLayout(false);
            this.Page2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Page1_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Page2_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.PictureBox Page1_Icon;
        private System.Windows.Forms.Button Page1_Button;
        private System.Windows.Forms.TextBox Page1_FolderPath;
        private System.Windows.Forms.Button Page1_FolderSelect;
        private System.Windows.Forms.PictureBox Page2_Icon;
        private System.Windows.Forms.Label Page2_ApacheStatus;
        private System.Windows.Forms.Label Page2_MySQLTitle;
        private System.Windows.Forms.Button Page2_ApacheStop;
        private System.Windows.Forms.Button Page2_ApacheStart;
        private System.Windows.Forms.Label Page2_ApacheTitle;
        private System.Windows.Forms.Label Page2_MySQLStatus;
        private System.Windows.Forms.Button Page2_MySQLStop;
        private System.Windows.Forms.Button Page2_MySQLStart;
        private System.Windows.Forms.Button Page2_MySQLAdmin;
        private System.Windows.Forms.Timer CheckServices;
    }
}

