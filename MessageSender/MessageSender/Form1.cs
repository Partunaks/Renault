using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
//using System.Reflection;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.IO;
using System.Diagnostics;



namespace MessageSender
{
    public partial class AnalysisApp : Form
    {
        Excel.Application ObjExcel1;
        Excel.Worksheet ObjWorkSheet1;
        //Directory.GetFiles(@"","Analysis_old.xlsx",);
        String file = Path.GetFullPath("Analysis.xlsx");
        string [] status = {"Выдан/in use","На складе/in store","Доступен/Avaible","Зарезервирован/reserved","К отправке/to be returned","Не найден/not found","Сломан/broken"};
        string[] email = {"alexandre.timofeyev@renault.com"};
        public AnalysisApp()
        {
            InitializeComponent();
            StatusBox.Items.AddRange(status);
            emailbox.Items.AddRange(email);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SendMsg_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetData_Click(object sender, EventArgs e)
        {
            //String[] files;
          //files = Directory.GetFiles("","Analysis_old.xlsx",SearchOption.AllDirectories);
            ObjExcel1 = new Excel.Application
            {
                DisplayAlerts = false //Отключение предупреждений                                 
            };


            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel1.Workbooks.Open(file, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            ObjWorkSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range range = ObjWorkSheet1.get_Range("E:E").Find(PCName1.Text);
            try
            {
                SerialNum1.Text = ObjWorkSheet1.get_Range("D" + range.Row.ToString()).Value2;
                PCModel.Text = ObjWorkSheet1.get_Range("C" + range.Row.ToString()).Value2;
                IPN1.Text = ObjWorkSheet1.get_Range("L" + range.Row.ToString()).Value2;
            }

            catch (Exception)
            {

                MessageBox.Show("Ошибка\n" + "Проверьте введенное имя компьютера", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SendMsg.Enabled = true;
            ObjWorkBook = null;
            ObjExcel1 = null;
            ObjWorkSheet1 = null;
            GC.Collect();
            Process[] List;
            List = Process.GetProcessesByName("EXCEL");
            foreach (Process proc in List)
            {
                proc.Kill();
            }
            SendMsg.Enabled = true;
        }

        private void FindPC_Click(object sender, EventArgs e)
        {


            ObjExcel1 = new Excel.Application
            {
                DisplayAlerts = false //Отключение предупреждений                                 
            };

           // String[] files;
            //files = Directory.GetFiles(@"", "Analysis", SearchOption.AllDirectories);
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel1.Workbooks.Open(file, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            ObjWorkSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range range = ObjWorkSheet1.get_Range("E:E").Find(PCName2.Text);
            try
            {
                SerialNum2.Text = ObjWorkSheet1.get_Range("D" + range.Row.ToString()).Value2;
                PCModel2.Text = ObjWorkSheet1.get_Range("C" + range.Row.ToString()).Value2;
                IPN2.Text = ObjWorkSheet1.get_Range("L" + range.Row.ToString()).Value2;
                Building.Text = ObjWorkSheet1.get_Range("O" + range.Row.ToString()).Value2;
                //Room.Text = ObjWorkSheet1.get_Range("P" + range.Row.ToString()).Value2;
                StatusBox.Text = ObjWorkSheet1.get_Range("K" + range.Row.ToString()).Value;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Ошибка\n" + ex + "Проверьте введенное имя компьютера", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Accept.Enabled = true;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            try
            {
                //String[] files;
                //files = Directory.GetFiles(@"", "Analysis", SearchOption.AllDirectories);
                Microsoft.Office.Interop.Excel.Range range = ObjWorkSheet1.get_Range("E:E").Find(PCName2.Text);
                ObjWorkSheet1.get_Range("D" + range.Row.ToString()).Value2 = SerialNum2.Text;
                ObjWorkSheet1.get_Range("C" + range.Row.ToString()).Value2 = PCModel2.Text;
                ObjWorkSheet1.get_Range("L" + range.Row.ToString()).Value2 = IPN2.Text;
                ObjWorkSheet1.get_Range("O" + range.Row.ToString()).Value2 = Building.Text;
                //Room.Text = ObjWorkSheet1.get_Range("P" + range.Row.ToString()).Value;
                ObjWorkSheet1.get_Range("K" + range.Row.ToString()).Value = StatusBox.Text;
                ObjWorkSheet1.SaveAs(file);            
                ObjExcel1 = null;
                ObjWorkSheet1 = null;
                GC.Collect();
                Process[] List;
                List = Process.GetProcessesByName("EXCEL");
                foreach (Process proc in List)
                {
                    proc.Kill();
                }
                MessageBox.Show("Файл успешно сохранен!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PCName2.Text = "";
                PCModel2.Text = "";
                SerialNum2.Text = "";
                Building.Text = "";
                IPN2.Text = "";
                StatusBox.Text = "";
                Accept.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "\n" + "Невозможно сохранить файл");

            }
        }

        private void SendMsg_Click_1(object sender, EventArgs e)
        {
            if (UserName.Text == "")
            {

                MessageBox.Show("Введите Фамилию и Имя пользователя!");
                return;

            }
            try
            {
                Outlook._Application _app = new Outlook.Application();
                Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                mail.To = emailbox.Text;
                mail.Subject = "Выдан ноутбук" + " " + PCModel.Text + " " + UserName.Text;
                mail.Body = "Выдан ноутбук:" + UserName.Text + "\n" + "IPN пользователя:" + IPN1.Text + "\n\n\n\n" + "Имя компьютера:" + PCName1.Text + "\n" + "Серийный номер компьютера:" + SerialNum1.Text;
                mail.Importance = Outlook.OlImportance.olImportanceNormal;
                ((Outlook.MailItem)mail).Send();
                MessageBox.Show("Ваше сообщение отправлено!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            PCName1.Text = "";
            UserName.Text = "";
            SerialNum1.Text = "";
            PCModel.Text = "";
            IPN1.Text = "";
            SendMsg.Enabled = false;
            emailbox.Text = "";
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}