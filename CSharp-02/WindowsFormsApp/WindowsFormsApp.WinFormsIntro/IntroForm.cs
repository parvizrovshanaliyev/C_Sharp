using System;
using System.Windows.Forms;

namespace WindowsFormsApp.WinFormsIntro
{
    #region Intro
    /*
     * WindowsFormsApp windows emeliyyat sistemi ucun
     * yaratdigimiz desktop apllication-lardir yanilmariq.
     *
     * ** ToolBox
     *    Bu pencerede ise evvelceden teyin edilmis tool-lar gosterilir, button textBox ve sair.
     * ** Properties
     *    Bu pencere vasitesile winforms-da istifade edilen her seyin agliniza gelecek butun ozelliklerini,
     *    redakte edeceyik.
     * ** The main entry point for the application. Program.cs
     *    Program cs evvelce oyrendiyimiz Console app-lerde oldugu kimi baslagic noqtesidir.
     *    Program cs Icerisindeki Application.Run(new Form()) proyekt run olan zaman hansi
     *    formun baslagic formu olaraq ise duseceyini teyin edir.
     * ** Inheritance : Form
     *    Yaradilan her bir Form class-i Forme ozeliklerini inheritance-la alir.
     *
     * ** InitializeComponent();
     *    her bir formun ctor-unda bu method gore bilersiz form daxilndeki ozellikler,
     *    toollar ,methodlar burada qeyd edilir.
     *
     * ** Click event
     * ** Show method
     * ** object sender
     * ** Form > layout start Position
     * ** FormBorderStyle
     * ** Focus> enter evneti
     *
     * ********
     * ** Bir formdayken diger Formun acilmasini temin et
     * ** Formun size-ni sabitle, bir formdan digerine data otur
     *
     */


    #endregion
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            string inputValue = textBox1.Text;

            Intro2Form intro2Form = new Intro2Form(inputValue);

            intro2Form.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox) sender;
            textBox.Text = string.Empty;
        }
    }
}
