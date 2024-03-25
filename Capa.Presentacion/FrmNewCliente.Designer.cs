﻿namespace Ventas.CapaPresentacion
{
    partial class FrmNewCliente
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmb_sexo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_SegundoApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_PrimerApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SegundoNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_PrimerNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NumeroCedula = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Find);
            this.groupBox3.Controls.Add(this.btn_Update);
            this.groupBox3.Controls.Add(this.dgv_Clientes);
            this.groupBox3.Controls.Add(this.btn_Remove);
            this.groupBox3.Controls.Add(this.btn_Add);
            this.groupBox3.Location = new System.Drawing.Point(217, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 328);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de clientes";
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Find.BackgroundImage = global::Ventas.CapaPresentacion.Properties.Resources.Lupa;
            this.btn_Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ForeColor = System.Drawing.Color.Black;
            this.btn_Find.ImageKey = "(ninguno)";
            this.btn_Find.Location = new System.Drawing.Point(442, 294);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(59, 28);
            this.btn_Find.TabIndex = 15;
            this.btn_Find.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Find.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Update.BackgroundImage = global::Ventas.CapaPresentacion.Properties.Resources.ModifyUser;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.ImageKey = "(ninguno)";
            this.btn_Update.Location = new System.Drawing.Point(377, 294);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(59, 28);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Location = new System.Drawing.Point(7, 27);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.Size = new System.Drawing.Size(494, 261);
            this.dgv_Clientes.TabIndex = 0;
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Remove.BackgroundImage = global::Ventas.CapaPresentacion.Properties.Resources.DeleteUser;
            this.btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.Black;
            this.btn_Remove.Location = new System.Drawing.Point(307, 294);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(64, 28);
            this.btn_Remove.TabIndex = 13;
            this.btn_Remove.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Add.BackgroundImage = global::Ventas.CapaPresentacion.Properties.Resources.AddUser;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Add.Location = new System.Drawing.Point(239, 294);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(62, 28);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_NumeroCedula);
            this.groupBox2.Controls.Add(this.dateTimePicker);
            this.groupBox2.Controls.Add(this.cmb_sexo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_SegundoApellido);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_PrimerApellido);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_SegundoNombre);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_PrimerNombre);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 356);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información personal";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(5, 287);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker.TabIndex = 11;
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Location = new System.Drawing.Point(71, 326);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(118, 24);
            this.cmb_sexo.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(2, 174);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "Segundo apellido:";
            // 
            // txt_SegundoApellido
            // 
            this.txt_SegundoApellido.Location = new System.Drawing.Point(5, 193);
            this.txt_SegundoApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SegundoApellido.MaxLength = 20;
            this.txt_SegundoApellido.Name = "txt_SegundoApellido";
            this.txt_SegundoApellido.Size = new System.Drawing.Size(184, 22);
            this.txt_SegundoApellido.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Primer apellido:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 330);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Sexo";
            // 
            // txt_PrimerApellido
            // 
            this.txt_PrimerApellido.Location = new System.Drawing.Point(5, 145);
            this.txt_PrimerApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PrimerApellido.MaxLength = 20;
            this.txt_PrimerApellido.Name = "txt_PrimerApellido";
            this.txt_PrimerApellido.Size = new System.Drawing.Size(184, 22);
            this.txt_PrimerApellido.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Segundo nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 267);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Fecha de nacimiento";
            // 
            // txt_SegundoNombre
            // 
            this.txt_SegundoNombre.Location = new System.Drawing.Point(5, 96);
            this.txt_SegundoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SegundoNombre.Name = "txt_SegundoNombre";
            this.txt_SegundoNombre.Size = new System.Drawing.Size(184, 22);
            this.txt_SegundoNombre.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Primer nombre:";
            // 
            // txt_PrimerNombre
            // 
            this.txt_PrimerNombre.Location = new System.Drawing.Point(5, 46);
            this.txt_PrimerNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PrimerNombre.Name = "txt_PrimerNombre";
            this.txt_PrimerNombre.Size = new System.Drawing.Size(184, 22);
            this.txt_PrimerNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Número de Cédula";
            // 
            // txt_NumeroCedula
            // 
            this.txt_NumeroCedula.Location = new System.Drawing.Point(5, 243);
            this.txt_NumeroCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NumeroCedula.MaxLength = 14;
            this.txt_NumeroCedula.Name = "txt_NumeroCedula";
            this.txt_NumeroCedula.Size = new System.Drawing.Size(184, 22);
            this.txt_NumeroCedula.TabIndex = 12;
            // 
            // FrmNewCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 380);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmNewCliente";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.FrmNewCliente_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_sexo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_SegundoApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_PrimerApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_SegundoNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_PrimerNombre;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NumeroCedula;
    }
}