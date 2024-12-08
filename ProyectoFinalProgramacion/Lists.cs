using ProyectoFinalProgramacion.Classes_for_lists;
using ProyectoFinalProgramacion.Node_class_for_lists;
using ProyectoFinalProgramacion.Node_classes_for_lists;
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
    public partial class Lists : Form
    {
        LinkedList singlelist = new LinkedList();
        CircularsLists circularlist = new CircularsLists();
        private DoubleLinkedList doublelist = new DoubleLinkedList();
        DoubleCircularList dcll = new DoubleCircularList();
        public Lists()
        {
            InitializeComponent();
        } 

        private void btnBack_Click(object sender, EventArgs e)
        {
            LinearStructuresForm linearStructuresForm = new LinearStructuresForm();
            linearStructuresForm.Show();
            this.Close();
        }

        //SingleList

        private void btnAddSingleList_Click(object sender, EventArgs e)
        {
            if (singlelist.Contains(int.Parse(txtValue.Text)))
            {
                MessageBox.Show("Value already exists in the linked list");
                return;
            }
            //Add the value to the linked list
            SingleListNode singlelistnode = new SingleListNode(int.Parse(txtValue.Text), txtName.Text, txtPhoneNumber.Text, txtZipCode.Text);
            singlelist.Add(singlelistnode);//int.Parse(txtValue.Text));
                                           //Display the linked list in a message box
            MessageBox.Show(singlelist.ToString());
        }

        private void btnRemoveSingleList_Click(object sender, EventArgs e)
        {
            //if the value in txtValue exists in the linked list, remove it
            if (singlelist.Contains(int.Parse(txtValue.Text)))
            {
                singlelist.Remove(int.Parse(txtValue.Text));
                //Display the linked list in a message box
                MessageBox.Show(singlelist.ToString());
            }
            else
            {
                MessageBox.Show("Value does not exist in the linked list");
            }
        }

        private void btnContainsSingleList_Click(object sender, EventArgs e)
        {
            //if the value in txtValue exists in the linked list, display a message box
            if (singlelist.Contains(int.Parse(txtValue.Text)))
            {
                MessageBox.Show("Value exists in the linked list");
            }
            else
            {
                MessageBox.Show("Value does not exist in the linked list");
            }
        }

        private void btnCountSingleList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The linked list contains " + singlelist.Count() + " node(s)");
        }

        //CircularList

        private void UpdateListNodes()
        {
            lstNodes.Items.Clear();
            var nodes = circularlist.Display();
            foreach (var node in nodes)
            {
                lstNodes.Items.Add(node);
            }
        }
        private void btnAddCircularsLists_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValueCircularList.Text, out int value))
            {
                circularlist.Add(value);
                MessageBox.Show("Node added successfully!");
                txtValueCircularList.Clear();
                UpdateListNodes();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnRemoveCircularsLists_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValueCircularList.Text, out int value))
            {
                circularlist.Remove(value);
                txtValueCircularList.Clear();
                UpdateListNodes();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnContainsCircularsLists_Click(object sender, EventArgs e)
        {
            if (txtValueCircularList.Text == "")
            {
                MessageBox.Show("Enter a valid value");
            }
            else if (circularlist.Contains(int.Parse(txtValueCircularList.Text)))
            {
                MessageBox.Show("Value exists in the linked list");
            }
            else
            {
                MessageBox.Show("Value does not exist in the linked list");
            }
        }

        private void btnCountCircularsLists_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The linked list contains " + circularlist.Count() + " node(s)");
        }

        //DoubleList

        private void btnAggDoubleList_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDataDoubleList.Text, out int value))
            {
                doublelist.Add(value); // Agregar en orden numérico.
                UpdateDoubleLinkedListView(); // Actualizar el ListView.
                MessageBox.Show($"Se agregó {value} a la lista.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido y que sea entero");
            }
            txtDataDoubleList.Clear(); // Limpiar el TextBox.
        }

        private void btnDeleteDoubleList_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDataDoubleList.Text, out int value))
            {
                doublelist.Delete(value); // Eliminar el nodo con el valor.
                UpdateDoubleLinkedListView(); // Actualizar el ListView.
                MessageBox.Show($"Se eliminó {value} de la lista (si existía).");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido y que sea entero");
            }
            txtDataDoubleList.Clear(); // Limpiar el TextBox.
        }

        private void btnSearchDoubleList_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDataDoubleList.Text, out int value))
            {
                bool found = doublelist.Search(value); // Buscar el valor.
                if (found)
                    MessageBox.Show($"El número {value} se encuentra en la lista.");
                else
                    MessageBox.Show($"El número {value} no se encuentra en la lista.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido y que sea entero");
            }
            txtDataDoubleList.Clear(); // Limpiar el TextBox.
        }
        private void UpdateDoubleLinkedListView()
        {
            lvDisplayDoubleList.Items.Clear(); // Limpiar el ListView.
            DoubleLinkedListNode current = doublelist.GetHead(); // Obtener la cabeza de la lista.
            int position = 1; // Iniciar la posición desde 1.

            while (current != null)
            {
                // Crear un ítem de ListView con la posición como primer subitem.
                ListViewItem item = new ListViewItem(position.ToString());

                // Añadir el dato del nodo como segundo subitem.
                item.SubItems.Add(current.Data.ToString());

                // Agregar el ítem al ListView.
                lvDisplayDoubleList.Items.Add(item);

                // Avanzar al siguiente nodo.
                current = current.Next;
                position++;
            }
        }

        //DoubleCircularList
        private void btnAddDoubleCircularList_Click(object sender, EventArgs e)
        {
            if (dcll.Contains(int.Parse(txtNumberDoubleCircularList.Text)))
            {
                MessageBox.Show("The value already exists ");
                return;
            }
            DoubleCircularListNode node = new DoubleCircularListNode(int.Parse(txtNumberDoubleCircularList.Text));
            dcll.Add(node);
            MessageBox.Show(dcll.ToString());
        }

        private void btnRemoveDoubleCircularList_Click(object sender, EventArgs e)
        {
            if (dcll.Contains(int.Parse(txtNumberDoubleCircularList.Text)))
            {
                dcll.Remove(int.Parse(txtNumberDoubleCircularList.Text));
                MessageBox.Show(dcll.ToString());
            }

            else
            {
                MessageBox.Show("Value " + txtNumberDoubleCircularList.Text + " does not exist in the doubly circular linked list");
            }
        }

        private void btnContainsDoubleCircularList_Click(object sender, EventArgs e)
        {
            if (dcll.Contains(int.Parse(txtNumberDoubleCircularList.Text)))
            {
                MessageBox.Show("Value " + txtNumberDoubleCircularList.Text + " exists in the doubly circular linked list");
            }
            else
            {
                MessageBox.Show("Value " + txtNumberDoubleCircularList.Text + " does not exist in the doubly circular linked list");
            }
        }
    }
}
