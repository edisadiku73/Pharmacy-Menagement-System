namespace PharmacyMenagementSystem
{
    partial class Company
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDkompanis = new System.Windows.Forms.TextBox();
            this.Nrkompanis = new System.Windows.Forms.TextBox();
            this.Emrikompanis = new System.Windows.Forms.TextBox();
            this.Adresakompanis = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.CompanydataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CompanydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kompania Prodhuese";
            // 
            // IDkompanis
            // 
            this.IDkompanis.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDkompanis.Location = new System.Drawing.Point(18, 82);
            this.IDkompanis.Name = "IDkompanis";
            this.IDkompanis.Size = new System.Drawing.Size(118, 22);
            this.IDkompanis.TabIndex = 1;
            // 
            // Nrkompanis
            // 
            this.Nrkompanis.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nrkompanis.Location = new System.Drawing.Point(217, 82);
            this.Nrkompanis.Name = "Nrkompanis";
            this.Nrkompanis.Size = new System.Drawing.Size(118, 22);
            this.Nrkompanis.TabIndex = 2;
            // 
            // Emrikompanis
            // 
            this.Emrikompanis.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emrikompanis.Location = new System.Drawing.Point(18, 181);
            this.Emrikompanis.Name = "Emrikompanis";
            this.Emrikompanis.Size = new System.Drawing.Size(118, 22);
            this.Emrikompanis.TabIndex = 3;
            // 
            // Adresakompanis
            // 
            this.Adresakompanis.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresakompanis.Location = new System.Drawing.Point(217, 183);
            this.Adresakompanis.Name = "Adresakompanis";
            this.Adresakompanis.Size = new System.Drawing.Size(118, 22);
            this.Adresakompanis.TabIndex = 4;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.Transparent;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addbutton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.LawnGreen;
            this.Addbutton.Location = new System.Drawing.Point(18, 278);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 38);
            this.Addbutton.TabIndex = 5;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.Transparent;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatebutton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.LawnGreen;
            this.updatebutton.Location = new System.Drawing.Point(126, 278);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 38);
            this.updatebutton.TabIndex = 6;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Transparent;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletebutton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.LawnGreen;
            this.deletebutton.Location = new System.Drawing.Point(235, 278);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 38);
            this.deletebutton.TabIndex = 7;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Transparent;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbutton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.Color.LawnGreen;
            this.backbutton.Location = new System.Drawing.Point(127, 361);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(74, 40);
            this.backbutton.TabIndex = 8;
            this.backbutton.Text = "BACK";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // CompanydataGridView
            // 
            this.CompanydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanydataGridView.Location = new System.Drawing.Point(368, 12);
            this.CompanydataGridView.Name = "CompanydataGridView";
            this.CompanydataGridView.Size = new System.Drawing.Size(494, 389);
            this.CompanydataGridView.TabIndex = 9;
            this.CompanydataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompanydataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID Kompanis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(214, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nr Telefonit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(15, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Emri Kompanis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LawnGreen;
            this.label5.Location = new System.Drawing.Point(214, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adresa";
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmacyMenagementSystem.Properties.Resources.medical2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 437);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompanydataGridView);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Adresakompanis);
            this.Controls.Add(this.Emrikompanis);
            this.Controls.Add(this.Nrkompanis);
            this.Controls.Add(this.IDkompanis);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanydataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDkompanis;
        private System.Windows.Forms.TextBox Nrkompanis;
        private System.Windows.Forms.TextBox Emrikompanis;
        private System.Windows.Forms.TextBox Adresakompanis;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.DataGridView CompanydataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}