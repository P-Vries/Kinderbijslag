namespace Kinderbijslag
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbaantalKinderen = new System.Windows.Forms.TextBox();
            this.pnlKinderen = new System.Windows.Forms.Panel();
            this.btnpnlOk = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblID = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.pnlKinderen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aantal kinderen: ";
            // 
            // txbaantalKinderen
            // 
            this.txbaantalKinderen.Location = new System.Drawing.Point(105, 6);
            this.txbaantalKinderen.Name = "txbaantalKinderen";
            this.txbaantalKinderen.Size = new System.Drawing.Size(36, 20);
            this.txbaantalKinderen.TabIndex = 1;
            // 
            // pnlKinderen
            // 
            this.pnlKinderen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKinderen.Controls.Add(this.btnpnlOk);
            this.pnlKinderen.Controls.Add(this.dateTimePicker1);
            this.pnlKinderen.Controls.Add(this.lblID);
            this.pnlKinderen.Location = new System.Drawing.Point(15, 33);
            this.pnlKinderen.Name = "pnlKinderen";
            this.pnlKinderen.Size = new System.Drawing.Size(200, 100);
            this.pnlKinderen.TabIndex = 0;
            this.pnlKinderen.Visible = false;
            // 
            // btnpnlOk
            // 
            this.btnpnlOk.Location = new System.Drawing.Point(120, 72);
            this.btnpnlOk.Name = "btnpnlOk";
            this.btnpnlOk.Size = new System.Drawing.Size(75, 23);
            this.btnpnlOk.TabIndex = 2;
            this.btnpnlOk.Text = "Ok";
            this.btnpnlOk.UseVisualStyleBackColor = true;
            this.btnpnlOk.Click += new System.EventHandler(this.btnpnlOk_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Kind 1";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(147, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Ok";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(21, 143);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(126, 13);
            this.lblOut.TabIndex = 2;
            this.lblOut.Text = "Te betalen Kinderbijslag: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 165);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pnlKinderen);
            this.Controls.Add(this.txbaantalKinderen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlKinderen.ResumeLayout(false);
            this.pnlKinderen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbaantalKinderen;
        private System.Windows.Forms.Panel pnlKinderen;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnpnlOk;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblOut;
    }
}

