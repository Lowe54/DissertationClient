namespace DissertationClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Menu_Login = new System.Windows.Forms.Button();
            this.button_Menu_CreateAccount = new System.Windows.Forms.Button();
            this.button_Menu_View_Images = new System.Windows.Forms.Button();
            this.button_Upload_Image = new System.Windows.Forms.Button();
            this.groupBox_CreateAccount = new System.Windows.Forms.GroupBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_CA_Create = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webControl = new Awesomium.Windows.Forms.WebControl(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_CreateAccount.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Menu_Login
            // 
            this.button_Menu_Login.Location = new System.Drawing.Point(864, 23);
            this.button_Menu_Login.Name = "button_Menu_Login";
            this.button_Menu_Login.Size = new System.Drawing.Size(125, 53);
            this.button_Menu_Login.TabIndex = 0;
            this.button_Menu_Login.Text = "Login/Logout";
            this.button_Menu_Login.UseVisualStyleBackColor = true;
            this.button_Menu_Login.Click += new System.EventHandler(this.button_Menu_Login_Click);
            // 
            // button_Menu_CreateAccount
            // 
            this.button_Menu_CreateAccount.Location = new System.Drawing.Point(864, 82);
            this.button_Menu_CreateAccount.Name = "button_Menu_CreateAccount";
            this.button_Menu_CreateAccount.Size = new System.Drawing.Size(125, 60);
            this.button_Menu_CreateAccount.TabIndex = 1;
            this.button_Menu_CreateAccount.Text = "Create Account";
            this.button_Menu_CreateAccount.UseVisualStyleBackColor = true;
            this.button_Menu_CreateAccount.Click += new System.EventHandler(this.button_Menu_CreateAccount_Click);
            // 
            // button_Menu_View_Images
            // 
            this.button_Menu_View_Images.Location = new System.Drawing.Point(864, 150);
            this.button_Menu_View_Images.Name = "button_Menu_View_Images";
            this.button_Menu_View_Images.Size = new System.Drawing.Size(125, 58);
            this.button_Menu_View_Images.TabIndex = 2;
            this.button_Menu_View_Images.Text = "View My Images";
            this.button_Menu_View_Images.UseVisualStyleBackColor = true;
            this.button_Menu_View_Images.Click += new System.EventHandler(this.button_Menu_View_Images_Click);
            // 
            // button_Upload_Image
            // 
            this.button_Upload_Image.Location = new System.Drawing.Point(864, 214);
            this.button_Upload_Image.Name = "button_Upload_Image";
            this.button_Upload_Image.Size = new System.Drawing.Size(125, 61);
            this.button_Upload_Image.TabIndex = 3;
            this.button_Upload_Image.Text = "Upload Image";
            this.button_Upload_Image.UseVisualStyleBackColor = true;
            this.button_Upload_Image.Click += new System.EventHandler(this.button_Upload_Image_Click);
            // 
            // groupBox_CreateAccount
            // 
            this.groupBox_CreateAccount.Controls.Add(this.button_Login);
            this.groupBox_CreateAccount.Controls.Add(this.button_CA_Create);
            this.groupBox_CreateAccount.Controls.Add(this.textBox_Password);
            this.groupBox_CreateAccount.Controls.Add(this.label2);
            this.groupBox_CreateAccount.Controls.Add(this.textBox_UserName);
            this.groupBox_CreateAccount.Controls.Add(this.label1);
            this.groupBox_CreateAccount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox_CreateAccount.Location = new System.Drawing.Point(13, 15);
            this.groupBox_CreateAccount.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox_CreateAccount.Name = "groupBox_CreateAccount";
            this.groupBox_CreateAccount.Size = new System.Drawing.Size(823, 416);
            this.groupBox_CreateAccount.TabIndex = 4;
            this.groupBox_CreateAccount.TabStop = false;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(574, 159);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(110, 47);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_CA_Create
            // 
            this.button_CA_Create.Location = new System.Drawing.Point(574, 159);
            this.button_CA_Create.Name = "button_CA_Create";
            this.button_CA_Create.Size = new System.Drawing.Size(110, 47);
            this.button_CA_Create.TabIndex = 4;
            this.button_CA_Create.Text = "Create Account";
            this.button_CA_Create.UseVisualStyleBackColor = true;
            this.button_CA_Create.Click += new System.EventHandler(this.button_CA_Create_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(121, 91);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(525, 20);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(121, 50);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(525, 20);
            this.textBox_UserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName: ";
            // 
            // webControl
            // 
            this.webControl.Location = new System.Drawing.Point(13, 28);
            this.webControl.Size = new System.Drawing.Size(824, 402);
            this.webControl.Source = new System.Uri("http://localhost:8080/DissertationBackend/Welcome.php", System.UriKind.Absolute);
            this.webControl.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1001, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Options";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 440);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.webControl);
            this.Controls.Add(this.groupBox_CreateAccount);
            this.Controls.Add(this.button_Upload_Image);
            this.Controls.Add(this.button_Menu_View_Images);
            this.Controls.Add(this.button_Menu_CreateAccount);
            this.Controls.Add(this.button_Menu_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Image Storage Client";
            this.groupBox_CreateAccount.ResumeLayout(false);
            this.groupBox_CreateAccount.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Menu_Login;
        private System.Windows.Forms.Button button_Menu_CreateAccount;
        private System.Windows.Forms.Button button_Menu_View_Images;
        private System.Windows.Forms.Button button_Upload_Image;
        private System.Windows.Forms.GroupBox groupBox_CreateAccount;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_CA_Create;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label1;
        private Awesomium.Windows.Forms.WebControl webControl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
    }
}

