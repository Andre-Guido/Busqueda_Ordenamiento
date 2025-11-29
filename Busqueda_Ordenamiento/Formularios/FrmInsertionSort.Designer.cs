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
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tbRegistros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumBuscado = new System.Windows.Forms.TextBox();
            this.btnBinaria = new System.Windows.Forms.Button();
            this.btnLineal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstOrdenada = new System.Windows.Forms.ListBox();
            this.lblDurationSorted = new System.Windows.Forms.Label();
            this.lblDurationOriginal = new System.Windows.Forms.Label();
            this.lblTimeEndSorted = new System.Windows.Forms.Label();
            this.lblTimeEndOriginal = new System.Windows.Forms.Label();
            this.lblTimeIniSorted = new System.Windows.Forms.Label();
            this.lblTimeIniOriginal = new System.Windows.Forms.Label();
            this.lstOriginal = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDurationSearch = new System.Windows.Forms.Label();
            this.lblTimeEndBusqueda = new System.Windows.Forms.Label();
            this.lblTimeIniBusqueda = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnOrdenar);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.tbRegistros);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
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
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(189, 102);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(82, 28);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(52, 102);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(131, 28);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Números";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // tbRegistros
            // 
            this.tbRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(37, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor a buscar:";
            // 
            // tbNumBuscado
            // 
            this.tbNumBuscado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbNumBuscado.Location = new System.Drawing.Point(142, 30);
            this.tbNumBuscado.Name = "tbNumBuscado";
            this.tbNumBuscado.Size = new System.Drawing.Size(104, 26);
            this.tbNumBuscado.TabIndex = 6;
            this.tbNumBuscado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBinaria
            // 
            this.btnBinaria.Location = new System.Drawing.Point(41, 62);
            this.btnBinaria.Name = "btnBinaria";
            this.btnBinaria.Size = new System.Drawing.Size(131, 32);
            this.btnBinaria.TabIndex = 5;
            this.btnBinaria.Text = "Búsqueda Binaria";
            this.btnBinaria.UseVisualStyleBackColor = true;
            this.btnBinaria.Click += new System.EventHandler(this.btnBinaria_Click);
            // 
            // btnLineal
            // 
            this.btnLineal.Location = new System.Drawing.Point(41, 100);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(131, 32);
            this.btnLineal.TabIndex = 4;
            this.btnLineal.Text = "Búsqueda Lineal";
            this.btnLineal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstOrdenada);
            this.groupBox2.Controls.Add(this.lblDurationSorted);
            this.groupBox2.Controls.Add(this.lblDurationOriginal);
            this.groupBox2.Controls.Add(this.lblTimeEndSorted);
            this.groupBox2.Controls.Add(this.lblTimeEndOriginal);
            this.groupBox2.Controls.Add(this.lblTimeIniSorted);
            this.groupBox2.Controls.Add(this.lblTimeIniOriginal);
            this.groupBox2.Controls.Add(this.lstOriginal);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 405);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registros:";
            // 
            // lstOrdenada
            // 
            this.lstOrdenada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstOrdenada.FormattingEnabled = true;
            this.lstOrdenada.ItemHeight = 19;
            this.lstOrdenada.Location = new System.Drawing.Point(19, 212);
            this.lstOrdenada.Name = "lstOrdenada";
            this.lstOrdenada.Size = new System.Drawing.Size(120, 175);
            this.lstOrdenada.TabIndex = 8;
            // 
            // lblDurationSorted
            // 
            this.lblDurationSorted.AutoSize = true;
            this.lblDurationSorted.Location = new System.Drawing.Point(169, 322);
            this.lblDurationSorted.Name = "lblDurationSorted";
            this.lblDurationSorted.Size = new System.Drawing.Size(142, 19);
            this.lblDurationSorted.TabIndex = 7;
            this.lblDurationSorted.Text = "Duración: 0 Segundos";
            // 
            // lblDurationOriginal
            // 
            this.lblDurationOriginal.AutoSize = true;
            this.lblDurationOriginal.Location = new System.Drawing.Point(169, 132);
            this.lblDurationOriginal.Name = "lblDurationOriginal";
            this.lblDurationOriginal.Size = new System.Drawing.Size(142, 19);
            this.lblDurationOriginal.TabIndex = 6;
            this.lblDurationOriginal.Text = "Duración: 0 Segundos";
            // 
            // lblTimeEndSorted
            // 
            this.lblTimeEndSorted.AutoSize = true;
            this.lblTimeEndSorted.Location = new System.Drawing.Point(169, 288);
            this.lblTimeEndSorted.Name = "lblTimeEndSorted";
            this.lblTimeEndSorted.Size = new System.Drawing.Size(152, 19);
            this.lblTimeEndSorted.TabIndex = 5;
            this.lblTimeEndSorted.Text = "Tiempo de fin: 00:00:00";
            // 
            // lblTimeEndOriginal
            // 
            this.lblTimeEndOriginal.AutoSize = true;
            this.lblTimeEndOriginal.Location = new System.Drawing.Point(169, 98);
            this.lblTimeEndOriginal.Name = "lblTimeEndOriginal";
            this.lblTimeEndOriginal.Size = new System.Drawing.Size(152, 19);
            this.lblTimeEndOriginal.TabIndex = 4;
            this.lblTimeEndOriginal.Text = "Tiempo de fin: 00:00:00";
            // 
            // lblTimeIniSorted
            // 
            this.lblTimeIniSorted.AutoSize = true;
            this.lblTimeIniSorted.Location = new System.Drawing.Point(169, 257);
            this.lblTimeIniSorted.Name = "lblTimeIniSorted";
            this.lblTimeIniSorted.Size = new System.Drawing.Size(169, 19);
            this.lblTimeIniSorted.TabIndex = 3;
            this.lblTimeIniSorted.Text = "Tiempo de inicio: 00:00:00";
            // 
            // lblTimeIniOriginal
            // 
            this.lblTimeIniOriginal.AutoSize = true;
            this.lblTimeIniOriginal.Location = new System.Drawing.Point(169, 67);
            this.lblTimeIniOriginal.Name = "lblTimeIniOriginal";
            this.lblTimeIniOriginal.Size = new System.Drawing.Size(169, 19);
            this.lblTimeIniOriginal.TabIndex = 2;
            this.lblTimeIniOriginal.Text = "Tiempo de inicio: 00:00:00";
            // 
            // lstOriginal
            // 
            this.lstOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstOriginal.FormattingEnabled = true;
            this.lstOriginal.ItemHeight = 19;
            this.lstOriginal.Location = new System.Drawing.Point(19, 26);
            this.lstOriginal.Name = "lstOriginal";
            this.lstOriginal.Size = new System.Drawing.Size(120, 175);
            this.lstOriginal.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDurationSearch);
            this.groupBox3.Controls.Add(this.lblTimeEndBusqueda);
            this.groupBox3.Controls.Add(this.lblTimeIniBusqueda);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbNumBuscado);
            this.groupBox3.Controls.Add(this.btnLineal);
            this.groupBox3.Controls.Add(this.btnBinaria);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(405, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 252);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda";
            // 
            // lblDurationSearch
            // 
            this.lblDurationSearch.AutoSize = true;
            this.lblDurationSearch.Location = new System.Drawing.Point(37, 204);
            this.lblDurationSearch.Name = "lblDurationSearch";
            this.lblDurationSearch.Size = new System.Drawing.Size(142, 19);
            this.lblDurationSearch.TabIndex = 10;
            this.lblDurationSearch.Text = "Duración: 0 Segundos";
            // 
            // lblTimeEndBusqueda
            // 
            this.lblTimeEndBusqueda.AutoSize = true;
            this.lblTimeEndBusqueda.Location = new System.Drawing.Point(37, 170);
            this.lblTimeEndBusqueda.Name = "lblTimeEndBusqueda";
            this.lblTimeEndBusqueda.Size = new System.Drawing.Size(152, 19);
            this.lblTimeEndBusqueda.TabIndex = 9;
            this.lblTimeEndBusqueda.Text = "Tiempo de fin: 00:00:00";
            // 
            // lblTimeIniBusqueda
            // 
            this.lblTimeIniBusqueda.AutoSize = true;
            this.lblTimeIniBusqueda.Location = new System.Drawing.Point(37, 139);
            this.lblTimeIniBusqueda.Name = "lblTimeIniBusqueda";
            this.lblTimeIniBusqueda.Size = new System.Drawing.Size(169, 19);
            this.lblTimeIniBusqueda.TabIndex = 8;
            this.lblTimeIniBusqueda.Text = "Tiempo de inicio: 00:00:00";
            // 
            // FrmInsertionSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(715, 588);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInsertionSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenamiento de Inserción ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.ListBox lstOriginal;
        private System.Windows.Forms.Label lblDurationSorted;
        private System.Windows.Forms.Label lblDurationOriginal;
        private System.Windows.Forms.Label lblTimeEndSorted;
        private System.Windows.Forms.Label lblTimeEndOriginal;
        private System.Windows.Forms.Label lblTimeIniSorted;
        private System.Windows.Forms.Label lblTimeIniOriginal;
        private System.Windows.Forms.ListBox lstOrdenada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumBuscado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDurationSearch;
        private System.Windows.Forms.Label lblTimeEndBusqueda;
        private System.Windows.Forms.Label lblTimeIniBusqueda;
    }
}