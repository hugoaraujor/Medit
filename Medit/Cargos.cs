using BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataEntities;

namespace Medit
{
    public partial class Cargos : Form
    {
        public long idcurrent = 2;
        List<int> borrados = new List<int>();
        ComboBox cbm;
        DataGridViewCell currentCell;

        // This DataTable will become a data source for the DataGridView
        DataTable dt = new DataTable();


        private bool nuevo = false;
        public bool agregar = false;
        public bool editar = false;
        public const int MODOREG = 0;
        public const int MODOEDIT = 1;
        public const int MODOREGDOC = 0;
        public const int MODOEDITDOC = 1;
        private int tipo;
        CargosManager cm = new CargosManager();
        public Cargos()
        {

            InitializeComponent();


            // CargaCargo(bp.idCargoSel);
        }



        private void Btn_NuevoCargo_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            customButton2.Visible = false;
            idcurrent = 0;
            nuevo = true;

            Btn_NuevoCargo.Enabled = false;
            Btn_GuardarCargo.Enabled = true;
            Btn_cancelarEdicionCargo.Enabled = true;
            Utiles.BlanquearControles(this);
            if (dataGridView1.Columns.Contains("cmb"))
            {
                dataGridView1.Columns.RemoveAt(0);
            }
            Utiles.HabilitarControles(this);
            textB1.Text = "0";
        }



        private void Btn_EditarCargo_Click(object sender, EventArgs e)
        {
            if (textB1.Text.ToString() == "")
                return;
            editar = true;
            if (this.checkBox2.Checked == true)
            {
                customButton2.Visible = true;
            }
            Btn_GuardarCargo.Enabled = true;
            Btn_cancelarEdicionCargo.Enabled = true;


            Utiles.HabilitarControles(this);
        }

        private void Btn_GuardarCargo_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false; customButton2.Visible = false;
            int retorno = 0;
            if (nuevo && textB1.Text == "0")
                retorno = cm.InsertCargo(new DataEntities.CargosDTO { inventario = checkBox1.Checked, Grupo = ((int)comboPlus2.SelectedValue), Tipocargo = tipo, descripción = textB2.Text, precio1 = ADecimal(textB3.Text), precio2 = ADecimal(textB4.Text), precio3 = ADecimal(textB5.Text), Kit = checkBox2.Checked, agrupable = checkBox3.Checked,presentacion=textB6.Text, indicaciones=textB7.Text,via=comboPlus2.Text,activo= checkBox4.Checked});
            else
            {
                retorno = (Convert.ToInt32(textB1.Text));
                cm.Edit(new CargosDTO { CargoId = (Convert.ToInt16(textB1.Text)), inventario = checkBox1.Checked, Grupo = ((int)comboPlus2.SelectedValue), Tipocargo = tipo, descripción = textB2.Text, precio1 = ADecimal(textB3.Text), precio2 = ADecimal(textB4.Text), precio3 = ADecimal(textB5.Text), Kit = checkBox2.Checked, agrupable = checkBox3.Checked, presentacion = textB6.Text, indicaciones = textB7.Text, via = comboPlus2.Text, activo = checkBox4.Checked });

            }
            if (this.checkBox2.Checked)
                GuardarSubComponentes(retorno);

            Btn_GuardarCargo.Enabled = false;
            Btn_cancelarEdicionCargo.Enabled = false;
            Btn_NuevoCargo.Enabled = true;
            Utiles.DesHabilitarControles(this);
            textB1.Text = retorno.ToString();
        }

        private void GuardarSubComponentes(int parentid)
        {
            SubProductoManager sm = new SubProductoManager();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["Cantidad"].Value != null && item.Index < dataGridView1.Rows.Count - 1)
                {
                    SubproductoDTO sp = new SubproductoDTO
                    {
                        cantidad = Convert.ToInt32(item.Cells["Cantidad"].Value),
                        cargoid = Convert.ToInt32(item.Cells["Codigo"].Value),
                        parentid = Convert.ToInt32(item.Cells["parentid"].Value),
                        subprodid = Convert.ToInt32(item.Cells["subproductoid"].Value)
                    };
                    if (sp.subprodid == -1)
                        sm.Insert(sp, parentid);
                    else
                        sm.Edit(sp);
                }

            }
            foreach (int n in borrados)
            {
                sm.Delete(n);
            }
            borrados.Clear();
        }

        private decimal? ADecimal(string text)
        {
            decimal resultado = 0;
            if (text != null)
            {
                if (text.ToString() == "")
                    resultado = 0;
                else
                    resultado = Convert.ToDecimal(text);
            }
            return resultado;
        }

        private void Btn_cancelarEdicionCargo_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            customButton2.Visible = false;

            Btn_cancelarEdicionCargo.Enabled = false;
            editar = false;
            agregar = false;


            //            Btn_EditarCargo.Enabled = false;
            if (idcurrent != 0)
                Btn_NuevoCargo.Enabled = false;

            Btn_GuardarCargo.Enabled = false;
            Btn_NuevoCargo.Enabled = true;
         //   Utiles.BlanquearControles(this);
            Utiles.DesHabilitarControles(this);
        }

        private void Btn_BuscarCargo_Click(object sender, EventArgs e)
        {
            BuscarCargos bp = new BuscarCargos();
            bp.ShowDialog();
            CargaCargo(bp.idCargoSel);
            textB1.Text = bp.idCargoSel.ToString();
            Panel1.Visible = true;
            Panel2.Visible = false;
        }

        private void CargaCargo(int idcargo)
        {
            if (idcargo == 0)
                return;

            CargosManager tcm = new CargosManager();
            DataEntities.CargosDTO cargo = tcm.GetCargo(idcargo);

            if (cargo.inventario == null || cargo.inventario == false)
                checkBox1.Checked = false;
            else
                checkBox1.Checked = true;

            if (cargo.agrupable == null || cargo.agrupable == false)
                checkBox3.Checked = false;
            else
                checkBox3.Checked = true;
            textB1.Text = cargo.CargoId.ToString();
            if (cargo.Kit == null || cargo.Kit == false) { 
            checkBox2.Checked = false;
            Utiles.BlanquearControles(dataGridView1);
            Utiles.DesHabilitarControles(dataGridView1);
                customButton2.Visible = false;
            }
            else
            {
                checkBox2.Checked = true;
                CargaKit(cargo.CargoId);
                customButton2.Visible = true;
            }
            tipo = (int)cargo.Tipocargo;
            TipoCargosManager tc = new TipoCargosManager();
            this.combolus1.DataSource = tc.GetTipodeCargos();
            this.combolus1.DisplayMember = "TipocargoDesc";
            this.combolus1.ValueMember = "TipoCargoId";
            this.combolus1.SelectedValue = cargo.Tipocargo;

            cargarlista(tipo);
            comboPlus2.SelectedValue = cargo.Grupo;
            textB2.Text = cargo.descripción;
            textB3.Text = String.Format("{0:0.00}", cargo.precio1);
            textB4.Text = String.Format("{0:0.00}", cargo.precio2);
            textB5.Text = String.Format("{0:0.00}", cargo.precio3);
            idcurrent = cargo.CargoId;


        }

        private void Cargas_Load(object sender, EventArgs e)
        {
            TipoCargosManager tcm = new TipoCargosManager();
            this.combolus1.DataSource = tcm.GetTipodeCargos();
            this.combolus1.DisplayMember = "TipocargoDesc";
            this.combolus1.ValueMember = "TipoCargoId";
            Panel1.Visible = true;
            Panel2.Visible = false;
        }
        private void cargarlista(int tipo)
        {
            CargoClasesManager ccm = new CargoClasesManager();
            this.comboPlus2.DataSource = ccm.GetClasesTable(tipo);
            this.comboPlus2.DisplayMember = "Clase";
            this.comboPlus2.ValueMember = "ClaseId";
        }
        private void combolus1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tipo = (int)this.combolus1.SelectedValue;
                cargarlista(tipo);


            }
            catch { }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            if (textB1.Text == "")
                return;
            DialogResult resp = MessageBox.Show("Esta Seguro de Eliminar Registro", "Confirmación", MessageBoxButtons.YesNoCancel);
            if (resp == DialogResult.Yes)
            {
                cm.Delete(Convert.ToInt16(textB1.Text));
                Utiles.BlanquearControles(this);
                customButton2.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargoClases cc = new CargoClases();
            cc.ShowDialog();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                customButton2.Visible = true;
            else
                customButton2.Visible = true;

            if (this.textB1.Text == "0" && customButton2.Visible)
            {
                CargaKit(0);
            }

        }

        private void CargaKit(int idcargo)
        {
            if (this.textB1.Text == "")
                return;


            dataGridView1.DataSource = cm.GetSubComponentes(idcargo);
            //cm.GetCargoComponente(Convert.ToInt32(this.textB1.Text));
            DataTable dt = cm.GetCargosTable("");
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dt.Rows[i];
                if (dr[0].ToString() == this.textB1.Text)
                    dr.Delete();
            }
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.DataSource = dt;
            cmb.DisplayMember = "descripción";
            cmb.ValueMember = "CargoId";
            cmb.HeaderText = "Select Data";
            cmb.Name = "cmb";




            DataGridViewColumn dtc = new DataGridViewColumn();// dataGridView1.Columns[4];
            dtc.Name = "Combocol";
            dtc = cmb;
            if (!dataGridView1.Columns.Contains("cmb"))
            {
                dataGridView1.Columns.Add(dtc);
            }

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (!(item.IsNewRow) && item.Cells[2].Value != null)
                {

                    Console.WriteLine(item.IsNewRow);
                    Console.WriteLine(item.Cells[4].Value);
                    Console.WriteLine(item.Cells[5].Value);
                    if (item.Cells[1].Value != null)
                        item.Cells[5].Value = (int)item.Cells[1].Value;
                }
            }
            ///   dataGridView1.Columns[1].Visible = false;
            // dataGridView1.Columns[2].Visible = false;

            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
            dataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);
        }
        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (cbm != null)
            {
                // Here we will remove the subscription for selected index changed
                cbm.SelectedIndexChanged -= new EventHandler(cbm_SelectedIndexChanged);
            }
        }

        void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Here try to add subscription for selected index changed event
            if (e.Control is ComboBox)
            {
                cbm = (ComboBox)e.Control;
                if (cbm != null)
                {
                    cbm.SelectedIndexChanged += new EventHandler(cbm_SelectedIndexChanged);
                }
                currentCell = this.dataGridView1.CurrentCell;
            }
        }

        void cbm_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Invoke method if the selection changed event occurs
            BeginInvoke(new MethodInvoker(EndEdit));
        }

        void EndEdit()
        {
            // Change the content of appropriate cell when selected index changes
            if (cbm != null)
            {
                DataRowView drv = (DataRowView)cbm.SelectedItem;
                Console.WriteLine(drv[0].ToString());
                Console.WriteLine(drv[1].ToString());
                Console.WriteLine(drv[2].ToString());
                Console.WriteLine(drv[3].ToString());
                //CargosDTO drv = ((CargosDTO)cbm.SelectedItem) ;
                if (drv != null)
                {
                    //  if (cmb.drv.CargoId > 0)
                    // {
                    this.dataGridView1.Rows[currentCell.RowIndex].Cells["Codigo"].Value = drv[0];
                    this.dataGridView1.Rows[currentCell.RowIndex].Cells["Parentid"].Value = this.textB1.Text;
                    if (this.dataGridView1.Rows[currentCell.RowIndex].Cells["subproductoid"].Value == null || this.dataGridView1.Rows[currentCell.RowIndex].Cells["subproductoid"].Value.ToString() == "")
                    {
                        this.dataGridView1.Rows[currentCell.RowIndex].Cells["subproductoid"].Value = -1;
                    }
                    if (this.dataGridView1.Rows[currentCell.RowIndex].Cells["Cantidad"].Value == null || this.dataGridView1.Rows[currentCell.RowIndex].Cells["Cantidad"].Value.ToString() == "")
                    {
                        this.dataGridView1.Rows[currentCell.RowIndex].Cells["Cantidad"].Value = 1;//cantidad
                        this.dataGridView1.EndEdit();
                    }
                    //          }
                }
            }
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string SubPid = e.Row.Cells["subproductoid"].Value.ToString();
            if (SubPid != "-1")
                borrados.Add(Convert.ToInt32(SubPid));
        }

        private void Panel2_Enter(object sender, EventArgs e)
        {

        }

        private void comboPlus2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((int)comboPlus2.SelectedValue) == 1)
            { textB6.Visible = true;
                textB7.Visible = true;
                comboPlus2.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label11.Visible = true;
            }
            else
            {
                textB6.Visible = false;
                textB7.Visible = false;
                comboPlus2.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label11.Visible = false;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
