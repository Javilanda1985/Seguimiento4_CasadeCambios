using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casa
{
    public partial class Form1 : Form
    {
        int dolar, euro, libra, peso, suma, valor, ven_total, comp_total, saldo;

        public void validar(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void guardar()
        {
            dolar1.Enabled = false;
            dolar2.Enabled = false;
            dolar3.Enabled = false;
            dolar4.Enabled = false;
            euro1.Enabled = false;
            euro2.Enabled = false;
            euro3.Enabled = false;
            euro4.Enabled = false;
            libra1.Enabled = false;
            libra2.Enabled = false;
            libra3.Enabled = false;
            libra4.Enabled = false;
            peso1.Enabled = false;
            peso2.Enabled = false;
            btnGuardar.Enabled = false;

            dolar4.Text = dolar1.Text;
            euro4.Text = euro1.Text;
            libra4.Text = libra1.Text;
            peso2.Text = peso1.Text;
        }

        public void operacion()
        {
            
                dolar = Convert.ToInt32(dolar4.Text);
                euro = Convert.ToInt32(euro4.Text);
                valor = Convert.ToInt32(cantidad.Text);
                libra = Convert.ToInt32(libra4.Text);
                peso = Convert.ToInt32(peso2.Text);
                //////////////////////DOLAR >> COMPRA////////////////////////////////////////////////////////
                if ((cbDivisa.SelectedIndex == 0) && (cbOperacion.SelectedIndex == 0))
                {
                    resultado.Text = " ";
                    comp_total = Convert.ToInt32(dolar2.Text) * valor;
                    if (peso >= comp_total)
                    {
                        saldo = (Convert.ToInt32(dolar4.Text) + Convert.ToInt32(cantidad.Text));
                        suma = Convert.ToInt32(peso2.Text) - comp_total;
                        dolar4.Text = Convert.ToString(saldo);
                        peso2.Text = Convert.ToString(suma);
                        resultado.Text += "Fecha: " + label1.Text + " Hora: " + label12.Text + " Compra: " + Convert.ToString(valor) + " dolares a " + dolar2.Text + ". Valor compra: " + Convert.ToString(comp_total) + " pesos";
                        MessageBox.Show("Transaccion realizada con exito" + "\n nuevo saldo de dolares: " + saldo + "\n nuevo saldo de pesos: " + suma, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Transaccion fallida, saldo insuficiente" + "\n Saldo disponible en pesos: " + peso, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if ((cbDivisa.SelectedIndex == 0) && (cbOperacion.SelectedIndex == 1))
                {
                    resultado.Text = " ";
                    if (dolar >= valor)
                    {
                        ven_total = Convert.ToInt32(dolar3.Text) * valor;
                        saldo = (Convert.ToInt32(dolar4.Text) - Convert.ToInt32(cantidad.Text));
                        suma = Convert.ToInt32(peso2.Text) + ven_total;
                        dolar4.Text = Convert.ToString(saldo);
                        peso2.Text = Convert.ToString(suma);
                        resultado.Text += "Fecha: " + label1.Text + " Hora: " + label12.Text + " Venta: " + Convert.ToString(valor) + " dolares a " + dolar3.Text + ". Valor venta: " + Convert.ToString(comp_total) + " pesos";
                        MessageBox.Show("Transaccion realizada con exito" + "\n nuevo saldo de dolares: " + saldo + "\n nuevo saldo de pesos: " + suma, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Transaccion fallida, saldo insuficiente" + "\n Saldo disponible en dolares: " + dolar + "\n saldo disponible en pesos: " + peso, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //////////////////////EURO >> COMPRA////////////////////////////////////////////////////////
                if ((cbDivisa.SelectedIndex == 1) && (cbOperacion.SelectedIndex == 0))
                {
                    resultado.Text = " ";
                    comp_total = Convert.ToInt32(euro2.Text) * valor;
                    if (peso >= comp_total)
                    {
                        saldo = (Convert.ToInt32(euro4.Text) + Convert.ToInt32(cantidad.Text));
                        suma = Convert.ToInt32(peso2.Text) - comp_total;
                        euro4.Text = Convert.ToString(saldo);
                        peso2.Text = Convert.ToString(suma);
                        resultado.Text += "Fecha: " + label1.Text + " Hora: " + label12.Text + " Compra: " + Convert.ToString(valor) + " euros a " + euro2.Text + ". Valor compra: " + Convert.ToString(comp_total) + " pesos";
                        MessageBox.Show("Transaccion realizada con exito" + "\n nuevo saldo de euros: " + saldo + "\n nuevo saldo de pesos: " + suma, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Transaccion fallida, saldo insuficiente" + "\n Saldo disponible en pesos: " + peso, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if ((cbDivisa.SelectedIndex == 1) && (cbOperacion.SelectedIndex == 1))
                {
                    resultado.Text = " ";
                    if (euro >= valor)
                    {
                        ven_total = Convert.ToInt32(euro3.Text) * valor;
                        saldo = (Convert.ToInt32(euro4.Text) - Convert.ToInt32(cantidad.Text));
                        suma = Convert.ToInt32(peso2.Text) + ven_total;
                        euro4.Text = Convert.ToString(saldo);
                        peso2.Text = Convert.ToString(suma);
                        resultado.Text += "Fecha: " + label1.Text + " Hora: " + label12.Text + " Venta: " + Convert.ToString(valor) + " euros a " + euro3.Text + ". Valor compra: " + Convert.ToString(comp_total) + " pesos";
                        MessageBox.Show("Transaccion realizada con exito" + "\n nuevo saldo de euros: " + saldo + "\n nuevo saldo de pesos: " + suma, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Transaccion fallida, saldo insuficiente" + "\n Saldo disponible en euros: " + euro + "\n saldo disponible en pesos: " + peso, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //////////////////////LIBRA >> COMPRA////////////////////////////////////////////////////////
                if ((cbDivisa.SelectedIndex == 2) && (cbOperacion.SelectedIndex == 0))
                {
                    resultado.Text = " ";
                    comp_total = Convert.ToInt32(libra2.Text) * valor;
                    if (peso >= comp_total)
                    {
                        resultado.Text = Convert.ToString(comp_total);
                        saldo = (Convert.ToInt32(libra4.Text) + Convert.ToInt32(cantidad.Text));
                        suma = Convert.ToInt32(peso2.Text) - comp_total;
                        libra4.Text = Convert.ToString(saldo);
                        peso2.Text = Convert.ToString(suma);
                        resultado.Text += "Fecha: " + label1.Text + " Hora: " + label12.Text + " Compra: " + Convert.ToString(valor) + " libras a " + libra2.Text + ". Valor compra: " + Convert.ToString(comp_total) + " pesos";
                        MessageBox.Show("Transaccion realizada con exito" + "\n nuevo saldo de libras esterlinas: " + saldo + "\n nuevo saldo de pesos: " + suma, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Transaccion fallida, saldo insuficiente" + "\n Saldo disponible en pesos: " + peso, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if ((cbDivisa.SelectedIndex == 2) && (cbOperacion.SelectedIndex == 1))
                {
                    resultado.Text = " ";
                    if (libra >= valor)
                    {
                        ven_total = Convert.ToInt32(libra3.Text) * valor;
                        resultado.Text = Convert.ToString(ven_total);
                        saldo = (Convert.ToInt32(libra4.Text) - Convert.ToInt32(cantidad.Text));
                        suma = Convert.ToInt32(peso2.Text) + ven_total;
                        libra4.Text = Convert.ToString(saldo);
                        peso2.Text = Convert.ToString(suma);
                        resultado.Text += "Fecha: " + label1.Text + " Hora: " + label12.Text + " Venta: " + Convert.ToString(valor) + " libras a " + libra3.Text + ". Valor compra: " + Convert.ToString(comp_total) + " pesos";
                        MessageBox.Show("Transaccion realizada con exito" + "\n nuevo saldo de libras esterlinas: " + saldo + "\n nuevo saldo de pesos: " + suma, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Transaccion fallida, saldo insuficiente" + "\n Saldo disponible en libras esterlinas: " + libra + "\n saldo disponible en pesos: " + peso, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
        }

        public Form1()
        {
            InitializeComponent();           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnoperacion_Click(object sender, EventArgs e)
        {
            operacion();
        }
        
        private void dolar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar(e);
        }

        private void dolar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar(e);
        }

        private void dolar3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar(e);
        }

        private void euro1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar(e);
        }

        private void euro2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar(e);
        }

        private void euro3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar(e);
        }

        private void libra1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar(e);
        }

        private void libra2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar(e);
        }

        private void libra3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar(e);
        }

        private void peso1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                guardar();
            }
        }

        private void cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                operacion();       
            }
        }

        private void cbDivisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
            label12.Text = DateTime.Now.ToShortTimeString(); 
        }

    }
}
