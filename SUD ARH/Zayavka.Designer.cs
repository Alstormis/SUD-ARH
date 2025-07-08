namespace SUD_ARH
{
    partial class Zayavka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zayavka));
            this.Salir = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Case_number = new System.Windows.Forms.Label();
            this.Dobav = new System.Windows.Forms.Button();
            this.Case_number_1 = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.Name_zayavka = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(858, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 6;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(822, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 7;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "НАЗАД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 108);
            this.label1.TabIndex = 10;
            this.label1.Text = "ЗАЯВКА НА \r\nВЫДАЧУ ДОКУМЕНТА";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 23.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "ФАМИЛИЯ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 23.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(258, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 42);
            this.label3.TabIndex = 12;
            this.label3.Text = "ИМЯ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 23.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(181, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "ОТЧЕСТВО";
            // 
            // Case_number
            // 
            this.Case_number.AutoSize = true;
            this.Case_number.Font = new System.Drawing.Font("Roboto Cn", 23.25F);
            this.Case_number.ForeColor = System.Drawing.Color.White;
            this.Case_number.Location = new System.Drawing.Point(146, 401);
            this.Case_number.Name = "Case_number";
            this.Case_number.Size = new System.Drawing.Size(188, 42);
            this.Case_number.TabIndex = 14;
            this.Case_number.Text = "НОМЕР ДЕЛА";
            // 
            // Dobav
            // 
            this.Dobav.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Dobav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Dobav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dobav.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dobav.ForeColor = System.Drawing.Color.White;
            this.Dobav.Location = new System.Drawing.Point(444, 476);
            this.Dobav.Name = "Dobav";
            this.Dobav.Size = new System.Drawing.Size(180, 46);
            this.Dobav.TabIndex = 114;
            this.Dobav.Text = "ПОДАТЬ ЗАЯВКУ";
            this.Dobav.UseVisualStyleBackColor = true;
            this.Dobav.Click += new System.EventHandler(this.Dobav_Click);
            // 
            // Case_number_1
            // 
            this.Case_number_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Case_number_1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Case_number_1.ForeColor = System.Drawing.Color.White;
            this.Case_number_1.Location = new System.Drawing.Point(353, 401);
            this.Case_number_1.Name = "Case_number_1";
            this.Case_number_1.Size = new System.Drawing.Size(392, 44);
            this.Case_number_1.TabIndex = 115;
            // 
            // Patronymic
            // 
            this.Patronymic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Patronymic.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronymic.ForeColor = System.Drawing.Color.White;
            this.Patronymic.Location = new System.Drawing.Point(353, 335);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(392, 44);
            this.Patronymic.TabIndex = 116;
            // 
            // Name_zayavka
            // 
            this.Name_zayavka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Name_zayavka.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_zayavka.ForeColor = System.Drawing.Color.White;
            this.Name_zayavka.Location = new System.Drawing.Point(353, 263);
            this.Name_zayavka.Name = "Name_zayavka";
            this.Name_zayavka.Size = new System.Drawing.Size(392, 44);
            this.Name_zayavka.TabIndex = 117;
            // 
            // Surname
            // 
            this.Surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Surname.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.ForeColor = System.Drawing.Color.White;
            this.Surname.Location = new System.Drawing.Point(353, 192);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(392, 44);
            this.Surname.TabIndex = 118;
            // 
            // Zayavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name_zayavka);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.Case_number_1);
            this.Controls.Add(this.Dobav);
            this.Controls.Add(this.Case_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Minimizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Zayavka";
            this.Text = "Zayavka";
            this.Load += new System.EventHandler(this.Zayavka_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Zayavka_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Case_number;
        private System.Windows.Forms.Button Dobav;
        private System.Windows.Forms.TextBox Case_number_1;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.TextBox Name_zayavka;
        private System.Windows.Forms.TextBox Surname;
    }
}