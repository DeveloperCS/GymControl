using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;

namespace Control_Gimmnacio
{
    public partial class reportes : Form
    {
        public reportes()
        {
            InitializeComponent();
            //evitar modificar combobox
            cbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void llenarReporte()
        {
            cbTipoReporte.Items.Add("Socios");
            cbTipoReporte.Items.Add("Memebresias");
            cbTipoReporte.Items.Add("Visitantes");
            cbTipoReporte.Items.Add("Productos");
        }
        private void reportes_Load(object sender, EventArgs e)
        {
            llenarReporte();
        }
        conexionDatos dts = new conexionDatos();
        string q = "";
        private void cbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipoReporte.SelectedItem.ToString()=="Socios")
            {
                q = "Select idSocio as Clave, nombre as Nombre, fNacimiento as [Fecha de Nacimiento], sexo as Sexo,dir as Direccion, tel as [Telefono de Contacto], fb as Facebook  from socio";
                dataGridView1.DataSource = dts.consulta(q).Tables[0];
               
            }
            if (cbTipoReporte.SelectedItem.ToString()== "Memebresias")
            {
                q = "select M.idMemS as [Clave Socio/Memebresia],(select S.nombre as Nombre from socio S where S.idSocio=idMems) Socio, M.idControl as [ID Membresia],M.tMem as Tipo, M.fechaIngreso as Inicio,M.fechatermino as Termino, M.prom as Promocion, M.estado as Estatus from memSocio M  order by Socio";
                dataGridView1.DataSource = dts.consulta(q).Tables[0];
            }
            if(cbTipoReporte.SelectedItem.ToString()== "Visitantes")
            {
                q = "select v.cantidad as Cantidad, v.fecha as [Fecha de ingreso] from visitante v";
                dataGridView1.DataSource = dts.consulta(q).Tables[0];
            }
            if (cbTipoReporte.SelectedItem.ToString()=="Productos")
            {
                q = "select idProduc as Id,nomProduc as Producto,cantidad as Cantidad,precio as Precio from produc";
                dataGridView1.DataSource = dts.consulta(q).Tables[0];
            }
        }
        string h = "",f="";
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No Hay Datos Para Realizar Un Reporte");
            }
            else
            {
                //hora y fecha
                h = DateTime.Now.ToLongTimeString();
                f = DateTime.Now.ToLongDateString();
                //ESCOJE A RUTA DONDE GUARDAREMOS EL PDF
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    Document doc = new Document(PageSize.A3, 9, 9, 9, 9);
                    Chunk encab = new Chunk("GYM CONTROL REPORT: "+cbTipoReporte.SelectedItem.ToString(), FontFactory.GetFont("COURIER", 18));
                    Chunk fechaC = new Chunk(f+"."+"\n"+h, FontFactory.GetFont("COURIER", 12));
                    try
                    {
                        FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                        PdfWriter writer = PdfWriter.GetInstance(doc, file);
                        writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                        writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                        doc.Open();

                        doc.Add(new Paragraph(encab));
                        doc.Add(new Paragraph(fechaC));
                        doc.Add(new Paragraph("\n"));
                        GenerarDocumentos(doc);

                        Process.Start(filename);
                        doc.Close();

                    }
                    catch (Exception ex)
                    {
                            MessageBox.Show(ex.Message + " --" + ex.StackTrace.ToString());
                    }
                   
                   
                }
            }
        }
        //Función que genera el documento Pdf
        public void GenerarDocumentos(Document document)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView 
            PdfPTable datatable = new PdfPTable(dataGridView1.ColumnCount);

            //asignamos algunas propiedades para el diseño del pdf 
            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dataGridView1);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            //DEFINIMOS EL COLOR DE LAS CELDAS EN EL PDF
            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;

            //DEFINIMOS EL COLOR DE LOS BORDES
            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;

            //LA FUENTE DE NUESTRO TEXTO
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF 
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {

                objP = new Phrase(dataGridView1.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;
              
                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 2;
            
            datatable.DefaultCell.BorderWidth = 1;

            //SE GENERA EL CUERPO DEL PDF
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    objP = new Phrase(dataGridView1[j, i].Value.ToString(), fuente);
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            /*if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Fecha de Nacimiento")
            {
                dataGridView1.Columns["Fecha de Nacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }*/
                
        }
           
        //Función que obtiene los tamaños de las columnas del datagridview
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            //Tomamos el numero de columnas
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                //Tomamos el ancho de cada columna
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
    }
}
