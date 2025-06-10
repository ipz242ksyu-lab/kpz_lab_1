using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClassLibrary;
using ClassLibrary1;
using ClassLibrary2;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        List<MyFile> FileList;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileList = new List<MyFile>();
            listView.AllowDrop = true;
            listView.DragEnter += listView_DragEnter;
            listView.DragDrop += listView_DragDrop;
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string filename in openFileDialog.FileNames)
                        AddFile(filename);
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                var file = FileList[listView.SelectedItems[0].Index];
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.FileName = file.Name;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        file.Save(saveFileDialog.FileName);
                }
            }
            else
                MessageBox.Show("Виберіть 1 файл.");
        }

        private void ZippingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Zip archive (*.gzar)|*.gzar";
                    saveFileDialog.FileName = "archive.gzar";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        List<MyFile> filesToZip = new List<MyFile>();
                        foreach (ListViewItem item in listView.SelectedItems)
                            filesToZip.Add(FileList[item.Index]);

                        var zipped = ZippingUnzipping.Zipping(filesToZip, saveFileDialog.FileName);
                        AddFile(zipped);
                    }
                }
            }
            else
                MessageBox.Show("Виберіть файли для архівації.");
        }

        private void UnzippingToolStripMenuItem_Click(object sender, EventArgs e, MyFile file)
        {
            if (listView.SelectedItems.Count == 1)
            {
                MyFile myFile = FileList[listView.SelectedItems[0].Index];

                if (file.Name.EndsWith(".gzar"))
                {
                    List<string> unzippedFiles = ZippingUnzipping.Unzipping(file.Path);
                    foreach (var f in unzippedFiles)
                        AddFile(f);
                }
                else
                {
                    MessageBox.Show("Файл не є архівом .gzar");
                }
            }
            else
            {
                MessageBox.Show("Виберіть 1 файл.");
            }
        }

        private void EncodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView.SelectedItems)
            {
                var file = FileList[item.Index];
                var encoded = EncodingDecoding.Encoding(file);
                AddFile(encoded);
            }
        }

        private void DecodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView.SelectedItems)
            {
                var file = FileList[item.Index];
                if (file.Name.EndsWith(".crypt"))
                {
                    var decoded = EncodingDecoding.Decoding(file);
                    AddFile(decoded);
                }
                else
                    MessageBox.Show($"Файл {file.Name} не закодований.");
            }
        }

        private void AddFile(string path)
        {
            var file = new MyFile(path);
            FileList.Add(file);
            listView.Items.Add(new ListViewItem(new string[] { (listView.Items.Count + 1).ToString(), file.Name }));
        }

        private void AddFile(MyFile file)
        {
            FileList.Add(file);
            listView.Items.Add(new ListViewItem(new string[] { (listView.Items.Count + 1).ToString(), file.Name }));
        }

        private void listView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void listView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var path in files)
                    AddFile(path);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}