namespace Tienda
{
    partial class Menu
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
            DvProductos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtNombre = new TextBox();
            TxtDescripcion = new TextBox();
            TxtPrecio = new TextBox();
            BtnSobreescribir = new Button();
            BtnEliminar = new Button();
            BtnAgregar = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DvProductos
            // 
            DvProductos.BackgroundColor = Color.MintCream;
            DvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DvProductos.GridColor = Color.Honeydew;
            DvProductos.Location = new Point(12, 12);
            DvProductos.Name = "DvProductos";
            DvProductos.RowHeadersWidth = 62;
            DvProductos.RowTemplate.Height = 33;
            DvProductos.Size = new Size(413, 610);
            DvProductos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(461, 128);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(521, 458);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 2;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(461, 184);
            label3.Name = "label3";
            label3.Size = new Size(143, 31);
            label3.TabIndex = 3;
            label3.Text = "Descripcion";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(569, 128);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(226, 31);
            TxtNombre.TabIndex = 4;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(470, 218);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(325, 203);
            TxtDescripcion.TabIndex = 5;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(619, 458);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(150, 31);
            TxtPrecio.TabIndex = 6;
            // 
            // BtnSobreescribir
            // 
            BtnSobreescribir.BackgroundImage = Properties.Resources.editar;
            BtnSobreescribir.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSobreescribir.Location = new Point(470, 554);
            BtnSobreescribir.Name = "BtnSobreescribir";
            BtnSobreescribir.Size = new Size(67, 65);
            BtnSobreescribir.TabIndex = 7;
            BtnSobreescribir.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackgroundImage = Properties.Resources.Eliminar;
            BtnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnEliminar.Location = new Point(569, 554);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(67, 65);
            BtnEliminar.TabIndex = 8;
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackgroundImage = Properties.Resources.Agregar;
            BtnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnAgregar.Location = new Point(669, 554);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(67, 65);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(470, 59);
            label4.Name = "label4";
            label4.Size = new Size(197, 47);
            label4.TabIndex = 10;
            label4.Text = "Productos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.producto;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(673, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 80);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoVerde;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(807, 642);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(BtnAgregar);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnSobreescribir);
            Controls.Add(TxtPrecio);
            Controls.Add(TxtDescripcion);
            Controls.Add(TxtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DvProductos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)DvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DvProductos;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtNombre;
        private TextBox TxtDescripcion;
        private TextBox TxtPrecio;
        private Button BtnSobreescribir;
        private Button BtnEliminar;
        private Button BtnAgregar;
        private Label label4;
        private PictureBox pictureBox1;
    }
}