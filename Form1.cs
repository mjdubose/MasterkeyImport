using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace MasterkeyImport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var result = OpenCSVDialog.ShowDialog();
            if (result != DialogResult.OK) return;
            var fileinfo = new FileInfo(OpenCSVDialog.FileName);


            using (var filestr = new FileStream(fileinfo.DirectoryName + "\\schema.ini",
                FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(filestr))
                {
                    //  1                      2        3        4                5              6        7       9       9     10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26   27   28     29 30
                    //"HPCSoft MasterKing","3/13/2015","Page 1","arooga test - 2","Key Symbol","Bitting","Qty","Comments","AB1","6","1","5","0","5","7","6"," "," "," "," "," "," "," "," "," ", " ", " ","0.00"," ",""
                    writer.WriteLine("[" + fileinfo.Name + "]");
                    writer.WriteLine("ColNameHeader=False");
                    writer.WriteLine("Format=CSVDelimited");
                    writer.WriteLine("DateTimeFormat=MM-dd-yy");
                    writer.WriteLine("Col1=Generated_By Text");
                    writer.WriteLine("Col2=Date Text");
                    writer.WriteLine("Col3=Page_Number Text");
                    writer.WriteLine("Col4=Keying_System_Name Text");
                    writer.WriteLine("Col5=Key_Symbol Text");
                    writer.WriteLine("Col6=Complete_Bitting Text");
                    writer.WriteLine("Col7=Qty Text");
                    writer.WriteLine("Col8=Comments Text");
                    writer.WriteLine("Col9=Complete_Key_Symbol Text");
                    writer.WriteLine("Col10=Bitting_1 Text");
                    writer.WriteLine("Col11=Bitting_2 Text");
                    writer.WriteLine("Col12=Bitting_3 Text");
                    writer.WriteLine("Col13=Bitting_4 Text");
                    writer.WriteLine("Col14=Bitting_5 Text");
                    writer.WriteLine("Col15=Bitting_6 Text");
                    writer.WriteLine("Col16=Bitting_7 Text");
                    writer.WriteLine("Col17=R Text");
                    writer.WriteLine("Col18=S Text");
                    writer.WriteLine("Col19=T Text");
                    writer.WriteLine("Col20=U Text");
                    writer.WriteLine("Col21=V Text");
                    writer.WriteLine("Col22=W Text");
                    writer.WriteLine("Col23=X Text");
                    writer.WriteLine("Col24=Y Text");
                    writer.WriteLine("Col25=Z Text");
                    writer.WriteLine("Col26=AA Text");
                    writer.WriteLine("Col27=AB Text");
                    writer.WriteLine("Col28=AC Text");
                    writer.WriteLine("Col29=AD Text");
                    writer.WriteLine("Col30=AE Text");
                    writer.Close();
                    writer.Dispose();
                }
                filestr.Close();
                filestr.Dispose();
            }



            string file = Path.GetFileName(OpenCSVDialog.FileName);
            string dir = Path.GetDirectoryName(OpenCSVDialog.FileName);

            string cStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir + ";"
                          + "Extended Properties='Text;HDR=No;FMT=Delimited';";
            string sqlStr = "SELECT * FROM [" + file + "]";
            var dt = new DataTable();
            try
            {
                var da = new OleDbDataAdapter(sqlStr, cStr);
                da.Fill(dt);
            }
            catch { dt = null; }


            dg_Convert.DataSource = dt;
        }
        private static void ExportDgvtoCsv(DataGridView dgv,FileSystemInfo fileInfo)
        {
            if (dgv.Columns.Count == 0) return;
            var myString = new StringBuilder();

            if (File.Exists(fileInfo.FullName))
            {
                File.Delete(fileInfo.FullName);
            }

            using (var sw = new StreamWriter(fileInfo.FullName, true))
            {

                // loop through each row of our DataGridView

                for (int i = 0; i < dgv.Rows.Count - 1; i++)
                {
                    var row = dgv.Rows[i];
                    for (int index = 0; index < row.Cells.Count; index++)
                    {


                        var cell = row.Cells[index];

                        myString.Append("\"" + cell.Value + "\"");
                        if (index != row.Cells.Count - 1)
                        {
                            myString.Append(",");
                        }
                    }
                    myString.Append(Environment.NewLine);
                }

                sw.Write(myString.ToString());
               
            }

            GC.Collect();
        }
        private void convertCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void OpenCSVDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = SaveFileDialog.ShowDialog();
            if (result != DialogResult.OK) return;
            var fileinfo = new FileInfo(SaveFileDialog.FileName);

            ExportDgvtoCsv(dg_Convert, fileinfo);
        }

       
    }
}
