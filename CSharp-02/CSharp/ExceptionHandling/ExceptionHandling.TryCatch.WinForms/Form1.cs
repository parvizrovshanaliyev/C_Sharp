using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandling.TryCatch.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            /*
             * eger burda adam textBoxlardan birini bos qoysa o zaman null deyer oldugundan bizde int istediyimizden xeta verecek
             */

            Sum();

            DivideByZeroException();
        }
        private void Sum()
        {
            try
            {
                int number1 = Convert.ToInt32(textBoxNumber1.Text);
                int number2 = Convert.ToInt32(textBoxNumber2.Text);

                int sum = number1 + number2;

                MessageBox.Show(sum.ToString());
            }
            catch (Exception exception)
            {
                #region v1

                MessageBox.Show("Deyer daxil etmemisiz");

                #endregion

                #region v2

                MessageBox.Show(exception.Message);

                #endregion
            }
            finally
            {
                MessageBox.Show("siz yoktunuz biz vardik yegen");
            }
        }
        private void DivideByZeroException()
        {
            try
            {
                int number1 = Convert.ToInt32(textBoxNumber1.Text);
                int number2 = Convert.ToInt32(textBoxNumber2.Text);

                int sum = number1 / number2;

                MessageBox.Show(sum.ToString());
            }
            catch (DivideByZeroException divideByZeroException)
            {
                MessageBox.Show(divideByZeroException.Message);

                #region v2

                throw new Exception("You can not divide any number to zero");

                #endregion
            }
            catch (Exception exception)
            {
                throw new Exception("please use only numbers");
            }
            finally
            {
                MessageBox.Show("Program finished");
            }
        }

        
    }
}
