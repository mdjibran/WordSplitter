using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordSplitter.CustomClasses;

namespace WordSplitter
{
    public partial class Form1 : Form
    {
        Summary summaryForm;

        public Form1()
        {
            InitializeComponent();
            SetFieldValuesDefault();
            summaryForm = new Summary();
            _btnRemoveName.Enabled = false;
            _btnAddFileName.Enabled = false;
        }

      
        private void SetFieldValuesDefault()
        {
            _chkBoxNamesList.Items.Add("Specs");
            _chkBoxNamesList.Items.Add("Claims");
            _chkBoxNamesList.Items.Add("Abstract");
            _chkBoxNamesList.Items.Add("ff");
            _txtPrefix.Text = "PROJNAME_";
            _txtSuffix.Text = "_SUFFIX";
            _txtSourceFile.Text = @"C:\Users\mjibran\Desktop\Pending\RPA\Code\C#\MVP\source.docx";
            _txtDestination.Text = @"C:\Users\mjibran\Desktop\Pending\RPA\Code\C#\MVP\output";
        }

        private void StartProcessing(object state)
        {
            string source = _txtSourceFile.Text;
            string destination = _txtDestination.Text;
            bool ifOpenFile = _chkOpenFile.Checked;
            bool isKeepNums = _chkKeepPageNums.Checked;
            bool canPDF = _chkSavePDF.Checked;

            if (Processing.ValidateForm(source, destination))
            {
                SplitByBookmark split = new SplitByBookmark();                
                List<string> Names = new List<string>();


                foreach (var item in _chkBoxNamesList.Items)
                {
                    Names.Add(item.ToString().Trim());
                }
                summaryForm.AddSummaryRow("File Names Read.");

                if (split.SplitDocument(_txtSourceFile.Text, _txtDestination.Text + "\\", Names, summaryForm, ifOpenFile, isKeepNums, canPDF))
                {
                    Process.Start(_txtDestination.Text);

                }

                summaryForm.CleanStage();
            }

            SetDisplay(false);
        }

        private void ToggleStates(bool visible)
        {            
            _lblProcessing.Visible = visible;
            _btnStart.Visible = !visible;
        }

        private bool CheckIfNameAlreadyAdded(string Name)
        {
            if (_chkBoxNamesList.Items.Contains(Name))
            {
                
                return true;
            }

            return false;
        }

        delegate void SetTextCallback(bool Visible);

        private void SetDisplay(bool Visible)
        {
            if (this._lblProcessing.InvokeRequired || this._btnStart.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetDisplay);
                this.Invoke(d, new object[] { Visible });
            }
            else
            {
                this._lblProcessing.Visible = Visible;
                this._btnStart.Visible = !Visible;
            }
        }


        #region MenuOptions
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help obj = new Help();
            obj.Show();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (summaryForm.IsDisposed)
                summaryForm = new Summary();
            
            string log = GlobalVariables.GetLogs();

            if (log != null)
            {
                summaryForm.SetPreviousLog(log);
                GlobalVariables.SaveLogs(null);

            }
            summaryForm.Show();
        }
        #endregion

        #region Events

        private void _btnStart_Click(object sender, EventArgs e)
        {
            ToggleStates(true);
            if (summaryForm.IsDisposed)
                summaryForm = new Summary();
            summaryForm.SetupStage();

            ThreadPool.QueueUserWorkItem(StartProcessing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // Filter by Word Documents
            dialog.Filter = "Word Documents|*.doc;*.docx";

            DialogResult result = dialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = dialog.FileName;
                _txtSourceFile.Text = file;
            }
        }

        private void _btnDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _txtDestination.Text = dialog.SelectedPath;

            }
        }

        private void _chkBoxNamesList_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (_chkBoxNamesList.CheckedItems.Count == 1 && e.NewValue == CheckState.Unchecked)
                _btnRemoveName.Enabled = false;
            else
                _btnRemoveName.Enabled = true;

        }

        private void _txtAddFileName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_txtAddFileName.Text))
                _btnAddFileName.Enabled = true;
            else
                _btnAddFileName.Enabled = false;
        }

        private void _txtAddFileName_Click(object sender, EventArgs e)
        {
            string prefix = _txtPrefix.Text;
            string suffix = _txtSuffix.Text;
            string name = _txtAddFileName.Text.Trim();

            if (!string.IsNullOrWhiteSpace(name))
            {

                string NewName = prefix + name + suffix;

                if (!CheckIfNameAlreadyAdded(NewName))
                {
                    _chkBoxNamesList.Items.Add(NewName);
                    _txtAddFileName.Text = "";
                }
                else
                {
                    ResponseBoxes.ShowMessageBox("FileName already exists.");
                }
            }
            else
            {
                ResponseBoxes.ShowMessageBox("Please add value.");
            }
        }

        private void _txtRemoveName_Click(object sender, EventArgs e)
        {
            for (int i = _chkBoxNamesList.Items.Count - 1; i >= 0; i--)
            {
                if (_chkBoxNamesList.GetItemChecked(i))
                {
                    _chkBoxNamesList.Items.Remove(_chkBoxNamesList.Items[i]);
                }
            }
            _btnRemoveName.Enabled = false;
        }

        #endregion
    }
}
