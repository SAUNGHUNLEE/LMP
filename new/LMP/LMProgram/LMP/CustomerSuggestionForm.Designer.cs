
namespace LMP
{
    partial class CustomerSuggestionForm
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
            this.txtCusSuggestInput = new System.Windows.Forms.TextBox();
            this.btnCusSuggestDel = new System.Windows.Forms.Button();
            this.btnCusSuggestFind = new System.Windows.Forms.Button();
            this.lVCusSuggest = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComboCusSuggestChoice = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1330, 40);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // Max
            // 
            this.Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Max.FlatAppearance.BorderSize = 0;
            this.Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Max.Font = new System.Drawing.Font("굴림", 15F);
            this.Max.Location = new System.Drawing.Point(1253, 7);
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
            this.Min.Location = new System.Drawing.Point(1213, 7);
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
            this.button4.Location = new System.Drawing.Point(1293, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "🗙";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtCusSuggestInput
            // 
            this.txtCusSuggestInput.Location = new System.Drawing.Point(554, 546);
            this.txtCusSuggestInput.Multiline = true;
            this.txtCusSuggestInput.Name = "txtCusSuggestInput";
            this.txtCusSuggestInput.Size = new System.Drawing.Size(252, 20);
            this.txtCusSuggestInput.TabIndex = 31;
            // 
            // btnCusSuggestDel
            // 
            this.btnCusSuggestDel.BackColor = System.Drawing.Color.Gray;
            this.btnCusSuggestDel.FlatAppearance.BorderSize = 0;
            this.btnCusSuggestDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusSuggestDel.ForeColor = System.Drawing.Color.White;
            this.btnCusSuggestDel.Location = new System.Drawing.Point(1087, 511);
            this.btnCusSuggestDel.Name = "btnCusSuggestDel";
            this.btnCusSuggestDel.Size = new System.Drawing.Size(75, 25);
            this.btnCusSuggestDel.TabIndex = 29;
            this.btnCusSuggestDel.Text = "새글작성";
            this.btnCusSuggestDel.UseVisualStyleBackColor = false;
            // 
            // btnCusSuggestFind
            // 
            this.btnCusSuggestFind.BackColor = System.Drawing.Color.Gray;
            this.btnCusSuggestFind.FlatAppearance.BorderSize = 0;
            this.btnCusSuggestFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusSuggestFind.ForeColor = System.Drawing.Color.White;
            this.btnCusSuggestFind.Location = new System.Drawing.Point(824, 546);
            this.btnCusSuggestFind.Name = "btnCusSuggestFind";
            this.btnCusSuggestFind.Size = new System.Drawing.Size(75, 20);
            this.btnCusSuggestFind.TabIndex = 30;
            this.btnCusSuggestFind.Text = "검 색";
            this.btnCusSuggestFind.UseVisualStyleBackColor = false;
            // 
            // lVCusSuggest
            // 
            this.lVCusSuggest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4,
            columnHeader5});
            this.lVCusSuggest.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lVCusSuggest.GridLines = true;
            this.lVCusSuggest.HideSelection = false;
            this.lVCusSuggest.Location = new System.Drawing.Point(180, 79);
            this.lVCusSuggest.Name = "lVCusSuggest";
            this.lVCusSuggest.Size = new System.Drawing.Size(982, 426);
            this.lVCusSuggest.TabIndex = 28;
            this.lVCusSuggest.UseCompatibleStateImageBehavior = false;
            this.lVCusSuggest.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "번호";
            this.columnHeader1.Width = 59;
            // 
            // ComboCusSuggestChoice
            // 
            this.ComboCusSuggestChoice.FormattingEnabled = true;
            this.ComboCusSuggestChoice.Location = new System.Drawing.Point(413, 546);
            this.ComboCusSuggestChoice.Name = "ComboCusSuggestChoice";
            this.ComboCusSuggestChoice.Size = new System.Drawing.Size(121, 20);
            this.ComboCusSuggestChoice.TabIndex = 33;
            this.ComboCusSuggestChoice.Text = "제목";
            // 
            // CustomerSuggestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 611);
            this.Controls.Add(this.ComboCusSuggestChoice);
            this.Controls.Add(this.txtCusSuggestInput);
            this.Controls.Add(this.btnCusSuggestDel);
            this.Controls.Add(this.btnCusSuggestFind);
            this.Controls.Add(this.lVCusSuggest);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerSuggestionForm";
            this.Text = "CustomerSuggestion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCusSuggestInput;
        private System.Windows.Forms.Button btnCusSuggestDel;
        private System.Windows.Forms.Button btnCusSuggestFind;
        private System.Windows.Forms.ListView lVCusSuggest;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox ComboCusSuggestChoice;
    }
}