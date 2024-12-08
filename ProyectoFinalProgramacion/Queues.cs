using ProyectoFinalProgramacion.Class_for_queue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion
{
    public partial class Queues : Form
    {
        readonly SimpleVectorQueue simpleVectorQueue = new SimpleVectorQueue(5);
        readonly SimpleQueueList simpleQueueList = new SimpleQueueList();
        readonly CircularQueue circularQueue = new CircularQueue(5);
        readonly DoubleQueueVector doubleQueueVector = new DoubleQueueVector(5);
        readonly DoubleQueueList doubleQueueList = new DoubleQueueList();
        readonly PriorityQueueVectors priorityQueueVectors = new PriorityQueueVectors(5);
        readonly PriorityQueueVectorLists priorityQueueVectorLists = new PriorityQueueVectorLists(5);
        readonly PriorityQueueListVectors priorityQueueListVectors = new PriorityQueueListVectors(5);
        readonly PriorityQueueLists priorityQueueLists = new PriorityQueueLists(5);

        public Queues()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LinearStructuresForm linearStructuresForm = new LinearStructuresForm();
            linearStructuresForm.Show();
            this.Close();
        }

        //SimpleQueueVectoy

        private void btnEnqueueSimpleQueueVector_Click(object sender, EventArgs e)
        {
            try
            {
                int element = int.Parse(txtElementSimpleQueueVector.Text);
                simpleVectorQueue.Enqueue(element);
                UpdateSimpleQueueVectorDisplay();
                txtElementSimpleQueueVector.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDequeueSimpleQueueVector_Click(object sender, EventArgs e)
        {
            try
            {
                int element = simpleVectorQueue.Dequeue();
                MessageBox.Show($"Dequeued element: {element}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateSimpleQueueVectorDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateSimpleQueueVectorDisplay()
        {
            lstSimpleQueueVector.Items.Clear();
            foreach (var item in simpleVectorQueue.GetQueueElements())
            {
                lstSimpleQueueVector.Items.Add(item);
            }
        }
        private void btnShowSingleQueueVector_Click(object sender, EventArgs e)
        {
            try
            {
                int[] elements = simpleVectorQueue.GetQueueElements();
                if (elements.Length == 0)
                {
                    MessageBox.Show("The queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string elementsString = string.Join(", ", elements);
                    MessageBox.Show($"Queue Elements: {elementsString}", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Simple Queue List

        private void btnEnqueueSimpleQueueList_Click(object sender, EventArgs e)
        {
            try
            {
                int element = int.Parse(txtElementSimpleQueueList.Text);
                simpleQueueList.Enqueue(element);
                UpdateSimpleQueueListDisplay();
                txtElementSimpleQueueList.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDequeueSimpleQueueList_Click(object sender, EventArgs e)
        {
            try
            {
                int element = simpleQueueList.Dequeue();
                MessageBox.Show($"Dequeued element: {element}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateSimpleQueueListDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateSimpleQueueListDisplay()
        {
            lstSimpleQueueList.Items.Clear();
            foreach (var item in simpleQueueList.GetQueueElements())
            {
                lstSimpleQueueList.Items.Add(item);
            }
        }
        private void btnShowSimpleQueueList_Click(object sender, EventArgs e)
        {
            try
            {
                var elements = simpleQueueList.GetQueueElements();
                if (!elements.Any())
                {
                    MessageBox.Show("The queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string elementsString = string.Join(", ", elements);
                    MessageBox.Show($"Queue Elements: {elementsString}", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //circular queue
        private void btnEnqueueCircularQueue_Click(object sender, EventArgs e)
        {
            try
            {
                int element = int.Parse(txtElementCircularQueue.Text);
                circularQueue.Enqueue(element);
                UpdateCircularQueueDisplay();
                txtElementCircularQueue.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDequeueCircularQueue_Click(object sender, EventArgs e)
        {
            try
            {
                int element = circularQueue.Dequeue();
                MessageBox.Show($"Dequeued element: {element}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateCircularQueueDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShowElementsCircularQueue_Click(object sender, EventArgs e)
        {
            try
            {
                int[] elements = circularQueue.GetQueueElements();
                if (elements.Length == 0)
                {
                    MessageBox.Show("The queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string elementsString = string.Join(", ", elements);
                    MessageBox.Show($"Queue Elements: {elementsString}", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateCircularQueueDisplay()
        {
            lstCircularQueue.Items.Clear();
            foreach (var item in circularQueue.GetQueueElements())
            {
                lstCircularQueue.Items.Add(item);
            }
        }

        //Double Queue Vector

        private void btnInsertFrontDoubleQueueVector_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtElementDoubleQueueVector.Text);
                doubleQueueVector.InsertFront(value);
                UpdateDoubleDequeueVectorDisplay();
                txtElementDoubleQueueVector.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertRearDoubleQueueVector_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtElementDoubleQueueVector.Text);
                doubleQueueVector.InsertRear(value);
                UpdateDoubleDequeueVectorDisplay();
                txtElementDoubleQueueVector.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveFrontDoubleQueueVector_Click(object sender, EventArgs e)
        {
            try
            {
                int value = doubleQueueVector.RemoveFront();
                MessageBox.Show($"Removed from front: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDoubleDequeueVectorDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveRearDoubleQueueVector_Click(object sender, EventArgs e)
        {
            try
            {
                int value = doubleQueueVector.RemoveRear();
                MessageBox.Show($"Removed from rear: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDoubleDequeueVectorDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowDoubleQueueVector_Click(object sender, EventArgs e)
        {
            try
            {
                var elements = doubleQueueVector.GetDequeElements();
                if (!elements.Any())
                {
                    MessageBox.Show("Deque is empty.", "Deque Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string elementsString = string.Join(", ", elements);
                    MessageBox.Show($"Deque Elements: {elementsString}", "Deque Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDoubleDequeueVectorDisplay()
        {
            lstDoubleQueueVector.Items.Clear();
            foreach (var item in doubleQueueVector.GetDequeElements())
            {
                lstDoubleQueueVector.Items.Add(item);
            }
        }

        //Double Queue List

        private void btnInsertFrontDoubleQueueList_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtElementDoubleQueueList.Text);
                doubleQueueList.InsertFront(value);
                UpdateDoubleQueueListDisplay();
                txtElementDoubleQueueList.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertRearDoubleQueueList_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtElementDoubleQueueList.Text);
                doubleQueueList.InsertRear(value);
                UpdateDoubleQueueListDisplay();
                txtElementDoubleQueueList.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveFrontDoubleQueueList_Click(object sender, EventArgs e)
        {
            try
            {
                int value = doubleQueueList.RemoveFront();
                MessageBox.Show($"Removed from front: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDoubleQueueListDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveRearDoubleQueueList_Click(object sender, EventArgs e)
        {
            try
            {
                int value = doubleQueueList.RemoveRear();
                MessageBox.Show($"Removed from rear: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDoubleQueueListDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowDoubleQueueList_Click(object sender, EventArgs e)
        {
            try
            {
                var elements = doubleQueueList.GetDequeElements();
                if (!elements.Any())
                {
                    MessageBox.Show("Deque is empty.", "Deque Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string elementsString = string.Join(", ", elements);
                    MessageBox.Show($"Deque Elements: {elementsString}", "Deque Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDoubleQueueListDisplay()
        {
            lstDoubleQueueList.Items.Clear();
            foreach (var item in doubleQueueList.GetDequeElements())
            {
                lstDoubleQueueList.Items.Add(item);
            }
        }

        //Priority Queue Vectors of Vectors
        private void btnEnqueuePriorityQueueVV_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtElementPriorityQueueVV.Text);
                int priority = int.Parse(txtPriorityPriorityQueueVV.Text);
                priorityQueueVectors.Enqueue(value, priority);
                UpdatePriorityQueueVVDisplay();
                txtElementPriorityQueueVV.Clear();
                txtPriorityPriorityQueueVV.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDequeuePriorityQueueVV_Click(object sender, EventArgs e)
        {
            try
            {
                int value = priorityQueueVectors.Dequeue();
                MessageBox.Show($"Dequeued: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdatePriorityQueueVVDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowPriorityQueueVV_Click(object sender, EventArgs e)
        {
            try
            {
                var queueElements = priorityQueueVectors.GetQueueElements();
                lstPriorityQueueVV.Items.Clear();
                for (int i = 0; i < queueElements.Length; i++)
                {
                    if (queueElements[i].Count > 0)
                    {
                        string priorityElements = $"Priority {i}: {string.Join(", ", queueElements[i])}";
                        lstPriorityQueueVV.Items.Add(priorityElements);
                    }
                }

                if (lstPriorityQueueVV.Items.Count == 0)
                {
                    MessageBox.Show("Priority queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdatePriorityQueueVVDisplay()
        {
            lstPriorityQueueVV.Items.Clear();
            var queueElements = priorityQueueVectors.GetQueueElements();

            for (int i = 0; i < queueElements.Length; i++)
            {
                if (queueElements[i].Count > 0)
                {
                    string priorityElements = $"Priority {i}: {string.Join(", ", queueElements[i])}";
                    lstPriorityQueueVV.Items.Add(priorityElements);
                }
            }
        }

        //Priority Queue Vectors of Lists

        private void btnEnqueuePriorityQueueVL_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtElementPriorityQueueVL.Text);
                int priority = int.Parse(txtPriorityPriorityQueueVL.Text);
                priorityQueueVectorLists.Enqueue(value, priority);
                UpdateQueueDisplay();
                txtElementPriorityQueueVL.Clear();
                txtPriorityPriorityQueueVL.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDequeuePriorityQueueVL_Click(object sender, EventArgs e)
        {
            try
            {
                int value = priorityQueueVectorLists.Dequeue();
                MessageBox.Show($"Dequeued: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateQueueDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowPriorityQueueVL_Click(object sender, EventArgs e)
        {
            try
            {
                var queueElements = priorityQueueVectorLists.GetQueueElements();
                lstPriorityQueueVL.Items.Clear();
                for (int i = 0; i < queueElements.Count; i++)
                {
                    if (queueElements[i].Count > 0)
                    {
                        string priorityElements = $"Priority {i}: {string.Join(", ", queueElements[i])}";
                        lstPriorityQueueVL.Items.Add(priorityElements);
                    }
                }

                if (lstPriorityQueueVL.Items.Count == 0)
                {
                    MessageBox.Show("Priority queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateQueueDisplay()
        {
            lstPriorityQueueVL.Items.Clear();
            var queueElements = priorityQueueVectorLists.GetQueueElements();

            for (int i = 0; i < queueElements.Count; i++)
            {
                if (queueElements[i].Count > 0)
                {
                    string priorityElements = $"Priority {i}: {string.Join(", ", queueElements[i])}";
                    lstPriorityQueueVL.Items.Add(priorityElements);
                }
            }
        }

        //Priority Queue Lists of Lists

        private void btnEnqueuePriorityQueueLL_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtElementPriorityQueueLL.Text);
                int priority = int.Parse(txtPriorityPriorityQueueLL.Text);
                priorityQueueLists.Enqueue(value, priority);
                UpdatePriorityQueueLLDisplay();
                txtElementPriorityQueueLL.Clear();
                txtPriorityPriorityQueueLL.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDequeuePriorityQueueLL_Click(object sender, EventArgs e)
        {
            try
            {
                int value = priorityQueueLists.Dequeue();
                MessageBox.Show($"Dequeued: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdatePriorityQueueLLDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowPriorityQueueLL_Click(object sender, EventArgs e)
        {
            try
            {
                var queueElements = priorityQueueLists.GetQueueElements();
                lstPriorityQueueLL.Items.Clear();

                int priority = 0;
                foreach (var list in queueElements)
                {
                    if (list.Count > 0)
                    {
                        string priorityElements = $"Priority {priority}: {string.Join(", ", list)}";
                        lstPriorityQueueLL.Items.Add(priorityElements);
                    }
                    priority++;
                }

                if (lstPriorityQueueLL.Items.Count == 0)
                {
                    MessageBox.Show("Priority queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdatePriorityQueueLLDisplay()
        {
            lstPriorityQueueLL.Items.Clear();

            var queueElements = priorityQueueLists.GetQueueElements();
            int priority = 0;

            foreach (var list in queueElements)
            {
                if (list.Count > 0)
                {
                    string priorityElements = $"Priority {priority}: {string.Join(", ", list)}";
                    lstPriorityQueueLL.Items.Add(priorityElements);
                }
                priority++;
            }
        }

        //Priority Queue Lists of Vectors

        private void btnEnqueuePriorityQueueLV_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtElementPriorityQueueLV.Text);
                int priority = int.Parse(txtPriorityPriorityQueueLV.Text);
                priorityQueueListVectors.Enqueue(value, priority);
                UpdatePriorityQueueLVDisplay();
                txtElementPriorityQueueLV.Clear();
                txtPriorityPriorityQueueLV.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeququqPriorityQueueLV_Click(object sender, EventArgs e)
        {
            try
            {
                int value = priorityQueueListVectors.Dequeue();
                MessageBox.Show($"Dequeued: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdatePriorityQueueLVDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowPriorityQueueLV_Click(object sender, EventArgs e)
        {
            try
            {
                var queueElements = priorityQueueListVectors.GetQueueElements();
                lstPriorityQueueLV.Items.Clear();
                int priorityIndex = 0;  // Manually track the priority index

                foreach (var priorityList in queueElements)
                {
                    if (priorityList.Count <= 0)
                    {
                        continue;  // Skip empty priority lists
                    }

                    // Use the priorityIndex to show the correct priority level
                    string priorityElements = $"Priority {priorityIndex}: {string.Join(", ", priorityList)}";
                    lstPriorityQueueLV.Items.Add(priorityElements);
                    priorityIndex++;  // Increment the priority index
                }

                if (lstPriorityQueueLV.Items.Count == 0)
                {
                    MessageBox.Show("Priority queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdatePriorityQueueLVDisplay()
        {
            lstPriorityQueueLV.Items.Clear();
            var queueElements = priorityQueueListVectors.GetQueueElements();
            int priorityIndex = 0;

            foreach (var priorityList in queueElements)
            {
                if (priorityList.Count > 0)
                {
                    string priorityElements = $"Priority {priorityIndex}: {string.Join(", ", priorityList)}";
                    lstPriorityQueueLV.Items.Add(priorityElements);
                }
                priorityIndex++;
            }
        }
    }
}
