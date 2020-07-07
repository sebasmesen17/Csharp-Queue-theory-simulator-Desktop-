using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace TeoriaColas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            cargarCbx();
        
        }

        public void cargarCbx()
        {
            List<string> lista = new List<string>();
            lista.Insert(0, "Seleccione una");
            lista.Insert(1, "Segundos");
            lista.Insert(2, "Minutos");
            lista.Insert(3, "Horas");
            lista.Insert(4, "Días");
            cbUnidadMedida.DataSource = lista;
        }
       
        private void btnSimular_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (txtLambda.Text!="" && txtMiu.Text != "" && int.TryParse(txtLambda.Text, out temp)&& int.TryParse(txtMiu.Text, out temp) &&cbUnidadMedida.SelectedIndex!=0 && txtLambda.Text != "0" && txtMiu.Text != "0" )
            {
                if (Convert.ToDouble(txtLambda.Text) > Convert.ToDouble(txtMiu.Text) || txtLambda.Text== txtMiu.Text)
                {
                    string msj = "El valor de Lambda(λ) es menor que el de Miu(μ) o el valor de Lambda(λ) y Miu(μ) son iguales. favor verificar sus datos de entrada de nuevo";
                    MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    calcularL();
                    calcularLq();
                    calcularW();
                    calcularWq();
                    calcularP();
                    calcularPo();
                    calcularPnk();
                    btnEnviarCorreo.Enabled = true;
                    txtCorreo.Enabled = true;
                    dateTimeCalendar.Enabled = true;
                    txtLambda.Enabled = false;
                    txtMiu.Enabled = false;

                }
            }
            else
            {
                string msj = "Error en el sistema, las posibles causas son: \n1. Intenta introducir una letra por número. \n2. Está dejando campos de entradaen blanco. \n3. No ha seleccionado una unidad de medida de tiempo. \n4. Introdujo en el valor de Lambda(λ) o Miu(μ) un cero (0)"; MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcularPnk()//lambda/miu elevado a k+1
        {
            double lambda, miu, n1, n2, n3, n4, n5;
            lambda = Convert.ToDouble(txtLambda.Text);
            miu = Convert.ToDouble(txtMiu.Text);
            n1 = Math.Pow((lambda/miu), 0 + 1);
            txtn1.Text = Math.Round(n1, 3).ToString();

            n2 = Math.Pow((lambda/miu), 1 + 1);
            txtn2.Text = Math.Round(n2, 3).ToString();

            n3 = Math.Pow((lambda/miu), 2 + 1);
            txtn3.Text = Math.Round(n3, 3).ToString();

            n4 = Math.Pow((lambda/miu), 3 + 1);
            txtn4.Text = Math.Round(n4, 3).ToString();

            n5 = Math.Pow((lambda/miu), 4 + 1);
            txtn5.Text = Math.Round(n5, 3).ToString();

        }

        private void calcularPo()//1-lambda/miu
        {
            double lambda, miu, po;
            lambda = Convert.ToDouble(txtLambda.Text);
            miu = Convert.ToDouble(txtMiu.Text);
            po = 1-(lambda / miu);
            double resultado = 0;
            resultado = Math.Round(po, 2)*100;
            txtPo.Text = resultado.ToString()+"%";
        }

        private void calcularP()//lambda/miu
        {
            double lambda, miu, p;
            lambda = Convert.ToDouble(txtLambda.Text);
            miu = Convert.ToDouble(txtMiu.Text);
            p = lambda / miu;
            double resultado = 0;
            resultado=Math.Round(p, 2)*100;
            txtP.Text = resultado.ToString()+"%";
        }

        private void calcularWq()
        {
            double lambda, miu, wq;
            lambda = Convert.ToDouble(txtLambda.Text);
            miu = Convert.ToDouble(txtMiu.Text);
            wq =lambda / (miu * (miu - lambda));
            
            txtWq.Text = Math.Round(wq, 2).ToString() + " " + cbUnidadMedida.SelectedItem.ToString();
        }

        private void calcularW()
        {
            double lambda, miu, w;
            lambda = Convert.ToDouble(txtLambda.Text);
            miu = Convert.ToDouble(txtMiu.Text);
            w = 1 / (miu - lambda);
            
            txtW.Text = Math.Round(w, 2).ToString() + " " + cbUnidadMedida.SelectedItem.ToString();
        }

        private void calcularLq()// lambda al cuadrado /u(u-lambda)
        {
            double lambda, miu, lq;
            lambda = Convert.ToDouble(txtLambda.Text);
            miu = Convert.ToDouble(txtMiu.Text);
            lq = Math.Pow(lambda, 2)/(miu*(miu-lambda));
            
            txtLq.Text = Math.Round(lq, 2).ToString();
        }

        private void calcularL()//  L=landa/(miu-landa); 
        {
            double lambda, miu, l;
            lambda = Convert.ToDouble(txtLambda.Text);
            miu= Convert.ToDouble(txtMiu.Text);
            l = lambda/(miu - lambda);
            txtL.Text = Math.Round(l, 2).ToString();
        }

        private void limpiar()
        {
            btnEnviarCorreo.Enabled = false;
            txtL.Text = String.Empty;
            txtLq.Text = String.Empty;
            txtW.Text = String.Empty;
            txtWq.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            txtP.Text = String.Empty;
            txtPo.Text = String.Empty;
            txtn1.Text = String.Empty;
            txtn2.Text = String.Empty;
            txtn3.Text = String.Empty;
            txtn4.Text = String.Empty;
            txtn5.Text = String.Empty;
            txtLambda.Text = String.Empty;
            txtMiu.Text = String.Empty;
            btnEnviarCorreo.Enabled = false;
            txtCorreo.Enabled = false;
            dateTimeCalendar.Enabled = false;

            txtLambda.Enabled = true;
            txtMiu.Enabled = true;
        }
        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            Validacion validacion = new Validacion();
            if (validacion.IsValidEmail(txtCorreo.Text)==true)
            {
                DateTime iDate;
                iDate = dateTimeCalendar.Value;
                enviarVerificacion(txtCorreo.Text, iDate, Convert.ToDouble(txtL.Text), Convert.ToDouble(txtLq.Text), txtW.Text, txtWq.Text, txtP.Text.ToString(), txtPo.Text.ToString(), Convert.ToDouble(txtn1.Text), Convert.ToDouble(txtn2.Text), Convert.ToDouble(txtn3.Text), Convert.ToDouble(txtn4.Text), Convert.ToDouble(txtn5.Text));
            }
            else
            {
                txtCorreo.Text= String.Empty;
                MessageBox.Show("Correo Incorrecto, siga el formato: example@example.com", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        //metodo para enviar por correo
        public void enviarVerificacion(string correoUsuario, DateTime calendar, double l, double lq, string w, string Wq, string p, string Po, double p1, double p2, double p3, double p4, double p5)
        {
            try
            {
                //instancia un objeto MailMessage           
                MailMessage email = new MailMessage();

                //email.To.Add es para quien va dirigido
                email.To.Add(new MailAddress(correoUsuario));
                email.From = new MailAddress("teoriacolasmetodos2020@gmail.com");//Correo de salida
                email.Subject = "Reporte Simulación";//asunto del correo
                email.SubjectEncoding = Encoding.UTF8;//le damos formato UTF8

                email.Body = "<b>Reporte efectuado: " + calendar + " </b><br>" + " </b><br>" +
                    "<b>Número promedio de barcazas en el puerto (L): </b> " + l + " </b><br>" + " </b><br>" +
                    "<b>Barcazas en espera a ser atendidos(Lq): </b> " + lq + " </b><br>" + " </b><br>" +
                    "<b>Tiempo total de espera(W): </b> " + w + " </b><br>" + " </b><br>" +
                    "<b>Tiempo promedio de barcazas en la cola(Wq): </b> " + Wq + " </b><br>" + " </b><br>" +
                    "<b>Probabilidad de que el puerto se esté ocupando(P): </b> " + p + " </b><br>" + " </b><br>" +
                    "<b>Porcentaje de que nadie use el sistema(Po): </b> " + Po + " </b><br>" + " </b><br>" +
                    "<b>Probabilidad=1: </b> " + p1 + " </b><br>" + " </b><br>" +
                    "<b>Probabilidad=2: </b> " + p2 + " </b><br>" + " </b><br>" +
                    "<b>Probabilidad=3: </b> " + p3 + " </b><br>" + " </b><br>" +
                    "<b>Probabilidad=4: </b> " + p4 + " </b><br>" + " </b><br>" +
                    "<b>Probabilidad=5: </b> " + p5 + " </b><br>" + " </b><br>";
                email.BodyEncoding = Encoding.UTF8;//le damos formato UTF8
                email.IsBodyHtml = true;//cuerpo del mensaje en html           
                //email.Attachments.Add();
                email.Priority = MailPriority.Normal;

                /*---------------------------------------------------------------------------------------------------------------------*/
                var document = new Document();

                MemoryStream memoryStream = new MemoryStream();

                PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);

                document.Open();

                document.Add(new Paragraph("                      Simulación teoria de Colas - Metodos Cuantitativos 2020".ToUpper()));
                document.Add(new Paragraph("_____________________________________________________________________________"));
                document.Add(new Paragraph("   "));
                document.Add(new Paragraph("   "));
                document.Add(new Paragraph("Reporte efectuado: " + calendar));
                document.Add(new Paragraph("   "));
                document.Add(new Paragraph("Número promedio de barcazas en el puerto (L): " + l));
                document.Add(new Paragraph("   "));
                document.Add(new Paragraph("Barcazas en espera a ser atendidos(Lq): " + lq));
                document.Add(new Paragraph("   "));
                document.Add(new Paragraph("Tiempo total de espera(W): " + w));
                document.Add(new Paragraph("   "));
                document.Add(new Paragraph("Tiempo promedio de barcazas en la cola(Wq): " + Wq));
                document.Add(new Paragraph("   "));
                document.Add(new Paragraph("Probabilidad de que el puerto se esté ocupando(P): " + p));
                document.Add(new Paragraph("   "));
                document.Add(new Paragraph("Porcentaje de que nadie use el sistema(Po): " + Po));
                document.Add(new Paragraph("   "));
                document.Add(new Paragraph("   "));
                document.Add(new Paragraph("    Probabilidad Pn>k"));
                document.Add(new Paragraph("   "));
                document.Add(new Paragraph(" Probabilidad=1: " + p1));
                document.Add(new Paragraph(" Probabilidad=2: " + p2));
                document.Add(new Paragraph(" Probabilidad=3: " + p3));
                document.Add(new Paragraph(" Probabilidad=4: " + p4));
                document.Add(new Paragraph(" Probabilidad=5: " + p5));
                document.Add(new Paragraph("   "));
                document.Add(new Paragraph("                                      Muchas gracias por usar nuestra simulación.".ToUpper()));

                writer.CloseStream = false;

                document.Close();

                memoryStream.Position = 0;

                /*---------------------------------------------------------------------------------------------------------------------*/


                SmtpClient smtp = new SmtpClient();//Cliente correo
                smtp.Host = "smtp.gmail.com";// "smtp.office365.com"
                smtp.Port = 587;//Puerto de gmail (solo ese)
                smtp.EnableSsl = true;//Seguridad
                smtp.UseDefaultCredentials = false;
                string nombre = "ReportePuerto New Orleans: " + calendar + ".pdf";
                email.Attachments.Add(new Attachment(memoryStream, nombre));
                smtp.Credentials = new NetworkCredential("teoriacolasmetodos2020@gmail.com", "MetodosCuantitativos2020");//Credenciales del correo que envía mensajes

                //metodo para enviar el correo
                smtp.Send(email);//envía por correo
                email.Dispose();//libera memoria
                smtp.Dispose();//libera memoria
                               limpiar();
                MessageBox.Show("Reporte Enviando Correctamente", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
           
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }//end

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (Brush b = new SolidBrush(Color.FromArgb(168, panel1.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (Brush b = new SolidBrush(Color.FromArgb(168, panel1.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void datosGrupo_Click(object sender, EventArgs e)
        {
            string msj = "LOS INTEGRANTES DEL GRUPO SON:\n \n - Sebastian Mesén Arias B74769 \n - Geovanni Fernández Elizondo B72902 \n - Fabricio Vargas Alvarez B77976 \n - Josué Ruiz Castrillo B76860\n - Gabriel Mesén Trejos B24145 \n - Joseph Morales Silva B75211";

             MessageBox.Show(msj, "PROYECTO MÉTODOS CUANTITATIVO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
