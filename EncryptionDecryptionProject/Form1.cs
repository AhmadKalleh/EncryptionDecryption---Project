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
using System.Drawing.Drawing2D;

namespace EncryptionDecryptionProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetRoundedCornersToForm()
        {
            int radius = 30; // نصف قطر الزوايا الدائرية
            GraphicsPath path = new GraphicsPath();

            // إضافة مستطيل بزوايا دائرية إلى المسار
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path); // تعيين المنطقة المحددة للمسار
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedCornersToForm(); // إعادة تعيين الزوايا عند تغيير حجم النموذج

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtDecryptedText.Text = "";
            txtDecryptedText.ForeColor =Color.Black;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

           
            Color color = Color.White;
            Pen pen = new Pen(color);

            pen.Width = 2;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 600, 20, 600, 700);
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtEncryptedText.Text = "";
            txtEncryptedText.ForeColor =Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

                     
            saveFileDialog1.InitialDirectory = @"سطح المكتب:\";
            saveFileDialog1.Title = "Save Text to File";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt | All files (*.*) | *.*";
            saveFileDialog1.FilterIndex = 2;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.WriteLine(lbTextDecrypted.Text);
                streamWriter.Close();
            }

            MessageBox.Show("Text Saved Successfully", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEncryptedText.Text = "Enter text encrypted or choose file encrypted";
            txtEncryptedText.ForeColor=Color.LightGray;
            btnSave.Enabled = false;
            lbTextDecrypted.Text = "";
          
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            txtDecryptedText.Text = "Enter text decrypted or choose file decrypted";
            txtDecryptedText.ForeColor = Color.LightGray;
            btnSave2.Enabled = false;
            lbOriginalText.Text = "";

        }

        private void btnSave2_Click(object sender, EventArgs e)
        {

            saveFileDialog1.InitialDirectory = @"سطح المكتب:\";
            saveFileDialog1.Title = "Save Text to File";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt | All files (*.*) | *.*";
            saveFileDialog1.FilterIndex = 2;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.WriteLine(lbOriginalText.Text);
                streamWriter.Close();
            }

            MessageBox.Show("Text Saved Successfully","Note",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openFileToGetTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Open File to get Text";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt | All files (*.*) | *.*";
            openFileDialog1.FilterIndex = 2;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                string line = "";
                while ((line=streamReader.ReadLine())!=null)
                {
                    txtEncryptedText.Text += line + Environment.NewLine;
                }

                streamReader.Close();
            }
        }

        private void openFileMenueStrip2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Open File to get Text";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt | All files (*.*) | *.*";
            openFileDialog1.FilterIndex = 2;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                string line = "";
                while ((line = streamReader.ReadLine()) != null)
                {
                    txtDecryptedText.Text += line + Environment.NewLine;
           
                }

                

                streamReader.Close();
            }
        }

        private bool ShowErrorMessage(TextBox textBox,String Text)
        {
            if (textBox.Text == Text)
            {
                MessageBox.Show("You should Enter Text", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; 
            }

            return false;   
        }
        private void btnEncryption_Click(object sender, EventArgs e)
        {

            if(ShowErrorMessage(txtEncryptedText, "Enter text encrypted or choose file encrypted"))
                return;

            btnSave.Enabled = true;

            String ans = "";
            for(int i=0;i<txtEncryptedText.Text.Length;i++)
            {
                if (txtEncryptedText.Text[i] == '\r')
                    continue;

                else if (txtEncryptedText.Text[i] == '\n')
                {
                    lbTextDecrypted.Text += ans + Environment.NewLine;
                    ans = "";
                    continue;
                }
                ans += Convert.ToChar(Convert.ToInt32(txtEncryptedText.Text[i])+2);
            }

            if(ans !="")
                lbTextDecrypted.Text += ans;


        }

        private void btnDecryption_Click(object sender, EventArgs e)
        {

            if (ShowErrorMessage(txtDecryptedText, "Enter text decrypted or choose file decrypted"))
                return;

            btnSave2.Enabled=true;

            String ans = "";

            for (int i = 0; i < txtDecryptedText.Text.Length; i++)
            {
                if (txtDecryptedText.Text[i] =='\r')
                    continue;
                else if (txtDecryptedText.Text[i]=='\n')
                {
                    lbOriginalText.Text += ans + Environment.NewLine;
                    ans = "";
                    continue;
                }

                ans += Convert.ToChar(Convert.ToInt32(txtDecryptedText.Text[i]) - 2);
            }

            if (ans != "")
                lbOriginalText.Text += ans;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnSave2.Enabled = false;

        }
    }
}
