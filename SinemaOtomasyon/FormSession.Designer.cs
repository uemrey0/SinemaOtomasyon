
namespace SinemaOtomasyon
{
    partial class FormSession
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
            this.comboMovie = new System.Windows.Forms.ComboBox();
            this.comboTheater = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.sessionGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.sessionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMovie
            // 
            this.comboMovie.FormattingEnabled = true;
            this.comboMovie.Location = new System.Drawing.Point(134, 76);
            this.comboMovie.Name = "comboMovie";
            this.comboMovie.Size = new System.Drawing.Size(184, 21);
            this.comboMovie.TabIndex = 0;
            this.comboMovie.SelectedIndexChanged += new System.EventHandler(this.comboMovie_SelectedIndexChanged);
            // 
            // comboTheater
            // 
            this.comboTheater.FormattingEnabled = true;
            this.comboTheater.Location = new System.Drawing.Point(134, 134);
            this.comboTheater.Name = "comboTheater";
            this.comboTheater.Size = new System.Drawing.Size(184, 21);
            this.comboTheater.TabIndex = 1;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(134, 191);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(184, 20);
            this.timePicker.TabIndex = 2;
            // 
            // sessionGrid
            // 
            this.sessionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionGrid.Location = new System.Drawing.Point(500, 12);
            this.sessionGrid.Name = "sessionGrid";
            this.sessionGrid.Size = new System.Drawing.Size(378, 596);
            this.sessionGrid.TabIndex = 9;
            this.sessionGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sessionGrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Salon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Saat";
            // 
            // buttonSave
            // 
            this.buttonSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonSave.IconColor = System.Drawing.Color.Black;
            this.buttonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSave.Location = new System.Drawing.Point(37, 249);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(118, 38);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 620);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sessionGrid);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.comboTheater);
            this.Controls.Add(this.comboMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSession";
            this.Text = "Seans Ekle/Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.sessionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMovie;
        private System.Windows.Forms.ComboBox comboTheater;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DataGridView sessionGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton buttonSave;
    }
}