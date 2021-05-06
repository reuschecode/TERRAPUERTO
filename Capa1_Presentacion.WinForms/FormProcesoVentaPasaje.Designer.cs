
namespace Capa1_Presentacion.WinForms
{
    partial class FormProcesoVentaPasaje
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
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpRetorno = new System.Windows.Forms.DateTimePicker();
            this.dtpIda = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEmbarque = new System.Windows.Forms.ComboBox();
            this.comboBoxDesembarque = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViajes
            // 
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(12, 51);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.Size = new System.Drawing.Size(530, 366);
            this.dgvViajes.TabIndex = 0;
            this.dgvViajes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Viajes disponibles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Embarque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desembarque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de ida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de retorno:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpRetorno
            // 
            this.dtpRetorno.Location = new System.Drawing.Point(572, 338);
            this.dtpRetorno.Name = "dtpRetorno";
            this.dtpRetorno.Size = new System.Drawing.Size(200, 20);
            this.dtpRetorno.TabIndex = 7;
            // 
            // dtpIda
            // 
            this.dtpIda.Location = new System.Drawing.Point(573, 253);
            this.dtpIda.Name = "dtpIda";
            this.dtpIda.Size = new System.Drawing.Size(200, 20);
            this.dtpIda.TabIndex = 8;
            // 
            // comboBoxEmbarque
            // 
            this.comboBoxEmbarque.FormattingEnabled = true;
            this.comboBoxEmbarque.Location = new System.Drawing.Point(573, 94);
            this.comboBoxEmbarque.Name = "comboBoxEmbarque";
            this.comboBoxEmbarque.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEmbarque.TabIndex = 9;
            // 
            // comboBoxDesembarque
            // 
            this.comboBoxDesembarque.FormattingEnabled = true;
            this.comboBoxDesembarque.Location = new System.Drawing.Point(573, 169);
            this.comboBoxDesembarque.Name = "comboBoxDesembarque";
            this.comboBoxDesembarque.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDesembarque.TabIndex = 10;
            // 
            // FormProcesoVentaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxDesembarque);
            this.Controls.Add(this.comboBoxEmbarque);
            this.Controls.Add(this.dtpIda);
            this.Controls.Add(this.dtpRetorno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvViajes);
            this.Name = "FormProcesoVentaPasaje";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormProcesoVentaPasaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpRetorno;
        private System.Windows.Forms.DateTimePicker dtpIda;
        private System.Windows.Forms.ComboBox comboBoxEmbarque;
        private System.Windows.Forms.ComboBox comboBoxDesembarque;
    }
}