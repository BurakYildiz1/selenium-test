namespace Selenium_test
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_Search = new MetroFramework.Controls.MetroTextBox();
            this.Google_Search = new System.Windows.Forms.GroupBox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.Search = new MetroFramework.Controls.MetroButton();
            this.Website_Login = new System.Windows.Forms.GroupBox();
            this.Login = new MetroFramework.Controls.MetroButton();
            this.txt_pass = new MetroFramework.Controls.MetroTextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.Google_Search.SuspendLayout();
            this.Website_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            // 
            // 
            // 
            this.txt_Search.CustomButton.Image = null;
            this.txt_Search.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txt_Search.CustomButton.Name = "";
            this.txt_Search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Search.CustomButton.TabIndex = 1;
            this.txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Search.CustomButton.UseSelectable = true;
            this.txt_Search.CustomButton.Visible = false;
            this.txt_Search.Lines = new string[] {
        "Google search"};
            this.txt_Search.Location = new System.Drawing.Point(42, 43);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.ShortcutsEnabled = true;
            this.txt_Search.Size = new System.Drawing.Size(197, 23);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.Text = "Google search";
            this.txt_Search.UseSelectable = true;
            this.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Google_Search
            // 
            this.Google_Search.Controls.Add(this.Search);
            this.Google_Search.Controls.Add(this.txt_Search);
            this.Google_Search.Location = new System.Drawing.Point(23, 89);
            this.Google_Search.Name = "Google_Search";
            this.Google_Search.Size = new System.Drawing.Size(308, 173);
            this.Google_Search.TabIndex = 1;
            this.Google_Search.TabStop = false;
            this.Google_Search.Text = "Google_Search";
            this.Google_Search.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(100, 133);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseSelectable = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Website_Login
            // 
            this.Website_Login.Controls.Add(this.Login);
            this.Website_Login.Controls.Add(this.txt_pass);
            this.Website_Login.Controls.Add(this.txt_email);
            this.Website_Login.Location = new System.Drawing.Point(428, 89);
            this.Website_Login.Name = "Website_Login";
            this.Website_Login.Size = new System.Drawing.Size(308, 173);
            this.Website_Login.TabIndex = 4;
            this.Website_Login.TabStop = false;
            this.Website_Login.Text = "Website_Login";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(117, 133);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseSelectable = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // txt_pass
            // 
            // 
            // 
            // 
            this.txt_pass.CustomButton.Image = null;
            this.txt_pass.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txt_pass.CustomButton.Name = "";
            this.txt_pass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pass.CustomButton.TabIndex = 1;
            this.txt_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pass.CustomButton.UseSelectable = true;
            this.txt_pass.CustomButton.Visible = false;
            this.txt_pass.Lines = new string[] {
        "Password"};
            this.txt_pass.Location = new System.Drawing.Point(66, 81);
            this.txt_pass.MaxLength = 32767;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '\0';
            this.txt_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pass.SelectedText = "";
            this.txt_pass.SelectionLength = 0;
            this.txt_pass.SelectionStart = 0;
            this.txt_pass.ShortcutsEnabled = true;
            this.txt_pass.Size = new System.Drawing.Size(197, 23);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.Text = "Password";
            this.txt_pass.UseSelectable = true;
            this.txt_pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[] {
        "E-mail"};
            this.txt_email.Location = new System.Drawing.Point(66, 43);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(197, 23);
            this.txt_email.TabIndex = 0;
            this.txt_email.Text = "E-mail";
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 346);
            this.Controls.Add(this.Website_Login);
            this.Controls.Add(this.Google_Search);
            this.Name = "Form1";
            this.Text = "Selenium-test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Google_Search.ResumeLayout(false);
            this.Website_Login.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_Search;
        private System.Windows.Forms.GroupBox Google_Search;
        private MetroFramework.Controls.MetroButton Search;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.GroupBox Website_Login;
        private MetroFramework.Controls.MetroButton Login;
        private MetroFramework.Controls.MetroTextBox txt_pass;
        private MetroFramework.Controls.MetroTextBox txt_email;
    }
}

