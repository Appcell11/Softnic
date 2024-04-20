namespace Ventas.CapaPresentacion
{
    partial class FrmControlRecibos
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
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.label_NoRecibo = new System.Windows.Forms.Label();
            this.txt_numRecibo = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_activarRecibo = new System.Windows.Forms.Button();
            this.Group_Recibos = new System.Windows.Forms.GroupBox();
            this.dgv_Recibos = new System.Windows.Forms.DataGridView();
            this.groupBoxActions.SuspendLayout();
            this.Group_Recibos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recibos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.label_NoRecibo);
            this.groupBoxActions.Controls.Add(this.txt_numRecibo);
            this.groupBoxActions.Controls.Add(this.btn_cancelar);
            this.groupBoxActions.Controls.Add(this.btn_activarRecibo);
            this.groupBoxActions.Location = new System.Drawing.Point(12, 364);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(509, 74);
            this.groupBoxActions.TabIndex = 0;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Acciones";
            // 
            // label_NoRecibo
            // 
            this.label_NoRecibo.AutoSize = true;
            this.label_NoRecibo.Location = new System.Drawing.Point(6, 32);
            this.label_NoRecibo.Name = "label_NoRecibo";
            this.label_NoRecibo.Size = new System.Drawing.Size(58, 13);
            this.label_NoRecibo.TabIndex = 3;
            this.label_NoRecibo.Text = "No Recibo";
            // 
            // txt_numRecibo
            // 
            this.txt_numRecibo.Location = new System.Drawing.Point(70, 29);
            this.txt_numRecibo.Name = "txt_numRecibo";
            this.txt_numRecibo.Size = new System.Drawing.Size(153, 20);
            this.txt_numRecibo.TabIndex = 2;
            this.txt_numRecibo.TextChanged += new System.EventHandler(this.txt_numRecibo_TextChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancelar.Location = new System.Drawing.Point(393, 19);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 39);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Eliminar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_activarRecibo
            // 
            this.btn_activarRecibo.BackColor = System.Drawing.Color.Green;
            this.btn_activarRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_activarRecibo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_activarRecibo.Location = new System.Drawing.Point(277, 19);
            this.btn_activarRecibo.Name = "btn_activarRecibo";
            this.btn_activarRecibo.Size = new System.Drawing.Size(110, 39);
            this.btn_activarRecibo.TabIndex = 0;
            this.btn_activarRecibo.Text = "Activar";
            this.btn_activarRecibo.UseVisualStyleBackColor = false;
            this.btn_activarRecibo.Click += new System.EventHandler(this.btn_activarRecibo_Click);
            // 
            // Group_Recibos
            // 
            this.Group_Recibos.Controls.Add(this.dgv_Recibos);
            this.Group_Recibos.Location = new System.Drawing.Point(12, 12);
            this.Group_Recibos.Name = "Group_Recibos";
            this.Group_Recibos.Size = new System.Drawing.Size(509, 346);
            this.Group_Recibos.TabIndex = 1;
            this.Group_Recibos.TabStop = false;
            this.Group_Recibos.Text = "Recibos";
            // 
            // dgv_Recibos
            // 
            this.dgv_Recibos.AllowUserToAddRows = false;
            this.dgv_Recibos.AllowUserToDeleteRows = false;
            this.dgv_Recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Recibos.Location = new System.Drawing.Point(7, 20);
            this.dgv_Recibos.MultiSelect = false;
            this.dgv_Recibos.Name = "dgv_Recibos";
            this.dgv_Recibos.ReadOnly = true;
            this.dgv_Recibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Recibos.Size = new System.Drawing.Size(496, 320);
            this.dgv_Recibos.TabIndex = 0;
            this.dgv_Recibos.SelectionChanged += new System.EventHandler(this.dgv_Recibos_SelectionChanged);
            // 
            // FrmControlRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.Group_Recibos);
            this.Controls.Add(this.groupBoxActions);
            this.MaximumSize = new System.Drawing.Size(549, 489);
            this.MinimumSize = new System.Drawing.Size(549, 489);
            this.Name = "FrmControlRecibos";
            this.Text = "FrmControlRecibos";
            this.Load += new System.EventHandler(this.FrmControlRecibos_Load);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.Group_Recibos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recibos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.GroupBox Group_Recibos;
        private System.Windows.Forms.DataGridView dgv_Recibos;
        private System.Windows.Forms.TextBox txt_numRecibo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_activarRecibo;
        private System.Windows.Forms.Label label_NoRecibo;
    }
}