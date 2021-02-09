
namespace SteuerelementeAktivieren
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.cBoxKunde = new System.Windows.Forms.CheckBox();
			this.rBtnKreditkarte = new System.Windows.Forms.RadioButton();
			this.rBtnLastschrift = new System.Windows.Forms.RadioButton();
			this.rBtnÜberweisung = new System.Windows.Forms.RadioButton();
			this.lstPaketdienst = new System.Windows.Forms.ListBox();
			this.lblHilfe = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtEingabe1 = new System.Windows.Forms.TextBox();
			this.txtEingabe2 = new System.Windows.Forms.TextBox();
			this.btnRechnen = new System.Windows.Forms.Button();
			this.lblAusgabe = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblHilfe);
			this.groupBox1.Controls.Add(this.lstPaketdienst);
			this.groupBox1.Controls.Add(this.rBtnÜberweisung);
			this.groupBox1.Controls.Add(this.rBtnLastschrift);
			this.groupBox1.Controls.Add(this.rBtnKreditkarte);
			this.groupBox1.Controls.Add(this.cBoxKunde);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(500, 255);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ereignis Enter";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(7, 20);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 0;
			this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
			// 
			// cBoxKunde
			// 
			this.cBoxKunde.AutoSize = true;
			this.cBoxKunde.Location = new System.Drawing.Point(7, 47);
			this.cBoxKunde.Name = "cBoxKunde";
			this.cBoxKunde.Size = new System.Drawing.Size(97, 17);
			this.cBoxKunde.TabIndex = 1;
			this.cBoxKunde.Text = "bereits Kunde?";
			this.cBoxKunde.UseVisualStyleBackColor = true;
			this.cBoxKunde.Enter += new System.EventHandler(this.cBoxKunde_Enter);
			// 
			// rBtnKreditkarte
			// 
			this.rBtnKreditkarte.AutoSize = true;
			this.rBtnKreditkarte.Location = new System.Drawing.Point(7, 71);
			this.rBtnKreditkarte.Name = "rBtnKreditkarte";
			this.rBtnKreditkarte.Size = new System.Drawing.Size(76, 17);
			this.rBtnKreditkarte.TabIndex = 2;
			this.rBtnKreditkarte.TabStop = true;
			this.rBtnKreditkarte.Text = "Kreditkarte";
			this.rBtnKreditkarte.UseVisualStyleBackColor = true;
			this.rBtnKreditkarte.CheckedChanged += new System.EventHandler(this.rBtnZahlungsform_CheckedChanged);
			// 
			// rBtnLastschrift
			// 
			this.rBtnLastschrift.AutoSize = true;
			this.rBtnLastschrift.Location = new System.Drawing.Point(7, 95);
			this.rBtnLastschrift.Name = "rBtnLastschrift";
			this.rBtnLastschrift.Size = new System.Drawing.Size(73, 17);
			this.rBtnLastschrift.TabIndex = 3;
			this.rBtnLastschrift.TabStop = true;
			this.rBtnLastschrift.Text = "Lastschrift";
			this.rBtnLastschrift.UseVisualStyleBackColor = true;
			this.rBtnLastschrift.CheckedChanged += new System.EventHandler(this.rBtnZahlungsform_CheckedChanged);
			// 
			// rBtnÜberweisung
			// 
			this.rBtnÜberweisung.AutoSize = true;
			this.rBtnÜberweisung.Location = new System.Drawing.Point(7, 119);
			this.rBtnÜberweisung.Name = "rBtnÜberweisung";
			this.rBtnÜberweisung.Size = new System.Drawing.Size(87, 17);
			this.rBtnÜberweisung.TabIndex = 4;
			this.rBtnÜberweisung.TabStop = true;
			this.rBtnÜberweisung.Text = "Überweisung";
			this.rBtnÜberweisung.UseVisualStyleBackColor = true;
			this.rBtnÜberweisung.CheckedChanged += new System.EventHandler(this.rBtnZahlungsform_CheckedChanged);
			// 
			// lstPaketdienst
			// 
			this.lstPaketdienst.FormattingEnabled = true;
			this.lstPaketdienst.Location = new System.Drawing.Point(7, 143);
			this.lstPaketdienst.Name = "lstPaketdienst";
			this.lstPaketdienst.Size = new System.Drawing.Size(110, 69);
			this.lstPaketdienst.TabIndex = 5;
			this.lstPaketdienst.Enter += new System.EventHandler(this.lstPaketdienst_Enter);
			// 
			// lblHilfe
			// 
			this.lblHilfe.AutoSize = true;
			this.lblHilfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHilfe.ForeColor = System.Drawing.Color.Red;
			this.lblHilfe.Location = new System.Drawing.Point(20, 225);
			this.lblHilfe.Name = "lblHilfe";
			this.lblHilfe.Size = new System.Drawing.Size(51, 16);
			this.lblHilfe.TabIndex = 6;
			this.lblHilfe.Text = "label1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblAusgabe);
			this.groupBox2.Controls.Add(this.btnRechnen);
			this.groupBox2.Controls.Add(this.txtEingabe2);
			this.groupBox2.Controls.Add(this.txtEingabe1);
			this.groupBox2.Location = new System.Drawing.Point(13, 284);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(270, 120);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Eigenschaft Enabled";
			// 
			// txtEingabe1
			// 
			this.txtEingabe1.Location = new System.Drawing.Point(7, 29);
			this.txtEingabe1.Name = "txtEingabe1";
			this.txtEingabe1.Size = new System.Drawing.Size(100, 20);
			this.txtEingabe1.TabIndex = 0;
			this.txtEingabe1.TextChanged += new System.EventHandler(this.txtEingabe_TextChanged);
			// 
			// txtEingabe2
			// 
			this.txtEingabe2.Location = new System.Drawing.Point(113, 29);
			this.txtEingabe2.Name = "txtEingabe2";
			this.txtEingabe2.Size = new System.Drawing.Size(100, 20);
			this.txtEingabe2.TabIndex = 1;
			this.txtEingabe2.TextChanged += new System.EventHandler(this.txtEingabe_TextChanged);
			// 
			// btnRechnen
			// 
			this.btnRechnen.Enabled = false;
			this.btnRechnen.Location = new System.Drawing.Point(7, 78);
			this.btnRechnen.Name = "btnRechnen";
			this.btnRechnen.Size = new System.Drawing.Size(75, 23);
			this.btnRechnen.TabIndex = 2;
			this.btnRechnen.Text = "Rechnen";
			this.btnRechnen.UseVisualStyleBackColor = true;
			this.btnRechnen.Visible = false;
			this.btnRechnen.Click += new System.EventHandler(this.btnRechnen_Click);
			// 
			// lblAusgabe
			// 
			this.lblAusgabe.AutoSize = true;
			this.lblAusgabe.Location = new System.Drawing.Point(7, 56);
			this.lblAusgabe.Name = "lblAusgabe";
			this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
			this.lblAusgabe.TabIndex = 3;
			this.lblAusgabe.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 487);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Steuerelemente aktivieren";
			this.Activated += new System.EventHandler(this.Form1_Activated);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblHilfe;
		private System.Windows.Forms.ListBox lstPaketdienst;
		private System.Windows.Forms.RadioButton rBtnÜberweisung;
		private System.Windows.Forms.RadioButton rBtnLastschrift;
		private System.Windows.Forms.RadioButton rBtnKreditkarte;
		private System.Windows.Forms.CheckBox cBoxKunde;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnRechnen;
		private System.Windows.Forms.TextBox txtEingabe2;
		private System.Windows.Forms.TextBox txtEingabe1;
		private System.Windows.Forms.Label lblAusgabe;
	}
}

