namespace PharmacyMenagementSystem
{
    partial class BillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.combobill = new System.Windows.Forms.ComboBox();
            this.stokDisp = new System.Windows.Forms.Label();
            this.sasia = new System.Windows.Forms.TextBox();
            this.Addbill = new System.Windows.Forms.Button();
            this.BilldataGridView = new System.Windows.Forms.DataGridView();
            this.IdBarnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EBarnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sasiabarnave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QmimiNjesis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QmimiTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalishumes = new System.Windows.Forms.Label();
            this.printbutton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.billbackbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BilldataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faturimi";
            // 
            // combobill
            // 
            this.combobill.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobill.FormattingEnabled = true;
            this.combobill.Location = new System.Drawing.Point(16, 78);
            this.combobill.Name = "combobill";
            this.combobill.Size = new System.Drawing.Size(121, 22);
            this.combobill.TabIndex = 1;
            this.combobill.SelectedIndexChanged += new System.EventHandler(this.combobill_SelectedIndexChanged);
            this.combobill.SelectionChangeCommitted += new System.EventHandler(this.combobill_SelectionChangeCommitted);
            // 
            // stokDisp
            // 
            this.stokDisp.AutoSize = true;
            this.stokDisp.BackColor = System.Drawing.Color.Transparent;
            this.stokDisp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokDisp.ForeColor = System.Drawing.Color.LawnGreen;
            this.stokDisp.Location = new System.Drawing.Point(15, 123);
            this.stokDisp.Name = "stokDisp";
            this.stokDisp.Size = new System.Drawing.Size(153, 14);
            this.stokDisp.TabIndex = 2;
            this.stokDisp.Text = "Stoku i Disponueshem";
            this.stokDisp.Visible = false;
            // 
            // sasia
            // 
            this.sasia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sasia.Location = new System.Drawing.Point(18, 186);
            this.sasia.Name = "sasia";
            this.sasia.Size = new System.Drawing.Size(119, 22);
            this.sasia.TabIndex = 3;
            this.sasia.TextChanged += new System.EventHandler(this.sasia_TextChanged);
            // 
            // Addbill
            // 
            this.Addbill.BackColor = System.Drawing.Color.Transparent;
            this.Addbill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addbill.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbill.ForeColor = System.Drawing.Color.LawnGreen;
            this.Addbill.Location = new System.Drawing.Point(16, 228);
            this.Addbill.Name = "Addbill";
            this.Addbill.Size = new System.Drawing.Size(102, 56);
            this.Addbill.TabIndex = 4;
            this.Addbill.Text = "SHTO NE FATUR";
            this.Addbill.UseVisualStyleBackColor = false;
            this.Addbill.Click += new System.EventHandler(this.Addbill_Click);
            // 
            // BilldataGridView
            // 
            this.BilldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BilldataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBarnes,
            this.EBarnes,
            this.sasiabarnave,
            this.QmimiNjesis,
            this.QmimiTotal});
            this.BilldataGridView.Location = new System.Drawing.Point(230, 9);
            this.BilldataGridView.Name = "BilldataGridView";
            this.BilldataGridView.Size = new System.Drawing.Size(573, 320);
            this.BilldataGridView.TabIndex = 5;
            // 
            // IdBarnes
            // 
            this.IdBarnes.HeaderText = "ID E Barnes";
            this.IdBarnes.Name = "IdBarnes";
            // 
            // EBarnes
            // 
            this.EBarnes.HeaderText = "Emri i Barnes";
            this.EBarnes.Name = "EBarnes";
            // 
            // sasiabarnave
            // 
            this.sasiabarnave.HeaderText = "Sasia";
            this.sasiabarnave.Name = "sasiabarnave";
            // 
            // QmimiNjesis
            // 
            this.QmimiNjesis.HeaderText = "Qmimi Njesi";
            this.QmimiNjesis.Name = "QmimiNjesis";
            // 
            // QmimiTotal
            // 
            this.QmimiTotal.HeaderText = "Qmimi Total";
            this.QmimiTotal.Name = "QmimiTotal";
            // 
            // totalishumes
            // 
            this.totalishumes.AutoSize = true;
            this.totalishumes.BackColor = System.Drawing.Color.Transparent;
            this.totalishumes.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalishumes.ForeColor = System.Drawing.Color.LawnGreen;
            this.totalishumes.Location = new System.Drawing.Point(224, 349);
            this.totalishumes.Name = "totalishumes";
            this.totalishumes.Size = new System.Drawing.Size(228, 32);
            this.totalishumes.TabIndex = 6;
            this.totalishumes.Text = "Totali Shumes";
            // 
            // printbutton
            // 
            this.printbutton.BackColor = System.Drawing.Color.Transparent;
            this.printbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printbutton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbutton.ForeColor = System.Drawing.Color.LawnGreen;
            this.printbutton.Location = new System.Drawing.Point(230, 401);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(125, 39);
            this.printbutton.TabIndex = 7;
            this.printbutton.Text = "Printo Faturen";
            this.printbutton.UseVisualStyleBackColor = false;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // billbackbtn
            // 
            this.billbackbtn.BackColor = System.Drawing.Color.Transparent;
            this.billbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.billbackbtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billbackbtn.ForeColor = System.Drawing.Color.LawnGreen;
            this.billbackbtn.Location = new System.Drawing.Point(16, 341);
            this.billbackbtn.Name = "billbackbtn";
            this.billbackbtn.Size = new System.Drawing.Size(102, 40);
            this.billbackbtn.TabIndex = 8;
            this.billbackbtn.Text = "BACK";
            this.billbackbtn.UseVisualStyleBackColor = false;
            this.billbackbtn.Click += new System.EventHandler(this.billbackbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Zgjedh Barnen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(15, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sasia";
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmacyMenagementSystem.Properties.Resources.medical2;
            this.ClientSize = new System.Drawing.Size(838, 469);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billbackbtn);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.totalishumes);
            this.Controls.Add(this.BilldataGridView);
            this.Controls.Add(this.Addbill);
            this.Controls.Add(this.sasia);
            this.Controls.Add(this.stokDisp);
            this.Controls.Add(this.combobill);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingForm";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BilldataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobill;
        private System.Windows.Forms.Label stokDisp;
        private System.Windows.Forms.TextBox sasia;
        private System.Windows.Forms.Button Addbill;
        private System.Windows.Forms.DataGridView BilldataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn EBarnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn sasiabarnave;
        private System.Windows.Forms.DataGridViewTextBoxColumn QmimiNjesis;
        private System.Windows.Forms.DataGridViewTextBoxColumn QmimiTotal;
        private System.Windows.Forms.Label totalishumes;
        private System.Windows.Forms.Button printbutton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button billbackbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}