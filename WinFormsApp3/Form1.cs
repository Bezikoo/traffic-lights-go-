using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)//≤ващенко √л≥б
        {
            panel1.Visible = true;
            Pen myPen = new Pen(Color.Gray, 3);
            Rectangle r = new Rectangle(20, 20, 50, 50);
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            g.DrawEllipse(myPen, r);
            SolidBrush myBrus = new SolidBrush(Color.Gray);
            Rectangle fr = new Rectangle(20, 20, 50, 50);
            Graphics fg = Graphics.FromHwnd(panel1.Handle);
            g.FillEllipse(myBrus, r);
            Pen myPent = new Pen(Color.Gray, 3);
            Rectangle tr = new Rectangle(20, 180 , 50, 50);
            Graphics tg = Graphics.FromHwnd(panel1.Handle);
            tg.DrawEllipse(myPent, tr);
            SolidBrush myBrust = new SolidBrush(Color.Gray);
            Rectangle gr = new Rectangle(20, 180, 50, 50);
            Graphics gg = Graphics.FromHwnd(panel1.Handle);
            tg.FillEllipse(myBrust, gr);
            Pen myPenw = new Pen(Color.Gray, 3);
            Rectangle wr = new Rectangle(20, 100, 50, 50);
            Graphics wg = Graphics.FromHwnd(panel1.Handle);
            Pen myPentt = new Pen(Color.Gray, 3);
            Rectangle ttr = new Rectangle(20, 100, 50, 50);
            Graphics ttg = Graphics.FromHwnd(panel1.Handle);
            ttg.DrawEllipse(myPentt, ttr);
            SolidBrush myBrustt = new SolidBrush(Color.Gray);
            Rectangle tfr = new Rectangle(20, 100, 50, 50);
            Graphics tfg = Graphics.FromHwnd(panel1.Handle);
            tfg.FillEllipse(myBrus, tfr);
        }

        private void button1_Click(object sender, EventArgs e)//≤ващенко √л≥б
        {
            SolidBrush myBrus = new SolidBrush(Color.Red);
            Rectangle rf = new Rectangle(20, 20, 50, 50);
            Graphics gf = Graphics.FromHwnd(panel1.Handle);
            gf.FillEllipse(myBrus, rf);
            Pen myPent = new Pen(Color.Gray, 3);
            SolidBrush myBrustt = new SolidBrush(Color.Gray);
            Rectangle tfr = new Rectangle(20, 100, 50, 50);
            Graphics tfg = Graphics.FromHwnd(panel1.Handle);
            tfg.FillEllipse(myBrustt, tfr);
            SolidBrush myBrust = new SolidBrush(Color.Gray);
            Rectangle gr = new Rectangle(20, 180, 50, 50);
            Graphics gg = Graphics.FromHwnd(panel1.Handle);
            gg.FillEllipse(myBrustt, gr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SolidBrush myBrust = new SolidBrush(Color.Yellow);
            Rectangle rt = new Rectangle(20, 100, 50, 50);
            Graphics gt = Graphics.FromHwnd(panel1.Handle);
            gt.FillEllipse(myBrust, rt);
            Pen myPent = new Pen(Color.Gray, 3);
            SolidBrush myBrustt = new SolidBrush(Color.Gray);
            Rectangle tfr = new Rectangle(20, 20, 50, 50);
            Graphics tfg = Graphics.FromHwnd(panel1.Handle);
            tfg.FillEllipse(myBrustt, tfr);
            Pen myPentf = new Pen(Color.Gray, 3);
            SolidBrush myBrusto = new SolidBrush(Color.Gray);
            Rectangle grot = new Rectangle(20, 180, 50, 50);
            Graphics ggf = Graphics.FromHwnd(panel1.Handle);
            ggf.FillEllipse(myBrusto, grot);
        }

        private void button3_Click(object sender, EventArgs e)//≤ващенко √л≥б
        {
            SolidBrush myBrugg = new SolidBrush(Color.Green);
            Rectangle rf = new Rectangle(20, 180, 50, 50);
            Graphics gf = Graphics.FromHwnd(panel1.Handle);
            gf.FillEllipse(myBrugg, rf);
            SolidBrush myBrus = new SolidBrush(Color.Gray);
            Rectangle rrr = new Rectangle(20, 100, 50, 50);
            Graphics ggg = Graphics.FromHwnd(panel1.Handle);
            ggg.FillEllipse(myBrus, rrr);
            SolidBrush myBrusj = new SolidBrush(Color.Gray);
            Rectangle frj = new Rectangle(20, 20, 50, 50);
            Graphics fg = Graphics.FromHwnd(panel1.Handle);
            fg.FillEllipse(myBrus, frj);
        }
    }
}
