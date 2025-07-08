namespace SUD_ARH
{
    partial class Arhiv
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arhiv));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.galob = new Bunifu.Framework.UI.BunifuFlatButton();
            this.apel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mater = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Admini = new Bunifu.Framework.UI.BunifuFlatButton();
            this.grag = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Ygol = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Acc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CuSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.civil1 = new SUD_ARH.civil();
            this.appeal1 = new SUD_ARH.appeal();
            this.complaints1 = new SUD_ARH.complaints();
            this.materials1 = new SUD_ARH.materials();
            this.criminal1 = new SUD_ARH.criminal();
            this.administrative1 = new SUD_ARH.administrative();
            this.accounting1 = new SUD_ARH.accounting();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.Minimizar);
            this.panel1.Controls.Add(this.MenuSidebar);
            this.panel1.Location = new System.Drawing.Point(-20, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1646, 46);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "SUD ARH";
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1571, 11);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 3;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1535, 11);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 3;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // MenuSidebar
            // 
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(45, 22);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 3;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.SidebarWrapper.Location = new System.Drawing.Point(-7, 53);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(233, 746);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.galob);
            this.Sidebar.Controls.Add(this.apel);
            this.Sidebar.Controls.Add(this.mater);
            this.Sidebar.Controls.Add(this.Admini);
            this.Sidebar.Controls.Add(this.grag);
            this.Sidebar.Controls.Add(this.Ygol);
            this.Sidebar.Controls.Add(this.Acc);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(14, 13);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(211, 654);
            this.Sidebar.TabIndex = 0;
            // 
            // galob
            // 
            this.galob.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.galob.BackColor = System.Drawing.Color.Transparent;
            this.galob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.galob.BorderRadius = 0;
            this.galob.ButtonText = "ЖАЛОБЫ";
            this.galob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.galob.DisabledColor = System.Drawing.Color.Transparent;
            this.galob.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.galob.Iconcolor = System.Drawing.Color.Transparent;
            this.galob.Iconimage = ((System.Drawing.Image)(resources.GetObject("galob.Iconimage")));
            this.galob.Iconimage_right = null;
            this.galob.Iconimage_right_Selected = null;
            this.galob.Iconimage_Selected = null;
            this.galob.IconMarginLeft = 0;
            this.galob.IconMarginRight = 0;
            this.galob.IconRightVisible = true;
            this.galob.IconRightZoom = 0D;
            this.galob.IconVisible = true;
            this.galob.IconZoom = 70D;
            this.galob.IsTab = true;
            this.galob.Location = new System.Drawing.Point(10, 368);
            this.galob.Name = "galob";
            this.galob.Normalcolor = System.Drawing.Color.Transparent;
            this.galob.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.galob.OnHoverTextColor = System.Drawing.Color.White;
            this.galob.selected = false;
            this.galob.Size = new System.Drawing.Size(187, 43);
            this.galob.TabIndex = 6;
            this.galob.Text = "ЖАЛОБЫ";
            this.galob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.galob.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.galob.TextFont = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galob.Click += new System.EventHandler(this.galob_Click);
            // 
            // apel
            // 
            this.apel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.apel.BackColor = System.Drawing.Color.Transparent;
            this.apel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.apel.BorderRadius = 0;
            this.apel.ButtonText = "АПЕЛЛЯЦИЯ";
            this.apel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apel.DisabledColor = System.Drawing.Color.Transparent;
            this.apel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apel.Iconcolor = System.Drawing.Color.Transparent;
            this.apel.Iconimage = ((System.Drawing.Image)(resources.GetObject("apel.Iconimage")));
            this.apel.Iconimage_right = null;
            this.apel.Iconimage_right_Selected = null;
            this.apel.Iconimage_Selected = null;
            this.apel.IconMarginLeft = 0;
            this.apel.IconMarginRight = 0;
            this.apel.IconRightVisible = true;
            this.apel.IconRightZoom = 0D;
            this.apel.IconVisible = true;
            this.apel.IconZoom = 70D;
            this.apel.IsTab = true;
            this.apel.Location = new System.Drawing.Point(10, 319);
            this.apel.Name = "apel";
            this.apel.Normalcolor = System.Drawing.Color.Transparent;
            this.apel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.apel.OnHoverTextColor = System.Drawing.Color.White;
            this.apel.selected = false;
            this.apel.Size = new System.Drawing.Size(187, 43);
            this.apel.TabIndex = 6;
            this.apel.Text = "АПЕЛЛЯЦИЯ";
            this.apel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.apel.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.apel.TextFont = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apel.Click += new System.EventHandler(this.apel_Click);
            // 
            // mater
            // 
            this.mater.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.mater.BackColor = System.Drawing.Color.Transparent;
            this.mater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mater.BorderRadius = 0;
            this.mater.ButtonText = "МАТЕРИАЛЫ";
            this.mater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mater.DisabledColor = System.Drawing.Color.Transparent;
            this.mater.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mater.Iconcolor = System.Drawing.Color.Transparent;
            this.mater.Iconimage = ((System.Drawing.Image)(resources.GetObject("mater.Iconimage")));
            this.mater.Iconimage_right = null;
            this.mater.Iconimage_right_Selected = null;
            this.mater.Iconimage_Selected = null;
            this.mater.IconMarginLeft = 0;
            this.mater.IconMarginRight = 0;
            this.mater.IconRightVisible = true;
            this.mater.IconRightZoom = 0D;
            this.mater.IconVisible = true;
            this.mater.IconZoom = 70D;
            this.mater.IsTab = true;
            this.mater.Location = new System.Drawing.Point(10, 270);
            this.mater.Name = "mater";
            this.mater.Normalcolor = System.Drawing.Color.Transparent;
            this.mater.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.mater.OnHoverTextColor = System.Drawing.Color.White;
            this.mater.selected = false;
            this.mater.Size = new System.Drawing.Size(187, 43);
            this.mater.TabIndex = 6;
            this.mater.Text = "МАТЕРИАЛЫ";
            this.mater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mater.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.mater.TextFont = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mater.Click += new System.EventHandler(this.mater_Click);
            // 
            // Admini
            // 
            this.Admini.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Admini.BackColor = System.Drawing.Color.Transparent;
            this.Admini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Admini.BorderRadius = 0;
            this.Admini.ButtonText = "АДМИНИСТРА-  ТИВНЫЕ";
            this.Admini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admini.DisabledColor = System.Drawing.Color.Transparent;
            this.Admini.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admini.Iconcolor = System.Drawing.Color.Transparent;
            this.Admini.Iconimage = ((System.Drawing.Image)(resources.GetObject("Admini.Iconimage")));
            this.Admini.Iconimage_right = null;
            this.Admini.Iconimage_right_Selected = null;
            this.Admini.Iconimage_Selected = null;
            this.Admini.IconMarginLeft = 0;
            this.Admini.IconMarginRight = 0;
            this.Admini.IconRightVisible = true;
            this.Admini.IconRightZoom = 0D;
            this.Admini.IconVisible = true;
            this.Admini.IconZoom = 70D;
            this.Admini.IsTab = true;
            this.Admini.Location = new System.Drawing.Point(10, 221);
            this.Admini.Name = "Admini";
            this.Admini.Normalcolor = System.Drawing.Color.Transparent;
            this.Admini.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Admini.OnHoverTextColor = System.Drawing.Color.White;
            this.Admini.selected = false;
            this.Admini.Size = new System.Drawing.Size(187, 43);
            this.Admini.TabIndex = 6;
            this.Admini.Text = "АДМИНИСТРА-  ТИВНЫЕ";
            this.Admini.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Admini.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.Admini.TextFont = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admini.Click += new System.EventHandler(this.Admini_Click);
            // 
            // grag
            // 
            this.grag.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.grag.BackColor = System.Drawing.Color.Transparent;
            this.grag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grag.BorderRadius = 0;
            this.grag.ButtonText = "ГРАЖДАНСКИЕ";
            this.grag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grag.DisabledColor = System.Drawing.Color.Transparent;
            this.grag.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grag.Iconcolor = System.Drawing.Color.Transparent;
            this.grag.Iconimage = ((System.Drawing.Image)(resources.GetObject("grag.Iconimage")));
            this.grag.Iconimage_right = null;
            this.grag.Iconimage_right_Selected = null;
            this.grag.Iconimage_Selected = null;
            this.grag.IconMarginLeft = 0;
            this.grag.IconMarginRight = 0;
            this.grag.IconRightVisible = true;
            this.grag.IconRightZoom = 0D;
            this.grag.IconVisible = true;
            this.grag.IconZoom = 70D;
            this.grag.IsTab = true;
            this.grag.Location = new System.Drawing.Point(10, 172);
            this.grag.Name = "grag";
            this.grag.Normalcolor = System.Drawing.Color.Transparent;
            this.grag.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.grag.OnHoverTextColor = System.Drawing.Color.White;
            this.grag.selected = false;
            this.grag.Size = new System.Drawing.Size(187, 43);
            this.grag.TabIndex = 6;
            this.grag.Text = "ГРАЖДАНСКИЕ";
            this.grag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grag.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.grag.TextFont = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grag.Click += new System.EventHandler(this.grag_Click);
            // 
            // Ygol
            // 
            this.Ygol.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Ygol.BackColor = System.Drawing.Color.Transparent;
            this.Ygol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ygol.BorderRadius = 0;
            this.Ygol.ButtonText = "УГОЛОВНЫЕ";
            this.Ygol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ygol.DisabledColor = System.Drawing.Color.Transparent;
            this.Ygol.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ygol.Iconcolor = System.Drawing.Color.Transparent;
            this.Ygol.Iconimage = ((System.Drawing.Image)(resources.GetObject("Ygol.Iconimage")));
            this.Ygol.Iconimage_right = null;
            this.Ygol.Iconimage_right_Selected = null;
            this.Ygol.Iconimage_Selected = null;
            this.Ygol.IconMarginLeft = 0;
            this.Ygol.IconMarginRight = 0;
            this.Ygol.IconRightVisible = true;
            this.Ygol.IconRightZoom = 0D;
            this.Ygol.IconVisible = true;
            this.Ygol.IconZoom = 60D;
            this.Ygol.IsTab = true;
            this.Ygol.Location = new System.Drawing.Point(10, 123);
            this.Ygol.Name = "Ygol";
            this.Ygol.Normalcolor = System.Drawing.Color.Transparent;
            this.Ygol.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Ygol.OnHoverTextColor = System.Drawing.Color.White;
            this.Ygol.selected = false;
            this.Ygol.Size = new System.Drawing.Size(187, 43);
            this.Ygol.TabIndex = 6;
            this.Ygol.Text = "УГОЛОВНЫЕ";
            this.Ygol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Ygol.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.Ygol.TextFont = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ygol.Click += new System.EventHandler(this.Ygol_Click);
            // 
            // Acc
            // 
            this.Acc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Acc.BackColor = System.Drawing.Color.Transparent;
            this.Acc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Acc.BorderRadius = 0;
            this.Acc.ButtonText = "УЧЕТ ВЫДАЧИ";
            this.Acc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Acc.DisabledColor = System.Drawing.Color.Transparent;
            this.Acc.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Acc.Iconcolor = System.Drawing.Color.Transparent;
            this.Acc.Iconimage = ((System.Drawing.Image)(resources.GetObject("Acc.Iconimage")));
            this.Acc.Iconimage_right = null;
            this.Acc.Iconimage_right_Selected = null;
            this.Acc.Iconimage_Selected = null;
            this.Acc.IconMarginLeft = 0;
            this.Acc.IconMarginRight = 0;
            this.Acc.IconRightVisible = true;
            this.Acc.IconRightZoom = 0D;
            this.Acc.IconVisible = true;
            this.Acc.IconZoom = 70D;
            this.Acc.IsTab = true;
            this.Acc.Location = new System.Drawing.Point(10, 74);
            this.Acc.Name = "Acc";
            this.Acc.Normalcolor = System.Drawing.Color.Transparent;
            this.Acc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Acc.OnHoverTextColor = System.Drawing.Color.White;
            this.Acc.selected = false;
            this.Acc.Size = new System.Drawing.Size(187, 43);
            this.Acc.TabIndex = 6;
            this.Acc.Text = "УЧЕТ ВЫДАЧИ";
            this.Acc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Acc.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.Acc.TextFont = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc.Click += new System.EventHandler(this.Acc_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 47);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(196, 10);
            this.LineaSidebar.TabIndex = 5;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Главная";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CuSidebar
            // 
            this.CuSidebar.ElipseRadius = 7;
            this.CuSidebar.TargetControl = this.Sidebar;
            // 
            // civil1
            // 
            this.civil1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.civil1.Location = new System.Drawing.Point(216, 53);
            this.civil1.Name = "civil1";
            this.civil1.Size = new System.Drawing.Size(1417, 819);
            this.civil1.TabIndex = 8;
            // 
            // appeal1
            // 
            this.appeal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.appeal1.Location = new System.Drawing.Point(216, 53);
            this.appeal1.Name = "appeal1";
            this.appeal1.Size = new System.Drawing.Size(1417, 819);
            this.appeal1.TabIndex = 7;
            // 
            // complaints1
            // 
            this.complaints1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.complaints1.Location = new System.Drawing.Point(216, 53);
            this.complaints1.Name = "complaints1";
            this.complaints1.Size = new System.Drawing.Size(1417, 819);
            this.complaints1.TabIndex = 6;
            // 
            // materials1
            // 
            this.materials1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.materials1.Location = new System.Drawing.Point(216, 53);
            this.materials1.Name = "materials1";
            this.materials1.Size = new System.Drawing.Size(1417, 819);
            this.materials1.TabIndex = 5;
            // 
            // criminal1
            // 
            this.criminal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.criminal1.Location = new System.Drawing.Point(216, 53);
            this.criminal1.Name = "criminal1";
            this.criminal1.Size = new System.Drawing.Size(1417, 819);
            this.criminal1.TabIndex = 4;
            // 
            // administrative1
            // 
            this.administrative1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.administrative1.Location = new System.Drawing.Point(216, 53);
            this.administrative1.Name = "administrative1";
            this.administrative1.Size = new System.Drawing.Size(1417, 819);
            this.administrative1.TabIndex = 3;
            // 
            // accounting1
            // 
            this.accounting1.BackColor = System.Drawing.Color.Transparent;
            this.accounting1.Location = new System.Drawing.Point(216, 53);
            this.accounting1.Name = "accounting1";
            this.accounting1.Size = new System.Drawing.Size(1365, 677);
            this.accounting1.TabIndex = 2;
            this.accounting1.Load += new System.EventHandler(this.accounting1_Load);
            // 
            // Arhiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1593, 732);
            this.Controls.Add(this.civil1);
            this.Controls.Add(this.appeal1);
            this.Controls.Add(this.complaints1);
            this.Controls.Add(this.materials1);
            this.Controls.Add(this.criminal1);
            this.Controls.Add(this.administrative1);
            this.Controls.Add(this.accounting1);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Arhiv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arhiv";
            this.Load += new System.EventHandler(this.Arhiv_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arhiv_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox Minimizar;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton galob;
        private Bunifu.Framework.UI.BunifuFlatButton apel;
        private Bunifu.Framework.UI.BunifuFlatButton mater;
        private Bunifu.Framework.UI.BunifuFlatButton Admini;
        private Bunifu.Framework.UI.BunifuFlatButton grag;
        private Bunifu.Framework.UI.BunifuFlatButton Ygol;
        private Bunifu.Framework.UI.BunifuFlatButton Acc;
        private Bunifu.Framework.UI.BunifuElipse CuSidebar;
        private accounting accounting1;
        private administrative administrative1;
        private criminal criminal1;
        private materials materials1;
        private complaints complaints1;
        private appeal appeal1;
        private civil civil1;
    }
}