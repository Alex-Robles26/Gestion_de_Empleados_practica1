namespace Gestion_de_Empleados_practica1
{
    partial class ManauryRobles
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvEmpleados = new DataGridView();
            txtSalario = new TextBox();
            label1 = new Label();
            cbCargo = new ComboBox();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btn_eliminar = new Button();
            btn_registrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 28);
            label6.Name = "label6";
            label6.Size = new Size(354, 38);
            label6.TabIndex = 27;
            label6.Text = "GESTION DE EMPLEADOS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 283);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 26;
            label5.Text = "Salario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 236);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 25;
            label4.Text = "Cargo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 203);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 24;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 159);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 23;
            label2.Text = "Apellido";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(374, 56);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(668, 346);
            dgvEmpleados.TabIndex = 22;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(92, 284);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(151, 27);
            txtSalario.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 118);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 20;
            label1.Text = "Nombre";
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(92, 237);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(151, 28);
            cbCargo.TabIndex = 19;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(92, 204);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(151, 27);
            txtEdad.TabIndex = 18;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(92, 159);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(151, 27);
            txtApellido.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 16;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.Transparent;
            btn_eliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(176, 376);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(148, 47);
            btn_eliminar.TabIndex = 15;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = Color.Transparent;
            btn_registrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar.Location = new Point(16, 376);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(145, 47);
            btn_registrar.TabIndex = 14;
            btn_registrar.Text = "REGISTRAR";
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // ManauryRobles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1062, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvEmpleados);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Controls.Add(cbCargo);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_registrar);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ManauryRobles";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvEmpleados;
        private TextBox txtSalario;
        private Label label1;
        private ComboBox cbCargo;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btn_eliminar;
        private Button btn_registrar;
    }
}
