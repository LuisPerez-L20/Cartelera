namespace Cartelera
{
    partial class Form1
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
            dgDatos = new DataGridView();
            btnMostrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txbNombre = new TextBox();
            txbGenero = new TextBox();
            txbAñoestreno = new TextBox();
            txbPersonajePrincipal = new TextBox();
            txbeliminar = new TextBox();
            label6 = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            SuspendLayout();
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(22, 12);
            dgDatos.Name = "dgDatos";
            dgDatos.Size = new Size(753, 155);
            dgDatos.TabIndex = 0;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(371, 173);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 181);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 230);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Genero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 281);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 7;
            label3.Text = "Añoestreno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 329);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 8;
            label4.Text = "PersonajePrincipal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 329);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 9;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(22, 199);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(100, 23);
            txbNombre.TabIndex = 10;
            // 
            // txbGenero
            // 
            txbGenero.Location = new Point(22, 255);
            txbGenero.Name = "txbGenero";
            txbGenero.Size = new Size(100, 23);
            txbGenero.TabIndex = 11;
            // 
            // txbAñoestreno
            // 
            txbAñoestreno.Location = new Point(22, 299);
            txbAñoestreno.Name = "txbAñoestreno";
            txbAñoestreno.Size = new Size(100, 23);
            txbAñoestreno.TabIndex = 12;
            // 
            // txbPersonajePrincipal
            // 
            txbPersonajePrincipal.Location = new Point(22, 356);
            txbPersonajePrincipal.Name = "txbPersonajePrincipal";
            txbPersonajePrincipal.Size = new Size(100, 23);
            txbPersonajePrincipal.TabIndex = 13;
            // 
            // txbeliminar
            // 
            txbeliminar.Location = new Point(721, 299);
            txbeliminar.Name = "txbeliminar";
            txbeliminar.Size = new Size(100, 23);
            txbeliminar.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(740, 281);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 15;
            label6.Text = "ID Eliminar";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(32, 395);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(740, 329);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(label6);
            Controls.Add(txbeliminar);
            Controls.Add(txbPersonajePrincipal);
            Controls.Add(txbAñoestreno);
            Controls.Add(txbGenero);
            Controls.Add(txbNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMostrar);
            Controls.Add(dgDatos);
            Name = "Form1";
            Text = "p";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgDatos;
        private Button btnMostrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbNombre;
        private TextBox txbGenero;
        private TextBox txbAñoestreno;
        private TextBox txbPersonajePrincipal;
        private TextBox txbeliminar;
        private Label label6;
        private Button btnAgregar;
        private Button btnEliminar;
    }
}
