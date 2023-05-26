using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace lr31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateProcessList();
        }
        private void PopulateProcessList()
        {
            processListView.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                processListView.Items.Add(item);
            }
        }
        private void viewProcessInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = processListView.SelectedItems[0];
                string processName = selectedItem.SubItems[0].Text;
                int processId = int.Parse(selectedItem.SubItems[1].Text);

                Process process = Process.GetProcessById(processId);
                string message = $"Process Name: {processName}\nProcess ID: {processId}\n";
                message += $"Start Time: {process.StartTime}\nTotal Processor Time: {process.TotalProcessorTime}\n";
                message += $"Physical Memory Usage: {process.WorkingSet64} bytes";

                MessageBox.Show(message, "Process Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void processListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (processListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void stopProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = processListView.SelectedItems[0];
                int processId = int.Parse(selectedItem.SubItems[1].Text);

                try
                {
                    Process process = Process.GetProcessById(processId);
                    process.Kill();
                    process.WaitForExit();

                    MessageBox.Show("Process stopped successfully.", "Process Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while stopping the process: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                PopulateProcessList();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateProcessList();
        }

        private void exportToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.Title = "Export Process List";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (ListViewItem item in processListView.Items)
                        {
                            writer.WriteLine($"{item.SubItems[0].Text}\t{item.SubItems[1].Text}");
                        }
                    }

                    MessageBox.Show("Process list exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while exporting the process list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void viewThreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = processListView.SelectedItems[0];
                int processId = int.Parse(selectedItem.SubItems[1].Text);

                Process process = Process.GetProcessById(processId);
                string message = $"Threads of Process: {process.ProcessName} (ID: {processId})\n\n";

                foreach (ProcessThread thread in process.Threads)
                {
                    message += $"Thread ID: {thread.Id}\tThread State: {thread.ThreadState}\n";
                }

                MessageBox.Show(message, "Process Threads", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void viewModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = processListView.SelectedItems[0];
                int processId = int.Parse(selectedItem.SubItems[1].Text);

                Process process = Process.GetProcessById(processId);
                string message = $"Modules of Process: {process.ProcessName} (ID: {processId})\n\n";

                foreach (ProcessModule module in process.Modules)
                {
                    message += $"Module Name: {module.ModuleName}\nModule File Name: {module.FileName}\n\n";
                }

                MessageBox.Show(message, "Process Modules", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
