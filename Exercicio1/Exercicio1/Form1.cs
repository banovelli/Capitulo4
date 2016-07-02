using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        int startMilieage;
        int endMileage;
        Double milesTraveled;
        double reimburserate = 0.39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startMilieage = (int) numericUpDown1.Value;
            endMileage = (int) numericUpDown2.Value;
            if(startMilieage <= endMileage){
                milesTraveled = endMileage - startMilieage;
                amountOwed = milesTraveled * reimburserate;
                label4.Text = "$"+amountOwed;
            }
            else{
                MessageBox.Show("A milha inical deve ser menor que a final",
                    "Não consigo calcular a milhagem");
            }
        }
    }
}
