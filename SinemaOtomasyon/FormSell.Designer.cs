
namespace SinemaOtomasyon
{
    partial class FormSell
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
            this.btnStudent = new FontAwesome.Sharp.IconButton();
            this.btnAdult = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudent.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnStudent.IconColor = System.Drawing.Color.Black;
            this.btnStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudent.Location = new System.Drawing.Point(61, 86);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(164, 107);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Öğrenci";
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnAdult
            // 
            this.btnAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdult.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnAdult.IconColor = System.Drawing.Color.Black;
            this.btnAdult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdult.Location = new System.Drawing.Point(287, 85);
            this.btnAdult.Name = "btnAdult";
            this.btnAdult.Size = new System.Drawing.Size(164, 107);
            this.btnAdult.TabIndex = 1;
            this.btnAdult.Text = "Tam";
            this.btnAdult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdult.UseVisualStyleBackColor = true;
            this.btnAdult.Click += new System.EventHandler(this.btnAdult_Click);
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 290);
            this.Controls.Add(this.btnAdult);
            this.Controls.Add(this.btnStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSell";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnStudent;
        private FontAwesome.Sharp.IconButton btnAdult;
    }
}