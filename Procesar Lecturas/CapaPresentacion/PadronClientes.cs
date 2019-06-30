using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Excel;

namespace CapaPresentacion
{
    public partial class PadronClientes : Form
    {
        public PadronClientes()
        {
            InitializeComponent();
        }
        DataSet result; // para llenar el dataGridView con los datos del padrón

        private void PadronClientes_Load(object sender, EventArgs e)
        {
            btnProcesar.Enabled = false;
            btnExportar.Enabled = false;
            cboSector.Items.Add("Tacna");
            cboSector.Items.Add("Moquegua");
            cboSector.Items.Add("Ilo");
            cboSector.Items.Add("Libres");
            cboSector.Items.Add("Todos");
            cboSector.SelectedIndex = 0;
        }

        private void btnCargarExcel_Click(object sender, EventArgs e)
        {
            dgvmedidor.DataMember = "";
            dgvmedidor.DataSource = "";

            btnMostrarPadron.Enabled = false;
            cboSector.Enabled = false;
            
            
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 207-2016|*.xlsx|Excel 97-2003|*.xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                        IExcelDataReader reader;
                        if (ofd.FilterIndex == 1)
                            reader = ExcelReaderFactory.CreateOpenXmlReader(fs);//Read excel 2007
                        else
                            reader = ExcelReaderFactory.CreateBinaryReader(fs);//Read excel 97-2003
                        reader.IsFirstRowAsColumnNames = true;
                        result = reader.AsDataSet();
                        //cboExcel.Items.Clear();
                        //Add sheet to comboxbox
                        foreach (DataTable dt in result.Tables)
                            cboExcel.Items.Add(dt.TableName);
                        reader.Close();
                        cboExcel.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problema detectado, por favor verifique que existe el archivo; si lo esta usando cierrelo y vuelva a intentar", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }           
                        
        }

        private void cboExcel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill data from excel into DataGridView based on sheet selection
            dgvmedidor.DataSource = result.Tables[cboExcel.SelectedIndex];
            
            if (cboExcel.Text != "") btnProcesar.Enabled = true;
            else btnProcesar.Enabled = false;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

        }
    }
    
}
