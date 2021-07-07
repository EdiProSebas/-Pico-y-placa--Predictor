using System;
using System.Windows.Forms;

namespace license_plate_number_Pico_y_Placa_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbxH_AM.Visible = false;
            cmbxH_PM.Visible = false;
            cmbxM_AM.Visible = false;
            cmbxM_PM.Visible = false;
            this.Calendar.ShowToday = false;
            this.Calendar.ShowTodayCircle = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String day = Calendar.SelectionStart.ToString("dddd");
            lblday.Text = day;
            String placa = textBox1.Text;
            placa.Trim();
            int length = placa.Length;
           String[] vector= { "0","0","0","0","0","0","0","0"};
            try
            {
                for (int i = 0; i < length; i++)
                {
                    vector[i] = placa.Substring(i, 1);
                }
                String LastDigit = vector[length - 1];

                Num_Not_Available(day, LastDigit);


            }
            catch (Exception )
            {

                MessageBox.Show("Invalid License Plate Number");
            }



        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Calendar.MaxSelectionCount = 1;

        }

        private void Num_Not_Available(String Day, String LastDigit)
        {
            int hora = 0;
            int minuto = 0;

            if (AMcheck.Checked == true)
            {
                 hora = Int32.Parse(cmbxH_AM.Text);
                 minuto = Convert.ToInt32(cmbxM_AM.Text);
            }
            else if(PMcheck.Checked == true)
            {
                 hora = Convert.ToInt32(cmbxH_PM.Text);
                 minuto = Convert.ToInt32(cmbxM_PM.Text);
            }

            


            switch (Day)
            {
                case "lunes":
                    if (LastDigit=="1" || LastDigit=="2")
                    {
                        MessageBox.Show("Your Vehicle has restrictions on Monday");
                        ResultadoFinal(hora, minuto);
                    }
                    else
                    {
                        MessageBox.Show("Your Vehicle has not restrictions on Monday");
                    }
                    break;
                case "martes":
                    if (LastDigit == "3" || LastDigit == "4")
                    {
                        MessageBox.Show("Your Vehicle has restrictions on Tuesday");
                        ResultadoFinal(hora, minuto);
                    }
                    else
                    {
                        MessageBox.Show("Your Vehicle has not restrictions on Tuesday");
                    }
                    break;
                case "miércoles":
                    if (LastDigit == "5" || LastDigit == "6")
                    {
                        MessageBox.Show("Your Vehicle has restrictions on Wednesday"); 
                        ResultadoFinal(hora, minuto);
                    }
                    else
                    {
                        MessageBox.Show("Your Vehicle has not restrictions on Wednesday");
                    }
                    break;
                case "jueves":
                    if (LastDigit == "7" || LastDigit == "8")
                    {
                        MessageBox.Show("Your Vehicle has restrictions on Thursday");
                        ResultadoFinal(hora, minuto);
                    }
                    else
                    {
                        MessageBox.Show("Your Vehicle has not restrictions on Thursday");
                    }
                    break;
                case "viernes":
                    if (LastDigit == "9" || LastDigit == "0")
                    {
                        MessageBox.Show("Your Vehicle has restrictions on Friday");
                        ResultadoFinal(hora, minuto);

                    }
                    else
                    {
                        MessageBox.Show("Your Vehicle has not restrictions on Friday");
                    }
                    break;
                default:
                    MessageBox.Show("on this day there is not restriction applied for any license plate number");
                    break;
            }
           
        }


        private void ResultadoFinal(int hora, int min)
        {
            while (hora>=0 )
            {
                if (hora >= 0 && min >= 0)
                {
                    if (hora >= 7 && hora <= 9)
                    {
                        if (hora == 9)
                        {
                            if (min >= 30)
                            {
                                MessageBox.Show("Your vehicle can be on the road at this time: (" + hora + ":" + min);
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Your vehicle can not be on the road at this time: (" + hora + ":" + min+")");
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your vehicle can not be on the road at this time: (" + hora + ":" + min + ")");
                            break;
                        }
                    }


                    if (hora == 16)
                    {
                        MessageBox.Show("Your vehicle can not be on the road at this time: (" + hora + ":" + min + ")");
                        break;
                    }

                    if (hora <= 19 && hora >= 0)
                    {
                        if (hora == 19)
                        {
                            if (min >= 30)
                            {
                                MessageBox.Show("Your vehicle can be on the road at this time: (" + hora + ":" + min + ")");
                                break;

                            }
                            else
                            {
                                MessageBox.Show("Your vehicle can not be on the road at this time: (" + hora + ":" + min + ")");
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your vehicle can be on the road at this time: (" + hora + ":" + min + ")");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Your vehicle can not be on the road at this time: (" + hora + ":" + min + ")");
                    break;
                }

            }
        }

        private void AMcheck_CheckedChanged(object sender, EventArgs e)
        {
            cmbxH_AM.Visible = true;
            cmbxM_AM.Visible = true;
            cmbxH_PM.Visible = false;
            cmbxM_PM.Visible = false;
            PMcheck.Visible = false;

        }

        private void PMcheck_CheckedChanged(object sender, EventArgs e)
        {
            cmbxH_AM.Visible = false;
            cmbxM_AM.Visible = false;
            cmbxH_PM.Visible = true;
            cmbxM_PM.Visible = true;
            AMcheck.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;

           if(AMcheck.Checked== true)
            {
                AMcheck.Checked = false;
                cmbxH_AM.Visible = false;
                cmbxM_AM.Visible = false;
                PMcheck.Visible = true;
            }
           if(PMcheck.Checked== true)
            {
                PMcheck.Checked = false;
                cmbxH_PM.Visible = false;
                cmbxM_PM.Visible = false;
                AMcheck.Visible = true;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
