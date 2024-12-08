using ProyectoFinalProgramacion.Classes_for_stacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion
{
    public partial class Stacks : Form
    {
        private StaticStack staticstack = new StaticStack();
        DynamicStack dynamicStack = new DynamicStack();
        public Stacks()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LinearStructuresForm linearStructuresForm = new LinearStructuresForm();
            linearStructuresForm.Show();
            this.Close();
        }

        //static stack

        private void btnPushStaticStack_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(txtInputStaticStack.Text);
                staticstack.Push(number);
                UpdateStaticStack();
                txtInputStaticStack.Clear();
            }
            catch
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void btnPopStaticStack_Click(object sender, EventArgs e)
        {
            MessageBox.Show(staticstack.Pop());
            UpdateStaticStack();
        }

        private void btnPeekStaticStack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elemento en el tope: " + staticstack.Peek());
        }

        private void btnSizeStaticStack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tamaño actual de la pila: " + staticstack.Size());
        }
        private void UpdateStaticStack()
        {
            lstStaticStack.Items.Clear();
            StaticStack temporal = new StaticStack();
            string elemento;

            // Mostrar los elementos en la pila
            while (!staticstack.IsEmpty())
            {
                elemento = staticstack.Pop();
                lstStaticStack.Items.Add(elemento);
                temporal.Push(int.Parse(elemento));
            }

            // Restaurar los elementos en la pila original
            while (!temporal.IsEmpty())
            {
                staticstack.Push(int.Parse(temporal.Pop()));
            }
        }

        //dynamicstack

        private void btnPushDynamicStack_Click(object sender, EventArgs e)
        {
            try
            {
                NodeStacks newNodeStacks = new NodeStacks(Convert.ToInt32(txtDataDynamicStack.Text));
                dynamicStack.Push(newNodeStacks);
                UpdateDynamicStack();
                txtDataDynamicStack.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void btnPopDynamicStack_Click(object sender, EventArgs e)
        {
            if (!dynamicStack.IsEmpty())
            {
                NodeStacks poppedNode = dynamicStack.Pop();
                UpdateDynamicStack();
                MessageBox.Show("Elemento eliminado: " + poppedNode.Data);
                return;
            }
            UpdateDynamicStack();
            MessageBox.Show("La pila está vacía.");
            return;
        }

        private void btnPeekDynamicStack_Click(object sender, EventArgs e)
        {
            NodeStacks topNode = dynamicStack.Peek();
            if (!dynamicStack.IsEmpty())
            {
                MessageBox.Show("Elemento en el top: " + topNode.Data);
                return;
            }
            MessageBox.Show("La pila está vacía.");
            return;
        }
        private void BtnSizeDynamicStack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hay " + dynamicStack.Size() + " elementos en la pila");
        }
        private void UpdateDynamicStack()
        {
            lstDynamicStack.Items.Clear(); // Limpia la lista antes de actualizar
            NodeStacks currentNode = dynamicStack.Peek(); // Asegúrate de que esto esté correctamente referenciado

            while (currentNode != null)
            {
                lstDynamicStack.Items.Add(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }
    }
}
