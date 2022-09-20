using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Logic
{
    public class SmsBox
    {
        #region OkMessage
        /// <summary>
        /// Para el uso del MessageBox con 1 sólo botón con título.
        /// </summary>
        /// <param name="srtMessage">Mensaje enviado de la validación</param>
        /// <param name="strTitulo">Título enviado desde el código traído desde el formulario ubicado</param>
        public static void OkMessage(string srtMessage, string strTitulo)
        {
            MessageBox.Show(srtMessage
                ,strTitulo
                ,MessageBoxButtons.OK);
        }

        /// <summary>
        /// Para el uso del MessageBox de información con 1 sólo botón con título.
        /// </summary>
        /// <param name="srtMessage">Mensaje enviado de la validación</param>
        /// <param name="strTitulo">Título enviado desde el código traído desde el formulario ubicado</param>
        public static void OkMessageInfo(string srtMessage, string strTitulo)
        {
            MessageBox.Show(srtMessage
                , strTitulo
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information
                , MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Para el uso del MessageBox de Alerta con 1 sólo botón con título.
        /// </summary>
        /// <param name="srtMessage">Mensaje enviado de la validación</param>
        /// <param name="strTitulo">Título enviado desde el código traído desde el formulario ubicado</param>
        public static void OkMessageAlert(string srtMessage, string strTitulo)
        {
            MessageBox.Show(srtMessage
                , strTitulo
                , MessageBoxButtons.OK
                , MessageBoxIcon.Exclamation
                , MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Para el uso del MessageBox de Error con 1 sólo botón con título
        /// </summary>
        /// <param name="srtMessage">Mensaje enviado de la validación</param>
        /// <param name="strTitulo">Título enviado desde el código traído desde el formulario ubicado</param>
        public static void OkMessageError(string srtMessage, string strTitulo)
        {
            MessageBox.Show(srtMessage
                , strTitulo
                , MessageBoxButtons.OK
                , MessageBoxIcon.Error
                , MessageBoxDefaultButton.Button1);
        }
        #endregion
        #region YesNoMessage
        /// <summary>
        /// Para el uso del MessageBox con 2 botones para validación de usuario con título
        /// </summary>
        /// <param name="srtMessage">>Mensaje enviado de la validación</param>
        /// <param name="strTitulo">Título enviado desde el código traído desde el formulario ubicado</param>
        /// <returns>Regresa la elección el usuario</returns>
        public static bool YesNoMessage2Button(string srtMessage, string strTitulo)
        {
            DialogResult result = MessageBox.Show(srtMessage
                                                    , strTitulo
                                                    , MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Para el uso del MessageBox de Información con 2 botones para validación de usuario con título
        /// </summary>
        /// <param name="srtMessage">>Mensaje enviado de la validación</param>
        /// <param name="strTitulo">Título enviado desde el código traído desde el formulario ubicado</param>
        /// <returns>Regresa la elección el usuario</returns>
        public static bool YesNoMessage2ButtonInfo(string srtMessage, string strTitulo)
        {
            DialogResult result = MessageBox.Show(srtMessage
                                                    , strTitulo
                                                    , MessageBoxButtons.YesNo
                                                    , MessageBoxIcon.Information
                                                    , MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Para el uso del MessageBox de Alerta con 2 botones para validación de usuario con título
        /// </summary>
        /// <param name="srtMessage">>Mensaje enviado de la validación</param>
        /// <param name="strTitulo">Título enviado desde el código traído desde el formulario ubicado</param>
        /// <returns>Regresa la elección el usuario</returns>
        public static bool YesNoMessage2ButtonAlert(string srtMessage, string strTitulo)
        {
            DialogResult result = MessageBox.Show(srtMessage
                                                    , strTitulo
                                                    , MessageBoxButtons.YesNo
                                                    , MessageBoxIcon.Exclamation
                                                    , MessageBoxDefaultButton.Button1);
            if(result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}
