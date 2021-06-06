namespace NumberReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Input = new System.Windows.Forms.Label();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.gbx_Language = new System.Windows.Forms.GroupBox();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.rbt_Vietnamese = new System.Windows.Forms.RadioButton();
            this.btn_Read = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Speak = new System.Windows.Forms.Button();
            this.gbx_Language.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Input.Font = new System.Drawing.Font("UTM Hanzel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Input.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Input.Location = new System.Drawing.Point(39, 44);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(89, 25);
            this.lbl_Input.TabIndex = 0;
            this.lbl_Input.Text = "Nhập Số: ";
            // 
            // txt_Input
            // 
            this.txt_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Input.Location = new System.Drawing.Point(127, 45);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(435, 24);
            this.txt_Input.TabIndex = 1;
            this.txt_Input.TextChanged += new System.EventHandler(this.txt_Input_TextChanged);
            this.txt_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Input_KeyPress);
            this.txt_Input.MouseHover += new System.EventHandler(this.txt_Input_MouseHover);
            // 
            // gbx_Language
            // 
            this.gbx_Language.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Language.Controls.Add(this.rbt_English);
            this.gbx_Language.Controls.Add(this.rbt_Vietnamese);
            this.gbx_Language.Font = new System.Drawing.Font("UTM Hanzel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Language.ForeColor = System.Drawing.Color.White;
            this.gbx_Language.Location = new System.Drawing.Point(43, 88);
            this.gbx_Language.Name = "gbx_Language";
            this.gbx_Language.Size = new System.Drawing.Size(524, 77);
            this.gbx_Language.TabIndex = 2;
            this.gbx_Language.TabStop = false;
            this.gbx_Language.Text = "Ngôn Ngữ";
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Font = new System.Drawing.Font("UTM Hanzel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_English.ForeColor = System.Drawing.Color.DarkOrange;
            this.rbt_English.Location = new System.Drawing.Point(330, 33);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(112, 29);
            this.rbt_English.TabIndex = 1;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "Tiếng Anh";
            this.rbt_English.UseVisualStyleBackColor = true;
            // 
            // rbt_Vietnamese
            // 
            this.rbt_Vietnamese.AutoSize = true;
            this.rbt_Vietnamese.Font = new System.Drawing.Font("UTM Hanzel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Vietnamese.ForeColor = System.Drawing.Color.DarkOrange;
            this.rbt_Vietnamese.Location = new System.Drawing.Point(64, 33);
            this.rbt_Vietnamese.Name = "rbt_Vietnamese";
            this.rbt_Vietnamese.Size = new System.Drawing.Size(112, 29);
            this.rbt_Vietnamese.TabIndex = 0;
            this.rbt_Vietnamese.TabStop = true;
            this.rbt_Vietnamese.Text = "Tiếng Việt";
            this.rbt_Vietnamese.UseVisualStyleBackColor = true;
            this.rbt_Vietnamese.CheckedChanged += new System.EventHandler(this.rbt_Vietnamese_CheckedChanged);
            // 
            // btn_Read
            // 
            this.btn_Read.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Read.Font = new System.Drawing.Font("UTM Davida", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read.ForeColor = System.Drawing.Color.Black;
            this.btn_Read.Location = new System.Drawing.Point(442, 171);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(125, 34);
            this.btn_Read.TabIndex = 3;
            this.btn_Read.Text = "Đọc Số";
            this.btn_Read.UseVisualStyleBackColor = false;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Result.Font = new System.Drawing.Font("UTM Hanzel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result.Location = new System.Drawing.Point(45, 214);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Result.Size = new System.Drawing.Size(522, 144);
            this.txt_Result.TabIndex = 4;
            this.txt_Result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Result_KeyPress);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Close.Font = new System.Drawing.Font("UTM Davida", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Location = new System.Drawing.Point(437, 366);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(125, 34);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Speak
            // 
            this.btn_Speak.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Speak.Font = new System.Drawing.Font("UTM Davida", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Speak.ForeColor = System.Drawing.Color.Black;
            this.btn_Speak.Location = new System.Drawing.Point(311, 171);
            this.btn_Speak.Name = "btn_Speak";
            this.btn_Speak.Size = new System.Drawing.Size(125, 34);
            this.btn_Speak.TabIndex = 6;
            this.btn_Speak.Text = "Phát âm";
            this.btn_Speak.UseVisualStyleBackColor = false;
            this.btn_Speak.Click += new System.EventHandler(this.btn_Speak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 420);
            this.Controls.Add(this.btn_Speak);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.gbx_Language);
            this.Controls.Add(this.lbl_Input);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đọc Số Nguyên";
            this.gbx_Language.ResumeLayout(false);
            this.gbx_Language.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.GroupBox gbx_Language;
        private System.Windows.Forms.RadioButton rbt_English;
        private System.Windows.Forms.RadioButton rbt_Vietnamese;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Speak;
    }
}

