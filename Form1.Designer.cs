namespace Snow
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.back = new System.Windows.Forms.ToolStripButton();
            this.forward = new System.Windows.Forms.ToolStripButton();
            this.refresh = new System.Windows.Forms.ToolStripButton();
            this.home = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancel = new System.Windows.Forms.ToolStripButton();
            this.url = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Go = new System.Windows.Forms.ToolStripButton();
            this.FavouritesToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavouritesToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.favouritesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favouritesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favouritesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favouritesListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back,
            this.forward,
            this.refresh,
            this.home,
            this.toolStripSeparator2,
            this.cancel,
            this.url,
            this.toolStripSeparator1,
            this.Go,
            this.FavouritesToolStrip,
            this.historyToolStrip,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1593, 43);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // back
            // 
            this.back.AutoSize = false;
            this.back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 40);
            this.back.Text = "Back";
            // 
            // forward
            // 
            this.forward.AutoSize = false;
            this.forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forward.Image = ((System.Drawing.Image)(resources.GetObject("forward.Image")));
            this.forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(30, 40);
            this.forward.Text = "Forward";
            // 
            // refresh
            // 
            this.refresh.AutoSize = false;
            this.refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refresh.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(30, 40);
            this.refresh.Text = "refresh";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // home
            // 
            this.home.AutoSize = false;
            this.home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(30, 40);
            this.home.Text = "home";
            this.home.ToolTipText = "Home Page";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // cancel
            // 
            this.cancel.AutoSize = false;
            this.cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(30, 40);
            this.cancel.Text = "cancel";
            // 
            // url
            // 
            this.url.AutoSize = false;
            this.url.MaxLength = 200;
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(674, 27);
            this.url.Text = "http://";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // Go
            // 
            this.Go.AutoSize = false;
            this.Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Go.Image = ((System.Drawing.Image)(resources.GetObject("Go.Image")));
            this.Go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(30, 40);
            this.Go.Text = "Go";
            this.Go.Click += new System.EventHandler(this.go_Click);
            // 
            // FavouritesToolStrip
            // 
            this.FavouritesToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FavouritesToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavouritesToolStrip});
            this.FavouritesToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("FavouritesToolStrip.Image")));
            this.FavouritesToolStrip.Name = "FavouritesToolStrip";
            this.FavouritesToolStrip.Size = new System.Drawing.Size(28, 43);
            this.FavouritesToolStrip.Text = "Favorites";
            this.FavouritesToolStrip.ToolTipText = "Favourites";
            // 
            // addToFavouritesToolStrip
            // 
            this.addToFavouritesToolStrip.Name = "addToFavouritesToolStrip";
            this.addToFavouritesToolStrip.Size = new System.Drawing.Size(160, 22);
            this.addToFavouritesToolStrip.Text = "Add to Favorites";
            this.addToFavouritesToolStrip.Click += new System.EventHandler(this.addToFavouritesToolStrip_Click);
            // 
            // historyToolStrip
            // 
            this.historyToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.historyToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("historyToolStrip.Image")));
            this.historyToolStrip.Name = "historyToolStrip";
            this.historyToolStrip.Size = new System.Drawing.Size(28, 43);
            this.historyToolStrip.Text = "History";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 40);
            this.toolStripButton1.Text = "Open New Tab";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Location = new System.Drawing.Point(0, 46);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1593, 570);
            this.tabControl2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 621);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lupo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favouritesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favouritesListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton back;
        private System.Windows.Forms.ToolStripButton forward;
        private System.Windows.Forms.ToolStripButton refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox url;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem FavouritesToolStrip;
        private System.Windows.Forms.ToolStripMenuItem addToFavouritesToolStrip;
        private System.Windows.Forms.ToolStripButton cancel;
        private System.Windows.Forms.ToolStripMenuItem historyToolStrip;
        private System.Windows.Forms.ToolStripButton Go;
        private System.Windows.Forms.BindingSource form1BindingSource;
        public System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.ToolStripButton home;
        private System.Windows.Forms.BindingSource favouritesListBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource2;
        private System.Windows.Forms.BindingSource favouritesBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

