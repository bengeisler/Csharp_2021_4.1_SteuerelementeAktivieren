using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteuerelementeAktivieren
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Liste befüllen bei Programmstart
			lstPaketdienst.Items.Add("DHL");
			lstPaketdienst.Items.Add("Hermes");
			lstPaketdienst.Items.Add("UPS");
		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			lblHilfe.Text = "";
		}

		private void txtName_Enter(object sender, EventArgs e)
		{
			lblHilfe.Text = "Bitte geben Sie Nachname, Vorname ein";
		}

		private void cBoxKunde_Enter(object sender, EventArgs e)
		{
			lblHilfe.Text = "Kreuzen Sie an, ob Sie bereits Kunde sind";
		}

		private void lstPaketdienst_Enter(object sender, EventArgs e)
		{
			lblHilfe.Text = "Wählen Sie einen Paketdienst aus";
		}

		// Eigene Ereignismethode erstellt:
		// - Der Name enthält die Steuerelemente, auf die sie sich bezieht
		//   sowie das Ereignis
		// - Signatur der Methode muss einer Ereignismethode entsprechen
		//		- "private void" am Anfang
		//		- die Argumente "object sender, EventArgs e" in Klammern
		private void rBtnZahlungsform_CheckedChanged(object sender, EventArgs e)
		{
			lblHilfe.Text = "Wählen Sie die Zahlungsform aus";
		}

		private void btnRechnen_Click(object sender, EventArgs e)
		{
			try
			{
				lblAusgabe.Text = "Ergebnis: " +
					(Convert.ToInt32(txtEingabe1.Text) +
					Convert.ToInt32(txtEingabe2.Text));
			}
			catch
			{
				lblAusgabe.Text = "0";
			}
		}

		// Ereignismethode erstellen
		// Wird von beiden Eingabefeldern verwendet
		private void txtEingabe_TextChanged(object sender, EventArgs e) 
		{
			if (txtEingabe1.Text != "" && txtEingabe2.Text != "")
			{
				btnRechnen.Enabled = true;		// Bedienbarkeit 
				//btnRechnen.Visible = true;			// Sichtbarkeit
			}
			else
			{
				btnRechnen.Enabled = false;		// Bedienbarkeit 
				//btnRechnen.Visible = false;     // Sichtbarkeit
			}
		}
	}
}
