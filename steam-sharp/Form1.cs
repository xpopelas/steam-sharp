using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steam_sharp
{
  public partial class Form1 : Form
  {
    private MasterClass _master;

    public Form1()
    {
      InitializeComponent();
            
      //MasterClass
      _master = new MasterClass("A6DE3C1CD7D350117B6A78D4DBE7A332");
      
      // AppFetcher
      _appFetcher = new AppFetcher(_master);
      _appFetcher.Owner = this;

    }

    private AppFetcher _appFetcher;

    private void button1_Click(object sender, EventArgs e)
    {
      _appFetcher.Show();
    }
  }
}
