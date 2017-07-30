namespace NominaMensual
{
    partial class CargoEmpleado
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtCa = new System.Windows.Forms.TextBox();
            this.txtCarg = new System.Windows.Forms.TextBox();
            this.txtpu = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCod_cargo = new System.Windows.Forms.TextBox();
            this.btnBus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Cargo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(370, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(24, 285);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(98, 37);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(275, 285);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 37);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Elinimar ";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(146, 285);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 37);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Editar y Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtCa
            // 
            this.txtCa.Location = new System.Drawing.Point(166, 172);
            this.txtCa.Name = "txtCa";
            this.txtCa.Size = new System.Drawing.Size(100, 20);
            this.txtCa.TabIndex = 7;
            // 
            // txtCarg
            // 
            this.txtCarg.Location = new System.Drawing.Point(166, 233);
            this.txtCarg.Name = "txtCarg";
            this.txtCarg.Size = new System.Drawing.Size(100, 20);
            this.txtCarg.TabIndex = 8;
            // 
            // txtpu
            // 
            this.txtpu.Location = new System.Drawing.Point(201, 198);
            this.txtpu.Name = "txtpu";
            this.txtpu.Size = new System.Drawing.Size(20, 20);
            this.txtpu.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.txtCod_cargo);
            this.flowLayoutPanel1.Controls.Add(this.btnBus);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(374, 77);
            this.flowLayoutPanel1.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 15);
            this.label13.TabIndex = 36;
            this.label13.Text = "Codigo Empleado";
            // 
            // txtCod_cargo
            // 
            this.txtCod_cargo.Location = new System.Drawing.Point(130, 3);
            this.txtCod_cargo.Name = "txtCod_cargo";
            this.txtCod_cargo.Size = new System.Drawing.Size(100, 20);
            this.txtCod_cargo.TabIndex = 37;
            // 
            // btnBus
            // 
            this.btnBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBus.ForeColor = System.Drawing.Color.Red;
            this.btnBus.Location = new System.Drawing.Point(236, 3);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(100, 42);
            this.btnBus.TabIndex = 38;
            this.btnBus.Text = "Buscar";
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 49;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CargoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 506);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtpu);
            this.Controls.Add(this.txtCarg);
            this.Controls.Add(this.txtCa);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CargoEmpleado";
            this.Text = "CargoEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtCa;
        private System.Windows.Forms.TextBox txtCarg;
        private System.Windows.Forms.TextBox txtpu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCod_cargo;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Button button1;
    }
}