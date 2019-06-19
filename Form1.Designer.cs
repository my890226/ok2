namespace _20190507datagird
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.myTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pw_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.male_radio = new System.Windows.Forms.RadioButton();
            this.female_radio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.remark_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.age_text = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.myTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_text)).BeginInit();
            this.SuspendLayout();
            // 
            // myTable
            // 
            this.myTable.BackgroundColor = System.Drawing.Color.White;
            this.myTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myTable.Location = new System.Drawing.Point(115, 12);
            this.myTable.Name = "myTable";
            this.myTable.RowTemplate.Height = 23;
            this.myTable.Size = new System.Drawing.Size(278, 224);
            this.myTable.TabIndex = 0;
            this.myTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myTable_CellDbClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "조회";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(16, 27);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(93, 21);
            this.name_txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "비밀번호";
            // 
            // pw_text
            // 
            this.pw_text.Location = new System.Drawing.Point(16, 72);
            this.pw_text.Name = "pw_text";
            this.pw_text.Size = new System.Drawing.Size(93, 21);
            this.pw_text.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "성별";
            // 
            // male_radio
            // 
            this.male_radio.AutoSize = true;
            this.male_radio.Location = new System.Drawing.Point(9, 121);
            this.male_radio.Name = "male_radio";
            this.male_radio.Size = new System.Drawing.Size(47, 16);
            this.male_radio.TabIndex = 12;
            this.male_radio.TabStop = true;
            this.male_radio.Text = "남자";
            this.male_radio.UseVisualStyleBackColor = true;
            // 
            // female_radio
            // 
            this.female_radio.AutoSize = true;
            this.female_radio.Location = new System.Drawing.Point(62, 121);
            this.female_radio.Name = "female_radio";
            this.female_radio.Size = new System.Drawing.Size(47, 16);
            this.female_radio.TabIndex = 13;
            this.female_radio.TabStop = true;
            this.female_radio.Text = "여자";
            this.female_radio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "기타";
            // 
            // remark_text
            // 
            this.remark_text.Location = new System.Drawing.Point(15, 207);
            this.remark_text.Multiline = true;
            this.remark_text.Name = "remark_text";
            this.remark_text.Size = new System.Drawing.Size(94, 63);
            this.remark_text.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "나이";
            // 
            // age_text
            // 
            this.age_text.Location = new System.Drawing.Point(17, 155);
            this.age_text.Name = "age_text";
            this.age_text.Size = new System.Drawing.Size(49, 21);
            this.age_text.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 288);
            this.Controls.Add(this.age_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.remark_text);
            this.Controls.Add(this.female_radio);
            this.Controls.Add(this.male_radio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pw_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_text)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView myTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pw_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton male_radio;
        private System.Windows.Forms.RadioButton female_radio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox remark_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown age_text;
    }
}

