namespace Ventas.CapaPresentacion
{
    partial class FrmPerfilesUsuarios
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
            this.FormUserGroup = new System.Windows.Forms.GroupBox();
            this.btn_UpdateUser = new System.Windows.Forms.Button();
            this.btn_RemoveUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Contrasena = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_VisiblePass = new System.Windows.Forms.Button();
            this.FormUserGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormUserGroup
            // 
            this.FormUserGroup.Controls.Add(this.btn_UpdateUser);
            this.FormUserGroup.Controls.Add(this.btn_VisiblePass);
            this.FormUserGroup.Controls.Add(this.btn_RemoveUser);
            this.FormUserGroup.Controls.Add(this.btn_AddUser);
            this.FormUserGroup.Controls.Add(this.label10);
            this.FormUserGroup.Controls.Add(this.txt_Contrasena);
            this.FormUserGroup.Controls.Add(this.txt_Id);
            this.FormUserGroup.Controls.Add(this.label4);
            this.FormUserGroup.Controls.Add(this.label3);
            this.FormUserGroup.Controls.Add(this.txt_NombreUsuario);
            this.FormUserGroup.Location = new System.Drawing.Point(12, 12);
            this.FormUserGroup.Name = "FormUserGroup";
            this.FormUserGroup.Size = new System.Drawing.Size(233, 297);
            this.FormUserGroup.TabIndex = 1;
            this.FormUserGroup.TabStop = false;
            this.FormUserGroup.Text = "Datos de Usuario";
            // 
            // btn_UpdateUser
            // 
            this.btn_UpdateUser.BackColor = System.Drawing.Color.Orange;
            this.btn_UpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btn_UpdateUser.Location = new System.Drawing.Point(6, 246);
            this.btn_UpdateUser.Name = "btn_UpdateUser";
            this.btn_UpdateUser.Size = new System.Drawing.Size(217, 23);
            this.btn_UpdateUser.TabIndex = 9;
            this.btn_UpdateUser.Text = "Modificar Usuario";
            this.btn_UpdateUser.UseVisualStyleBackColor = false;
            // 
            // btn_RemoveUser
            // 
            this.btn_RemoveUser.BackColor = System.Drawing.Color.LightCoral;
            this.btn_RemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveUser.ForeColor = System.Drawing.Color.Black;
            this.btn_RemoveUser.Location = new System.Drawing.Point(6, 217);
            this.btn_RemoveUser.Name = "btn_RemoveUser";
            this.btn_RemoveUser.Size = new System.Drawing.Size(217, 23);
            this.btn_RemoveUser.TabIndex = 7;
            this.btn_RemoveUser.Text = "➖ Eliminar Usuario";
            this.btn_RemoveUser.UseVisualStyleBackColor = false;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_AddUser.Location = new System.Drawing.Point(6, 188);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(217, 23);
            this.btn_AddUser.TabIndex = 6;
            this.btn_AddUser.Text = "➕ Agregar Nuevo Usuario";
            this.btn_AddUser.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Contraseña";
            // 
            // txt_Contrasena
            // 
            this.txt_Contrasena.Location = new System.Drawing.Point(6, 140);
            this.txt_Contrasena.Name = "txt_Contrasena";
            this.txt_Contrasena.Size = new System.Drawing.Size(177, 20);
            this.txt_Contrasena.TabIndex = 4;
            this.txt_Contrasena.UseSystemPasswordChar = true;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(38, 30);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(74, 20);
            this.txt_Id.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre de Usuario";
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.Location = new System.Drawing.Point(6, 83);
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(217, 20);
            this.txt_NombreUsuario.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(274, 296);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_VisiblePass
            // 
            this.btn_VisiblePass.BackgroundImage = global::Ventas.CapaPresentacion.Properties.Resources.EyeIcon;
            this.btn_VisiblePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_VisiblePass.Location = new System.Drawing.Point(189, 138);
            this.btn_VisiblePass.Name = "btn_VisiblePass";
            this.btn_VisiblePass.Size = new System.Drawing.Size(34, 23);
            this.btn_VisiblePass.TabIndex = 8;
            this.btn_VisiblePass.UseVisualStyleBackColor = true;
            // 
            // FrmPerfilesUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FormUserGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPerfilesUsuarios";
            this.Text = "FrmPerfilesUsuarios";
            this.FormUserGroup.ResumeLayout(false);
            this.FormUserGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FormUserGroup;
        private System.Windows.Forms.Button btn_UpdateUser;
        private System.Windows.Forms.Button btn_VisiblePass;
        private System.Windows.Forms.Button btn_RemoveUser;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Contrasena;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}