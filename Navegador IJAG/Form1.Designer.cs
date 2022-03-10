
namespace Navegador_IJAG
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdfav = new System.Windows.Forms.ComboBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.home = new FontAwesome.Sharp.IconButton();
            this.buscar = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.cargar = new FontAwesome.Sharp.IconButton();
            this.delante = new FontAwesome.Sharp.IconButton();
            this.atras = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.cargar);
            this.panel1.Controls.Add(this.delante);
            this.panel1.Controls.Add(this.atras);
            this.panel1.Controls.Add(this.buscar);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.cmdfav);
            this.panel1.Controls.Add(this.txtdireccion);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 71);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmdfav
            // 
            this.cmdfav.FormattingEnabled = true;
            this.cmdfav.Location = new System.Drawing.Point(505, 27);
            this.cmdfav.Name = "cmdfav";
            this.cmdfav.Size = new System.Drawing.Size(124, 21);
            this.cmdfav.TabIndex = 7;
            this.cmdfav.Text = "Favoritos";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdireccion.Location = new System.Drawing.Point(172, 28);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(271, 20);
            this.txtdireccion.TabIndex = 5;
            this.txtdireccion.TextChanged += new System.EventHandler(this.txtdireccion_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(1, 79);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(815, 423);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // home
            // 
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.home.IconColor = System.Drawing.Color.Black;
            this.home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home.IconSize = 40;
            this.home.Location = new System.Drawing.Point(10, 17);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(49, 41);
            this.home.TabIndex = 8;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // buscar
            // 
            this.buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscar.FlatAppearance.BorderSize = 0;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buscar.IconColor = System.Drawing.Color.Black;
            this.buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscar.IconSize = 40;
            this.buscar.Location = new System.Drawing.Point(449, 17);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(49, 41);
            this.buscar.TabIndex = 9;
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton2.IconColor = System.Drawing.Color.Yellow;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(635, 17);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(49, 41);
            this.iconButton2.TabIndex = 14;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(745, 18);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(49, 41);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // cargar
            // 
            this.cargar.FlatAppearance.BorderSize = 0;
            this.cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargar.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.cargar.IconColor = System.Drawing.Color.Green;
            this.cargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cargar.IconSize = 40;
            this.cargar.Location = new System.Drawing.Point(690, 19);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(49, 41);
            this.cargar.TabIndex = 12;
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // delante
            // 
            this.delante.FlatAppearance.BorderSize = 0;
            this.delante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delante.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.delante.IconColor = System.Drawing.Color.SteelBlue;
            this.delante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delante.IconSize = 40;
            this.delante.Location = new System.Drawing.Point(117, 17);
            this.delante.Name = "delante";
            this.delante.Size = new System.Drawing.Size(49, 41);
            this.delante.TabIndex = 11;
            this.delante.UseVisualStyleBackColor = true;
            this.delante.Click += new System.EventHandler(this.delante_Click);
            // 
            // atras
            // 
            this.atras.FlatAppearance.BorderSize = 0;
            this.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atras.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.atras.IconColor = System.Drawing.Color.SteelBlue;
            this.atras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.atras.IconSize = 40;
            this.atras.Location = new System.Drawing.Point(62, 17);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(49, 41);
            this.atras.TabIndex = 10;
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 499);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Navegador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmdfav;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton cargar;
        private FontAwesome.Sharp.IconButton delante;
        private FontAwesome.Sharp.IconButton atras;
        private FontAwesome.Sharp.IconButton buscar;
        private FontAwesome.Sharp.IconButton home;
    }
}

