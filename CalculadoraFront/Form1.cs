using CalculadoraFront.Servicios;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculadoraFront
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
           // this.ActiveControl = null;

        }

        // Este método maneja el evento Click de los botones de la calculadora.
        // Realiza la función específica del botón y actualiza el contenido del TextBox.
        private void CommonButtonClick(object sender, EventArgs e) 
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;

            if (display.Text.Contains("Error.")) // Si el TextBox contiene "Error.", lo borra.
            {
                display.Text = string.Empty;
                mostrar.Text = string.Empty;
            }
            if (clickedButton.Name == "btnLimpiar") // Botón para limpiar el contenido del TextBox.
            {
                display.Text = string.Empty;
                mostrar.Text = string.Empty;
            }

            // Realiza acciones específicas para diferentes botones.
            else if (clickedButton.Name == "btn0")
            {
                display.Text += "0";
            }
            else if (clickedButton.Name == "btn1")
            {
                display.Text += "1";
            }
            else if (clickedButton.Name == "btn2")
            {
                display.Text += "2";
            }
            else if (clickedButton.Name == "btn3")
            {
                display.Text += "3";
            }
            else if (clickedButton.Name == "btn4")
            {
                display.Text += "4";
            }
            else if (clickedButton.Name == "btn5")
            {
                display.Text += "5";
            }
            else if (clickedButton.Name == "btn6")
            {
                display.Text += "6";
            }
            else if (clickedButton.Name == "btn7")
            {
                display.Text += "7";
            }
            else if (clickedButton.Name == "btn8")
            {
                display.Text += "8";
            }
            else if (clickedButton.Name == "btn9")
            {
                display.Text += "9";
            }
            else if (clickedButton.Name == "btn1")
            {
                display.Text += "1";
            }
            else if (clickedButton.Name == "btnParentesisAbrir")
            {
                display.Text += "(";
            }
            else if (clickedButton.Name == "btnParentesisCerrar")
            {
                display.Text += ")";
            }
            else if (clickedButton.Name == "btnMultiplicacion")
            {
                display.Text += "*";
            }
            else if (clickedButton.Name == "btnDivision")
            {
                display.Text += "/";
            }
            else if (clickedButton.Name == "btnSuma")
            {
                display.Text += "+";
            }
            else if (clickedButton.Name == "btnResta")
            {
                display.Text += "-";
            }
            else if (clickedButton.Name == "btnPunto")
            {
                display.Text += ",";
            }
            else if (clickedButton.Name == "btnCalcular") // Realiza el cálculo y actualiza el contenido del TextBox.
            {
                if (display.Text.Length > 0)
                {
                    Lector lector = new Lector();
                    String[] resultado = lector.Leer(display.Text);
                    display.Text = resultado[0];
                    mostrar.Text = resultado[1];
                }
            }
            else if (clickedButton.Name == "btnBorrar") // Elimina el último carácter del TextBox.
            {
                if (display.Text.Length > 0)
                {
                    display.Text = display.Text.Substring(0, display.Text.Length - 1);
                }
            }
        }

        // Este método maneja el evento KeyPress del formulario.
        // Permite ingresar datos en el TextBox mediante el teclado.
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Realiza acciones específicas según la tecla presionada.
            if (display.Text.Contains("Error."))
            {
                display.Text = string.Empty;
                mostrar.Text = string.Empty;
            }
            if (e.KeyChar == '0')
            {
                display.Text += "0";
            }
            if (e.KeyChar == '1')
            {
                display.Text += "1";
            }
            if (e.KeyChar == '2')
            {
                display.Text += "2";
            }
            if (e.KeyChar == '3')
            {
                display.Text += "3";
            }
            if (e.KeyChar == '4')
            {
                display.Text += "4";
            }
            if (e.KeyChar == '5')
            {
                display.Text += "5";
            }
            if (e.KeyChar == '6')
            {
                display.Text += "6";
            }
            if (e.KeyChar == '7')
            {
                display.Text += "7";
            }
            if (e.KeyChar == '8')
            {
                display.Text += "8";
            }
            if (e.KeyChar == '9')
            {
                display.Text += "9";
            }
            if (e.KeyChar == '.')
            {
                display.Text += ",";
            }
            if (e.KeyChar == ',')
            {
                display.Text += ",";
            }
            if (e.KeyChar == '+')
            {
                display.Text += "+";
            }
            if (e.KeyChar == '-')
            {
                display.Text += "-";
            }
            if (e.KeyChar == '*')
            {
                display.Text += "*";
            }
            if (e.KeyChar == '/')
            {
                display.Text += "/";
            }
            if (e.KeyChar == '(')
            {
                display.Text += "(";
            }
            if (e.KeyChar == ')')
            {
                display.Text += ")";
            }
            if (e.KeyChar == (char)Keys.Back) // Verifica si el TextBox no está vacío y elimina el último carácter.
            {
                // Verificar si el TextBox no está vacío
                if (display.Text.Length > 0)
                {
                    display.Text = display.Text.Substring(0, display.Text.Length - 1);
                }
            }
            if (e.KeyChar == (char)Keys.Enter) // Realiza un cálculo cuando se presiona "Enter" y actualiza el TextBox.
            {
                if (display.Text.Length > 0)
                {
                    Lector lector = new Lector();
                    String[] resultado = lector.Leer(display.Text);
                    display.Text = resultado[0];
                    mostrar.Text = resultado[1];
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e) // Este método se ejecuta cuando se carga el formulario y desactiva el enfoque.
        {
            this.ActiveControl = null;
        }
    }
}
