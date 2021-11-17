
namespace LMP
{
    partial class LoginForm
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
            this.labLogID = new System.Windows.Forms.Label();
            this.labLogPW = new System.Windows.Forms.Label();
            this.txtLogID = new System.Windows.Forms.TextBox();
            this.txtLogPW = new System.Windows.Forms.TextBox();
            this.labLogSearch = new System.Windows.Forms.Label();
            this.labLogAddMem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogLogin = new System.Windows.Forms.Button();
            this.btnLogNonLogin = new System.Windows.Forms.Button();
            this.picLogLogo = new System.Windows.Forms.PictureBox();
            this.grpLogLogin = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogLogo)).BeginInit();
            this.grpLogLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 30F);
            this.label1.Location = new System.Drawing.Point(197, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // labLogID
            // 
            this.labLogID.AutoSize = true;
            this.labLogID.Font = new System.Drawing.Font("Gulim", 10F);
            this.labLogID.Location = new System.Drawing.Point(81, 190);
            this.labLogID.Name = "labLogID";
            this.labLogID.Size = new System.Drawing.Size(64, 14);
            this.labLogID.TabIndex = 1;
            this.labLogID.Text = "아이디 : ";
            // 
            // labLogPW
            // 
            this.labLogPW.AutoSize = true;
            this.labLogPW.Font = new System.Drawing.Font("Gulim", 10F);
            this.labLogPW.Location = new System.Drawing.Point(67, 257);
            this.labLogPW.Name = "labLogPW";
            this.labLogPW.Size = new System.Drawing.Size(78, 14);
            this.labLogPW.TabIndex = 2;
            this.labLogPW.Text = "비밀번호 : ";
            // 
            // txtLogID
            // 
            this.txtLogID.Location = new System.Drawing.Point(181, 188);
            this.txtLogID.Name = "txtLogID";
            this.txtLogID.Size = new System.Drawing.Size(201, 21);
            this.txtLogID.TabIndex = 3;
            // 
            // txtLogPW
            // 
            this.txtLogPW.Location = new System.Drawing.Point(181, 255);
            this.txtLogPW.Name = "txtLogPW";
            this.txtLogPW.PasswordChar = '*';
            this.txtLogPW.Size = new System.Drawing.Size(201, 21);
            this.txtLogPW.TabIndex = 4;
            // 
            // labLogSearch
            // 
            this.labLogSearch.AutoSize = true;
            this.labLogSearch.Font = new System.Drawing.Font("Gulim", 10F);
            this.labLogSearch.Location = new System.Drawing.Point(81, 313);
            this.labLogSearch.Name = "labLogSearch";
            this.labLogSearch.Size = new System.Drawing.Size(144, 14);
            this.labLogSearch.TabIndex = 5;
            this.labLogSearch.Text = "아이디/비밀번호 찾기";
            // 
            // labLogAddMem
            // 
            this.labLogAddMem.AutoSize = true;
            this.labLogAddMem.Font = new System.Drawing.Font("Gulim", 10F);
            this.labLogAddMem.Location = new System.Drawing.Point(266, 313);
            this.labLogAddMem.Name = "labLogAddMem";
            this.labLogAddMem.Size = new System.Drawing.Size(63, 14);
            this.labLogAddMem.TabIndex = 6;
            this.labLogAddMem.Text = "회원가입";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "------------------------------------------------------------------";
            // 
            // btnLogLogin
            // 
            this.btnLogLogin.Font = new System.Drawing.Font("Gulim", 20F);
            this.btnLogLogin.Location = new System.Drawing.Point(61, 408);
            this.btnLogLogin.Name = "btnLogLogin";
            this.btnLogLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogLogin.TabIndex = 8;
            this.btnLogLogin.Text = "로그인";
            this.btnLogLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogNonLogin
            // 
            this.btnLogNonLogin.Font = new System.Drawing.Font("Gulim", 20F);
            this.btnLogNonLogin.Location = new System.Drawing.Point(257, 408);
            this.btnLogNonLogin.Name = "btnLogNonLogin";
            this.btnLogNonLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogNonLogin.TabIndex = 9;
            this.btnLogNonLogin.Text = "비회원";
            // 
            // picLogLogo
            // 
            this.picLogLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogLogo.Image = global::LMP.Properties.Resources.ddoing1;
            this.picLogLogo.Location = new System.Drawing.Point(52, 20);
            this.picLogLogo.Name = "picLogLogo";
            this.picLogLogo.Size = new System.Drawing.Size(116, 145);
            this.picLogLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogLogo.TabIndex = 10;
            this.picLogLogo.TabStop = false;
            // 
            // grpLogLogin
            // 
            this.grpLogLogin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grpLogLogin.Controls.Add(this.picLogLogo);
            this.grpLogLogin.Controls.Add(this.label1);
            this.grpLogLogin.Controls.Add(this.btnLogNonLogin);
            this.grpLogLogin.Controls.Add(this.labLogID);
            this.grpLogLogin.Controls.Add(this.btnLogLogin);
            this.grpLogLogin.Controls.Add(this.labLogPW);
            this.grpLogLogin.Controls.Add(this.label2);
            this.grpLogLogin.Controls.Add(this.txtLogID);
            this.grpLogLogin.Controls.Add(this.labLogAddMem);
            this.grpLogLogin.Controls.Add(this.txtLogPW);
            this.grpLogLogin.Controls.Add(this.labLogSearch);
            this.grpLogLogin.Location = new System.Drawing.Point(162, 45);
            this.grpLogLogin.Name = "grpLogLogin";
            this.grpLogLogin.Size = new System.Drawing.Size(453, 468);
            this.grpLogLogin.TabIndex = 11;
            this.grpLogLogin.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpLogLogin);
            this.Name = "Login";
            this.Text = "로그인폼";
            ((System.ComponentModel.ISupportInitialize)(this.picLogLogo)).EndInit();
            this.grpLogLogin.ResumeLayout(false);
            this.grpLogLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labLogID;
        private System.Windows.Forms.Label labLogPW;
        private System.Windows.Forms.TextBox txtLogID;
        private System.Windows.Forms.TextBox txtLogPW;
        private System.Windows.Forms.Label labLogSearch;
        private System.Windows.Forms.Label labLogAddMem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogLogin;
        private System.Windows.Forms.Button btnLogNonLogin;
        private System.Windows.Forms.PictureBox picLogLogo;
        private System.Windows.Forms.GroupBox grpLogLogin;
    }
}

