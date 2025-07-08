using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea_Calculadora_Web

{

    public partial class Inicio : System.Web.UI.Page

         
   
        {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bresultado_Click(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);

            int Total = a + b;

            Txt3.Text = Total.ToString();
        }

        protected void btn_rest_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);

            int Total = a - b;

            Txt3.Text = Total.ToString(); // convertir el resultado a cadena
        }

        protected void btn_Mult_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);

            int Total = a * b;

            Txt3.Text = Total.ToString();
        }

        protected void btn_Div_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(Txt1.Text);
            double b = Convert.ToInt32(Txt2.Text);

            double Total = a / b;

            Txt3.Text = Total.ToString("0.00"); 
        }

        protected void btn_raiz_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(Txt1.Text);
            double raiz = Math.Sqrt(a);



            Txt3.Text = raiz.ToString("0.00"); 
        }

        protected void btn_poten2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);

            int potencia = 1;
            if (b == 0)
            {
                potencia = 1; 
            }
            else if (b == 1)
            {
                potencia = a; 
            }

            int exponente = b;
            if (b < 0)
            {
                exponente = -b; // Hacer el exponente positivo
            }
            int i = 1;
            while (i <= exponente)
            {
                potencia *= a;
                i++;
            }
          

            Txt3.Text = potencia.ToString();

        }

        protected void btn_poten3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);

            int potencia = 1;

            if (b == 0)
            {
                potencia = 1; // elevado a la 0 es = a 1
            }
            else if (b == 1)
            {
                potencia = a; // elevado a la 1 es = a si mismo
            }
            else
            {
                int exponente = b;
                if (b < 0)
                {
                    exponente = -b; 
                }
            int i = 1;
            while (i <= exponente)
            {
                potencia *= a;
                i++;
                }
            }

        }

        protected void btn_fact_Click(object sender, EventArgs e)
        {
            int factorial = 0, total = 1;
            factorial = Convert.ToInt32(Txt1.Text);
            for (int i = 1; i <= factorial; i++)
            {
                total *= i; 
            }

            Txt3.Text = total.ToString(); 
        }

        protected void btn_fibo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt1.Text) || string.IsNullOrEmpty(Txt2.Text))
            {
                MSJS.Text = "Por favor, ingrese valores válidos.";
                return; // Salir del método si los campos están vacíos
            }
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);
            int c = 0, d = 1, f = 0;

            for (int i = 0; i < a; i++)
            {
                f = c + d; 
                c = d; 
                d = f;
            }

            Txt3.Text = f.ToString(); 
        }

        protected void btn_Borrar_Click(object sender, EventArgs e)
        {
            Txt1.Text = "";
            Txt2.Text = "";
            Txt3.Text = ""; 
            MSJS.Text = ""; // Limpiar el mensaje de error o información
        }

        protected void MSJS_TextChanged(object sender, EventArgs e)
        {
            MSJS.Text = ""; // Limpiar el mensaje de error o información al cambiar el texto
    }

     
}
}