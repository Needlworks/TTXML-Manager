using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TTXMLManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private struct Category
        {
            public string name;
            public int priority;
            public bool root;
        };
        private struct Post
        {
            public string title;
            public string category;
            public int id;
        };

        private string currentBgWork;
        private List<Category> categories;
        private List<Post> posts;

        private void frmMain_Load(object sender, EventArgs e)
        {
            categories = new List<Category>();
            posts = new List<Post>();
            currentBgWork = null;
        }

        private void tsbtnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Cancel)
                return;

            tsProgressBar.Visible = true;
            tsProgressBar.Maximum = 100;
            tsbtnOpen.Enabled = false;
            tsbtnSplit.Enabled = false;
            tsbtnCategory.Enabled = false;
            tsbtnAttachment.Enabled = false;

            categories.Clear();
            posts.Clear();
            lstCategories.Items.Clear();
            lstArticles.Items.Clear();
            lstAttachments.Items.Clear();

            currentBgWork = "scan";
            bgworkerScan.RunWorkerAsync(openFileDialog.FileName);
            tsbtnCancel.Visible = true;
        }

        private void tsbtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램 제작 : 태터네트워크재단 니들웍스 (TNF / Needlworks)\n" + 
                            "아이콘 디자인 : icons8.com", "프로그램 정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void readCategory(XmlReader reader, string categoryName = null)
        {
            Category cat = new Category();
            reader.ReadToDescendant("name");
            reader.ReadStartElement("name");
            if (categoryName == null)
                categoryName = reader.ReadContentAsString();
            else
                categoryName += "/" + reader.ReadContentAsString();
            cat.name = categoryName;
            reader.ReadEndElement();
            reader.ReadStartElement("priority");
            int.TryParse(reader.ReadContentAsString(), out cat.priority);
            reader.ReadEndElement();
            if (reader.IsStartElement() && reader.LocalName == "root")
            {
                reader.ReadStartElement("root");
                cat.root = (reader.ReadContentAsInt() == 1);
                reader.ReadEndElement();
            }
            categories.Add(cat);

            if (reader.IsStartElement() && reader.LocalName == "category")
            {
                // Recurse into subcategories.
                readCategory(reader, categoryName);
                // Consume the end tag.
                // (This is done automatically in the base case
                // to reflect end-tag to the tracked XML path.
                // See below.)
                reader.ReadEndElement();
            }
        }

        private void readPost(XmlReader reader)
        {

        }

        private void bgworkerScan_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string filename = e.Argument as string;
            FileStream stream = File.OpenRead(filename);
            ProgressStreamWrapper wrappedStream = new ProgressStreamWrapper(stream);
            wrappedStream.PositionChanged += (o, evarg) => worker.ReportProgress((int) ((double) wrappedStream.Position / wrappedStream.Length * 100));
            
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.CloseInput = true;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            XmlReader reader = XmlReader.Create(wrappedStream, settings);
            List<string> pathNames = new List<string>();

            while (reader.Read())
            {
                if (worker.CancellationPending)
                    break;
                if (reader.IsStartElement())
                {
                    pathNames.Add(reader.LocalName);
                    //System.Diagnostics.Debug.WriteLine("add depth: " + reader.LocalName);
                    string path = string.Join("/", pathNames);

                    if (path.StartsWith("blog/category"))
                    {
                        readCategory(reader);
                    }
                    else if (path.StartsWith("blog/post"))
                    {
                        readPost(reader);
                    }
                }
                if (reader.NodeType == XmlNodeType.EndElement)
                {
                    //System.Diagnostics.Debug.WriteLine("remove depth: " + reader.LocalName);
                    if (reader.LocalName != pathNames[pathNames.Count - 1])
                        throw new InvalidOperationException("invalid path manipulation?");
                    pathNames.RemoveAt(pathNames.Count - 1);
                }
            }
            reader.Close();
        }
        
        private void bgworkerScan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tsProgressBar.Value = e.ProgressPercentage;
        }

        private void bgworkerScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tsProgressBar.Visible = false;
            tsbtnCancel.Visible = false;
            tsbtnOpen.Enabled = true;
            currentBgWork = null;
            if (e.Cancelled)
            {
                categories.Clear();
                posts.Clear();
                return;
            }

            //categories.Sort((Category c1, Category c2) => c1.priority.CompareTo(c2.priority));
            var visibleCategories = from cat in categories where !cat.root select cat;
            foreach (Category cat in visibleCategories)
            {
                lstCategories.Items.Add(cat.name);
            }

            tsbtnCategory.Enabled = true;
            tsbtnAttachment.Enabled = true;
            tsbtnSplit.Enabled = true;
        }

        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            switch (currentBgWork)
            {
                case "scan":
                    bgworkerScan.CancelAsync();
                    break;
                default:
                    break;
            }
        }
    }
}
