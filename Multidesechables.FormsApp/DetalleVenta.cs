using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Multidesechables.EntidadesDeNegocio;
using Multidesechables.LogicaDeNegocio;




namespace Multidesechables.FormsApp
{
    public partial class DetalleVenta : Form
    {
        public DetalleVenta()
        {
            InitializeComponent();
        }
        private void DetalleVenta_Load(object sender, EventArgs e)
        {
          
        }

        private void closeFormCategory_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            E_Venta oVenta = new N_Venta().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.IdVenta != 0)
            {
                txtnumerodocumento.Text = oVenta.NumeroDocumento;
                txtfecha.Text = Convert.ToDateTime(oVenta.FechaRegistro).ToString("dddd dd MMMM yyyy HH:mm");
                txttipodocumento.Text = oVenta.TipoDocumento;
                txtusuario.Text = oVenta.oUsuario.NombreCompleto;


                txtdoccliente.Text = oVenta.DocumentoCliente;
                txtnombrecliente.Text = oVenta.NombreCliente;

                dgvdata.Rows.Clear();
                foreach (E_DetalleVenta dv in oVenta.oDetalle_Venta)
                {
                    dgvdata.Rows.Add(new object[] { dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                }

                txtmontototal.Text = oVenta.MontoTotal.ToString("0.00");
                txtmontopago.Text = oVenta.MontoPago.ToString("0.00");
                txtmontocambio.Text = oVenta.MontoCambio.ToString("0.00");


            }
        }
        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdoccliente.Text = "";
            txtnombrecliente.Text = "";

            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
            txtmontopago.Text = "0.00";
            txtmontocambio.Text = "0.00";
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            if (txttipodocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
            E_Negocio odatos = new N_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txttipodocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text);


            Texto_Html = Texto_Html.Replace("@doccliente", txtdoccliente.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtnombrecliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtmontototal.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", txtmontopago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", txtmontocambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", txtnumerodocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {

                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new N_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        StringBuilder linea = new StringBuilder();
        int maxCant = 50;
        private void AgregarCaracter(string c)
        {
            string texto = "";
            for (int i = 0; i < maxCant; i++)
            {
                texto += c;
            }
            linea.AppendLine(texto);
        }
        private void AgregarTextoCentro(string texto)
        {

            if (texto.Length > maxCant)
            {

            }
            else
            {
                decimal agregarespacio = Math.Truncate(Convert.ToDecimal((maxCant - texto.Length) / 2));
                string espacios = "";
                for (int i = 0; i < agregarespacio; i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto);
            }
        }
        private void AgregarDosColumnas(string texto1, string texto2)
        {
            int cantidadtexto = texto1.Length + texto2.Length;
            if (cantidadtexto > maxCant)
            {

            }
            else
            {
                int cantidadespacio = maxCant - cantidadtexto;
                string espacios = "";
                for (int i = 0; i < cantidadespacio; i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(texto1 + espacios + texto2);
            }

        }
        private void tiket_Click(object sender, EventArgs e)
        {
            string tickettexto = Properties.Resources.Ticket.ToString();
            E_Negocio negocio = new N_Negocio().ObtenerDatos();

            tickettexto = tickettexto.Replace("¡nombreempresa!", negocio.Nombre.ToUpper());
            tickettexto = tickettexto.Replace("¡documentoempresa!", negocio.RUC);
            tickettexto = tickettexto.Replace("¡ubicacionempresa!", negocio.Direccion);


            tickettexto = tickettexto.Replace("tipodocumento!", txttipodocumento.Text.ToUpper());
            tickettexto = tickettexto.Replace("¡numerodocumento!", txtnumerodocumento.Text);
            tickettexto = tickettexto.Replace("¡documentocliente!", txtdoccliente.Text);
            tickettexto = tickettexto.Replace("¡nombrecliente!", txtnombrecliente.Text);
            tickettexto = tickettexto.Replace("¡fechaventa!", txtfecha.Text);

            StringBuilder tr = new StringBuilder();
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
             
                tr.AppendLine("<tr>");
                tr.AppendLine("<td width=\"180\">" + row.Cells["Producto"].Value.ToString() + "</td>");
                tr.AppendLine("<td width=\"20\">" + row.Cells["Cantidad"].Value.ToString() + "</td>");
         
                tr.AppendLine("<td style=\"font-size:14px\">" + row.Cells["Precio"].Value.ToString() + "</td>");
                tr.AppendLine("<td style=\"font-size:14px\">" + row.Cells["SubTotal"].Value.ToString() + "</td>");
                tr.AppendLine("</tr>");
            }
            tickettexto = tickettexto.Replace("¡detalleventa!", tr.ToString());
            tickettexto = tickettexto.Replace("¡totalpagar!", txtmontototal.Text);
            tickettexto = tickettexto.Replace("¡pagocon!", txtmontopago.Text);
            tickettexto = tickettexto.Replace("¡cambio!", txtmontocambio.Text);
            webBrowser1.DocumentText = tickettexto;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }




  







    }

}
