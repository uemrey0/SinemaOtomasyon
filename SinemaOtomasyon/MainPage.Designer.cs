﻿
namespace SinemaOtomasyon
{
    partial class MainPage
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
            this.btnHide = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnTheaters = new FontAwesome.Sharp.IconButton();
            this.btnMovie = new FontAwesome.Sharp.IconButton();
            this.btnTicket = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Gold;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.ForeColor = System.Drawing.Color.Coral;
            this.btnHide.Location = new System.Drawing.Point(28, 6);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(10, 10);
            this.btnHide.TabIndex = 5;
            this.btnHide.TabStop = false;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Coral;
            this.btnExit.Location = new System.Drawing.Point(12, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(10, 10);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(19)))), ((int)(((byte)(81)))));
            this.pnlTop.Controls.Add(this.btnHide);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 20);
            this.pnlTop.TabIndex = 6;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(55)))), ((int)(((byte)(137)))));
            this.pnlMenu.Controls.Add(this.btnTheaters);
            this.pnlMenu.Controls.Add(this.btnMovie);
            this.pnlMenu.Controls.Add(this.btnTicket);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 20);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(210, 680);
            this.pnlMenu.TabIndex = 7;
            // 
            // btnTheaters
            // 
            this.btnTheaters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheaters.FlatAppearance.BorderSize = 0;
            this.btnTheaters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheaters.ForeColor = System.Drawing.Color.Snow;
            this.btnTheaters.IconChar = FontAwesome.Sharp.IconChar.ProjectDiagram;
            this.btnTheaters.IconColor = System.Drawing.Color.Snow;
            this.btnTheaters.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTheaters.IconSize = 32;
            this.btnTheaters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheaters.Location = new System.Drawing.Point(0, 236);
            this.btnTheaters.Name = "btnTheaters";
            this.btnTheaters.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTheaters.Size = new System.Drawing.Size(210, 50);
            this.btnTheaters.TabIndex = 4;
            this.btnTheaters.Text = "Salonlar";
            this.btnTheaters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTheaters.UseVisualStyleBackColor = true;
            this.btnTheaters.Click += new System.EventHandler(this.btnTheaters_Click);
            // 
            // btnMovie
            // 
            this.btnMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovie.FlatAppearance.BorderSize = 0;
            this.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovie.ForeColor = System.Drawing.Color.Snow;
            this.btnMovie.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.btnMovie.IconColor = System.Drawing.Color.Snow;
            this.btnMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMovie.IconSize = 32;
            this.btnMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovie.Location = new System.Drawing.Point(0, 186);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMovie.Size = new System.Drawing.Size(210, 50);
            this.btnMovie.TabIndex = 3;
            this.btnMovie.Text = "Filmler";
            this.btnMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovie.UseVisualStyleBackColor = true;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.ForeColor = System.Drawing.Color.Snow;
            this.btnTicket.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnTicket.IconColor = System.Drawing.Color.Snow;
            this.btnTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTicket.IconSize = 32;
            this.btnTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.Location = new System.Drawing.Point(0, 136);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTicket.Size = new System.Drawing.Size(210, 50);
            this.btnTicket.TabIndex = 2;
            this.btnTicket.Text = "Bilet Kes";
            this.btnTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Snow;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Snow;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 86);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(210, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(210, 86);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImage = global::SinemaOtomasyon.Properties.Resources.LogoSinema;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogo.Location = new System.Drawing.Point(0, -1);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(194, 71);
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(55)))), ((int)(((byte)(137)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.iconCurrentChildForm);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(890, 60);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(44, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(55)))), ((int)(((byte)(137)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Cornsilk;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Cornsilk;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 13);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlContainer.Controls.Add(this.pnlDesktop);
            this.pnlContainer.Controls.Add(this.pnlTitle);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(210, 20);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(890, 680);
            this.pnlContainer.TabIndex = 8;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.SeaShell;
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 60);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(890, 620);
            this.pnlDesktop.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.pnlTop.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnTheaters;
        private FontAwesome.Sharp.IconButton btnMovie;
        private FontAwesome.Sharp.IconButton btnTicket;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlDesktop;
    }
}