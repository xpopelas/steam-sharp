using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace steam_sharp
{
    public partial class AppFetcher : Form
    {
        private MasterClass _master;
        
        private Dictionary<uint, string> _currentDisplayData = new Dictionary<uint, string>();
        private string _currentQuery;
        private int _currentIndex;
        private const int MaxItems = 15;
        public AppFetcher(MasterClass master)
        {
            _master = master;
            InitializeComponent();
        }

        private void UpdateSearchLabelText()
        {
            string labelText = String.Format("Found total of {0} result{1} for search term \"{2}\". " +
                                             "Displaying results {3}-{4}.",
                _currentDisplayData.Count, _currentDisplayData.Count != 1 ? "s" : "", _currentQuery,
                _currentIndex + 1, _currentIndex + MaxItems);
            searchInfoLabel1.Text = labelText;
        }
        private void DisplayDataInGrid()
        {
            UpdateSearchLabelText();
            
            var data = _currentDisplayData
                .Select(x => new {k = x.Key.ToString(), v = x.Value})
                .ToArray();
            
            dataGridView1.Rows.Clear();
            
            for (int i = _currentIndex; i < _currentIndex + MaxItems && i < data.Length; i++)
            {
                string[] toDisplay = {data[i].k, data[i].v};
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

            if (_currentIndex >= _currentDisplayData.Count)
            {
                _currentIndex = _currentDisplayData.Count - 1;
            }

            if (_currentIndex != prevIndex)
            {
                DisplayDataInGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _currentQuery = textBox1.Text;
            _currentDisplayData = _master.SearchForApps(_currentQuery);
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
    }
}