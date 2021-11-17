
namespace LMP
{
    partial class AdminNoticeForm
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
            this.txtAdNotice = new System.Windows.Forms.TextBox();
            this.lVAdNotice = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Max = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtAdNoticeInput = new System.Windows.Forms.TextBox();
            this.btnAdNoticeFind = new System.Windows.Forms.Button();
            this.btnAdNoticeAdd = new System.Windows.Forms.Button();
            this.btnAdNoticeEdit = new System.Windows.Forms.Button();
            this.btnAdNoticeDel = new System.Windows.Forms.Button();
            this.ComboAdNoticeChoice = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdNotice
            // 
            this.txtAdNotice.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAdNotice.Location = new System.Drawing.Point(237, 75);
            this.txtAdNotice.Multiline = true;
            this.txtAdNotice.Name = "txtAdNotice";
            this.txtAdNotice.Size = new System.Drawing.Size(380, 426);
            this.txtAdNotice.TabIndex = 0;
            this.txtAdNotice.Text = "\r\n\r\n\r\n1.반납일은 철저하게 지켜주시길 바랍니다. \r\n2.질문하시고 싶으시면 문의게시판을 이용해 주시길 바랍니다.";
            this.txtAdNotice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lVAdNotice
            // 
            this.lVAdNotice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lVAdNotice.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lVAdNotice.GridLines = true;
            this.lVAdNotice.HideSelection = false;
            this.lVAdNotice.Location = new System.Drawing.Point(656, 75);
            this.lVAdNotice.Name = "lVAdNotice";
            this.lVAdNotice.Size = new System.Drawing.Size(543, 381);
            this.lVAdNotice.TabIndex = 5;
            this.lVAdNotice.UseCompatibleStateImageBehavior = false;
            this.lVAdNotice.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "번호";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "제목";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "내용";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 254;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "날짜";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(375, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "공지사항";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.Max, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Min, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 39);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // Max
            // 
            this.Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Max.FlatAppearance.BorderSize = 0;
            this.Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Max.Font = new System.Drawing.Font("굴림", 15F);
            this.Max.Location = new System.Drawing.Point(1307, 6);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(34, 29);
            this.Max.TabIndex = 3;
            this.Max.Text = "🗖";
            this.Max.UseVisualStyleBackColor = false;
            // 
            // Min
            // 
            this.Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Min.FlatAppearance.BorderSize = 0;
            this.Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min.Font = new System.Drawing.Font("굴림", 15F);
            this.Min.Location = new System.Drawing.Point(1267, 6);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(34, 29);
            this.Min.TabIndex = 2;
            this.Min.Text = "🗕";
            this.Min.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("굴림", 15F);
            this.button4.Location = new System.Drawing.Point(1347, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "🗙";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtAdNoticeInput
            // 
            this.txtAdNoticeInput.Location = new System.Drawing.Point(834, 479);
            this.txtAdNoticeInput.Multiline = true;
            this.txtAdNoticeInput.Name = "txtAdNoticeInput";
            this.txtAdNoticeInput.Size = new System.Drawing.Size(252, 20);
            this.txtAdNoticeInput.TabIndex = 25;
            // 
            // btnAdNoticeFind
            // 
            this.btnAdNoticeFind.BackColor = System.Drawing.Color.Gray;
            this.btnAdNoticeFind.FlatAppearance.BorderSize = 0;
            this.btnAdNoticeFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdNoticeFind.ForeColor = System.Drawing.Color.White;
            this.btnAdNoticeFind.Location = new System.Drawing.Point(1092, 479);
            this.btnAdNoticeFind.Name = "btnAdNoticeFind";
            this.btnAdNoticeFind.Size = new System.Drawing.Size(75, 20);
            this.btnAdNoticeFind.TabIndex = 24;
            this.btnAdNoticeFind.Text = "검 색";
            this.btnAdNoticeFind.UseVisualStyleBackColor = false;
            // 
            // btnAdNoticeAdd
            // 
            this.btnAdNoticeAdd.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdNoticeAdd.Location = new System.Drawing.Point(714, 518);
            this.btnAdNoticeAdd.Name = "btnAdNoticeAdd";
            this.btnAdNoticeAdd.Size = new System.Drawing.Size(94, 30);
            this.btnAdNoticeAdd.TabIndex = 2;
            this.btnAdNoticeAdd.Text = "추가";
            this.btnAdNoticeAdd.UseVisualStyleBackColor = true;
            this.btnAdNoticeAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdNoticeEdit
            // 
            this.btnAdNoticeEdit.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdNoticeEdit.Location = new System.Drawing.Point(857, 518);
            this.btnAdNoticeEdit.Name = "btnAdNoticeEdit";
            this.btnAdNoticeEdit.Size = new System.Drawing.Size(94, 30);
            this.btnAdNoticeEdit.TabIndex = 3;
            this.btnAdNoticeEdit.Text = "수정";
            this.btnAdNoticeEdit.UseVisualStyleBackColor = true;
            this.btnAdNoticeEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdNoticeDel
            // 
            this.btnAdNoticeDel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdNoticeDel.Location = new System.Drawing.Point(992, 518);
            this.btnAdNoticeDel.Name = "btnAdNoticeDel";
            this.btnAdNoticeDel.Size = new System.Drawing.Size(94, 30);
            this.btnAdNoticeDel.TabIndex = 4;
            this.btnAdNoticeDel.Text = "삭제";
            this.btnAdNoticeDel.UseVisualStyleBackColor = true;
            this.btnAdNoticeDel.Click += new System.EventHandler(this.button3_Click);
            // 
            // ComboAdNoticeChoice
            // 
            this.ComboAdNoticeChoice.FormattingEnabled = true;
            this.ComboAdNoticeChoice.Location = new System.Drawing.Point(707, 479);
            this.ComboAdNoticeChoice.Name = "ComboAdNoticeChoice";
            this.ComboAdNoticeChoice.Size = new System.Drawing.Size(121, 20);
            this.ComboAdNoticeChoice.TabIndex = 27;
            this.ComboAdNoticeChoice.Text = "제목";
            // 
            // AdminNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 571);
            this.Controls.Add(this.ComboAdNoticeChoice);
            this.Controls.Add(this.txtAdNoticeInput);
            this.Controls.Add(this.btnAdNoticeFind);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lVAdNotice);
            this.Controls.Add(this.btnAdNoticeDel);
            this.Controls.Add(this.btnAdNoticeEdit);
            this.Controls.Add(this.btnAdNoticeAdd);
            this.Controls.Add(this.txtAdNotice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminNoticeForm";
            this.Text = "공지사항";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdNotice;
        private System.Windows.Forms.ListView lVAdNotice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtAdNoticeInput;
        private System.Windows.Forms.Button btnAdNoticeFind;
        private System.Windows.Forms.Button btnAdNoticeAdd;
        private System.Windows.Forms.Button btnAdNoticeEdit;
        private System.Windows.Forms.Button btnAdNoticeDel;
        private System.Windows.Forms.ComboBox ComboAdNoticeChoice;
    }
}