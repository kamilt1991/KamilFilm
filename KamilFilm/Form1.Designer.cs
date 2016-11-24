namespace KamilFilm
{
    partial class KamilFilm
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
            this.lista_filmow_lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lista_filmow_lv
            // 
            this.lista_filmow_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lista_filmow_lv.FullRowSelect = true;
            this.lista_filmow_lv.GridLines = true;
            this.lista_filmow_lv.Location = new System.Drawing.Point(33, 48);
            this.lista_filmow_lv.Name = "lista_filmow_lv";
            this.lista_filmow_lv.Size = new System.Drawing.Size(444, 393);
            this.lista_filmow_lv.TabIndex = 0;
            this.lista_filmow_lv.UseCompatibleStateImageBehavior = false;
            this.lista_filmow_lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tytuł";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rok produkcji";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Reżyser";
            this.columnHeader3.Width = 100;
            // 
            // KamilFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 574);
            this.Controls.Add(this.lista_filmow_lv);
            this.Name = "KamilFilm";
            this.Text = "Kamil Film";
            this.Load += new System.EventHandler(this.KamilFilm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lista_filmow_lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

