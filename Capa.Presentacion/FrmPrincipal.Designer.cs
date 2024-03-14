namespace Ventas.CapaPresentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CajaPage = new System.Windows.Forms.TabPage();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Descuentos = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Clientes = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_Examenes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dgv_Examenes = new System.Windows.Forms.DataGridView();
            this.UsersPage = new System.Windows.Forms.TabPage();
            this.GroupUsers = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.FormUserGroup = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_RemoveUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CajaPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examenes)).BeginInit();
            this.UsersPage.SuspendLayout();
            this.GroupUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.FormUserGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 406);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(840, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel1.Text = "SoftNic";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CajaPage);
            this.tabControl1.Controls.Add(this.UsersPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 403);
            this.tabControl1.TabIndex = 4;
            // 
            // CajaPage
            // 
            this.CajaPage.Controls.Add(this.btn_AgregarCliente);
            this.CajaPage.Controls.Add(this.groupBox1);
            this.CajaPage.Controls.Add(this.cmb_Clientes);
            this.CajaPage.Controls.Add(this.label13);
            this.CajaPage.Controls.Add(this.cmb_Examenes);
            this.CajaPage.Controls.Add(this.label9);
            this.CajaPage.Controls.Add(this.label2);
            this.CajaPage.Controls.Add(this.label1);
            this.CajaPage.Controls.Add(this.btn_Cancelar);
            this.CajaPage.Controls.Add(this.btn_Imprimir);
            this.CajaPage.Controls.Add(this.btn_Buscar);
            this.CajaPage.Controls.Add(this.dgv_Examenes);
            this.CajaPage.Location = new System.Drawing.Point(4, 22);
            this.CajaPage.Margin = new System.Windows.Forms.Padding(2);
            this.CajaPage.Name = "CajaPage";
            this.CajaPage.Padding = new System.Windows.Forms.Padding(2);
            this.CajaPage.Size = new System.Drawing.Size(832, 377);
            this.CajaPage.TabIndex = 0;
            this.CajaPage.Text = "Caja";
            this.CajaPage.UseVisualStyleBackColor = true;
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.Location = new System.Drawing.Point(520, 36);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(22, 22);
            this.btn_AgregarCliente.TabIndex = 28;
            this.btn_AgregarCliente.Text = "+";
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Descuentos);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(567, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 226);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // cmb_Descuentos
            // 
            this.cmb_Descuentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Descuentos.FormattingEnabled = true;
            this.cmb_Descuentos.Location = new System.Drawing.Point(127, 53);
            this.cmb_Descuentos.Name = "cmb_Descuentos";
            this.cmb_Descuentos.Size = new System.Drawing.Size(120, 21);
            this.cmb_Descuentos.TabIndex = 32;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown2.Location = new System.Drawing.Point(127, 19);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 31;
            this.numericUpDown2.ThousandsSeparator = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(124, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 16);
            this.label18.TabIndex = 30;
            this.label18.Text = "C$";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(124, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 16);
            this.label17.TabIndex = 29;
            this.label17.Text = "C$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(167, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "000.00";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(170, 198);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(167, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "000.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Descuento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Importe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Saldo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total a pagar:";
            // 
            // cmb_Clientes
            // 
            this.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Clientes.FormattingEnabled = true;
            this.cmb_Clientes.Location = new System.Drawing.Point(312, 36);
            this.cmb_Clientes.Name = "cmb_Clientes";
            this.cmb_Clientes.Size = new System.Drawing.Size(202, 21);
            this.cmb_Clientes.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(632, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "0000";
            // 
            // cmb_Examenes
            // 
            this.cmb_Examenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Examenes.FormattingEnabled = true;
            this.cmb_Examenes.Location = new System.Drawing.Point(15, 36);
            this.cmb_Examenes.Name = "cmb_Examenes";
            this.cmb_Examenes.Size = new System.Drawing.Size(291, 21);
            this.cmb_Examenes.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Examen a realizar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recibo:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(213, 292);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(93, 23);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "✖ Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.Location = new System.Drawing.Point(111, 292);
            this.btn_Imprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(98, 23);
            this.btn_Imprimir.TabIndex = 11;
            this.btn_Imprimir.Text = "🖨 Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(15, 293);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(92, 22);
            this.btn_Buscar.TabIndex = 10;
            this.btn_Buscar.Text = "🔍 Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // dgv_Examenes
            // 
            this.dgv_Examenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Examenes.Location = new System.Drawing.Point(15, 62);
            this.dgv_Examenes.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Examenes.Name = "dgv_Examenes";
            this.dgv_Examenes.RowHeadersWidth = 62;
            this.dgv_Examenes.RowTemplate.Height = 28;
            this.dgv_Examenes.Size = new System.Drawing.Size(527, 227);
            this.dgv_Examenes.TabIndex = 8;
            // 
            // UsersPage
            // 
            this.UsersPage.Controls.Add(this.GroupUsers);
            this.UsersPage.Controls.Add(this.FormUserGroup);
            this.UsersPage.Location = new System.Drawing.Point(4, 22);
            this.UsersPage.Margin = new System.Windows.Forms.Padding(2);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Padding = new System.Windows.Forms.Padding(2);
            this.UsersPage.Size = new System.Drawing.Size(832, 377);
            this.UsersPage.TabIndex = 1;
            this.UsersPage.Text = "Usuarios";
            this.UsersPage.UseVisualStyleBackColor = true;
            // 
            // GroupUsers
            // 
            this.GroupUsers.Controls.Add(this.dataGridView2);
            this.GroupUsers.Location = new System.Drawing.Point(245, 6);
            this.GroupUsers.Name = "GroupUsers";
            this.GroupUsers.Size = new System.Drawing.Size(579, 366);
            this.GroupUsers.TabIndex = 1;
            this.GroupUsers.TabStop = false;
            this.GroupUsers.Text = "Lista de Usuarios";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(566, 340);
            this.dataGridView2.TabIndex = 0;
            // 
            // FormUserGroup
            // 
            this.FormUserGroup.Controls.Add(this.button6);
            this.FormUserGroup.Controls.Add(this.button5);
            this.FormUserGroup.Controls.Add(this.btn_RemoveUser);
            this.FormUserGroup.Controls.Add(this.btn_AddUser);
            this.FormUserGroup.Controls.Add(this.label10);
            this.FormUserGroup.Controls.Add(this.textBox3);
            this.FormUserGroup.Controls.Add(this.textBox2);
            this.FormUserGroup.Controls.Add(this.label4);
            this.FormUserGroup.Controls.Add(this.label3);
            this.FormUserGroup.Controls.Add(this.textBox1);
            this.FormUserGroup.Location = new System.Drawing.Point(9, 6);
            this.FormUserGroup.Name = "FormUserGroup";
            this.FormUserGroup.Size = new System.Drawing.Size(229, 366);
            this.FormUserGroup.TabIndex = 0;
            this.FormUserGroup.TabStop = false;
            this.FormUserGroup.Text = "Datos de Usuario";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Orange;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(6, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(217, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Modificar Usuario";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Ventas.CapaPresentacion.Properties.Resources.EyeIcon;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(189, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 23);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_RemoveUser
            // 
            this.btn_RemoveUser.BackColor = System.Drawing.Color.LightCoral;
            this.btn_RemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveUser.ForeColor = System.Drawing.Color.Black;
            this.btn_RemoveUser.Location = new System.Drawing.Point(6, 213);
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
            this.btn_AddUser.Location = new System.Drawing.Point(6, 184);
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
            this.label10.Location = new System.Drawing.Point(3, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Contraseña";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre de Usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 428);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.Activated += new System.EventHandler(this.FrmPrincipal_Activated);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.CajaPage.ResumeLayout(false);
            this.CajaPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examenes)).EndInit();
            this.UsersPage.ResumeLayout(false);
            this.GroupUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.FormUserGroup.ResumeLayout(false);
            this.FormUserGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CajaPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Clientes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_Examenes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dgv_Examenes;
        private System.Windows.Forms.TabPage UsersPage;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.ComboBox cmb_Descuentos;
        private System.Windows.Forms.GroupBox FormUserGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GroupUsers;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_RemoveUser;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}



