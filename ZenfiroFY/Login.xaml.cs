using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Logic;

namespace ZenfiroFY
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Click += BtnFunction;
            btnSalir.Click += BtnFunction;
        }

        private void BtnFunction(object sender, RoutedEventArgs e)
        {
            Button opcion = (Button)sender;
            switch (opcion.Name.ToLower())
            {
                case "btnlogin":
                    Validar(txtUsuario.Text, txtClave.Password);
                    break;
                case "btnsalir":
                    this.Close();
                    break;
            }
        }
        private bool Validar(string strUser, string strPass)
        {
            DateTime dtLogin = DateTime.Now;
            if (strUser == "")
            {
                txtUsuario.Focus();
                SmsBox.OkMessage("Debe indicar el usuario para poder ingresar, verifique e intente nuevamente.", this.Title);
                return false;
            }
            else if(strPass == "")
            {
                txtClave.Focus();
                SmsBox.OkMessage("Debe indicar la clave para poder ingresar, verifique e intente nuevamente.", this.Title);
                return false;
            }
            else
            {
                Encrypt encrypt = new Encrypt();
                string key = encrypt.strEncrypt(strPass);
                lblError.Visibility = Visibility.Visible;
            }
            return true;
        }
    }
}
