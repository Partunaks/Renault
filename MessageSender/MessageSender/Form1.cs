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
        public void clear()
        {
            ObjExcel1 = null;
            ObjWorkSheet1 = null;
            GC.Collect();
            Process[] List;
            List = Process.GetProcessesByName("EXCEL");
            foreach (Process proc in List)
            {
                proc.Kill();
            }

        }
        Excel.Application ObjExcel1;
        Excel.Worksheet ObjWorkSheet1;
        String file = Path.GetFullPath("Analysis.xlsx");
        string[] status = { "Выдан/in use", "На складе/in store", "Доступен/Avaible", "Зарезервирован/reserved", "К отправке/to be returned", "Не найден/not found", "Сломан/broken" };
        string[] email = { "alexandre.timofeyev@renault.com" };
        string[] building = {"B1","B2","B3","B4","BD","CLE","Шоколад","Metropole","Другое/other","HP","Учебный центр, Волгоградский, 42К5","Black&White","Жукова","K4","RN Bank"};
        public AnalysisApp()
        {
            InitializeComponent();
            StatusBox.Items.AddRange(status);
            emailbox.Items.AddRange(email);
            BuildingBox.Items.AddRange(building);

        }

        

        private void GetData_Click(object sender, EventArgs e)
        {
            
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
                return;
            }
            SendMsg.Enabled = true;
            clear();
            SendMsg.Enabled = true;
        }

        private void FindPC_Click(object sender, EventArgs e)
        {


            ObjExcel1 = new Excel.Application
            {
                DisplayAlerts = false //Отключение предупреждений                                 
            };

            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel1.Workbooks.Open(file, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            ObjWorkSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range range = ObjWorkSheet1.get_Range("E:E").Find(PCName2.Text);
            try
            {
                SerialNum2.Text = ObjWorkSheet1.get_Range("D" + range.Row.ToString()).Value2;
                PCModel2.Text = ObjWorkSheet1.get_Range("C" + range.Row.ToString()).Value2;
                IPN2.Text = ObjWorkSheet1.get_Range("L" + range.Row.ToString()).Value2;
                BuildingBox.Text = ObjWorkSheet1.get_Range("O" + range.Row.ToString()).Value2;
                Room.Text =Convert.ToString(ObjWorkSheet1.get_Range("P" + range.Row.ToString()).Value2);
                StatusBox.Text = ObjWorkSheet1.get_Range("K" + range.Row.ToString()).Value;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Ошибка\n" + "Проверьте введенное имя компьютера.Возможно компьютера нет в списке", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Accept.Enabled = true;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Range range = ObjWorkSheet1.get_Range("E:E").Find(PCName2.Text);
                ObjWorkSheet1.get_Range("D" + range.Row.ToString()).Value2 = SerialNum2.Text;
                ObjWorkSheet1.get_Range("C" + range.Row.ToString()).Value2 = PCModel2.Text;
                ObjWorkSheet1.get_Range("L" + range.Row.ToString()).Value2 = IPN2.Text;
                ObjWorkSheet1.get_Range("O" + range.Row.ToString()).Value2 = BuildingBox.Text;
                ObjWorkSheet1.get_Range("P" + range.Row.ToString()).Value = Room.Text;
                ObjWorkSheet1.get_Range("K" + range.Row.ToString()).Value = StatusBox.Text;
                ObjWorkSheet1.SaveAs(file);
                clear();
                MessageBox.Show("Файл успешно сохранен!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PCName2.Text = "";
                PCModel2.Text = "";
                SerialNum2.Text = "";
                BuildingBox.Text = "";
                IPN2.Text = "";
                Room.Text = "";
                StatusBox.Text = "";
                clear();
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
                mail.Body = "Выдан ноутбук:"+"  " + UserName.Text + "\n" + "IPN пользователя:" + "  " + IPN1.Text + "\n\n\n\n" + "Имя компьютера:" + "  " + PCName1.Text + "\n" + "Серийный номер компьютера:" + "  " + SerialNum1.Text+"\n"+"Модель компьютера:" + "  "+PCModel.Text;
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

        private void AnalysisApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            clear();
        }
    }
}