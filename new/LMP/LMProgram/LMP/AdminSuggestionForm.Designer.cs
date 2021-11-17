
namespace LMP
{
    partial class AdminSuggestionForm
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
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ColumnHeader columnHeader4;
            System.Windows.Forms.ColumnHeader columnHeader5;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Max = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lVAdSuggest = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAdSuggestInput = new System.Windows.Forms.TextBox();
            this.btnAdSuggestDel = new System.Windows.Forms.Button();
            this.btnAdSuggestFind = new System.Windows.Forms.Button();
            this.ComboAdSuggestChoice = new System.Windows.Forms.ComboBox();
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "제목";
            columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader2.Width = 535;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "작성자";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "날짜";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "조회수";
            columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader5.Width = 87;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1411, 40);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // Max
            // 
            this.Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Max.FlatAppearance.BorderSize = 0;
            this.Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Max.Font = new System.Drawing.Font("굴림", 15F);
            this.Max.Location = new System.Drawing.Point(1334, 7);
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
            this.Min.Location = new System.Drawing.Point(1294, 7);
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
            this.button4.Location = new System.Drawing.Point(1374, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "🗙";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // lVAdSuggest
            // 
            this.lVAdSuggest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4,
            columnHeader5});
            this.lVAdSuggest.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lVAdSuggest.GridLines = true;
            this.lVAdSuggest.HideSelection = false;
            this.lVAdSuggest.Location = new System.Drawing.Point(216, 41);
            this.lVAdSuggest.Name = "lVAdSuggest";
            this.lVAdSuggest.Size = new System.Drawing.Size(982, 426);
            this.lVAdSuggest.TabIndex = 19;
            this.lVAdSuggest.UseCompatibleStateImageBehavior = false;
            this.lVAdSuggest.View = System.Windows.Forms.View.Details;
            this.lVAdSuggest.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "번호";
            this.columnHeader1.Width = 59;
            // 
            // txtAdSuggestInput
            // 
            this.txtAdSuggestInput.Location = new System.Drawing.Point(590, 525);
            this.txtAdSuggestInput.Multiline = true;
            this.txtAdSuggestInput.Name = "txtAdSuggestInput";
            this.txtAdSuggestInput.Size = new System.Drawing.Size(252, 20);
            this.txtAdSuggestInput.TabIndex = 26;
            // 
            // btnAdSuggestDel
            // 
            this.btnAdSuggestDel.BackColor = System.Drawing.Color.Gray;
            this.btnAdSuggestDel.FlatAppearance.BorderSize = 0;
            this.btnAdSuggestDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdSuggestDel.ForeColor = System.Drawing.Color.White;
            this.btnAdSuggestDel.Location = new System.Drawing.Point(1123, 473);
            this.btnAdSuggestDel.Name = "btnAdSuggestDel";
            this.btnAdSuggestDel.Size = new System.Drawing.Size(75, 25);
            this.btnAdSuggestDel.TabIndex = 24;
            this.btnAdSuggestDel.Text = "삭 제";
            this.btnAdSuggestDel.UseVisualStyleBackColor = false;
            // 
            // btnAdSuggestFind
            // 
            this.btnAdSuggestFind.BackColor = System.Drawing.Color.Gray;
            this.btnAdSuggestFind.FlatAppearance.BorderSize = 0;
            this.btnAdSuggestFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdSuggestFind.ForeColor = System.Drawing.Color.White;
            this.btnAdSuggestFind.Location = new System.Drawing.Point(848, 525);
            this.btnAdSuggestFind.Name = "btnAdSuggestFind";
            this.btnAdSuggestFind.Size = new System.Drawing.Size(75, 20);
            this.btnAdSuggestFind.TabIndex = 25;
            this.btnAdSuggestFind.Text = "검 색";
            this.btnAdSuggestFind.UseVisualStyleBackColor = false;
            // 
            // ComboAdSuggestChoice
            // 
            this.ComboAdSuggestChoice.FormattingEnabled = true;
            this.ComboAdSuggestChoice.Location = new System.Drawing.Point(463, 525);
            this.ComboAdSuggestChoice.Name = "ComboAdSuggestChoice";
            this.ComboAdSuggestChoice.Size = new System.Drawing.Size(121, 20);
            this.ComboAdSuggestChoice.TabIndex = 28;
            this.ComboAdSuggestChoice.Text = "제목";
            // 
            // AdminSuggestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 606);
            this.Controls.Add(this.ComboAdSuggestChoice);
            this.Controls.Add(this.txtAdSuggestInput);
            this.Controls.Add(this.btnAdSuggestDel);
            this.Controls.Add(this.btnAdSuggestFind);
            this.Controls.Add(this.lVAdSuggest);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSuggestionForm";
            this.Text = "SuggestionForm";
            this.Load += new System.EventHandler(this.SuggestionForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView lVAdSuggest;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtAdSuggestInput;
        private System.Windows.Forms.Button btnAdSuggestDel;
        private System.Windows.Forms.Button btnAdSuggestFind;
        private System.Windows.Forms.ComboBox ComboAdSuggestChoice;
    }
}