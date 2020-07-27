using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace PruebaFinal
{

    [TestClass]

    public class Pruebas
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        [TestMethod]

        [DataSource("System.Data.OleDB", @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=CasoPruebaProyectoFinal.xlsx;
            Extended Properties='Excel 12.0;HDR=yes';",
            "PruebaRegistrarUsuario$",
            DataAccessMethod.Sequential)]
        public void RegistroUsuarioPrueba()
        {



            string nombre, apellidos, correo, contraEsperada, contraActual;
            nombre = Convert.ToString(TestContext.DataRow["Nombre"]);
            apellidos = Convert.ToString(TestContext.DataRow["Apellidos"]);
            correo = Convert.ToString(TestContext.DataRow["correo"]);
            contraActual = Convert.ToString(TestContext.DataRow["contraActual"]);
            if (nombre != null && apellidos != null && correo != null)
            {

                contraEsperada = Convert.ToString(TestContext.DataRow["contraEsperada"]);
                Assert.AreEqual(contraEsperada, contraActual, "El registro de ususario se ha relizado correctamente");

            }

        }
        [TestMethod]

        [DataSource("System.Data.OleDB", @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=CasoPruebaProyectoFinal.xlsx;
            Extended Properties='Excel 12.0;HDR=yes';",
           "PruebaCorreoExistente$",
           DataAccessMethod.Sequential)]
        public void CorreoValidoPrueba()
        {



            string correoEmisorDigitado, correoEmisorValido, correoRecepetorDigitado, correoReceptorValido;
            correoEmisorDigitado = Convert.ToString(TestContext.DataRow["Correo Emisor Digitado"]);
            correoEmisorValido = Convert.ToString(TestContext.DataRow["Correo Emisor Valido"]);
            correoRecepetorDigitado = Convert.ToString(TestContext.DataRow["Correo Receptor Digitado"]);
            correoReceptorValido = Convert.ToString(TestContext.DataRow["Correo Receptor Valido"]);
            Assert.AreEqual(correoRecepetorDigitado, correoReceptorValido, "El correo receptor es valido");
            Assert.AreEqual(correoEmisorDigitado, correoEmisorValido, "El correo receptor es valido");


        }
        [TestMethod]

        [DataSource("System.Data.OleDB", @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=CasoPruebaProyectoFinal.xlsx;
            Extended Properties='Excel 12.0;HDR=yes';",
           "PruebaContraseñaValida$",
           DataAccessMethod.Sequential)]
        public void ContraseñaPrueba()
        {



            string contraDigita, contraValida;
            contraDigita = Convert.ToString(TestContext.DataRow["ContraseñaDigitada"]);
            contraValida = Convert.ToString(TestContext.DataRow["ContraseñaValida"]);


            Assert.AreEqual(contraDigita, contraValida, "El contraseña cumple con las politicas de seguridad");


        }

        //[TestMethod]

        //[DataSource("System.Data.OleDB", @"Provider=Microsoft.ACE.OLEDB.12.0;
        //    Data Source=CasoPruebaProyectoFinal.xlsx;
        //    Extended Properties='Excel 12.0;HDR=yes';",
        //   "PruebaPublicarTrabajoPrueb",
        //   DataAccessMethod.Sequential)]

        //public void PublicarTrabajoPrueba()
        //{

        //    string nombre, apellidos, correo, contraEsperada, contraActual;
        //    nombre = Convert.ToString(TestContext.DataRow["Nombre"]);
        //    apellidos = Convert.ToString(TestContext.DataRow["Apellidos"]);
        //    correo = Convert.ToString(TestContext.DataRow["correo"]);
        //    contraActual = Convert.ToString(TestContext.DataRow["contraActual"]);
        //    if (nombre != null && apellidos != null && correo != null)
        //    {

        //        contraEsperada = Convert.ToString(TestContext.DataRow["contraEsperada"]);
        //        Assert.AreEqual(contraEsperada, contraActual, "El registro de ususario se ha relizado correctamente");

        //    }



    
    }
}
