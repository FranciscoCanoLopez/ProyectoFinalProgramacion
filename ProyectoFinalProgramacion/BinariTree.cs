using ProyectoFinalProgramacion.Classes_for_Binari_Trees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgramacion
{
    public partial class BinariTree : Form
    {
        private BinariTreeNode raiz = null!;
        public BinariTree()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NonLinearStructuresForm nonLinearStructuresForm = new NonLinearStructuresForm();
            nonLinearStructuresForm.Show();
            this.Close();
        }

        //binari tree methods

        private void AgregarNodo(int valor)
        {
            raiz = AgregarNodoRecursivo(raiz, valor);
            pnlArbol.Invalidate();  // Redibuja el panel para mostrar el árbol actualizado
        }

        private BinariTreeNode AgregarNodoRecursivo(BinariTreeNode raiz, int valor)
        {
            if (raiz == null)
            {
                return new BinariTreeNode(valor);
            }

            if (valor < raiz.Valor)
            {
                raiz.Izquierda = AgregarNodoRecursivo(raiz.Izquierda, valor);
            }
            else if (valor > raiz.Valor)
            {
                raiz.Derecha = AgregarNodoRecursivo(raiz.Derecha, valor);
            }

            return raiz;
        }

        private void RecorridoInorden(BinariTreeNode raiz, ref string resultado)
        {
            if (raiz != null)
            {
                RecorridoInorden(raiz.Izquierda, ref resultado);
                resultado += raiz.Valor + " ";
                RecorridoInorden(raiz.Derecha, ref resultado);
            }
        }

        private void RecorridoPreorden(BinariTreeNode raiz, ref string resultado)
        {
            if (raiz != null)
            {
                resultado += raiz.Valor + " ";
                RecorridoPreorden(raiz.Izquierda, ref resultado);
                RecorridoPreorden(raiz.Derecha, ref resultado);
            }
        }

        private void RecorridoPostorden(BinariTreeNode raiz, ref string resultado)
        {
            if (raiz != null)
            {
                RecorridoPostorden(raiz.Izquierda, ref resultado);
                RecorridoPostorden(raiz.Derecha, ref resultado);
                resultado += raiz.Valor + " ";
            }
        }
        // Método para dibujar el árbol binario
        private void pnlArbol_Paint(object sender, PaintEventArgs e)
        {
            if (raiz != null)
            {
                // Ajustar el tamaño del árbol al tamaño del panel
                int panelWidth = pnlArbol.Width;
                int panelHeight = pnlArbol.Height;

                // Ajustar la posición inicial y el espacio entre nodos de acuerdo al tamaño del panel
                int espacio = panelWidth / 4;  // Ajusta el espacio entre nodos basado en el ancho del panel
                int startX = panelWidth / 2;  // Empieza el dibujo del árbol en el centro del panel
                int startY = 30;  // Empieza un poco hacia abajo para que el árbol sea visible

                DibujarArbol(e.Graphics, raiz, startX, startY, espacio);
            }
        }

        private void DibujarArbol(Graphics g, BinariTreeNode nodo, int x, int y, int espacio)
        {
            if (nodo == null) return;

            // Dibuja el nodo
            g.FillEllipse(Brushes.LightBlue, x - 20, y - 20, 40, 40);
            g.DrawEllipse(Pens.Black, x - 20, y - 20, 40, 40);
            g.DrawString(nodo.Valor.ToString(), this.Font, Brushes.Black, x - 10, y - 10);

            // Dibuja las líneas hacia los nodos hijos
            if (nodo.Izquierda != null)
            {
                g.DrawLine(Pens.Black, x, y, x - espacio, y + 60);
                DibujarArbol(g, nodo.Izquierda, x - espacio, y + 60, espacio / 2);
            }
            if (nodo.Derecha != null)
            {
                g.DrawLine(Pens.Black, x, y, x + espacio, y + 60);
                DibujarArbol(g, nodo.Derecha, x + espacio, y + 60, espacio / 2);
            }
        }

        private void btnAgregarBinariTreeNode_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValorNodo.Text, out int valor))
            {
                AgregarNodo(valor);
                txtValorNodo.Clear();
                MessageBox.Show($"Nodo con valor {valor} agregado.");
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.");
            }
        }

        private void btnInorden_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            RecorridoInorden(raiz, ref resultado);
            // Mostrar el resultado en un MessageBox
            MessageBox.Show("Inorden: " + resultado, "Recorrido Inorden", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPreorden_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            RecorridoPreorden(raiz, ref resultado);
            // Mostrar el resultado en un MessageBox
            MessageBox.Show("Preorden: " + resultado, "Recorrido Preorden", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPostorden_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            RecorridoPostorden(raiz, ref resultado);
            // Mostrar el resultado en un MessageBox
            MessageBox.Show("Postorden: " + resultado, "Recorrido Postorden", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
