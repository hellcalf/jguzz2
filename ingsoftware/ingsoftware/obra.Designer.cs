namespace ingsoftware
{
    partial class obra
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_num_contrato = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.cb_dia_ini = new System.Windows.Forms.ComboBox();
            this.cb_mes_ini = new System.Windows.Forms.ComboBox();
            this.cb_año_ini = new System.Windows.Forms.ComboBox();
            this.cb_dia_fin = new System.Windows.Forms.ComboBox();
            this.cb_mes_fin = new System.Windows.Forms.ComboBox();
            this.cb_año_fin = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero De Contrato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(123, 56);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(144, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // txt_num_contrato
            // 
            this.txt_num_contrato.Location = new System.Drawing.Point(123, 92);
            this.txt_num_contrato.Margin = new System.Windows.Forms.Padding(2);
            this.txt_num_contrato.Name = "txt_num_contrato";
            this.txt_num_contrato.Size = new System.Drawing.Size(144, 20);
            this.txt_num_contrato.TabIndex = 4;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(123, 125);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(144, 20);
            this.txt_direccion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha Fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estado ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cliente";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(62, 264);
            this.cb_estado.Margin = new System.Windows.Forms.Padding(2);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(62, 21);
            this.cb_estado.TabIndex = 10;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(174, 266);
            this.txt_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(84, 20);
            this.txt_cliente.TabIndex = 11;
            // 
            // cb_dia_ini
            // 
            this.cb_dia_ini.FormattingEnabled = true;
            this.cb_dia_ini.Location = new System.Drawing.Point(88, 177);
            this.cb_dia_ini.Margin = new System.Windows.Forms.Padding(2);
            this.cb_dia_ini.Name = "cb_dia_ini";
            this.cb_dia_ini.Size = new System.Drawing.Size(42, 21);
            this.cb_dia_ini.TabIndex = 12;
            // 
            // cb_mes_ini
            // 
            this.cb_mes_ini.FormattingEnabled = true;
            this.cb_mes_ini.Location = new System.Drawing.Point(134, 177);
            this.cb_mes_ini.Margin = new System.Windows.Forms.Padding(2);
            this.cb_mes_ini.Name = "cb_mes_ini";
            this.cb_mes_ini.Size = new System.Drawing.Size(41, 21);
            this.cb_mes_ini.TabIndex = 13;
            // 
            // cb_año_ini
            // 
            this.cb_año_ini.FormattingEnabled = true;
            this.cb_año_ini.Location = new System.Drawing.Point(182, 177);
            this.cb_año_ini.Margin = new System.Windows.Forms.Padding(2);
            this.cb_año_ini.Name = "cb_año_ini";
            this.cb_año_ini.Size = new System.Drawing.Size(92, 21);
            this.cb_año_ini.TabIndex = 14;
            // 
            // cb_dia_fin
            // 
            this.cb_dia_fin.FormattingEnabled = true;
            this.cb_dia_fin.Location = new System.Drawing.Point(88, 215);
            this.cb_dia_fin.Margin = new System.Windows.Forms.Padding(2);
            this.cb_dia_fin.Name = "cb_dia_fin";
            this.cb_dia_fin.Size = new System.Drawing.Size(42, 21);
            this.cb_dia_fin.TabIndex = 15;
            // 
            // cb_mes_fin
            // 
            this.cb_mes_fin.FormattingEnabled = true;
            this.cb_mes_fin.Location = new System.Drawing.Point(134, 215);
            this.cb_mes_fin.Margin = new System.Windows.Forms.Padding(2);
            this.cb_mes_fin.Name = "cb_mes_fin";
            this.cb_mes_fin.Size = new System.Drawing.Size(41, 21);
            this.cb_mes_fin.TabIndex = 16;
            // 
            // cb_año_fin
            // 
            this.cb_año_fin.FormattingEnabled = true;
            this.cb_año_fin.Location = new System.Drawing.Point(182, 215);
            this.cb_año_fin.Margin = new System.Windows.Forms.Padding(2);
            this.cb_año_fin.Name = "cb_año_fin";
            this.cb_año_fin.Size = new System.Drawing.Size(92, 21);
            this.cb_año_fin.TabIndex = 17;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(123, 328);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 18;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(214, 328);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // obra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 377);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cb_año_fin);
            this.Controls.Add(this.cb_mes_fin);
            this.Controls.Add(this.cb_dia_fin);
            this.Controls.Add(this.cb_año_ini);
            this.Controls.Add(this.cb_mes_ini);
            this.Controls.Add(this.cb_dia_ini);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_num_contrato);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "obra";
            this.Text = "obra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_num_contrato;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.ComboBox cb_dia_ini;
        private System.Windows.Forms.ComboBox cb_mes_ini;
        private System.Windows.Forms.ComboBox cb_año_ini;
        private System.Windows.Forms.ComboBox cb_dia_fin;
        private System.Windows.Forms.ComboBox cb_mes_fin;
        private System.Windows.Forms.ComboBox cb_año_fin;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}