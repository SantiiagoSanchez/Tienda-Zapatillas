namespace Presentacion.cs
{
    partial class Tienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tienda));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolCategorias = new System.Windows.Forms.ToolStripSplitButton();
            this.zapatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gucciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.versaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adidasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nikeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deportivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nikeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pumaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.urbanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.nikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gucciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vansToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.topperToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.louisVuittonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddCarrito = new System.Windows.Forms.Button();
            this.btnMiCarrito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.cs.Properties.Resources.logozapa;
            this.pictureBox1.Location = new System.Drawing.Point(360, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DgvProductos
            // 
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Location = new System.Drawing.Point(198, 139);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.Size = new System.Drawing.Size(483, 292);
            this.DgvProductos.TabIndex = 3;
            this.DgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolCategorias,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(876, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Categoria";
            // 
            // toolCategorias
            // 
            this.toolCategorias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCategorias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapatosToolStripMenuItem,
            this.casualToolStripMenuItem,
            this.deportivaToolStripMenuItem,
            this.urbanaToolStripMenuItem});
            this.toolCategorias.Image = global::Presentacion.cs.Properties.Resources.moradiño;
            this.toolCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCategorias.Name = "toolCategorias";
            this.toolCategorias.Size = new System.Drawing.Size(32, 22);
            this.toolCategorias.Text = "Categoria";
            // 
            // zapatosToolStripMenuItem
            // 
            this.zapatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gucciToolStripMenuItem1,
            this.versaToolStripMenuItem});
            this.zapatosToolStripMenuItem.Name = "zapatosToolStripMenuItem";
            this.zapatosToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.zapatosToolStripMenuItem.Text = "Zapatos";
            this.zapatosToolStripMenuItem.Click += new System.EventHandler(this.zapatosToolStripMenuItem_Click);
            // 
            // gucciToolStripMenuItem1
            // 
            this.gucciToolStripMenuItem1.Name = "gucciToolStripMenuItem1";
            this.gucciToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.gucciToolStripMenuItem1.Text = "Gucci";
            this.gucciToolStripMenuItem1.Click += new System.EventHandler(this.gucciToolStripMenuItem1_Click);
            // 
            // versaToolStripMenuItem
            // 
            this.versaToolStripMenuItem.Name = "versaToolStripMenuItem";
            this.versaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.versaToolStripMenuItem.Text = "Louis Vuitton";
            this.versaToolStripMenuItem.Click += new System.EventHandler(this.versaToolStripMenuItem_Click);
            // 
            // casualToolStripMenuItem
            // 
            this.casualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adidasToolStripMenuItem1,
            this.nikeToolStripMenuItem2});
            this.casualToolStripMenuItem.Name = "casualToolStripMenuItem";
            this.casualToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.casualToolStripMenuItem.Text = "Casual";
            this.casualToolStripMenuItem.Click += new System.EventHandler(this.casualToolStripMenuItem_Click);
            // 
            // adidasToolStripMenuItem1
            // 
            this.adidasToolStripMenuItem1.Name = "adidasToolStripMenuItem1";
            this.adidasToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.adidasToolStripMenuItem1.Text = "Adidas";
            this.adidasToolStripMenuItem1.Click += new System.EventHandler(this.adidasToolStripMenuItem1_Click);
            // 
            // nikeToolStripMenuItem2
            // 
            this.nikeToolStripMenuItem2.Name = "nikeToolStripMenuItem2";
            this.nikeToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.nikeToolStripMenuItem2.Text = "Nike";
            this.nikeToolStripMenuItem2.Click += new System.EventHandler(this.nikeToolStripMenuItem2_Click);
            // 
            // deportivaToolStripMenuItem
            // 
            this.deportivaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nikeToolStripMenuItem1,
            this.pumaToolStripMenuItem1});
            this.deportivaToolStripMenuItem.Name = "deportivaToolStripMenuItem";
            this.deportivaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.deportivaToolStripMenuItem.Text = "Deportiva";
            this.deportivaToolStripMenuItem.Click += new System.EventHandler(this.deportivaToolStripMenuItem_Click);
            // 
            // nikeToolStripMenuItem1
            // 
            this.nikeToolStripMenuItem1.Name = "nikeToolStripMenuItem1";
            this.nikeToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.nikeToolStripMenuItem1.Text = "Nike";
            this.nikeToolStripMenuItem1.Click += new System.EventHandler(this.nikeToolStripMenuItem1_Click);
            // 
            // pumaToolStripMenuItem1
            // 
            this.pumaToolStripMenuItem1.Name = "pumaToolStripMenuItem1";
            this.pumaToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.pumaToolStripMenuItem1.Text = "Puma";
            this.pumaToolStripMenuItem1.Click += new System.EventHandler(this.pumaToolStripMenuItem1_Click);
            // 
            // urbanaToolStripMenuItem
            // 
            this.urbanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vansToolStripMenuItem,
            this.topperToolStripMenuItem});
            this.urbanaToolStripMenuItem.Name = "urbanaToolStripMenuItem";
            this.urbanaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.urbanaToolStripMenuItem.Text = "Urbana";
            this.urbanaToolStripMenuItem.Click += new System.EventHandler(this.urbanaToolStripMenuItem_Click);
            // 
            // vansToolStripMenuItem
            // 
            this.vansToolStripMenuItem.Name = "vansToolStripMenuItem";
            this.vansToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.vansToolStripMenuItem.Text = "Vans";
            this.vansToolStripMenuItem.Click += new System.EventHandler(this.vansToolStripMenuItem_Click);
            // 
            // topperToolStripMenuItem
            // 
            this.topperToolStripMenuItem.Name = "topperToolStripMenuItem";
            this.topperToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.topperToolStripMenuItem.Text = "Topper";
            this.topperToolStripMenuItem.Click += new System.EventHandler(this.topperToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel2.Text = "Marca";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nikeToolStripMenuItem,
            this.adidasToolStripMenuItem,
            this.pumaToolStripMenuItem,
            this.gucciToolStripMenuItem,
            this.vansToolStripMenuItem1,
            this.topperToolStripMenuItem1,
            this.louisVuittonToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::Presentacion.cs.Properties.Resources.moradiño;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // nikeToolStripMenuItem
            // 
            this.nikeToolStripMenuItem.Name = "nikeToolStripMenuItem";
            this.nikeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.nikeToolStripMenuItem.Text = "Nike";
            this.nikeToolStripMenuItem.Click += new System.EventHandler(this.nikeToolStripMenuItem_Click);
            // 
            // adidasToolStripMenuItem
            // 
            this.adidasToolStripMenuItem.Name = "adidasToolStripMenuItem";
            this.adidasToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.adidasToolStripMenuItem.Text = "Adidas";
            this.adidasToolStripMenuItem.Click += new System.EventHandler(this.adidasToolStripMenuItem_Click);
            // 
            // pumaToolStripMenuItem
            // 
            this.pumaToolStripMenuItem.Name = "pumaToolStripMenuItem";
            this.pumaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pumaToolStripMenuItem.Text = "Puma";
            this.pumaToolStripMenuItem.Click += new System.EventHandler(this.pumaToolStripMenuItem_Click);
            // 
            // gucciToolStripMenuItem
            // 
            this.gucciToolStripMenuItem.Name = "gucciToolStripMenuItem";
            this.gucciToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.gucciToolStripMenuItem.Text = "Gucci";
            this.gucciToolStripMenuItem.Click += new System.EventHandler(this.gucciToolStripMenuItem_Click);
            // 
            // vansToolStripMenuItem1
            // 
            this.vansToolStripMenuItem1.Name = "vansToolStripMenuItem1";
            this.vansToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.vansToolStripMenuItem1.Text = "Vans";
            this.vansToolStripMenuItem1.Click += new System.EventHandler(this.vansToolStripMenuItem1_Click);
            // 
            // topperToolStripMenuItem1
            // 
            this.topperToolStripMenuItem1.Name = "topperToolStripMenuItem1";
            this.topperToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.topperToolStripMenuItem1.Text = "Topper";
            this.topperToolStripMenuItem1.Click += new System.EventHandler(this.topperToolStripMenuItem1_Click);
            // 
            // louisVuittonToolStripMenuItem
            // 
            this.louisVuittonToolStripMenuItem.Name = "louisVuittonToolStripMenuItem";
            this.louisVuittonToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.louisVuittonToolStripMenuItem.Text = "Louis Vuitton";
            this.louisVuittonToolStripMenuItem.Click += new System.EventHandler(this.louisVuittonToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(811, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 44);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddCarrito
            // 
            this.btnAddCarrito.BackColor = System.Drawing.Color.Orange;
            this.btnAddCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCarrito.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCarrito.ForeColor = System.Drawing.Color.White;
            this.btnAddCarrito.Location = new System.Drawing.Point(357, 437);
            this.btnAddCarrito.Name = "btnAddCarrito";
            this.btnAddCarrito.Size = new System.Drawing.Size(178, 33);
            this.btnAddCarrito.TabIndex = 21;
            this.btnAddCarrito.Text = "Añadir al carrito";
            this.btnAddCarrito.UseVisualStyleBackColor = false;
            this.btnAddCarrito.Click += new System.EventHandler(this.btnAddCarrito_Click);
            // 
            // btnMiCarrito
            // 
            this.btnMiCarrito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMiCarrito.BackgroundImage")));
            this.btnMiCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMiCarrito.Location = new System.Drawing.Point(792, 437);
            this.btnMiCarrito.Name = "btnMiCarrito";
            this.btnMiCarrito.Size = new System.Drawing.Size(72, 51);
            this.btnMiCarrito.TabIndex = 22;
            this.btnMiCarrito.UseVisualStyleBackColor = true;
            this.btnMiCarrito.Click += new System.EventHandler(this.btnMiCarrito_Click);
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(876, 500);
            this.Controls.Add(this.btnMiCarrito);
            this.Controls.Add(this.btnAddCarrito);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DgvProductos);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Tienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolCategorias;
        private System.Windows.Forms.ToolStripMenuItem zapatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem nikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gucciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urbanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gucciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem versaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adidasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nikeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pumaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nikeToolStripMenuItem2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem vansToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem topperToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem louisVuittonToolStripMenuItem;
        private System.Windows.Forms.Button btnAddCarrito;
        private System.Windows.Forms.Button btnMiCarrito;
    }
}