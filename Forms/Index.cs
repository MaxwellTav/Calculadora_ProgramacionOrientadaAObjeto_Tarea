using System;
using System.Windows.Forms;

namespace Calculadora_ProgramacionOrientadaAObjeto_Tarea
{
    public partial class Index : Form
    {
        //Variables
        double
            saveVar1 = 0,
            saveVar2 = 0;

        bool 
            saveState1 = false,
            saveState2 = false;

        public Index()
        { InitializeComponent(); }

        private void Index_Load(object sender, EventArgs e)
        { SetApplication(); }

        private void SetApplication()
        { TitleForm_lbl.Text = Text; }

        #region Botones
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "¡Está saliendo de la aplicación!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        //Minimize
        private void Minimize_btn_Click(object sender, EventArgs e)
        { WindowState = FormWindowState.Minimized; }

        //Números
        private void Button1_btn_Click(object sender, EventArgs e)
        { PanelNumber.Text += 1; }

        private void Button2_btn_Click(object sender, EventArgs e)
        { PanelNumber.Text += 2; }

        private void Button3_btn_Click(object sender, EventArgs e)
        { PanelNumber.Text += 3; }

        private void Button4_btn_Click(object sender, EventArgs e)
        { PanelNumber.Text += 4; }

        private void Button5_btn_Click(object sender, EventArgs e)
        { PanelNumber.Text += 5; }

        private void Button6_btn_Click(object sender, EventArgs e)
        { PanelNumber.Text += 6; }

        private void Button7_btn_Click(object sender, EventArgs e)
        { PanelNumber.Text += 7; }

        private void Button8_btn_Click(object sender, EventArgs e)
        { PanelNumber.Text += 8; }

        private void Button9_btn_Click(object sender, EventArgs e)
        { PanelNumber.Text += 9; }

        private void ButtonDot_btn_Click(object sender, EventArgs e)
        { PanelNumber.Text += "."; }

        private void Button0_btn_Click(object sender, EventArgs e)
        { PanelNumber.Text += 0; }

        private void ButtonCE_btn_Click(object sender, EventArgs e)
        { PanelNumber.Text = string.Empty; saveVar1 = 0; saveVar2 = 0; saveState1 = false; saveState2 = false; }


        //Operación resta
        private void Minus_btn_Click(object sender, EventArgs e)
        { DoOperation(Classes.OperationEnum.Resta); }

        private void Multi_btn_Click(object sender, EventArgs e)
        { DoOperation(Classes.OperationEnum.Multiplicacion); }

        private void Divide_btn_Click(object sender, EventArgs e)
        { DoOperation(Classes.OperationEnum.Division); }

        //Operación suma
        private void Plus_btn_Click(object sender, EventArgs e)
        { DoOperation(Classes.OperationEnum.Suma); }

        #endregion

        //------------------------------Operacion en general------------------------------\\
        private void DoOperation(Classes.OperationEnum operationEnum)
        {
            Classes.Operation operation = new Classes.Operation();

            try
            {
                if (!saveState1 && !saveState2)
                {
                    saveVar1 = double.Parse(PanelNumber.Text);
                    PanelNumber.Text = string.Empty;
                    saveState1 = true;
                }
                else if (saveState1 && !saveState2)
                {
                    saveVar2 = double.Parse(PanelNumber.Text);
                    
                    switch (operationEnum)
                    {
                        case Classes.OperationEnum.Suma:
                            operation.DoOperation(saveVar1, saveVar2, Classes.OperationEnum.Suma);
                            break;

                        case Classes.OperationEnum.Resta:
                            operation.DoOperation(saveVar1, saveVar2, Classes.OperationEnum.Resta);
                            break;

                        case Classes.OperationEnum.Multiplicacion:
                            operation.DoOperation(saveVar1, saveVar2, Classes.OperationEnum.Multiplicacion);
                            break;

                        case Classes.OperationEnum.Division:
                            operation.DoOperation(saveVar1, saveVar2, Classes.OperationEnum.Division);
                            break;
                    }


                    PanelNumber.Text = operation.Result.ToString();
                    saveState1 = false;
                }

            }
            catch (Exception error) { MessageBox.Show("no se púdo procesar el proceso anterior\n\nDetalles del error:\n" + error.Message, "Error: " + error.HResult, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
