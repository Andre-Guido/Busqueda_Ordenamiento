namespace Busqueda_Ordenamiento.Formularios
{
    partial class FrmInsertionSort
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBinaria = new System.Windows.Forms.Button();
            this.btnLineal = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tbRegistros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDurationSorted = new System.Windows.Forms.Label();
            this.lbDurationOriginal = new System.Windows.Forms.Label();
            this.lbTimeEndSorted = new System.Windows.Forms.Label();
            this.lbTimeEndOriginal = new System.Windows.Forms.Label();
            this.lbTimeIniSorted = new System.Windows.Forms.Label();
            this.lbTimeIniOriginal = new System.Windows.Forms.Label();
            this.lbOriginal = new System.Windows.Forms.ListBox();
            this.lbOrdenada = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBinaria);
            this.groupBox1.Controls.Add(this.btnLineal);
            this.groupBox1.Controls.Add(this.btnOrdenar);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.tbRegistros);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(73, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnBinaria
            // 
            this.btnBinaria.Location = new System.Drawing.Point(52, 174);
            this.btnBinaria.Name = "btnBinaria";
            this.btnBinaria.Size = new System.Drawing.Size(219, 32);
            this.btnBinaria.TabIndex = 5;
            this.btnBinaria.Text = "Búsqueda Binaria";
            this.btnBinaria.UseVisualStyleBackColor = true;
            // 
            // btnLineal
            // 
            this.btnLineal.Location = new System.Drawing.Point(52, 136);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(219, 32);
            this.btnLineal.TabIndex = 4;
            this.btnLineal.Text = "Búsqueda Lineal";
            this.btnLineal.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(189, 102);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(82, 28);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(52, 102);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(131, 28);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Números";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // tbRegistros
            // 
            this.tbRegistros.Location = new System.Drawing.Point(200, 17);
            this.tbRegistros.Name = "tbRegistros";
            this.tbRegistros.Size = new System.Drawing.Size(131, 26);
            this.tbRegistros.TabIndex = 1;
            this.tbRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Registros:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbOrdenada);
            this.groupBox2.Controls.Add(this.lbDurationSorted);
            this.groupBox2.Controls.Add(this.lbDurationOriginal);
            this.groupBox2.Controls.Add(this.lbTimeEndSorted);
            this.groupBox2.Controls.Add(this.lbTimeEndOriginal);
            this.groupBox2.Controls.Add(this.lbTimeIniSorted);
            this.groupBox2.Controls.Add(this.lbTimeIniOriginal);
            this.groupBox2.Controls.Add(this.lbOriginal);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(73, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 405);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registros:";
            // 
            // lbDurationSorted
            // 
            this.lbDurationSorted.AutoSize = true;
            this.lbDurationSorted.Location = new System.Drawing.Point(169, 322);
            this.lbDurationSorted.Name = "lbDurationSorted";
            this.lbDurationSorted.Size = new System.Drawing.Size(142, 19);
            this.lbDurationSorted.TabIndex = 7;
            this.lbDurationSorted.Text = "Duración: 0 Segundos";
            // 
            // lbDurationOriginal
            // 
            this.lbDurationOriginal.AutoSize = true;
            this.lbDurationOriginal.Location = new System.Drawing.Point(169, 132);
            this.lbDurationOriginal.Name = "lbDurationOriginal";
            this.lbDurationOriginal.Size = new System.Drawing.Size(142, 19);
            this.lbDurationOriginal.TabIndex = 6;
            this.lbDurationOriginal.Text = "Duración: 0 Segundos";
            // 
            // lbTimeEndSorted
            // 
            this.lbTimeEndSorted.AutoSize = true;
            this.lbTimeEndSorted.Location = new System.Drawing.Point(169, 288);
            this.lbTimeEndSorted.Name = "lbTimeEndSorted";
            this.lbTimeEndSorted.Size = new System.Drawing.Size(152, 19);
            this.lbTimeEndSorted.TabIndex = 5;
            this.lbTimeEndSorted.Text = "Tiempo de fin: 00:00:00";
            // 
            // lbTimeEndOriginal
            // 
            this.lbTimeEndOriginal.AutoSize = true;
            this.lbTimeEndOriginal.Location = new System.Drawing.Point(169, 98);
            this.lbTimeEndOriginal.Name = "lbTimeEndOriginal";
            this.lbTimeEndOriginal.Size = new System.Drawing.Size(152, 19);
            this.lbTimeEndOriginal.TabIndex = 4;
            this.lbTimeEndOriginal.Text = "Tiempo de fin: 00:00:00";
            // 
            // lbTimeIniSorted
            // 
            this.lbTimeIniSorted.AutoSize = true;
            this.lbTimeIniSorted.Location = new System.Drawing.Point(169, 257);
            this.lbTimeIniSorted.Name = "lbTimeIniSorted";
            this.lbTimeIniSorted.Size = new System.Drawing.Size(169, 19);
            this.lbTimeIniSorted.TabIndex = 3;
            this.lbTimeIniSorted.Text = "Tiempo de inicio: 00:00:00";
            // 
            // lbTimeIniOriginal
            // 
            this.lbTimeIniOriginal.AutoSize = true;
            this.lbTimeIniOriginal.Location = new System.Drawing.Point(169, 67);
            this.lbTimeIniOriginal.Name = "lbTimeIniOriginal";
            this.lbTimeIniOriginal.Size = new System.Drawing.Size(169, 19);
            this.lbTimeIniOriginal.TabIndex = 2;
            this.lbTimeIniOriginal.Text = "Tiempo de inicio: 00:00:00";
            // 
            // lbOriginal
            // 
            this.lbOriginal.FormattingEnabled = true;
            this.lbOriginal.ItemHeight = 19;
            this.lbOriginal.Location = new System.Drawing.Point(19, 26);
            this.lbOriginal.Name = "lbOriginal";
            this.lbOriginal.Size = new System.Drawing.Size(120, 175);
            this.lbOriginal.TabIndex = 0;
            // 
            // lbOrdenada
            // 
            this.lbOrdenada.FormattingEnabled = true;
            this.lbOrdenada.ItemHeight = 19;
            this.lbOrdenada.Location = new System.Drawing.Point(19, 212);
            this.lbOrdenada.Name = "lbOrdenada";
            this.lbOrdenada.Size = new System.Drawing.Size(120, 175);
            this.lbOrdenada.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "Al momento de generar los números, se generará una lista de números aleatorios en" +
    "tre 1 y 10,000.";
            // 
            // FrmInsertionSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(502, 657);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInsertionSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenamiento de Inserción ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox tbRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBinaria;
        private System.Windows.Forms.Button btnLineal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbOriginal;
        private System.Windows.Forms.Label lbDurationSorted;
        private System.Windows.Forms.Label lbDurationOriginal;
        private System.Windows.Forms.Label lbTimeEndSorted;
        private System.Windows.Forms.Label lbTimeEndOriginal;
        private System.Windows.Forms.Label lbTimeIniSorted;
        private System.Windows.Forms.Label lbTimeIniOriginal;
        private System.Windows.Forms.ListBox lbOrdenada;
        private System.Windows.Forms.Label label2;
    }
}