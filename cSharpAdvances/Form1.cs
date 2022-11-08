using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpAdvances
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delegate d = new Delegate();
            d.Run();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Event ev =new Event();
            Operate operate = new Operate();
            operate.Init();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Foreach f=new Foreach();
            f.RunMyItems();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Linq l = new Linq();
            l.Run1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExtensionMethods ex = new ExtensionMethods();
            ex.Run();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Check c = new Check();
            c.Run();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IsAs i=new IsAs();
            i.Run();    
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Idispose ids = new Idispose();
            ids.Run();  
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Genrices g=new Genrices();
            g.Run();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Type t=new Type();
            t.Run();
        }
    }
}
