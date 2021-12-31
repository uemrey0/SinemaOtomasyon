
namespace SinemaOtomasyon
{
    partial class FormMovies
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
            this.movieGrid = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonImage = new System.Windows.Forms.Button();
            this.buttonSave = new FontAwesome.Sharp.IconButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // movieGrid
            // 
            this.movieGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieGrid.Location = new System.Drawing.Point(598, 12);
            this.movieGrid.Name = "movieGrid";
            this.movieGrid.Size = new System.Drawing.Size(280, 596);
            this.movieGrid.TabIndex = 0;
            this.movieGrid.SelectionChanged += new System.EventHandler(this.movieGrid_SelectionChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(146, 132);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(186, 20);
            this.txtDirector.TabIndex = 1;
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Komedi",
            "Dram"});
            this.comboType.Location = new System.Drawing.Point(146, 194);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(186, 21);
            this.comboType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yönetmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Film Türü";
            // 
            // buttonImage
            // 
            this.buttonImage.Location = new System.Drawing.Point(439, 246);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(132, 38);
            this.buttonImage.TabIndex = 5;
            this.buttonImage.Text = "Görsel Değiştir";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonSave.IconColor = System.Drawing.Color.Black;
            this.buttonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSave.Location = new System.Drawing.Point(57, 246);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(118, 38);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = global::SinemaOtomasyon.Properties.Resources.No_Image;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.ErrorImage = global::SinemaOtomasyon.Properties.Resources.No_Image;
            this.pictureBox.Image = global::SinemaOtomasyon.Properties.Resources.No_Image;
            this.pictureBox.Location = new System.Drawing.Point(439, 73);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(132, 167);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(57, 23);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 7;
            this.buttonNew.Text = "Yeni Film";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // FormMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 620);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.movieGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMovies";
            this.Text = "Film Ekle / Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.movieGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView movieGrid;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonImage;
        private FontAwesome.Sharp.IconButton buttonSave;
        private System.Windows.Forms.Button buttonNew;
    }
}