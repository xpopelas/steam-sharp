using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace steam_sharp.Forms
{
    public partial class AppFetcher : Form
    {
        private ApplicationDataClass _applicationData;

        private List<KeyValuePair<uint, string>> _currentDisplayData = new List<KeyValuePair<uint, string>>();
        private string _currentQuery;
        private int _currentIndex;
        private uint _selectedAppId = 0;
        
        private const int MaxItems = 50;
        public AppFetcher(ApplicationDataClass applicationData)
        {
            _applicationData = applicationData;
            InitializeComponent();
        }

        private void UpdateLabelText()
        {
            string labelText = String.Format("Found total of {0} result{1} for search term \"{2}\". " +
                                             "Displaying results {3}-{4}.",
                _currentDisplayData.Count, _currentDisplayData.Count != 1 ? "s" : "", _currentQuery,
                _currentIndex + 1, _currentIndex + MaxItems);
            searchInfoLabel1.Text = labelText;
            
            if (_selectedAppId != 0)
            {
                labelAppId.Text = @"Selected app with ID " + _selectedAppId;
            }
        }
        private void DisplayDataInGrid()
        {
            _selectedAppId = _currentDisplayData[_currentIndex].Key;
            UpdateLabelText();

            dataGridView1.Rows.Clear();
            
            for (int i = _currentIndex; i < _currentIndex + MaxItems && i < _currentDisplayData.Count; i++)
            {
                object[] toDisplay = {_currentDisplayData[i].Key.ToString(), _currentDisplayData[i].Value };
                dataGridView1.Rows.Add(toDisplay);
            }
        }

        private void UpdateSelection(int amount)
        {
            int prevIndex = _currentIndex;
            _currentIndex += amount;
            if (_currentIndex < 0)
            {
                _currentIndex = 0;
            }

            if (_currentIndex > _currentDisplayData.Count - MaxItems)
            {
                _currentIndex = _currentDisplayData.Count - MaxItems;
            }

            if (_currentIndex != prevIndex)
            {
                DisplayDataInGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedAppId = 0; // No app selected
            button2.Enabled = false;
            
            _currentQuery = textBox1.Text;
            _currentDisplayData = _applicationData
                .SearchForApps(_currentQuery)
                .Select(x => x)
                .ToList();
            _currentIndex = 0;

            DisplayDataInGrid();
        }

        private void gridSelectionDown_Click(object sender, EventArgs e)
        {
            UpdateSelection(-MaxItems);
        }

        private void gridSelectionUp_Click(object sender, EventArgs e)
        {
            UpdateSelection(MaxItems);
        }

        private void AppFetcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedAppId = _currentDisplayData[_currentIndex + dataGridView1.CurrentCell.RowIndex].Key;
            UpdateLabelText();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_selectedAppId != 0)
            {
                FormAppInfo appForm = new FormAppInfo(_applicationData, _selectedAppId);
                // Create new form
            }
        }
    }
}